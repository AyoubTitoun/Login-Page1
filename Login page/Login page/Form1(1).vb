Public Class Form1


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       

    End Sub
    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,color.MediumBlue,ButtonBorderStyle.Solid)
    End Sub

    

    Private Sub BunifuCheckbox1_OnChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuCheckbox1.OnChange




        Me.Refresh()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
End Class
