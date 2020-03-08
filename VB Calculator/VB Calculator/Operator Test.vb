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
    Private Sub Tb1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb1.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
            End If
        End If
    End Sub

    'To filter the textbox and accept only numeric character
    Private Sub Tb3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tb3.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Bn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bn1.Click
        'Dim first As String
        'Dim Second As String
        'Dim third As String
        'Dim fourth As String

        'first = Tb1.Text
        'second =Tb2.Text
        'third = Tb3.Text

        If cboOperators.SelectedIndex = 0 Then

            Tb4.Text = Convert.ToInt32(Tb1.Text) + Convert.ToInt32(Tb3.Text)

            Tb4.Visible = True
            pnlSukatan.BackgroundImage = New Bitmap(My.Resources.Answer)
            pnlSukatan.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf cboOperators.SelectedIndex = 1 Then

            Tb4.Text = Convert.ToInt32(Tb1.Text) - Convert.ToInt32(Tb3.Text)

            Tb4.Visible = True
            pnlSukatan.BackgroundImage = New Bitmap(My.Resources.Answer)
            pnlSukatan.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf cboOperators.SelectedIndex = 2 Then

            Tb4.Text = Convert.ToInt32(Tb1.Text) / Convert.ToInt32(Tb3.Text)

            Tb4.Visible = True
            pnlSukatan.BackgroundImage = New Bitmap(My.Resources.Answer)
            pnlSukatan.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf cboOperators.SelectedIndex = 3 Then

            Tb4.Text = Convert.ToInt32(Tb1.Text) * Convert.ToInt32(Tb3.Text)

            Tb4.Visible = True
            pnlSukatan.BackgroundImage = New Bitmap(My.Resources.Answer)
            pnlSukatan.BackgroundImageLayout = ImageLayout.Stretch
        Else
            MsgBox("Please enter valid operator")
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set background image to enhance User Interface
        Me.BackgroundImage = New Bitmap(My.Resources.Background)
        Me.BackgroundImageLayout = ImageLayout.Stretch

        'To Fill the Form with panel, it serve as basis of other controls
        pnlSukatan.Dock = DockStyle.Fill

        'To layout the position and size of the button Check
        Bn1.Width = pnlSukatan.Width / 3.2
        Bn1.Height = pnlSukatan.Height / 9
        Bn1.Left = pnlSukatan.Left + pnlSukatan.Width / 1.73
        Bn1.Top = pnlSukatan.Top + pnlSukatan.Height / 1.5

        'To Set the Button Into Transparent
        Bn1.FlatStyle = FlatStyle.Flat
        Bn1.FlatAppearance.BorderSize = 0
        Bn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Bn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Bn1.BackColor = System.Drawing.Color.Transparent

        'The Text in this text canot modified or edit by the user manualy
        Tb4.ReadOnly = True

        'To Set all the Input text or numbers unto the center  
        Tb1.TextAlign = HorizontalAlignment.Center
        Tb3.TextAlign = HorizontalAlignment.Center
        Tb4.TextAlign = HorizontalAlignment.Center

        'It makes the Textbox Layout works perfectly
        Tb1.Multiline = True
        Tb3.Multiline = True
        Tb4.Multiline = True

        'To Set Value on textbox on load to avoid error if Button is clicked while textbox is empty
        Tb1.Text = 0
        Tb3.Text = 0
        Tb4.Text = 0

        'To layout the position and size of the TextBox(Tb1) which is the First Number
        Tb1.Width = pnlSukatan.Width / 6
        Tb1.Height = pnlSukatan.Height / 9
        Tb1.Left = pnlSukatan.Left + pnlSukatan.Width / 1.27
        Tb1.Top = pnlSukatan.Top + pnlSukatan.Height / 3.9

        'To layout the position and size of the TextBox(Tb3) which is the Second Number
        Tb3.Width = pnlSukatan.Width / 6
        Tb3.Height = pnlSukatan.Height / 9
        Tb3.Left = pnlSukatan.Left + pnlSukatan.Width / 1.27
        Tb3.Top = pnlSukatan.Top + pnlSukatan.Height / 2.6

        'To layout the position and size of the TextBox(Tb4) which is the answer
        Tb4.Width = pnlSukatan.Width / 3.5
        Tb4.Height = pnlSukatan.Height / 7
        Tb4.Left = pnlSukatan.Left + pnlSukatan.Width / 1.58
        Tb4.Top = pnlSukatan.Top + pnlSukatan.Height / 1.25

        'To Add items in the combobox
        cboOperators.Items.Clear()
        cboOperators.Items.Add("Addition")
        cboOperators.Items.Add("Subtraction")
        cboOperators.Items.Add("Division")
        cboOperators.Items.Add("Multiplication")
        cboOperators.SelectedIndex = 0

        'to Layout Combobox
        cboOperators.Width = pnlSukatan.Width / 3.5
        cboOperators.Height = pnlSukatan.Height / 9
        cboOperators.Left = pnlSukatan.Left + pnlSukatan.Width / 1.5
        cboOperators.Top = pnlSukatan.Top + pnlSukatan.Height / 1.85
    End Sub

    Private Sub Form1_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        'Set background image to enhance User Interface
        Me.BackgroundImage = New Bitmap(My.Resources.background)
        Me.BackgroundImageLayout = ImageLayout.Stretch

        'To Fill the Form with panel, it serve as basis of other controls
        pnlSukatan.Dock = DockStyle.Fill

        'To layout the position and size of the button Check
        Bn1.Width = pnlSukatan.Width / 3.2
        Bn1.Height = pnlSukatan.Height / 9
        Bn1.Left = pnlSukatan.Left + pnlSukatan.Width / 1.73
        Bn1.Top = pnlSukatan.Top + pnlSukatan.Height / 1.5

        'To Set the Button Into Transparent
        Bn1.FlatStyle = FlatStyle.Flat
        Bn1.FlatAppearance.BorderSize = 0
        Bn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Bn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Bn1.BackColor = System.Drawing.Color.Transparent

        'The Text in this text canot modified or edit by the user manualy
        Tb4.ReadOnly = True

        'To Set all the Input text or numbers unto the center  
        Tb1.TextAlign = HorizontalAlignment.Center
        Tb3.TextAlign = HorizontalAlignment.Center
        Tb4.TextAlign = HorizontalAlignment.Center

        'It makes the Textbox Layout works perfectly
        Tb1.Multiline = True
        Tb3.Multiline = True
        Tb4.Multiline = True

        'To Set Value on textbox on load to avoid error if Button is clicked while textbox is empty
        Tb1.Text = 0
        Tb3.Text = 0
        Tb4.Text = 0

        'To layout the position and size of the TextBox(Tb1) which is the First Number
        Tb1.Width = pnlSukatan.Width / 6
        Tb1.Height = pnlSukatan.Height / 9
        Tb1.Left = pnlSukatan.Left + pnlSukatan.Width / 1.27
        Tb1.Top = pnlSukatan.Top + pnlSukatan.Height / 3.9

        'To layout the position and size of the TextBox(Tb3) which is the Second Number
        Tb3.Width = pnlSukatan.Width / 6
        Tb3.Height = pnlSukatan.Height / 9
        Tb3.Left = pnlSukatan.Left + pnlSukatan.Width / 1.27
        Tb3.Top = pnlSukatan.Top + pnlSukatan.Height / 2.6

        'To layout the position and size of the TextBox(Tb4) which is the answer
        Tb4.Width = pnlSukatan.Width / 3.5
        Tb4.Height = pnlSukatan.Height / 7
        Tb4.Left = pnlSukatan.Left + pnlSukatan.Width / 1.58
        Tb4.Top = pnlSukatan.Top + pnlSukatan.Height / 1.25

        'To Add items in the combobox
        cboOperators.Items.Clear()
        cboOperators.Items.Add("Addition")
        cboOperators.Items.Add("Subtraction")
        cboOperators.Items.Add("Division")
        cboOperators.Items.Add("Multiplication")
        cboOperators.SelectedIndex = 0

        'to Layout Combobox
        cboOperators.Width = pnlSukatan.Width / 3.5
        cboOperators.Height = pnlSukatan.Height / 9
        cboOperators.Left = pnlSukatan.Left + pnlSukatan.Width / 1.5
        cboOperators.Top = pnlSukatan.Top + pnlSukatan.Height / 1.85
    End Sub
End Class
