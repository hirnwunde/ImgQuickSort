<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FBD_sourceDir = New System.Windows.Forms.FolderBrowserDialog()
        Me.lb_images = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_done = New System.Windows.Forms.Label()
        Me.tb_act_image = New System.Windows.Forms.TextBox()
        Me.btn_chooseLeftDir = New System.Windows.Forms.Button()
        Me.tb_leftDir = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_rightDir = New System.Windows.Forms.TextBox()
        Me.btn_chooseRightDir = New System.Windows.Forms.Button()
        Me.btn_go = New System.Windows.Forms.Button()
        Me.lbl_filesCntLeft = New System.Windows.Forms.Label()
        Me.lbl_filesCntRight = New System.Windows.Forms.Label()
        Me.lbl_filesSummary = New System.Windows.Forms.Label()
        Me.lbl_filesProcessed = New System.Windows.Forms.Label()
        Me.lbl_filesToProcess = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_images
        '
        Me.lb_images.FormattingEnabled = True
        Me.lb_images.Location = New System.Drawing.Point(712, 12)
        Me.lb_images.Name = "lb_images"
        Me.lb_images.Size = New System.Drawing.Size(146, 199)
        Me.lb_images.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_done)
        Me.Panel1.Location = New System.Drawing.Point(12, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(665, 426)
        Me.Panel1.TabIndex = 16
        '
        'lbl_done
        '
        Me.lbl_done.AutoSize = True
        Me.lbl_done.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_done.Location = New System.Drawing.Point(146, 185)
        Me.lbl_done.Name = "lbl_done"
        Me.lbl_done.Size = New System.Drawing.Size(0, 108)
        Me.lbl_done.TabIndex = 0
        '
        'tb_act_image
        '
        Me.tb_act_image.Location = New System.Drawing.Point(712, 218)
        Me.tb_act_image.Name = "tb_act_image"
        Me.tb_act_image.Size = New System.Drawing.Size(146, 20)
        Me.tb_act_image.TabIndex = 17
        '
        'btn_chooseLeftDir
        '
        Me.btn_chooseLeftDir.Location = New System.Drawing.Point(293, 3)
        Me.btn_chooseLeftDir.Name = "btn_chooseLeftDir"
        Me.btn_chooseLeftDir.Size = New System.Drawing.Size(33, 23)
        Me.btn_chooseLeftDir.TabIndex = 18
        Me.btn_chooseLeftDir.Text = "..."
        Me.btn_chooseLeftDir.UseVisualStyleBackColor = True
        '
        'tb_leftDir
        '
        Me.tb_leftDir.Location = New System.Drawing.Point(42, 6)
        Me.tb_leftDir.Name = "tb_leftDir"
        Me.tb_leftDir.Size = New System.Drawing.Size(245, 20)
        Me.tb_leftDir.TabIndex = 19
        Me.tb_leftDir.Text = "d:\tmp\1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "left:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(356, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "right:"
        '
        'tb_rightDir
        '
        Me.tb_rightDir.Location = New System.Drawing.Point(392, 6)
        Me.tb_rightDir.Name = "tb_rightDir"
        Me.tb_rightDir.Size = New System.Drawing.Size(245, 20)
        Me.tb_rightDir.TabIndex = 22
        Me.tb_rightDir.Text = "d:\tmp\2"
        '
        'btn_chooseRightDir
        '
        Me.btn_chooseRightDir.Location = New System.Drawing.Point(643, 3)
        Me.btn_chooseRightDir.Name = "btn_chooseRightDir"
        Me.btn_chooseRightDir.Size = New System.Drawing.Size(33, 23)
        Me.btn_chooseRightDir.TabIndex = 21
        Me.btn_chooseRightDir.Text = "..."
        Me.btn_chooseRightDir.UseVisualStyleBackColor = True
        '
        'btn_go
        '
        Me.btn_go.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_go.Location = New System.Drawing.Point(293, 32)
        Me.btn_go.Name = "btn_go"
        Me.btn_go.Size = New System.Drawing.Size(93, 32)
        Me.btn_go.TabIndex = 24
        Me.btn_go.Text = "GO!"
        Me.btn_go.UseVisualStyleBackColor = True
        '
        'lbl_filesCntLeft
        '
        Me.lbl_filesCntLeft.AutoSize = True
        Me.lbl_filesCntLeft.Location = New System.Drawing.Point(12, 50)
        Me.lbl_filesCntLeft.Name = "lbl_filesCntLeft"
        Me.lbl_filesCntLeft.Size = New System.Drawing.Size(70, 13)
        Me.lbl_filesCntLeft.TabIndex = 25
        Me.lbl_filesCntLeft.Text = "files in left dir:"
        '
        'lbl_filesCntRight
        '
        Me.lbl_filesCntRight.AutoSize = True
        Me.lbl_filesCntRight.Location = New System.Drawing.Point(392, 50)
        Me.lbl_filesCntRight.Name = "lbl_filesCntRight"
        Me.lbl_filesCntRight.Size = New System.Drawing.Size(76, 13)
        Me.lbl_filesCntRight.TabIndex = 26
        Me.lbl_filesCntRight.Text = "files in right dir:"
        '
        'lbl_filesSummary
        '
        Me.lbl_filesSummary.AutoSize = True
        Me.lbl_filesSummary.Location = New System.Drawing.Point(12, 514)
        Me.lbl_filesSummary.Name = "lbl_filesSummary"
        Me.lbl_filesSummary.Size = New System.Drawing.Size(72, 13)
        Me.lbl_filesSummary.TabIndex = 27
        Me.lbl_filesSummary.Text = "files summary:"
        '
        'lbl_filesProcessed
        '
        Me.lbl_filesProcessed.AutoSize = True
        Me.lbl_filesProcessed.Location = New System.Drawing.Point(290, 514)
        Me.lbl_filesProcessed.Name = "lbl_filesProcessed"
        Me.lbl_filesProcessed.Size = New System.Drawing.Size(80, 13)
        Me.lbl_filesProcessed.TabIndex = 28
        Me.lbl_filesProcessed.Text = "files processed:"
        '
        'lbl_filesToProcess
        '
        Me.lbl_filesToProcess.AutoSize = True
        Me.lbl_filesToProcess.Location = New System.Drawing.Point(528, 514)
        Me.lbl_filesToProcess.Name = "lbl_filesToProcess"
        Me.lbl_filesToProcess.Size = New System.Drawing.Size(80, 13)
        Me.lbl_filesToProcess.TabIndex = 29
        Me.lbl_filesToProcess.Text = "files to process:"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 539)
        Me.Controls.Add(Me.lbl_filesToProcess)
        Me.Controls.Add(Me.lbl_filesProcessed)
        Me.Controls.Add(Me.lbl_filesSummary)
        Me.Controls.Add(Me.lbl_filesCntRight)
        Me.Controls.Add(Me.lbl_filesCntLeft)
        Me.Controls.Add(Me.btn_go)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_rightDir)
        Me.Controls.Add(Me.btn_chooseRightDir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_leftDir)
        Me.Controls.Add(Me.btn_chooseLeftDir)
        Me.Controls.Add(Me.tb_act_image)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lb_images)
        Me.Name = "main"
        Me.Text = "ImgQuickSort"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FBD_sourceDir As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lb_images As System.Windows.Forms.ListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_done As System.Windows.Forms.Label
    Friend WithEvents tb_act_image As System.Windows.Forms.TextBox
    Friend WithEvents btn_chooseLeftDir As System.Windows.Forms.Button
    Friend WithEvents tb_leftDir As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_rightDir As System.Windows.Forms.TextBox
    Friend WithEvents btn_chooseRightDir As System.Windows.Forms.Button
    Friend WithEvents btn_go As System.Windows.Forms.Button
    Friend WithEvents lbl_filesCntLeft As System.Windows.Forms.Label
    Friend WithEvents lbl_filesCntRight As System.Windows.Forms.Label
    Friend WithEvents lbl_filesSummary As System.Windows.Forms.Label
    Friend WithEvents lbl_filesProcessed As System.Windows.Forms.Label
    Friend WithEvents lbl_filesToProcess As System.Windows.Forms.Label

End Class
