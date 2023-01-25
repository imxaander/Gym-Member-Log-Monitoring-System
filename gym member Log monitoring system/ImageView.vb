Imports System.Drawing
Public Class ImageView
    Private Sub ImageView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientSize = New Size(PictureBoxPrev.Width, PictureBoxPrev.Height)
        Me.AutoScaleMode = AutoScaleMode.None
    End Sub
    Private Sub ImageView_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        PictureBoxPrev.Image.Dispose()
        PictureBoxPrev.Image = Nothing
    End Sub
End Class