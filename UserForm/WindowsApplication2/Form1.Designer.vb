<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        Me.txtbox1 = New System.Windows.Forms.TextBox()
        Me.txtbox2 = New System.Windows.Forms.TextBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.login_lbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtbox1
        '
        Me.txtbox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox1.Location = New System.Drawing.Point(100, 125)
        Me.txtbox1.Name = "txtbox1"
        Me.txtbox1.Size = New System.Drawing.Size(199, 22)
        Me.txtbox1.TabIndex = 1
        '
        'txtbox2
        '
        Me.txtbox2.Location = New System.Drawing.Point(100, 158)
        Me.txtbox2.Name = "txtbox2"
        Me.txtbox2.Size = New System.Drawing.Size(199, 20)
        Me.txtbox2.TabIndex = 2
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.LightGray
        Me.btn1.Location = New System.Drawing.Point(160, 188)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 4
        Me.btn1.Text = "Login"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.LightGray
        Me.btn2.Location = New System.Drawing.Point(264, 240)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 24)
        Me.btn2.TabIndex = 5
        Me.btn2.Text = "Register"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Image = Global.WindowsApplication2.My.Resources.Resources.icons8_password_30
        Me.Label2.Location = New System.Drawing.Point(57, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 33)
        Me.Label2.TabIndex = 7
        '
        'login_lbl
        '
        Me.login_lbl.AutoSize = True
        Me.login_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.login_lbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.login_lbl.Image = CType(resources.GetObject("login_lbl.Image"), System.Drawing.Image)
        Me.login_lbl.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.login_lbl.Location = New System.Drawing.Point(18, 16)
        Me.login_lbl.Name = "login_lbl"
        Me.login_lbl.Size = New System.Drawing.Size(108, 40)
        Me.login_lbl.TabIndex = 0
        Me.login_lbl.Text = "Login"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Image = Global.WindowsApplication2.My.Resources.Resources.icons8_users_96__1_
        Me.Label3.Location = New System.Drawing.Point(-1, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(375, 93)
        Me.Label3.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Image = Global.WindowsApplication2.My.Resources.Resources.icons8_user_30
        Me.Label1.Location = New System.Drawing.Point(50, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 54)
        Me.Label1.TabIndex = 6
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(372, 296)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.txtbox2)
        Me.Controls.Add(Me.txtbox1)
        Me.Controls.Add(Me.login_lbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form1"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents login_lbl As Label
    Friend WithEvents txtbox1 As TextBox
    Friend WithEvents txtbox2 As TextBox
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
