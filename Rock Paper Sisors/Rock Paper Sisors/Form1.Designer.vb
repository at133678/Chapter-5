<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RockPaperSissors
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
        Me.btnSissors = New System.Windows.Forms.Button()
        Me.btnPaper = New System.Windows.Forms.Button()
        Me.btnRock = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSissors
        '
        Me.btnSissors.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSissors.Location = New System.Drawing.Point(85, 43)
        Me.btnSissors.Name = "btnSissors"
        Me.btnSissors.Size = New System.Drawing.Size(92, 65)
        Me.btnSissors.TabIndex = 0
        Me.btnSissors.Text = "Sissors"
        Me.btnSissors.UseVisualStyleBackColor = True
        '
        'btnPaper
        '
        Me.btnPaper.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaper.Location = New System.Drawing.Point(85, 186)
        Me.btnPaper.Name = "btnPaper"
        Me.btnPaper.Size = New System.Drawing.Size(75, 66)
        Me.btnPaper.TabIndex = 1
        Me.btnPaper.Text = "Paper"
        Me.btnPaper.UseVisualStyleBackColor = True
        '
        'btnRock
        '
        Me.btnRock.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRock.Location = New System.Drawing.Point(85, 328)
        Me.btnRock.Name = "btnRock"
        Me.btnRock.Size = New System.Drawing.Size(75, 62)
        Me.btnRock.TabIndex = 2
        Me.btnRock.Text = "Rock"
        Me.btnRock.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(305, 143)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(180, 40)
        Me.lblResult.TabIndex = 5
        '
        'RockPaperSissors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 457)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnRock)
        Me.Controls.Add(Me.btnPaper)
        Me.Controls.Add(Me.btnSissors)
        Me.Name = "RockPaperSissors"
        Me.Text = "Rock Paper Sissors"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSissors As System.Windows.Forms.Button
    Friend WithEvents btnPaper As System.Windows.Forms.Button
    Friend WithEvents btnRock As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label

End Class
