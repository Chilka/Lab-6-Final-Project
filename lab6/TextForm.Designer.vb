<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextForm
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
        Me.tbTextArea = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tbTextArea
        '
        Me.tbTextArea.Location = New System.Drawing.Point(-2, 0)
        Me.tbTextArea.Multiline = True
        Me.tbTextArea.Name = "tbTextArea"
        Me.tbTextArea.Size = New System.Drawing.Size(806, 453)
        Me.tbTextArea.TabIndex = 0
        '
        'TextForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tbTextArea)
        Me.Name = "TextForm"
        Me.Text = "TextForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbTextArea As TextBox
End Class
