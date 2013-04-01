<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TimeValue = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UnitHours = New System.Windows.Forms.RadioButton()
        Me.UnitMinutes = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextReminder = New System.Windows.Forms.TextBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ToggleTimer = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.TimeValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(446, 84)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reality Check"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(45, 96)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TimeValue)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UnitHours)
        Me.SplitContainer1.Panel2.Controls.Add(Me.UnitMinutes)
        Me.SplitContainer1.Size = New System.Drawing.Size(752, 48)
        Me.SplitContainer1.SplitterDistance = 489
        Me.SplitContainer1.TabIndex = 1
        '
        'TimeValue
        '
        Me.TimeValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.99!)
        Me.TimeValue.Location = New System.Drawing.Point(399, 2)
        Me.TimeValue.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TimeValue.Name = "TimeValue"
        Me.TimeValue.Size = New System.Drawing.Size(87, 47)
        Me.TimeValue.TabIndex = 1
        Me.TimeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TimeValue.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.99!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(102, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(291, 49)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Remind me every"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UnitHours
        '
        Me.UnitHours.AutoSize = True
        Me.UnitHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.UnitHours.Location = New System.Drawing.Point(22, 25)
        Me.UnitHours.Name = "UnitHours"
        Me.UnitHours.Size = New System.Drawing.Size(73, 24)
        Me.UnitHours.TabIndex = 1
        Me.UnitHours.Text = "Hours"
        Me.UnitHours.UseVisualStyleBackColor = True
        '
        'UnitMinutes
        '
        Me.UnitMinutes.AutoSize = True
        Me.UnitMinutes.Checked = True
        Me.UnitMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.UnitMinutes.Location = New System.Drawing.Point(22, 5)
        Me.UnitMinutes.Name = "UnitMinutes"
        Me.UnitMinutes.Size = New System.Drawing.Size(86, 24)
        Me.UnitMinutes.TabIndex = 0
        Me.UnitMinutes.TabStop = True
        Me.UnitMinutes.Text = "Minutes"
        Me.UnitMinutes.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 25.25!)
        Me.Label3.Location = New System.Drawing.Point(74, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(384, 43)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "User defined Reminder:"
        '
        'TextReminder
        '
        Me.TextReminder.AllowDrop = True
        Me.TextReminder.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.TextReminder.Location = New System.Drawing.Point(26, 241)
        Me.TextReminder.MaxLength = 10000
        Me.TextReminder.Multiline = True
        Me.TextReminder.Name = "TextReminder"
        Me.TextReminder.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextReminder.Size = New System.Drawing.Size(620, 197)
        Me.TextReminder.TabIndex = 3
        '
        'Timer
        '
        Me.Timer.Interval = 60000
        '
        'ToggleTimer
        '
        Me.ToggleTimer.AutoSize = True
        Me.ToggleTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToggleTimer.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToggleTimer.Location = New System.Drawing.Point(658, 342)
        Me.ToggleTimer.Name = "ToggleTimer"
        Me.ToggleTimer.Size = New System.Drawing.Size(139, 47)
        Me.ToggleTimer.TabIndex = 4
        Me.ToggleTimer.Text = "Toggle"
        Me.ToggleTimer.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Button1.Location = New System.Drawing.Point(658, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 43)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Minimize to System Tray"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Show"
        Me.NotifyIcon1.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 443)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ToggleTimer)
        Me.Controls.Add(Me.TextReminder)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Dreamer - nich der echte"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.TimeValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextReminder As System.Windows.Forms.TextBox
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents ToggleTimer As System.Windows.Forms.CheckBox
    Friend WithEvents TimeValue As System.Windows.Forms.NumericUpDown
    Friend WithEvents UnitHours As System.Windows.Forms.RadioButton
    Friend WithEvents UnitMinutes As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon

End Class
