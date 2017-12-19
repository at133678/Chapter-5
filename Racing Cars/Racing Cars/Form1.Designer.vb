<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarRace
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
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.CarTrack = New System.Windows.Forms.PictureBox()
        Me.FireSkull = New System.Windows.Forms.PictureBox()
        Me.ColorCar = New System.Windows.Forms.PictureBox()
        Me.RealCar = New System.Windows.Forms.PictureBox()
        Me.ResultforFireSkull = New System.Windows.Forms.Label()
        Me.ResultforRealCar = New System.Windows.Forms.Label()
        Me.ResultforColorCar = New System.Windows.Forms.Label()
        CType(Me.CarTrack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FireSkull, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RealCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(55, 397)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 4
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(55, 445)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'CarTrack
        '
        Me.CarTrack.Image = Global.Racing_Cars.My.Resources.Resources.Car_Track
        Me.CarTrack.Location = New System.Drawing.Point(28, -14)
        Me.CarTrack.Name = "CarTrack"
        Me.CarTrack.Size = New System.Drawing.Size(731, 374)
        Me.CarTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CarTrack.TabIndex = 6
        Me.CarTrack.TabStop = False
        '
        'FireSkull
        '
        Me.FireSkull.Image = Global.Racing_Cars.My.Resources.Resources.Fire_Skull1
        Me.FireSkull.Location = New System.Drawing.Point(28, 12)
        Me.FireSkull.Name = "FireSkull"
        Me.FireSkull.Size = New System.Drawing.Size(138, 79)
        Me.FireSkull.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FireSkull.TabIndex = 3
        Me.FireSkull.TabStop = False
        '
        'ColorCar
        '
        Me.ColorCar.Image = Global.Racing_Cars.My.Resources.Resources.Color_Car
        Me.ColorCar.Location = New System.Drawing.Point(28, 263)
        Me.ColorCar.Name = "ColorCar"
        Me.ColorCar.Size = New System.Drawing.Size(138, 97)
        Me.ColorCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ColorCar.TabIndex = 2
        Me.ColorCar.TabStop = False
        '
        'RealCar
        '
        Me.RealCar.Image = Global.Racing_Cars.My.Resources.Resources.Real_Car
        Me.RealCar.Location = New System.Drawing.Point(28, 140)
        Me.RealCar.Name = "RealCar"
        Me.RealCar.Size = New System.Drawing.Size(138, 79)
        Me.RealCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RealCar.TabIndex = 1
        Me.RealCar.TabStop = False
        '
        'ResultforFireSkull
        '
        Me.ResultforFireSkull.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ResultforFireSkull.Location = New System.Drawing.Point(225, 397)
        Me.ResultforFireSkull.Name = "ResultforFireSkull"
        Me.ResultforFireSkull.Size = New System.Drawing.Size(100, 39)
        Me.ResultforFireSkull.TabIndex = 7
        '
        'ResultforRealCar
        '
        Me.ResultforRealCar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ResultforRealCar.Location = New System.Drawing.Point(401, 397)
        Me.ResultforRealCar.Name = "ResultforRealCar"
        Me.ResultforRealCar.Size = New System.Drawing.Size(100, 39)
        Me.ResultforRealCar.TabIndex = 8
        '
        'ResultforColorCar
        '
        Me.ResultforColorCar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ResultforColorCar.Location = New System.Drawing.Point(577, 397)
        Me.ResultforColorCar.Name = "ResultforColorCar"
        Me.ResultforColorCar.Size = New System.Drawing.Size(81, 39)
        Me.ResultforColorCar.TabIndex = 9
        '
        'CarRace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 471)
        Me.Controls.Add(Me.ResultforColorCar)
        Me.Controls.Add(Me.ResultforRealCar)
        Me.Controls.Add(Me.ResultforFireSkull)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.FireSkull)
        Me.Controls.Add(Me.ColorCar)
        Me.Controls.Add(Me.RealCar)
        Me.Controls.Add(Me.CarTrack)
        Me.Name = "CarRace"
        Me.Text = "Car Race"
        CType(Me.CarTrack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FireSkull, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RealCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RealCar As System.Windows.Forms.PictureBox
    Friend WithEvents ColorCar As System.Windows.Forms.PictureBox
    Friend WithEvents FireSkull As System.Windows.Forms.PictureBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents CarTrack As System.Windows.Forms.PictureBox
    Friend WithEvents ResultforFireSkull As System.Windows.Forms.Label
    Friend WithEvents ResultforRealCar As System.Windows.Forms.Label
    Friend WithEvents ResultforColorCar As System.Windows.Forms.Label

End Class
