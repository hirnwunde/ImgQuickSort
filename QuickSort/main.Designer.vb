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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FBD_sourceDir = New System.Windows.Forms.FolderBrowserDialog()
        Me.lb_images = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_done = New System.Windows.Forms.Label()
        Me.tb_act_image = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(755, 477)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(665, 484)
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
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 512)
        Me.Controls.Add(Me.tb_act_image)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lb_images)
        Me.Controls.Add(Me.Button1)
        Me.Name = "main"
        Me.Text = "QuickSort"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FBD_sourceDir As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lb_images As System.Windows.Forms.ListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_done As System.Windows.Forms.Label
    Friend WithEvents tb_act_image As System.Windows.Forms.TextBox

End Class
