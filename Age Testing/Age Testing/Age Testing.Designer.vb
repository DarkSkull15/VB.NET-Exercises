<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Tb1 = New System.Windows.Forms.TextBox()
        Me.Bn1 = New System.Windows.Forms.Button()
        Me.pnlSukatan = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Tb1
        '
        Me.Tb1.BackColor = System.Drawing.Color.PeachPuff
        Me.Tb1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb1.Location = New System.Drawing.Point(579, 197)
        Me.Tb1.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb1.Name = "Tb1"
        Me.Tb1.Size = New System.Drawing.Size(105, 91)
        Me.Tb1.TabIndex = 0
        '
        'Bn1
        '
        Me.Bn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bn1.Location = New System.Drawing.Point(108, 135)
        Me.Bn1.Margin = New System.Windows.Forms.Padding(4)
        Me.Bn1.Name = "Bn1"
        Me.Bn1.Size = New System.Drawing.Size(241, 39)
        Me.Bn1.TabIndex = 4
        Me.Bn1.UseVisualStyleBackColor = True
        '
        'pnlSukatan
        '
        Me.pnlSukatan.BackColor = System.Drawing.Color.Transparent
        Me.pnlSukatan.Location = New System.Drawing.Point(1, 2)
        Me.pnlSukatan.Name = "pnlSukatan"
        Me.pnlSukatan.Size = New System.Drawing.Size(417, 50)
        Me.pnlSukatan.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1060, 585)
        Me.Controls.Add(Me.Bn1)
        Me.Controls.Add(Me.Tb1)
        Me.Controls.Add(Me.pnlSukatan)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Age Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tb1 As System.Windows.Forms.TextBox
    Friend WithEvents Bn1 As System.Windows.Forms.Button
    Friend WithEvents pnlSukatan As Panel
End Class
