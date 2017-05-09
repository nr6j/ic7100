<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectForm
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
        Me.btnButton1 = New System.Windows.Forms.Button()
        Me.btnButton2 = New System.Windows.Forms.Button()
        Me.btnButton3 = New System.Windows.Forms.Button()
        Me.btnButton4 = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblPages = New System.Windows.Forms.Label()
        Me.lblPage = New System.Windows.Forms.Label()
        Me.lblSlash = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(-3, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(356, 45)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Set"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnButton1
        '
        Me.btnButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnButton1.Location = New System.Drawing.Point(3, 48)
        Me.btnButton1.Name = "btnButton1"
        Me.btnButton1.Size = New System.Drawing.Size(714, 149)
        Me.btnButton1.TabIndex = 6
        Me.btnButton1.Text = "Button1"
        Me.btnButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnButton1.UseVisualStyleBackColor = True
        '
        'btnButton2
        '
        Me.btnButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnButton2.Location = New System.Drawing.Point(3, 203)
        Me.btnButton2.Name = "btnButton2"
        Me.btnButton2.Size = New System.Drawing.Size(714, 149)
        Me.btnButton2.TabIndex = 7
        Me.btnButton2.Text = "Button2"
        Me.btnButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnButton2.UseVisualStyleBackColor = True
        '
        'btnButton3
        '
        Me.btnButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnButton3.Location = New System.Drawing.Point(3, 358)
        Me.btnButton3.Name = "btnButton3"
        Me.btnButton3.Size = New System.Drawing.Size(714, 149)
        Me.btnButton3.TabIndex = 8
        Me.btnButton3.Text = "Button3"
        Me.btnButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnButton3.UseVisualStyleBackColor = True
        '
        'btnButton4
        '
        Me.btnButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnButton4.Location = New System.Drawing.Point(3, 514)
        Me.btnButton4.Name = "btnButton4"
        Me.btnButton4.Size = New System.Drawing.Size(714, 149)
        Me.btnButton4.TabIndex = 9
        Me.btnButton4.Text = "Button4"
        Me.btnButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnButton4.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.Location = New System.Drawing.Point(736, 48)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(75, 198)
        Me.btnUp.TabIndex = 10
        Me.btnUp.Text = "^"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDown.Location = New System.Drawing.Point(736, 253)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(75, 198)
        Me.btnDown.TabIndex = 11
        Me.btnDown.Text = "v"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(736, 514)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 104)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "<"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblPages
        '
        Me.lblPages.AutoSize = True
        Me.lblPages.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPages.Location = New System.Drawing.Point(781, 4)
        Me.lblPages.Name = "lblPages"
        Me.lblPages.Size = New System.Drawing.Size(35, 37)
        Me.lblPages.TabIndex = 15
        Me.lblPages.Text = "4"
        Me.lblPages.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPage
        '
        Me.lblPage.AutoSize = True
        Me.lblPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPage.Location = New System.Drawing.Point(726, 4)
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Size = New System.Drawing.Size(33, 37)
        Me.lblPage.TabIndex = 14
        Me.lblPage.Text = "1"
        Me.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSlash
        '
        Me.lblSlash.AutoSize = True
        Me.lblSlash.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlash.Location = New System.Drawing.Point(758, 4)
        Me.lblSlash.Name = "lblSlash"
        Me.lblSlash.Size = New System.Drawing.Size(26, 37)
        Me.lblSlash.TabIndex = 13
        Me.lblSlash.Text = "/"
        Me.lblSlash.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SelectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 670)
        Me.Controls.Add(Me.lblPages)
        Me.Controls.Add(Me.lblPage)
        Me.Controls.Add(Me.lblSlash)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.btnButton4)
        Me.Controls.Add(Me.btnButton3)
        Me.Controls.Add(Me.btnButton2)
        Me.Controls.Add(Me.btnButton1)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "SelectForm"
        Me.Text = "OffOnForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnButton1 As Button
    Friend WithEvents btnButton2 As Button
    Friend WithEvents btnButton3 As Button
    Friend WithEvents btnButton4 As Button
    Friend WithEvents btnUp As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblPages As Label
    Friend WithEvents lblPage As Label
    Friend WithEvents lblSlash As Label
End Class
