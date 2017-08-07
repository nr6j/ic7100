<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BtnWrite = New System.Windows.Forms.Button()
        Me.RtxInput = New System.Windows.Forms.RichTextBox()
        Me.RtxOutput = New System.Windows.Forms.RichTextBox()
        Me.LblInput = New System.Windows.Forms.Label()
        Me.LblOutput = New System.Windows.Forms.Label()
        Me.CmbPort = New System.Windows.Forms.ComboBox()
        Me.CmbBaud = New System.Windows.Forms.ComboBox()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.SuspendLayout()
        '
        'BtnInit
        '
        Me.BtnInit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInit.Location = New System.Drawing.Point(1023, 48)
        Me.BtnInit.Name = "BtnInit"
        Me.BtnInit.Size = New System.Drawing.Size(75, 38)
        Me.BtnInit.TabIndex = 0
        Me.BtnInit.Text = "Init"
        Me.BtnInit.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(1023, 96)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 38)
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnWrite
        '
        Me.BtnWrite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWrite.Location = New System.Drawing.Point(772, 48)
        Me.BtnWrite.Name = "BtnWrite"
        Me.BtnWrite.Size = New System.Drawing.Size(75, 38)
        Me.BtnWrite.TabIndex = 2
        Me.BtnWrite.Text = "Write"
        Me.BtnWrite.UseVisualStyleBackColor = True
        '
        'RtxInput
        '
        Me.RtxInput.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtxInput.Location = New System.Drawing.Point(26, 48)
        Me.RtxInput.Name = "RtxInput"
        Me.RtxInput.Size = New System.Drawing.Size(717, 126)
        Me.RtxInput.TabIndex = 3
        Me.RtxInput.Text = ""
        '
        'RtxOutput
        '
        Me.RtxOutput.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtxOutput.Location = New System.Drawing.Point(26, 204)
        Me.RtxOutput.Name = "RtxOutput"
        Me.RtxOutput.Size = New System.Drawing.Size(1074, 126)
        Me.RtxOutput.TabIndex = 4
        Me.RtxOutput.Text = ""
        '
        'LblInput
        '
        Me.LblInput.AutoSize = True
        Me.LblInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInput.Location = New System.Drawing.Point(26, 26)
        Me.LblInput.Name = "LblInput"
        Me.LblInput.Size = New System.Drawing.Size(46, 20)
        Me.LblInput.TabIndex = 5
        Me.LblInput.Text = "Input"
        '
        'LblOutput
        '
        Me.LblOutput.AutoSize = True
        Me.LblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOutput.Location = New System.Drawing.Point(26, 185)
        Me.LblOutput.Name = "LblOutput"
        Me.LblOutput.Size = New System.Drawing.Size(58, 20)
        Me.LblOutput.TabIndex = 6
        Me.LblOutput.Text = "Output"
        '
        'CmbPort
        '
        Me.CmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPort.FormattingEnabled = True
        Me.CmbPort.Location = New System.Drawing.Point(873, 48)
        Me.CmbPort.Name = "CmbPort"
        Me.CmbPort.Size = New System.Drawing.Size(121, 28)
        Me.CmbPort.TabIndex = 7
        '
        'CmbBaud
        '
        Me.CmbBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBaud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBaud.FormattingEnabled = True
        Me.CmbBaud.Items.AddRange(New Object() {"9600", "38400", "57600", "115200"})
        Me.CmbBaud.Location = New System.Drawing.Point(873, 96)
        Me.CmbBaud.Name = "CmbBaud"
        Me.CmbBaud.Size = New System.Drawing.Size(121, 28)
        Me.CmbBaud.TabIndex = 8
        '
        'SerialPort
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1128, 358)
        Me.Controls.Add(Me.CmbBaud)
        Me.Controls.Add(Me.CmbPort)
        Me.Controls.Add(Me.LblOutput)
        Me.Controls.Add(Me.LblInput)
        Me.Controls.Add(Me.RtxOutput)
        Me.Controls.Add(Me.RtxInput)
        Me.Controls.Add(Me.BtnWrite)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnInit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnInit As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnWrite As Button
    Friend WithEvents RtxInput As RichTextBox
    Friend WithEvents RtxOutput As RichTextBox
    Friend WithEvents LblInput As Label
    Friend WithEvents LblOutput As Label
    Friend WithEvents CmbPort As ComboBox
    Friend WithEvents CmbBaud As ComboBox
    Friend WithEvents SerialPort As IO.Ports.SerialPort
End Class
