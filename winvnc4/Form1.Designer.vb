<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.file_explorer_btn = New System.Windows.Forms.Button()
        Me.AMD_settings_btn = New System.Windows.Forms.Button()
        Me.Control_panel_btn = New System.Windows.Forms.Button()
        Me.CMD_btn = New System.Windows.Forms.Button()
        Me.Task_manager_btn = New System.Windows.Forms.Button()
        Me.reboot_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.ForeColor = System.Drawing.Color.AliceBlue
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(333, 132)
        Me.ListBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(231, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "alex@videocrew.pt"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Alex Ramos 2018"
        '
        'file_explorer_btn
        '
        Me.file_explorer_btn.BackColor = System.Drawing.Color.Bisque
        Me.file_explorer_btn.Location = New System.Drawing.Point(15, 172)
        Me.file_explorer_btn.Name = "file_explorer_btn"
        Me.file_explorer_btn.Size = New System.Drawing.Size(78, 23)
        Me.file_explorer_btn.TabIndex = 5
        Me.file_explorer_btn.Text = "File explorer"
        Me.file_explorer_btn.UseVisualStyleBackColor = False
        '
        'AMD_settings_btn
        '
        Me.AMD_settings_btn.BackColor = System.Drawing.Color.Bisque
        Me.AMD_settings_btn.Location = New System.Drawing.Point(99, 172)
        Me.AMD_settings_btn.Name = "AMD_settings_btn"
        Me.AMD_settings_btn.Size = New System.Drawing.Size(78, 23)
        Me.AMD_settings_btn.TabIndex = 6
        Me.AMD_settings_btn.Text = "AMD settings"
        Me.AMD_settings_btn.UseVisualStyleBackColor = False
        '
        'Control_panel_btn
        '
        Me.Control_panel_btn.BackColor = System.Drawing.Color.Bisque
        Me.Control_panel_btn.Location = New System.Drawing.Point(183, 172)
        Me.Control_panel_btn.Name = "Control_panel_btn"
        Me.Control_panel_btn.Size = New System.Drawing.Size(78, 23)
        Me.Control_panel_btn.TabIndex = 7
        Me.Control_panel_btn.Text = "Control Panel"
        Me.Control_panel_btn.UseVisualStyleBackColor = False
        '
        'CMD_btn
        '
        Me.CMD_btn.BackColor = System.Drawing.Color.Bisque
        Me.CMD_btn.Location = New System.Drawing.Point(267, 172)
        Me.CMD_btn.Name = "CMD_btn"
        Me.CMD_btn.Size = New System.Drawing.Size(78, 23)
        Me.CMD_btn.TabIndex = 8
        Me.CMD_btn.Text = "CMD"
        Me.CMD_btn.UseVisualStyleBackColor = False
        '
        'Task_manager_btn
        '
        Me.Task_manager_btn.BackColor = System.Drawing.Color.Bisque
        Me.Task_manager_btn.Location = New System.Drawing.Point(15, 201)
        Me.Task_manager_btn.Name = "Task_manager_btn"
        Me.Task_manager_btn.Size = New System.Drawing.Size(162, 23)
        Me.Task_manager_btn.TabIndex = 9
        Me.Task_manager_btn.Text = "Task Manager"
        Me.Task_manager_btn.UseVisualStyleBackColor = False
        '
        'reboot_btn
        '
        Me.reboot_btn.BackColor = System.Drawing.Color.OrangeRed
        Me.reboot_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.reboot_btn.Location = New System.Drawing.Point(267, 201)
        Me.reboot_btn.Name = "reboot_btn"
        Me.reboot_btn.Size = New System.Drawing.Size(77, 23)
        Me.reboot_btn.TabIndex = 10
        Me.reboot_btn.Text = "Reboot"
        Me.reboot_btn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(356, 260)
        Me.Controls.Add(Me.reboot_btn)
        Me.Controls.Add(Me.Task_manager_btn)
        Me.Controls.Add(Me.CMD_btn)
        Me.Controls.Add(Me.Control_panel_btn)
        Me.Controls.Add(Me.AMD_settings_btn)
        Me.Controls.Add(Me.file_explorer_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "VNC Argument  interceptor & Process launcher"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents file_explorer_btn As Button
    Friend WithEvents AMD_settings_btn As Button
    Friend WithEvents Control_panel_btn As Button
    Friend WithEvents CMD_btn As Button
    Friend WithEvents Task_manager_btn As Button
    Friend WithEvents reboot_btn As Button
End Class
