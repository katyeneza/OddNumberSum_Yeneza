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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.lblInstuctions = New System.Windows.Forms.Label()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(17, 101)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(77, 42)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(109, 61)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(53, 20)
        Me.txtNumber.TabIndex = 1
        '
        'lblInstuctions
        '
        Me.lblInstuctions.AutoSize = True
        Me.lblInstuctions.Location = New System.Drawing.Point(14, 61)
        Me.lblInstuctions.Name = "lblInstuctions"
        Me.lblInstuctions.Size = New System.Drawing.Size(82, 13)
        Me.lblInstuctions.TabIndex = 2
        Me.lblInstuctions.Text = "Enter a number:"
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Location = New System.Drawing.Point(23, 182)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(0, 13)
        Me.lblSum.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.lblInstuctions)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblInstuctions As System.Windows.Forms.Label
    Friend WithEvents lblSum As System.Windows.Forms.Label

End Class
