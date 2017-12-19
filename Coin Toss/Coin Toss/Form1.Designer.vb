<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoinToss
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
        Me.btnTosstheCoin = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picTails = New System.Windows.Forms.PictureBox()
        Me.picHeads = New System.Windows.Forms.PictureBox()
        Me.ResultforHeads = New System.Windows.Forms.Label()
        Me.ResultforTails = New System.Windows.Forms.Label()
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHeads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTosstheCoin
        '
        Me.btnTosstheCoin.Location = New System.Drawing.Point(80, 269)
        Me.btnTosstheCoin.Name = "btnTosstheCoin"
        Me.btnTosstheCoin.Size = New System.Drawing.Size(162, 32)
        Me.btnTosstheCoin.TabIndex = 0
        Me.btnTosstheCoin.Text = "Toss the Coin"
        Me.btnTosstheCoin.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(371, 269)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(162, 32)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picTails
        '
        Me.picTails.Image = Global.oin_Toss.My.Resources.Resources.Tail
        Me.picTails.Location = New System.Drawing.Point(371, 22)
        Me.picTails.Name = "picTails"
        Me.picTails.Size = New System.Drawing.Size(195, 201)
        Me.picTails.TabIndex = 3
        Me.picTails.TabStop = False
        '
        'picHeads
        '
        Me.picHeads.Image = Global.oin_Toss.My.Resources.Resources.Real_Coin
        Me.picHeads.Location = New System.Drawing.Point(37, 22)
        Me.picHeads.Name = "picHeads"
        Me.picHeads.Size = New System.Drawing.Size(205, 214)
        Me.picHeads.TabIndex = 2
        Me.picHeads.TabStop = False
        '
        'ResultforHeads
        '
        Me.ResultforHeads.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ResultforHeads.Location = New System.Drawing.Point(80, 340)
        Me.ResultforHeads.Name = "ResultforHeads"
        Me.ResultforHeads.Size = New System.Drawing.Size(151, 32)
        Me.ResultforHeads.TabIndex = 4
        '
        'ResultforTails
        '
        Me.ResultforTails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ResultforTails.Location = New System.Drawing.Point(368, 340)
        Me.ResultforTails.Name = "ResultforTails"
        Me.ResultforTails.Size = New System.Drawing.Size(150, 32)
        Me.ResultforTails.TabIndex = 5
        '
        'CoinToss
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(681, 425)
        Me.Controls.Add(Me.ResultforTails)
        Me.Controls.Add(Me.ResultforHeads)
        Me.Controls.Add(Me.picTails)
        Me.Controls.Add(Me.picHeads)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTosstheCoin)
        Me.Name = "CoinToss"
        Me.Text = "Coin Toss"
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHeads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTosstheCoin As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picHeads As System.Windows.Forms.PictureBox
    Friend WithEvents picTails As System.Windows.Forms.PictureBox
    Friend WithEvents ResultforHeads As System.Windows.Forms.Label
    Friend WithEvents ResultforTails As System.Windows.Forms.Label

End Class
