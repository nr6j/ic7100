<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RxHistForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblRX = New System.Windows.Forms.Label()
        Me.lblCallSign = New System.Windows.Forms.Label()
        Me.lblTO = New System.Windows.Forms.Label()
        Me.lblFROM = New System.Windows.Forms.Label()
        Me.lblRepeat = New System.Windows.Forms.Label()
        Me.lblRPT = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(-1, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(356, 45)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "RX HISTORY"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.Location = New System.Drawing.Point(516, 0)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(60, 24)
        Me.lblClock.TabIndex = 63
        Me.lblClock.Text = "12:00"
        '
        'btnUp
        '
        Me.btnUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.Location = New System.Drawing.Point(516, 27)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(60, 135)
        Me.btnUp.TabIndex = 64
        Me.btnUp.Text = "^"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDown.Location = New System.Drawing.Point(516, 158)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(60, 139)
        Me.btnDown.TabIndex = 65
        Me.btnDown.Text = "v"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(516, 303)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(60, 90)
        Me.btnBack.TabIndex = 66
        Me.btnBack.Text = "<"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblRX
        '
        Me.lblRX.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRX.Location = New System.Drawing.Point(3, 45)
        Me.lblRX.Name = "lblRX"
        Me.lblRX.Size = New System.Drawing.Size(80, 23)
        Me.lblRX.TabIndex = 67
        Me.lblRX.Text = "RX01:"
        '
        'lblCallSign
        '
        Me.lblCallSign.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCallSign.Location = New System.Drawing.Point(27, 68)
        Me.lblCallSign.Name = "lblCallSign"
        Me.lblCallSign.Size = New System.Drawing.Size(328, 23)
        Me.lblCallSign.TabIndex = 68
        Me.lblCallSign.Text = "M6EYS"
        '
        'lblTO
        '
        Me.lblTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTO.Location = New System.Drawing.Point(27, 92)
        Me.lblTO.Name = "lblTO"
        Me.lblTO.Size = New System.Drawing.Size(328, 23)
        Me.lblTO.TabIndex = 69
        Me.lblTO.Text = "→ CQCQCQ"
        '
        'lblFROM
        '
        Me.lblFROM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFROM.Location = New System.Drawing.Point(27, 115)
        Me.lblFROM.Name = "lblFROM"
        Me.lblFROM.Size = New System.Drawing.Size(328, 23)
        Me.lblFROM.TabIndex = 70
        Me.lblFROM.Text = "STAFFORDSHIRE UK"
        '
        'lblRepeat
        '
        Me.lblRepeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepeat.Location = New System.Drawing.Point(27, 253)
        Me.lblRepeat.Name = "lblRepeat"
        Me.lblRepeat.Size = New System.Drawing.Size(56, 23)
        Me.lblRepeat.TabIndex = 71
        Me.lblRepeat.Text = "RPT:"
        '
        'lblRPT
        '
        Me.lblRPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRPT.Location = New System.Drawing.Point(89, 253)
        Me.lblRPT.Name = "lblRPT"
        Me.lblRPT.Size = New System.Drawing.Size(266, 23)
        Me.lblRPT.TabIndex = 72
        Me.lblRPT.Text = "W6BML  B"
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(27, 346)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(328, 23)
        Me.lblDate.TabIndex = 73
        Me.lblDate.Text = "(2017/02/25  10:41)"
        '
        'RxHistForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 395)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblRPT)
        Me.Controls.Add(Me.lblRepeat)
        Me.Controls.Add(Me.lblFROM)
        Me.Controls.Add(Me.lblTO)
        Me.Controls.Add(Me.lblCallSign)
        Me.Controls.Add(Me.lblRX)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "RxHistForm"
        Me.Text = "RxHistForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblClock As Label
    Friend WithEvents btnUp As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblRX As Label
    Friend WithEvents lblCallSign As Label
    Friend WithEvents lblTO As Label
    Friend WithEvents lblFROM As Label
    Friend WithEvents lblRepeat As Label
    Friend WithEvents lblRPT As Label
    Friend WithEvents lblDate As Label
End Class
