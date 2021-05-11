Imports System.Drawing

Public Class Form1

    Dim draw As Boolean
    Dim drawcolor As Color = Color.Black
    Dim drawsize As Integer = 6
    Dim bit As Bitmap

    Private Sub paintbrush(x As Integer, y As Integer)
        Using graf As Graphics = Graphics.FromImage(PicDrawing.Image)
            graf.FillRectangle(New SolidBrush(drawcolor), New Rectangle(x, y, drawsize, drawsize))
        End Using

        PicDrawing.Refresh()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ComboFont.SelectedIndex = 2

        bit = New Bitmap(PicDrawing.Width, PicDrawing.Height)
        PicDrawing.Image = bit
    End Sub

    Private Sub PicDrawing_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PicDrawing.MouseMove
        If draw = True Then
            paintbrush(e.X, e.Y)
        End If
    End Sub

    Private Sub PicDrawing_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PicDrawing.MouseDown
        draw = True

        paintbrush(e.X, e.Y)
    End Sub

    Private Sub PicDrawing_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PicDrawing.MouseUp
        draw = False
    End Sub

    Private Sub BtnClear_Click(sender As System.Object, e As System.EventArgs) Handles BtnClear.Click
        bit = New Bitmap(PicDrawing.Width, PicDrawing.Height)
        PicDrawing.Image = bit
    End Sub

    Private Sub ComboFont_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboFont.SelectedIndexChanged
        drawsize = ComboFont.SelectedIndex
    End Sub

    Private Sub BtnColor_Click(sender As System.Object, e As System.EventArgs) Handles BtnColor.Click
        If ColorDialogDrawing.ShowDialog() = Windows.Forms.DialogResult.OK Then
            drawcolor = ColorDialogDrawing.Color
        End If
    End Sub

    Private Sub BtnSave_Click(sender As System.Object, e As System.EventArgs) Handles BtnSave.Click
        PicDrawing.DrawToBitmap(bit, New Rectangle(0, 0, PicDrawing.Width, PicDrawing.Height))
        bit.Save("Draw.png", Imaging.ImageFormat.Png)

        bit = New Bitmap(PicDrawing.Width, PicDrawing.Height)
        MessageBox.Show("Gambar telah disimpan, Directory Debug with file name Draw.png", "VB .NET", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
