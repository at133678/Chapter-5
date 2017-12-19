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
        Me.ComboBoxCountry = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPlay = New System.Windows.Forms.ComboBox()
        Me.ComboBoxArtest = New System.Windows.Forms.ComboBox()
        Me.Country = New System.Windows.Forms.Label()
        Me.Play = New System.Windows.Forms.Label()
        Me.Artest = New System.Windows.Forms.Label()
        Me.YourChoses = New System.Windows.Forms.GroupBox()
        Me.txtArtest = New System.Windows.Forms.TextBox()
        Me.txtPlay = New System.Windows.Forms.TextBox()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.txtShowSelection = New System.Windows.Forms.Button()
        Me.txtRestartForm = New System.Windows.Forms.Button()
        Me.txtExit = New System.Windows.Forms.Button()
        Me.YourChoses.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBoxCountry
        '
        Me.ComboBoxCountry.FormattingEnabled = True
        Me.ComboBoxCountry.Items.AddRange(New Object() {"England", "Ireland ", "Scotland", "Wales"})
        Me.ComboBoxCountry.Location = New System.Drawing.Point(275, 31)
        Me.ComboBoxCountry.Name = "ComboBoxCountry"
        Me.ComboBoxCountry.Size = New System.Drawing.Size(180, 21)
        Me.ComboBoxCountry.TabIndex = 0
        '
        'ComboBoxPlay
        '
        Me.ComboBoxPlay.FormattingEnabled = True
        Me.ComboBoxPlay.Items.AddRange(New Object() {"Hamlet", "Much Ado about nothing", "Romeo and Juliet"})
        Me.ComboBoxPlay.Location = New System.Drawing.Point(275, 120)
        Me.ComboBoxPlay.Name = "ComboBoxPlay"
        Me.ComboBoxPlay.Size = New System.Drawing.Size(180, 21)
        Me.ComboBoxPlay.TabIndex = 1
        '
        'ComboBoxArtest
        '
        Me.ComboBoxArtest.FormattingEnabled = True
        Me.ComboBoxArtest.Location = New System.Drawing.Point(275, 197)
        Me.ComboBoxArtest.Name = "ComboBoxArtest"
        Me.ComboBoxArtest.Size = New System.Drawing.Size(180, 21)
        Me.ComboBoxArtest.TabIndex = 2
        '
        'Country
        '
        Me.Country.AutoSize = True
        Me.Country.Location = New System.Drawing.Point(66, 31)
        Me.Country.Name = "Country"
        Me.Country.Size = New System.Drawing.Size(85, 13)
        Me.Country.TabIndex = 3
        Me.Country.Text = "Chose a Country"
        '
        'Play
        '
        Me.Play.AutoSize = True
        Me.Play.Location = New System.Drawing.Point(66, 120)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(68, 13)
        Me.Play.TabIndex = 4
        Me.Play.Text = "Chose a play"
        '
        'Artest
        '
        Me.Artest.AutoSize = True
        Me.Artest.Location = New System.Drawing.Point(66, 200)
        Me.Artest.Name = "Artest"
        Me.Artest.Size = New System.Drawing.Size(78, 13)
        Me.Artest.TabIndex = 5
        Me.Artest.Text = "Chose anartest"
        '
        'YourChoses
        '
        Me.YourChoses.Controls.Add(Me.txtArtest)
        Me.YourChoses.Controls.Add(Me.txtPlay)
        Me.YourChoses.Controls.Add(Me.txtCountry)
        Me.YourChoses.Location = New System.Drawing.Point(548, 12)
        Me.YourChoses.Name = "YourChoses"
        Me.YourChoses.Size = New System.Drawing.Size(285, 323)
        Me.YourChoses.TabIndex = 6
        Me.YourChoses.TabStop = False
        Me.YourChoses.Text = "Your Choses"
        '
        'txtArtest
        '
        Me.txtArtest.Location = New System.Drawing.Point(61, 188)
        Me.txtArtest.Name = "txtArtest"
        Me.txtArtest.Size = New System.Drawing.Size(100, 20)
        Me.txtArtest.TabIndex = 2
        '
        'txtPlay
        '
        Me.txtPlay.Location = New System.Drawing.Point(71, 109)
        Me.txtPlay.Name = "txtPlay"
        Me.txtPlay.Size = New System.Drawing.Size(100, 20)
        Me.txtPlay.TabIndex = 1
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(71, 19)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(100, 20)
        Me.txtCountry.TabIndex = 0
        '
        'txtShowSelection
        '
        Me.txtShowSelection.Location = New System.Drawing.Point(155, 327)
        Me.txtShowSelection.Name = "txtShowSelection"
        Me.txtShowSelection.Size = New System.Drawing.Size(75, 62)
        Me.txtShowSelection.TabIndex = 7
        Me.txtShowSelection.Text = "Show Selection"
        Me.txtShowSelection.UseVisualStyleBackColor = True
        '
        'txtRestartForm
        '
        Me.txtRestartForm.Location = New System.Drawing.Point(380, 327)
        Me.txtRestartForm.Name = "txtRestartForm"
        Me.txtRestartForm.Size = New System.Drawing.Size(75, 62)
        Me.txtRestartForm.TabIndex = 8
        Me.txtRestartForm.Text = "Reset Form"
        Me.txtRestartForm.UseVisualStyleBackColor = True
        '
        'txtExit
        '
        Me.txtExit.Location = New System.Drawing.Point(600, 341)
        Me.txtExit.Name = "txtExit"
        Me.txtExit.Size = New System.Drawing.Size(75, 62)
        Me.txtExit.TabIndex = 9
        Me.txtExit.Text = "Exit"
        Me.txtExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 454)
        Me.Controls.Add(Me.txtExit)
        Me.Controls.Add(Me.txtRestartForm)
        Me.Controls.Add(Me.txtShowSelection)
        Me.Controls.Add(Me.YourChoses)
        Me.Controls.Add(Me.Artest)
        Me.Controls.Add(Me.Play)
        Me.Controls.Add(Me.Country)
        Me.Controls.Add(Me.ComboBoxArtest)
        Me.Controls.Add(Me.ComboBoxPlay)
        Me.Controls.Add(Me.ComboBoxCountry)
        Me.Name = "Form1"
        Me.Text = ", s,"
        Me.YourChoses.ResumeLayout(False)
        Me.YourChoses.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxCountry As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxPlay As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxArtest As System.Windows.Forms.ComboBox
    Friend WithEvents Country As System.Windows.Forms.Label
    Friend WithEvents Play As System.Windows.Forms.Label
    Friend WithEvents Artest As System.Windows.Forms.Label
    Friend WithEvents YourChoses As System.Windows.Forms.GroupBox
    Friend WithEvents txtArtest As System.Windows.Forms.TextBox
    Friend WithEvents txtPlay As System.Windows.Forms.TextBox
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents txtShowSelection As System.Windows.Forms.Button
    Friend WithEvents txtRestartForm As System.Windows.Forms.Button
    Friend WithEvents txtExit As System.Windows.Forms.Button

End Class
