'' ########################################################
'' ############## Created by Alex Ramos  ##################
'' ########################################################
'' #### This program comes with absolutely no warranty ####
'' ########################################################
'' ############## For Bein Sports, Doha ###################
'' ########################################################
'' ###### alex@videocrew.pt ##################### 2018 ####
'' ########################################################
'' ########## It's all free to use and modify #############
'' ########################################################
''
''
''
''------------------------------------------------------------------------------------------------------------------------------------
''------------------------------------------------  Some Help here  ------------------------------------------------------------------
''------------------------------------------------------------------------------------------------------------------------------------
'' The purpose of this app is to sit between Watchpoint.exe and winvnc4.exe.
'' When the user presses "Shift + Controll + A", Watchmaker.exe sends a command to Watchpoint.exe to 
'' run winvnc4.exe with some flags or arguments, the default command is as follow:
''      D:\WATCHOUT 6\VNC\winvnc4.exe
''      -noconsole
''      PortNumber=3041
''      Password=17526B06234E5807
''      UpdateMethod=0
'' We must pass the complete arguments list to winvnc4.exe but we can add some more, for example by
'' default in Windows 10 VNC runs without elevated privileges, so when you try do run anything on
'' the VNC server / display machine that requires admin level you won't be able to, as VNC
'' is not running as admin.
''
'' The main reason for creating this app, is that I'm running the displays without winlogon shell / file explorer.
'' This means that when I access the displays via VNC, "Shift + Controll + A" on the production PC, the only thing I
'' can remotely control is watchpoint.
'' Now, we rename the orinal winvnc4.exe to winvnc4_bak.exe, and rename the app as winvnx4.exe. The app run on remote access
'' and then launch winvnc4_bak.exe
'' Also the app provides some direct buttons to usefull stuff like, win file explorer, AMD settings, Control panel, Task manager and CMD.
'' When watchpoint is back online any running proccess started by the app, like VNC or the app itself.
''-------------------------------------------------------------------------------------------------------------------------------------



Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cwd As String = My.Application.Info.DirectoryPath                                    ' gets current working directory of the app
        Dim returnValue As String()                                                              ' array where the arguments passed by watchpoint are stored
        Dim newArgs As String = ""

        returnValue = Environment.GetCommandLineArgs()                                           ' reads the arguments passed when the app starts and adds to the array
        If returnValue.Length > 1 Then
            For i = 0 To returnValue.Length - 1                                                  ' loops all arguments
                ListBox1.Items.Add(returnValue(i).ToString())                                    ' adds arguments to listbox
                'Try
                newArgs += returnValue(i + 1).ToString() & " "                                   ' converts array to a one line string
                'Catch EX As Exception
                'End Try
            Next i

            Call StartProcess(cwd & "\winvnc4_bak.exe", newArgs, "runas")                        ' starts original VNC as Admin and adds all the original arguments

        Else
            ListBox1.Items.Add("Nothing, No argument was pass to the file.")                     ' runs if no arguments are passed
            MessageBox.Show("Make sure original winvnc4.exe is renamed to winvnc4_bak.exe")
        End If

    End Sub

    Private Sub StartProcess(ByVal app As String, ByVal arg As String, ByVal verb As String)    ' Starts new process with the passed arguments

        Dim p As New ProcessStartInfo
        p.FileName = app                                                                        ' file to start/run
        p.Arguments = arg                                                                       ' arguments to add to file
        p.Verb = verb                                                                           ' flag to start/run as admin
        Process.Start(p)                                                                        ' run file

    End Sub

    Private Sub KillProcess(ByVal app As String)                                                ' kills started processes

        Dim proc = Process.GetProcessesByName(app)                                              ' searches process by name
        For i As Integer = 0 To proc.Count - 1                                                  ' loops all instaces of process
            proc(i).Kill()                                                                      ' kill process, if found
        Next i

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles file_explorer_btn.Click

        Call StartProcess("explorer.exe", "", "")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AMD_settings_btn.Click

        Call StartProcess("C:\Program Files (x86)\AMD\CNext\CCCSlim\ccc.exe", "", "")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Control_panel_btn.Click

        Call StartProcess("control.exe", "", "")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles CMD_btn.Click

        Call StartProcess("cmd", "", "runas")

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Task_manager_btn.Click

        Call StartProcess("taskmgr", "", "")

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles reboot_btn.Click

        Shell("Shutdown -r -t 0")

    End Sub

    ' on closing and exiting the app
    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.FormClosed

        Call KillProcess("winvnc4_bak")
        Call KillProcess("explorer")
        Call KillProcess("ccc")

    End Sub


End Class
