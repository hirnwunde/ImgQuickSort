Public Class main

    Dim KEINEBILDERMEHR As Boolean = False

    Private Sub getFilenamesFromSource()
        FBD_sourceDir.SelectedPath = "Z:\Bilder\&&_" 'My.Computer.FileSystem.SpecialDirectories.MyPictures
        FBD_sourceDir.ShowDialog()

        Dim srcdir As String = FBD_sourceDir.SelectedPath
        Dim imgfiles As New List(Of String)

        For Each file In My.Computer.FileSystem.GetFiles(srcdir)

            If file.EndsWith(".jpg") Or file.EndsWith(".jpeg") _
            Or file.EndsWith(".png") Or file.EndsWith(".bmp") _
            Or file.EndsWith(".gif") Or file.EndsWith(".wmf") Then
                imgfiles.Add(file)
            End If

        Next

        For Each picture In imgfiles
            lb_images.Items.Add(picture)
        Next
    End Sub

    Private Sub nextimage()
        If lb_images.Items.Count > 0 Then
            Dim tmpimg As String
            tmpimg = My.Computer.FileSystem.SpecialDirectories.Temp + "\ImgQuickSort.tmp"

            If My.Computer.FileSystem.FileExists(tmpimg) Then
                Panel1.BackgroundImage = Nothing
                System.Drawing.Image.FromFile(tmpimg).Dispose()
                My.Computer.FileSystem.DeleteFile(tmpimg)
            End If

            My.Computer.FileSystem.CopyFile(lb_images.Items(0), tmpimg)

            Panel1.BackgroundImageLayout = ImageLayout.Stretch
            Panel1.BackgroundImage = System.Drawing.Image.FromFile(tmpimg)
            tb_act_image.Text = lb_images.Items(0)
            lb_images.Items.RemoveAt(0)
        Else
            Panel1.BackgroundImage = Nothing
            lbl_done.Text = "DONE"
            KEINEBILDERMEHR = True
        End If
    End Sub


    Private Sub Panel1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseClick

        If Not KEINEBILDERMEHR Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                Dim filenameWOpath() As String
                filenameWOpath = tb_act_image.Text.Split("\")
                Panel1.BackgroundImage = Nothing
                My.Computer.FileSystem.MoveFile(tb_act_image.Text, tb_leftDir.Text + "\" + filenameWOpath(filenameWOpath.Count - 1))
                nextimage()
            End If

            If e.Button = Windows.Forms.MouseButtons.Right Then
                Dim filenameWOpath() As String
                filenameWOpath = tb_act_image.Text.Split("\")
                Panel1.BackgroundImage = Nothing
                My.Computer.FileSystem.MoveFile(tb_act_image.Text, tb_rightDir.Text + "\" + filenameWOpath(filenameWOpath.Count - 1))
                nextimage()
            End If
        End If

    End Sub

    Private Sub btn_chooseLeftDir_Click(sender As System.Object, e As System.EventArgs) Handles btn_chooseLeftDir.Click
        Dim leftdir As New FolderBrowserDialog
        leftdir.SelectedPath = My.Computer.FileSystem.SpecialDirectories.Desktop
        leftdir.ShowDialog()
        tb_leftDir.Text = leftdir.SelectedPath
    End Sub

    Private Sub btn_chooseRightDir_Click(sender As System.Object, e As System.EventArgs) Handles btn_chooseRightDir.Click
        Dim rightdir As New FolderBrowserDialog
        rightdir.SelectedPath = My.Computer.FileSystem.SpecialDirectories.Desktop
        rightdir.ShowDialog()
        tb_rightDir.Text = rightdir.SelectedPath
    End Sub

    Private Sub btn_go_Click(sender As System.Object, e As System.EventArgs) Handles btn_go.Click
        getFilenamesFromSource()
        nextimage()
        Panel1.Focus()
    End Sub
End Class
