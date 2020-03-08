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
        Me.Lb1 = New System.Windows.Forms.Label()
        Me.Lb2 = New System.Windows.Forms.Label()
        Me.Lb3 = New System.Windows.Forms.Label()
        Me.Lb4 = New System.Windows.Forms.Label()
        Me.Lb5 = New System.Windows.Forms.Label()
        Me.Bn1 = New System.Windows.Forms.Button()
        Me.Tb1 = New System.Windows.Forms.TextBox()
        Me.Tb2 = New System.Windows.Forms.TextBox()
        Me.Tb3 = New System.Windows.Forms.TextBox()
        Me.Tb4 = New System.Windows.Forms.TextBox()
        Me.pnlSukatan = New System.Windows.Forms.Panel()
        Me.cboOperators = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb1.Location = New System.Drawing.Point(104, 38)
        Me.Lb1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(145, 25)
        Me.Lb1.TabIndex = 0
        Me.Lb1.Text = "VB Calculator"
        Me.Lb1.Visible = False
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.Location = New System.Drawing.Point(77, 92)
        Me.Lb2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(89, 17)
        Me.Lb2.TabIndex = 1
        Me.Lb2.Text = "First Number"
        Me.Lb2.Visible = False
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.Location = New System.Drawing.Point(77, 149)
        Me.Lb3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(65, 17)
        Me.Lb3.TabIndex = 2
        Me.Lb3.Text = "Operator"
        Me.Lb3.Visible = False
        '
        'Lb4
        '
        Me.Lb4.AutoSize = True
        Me.Lb4.Location = New System.Drawing.Point(77, 204)
        Me.Lb4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb4.Name = "Lb4"
        Me.Lb4.Size = New System.Drawing.Size(110, 17)
        Me.Lb4.TabIndex = 3
        Me.Lb4.Text = "Second Number"
        Me.Lb4.Visible = False
        '
        'Lb5
        '
        Me.Lb5.AutoSize = True
        Me.Lb5.Location = New System.Drawing.Point(92, 303)
        Me.Lb5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb5.Name = "Lb5"
        Me.Lb5.Size = New System.Drawing.Size(48, 17)
        Me.Lb5.TabIndex = 4
        Me.Lb5.Text = "Result"
        Me.Lb5.Visible = False
        '
        'Bn1
        '
        Me.Bn1.Location = New System.Drawing.Point(135, 242)
        Me.Bn1.Margin = New System.Windows.Forms.Padding(4)
        Me.Bn1.Name = "Bn1"
        Me.Bn1.Size = New System.Drawing.Size(152, 44)
        Me.Bn1.TabIndex = 5
        Me.Bn1.UseVisualStyleBackColor = True
        '
        'Tb1
        '
        Me.Tb1.BackColor = System.Drawing.Color.PeachPuff
        Me.Tb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Tb1.Location = New System.Drawing.Point(223, 95)
        Me.Tb1.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb1.Name = "Tb1"
        Me.Tb1.Size = New System.Drawing.Size(132, 75)
        Me.Tb1.TabIndex = 6
        '
        'Tb2
        '
        Me.Tb2.Location = New System.Drawing.Point(223, 149)
        Me.Tb2.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb2.Name = "Tb2"
        Me.Tb2.Size = New System.Drawing.Size(132, 22)
        Me.Tb2.TabIndex = 7
        Me.Tb2.Visible = False
        '
        'Tb3
        '
        Me.Tb3.BackColor = System.Drawing.Color.PeachPuff
        Me.Tb3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb3.Location = New System.Drawing.Point(223, 210)
        Me.Tb3.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb3.Name = "Tb3"
        Me.Tb3.Size = New System.Drawing.Size(132, 75)
        Me.Tb3.TabIndex = 8
        '
        'Tb4
        '
        Me.Tb4.BackColor = System.Drawing.Color.PeachPuff
        Me.Tb4.Enabled = False
        Me.Tb4.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb4.Location = New System.Drawing.Point(175, 299)
        Me.Tb4.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb4.Name = "Tb4"
        Me.Tb4.Size = New System.Drawing.Size(180, 98)
        Me.Tb4.TabIndex = 9
        Me.Tb4.Visible = False
        '
        'pnlSukatan
        '
        Me.pnlSukatan.BackColor = System.Drawing.Color.Transparent
        Me.pnlSukatan.Location = New System.Drawing.Point(0, 0)
        Me.pnlSukatan.Name = "pnlSukatan"
        Me.pnlSukatan.Size = New System.Drawing.Size(417, 35)
        Me.pnlSukatan.TabIndex = 10
        '
        'cboOperators
        '
        Me.cboOperators.BackColor = System.Drawing.Color.PeachPuff
        Me.cboOperators.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOperators.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOperators.FormattingEnabled = True
        Me.cboOperators.Location = New System.Drawing.Point(443, 265)
        Me.cboOperators.MaxDropDownItems = 4
        Me.cboOperators.Name = "cboOperators"
        Me.cboOperators.Size = New System.Drawing.Size(236, 59)
        Me.cboOperators.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 683)
        Me.Controls.Add(Me.cboOperators)
        Me.Controls.Add(Me.Tb4)
        Me.Controls.Add(Me.Tb3)
        Me.Controls.Add(Me.Tb2)
        Me.Controls.Add(Me.Tb1)
        Me.Controls.Add(Me.Bn1)
        Me.Controls.Add(Me.Lb5)
        Me.Controls.Add(Me.Lb4)
        Me.Controls.Add(Me.Lb3)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.pnlSukatan)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "VB Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb1 As System.Windows.Forms.Label
    Friend WithEvents Lb2 As System.Windows.Forms.Label
    Friend WithEvents Lb3 As System.Windows.Forms.Label
    Friend WithEvents Lb4 As System.Windows.Forms.Label
    Friend WithEvents Lb5 As System.Windows.Forms.Label
    Friend WithEvents Bn1 As System.Windows.Forms.Button
    Friend WithEvents Tb1 As System.Windows.Forms.TextBox
    Friend WithEvents Tb2 As System.Windows.Forms.TextBox
    Friend WithEvents Tb3 As System.Windows.Forms.TextBox
    Friend WithEvents Tb4 As System.Windows.Forms.TextBox
    Friend WithEvents pnlSukatan As Panel
    Friend WithEvents cboOperators As ComboBox
End Class
