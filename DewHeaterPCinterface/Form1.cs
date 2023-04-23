using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading.Tasks;git
using System.Drawing;

namespace DewHeaterPCinterface
{
    public partial class DewHeaterController : Form
    {
        // data & commands
        string dataIn;                                                      // data received from arduino
        // Commands:    
        // to ARDUINO           rd=read from Arduino;   rc=close Arduino connection
        // to/from ARDUINO      md= mode;       mp= manual power;   mx= max power;      mt= mode threshold;
        // from ARDUINO         at= amb temp    ah=amb humidity;    ad=amd dewpoint;
        // from ARDUINO         ch = channel;   cm= channel mode;   ct= channel temp;   cd=channel dew point;    cp=channel power
        enum arduinoCommand { rd, md, mp, mx, mt, at, ah, ad, ch, cm, ct, cd, cp, rc };

        // parameters - mode, ambient data, channel data
        int[] modeParams = new int[4];                                      // mode params current for Arduino: 0=mode (see channelMode[]), 1=manual power, 2=max power level,  3=temp threshold (above ambient)
        int[] ambientParams = new int[3];                                   // ambient params from Arduino:     0=temp,                     1=humidity,     2=dew point
        int theCurrentChannel;                                              // the current channel being viewed or processed
        int[,] channelParams = new int[4, 3];                               // channel params: 3x channels, each with 0=temperature, 1=rel to dew point, 2=power
                                                                            // NB: all temps and dewpoints values are x10, eg 260=26.0 degrees)
        int[] channelMode = new int[4];                                     // channel modes: 0=OFF 1=MANUAL 2=AUTO-ambient 3=Auto-heaterSensor 4=OFF-cutoff
        string[] channelModeString = new string[] { "OFF", "MANUAL", "AUTO-ambient", "AUTO-heater", "CUTOFF" };
        int errorValue = -90;
        bool arduinoConnected;

        public DewHeaterController()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // serial COMS stuff
            string[] ports = SerialPort.GetPortNames();
            cBoxComPort.Items.AddRange(ports);
            serialPort1.WriteTimeout = 500;
            serialPort1.ReadTimeout = 500;
            arduinoConnected = false;

            // inital button/box enabling
            btnOpenPort.Enabled = true;
            btnClosePort.Enabled = false;
            gBoxSettings.Enabled = false;
            gBoxAmbient.Enabled = false;
            gBoxChan1.Enabled = false;
            gBoxChan2.Enabled = false;
            btnSetMode.Enabled = false;

            // label text
            lblAmbientTemp.Text = "Temp (" + (char)176 + "C)";
            lblAmbientDewPoint.Text = "Dew Point (" + (char)176 + "C)";
            lblChan1Temp.Text = "Temp (" + (char)176 + "C)";
            lblChan2Temp.Text = "Temp (" + (char)176 + "C)";
        }

        private void btnOpenComPort_Click(object sender, EventArgs e)
        {
            try
            {
                // open Arduino COM port
                serialPort1.PortName = cBoxComPort.Text;
                serialPort1.Open();
                lblComStatus.Text = "Waiting";

                // send "rd" command to Arduino to read all data
                sendArduinoCommand(arduinoCommand.rd.ToString() , 0);

                // alter open/close enabling
                btnClosePort.Enabled = true;
                btnOpenPort.Enabled = false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblComStatus.Text = "OFF";
            }
        }

        private void btnClosePort_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                // send "rc" command to Arduino to close connection
                sendArduinoCommand(arduinoCommand.rc.ToString(), 0);

                // close Arduino COM port
                serialPort1.Close();
                lblComStatus.Text = "OFF";

                // enable & disable boxes
                btnClosePort.Enabled = false;
                btnOpenPort.Enabled = true;
                gBoxSettings.Enabled = false;
                gBoxAmbient.Enabled = false;
                gBoxChan1.Enabled = false;
                gBoxChan2.Enabled = false;
                arduinoConnected = false;
            }
        }

        private void cBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            // changed the dew heater mode
            modeParams[0] = cBoxMode.SelectedIndex;
            btnSetMode.Enabled = true;
        }

        private void numBoxPwr_ValueChanged(object sender, EventArgs e)
        {
            // changed manual power level
            modeParams[1] = decimal.ToInt32(numBoxPwr.Value);
            if (modeParams[1] > modeParams[2])
            {
                modeParams[1] = modeParams[2];
            }
            btnSetMode.Enabled = true;
        }

        private void numBoxMaxPwr_ValueChanged(object sender, EventArgs e)
        {
            // changed max power setting
            modeParams[2] = decimal.ToInt32(numBoxMaxPwr.Value);
            if (modeParams[2] < modeParams[1])
            {
                modeParams[2] = modeParams[1];
            }
            btnSetMode.Enabled = true;
        }
        private void numBoxTempThresh_ValueChanged(object sender, EventArgs e)
        {
            // changed threshold for target heater temp
            modeParams[3] = decimal.ToInt32(numBoxTempThresh.Value);
            btnSetMode.Enabled = true;
        }

        private void btnSetMode_Click(object sender, EventArgs e)
        {
            if (btnSetMode.Enabled)
            {
                // send the MODE params to Arduino
                sendArduinoCommand(arduinoCommand.md.ToString(), modeParams[0]);
                sendArduinoCommand(arduinoCommand.mp.ToString(), modeParams[1]);
                sendArduinoCommand(arduinoCommand.mx.ToString(), modeParams[2]);
                sendArduinoCommand(arduinoCommand.mt.ToString(), modeParams[3]);

                btnSetMode.Enabled = false;
            }
        }

        private void sendArduinoCommand(string commandString , int commandValue)
        {
            string startCommandChar = ":";
            string endCommandChar = "#";
            string theCommandOut;
            theCommandOut = startCommandChar + commandString + commandValue.ToString() + endCommandChar;
            serialPort1.Write(theCommandOut);
            // a delay before sending the next command
            Task.Delay(200);
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIn = serialPort1.ReadLine();
            this.Invoke(new EventHandler(readArduinoCommand));
        }

        private void readArduinoCommand(object sender, EventArgs e)
        {
            string dataCommand;
            int dataCommandValue = 0;
            double dataCommandValueDouble = 0.0;

            // extract the data command received from Arduino and the command number associated with it
            dataCommand = dataIn.Substring(1,2);

            // perform the command received from Arduino.
            switch (Enum.Parse(typeof(arduinoCommand), dataCommand))
            {
                case arduinoCommand.rd:     // read from Arduino: mode
                    // dew heater recognised
                    lblComStatus.Text = "DewHeater connected";
                    arduinoConnected = true;
                    // enable group boxes if detected dew heater
                    gBoxSettings.Enabled = true;
                    gBoxAmbient.Enabled = true;
                    gBoxChan1.Enabled = true;
                    gBoxChan2.Enabled = true;
                    break;

                default:                    // if not the read command then get the value associated with it
                    dataCommandValue = Int32.Parse(dataIn.Substring(3));
                    break;
            }

            // IF the arduino is connected
            //  - can perform commands received from Arduino. NB: this does not include rd= read params form Arduino
            if (arduinoConnected)
            {
                switch (Enum.Parse(typeof(arduinoCommand), dataCommand))
                {
                    case arduinoCommand.md:     // read from Arduino: mode
                        modeParams[0] = dataCommandValue;
                        cBoxMode.SelectedIndex = dataCommandValue;
                        break;

                    case arduinoCommand.mp:     // read from Arduino: manual power
                        modeParams[1] = dataCommandValue;
                        numBoxPwr.Value = dataCommandValue;
                        break;

                    case arduinoCommand.mx:     // read from Arduino: maximum power level
                        modeParams[2] = dataCommandValue;
                        numBoxMaxPwr.Value = dataCommandValue;
                        break;

                    case arduinoCommand.mt:     // read from Arduino: target temperature
                        modeParams[3] = dataCommandValue;
                        numBoxTempThresh.Value = dataCommandValue;
                        break;

                    case arduinoCommand.at:     // read from Arduino: ambient temp
                        ambientParams[0] = dataCommandValue;
                        dataCommandValueDouble = Convert.ToDouble(dataCommandValue) / 10;     // display to one decimal place
                        if (dataCommandValueDouble != errorValue)
                        {
                            tBoxAmbientTemp.Text = dataCommandValueDouble.ToString("F1");
                            tBoxAmbientTemp.ForeColor = Color.Black;
                        }
                        else
                        {
                            tBoxAmbientTemp.Text = "--";
                            tBoxAmbientTemp.ForeColor = Color.Red;
                        }
                        break;

                    case arduinoCommand.ah:     // read from Arduino: ambient humidity
                        ambientParams[1] = dataCommandValue;
                        dataCommandValueDouble = Convert.ToDouble(dataCommandValue);
                        if (dataCommandValueDouble != errorValue)
                        {
                            tBoxAmbientHumidity.Text = dataCommandValueDouble.ToString("F1");
                            tBoxAmbientHumidity.ForeColor = Color.Black;
                        }
                        else
                        {
                            tBoxAmbientHumidity.Text = "----";
                            tBoxAmbientHumidity.ForeColor = Color.Red;
                        }
                        break;

                    case arduinoCommand.ad:     // read from Arduino: ambient dew point
                        ambientParams[2] = dataCommandValue;
                        dataCommandValueDouble = Convert.ToDouble(dataCommandValue) / 10;
                        if (dataCommandValueDouble != errorValue)
                        {
                            tBoxAmbientDewPoint.Text = dataCommandValueDouble.ToString("F1");
                            tBoxAmbientDewPoint.ForeColor = Color.Black;
                        }
                        else
                        {
                            tBoxAmbientDewPoint.Text = "----";
                            tBoxAmbientDewPoint.ForeColor = Color.Red;
                        }
                        break;

                    case arduinoCommand.ch:     // read from Arduino: the current channel
                        theCurrentChannel = dataCommandValue;
                        break;

                    case arduinoCommand.cm:     // read from Arduino: the current channel mode
                        channelMode[theCurrentChannel] = dataCommandValue;
                        switch (theCurrentChannel)
                        {
                            // display for the relevant channel
                            case 0:
                                tBoxChan1Mode.Text = channelModeString[dataCommandValue];
                                break;
                            case 1:
                                tBoxChan2Mode.Text = channelModeString[dataCommandValue];
                                break;
                            case 9:
                                break;
                        }
                        break;

                    case arduinoCommand.ct:     // read from Arduino: the current channel heater temp
                        channelParams[theCurrentChannel, 0] = dataCommandValue;
                        dataCommandValueDouble = Convert.ToDouble(dataCommandValue) / 10;
                        switch (theCurrentChannel)
                        {
                            // display for the relevant channel
                            case 0:
                                if (dataCommandValueDouble != errorValue)
                                {
                                    tBoxChan1Temp.Text = dataCommandValueDouble.ToString("F1");
                                    tBoxChan1Temp.ForeColor = Color.Black;
                                }
                                else
                                {
                                    tBoxChan1Temp.Text = "----";
                                    tBoxChan1Temp.ForeColor = Color.Red;
                                }
                                break;
                            case 1:
                                if (dataCommandValueDouble != errorValue)
                                {
                                    tBoxChan2Temp.Text = dataCommandValueDouble.ToString("F1");
                                    tBoxChan2Temp.ForeColor = Color.Black;
                                }
                                else
                                {
                                    tBoxChan2Temp.Text = "----";
                                    tBoxChan2Temp.ForeColor = Color.Red;
                                }
                                break;
                        }
                        break;

                    case arduinoCommand.cd:     // read from Arduino: the current channel heater temp relative to dew point
                        channelParams[theCurrentChannel, 1] = dataCommandValue;
                        dataCommandValueDouble = Convert.ToDouble(dataCommandValue) / 10;
                        switch (theCurrentChannel)
                        {
/*                            // display for the relevant channel
                            case 0:
                                if (dataCommandValueDouble != errorValue)
                                {
                                    tBoxChan1RelDP.Text = dataCommandValueDouble.ToString("F1");
                                    tBoxChan1RelDP.ForeColor = Color.Black;
                                }
                                else
                                {
                                    tBoxChan1RelDP.Text = "----";
                                    tBoxChan1RelDP.ForeColor = Color.Red;
                                }
                                break;
                            case 1:
                                if (dataCommandValueDouble != errorValue)
                                {
                                    tBoxChan2RelDP.Text = dataCommandValueDouble.ToString("F1");
                                    tBoxChan2RelDP.ForeColor = Color.Black;
                                }
                                else
                                {
                                    tBoxChan2RelDP.Text = "----";
                                    tBoxChan2RelDP.ForeColor = Color.Red;
                                }
                                break; */
                        }
                        break;

                    case arduinoCommand.cp:     // read from Arduino: the current channel heater power
                        string theText;
                        
                        channelParams[theCurrentChannel, 2] = dataCommandValue;
                        if (dataCommandValue > 0)
                        {
                            theText = "Heater ";
                            theText += dataCommandValue.ToString();
                            theText += "%";
                        }
                        else
                        {
                            theText = "Heater OFF";
                        }

                        switch (theCurrentChannel)
                        {
                            // display for the relevant channel
                            case 0:
                                pBarChan1Power.Value = dataCommandValue;                        // the value from 0-100%
                                lblChan1Status.Text = theText;
                                break;
                            case 1:
                                pBarChan2Power.Value = dataCommandValue;
                                lblChan2Status.Text = theText;
                                break;
                        }
                        break;

                    default:                    // if any other command, do nothing
                        break;
                }

            }
        }
    }
}
