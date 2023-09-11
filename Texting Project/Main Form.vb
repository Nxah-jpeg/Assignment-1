Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblMessage.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles picBRB.Click
        LblMessage.Text = "Be Right Back"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picBFF.Click
        LblMessage.Text = "Best Friend Forever"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub picIDK_Click(sender As Object, e As EventArgs) Handles picIDK.Click
        LblMessage.Text = "I don't know"
    End Sub

    Private Sub picLOL_Click(sender As Object, e As EventArgs) Handles picLOL.Click
        LblMessage.Text = "Laugh Out Loud"
    End Sub

    Private Sub picSRY_Click(sender As Object, e As EventArgs) Handles picSRY.Click
        LblMessage.Text = "Sorry"
    End Sub

    Private Sub picXO_Click(sender As Object, e As EventArgs) Handles picXO.Click
        LblMessage.Text = "Hugs and Kisses"
    End Sub
End Class
