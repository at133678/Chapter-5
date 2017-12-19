<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.ProgramMenu = New System.Windows.Forms.Label()
        Me.CoinToss = New System.Windows.Forms.Button()
        Me.btnSumOfNumbers = New System.Windows.Forms.Button()
        Me.CarRace = New System.Windows.Forms.Button()
        Me.RockPaperSissors = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ProgramMenu
        '
        Me.ProgramMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProgramMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgramMenu.Location = New System.Drawing.Point(27, 9)
        Me.ProgramMenu.Name = "ProgramMenu"
        Me.ProgramMenu.Size = New System.Drawing.Size(139, 40)
        Me.ProgramMenu.TabIndex = 0
        Me.ProgramMenu.Text = "Program Menu"
        '
        'CoinToss
        '
        Me.CoinToss.Location = New System.Drawing.Point(53, 53)
        Me.CoinToss.Name = "CoinToss"
        Me.CoinToss.Size = New System.Drawing.Size(75, 23)
        Me.CoinToss.TabIndex = 1
        Me.CoinToss.Text = "Coin Toss"
        Me.CoinToss.UseVisualStyleBackColor = True
        '
        'btnSumOfNumbers
        '
        Me.btnSumOfNumbers.Location = New System.Drawing.Point(53, 96)
        Me.btnSumOfNumbers.Name = "btnSumOfNumbers"
        Me.btnSumOfNumbers.Size = New System.Drawing.Size(75, 45)
        Me.btnSumOfNumbers.TabIndex = 2
        Me.btnSumOfNumbers.Text = "Sum Of Numbers"
        Me.btnSumOfNumbers.UseVisualStyleBackColor = True
        '
        'CarRace
        '
        Me.CarRace.Location = New System.Drawing.Point(53, 147)
        Me.CarRace.Name = "CarRace"
        Me.CarRace.Size = New System.Drawing.Size(75, 23)
        Me.CarRace.TabIndex = 3
        Me.CarRace.Text = "Car Race"
        Me.CarRace.UseVisualStyleBackColor = True
        '
        'RockPaperSissors
        '
        Me.RockPaperSissors.Location = New System.Drawing.Point(53, 190)
        Me.RockPaperSissors.Name = "RockPaperSissors"
        Me.RockPaperSissors.Size = New System.Drawing.Size(75, 39)
        Me.RockPaperSissors.TabIndex = 4
        Me.RockPaperSissors.Text = "Rock Paper Sissors"
        Me.RockPaperSissors.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 394)
        Me.Controls.Add(Me.RockPaperSissors)
        Me.Controls.Add(Me.CarRace)
        Me.Controls.Add(Me.btnSumOfNumbers)
        Me.Controls.Add(Me.CoinToss)
        Me.Controls.Add(Me.ProgramMenu)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProgramMenu As System.Windows.Forms.Label
    Friend WithEvents CoinToss As System.Windows.Forms.Button
    Friend WithEvents btnSumOfNumbers As System.Windows.Forms.Button
    Friend WithEvents CarRace As System.Windows.Forms.Button
    Friend WithEvents RockPaperSissors As System.Windows.Forms.Button

End Class
