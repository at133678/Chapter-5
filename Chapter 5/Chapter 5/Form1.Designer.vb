<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RunningTotal
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
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEnterSales = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTotalSales
        '
        Me.lblTotalSales.Location = New System.Drawing.Point(39, 34)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(95, 45)
        Me.lblTotalSales.TabIndex = 0
        Me.lblTotalSales.Text = "Total Sales"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(311, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 27)
        Me.Label2.TabIndex = 1
        '
        'btnEnterSales
        '
        Me.btnEnterSales.Location = New System.Drawing.Point(42, 196)
        Me.btnEnterSales.Name = "btnEnterSales"
        Me.btnEnterSales.Size = New System.Drawing.Size(100, 34)
        Me.btnEnterSales.TabIndex = 2
        Me.btnEnterSales.Text = "Enter Sales"
        Me.btnEnterSales.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(301, 196)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 34)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'RunningTotal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 251)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnterSales)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotalSales)
        Me.Name = "RunningTotal"
        Me.Text = "Running Total"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTotalSales As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnEnterSales As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
