Public Class main

    Dim KEINEBILDERMEHR As Boolean = False

    Private Sub getFilenamesFromSource()
        FBD_sourceDir.SelectedPath = "Z:\Bilder\&&_" 'My.Computer.FileSystem.SpecialDirectories.MyPictures
        FBD_sourceDir.ShowDialog()

        Dim srcdir As String = FBD_sourceDir.SelectedPath
        Dim imgfiles As New List(Of String)

        For Each file In My.Computer.FileSystem.GetFiles(srcdir)

            If file.EndsWith(".jpg") Or file.EndsWith(".jpeg") Then
                imgfiles.Add(file)
            End If

        Next

        For Each picture In imgfiles
            lb_images.Items.Add(picture)
        Next
    End Sub

    Private Sub nextimage()
        If lb_images.Items.Count > 0 Then
            Panel1.BackgroundImageLayout = ImageLayout.Stretch
            Panel1.BackgroundImage = System.Drawing.Image.FromFile(lb_images.Items(0))
            tb_act_image.Text = lb_images.Items(0)
            lb_images.Items.RemoveAt(0)
        Else
            Panel1.BackgroundImage = Nothing
            lbl_done.Text = "DONE"
            KEINEBILDERMEHR = True
        End If
    End Sub


    Private Sub main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        getFilenamesFromSource()
        nextimage()
        Panel1.Focus()
    End Sub

    Private Sub Panel1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseClick

        If Not KEINEBILDERMEHR Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                Dim filenameWOpath() As String
                filenameWOpath = tb_act_image.Text.Split("\")
                Panel1.BackgroundImage = Nothing
                My.Computer.FileSystem.CopyFile(tb_act_image.Text, FBD_sourceDir.SelectedPath + "\1\" + filenameWOpath(filenameWOpath.Count - 1))
                nextimage()
            End If

            If e.Button = Windows.Forms.MouseButtons.Right Then
                Dim filenameWOpath() As String
                filenameWOpath = tb_act_image.Text.Split("\")
                Panel1.BackgroundImage = Nothing
                My.Computer.FileSystem.CopyFile(tb_act_image.Text, FBD_sourceDir.SelectedPath + "\2\" + filenameWOpath(filenameWOpath.Count - 1))
                nextimage()
            End If
        End If

    End Sub
End Class
