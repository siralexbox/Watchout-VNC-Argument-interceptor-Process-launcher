# Watchout-VNC-Argument-interceptor-Process-launcher

The purpose of this app is to sit between Watchpoint.exe and winvnc4.exe.
When the user presses "Shift + Controll + A", Watchmaker.exe sends a command to Watchpoint.exe to 
run winvnc4.exe with some flags or arguments, the default command is as follow:
       D:\WATCHOUT 6\VNC\winvnc4.exe
       -noconsole
       PortNumber=3041
       Password=17526B06234E5807
       UpdateMethod=0
  We must pass the complete arguments list to winvnc4.exe but we can add some more, for example by
  default in Windows 10 VNC runs without elevated privileges, so when you try do run anything on
  the VNC server / display machine that requires admin level you won't be able to, as VNC
  is not running as admin.
 
  The main reason for creating this app, is that I'm running the displays without winlogon shell / file explorer.
  This means that when I access the displays via VNC, "Shift + Controll + A" on the production PC, the only thing I
  can remotely control is watchpoint.
  Now, we rename the orinal winvnc4.exe to winvnc4_bak.exe, and rename the app as winvnx4.exe. The app run on remote access
  and then launch winvnc4_bak.exe
  Also the app provides some direct buttons to usefull stuff like, win file explorer, AMD settings, Control panel, Task manager and CMD.
  When watchpoint is back online any running proccess started by the app, like VNC or the app itself
