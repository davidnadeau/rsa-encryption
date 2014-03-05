<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RSA
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.encrypted = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.decrypted = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.nval = New System.Windows.Forms.TextBox()
        Me.eval = New System.Windows.Forms.TextBox()
        Me.dval = New System.Windows.Forms.TextBox()
        Me.nval1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.prime1 = New System.Windows.Forms.Label()
        Me.prime2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.nnnn = New System.Windows.Forms.Label()
        Me.nvalue = New System.Windows.Forms.Label()
        Me.evalue = New System.Windows.Forms.Label()
        Me.dddd = New System.Windows.Forms.Label()
        Me.dvalue = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.decodoed = New System.Windows.Forms.Label()
        Me.inputmsg = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input Message"
        '
        'encrypted
        '
        Me.encrypted.Location = New System.Drawing.Point(7, 42)
        Me.encrypted.Name = "encrypted"
        Me.encrypted.Size = New System.Drawing.Size(207, 20)
        Me.encrypted.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(407, 42)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Encrypt"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'decrypted
        '
        Me.decrypted.Location = New System.Drawing.Point(7, 71)
        Me.decrypted.Name = "decrypted"
        Me.decrypted.Size = New System.Drawing.Size(207, 20)
        Me.decrypted.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(407, 68)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Decrypt"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'nval
        '
        Me.nval.Location = New System.Drawing.Point(237, 42)
        Me.nval.Name = "nval"
        Me.nval.Size = New System.Drawing.Size(75, 20)
        Me.nval.TabIndex = 10
        '
        'eval
        '
        Me.eval.Location = New System.Drawing.Point(340, 45)
        Me.eval.Name = "eval"
        Me.eval.Size = New System.Drawing.Size(61, 20)
        Me.eval.TabIndex = 11
        '
        'dval
        '
        Me.dval.Location = New System.Drawing.Point(340, 68)
        Me.dval.Name = "dval"
        Me.dval.Size = New System.Drawing.Size(61, 20)
        Me.dval.TabIndex = 13
        '
        'nval1
        '
        Me.nval1.Location = New System.Drawing.Point(237, 70)
        Me.nval1.Name = "nval1"
        Me.nval1.Size = New System.Drawing.Size(75, 20)
        Me.nval1.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Prime 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Prime 2:"
        '
        'prime1
        '
        Me.prime1.AutoSize = True
        Me.prime1.Location = New System.Drawing.Point(66, 22)
        Me.prime1.Name = "prime1"
        Me.prime1.Size = New System.Drawing.Size(0, 13)
        Me.prime1.TabIndex = 16
        '
        'prime2
        '
        Me.prime2.AutoSize = True
        Me.prime2.Location = New System.Drawing.Point(145, 22)
        Me.prime2.Name = "prime2"
        Me.prime2.Size = New System.Drawing.Size(0, 13)
        Me.prime2.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(47, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Generate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'nnnn
        '
        Me.nnnn.AutoSize = True
        Me.nnnn.Location = New System.Drawing.Point(44, 44)
        Me.nnnn.Name = "nnnn"
        Me.nnnn.Size = New System.Drawing.Size(16, 13)
        Me.nnnn.TabIndex = 19
        Me.nnnn.Text = "n:"
        '
        'nvalue
        '
        Me.nvalue.AutoSize = True
        Me.nvalue.Location = New System.Drawing.Point(66, 44)
        Me.nvalue.Name = "nvalue"
        Me.nvalue.Size = New System.Drawing.Size(0, 13)
        Me.nvalue.TabIndex = 20
        '
        'evalue
        '
        Me.evalue.AutoSize = True
        Me.evalue.Location = New System.Drawing.Point(66, 64)
        Me.evalue.Name = "evalue"
        Me.evalue.Size = New System.Drawing.Size(0, 13)
        Me.evalue.TabIndex = 22
        '
        'dddd
        '
        Me.dddd.AutoSize = True
        Me.dddd.Location = New System.Drawing.Point(44, 64)
        Me.dddd.Name = "dddd"
        Me.dddd.Size = New System.Drawing.Size(16, 13)
        Me.dddd.TabIndex = 21
        Me.dddd.Text = "e:"
        '
        'dvalue
        '
        Me.dvalue.AutoSize = True
        Me.dvalue.Location = New System.Drawing.Point(66, 87)
        Me.dvalue.Name = "dvalue"
        Me.dvalue.Size = New System.Drawing.Size(0, 13)
        Me.dvalue.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "d:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(220, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "n:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(318, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "e:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(220, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "n:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(318, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "d:"
        '
        'decodoed
        '
        Me.decodoed.AutoSize = True
        Me.decodoed.Location = New System.Drawing.Point(6, 110)
        Me.decodoed.Name = "decodoed"
        Me.decodoed.Size = New System.Drawing.Size(80, 13)
        Me.decodoed.TabIndex = 29
        Me.decodoed.Text = "Input Message:"
        '
        'inputmsg
        '
        Me.inputmsg.AutoSize = True
        Me.inputmsg.Location = New System.Drawing.Point(92, 110)
        Me.inputmsg.Name = "inputmsg"
        Me.inputmsg.Size = New System.Drawing.Size(48, 13)
        Me.inputmsg.TabIndex = 34
        Me.inputmsg.Text = "No Input"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.prime1)
        Me.GroupBox1.Controls.Add(Me.prime2)
        Me.GroupBox1.Controls.Add(Me.nnnn)
        Me.GroupBox1.Controls.Add(Me.nvalue)
        Me.GroupBox1.Controls.Add(Me.dvalue)
        Me.GroupBox1.Controls.Add(Me.dddd)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.evalue)
        Me.GroupBox1.Location = New System.Drawing.Point(560, 258)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(176, 140)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generate Values"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.inputmsg)
        Me.GroupBox2.Controls.Add(Me.encrypted)
        Me.GroupBox2.Controls.Add(Me.decodoed)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.decrypted)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.nval)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.eval)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.nval1)
        Me.GroupBox2.Controls.Add(Me.dval)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 258)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(519, 140)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Encryption Testing"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RSA.My.Resources.Resources.encryption_lock
        Me.PictureBox2.Location = New System.Drawing.Point(526, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(226, 238)
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RSA.My.Resources.Resources._73e32626e890fe762d165f802bad2a395ece03ac
        Me.PictureBox1.Location = New System.Drawing.Point(12, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(456, 238)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'RSA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(764, 417)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "RSA"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents encrypted As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents decrypted As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents nval As System.Windows.Forms.TextBox
    Friend WithEvents eval As System.Windows.Forms.TextBox
    Friend WithEvents dval As System.Windows.Forms.TextBox
    Friend WithEvents nval1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents prime1 As System.Windows.Forms.Label
    Friend WithEvents prime2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents nnnn As System.Windows.Forms.Label
    Friend WithEvents nvalue As System.Windows.Forms.Label
    Friend WithEvents evalue As System.Windows.Forms.Label
    Friend WithEvents dddd As System.Windows.Forms.Label
    Friend WithEvents dvalue As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents decodoed As System.Windows.Forms.Label
    Friend WithEvents inputmsg As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
