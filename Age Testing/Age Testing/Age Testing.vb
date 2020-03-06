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

    Private Sub Bn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bn1.Click
        Dim age As String

        age = Tb1.Text

        If age <= 13 Then
            'If True it will set the background of PnlSukatan to Child Image 
            pnlSukatan.BackgroundImage = New Bitmap(My.Resources.Child)
            pnlSukatan.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf age <= 21 Then
            'If True it will set the background of PnlSukatan to TeenAger Image
            pnlSukatan.BackgroundImage = New Bitmap(My.Resources.Teenager)
            pnlSukatan.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf age <= 65 Then
            'If True it will set the background of PnlSukatan to Adult Image
            pnlSukatan.BackgroundImage = New Bitmap(My.Resources.Adult)
            pnlSukatan.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf age > 65 Then
            'If True it will set the background of PnlSukatan to Old Image
            pnlSukatan.BackgroundImage = New Bitmap(My.Resources.Old)
            pnlSukatan.BackgroundImageLayout = ImageLayout.Stretch
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set background image to enhance User Interface
        Me.BackgroundImage = New Bitmap(My.Resources.Background)
        Me.BackgroundImageLayout = ImageLayout.Stretch

        'To Fill the Form with panel, it serve as basis of other controls
        pnlSukatan.Dock = DockStyle.Fill

        'To layout the position and size of the button Check
        Bn1.Width = pnlSukatan.Width / 2.65
        Bn1.Height = pnlSukatan.Height / 8
        Bn1.Left = pnlSukatan.Left + pnlSukatan.Width / 1.85
        Bn1.Top = pnlSukatan.Top + pnlSukatan.Height / 1.8

        'To Set the Button Into Transparent
        Bn1.FlatStyle = FlatStyle.Flat
        Bn1.FlatAppearance.BorderSize = 0
        Bn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Bn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Bn1.BackColor = System.Drawing.Color.Transparent

        'To Set all the Input text or numbers unto the center  
        Tb1.TextAlign = HorizontalAlignment.Center
        'It makes the Textbox Layout works perfectly
        Tb1.Multiline = True
        'To Set Value on textbox on load to avoid error if Button is clicked while textbox is empty
        Tb1.Text = 0

        'To layout the position and size of the TextBox Check
        Tb1.Width = pnlSukatan.Width / 2.65
        Tb1.Height = pnlSukatan.Height / 6
        Tb1.Left = pnlSukatan.Left + pnlSukatan.Width / 1.85
        Tb1.Top = pnlSukatan.Top + pnlSukatan.Height / 2.9


    End Sub


    'To reset the control layout when the Window Size change
    Private Sub Form1_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        'Set background image to enhance User Interface
        Me.BackgroundImage = New Bitmap(My.Resources.Background)
        Me.BackgroundImageLayout = ImageLayout.Stretch

        'To Fill the Form with panel, it serve as basis of other controls
        pnlSukatan.Dock = DockStyle.Fill

        'To layout the position and size of the button Check
        Bn1.Width = pnlSukatan.Width / 2.65
        Bn1.Height = pnlSukatan.Height / 8
        Bn1.Left = pnlSukatan.Left + pnlSukatan.Width / 1.85
        Bn1.Top = pnlSukatan.Top + pnlSukatan.Height / 1.8

        'To Set the Button Into Transparent
        Bn1.FlatStyle = FlatStyle.Flat
        Bn1.FlatAppearance.BorderSize = 0
        Bn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Bn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Bn1.BackColor = System.Drawing.Color.Transparent

        'To Set all the Input text or numbers unto the center  
        Tb1.TextAlign = HorizontalAlignment.Center
        'It makes the Textbox Layout works perfectly
        Tb1.Multiline = True
        'To Set Value on textbox on load to avoid error if Button is clicked while textbox is empty
        Tb1.Text = 0

        'To layout the position and size of the TextBox Check
        Tb1.Width = pnlSukatan.Width / 2.65
        Tb1.Height = pnlSukatan.Height / 6
        Tb1.Left = pnlSukatan.Left + pnlSukatan.Width / 1.85
        Tb1.Top = pnlSukatan.Top + pnlSukatan.Height / 2.9
    End Sub


End Class
