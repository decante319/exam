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
        Me.clear = New System.Windows.Forms.Button()
        Me.display = New System.Windows.Forms.Button()
        Me.label7 = New System.Windows.Forms.Label()
        Me.worktxt = New System.Windows.Forms.ComboBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.gendertxt = New System.Windows.Forms.ComboBox()
        Me.nametxt = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.phonetxt = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.agetxt = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.locationtxt = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.idtxt = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(247, 310)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(82, 28)
        Me.clear.TabIndex = 31
        Me.clear.Text = "CLEAR"
        Me.clear.UseVisualStyleBackColor = True
        '
        'display
        '
        Me.display.Location = New System.Drawing.Point(106, 310)
        Me.display.Name = "display"
        Me.display.Size = New System.Drawing.Size(82, 28)
        Me.display.TabIndex = 30
        Me.display.Text = "DISPLAY"
        Me.display.UseVisualStyleBackColor = True
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(125, 256)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(79, 23)
        Me.label7.TabIndex = 29
        Me.label7.Text = "OCCUPATION"
        Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'worktxt
        '
        Me.worktxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.worktxt.FormattingEnabled = True
        Me.worktxt.Items.AddRange(New Object() {"STUDENT", "FARMER", "TEACHER", "DOCTOR", "OTHER"})
        Me.worktxt.Location = New System.Drawing.Point(205, 258)
        Me.worktxt.Name = "worktxt"
        Me.worktxt.Size = New System.Drawing.Size(104, 21)
        Me.worktxt.TabIndex = 28
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(47, 161)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(53, 23)
        Me.label6.TabIndex = 27
        Me.label6.Text = "GENDER"
        Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gendertxt
        '
        Me.gendertxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gendertxt.FormattingEnabled = True
        Me.gendertxt.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.gendertxt.Location = New System.Drawing.Point(106, 161)
        Me.gendertxt.Name = "gendertxt"
        Me.gendertxt.Size = New System.Drawing.Size(104, 21)
        Me.gendertxt.TabIndex = 26
        '
        'nametxt
        '
        Me.nametxt.Location = New System.Drawing.Point(86, 106)
        Me.nametxt.Multiline = True
        Me.nametxt.Name = "nametxt"
        Me.nametxt.Size = New System.Drawing.Size(118, 31)
        Me.nametxt.TabIndex = 25
        Me.nametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(33, 114)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(47, 23)
        Me.label5.TabIndex = 24
        Me.label5.Text = "NAME"
        Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'phonetxt
        '
        Me.phonetxt.Location = New System.Drawing.Point(275, 112)
        Me.phonetxt.Multiline = True
        Me.phonetxt.Name = "phonetxt"
        Me.phonetxt.Size = New System.Drawing.Size(111, 23)
        Me.phonetxt.TabIndex = 23
        Me.phonetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(222, 112)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(47, 23)
        Me.label4.TabIndex = 22
        Me.label4.Text = "PHONE"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'agetxt
        '
        Me.agetxt.Location = New System.Drawing.Point(275, 161)
        Me.agetxt.Multiline = True
        Me.agetxt.Name = "agetxt"
        Me.agetxt.Size = New System.Drawing.Size(54, 32)
        Me.agetxt.TabIndex = 21
        Me.agetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(232, 161)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(47, 23)
        Me.label3.TabIndex = 20
        Me.label3.Text = "AGE"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'locationtxt
        '
        Me.locationtxt.Location = New System.Drawing.Point(189, 214)
        Me.locationtxt.Multiline = True
        Me.locationtxt.Name = "locationtxt"
        Me.locationtxt.Size = New System.Drawing.Size(111, 23)
        Me.locationtxt.TabIndex = 19
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(118, 212)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(65, 23)
        Me.label2.TabIndex = 18
        Me.label2.Text = "LOCATION"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'idtxt
        '
        Me.idtxt.Location = New System.Drawing.Point(205, 44)
        Me.idtxt.Multiline = True
        Me.idtxt.Name = "idtxt"
        Me.idtxt.Size = New System.Drawing.Size(62, 36)
        Me.idtxt.TabIndex = 17
        Me.idtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(136, 44)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(74, 36)
        Me.label1.TabIndex = 16
        Me.label1.Text = "ID-NUMBER"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.display)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.worktxt)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.gendertxt)
        Me.Controls.Add(Me.nametxt)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.phonetxt)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.agetxt)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.locationtxt)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.idtxt)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "GENZ DISPENSARY"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents clear As Button
    Private WithEvents display As Button
    Private WithEvents label7 As Label
    Private WithEvents worktxt As ComboBox
    Private WithEvents label6 As Label
    Private WithEvents gendertxt As ComboBox
    Private WithEvents nametxt As TextBox
    Private WithEvents label5 As Label
    Private WithEvents phonetxt As TextBox
    Private WithEvents label4 As Label
    Private WithEvents agetxt As TextBox
    Private WithEvents label3 As Label
    Private WithEvents locationtxt As TextBox
    Private WithEvents label2 As Label
    Private WithEvents idtxt As TextBox
    Private WithEvents label1 As Label
End Class
