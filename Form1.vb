Public Class Form1

    ' Lucy Cheng
    ' Flappy Birds
    ' May 2015

    Dim intYSpeed As Integer = 0
    Dim intGravity As Integer = 2
    Dim pbxArrayPipe(2) As PictureBox

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then
            intYSpeed = -15
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tmrTimer.Enabled = True
        CreatePipes(1)
    End Sub

    Private Sub tmrTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimer.Tick
        intYSpeed += intGravity
        pbxBird.Top += intYSpeed
    End Sub

    Private Sub CreatePipes(ByVal Number As Integer)
        Dim i As Integer = 0
        For i = 0 To Number
            Dim temp As New PictureBox
            Me.Controls.Add(temp)
            temp.Width = 50
            temp.Height = 350
            temp.BorderStyle = BorderStyle.FixedSingle
            temp.BackColor = Color.Red
            temp.Top = 100
            temp.Left = i * 200 + 100
            pbxArrayPipe(1) = temp
            pbxArrayPipe(1).Visible = True
        Next
    End Sub

End Class
