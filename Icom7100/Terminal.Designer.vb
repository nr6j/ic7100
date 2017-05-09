<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Terminal
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
        Me.components = New System.ComponentModel.Container()
        Me.BtnInit = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.RtxOutput = New System.Windows.Forms.RichTextBox()
        Me.CmbPort = New System.Windows.Forms.ComboBox()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.btnScreen0 = New System.Windows.Forms.Button()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.btnscreen1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnInit
        '
        Me.BtnInit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInit.Location = New System.Drawing.Point(698, 146)
        Me.BtnInit.Name = "BtnInit"
        Me.BtnInit.Size = New System.Drawing.Size(80, 38)
        Me.BtnInit.TabIndex = 0
        Me.BtnInit.Text = "Init"
        Me.BtnInit.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(698, 190)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(80, 38)
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'RtxOutput
        '
        Me.RtxOutput.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtxOutput.Location = New System.Drawing.Point(26, 48)
        Me.RtxOutput.Name = "RtxOutput"
        Me.RtxOutput.Size = New System.Drawing.Size(655, 410)
        Me.RtxOutput.TabIndex = 4
        Me.RtxOutput.Text = ""
        '
        'CmbPort
        '
        Me.CmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPort.FormattingEnabled = True
        Me.CmbPort.Location = New System.Drawing.Point(698, 65)
        Me.CmbPort.Name = "CmbPort"
        Me.CmbPort.Size = New System.Drawing.Size(121, 28)
        Me.CmbPort.TabIndex = 7
        '
        'btnScreen0
        '
        Me.btnScreen0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScreen0.Location = New System.Drawing.Point(698, 277)
        Me.btnScreen0.Name = "btnScreen0"
        Me.btnScreen0.Size = New System.Drawing.Size(80, 38)
        Me.btnScreen0.TabIndex = 9
        Me.btnScreen0.Text = "Screen0"
        Me.btnScreen0.UseVisualStyleBackColor = True
        '
        'btnCapture
        '
        Me.btnCapture.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapture.Location = New System.Drawing.Point(698, 406)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(80, 38)
        Me.btnCapture.TabIndex = 11
        Me.btnCapture.Text = "Capture"
        Me.btnCapture.UseVisualStyleBackColor = True
        '
        'btnscreen1
        '
        Me.btnscreen1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnscreen1.Location = New System.Drawing.Point(698, 321)
        Me.btnscreen1.Name = "btnscreen1"
        Me.btnscreen1.Size = New System.Drawing.Size(80, 38)
        Me.btnscreen1.TabIndex = 12
        Me.btnscreen1.Text = "Screen1"
        Me.btnscreen1.UseVisualStyleBackColor = True
        '
        'Terminal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(833, 468)
        Me.Controls.Add(Me.btnscreen1)
        Me.Controls.Add(Me.btnCapture)
        Me.Controls.Add(Me.btnScreen0)
        Me.Controls.Add(Me.CmbPort)
        Me.Controls.Add(Me.RtxOutput)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnInit)
        Me.Name = "Terminal"
        Me.Text = "Setup"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnInit As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents RtxOutput As RichTextBox
    Friend WithEvents CmbPort As ComboBox
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents btnScreen0 As Button
    Friend WithEvents btnCapture As Button
    Friend WithEvents btnscreen1 As Button
End Class
