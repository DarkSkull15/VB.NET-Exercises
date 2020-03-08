Public Class Form1
    'to prevent the Flicker of forms when resizing because of the images
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    'To filter the textbox and accept only numeric character
    Private Sub Textbox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
            End If
        End If
    End Sub

    'To filter the textbox and accept only numeric character
    Private Sub Textbox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Dim fnum As Single
        'Dim snum As Single
        'Dim total As Single

        'fnum = TextBox1.Text
        'snum = TextBox2.Text

        'total = fnum + snum

        'TextBox3.Text = total
        TextBox3.Text = Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text)

        TextBox3.Visible = True
        pnlSukatan.BackgroundImage = New Bitmap(My.Resources.Answer)
        pnlSukatan.BackgroundImageLayout = ImageLayout.Stretch

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set background image to enhance User Interface
        Me.BackgroundImage = New Bitmap(My.Resources.background)
        Me.BackgroundImageLayout = ImageLayout.Stretch

        'To Fill the Form with panel, it serve as basis of other controls
        pnlSukatan.Dock = DockStyle.Fill

        'To layout the position and size of the button Check
        Button1.Width = pnlSukatan.Width / 3.2
        Button1.Height = pnlSukatan.Height / 9
        Button1.Left = pnlSukatan.Left + pnlSukatan.Width / 1.73
        Button1.Top = pnlSukatan.Top + pnlSukatan.Height / 1.6

        'To Set the Button Into Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button1.BackColor = System.Drawing.Color.Transparent

        'The Text in this text canot modified or edit by the user manualy
        TextBox3.ReadOnly = True

        'To Set all the Input text or numbers unto the center  
        TextBox1.TextAlign = HorizontalAlignment.Center
        TextBox2.TextAlign = HorizontalAlignment.Center
        TextBox3.TextAlign = HorizontalAlignment.Center

        'It makes the Textbox Layout works perfectly
        TextBox1.Multiline = True
        TextBox2.Multiline = True
        TextBox3.Multiline = True

        'To Set Value on textbox on load to avoid error if Button is clicked while textbox is empty
        TextBox1.Text = 0
        TextBox2.Text = 0
        TextBox3.Text = 0

        'To layout the position and size of the TextBox(Textbox1) which is the First Number
        TextBox1.Width = pnlSukatan.Width / 6
        TextBox1.Height = pnlSukatan.Height / 9
        TextBox1.Left = pnlSukatan.Left + pnlSukatan.Width / 1.27
        TextBox1.Top = pnlSukatan.Top + pnlSukatan.Height / 3.2

        'To layout the position and size of the TextBox(Textbox2) which is the Second Number
        TextBox2.Width = pnlSukatan.Width / 6
        TextBox2.Height = pnlSukatan.Height / 9
        TextBox2.Left = pnlSukatan.Left + pnlSukatan.Width / 1.27
        TextBox2.Top = pnlSukatan.Top + pnlSukatan.Height / 2.2

        'To layout the position and size of the TextBox(Textbox3) which is the answer
        TextBox3.Width = pnlSukatan.Width / 3.5
        TextBox3.Height = pnlSukatan.Height / 7
        TextBox3.Left = pnlSukatan.Left + pnlSukatan.Width / 1.58
        TextBox3.Top = pnlSukatan.Top + pnlSukatan.Height / 1.25
    End Sub

    Private Sub Form1_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        'Set background image to enhance User Interface
        Me.BackgroundImage = New Bitmap(My.Resources.background)
        Me.BackgroundImageLayout = ImageLayout.Stretch

        'To Fill the Form with panel, it serve as basis of other controls
        pnlSukatan.Dock = DockStyle.Fill

        'To layout the position and size of the button Check
        Button1.Width = pnlSukatan.Width / 3.2
        Button1.Height = pnlSukatan.Height / 9
        Button1.Left = pnlSukatan.Left + pnlSukatan.Width / 1.73
        Button1.Top = pnlSukatan.Top + pnlSukatan.Height / 1.6

        'To Set the Button Into Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Button1.BackColor = System.Drawing.Color.Transparent

        'The Text in this text canot modified or edit by the user manualy
        TextBox3.ReadOnly = True

        'To Set all the Input text or numbers unto the center  
        TextBox1.TextAlign = HorizontalAlignment.Center
        TextBox2.TextAlign = HorizontalAlignment.Center
        TextBox3.TextAlign = HorizontalAlignment.Center

        'It makes the Textbox Layout works perfectly
        TextBox1.Multiline = True
        TextBox2.Multiline = True
        TextBox3.Multiline = True



        'To layout the position and size of the TextBox(Textbox1) which is the First Number
        TextBox1.Width = pnlSukatan.Width / 6
        TextBox1.Height = pnlSukatan.Height / 9
        TextBox1.Left = pnlSukatan.Left + pnlSukatan.Width / 1.27
        TextBox1.Top = pnlSukatan.Top + pnlSukatan.Height / 3.2

        'To layout the position and size of the TextBox(Textbox2) which is the Second Number
        TextBox2.Width = pnlSukatan.Width / 6
        TextBox2.Height = pnlSukatan.Height / 9
        TextBox2.Left = pnlSukatan.Left + pnlSukatan.Width / 1.27
        TextBox2.Top = pnlSukatan.Top + pnlSukatan.Height / 2.2

        'To layout the position and size of the TextBox(Textbox3) which is the answer
        TextBox3.Width = pnlSukatan.Width / 3.5
        TextBox3.Height = pnlSukatan.Height / 7
        TextBox3.Left = pnlSukatan.Left + pnlSukatan.Width / 1.58
        TextBox3.Top = pnlSukatan.Top + pnlSukatan.Height / 1.25
    End Sub
End Class
