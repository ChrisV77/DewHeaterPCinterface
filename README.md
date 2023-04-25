# DewHeaterPCinterface
windows app for arduino based dew heater
For this version (v1)
- all heater mode & general setting are global (for all heater channels)
- Arduino project 'TelescopeDewHeater_PC' which uses same global setting 

This allows you to set mode params for heater channels:
- mode: 0=off 1=manual power 2=auto-ambient 3=auto heater sensor
  - auto-ambient = heater power determiend by ambient temp relative to dew point
  - auto=heater sensor = heater power determined by heater temp relative to dew point.
    - also set a target temperature for the heater sensor (relative to dew point)
  
