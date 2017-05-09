<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSlash = New System.Windows.Forms.Label()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnButton1 = New System.Windows.Forms.Button()
        Me.btnButton2 = New System.Windows.Forms.Button()
        Me.btnButton3 = New System.Windows.Forms.Button()
        Me.btnButton4 = New System.Windows.Forms.Button()
        Me.lblPage = New System.Windows.Forms.Label()
        Me.lblPages = New System.Windows.Forms.Label()
        Me.lblButton1 = New System.Windows.Forms.Label()
        Me.pgbButton1 = New System.Windows.Forms.ProgressBar()
        Me.pgbButton2 = New System.Windows.Forms.ProgressBar()
        Me.pgbButton3 = New System.Windows.Forms.ProgressBar()
        Me.pgbButton4 = New System.Windows.Forms.ProgressBar()
        Me.lblButton2 = New System.Windows.Forms.Label()
        Me.lblButton3 = New System.Windows.Forms.Label()
        Me.lblButton4 = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(-2, -2)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(427, 45)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Set"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSlash
        '
        Me.lblSlash.AutoSize = True
        Me.lblSlash.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlash.Location = New System.Drawing.Point(1208, 2)
        Me.lblSlash.Name = "lblSlash"
        Me.lblSlash.Size = New System.Drawing.Size(26, 37)
        Me.lblSlash.TabIndex = 1
        Me.lblSlash.Text = "/"
        Me.lblSlash.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnUp
        '
        Me.btnUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.Location = New System.Drawing.Point(1191, 77)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(75, 198)
        Me.btnUp.TabIndex = 2
        Me.btnUp.Text = "^"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDown.Location = New System.Drawing.Point(1191, 281)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(75, 198)
        Me.btnDown.TabIndex = 3
        Me.btnDown.Text = "v"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(1191, 556)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 104)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "<"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnButton1
        '
        Me.btnButton1.BackColor = System.Drawing.Color.LightGray
        Me.btnButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnButton1.Location = New System.Drawing.Point(5, 50)
        Me.btnButton1.Name = "btnButton1"
        Me.btnButton1.Size = New System.Drawing.Size(1165, 149)
        Me.btnButton1.TabIndex = 5
        Me.btnButton1.Text = "Button1"
        Me.btnButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnButton1.UseVisualStyleBackColor = False
        '
        'btnButton2
        '
        Me.btnButton2.BackColor = System.Drawing.Color.LightGray
        Me.btnButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnButton2.Location = New System.Drawing.Point(5, 205)
        Me.btnButton2.Name = "btnButton2"
        Me.btnButton2.Size = New System.Drawing.Size(1165, 149)
        Me.btnButton2.TabIndex = 6
        Me.btnButton2.Text = "Button2"
        Me.btnButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnButton2.UseVisualStyleBackColor = False
        '
        'btnButton3
        '
        Me.btnButton3.BackColor = System.Drawing.Color.LightGray
        Me.btnButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnButton3.Location = New System.Drawing.Point(5, 360)
        Me.btnButton3.Name = "btnButton3"
        Me.btnButton3.Size = New System.Drawing.Size(1165, 149)
        Me.btnButton3.TabIndex = 7
        Me.btnButton3.Text = "Button3"
        Me.btnButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnButton3.UseVisualStyleBackColor = False
        '
        'btnButton4
        '
        Me.btnButton4.BackColor = System.Drawing.Color.LightGray
        Me.btnButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnButton4.Location = New System.Drawing.Point(5, 515)
        Me.btnButton4.Name = "btnButton4"
        Me.btnButton4.Size = New System.Drawing.Size(1165, 149)
        Me.btnButton4.TabIndex = 8
        Me.btnButton4.Text = "Button4"
        Me.btnButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnButton4.UseVisualStyleBackColor = False
        '
        'lblPage
        '
        Me.lblPage.AutoSize = True
        Me.lblPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPage.Location = New System.Drawing.Point(1176, 2)
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Size = New System.Drawing.Size(33, 37)
        Me.lblPage.TabIndex = 9
        Me.lblPage.Text = "1"
        Me.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPages
        '
        Me.lblPages.AutoSize = True
        Me.lblPages.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPages.Location = New System.Drawing.Point(1231, 2)
        Me.lblPages.Name = "lblPages"
        Me.lblPages.Size = New System.Drawing.Size(35, 37)
        Me.lblPages.TabIndex = 10
        Me.lblPages.Text = "4"
        Me.lblPages.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblButton1
        '
        Me.lblButton1.BackColor = System.Drawing.Color.LightGray
        Me.lblButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblButton1.Location = New System.Drawing.Point(891, 128)
        Me.lblButton1.Name = "lblButton1"
        Me.lblButton1.Size = New System.Drawing.Size(270, 60)
        Me.lblButton1.TabIndex = 11
        Me.lblButton1.Text = "100%"
        Me.lblButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pgbButton1
        '
        Me.pgbButton1.BackColor = System.Drawing.Color.LightGray
        Me.pgbButton1.Location = New System.Drawing.Point(891, 87)
        Me.pgbButton1.Name = "pgbButton1"
        Me.pgbButton1.Size = New System.Drawing.Size(270, 23)
        Me.pgbButton1.TabIndex = 12
        Me.pgbButton1.Value = 50
        '
        'pgbButton2
        '
        Me.pgbButton2.BackColor = System.Drawing.Color.LightGray
        Me.pgbButton2.Location = New System.Drawing.Point(891, 241)
        Me.pgbButton2.Name = "pgbButton2"
        Me.pgbButton2.Size = New System.Drawing.Size(270, 23)
        Me.pgbButton2.TabIndex = 13
        Me.pgbButton2.Value = 50
        '
        'pgbButton3
        '
        Me.pgbButton3.BackColor = System.Drawing.Color.LightGray
        Me.pgbButton3.Location = New System.Drawing.Point(891, 395)
        Me.pgbButton3.Name = "pgbButton3"
        Me.pgbButton3.Size = New System.Drawing.Size(270, 23)
        Me.pgbButton3.TabIndex = 14
        Me.pgbButton3.Value = 50
        '
        'pgbButton4
        '
        Me.pgbButton4.BackColor = System.Drawing.Color.LightGray
        Me.pgbButton4.Location = New System.Drawing.Point(891, 540)
        Me.pgbButton4.Name = "pgbButton4"
        Me.pgbButton4.Size = New System.Drawing.Size(270, 23)
        Me.pgbButton4.TabIndex = 15
        Me.pgbButton4.Value = 50
        '
        'lblButton2
        '
        Me.lblButton2.BackColor = System.Drawing.Color.LightGray
        Me.lblButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblButton2.Location = New System.Drawing.Point(891, 281)
        Me.lblButton2.Name = "lblButton2"
        Me.lblButton2.Size = New System.Drawing.Size(270, 60)
        Me.lblButton2.TabIndex = 16
        Me.lblButton2.Text = "100%"
        Me.lblButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblButton3
        '
        Me.lblButton3.BackColor = System.Drawing.Color.LightGray
        Me.lblButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblButton3.Location = New System.Drawing.Point(891, 438)
        Me.lblButton3.Name = "lblButton3"
        Me.lblButton3.Size = New System.Drawing.Size(270, 60)
        Me.lblButton3.TabIndex = 17
        Me.lblButton3.Text = "100%"
        Me.lblButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblButton4
        '
        Me.lblButton4.BackColor = System.Drawing.Color.LightGray
        Me.lblButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblButton4.Location = New System.Drawing.Point(891, 584)
        Me.lblButton4.Name = "lblButton4"
        Me.lblButton4.Size = New System.Drawing.Size(270, 60)
        Me.lblButton4.TabIndex = 18
        Me.lblButton4.Text = "100%"
        Me.lblButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInfo
        '
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(447, -2)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(427, 45)
        Me.lblInfo.TabIndex = 19
        Me.lblInfo.Text = "Info"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SetForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1265, 672)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblButton4)
        Me.Controls.Add(Me.lblButton3)
        Me.Controls.Add(Me.lblButton2)
        Me.Controls.Add(Me.pgbButton4)
        Me.Controls.Add(Me.pgbButton3)
        Me.Controls.Add(Me.pgbButton2)
        Me.Controls.Add(Me.pgbButton1)
        Me.Controls.Add(Me.lblButton1)
        Me.Controls.Add(Me.lblPages)
        Me.Controls.Add(Me.lblPage)
        Me.Controls.Add(Me.btnButton4)
        Me.Controls.Add(Me.btnButton3)
        Me.Controls.Add(Me.btnButton2)
        Me.Controls.Add(Me.btnButton1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.lblSlash)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "SetForm"
        Me.Text = "SetForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSlash As Label
    Friend WithEvents btnUp As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnButton1 As Button
    Friend WithEvents btnButton2 As Button
    Friend WithEvents btnButton3 As Button
    Friend WithEvents btnButton4 As Button
    Friend WithEvents lblPage As Label
    Friend WithEvents lblPages As Label
    Friend WithEvents lblButton1 As Label
    Friend WithEvents pgbButton1 As ProgressBar
    Friend WithEvents pgbButton2 As ProgressBar
    Friend WithEvents pgbButton3 As ProgressBar
    Friend WithEvents pgbButton4 As ProgressBar
    Friend WithEvents lblButton2 As Label
    Friend WithEvents lblButton3 As Label
    Friend WithEvents lblButton4 As Label
    Friend WithEvents lblInfo As Label
End Class
