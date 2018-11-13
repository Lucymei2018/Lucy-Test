<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStart
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
        Me.bntVersion1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'bntVersion1
        '
        Me.bntVersion1.Location = New System.Drawing.Point(76, 27)
        Me.bntVersion1.Name = "bntVersion1"
        Me.bntVersion1.Size = New System.Drawing.Size(109, 23)
        Me.bntVersion1.TabIndex = 0
        Me.bntVersion1.Text = "Version 1"
        Me.bntVersion1.UseVisualStyleBackColor = True
        '
        'FormStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 262)
        Me.Controls.Add(Me.bntVersion1)
        Me.Name = "FormStart"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bntVersion1 As System.Windows.Forms.Button

End Class
