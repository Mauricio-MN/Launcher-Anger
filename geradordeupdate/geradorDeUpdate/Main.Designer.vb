<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.Gerar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Gerar
        '
        Me.Gerar.Location = New System.Drawing.Point(86, 105)
        Me.Gerar.Name = "Gerar"
        Me.Gerar.Size = New System.Drawing.Size(113, 55)
        Me.Gerar.TabIndex = 0
        Me.Gerar.Text = "Gerar"
        Me.Gerar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Gerar)
        Me.Name = "Form1"
        Me.Text = "AngerMu Gerador de UPDATE"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gerar As System.Windows.Forms.Button

End Class
