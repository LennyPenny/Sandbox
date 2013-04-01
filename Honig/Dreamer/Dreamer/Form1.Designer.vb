<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Button_Options = New System.Windows.Forms.Button()
        Me.Timer_Animation = New System.Windows.Forms.Timer(Me.components)
        Me.Button_SwitchDynamicColors = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_Close
        '
        Me.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Close.Location = New System.Drawing.Point(247, 12)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(20, 20)
        Me.Button_Close.TabIndex = 1
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'Button_Options
        '
        Me.Button_Options.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Options.Location = New System.Drawing.Point(100, 280)
        Me.Button_Options.Name = "Button_Options"
        Me.Button_Options.Size = New System.Drawing.Size(100, 20)
        Me.Button_Options.TabIndex = 2
        Me.Button_Options.UseVisualStyleBackColor = True
        '
        'Timer_Animation
        '
        Me.Timer_Animation.Interval = 1
        '
        'Button_SwitchDynamicColors
        '
        Me.Button_SwitchDynamicColors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_SwitchDynamicColors.Location = New System.Drawing.Point(30, 400)
        Me.Button_SwitchDynamicColors.Name = "Button_SwitchDynamicColors"
        Me.Button_SwitchDynamicColors.Size = New System.Drawing.Size(237, 23)
        Me.Button_SwitchDynamicColors.TabIndex = 3
        Me.Button_SwitchDynamicColors.Text = "Dynamic colors"
        Me.Button_SwitchDynamicColors.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(300, 300)
        Me.Controls.Add(Me.Button_SwitchDynamicColors)
        Me.Controls.Add(Me.Button_Options)
        Me.Controls.Add(Me.Button_Close)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button_Close As System.Windows.Forms.Button
    Friend WithEvents Button_Options As System.Windows.Forms.Button
    Friend WithEvents Timer_Animation As System.Windows.Forms.Timer
    Friend WithEvents Button_SwitchDynamicColors As System.Windows.Forms.Button

End Class
