<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbox1 = New System.Windows.Forms.TextBox()
        Me.txtbox2 = New System.Windows.Forms.TextBox()
        Me.txtbox3 = New System.Windows.Forms.TextBox()
        Me.txtbox4 = New System.Windows.Forms.TextBox()
        Me.btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Font = New System.Drawing.Font("Impact", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(27, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTRATION MENU"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Gainsboro
        Me.Label5.Image = Global.WindowsApplication2.My.Resources.Resources.icons8_password_301
        Me.Label5.Location = New System.Drawing.Point(43, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 36)
        Me.Label5.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Gainsboro
        Me.Label4.Image = Global.WindowsApplication2.My.Resources.Resources.icons8_user_30__1_
        Me.Label4.Location = New System.Drawing.Point(43, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 36)
        Me.Label4.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.Image = Global.WindowsApplication2.My.Resources.Resources.icons8_password_30__1_
        Me.Label3.Location = New System.Drawing.Point(43, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 36)
        Me.Label3.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.Image = Global.WindowsApplication2.My.Resources.Resources.icons8_at_30
        Me.Label2.Location = New System.Drawing.Point(43, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 36)
        Me.Label2.TabIndex = 1
        '
        'txtbox1
        '
        Me.txtbox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox1.Location = New System.Drawing.Point(95, 96)
        Me.txtbox1.Name = "txtbox1"
        Me.txtbox1.Size = New System.Drawing.Size(204, 32)
        Me.txtbox1.TabIndex = 5
        '
        'txtbox2
        '
        Me.txtbox2.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox2.Location = New System.Drawing.Point(95, 134)
        Me.txtbox2.Name = "txtbox2"
        Me.txtbox2.Size = New System.Drawing.Size(204, 32)
        Me.txtbox2.TabIndex = 6
        '
        'txtbox3
        '
        Me.txtbox3.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox3.Location = New System.Drawing.Point(95, 172)
        Me.txtbox3.Name = "txtbox3"
        Me.txtbox3.Size = New System.Drawing.Size(204, 32)
        Me.txtbox3.TabIndex = 7
        '
        'txtbox4
        '
        Me.txtbox4.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox4.Location = New System.Drawing.Point(95, 210)
        Me.txtbox4.Name = "txtbox4"
        Me.txtbox4.Size = New System.Drawing.Size(204, 32)
        Me.txtbox4.TabIndex = 8
        '
        'btn
        '
        Me.btn.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn.Location = New System.Drawing.Point(114, 265)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(124, 36)
        Me.btn.TabIndex = 9
        Me.btn.Text = "Register"
        Me.btn.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(349, 337)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.txtbox4)
        Me.Controls.Add(Me.txtbox3)
        Me.Controls.Add(Me.txtbox2)
        Me.Controls.Add(Me.txtbox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbox1 As TextBox
    Friend WithEvents txtbox2 As TextBox
    Friend WithEvents txtbox3 As TextBox
    Friend WithEvents txtbox4 As TextBox
    Friend WithEvents btn As Button
End Class
