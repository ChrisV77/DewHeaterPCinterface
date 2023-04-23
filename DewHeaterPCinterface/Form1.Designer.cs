namespace DewHeaterPCinterface
{
    partial class DewHeaterController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cBoxComPort = new System.Windows.Forms.ComboBox();
            this.lblComPort = new System.Windows.Forms.Label();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.btnClosePort = new System.Windows.Forms.Button();
            this.gBoxSerialCm = new System.Windows.Forms.GroupBox();
            this.lblComStatus = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.gBoxAmbient = new System.Windows.Forms.GroupBox();
            this.tBoxAmbientDewPoint = new System.Windows.Forms.TextBox();
            this.tBoxAmbientHumidity = new System.Windows.Forms.TextBox();
            this.tBoxAmbientTemp = new System.Windows.Forms.TextBox();
            this.lblAmbientDewPoint = new System.Windows.Forms.Label();
            this.lblAmbientHumidity = new System.Windows.Forms.Label();
            this.lblAmbientTemp = new System.Windows.Forms.Label();
            this.gBoxSettings = new System.Windows.Forms.GroupBox();
            this.numBoxTempThresh = new System.Windows.Forms.NumericUpDown();
            this.lblTempThresh = new System.Windows.Forms.Label();
            this.lblMaxPower = new System.Windows.Forms.Label();
            this.numBoxMaxPwr = new System.Windows.Forms.NumericUpDown();
            this.btnSetMode = new System.Windows.Forms.Button();
            this.lblManPwr = new System.Windows.Forms.Label();
            this.numBoxPwr = new System.Windows.Forms.NumericUpDown();
            this.cBoxMode = new System.Windows.Forms.ComboBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.gBoxChan1 = new System.Windows.Forms.GroupBox();
            this.tBoxChan1Mode = new System.Windows.Forms.TextBox();
            this.lblChan1Status = new System.Windows.Forms.Label();
            this.lblChan1Mode = new System.Windows.Forms.Label();
            this.pBarChan1Power = new System.Windows.Forms.ProgressBar();
            this.tBoxChan1Temp = new System.Windows.Forms.TextBox();
            this.lblChan1Power = new System.Windows.Forms.Label();
            this.lblChan1Temp = new System.Windows.Forms.Label();
            this.gBoxChan2 = new System.Windows.Forms.GroupBox();
            this.tBoxChan2Mode = new System.Windows.Forms.TextBox();
            this.lblChan2Status = new System.Windows.Forms.Label();
            this.lblChan2Mode = new System.Windows.Forms.Label();
            this.pBarChan2Power = new System.Windows.Forms.ProgressBar();
            this.tBoxChan2Temp = new System.Windows.Forms.TextBox();
            this.lblChan2Power = new System.Windows.Forms.Label();
            this.lblChan2Temp = new System.Windows.Forms.Label();
            this.gBoxSerialCm.SuspendLayout();
            this.gBoxAmbient.SuspendLayout();
            this.gBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxTempThresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxMaxPwr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxPwr)).BeginInit();
            this.gBoxChan1.SuspendLayout();
            this.gBoxChan2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBoxComPort
            // 
            this.cBoxComPort.FormattingEnabled = true;
            this.cBoxComPort.Location = new System.Drawing.Point(88, 21);
            this.cBoxComPort.Name = "cBoxComPort";
            this.cBoxComPort.Size = new System.Drawing.Size(63, 21);
            this.cBoxComPort.TabIndex = 0;
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(23, 24);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(56, 13);
            this.lblComPort.TabIndex = 1;
            this.lblComPort.Text = "COM Port:";
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(19, 51);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(63, 33);
            this.btnOpenPort.TabIndex = 2;
            this.btnOpenPort.Text = "Connect";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenComPort_Click);
            // 
            // btnClosePort
            // 
            this.btnClosePort.Location = new System.Drawing.Point(88, 51);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.Size = new System.Drawing.Size(63, 33);
            this.btnClosePort.TabIndex = 3;
            this.btnClosePort.Text = "Close";
            this.btnClosePort.UseVisualStyleBackColor = true;
            this.btnClosePort.Click += new System.EventHandler(this.btnClosePort_Click);
            // 
            // gBoxSerialCm
            // 
            this.gBoxSerialCm.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gBoxSerialCm.Controls.Add(this.lblComStatus);
            this.gBoxSerialCm.Controls.Add(this.btnClosePort);
            this.gBoxSerialCm.Controls.Add(this.cBoxComPort);
            this.gBoxSerialCm.Controls.Add(this.btnOpenPort);
            this.gBoxSerialCm.Controls.Add(this.lblComPort);
            this.gBoxSerialCm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gBoxSerialCm.Location = new System.Drawing.Point(16, 15);
            this.gBoxSerialCm.Name = "gBoxSerialCm";
            this.gBoxSerialCm.Size = new System.Drawing.Size(166, 120);
            this.gBoxSerialCm.TabIndex = 4;
            this.gBoxSerialCm.TabStop = false;
            this.gBoxSerialCm.Text = "USB Connection";
            // 
            // lblComStatus
            // 
            this.lblComStatus.AutoSize = true;
            this.lblComStatus.Location = new System.Drawing.Point(19, 92);
            this.lblComStatus.Name = "lblComStatus";
            this.lblComStatus.Size = new System.Drawing.Size(13, 13);
            this.lblComStatus.TabIndex = 5;
            this.lblComStatus.Text = "--";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // gBoxAmbient
            // 
            this.gBoxAmbient.Controls.Add(this.tBoxAmbientDewPoint);
            this.gBoxAmbient.Controls.Add(this.tBoxAmbientHumidity);
            this.gBoxAmbient.Controls.Add(this.tBoxAmbientTemp);
            this.gBoxAmbient.Controls.Add(this.lblAmbientDewPoint);
            this.gBoxAmbient.Controls.Add(this.lblAmbientHumidity);
            this.gBoxAmbient.Controls.Add(this.lblAmbientTemp);
            this.gBoxAmbient.Location = new System.Drawing.Point(205, 15);
            this.gBoxAmbient.Name = "gBoxAmbient";
            this.gBoxAmbient.Size = new System.Drawing.Size(272, 80);
            this.gBoxAmbient.TabIndex = 6;
            this.gBoxAmbient.TabStop = false;
            this.gBoxAmbient.Text = "Ambient";
            // 
            // tBoxAmbientDewPoint
            // 
            this.tBoxAmbientDewPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxAmbientDewPoint.Location = new System.Drawing.Point(139, 47);
            this.tBoxAmbientDewPoint.Name = "tBoxAmbientDewPoint";
            this.tBoxAmbientDewPoint.Size = new System.Drawing.Size(33, 22);
            this.tBoxAmbientDewPoint.TabIndex = 11;
            // 
            // tBoxAmbientHumidity
            // 
            this.tBoxAmbientHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxAmbientHumidity.Location = new System.Drawing.Point(207, 20);
            this.tBoxAmbientHumidity.Name = "tBoxAmbientHumidity";
            this.tBoxAmbientHumidity.Size = new System.Drawing.Size(33, 22);
            this.tBoxAmbientHumidity.TabIndex = 10;
            // 
            // tBoxAmbientTemp
            // 
            this.tBoxAmbientTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxAmbientTemp.Location = new System.Drawing.Point(82, 20);
            this.tBoxAmbientTemp.Name = "tBoxAmbientTemp";
            this.tBoxAmbientTemp.Size = new System.Drawing.Size(33, 22);
            this.tBoxAmbientTemp.TabIndex = 9;
            // 
            // lblAmbientDewPoint
            // 
            this.lblAmbientDewPoint.AutoSize = true;
            this.lblAmbientDewPoint.Location = new System.Drawing.Point(66, 52);
            this.lblAmbientDewPoint.Name = "lblAmbientDewPoint";
            this.lblAmbientDewPoint.Size = new System.Drawing.Size(75, 13);
            this.lblAmbientDewPoint.TabIndex = 8;
            this.lblAmbientDewPoint.Text = "Dew Point (C):";
            this.lblAmbientDewPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmbientHumidity
            // 
            this.lblAmbientHumidity.AutoSize = true;
            this.lblAmbientHumidity.Location = new System.Drawing.Point(142, 25);
            this.lblAmbientHumidity.Name = "lblAmbientHumidity";
            this.lblAmbientHumidity.Size = new System.Drawing.Size(67, 13);
            this.lblAmbientHumidity.TabIndex = 8;
            this.lblAmbientHumidity.Text = "Humidity (%):";
            this.lblAmbientHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmbientTemp
            // 
            this.lblAmbientTemp.AutoSize = true;
            this.lblAmbientTemp.Location = new System.Drawing.Point(30, 25);
            this.lblAmbientTemp.Name = "lblAmbientTemp";
            this.lblAmbientTemp.Size = new System.Drawing.Size(53, 13);
            this.lblAmbientTemp.TabIndex = 0;
            this.lblAmbientTemp.Text = "Temp (C):";
            this.lblAmbientTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gBoxSettings
            // 
            this.gBoxSettings.Controls.Add(this.numBoxTempThresh);
            this.gBoxSettings.Controls.Add(this.lblTempThresh);
            this.gBoxSettings.Controls.Add(this.lblMaxPower);
            this.gBoxSettings.Controls.Add(this.numBoxMaxPwr);
            this.gBoxSettings.Controls.Add(this.btnSetMode);
            this.gBoxSettings.Controls.Add(this.lblManPwr);
            this.gBoxSettings.Controls.Add(this.numBoxPwr);
            this.gBoxSettings.Controls.Add(this.cBoxMode);
            this.gBoxSettings.Controls.Add(this.lblMode);
            this.gBoxSettings.Location = new System.Drawing.Point(16, 142);
            this.gBoxSettings.Name = "gBoxSettings";
            this.gBoxSettings.Size = new System.Drawing.Size(166, 173);
            this.gBoxSettings.TabIndex = 7;
            this.gBoxSettings.TabStop = false;
            this.gBoxSettings.Text = "SETTINGS";
            // 
            // numBoxTempThresh
            // 
            this.numBoxTempThresh.Location = new System.Drawing.Point(93, 100);
            this.numBoxTempThresh.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numBoxTempThresh.Name = "numBoxTempThresh";
            this.numBoxTempThresh.Size = new System.Drawing.Size(54, 20);
            this.numBoxTempThresh.TabIndex = 13;
            this.numBoxTempThresh.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numBoxTempThresh.ValueChanged += new System.EventHandler(this.numBoxTempThresh_ValueChanged);
            // 
            // lblTempThresh
            // 
            this.lblTempThresh.AutoSize = true;
            this.lblTempThresh.Location = new System.Drawing.Point(14, 104);
            this.lblTempThresh.Name = "lblTempThresh";
            this.lblTempThresh.Size = new System.Drawing.Size(70, 13);
            this.lblTempThresh.TabIndex = 12;
            this.lblTempThresh.Text = "Threshold (C)";
            this.lblTempThresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMaxPower
            // 
            this.lblMaxPower.AutoSize = true;
            this.lblMaxPower.Location = new System.Drawing.Point(19, 75);
            this.lblMaxPower.Name = "lblMaxPower";
            this.lblMaxPower.Size = new System.Drawing.Size(65, 13);
            this.lblMaxPower.TabIndex = 11;
            this.lblMaxPower.Text = "Max Pwr (%)";
            this.lblMaxPower.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numBoxMaxPwr
            // 
            this.numBoxMaxPwr.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numBoxMaxPwr.Location = new System.Drawing.Point(93, 71);
            this.numBoxMaxPwr.Name = "numBoxMaxPwr";
            this.numBoxMaxPwr.Size = new System.Drawing.Size(54, 20);
            this.numBoxMaxPwr.TabIndex = 10;
            this.numBoxMaxPwr.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numBoxMaxPwr.ValueChanged += new System.EventHandler(this.numBoxMaxPwr_ValueChanged);
            // 
            // btnSetMode
            // 
            this.btnSetMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetMode.Location = new System.Drawing.Point(26, 127);
            this.btnSetMode.Name = "btnSetMode";
            this.btnSetMode.Size = new System.Drawing.Size(95, 36);
            this.btnSetMode.TabIndex = 6;
            this.btnSetMode.Text = "SET";
            this.btnSetMode.UseVisualStyleBackColor = true;
            this.btnSetMode.Click += new System.EventHandler(this.btnSetMode_Click);
            // 
            // lblManPwr
            // 
            this.lblManPwr.AutoSize = true;
            this.lblManPwr.Location = new System.Drawing.Point(1, 50);
            this.lblManPwr.Name = "lblManPwr";
            this.lblManPwr.Size = new System.Drawing.Size(83, 13);
            this.lblManPwr.TabIndex = 9;
            this.lblManPwr.Text = "Manual Pwr (%):";
            this.lblManPwr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numBoxPwr
            // 
            this.numBoxPwr.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numBoxPwr.Location = new System.Drawing.Point(93, 46);
            this.numBoxPwr.Name = "numBoxPwr";
            this.numBoxPwr.Size = new System.Drawing.Size(54, 20);
            this.numBoxPwr.TabIndex = 8;
            this.numBoxPwr.ValueChanged += new System.EventHandler(this.numBoxPwr_ValueChanged);
            // 
            // cBoxMode
            // 
            this.cBoxMode.FormattingEnabled = true;
            this.cBoxMode.Items.AddRange(new object[] {
            "OFF",
            "MANUAL",
            "AUTO-ambient",
            "AUTO-heater"});
            this.cBoxMode.Location = new System.Drawing.Point(54, 20);
            this.cBoxMode.Name = "cBoxMode";
            this.cBoxMode.Size = new System.Drawing.Size(93, 21);
            this.cBoxMode.TabIndex = 8;
            this.cBoxMode.Text = "AUTO-heater";
            this.cBoxMode.SelectedIndexChanged += new System.EventHandler(this.cBoxMode_SelectedIndexChanged);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(8, 24);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(42, 13);
            this.lblMode.TabIndex = 0;
            this.lblMode.Text = "MODE:";
            this.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gBoxChan1
            // 
            this.gBoxChan1.Controls.Add(this.tBoxChan1Mode);
            this.gBoxChan1.Controls.Add(this.lblChan1Status);
            this.gBoxChan1.Controls.Add(this.lblChan1Mode);
            this.gBoxChan1.Controls.Add(this.pBarChan1Power);
            this.gBoxChan1.Controls.Add(this.tBoxChan1Temp);
            this.gBoxChan1.Controls.Add(this.lblChan1Power);
            this.gBoxChan1.Controls.Add(this.lblChan1Temp);
            this.gBoxChan1.Location = new System.Drawing.Point(198, 112);
            this.gBoxChan1.Name = "gBoxChan1";
            this.gBoxChan1.Size = new System.Drawing.Size(289, 92);
            this.gBoxChan1.TabIndex = 12;
            this.gBoxChan1.TabStop = false;
            this.gBoxChan1.Text = "Channel 1:";
            // 
            // tBoxChan1Mode
            // 
            this.tBoxChan1Mode.Location = new System.Drawing.Point(157, 25);
            this.tBoxChan1Mode.Name = "tBoxChan1Mode";
            this.tBoxChan1Mode.Size = new System.Drawing.Size(103, 20);
            this.tBoxChan1Mode.TabIndex = 18;
            // 
            // lblChan1Status
            // 
            this.lblChan1Status.AutoSize = true;
            this.lblChan1Status.Location = new System.Drawing.Point(175, 61);
            this.lblChan1Status.Name = "lblChan1Status";
            this.lblChan1Status.Size = new System.Drawing.Size(13, 13);
            this.lblChan1Status.TabIndex = 13;
            this.lblChan1Status.Text = "--";
            // 
            // lblChan1Mode
            // 
            this.lblChan1Mode.AutoSize = true;
            this.lblChan1Mode.Location = new System.Drawing.Point(118, 29);
            this.lblChan1Mode.Name = "lblChan1Mode";
            this.lblChan1Mode.Size = new System.Drawing.Size(37, 13);
            this.lblChan1Mode.TabIndex = 14;
            this.lblChan1Mode.Text = "Mode:";
            this.lblChan1Mode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pBarChan1Power
            // 
            this.pBarChan1Power.Location = new System.Drawing.Point(49, 58);
            this.pBarChan1Power.Name = "pBarChan1Power";
            this.pBarChan1Power.Size = new System.Drawing.Size(116, 19);
            this.pBarChan1Power.TabIndex = 13;
            // 
            // tBoxChan1Temp
            // 
            this.tBoxChan1Temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxChan1Temp.Location = new System.Drawing.Point(61, 24);
            this.tBoxChan1Temp.Name = "tBoxChan1Temp";
            this.tBoxChan1Temp.Size = new System.Drawing.Size(33, 22);
            this.tBoxChan1Temp.TabIndex = 9;
            // 
            // lblChan1Power
            // 
            this.lblChan1Power.AutoSize = true;
            this.lblChan1Power.Location = new System.Drawing.Point(6, 61);
            this.lblChan1Power.Name = "lblChan1Power";
            this.lblChan1Power.Size = new System.Drawing.Size(40, 13);
            this.lblChan1Power.TabIndex = 8;
            this.lblChan1Power.Text = "Power:";
            this.lblChan1Power.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChan1Temp
            // 
            this.lblChan1Temp.AutoSize = true;
            this.lblChan1Temp.Location = new System.Drawing.Point(6, 29);
            this.lblChan1Temp.Name = "lblChan1Temp";
            this.lblChan1Temp.Size = new System.Drawing.Size(58, 13);
            this.lblChan1Temp.TabIndex = 0;
            this.lblChan1Temp.Text = "Heater (C):";
            this.lblChan1Temp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gBoxChan2
            // 
            this.gBoxChan2.Controls.Add(this.tBoxChan2Mode);
            this.gBoxChan2.Controls.Add(this.lblChan2Status);
            this.gBoxChan2.Controls.Add(this.lblChan2Mode);
            this.gBoxChan2.Controls.Add(this.pBarChan2Power);
            this.gBoxChan2.Controls.Add(this.tBoxChan2Temp);
            this.gBoxChan2.Controls.Add(this.lblChan2Power);
            this.gBoxChan2.Controls.Add(this.lblChan2Temp);
            this.gBoxChan2.Location = new System.Drawing.Point(197, 223);
            this.gBoxChan2.Name = "gBoxChan2";
            this.gBoxChan2.Size = new System.Drawing.Size(290, 92);
            this.gBoxChan2.TabIndex = 18;
            this.gBoxChan2.TabStop = false;
            this.gBoxChan2.Text = "Channel 2:";
            // 
            // tBoxChan2Mode
            // 
            this.tBoxChan2Mode.Location = new System.Drawing.Point(157, 25);
            this.tBoxChan2Mode.Name = "tBoxChan2Mode";
            this.tBoxChan2Mode.Size = new System.Drawing.Size(103, 20);
            this.tBoxChan2Mode.TabIndex = 19;
            // 
            // lblChan2Status
            // 
            this.lblChan2Status.AutoSize = true;
            this.lblChan2Status.Location = new System.Drawing.Point(175, 61);
            this.lblChan2Status.Name = "lblChan2Status";
            this.lblChan2Status.Size = new System.Drawing.Size(13, 13);
            this.lblChan2Status.TabIndex = 18;
            this.lblChan2Status.Text = "--";
            // 
            // lblChan2Mode
            // 
            this.lblChan2Mode.AutoSize = true;
            this.lblChan2Mode.Location = new System.Drawing.Point(118, 29);
            this.lblChan2Mode.Name = "lblChan2Mode";
            this.lblChan2Mode.Size = new System.Drawing.Size(37, 13);
            this.lblChan2Mode.TabIndex = 14;
            this.lblChan2Mode.Text = "Mode:";
            this.lblChan2Mode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pBarChan2Power
            // 
            this.pBarChan2Power.Location = new System.Drawing.Point(49, 58);
            this.pBarChan2Power.Name = "pBarChan2Power";
            this.pBarChan2Power.Size = new System.Drawing.Size(116, 19);
            this.pBarChan2Power.TabIndex = 13;
            // 
            // tBoxChan2Temp
            // 
            this.tBoxChan2Temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxChan2Temp.Location = new System.Drawing.Point(61, 24);
            this.tBoxChan2Temp.Name = "tBoxChan2Temp";
            this.tBoxChan2Temp.Size = new System.Drawing.Size(33, 22);
            this.tBoxChan2Temp.TabIndex = 9;
            // 
            // lblChan2Power
            // 
            this.lblChan2Power.AutoSize = true;
            this.lblChan2Power.Location = new System.Drawing.Point(6, 61);
            this.lblChan2Power.Name = "lblChan2Power";
            this.lblChan2Power.Size = new System.Drawing.Size(40, 13);
            this.lblChan2Power.TabIndex = 8;
            this.lblChan2Power.Text = "Power:";
            this.lblChan2Power.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChan2Temp
            // 
            this.lblChan2Temp.AutoSize = true;
            this.lblChan2Temp.Location = new System.Drawing.Point(6, 29);
            this.lblChan2Temp.Name = "lblChan2Temp";
            this.lblChan2Temp.Size = new System.Drawing.Size(58, 13);
            this.lblChan2Temp.TabIndex = 0;
            this.lblChan2Temp.Text = "Heater (C):";
            this.lblChan2Temp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DewHeaterController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(504, 324);
            this.Controls.Add(this.gBoxChan2);
            this.Controls.Add(this.gBoxChan1);
            this.Controls.Add(this.gBoxSettings);
            this.Controls.Add(this.gBoxAmbient);
            this.Controls.Add(this.gBoxSerialCm);
            this.Name = "DewHeaterController";
            this.Text = "DewHeaterController";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBoxSerialCm.ResumeLayout(false);
            this.gBoxSerialCm.PerformLayout();
            this.gBoxAmbient.ResumeLayout(false);
            this.gBoxAmbient.PerformLayout();
            this.gBoxSettings.ResumeLayout(false);
            this.gBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxTempThresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxMaxPwr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxPwr)).EndInit();
            this.gBoxChan1.ResumeLayout(false);
            this.gBoxChan1.PerformLayout();
            this.gBoxChan2.ResumeLayout(false);
            this.gBoxChan2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxComPort;
        private System.Windows.Forms.Label lblComPort;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.Button btnClosePort;
        private System.Windows.Forms.GroupBox gBoxSerialCm;
        private System.Windows.Forms.Label lblComStatus;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox gBoxAmbient;
        private System.Windows.Forms.Label lblAmbientTemp;
        private System.Windows.Forms.GroupBox gBoxSettings;
        private System.Windows.Forms.ComboBox cBoxMode;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblManPwr;
        private System.Windows.Forms.NumericUpDown numBoxPwr;
        private System.Windows.Forms.Button btnSetMode;
        private System.Windows.Forms.TextBox tBoxAmbientDewPoint;
        private System.Windows.Forms.TextBox tBoxAmbientHumidity;
        private System.Windows.Forms.TextBox tBoxAmbientTemp;
        private System.Windows.Forms.Label lblAmbientDewPoint;
        private System.Windows.Forms.Label lblAmbientHumidity;
        private System.Windows.Forms.GroupBox gBoxChan1;
        private System.Windows.Forms.Label lblChan1Mode;
        private System.Windows.Forms.ProgressBar pBarChan1Power;
        private System.Windows.Forms.TextBox tBoxChan1Temp;
        private System.Windows.Forms.Label lblChan1Power;
        private System.Windows.Forms.Label lblChan1Temp;
        private System.Windows.Forms.GroupBox gBoxChan2;
        private System.Windows.Forms.Label lblChan2Mode;
        private System.Windows.Forms.ProgressBar pBarChan2Power;
        private System.Windows.Forms.TextBox tBoxChan2Temp;
        private System.Windows.Forms.Label lblChan2Power;
        private System.Windows.Forms.Label lblChan2Temp;
        private System.Windows.Forms.Label lblMaxPower;
        private System.Windows.Forms.NumericUpDown numBoxMaxPwr;
        private System.Windows.Forms.Label lblChan1Status;
        private System.Windows.Forms.Label lblChan2Status;
        private System.Windows.Forms.TextBox tBoxChan1Mode;
        private System.Windows.Forms.TextBox tBoxChan2Mode;
        private System.Windows.Forms.Label lblTempThresh;
        private System.Windows.Forms.NumericUpDown numBoxTempThresh;
    }
}

