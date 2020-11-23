<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtToken = New System.Windows.Forms.TextBox()
        Me.txtCookie = New System.Windows.Forms.TextBox()
        Me.txtUID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCopyToken = New System.Windows.Forms.Button()
        Me.btnCopyCookie = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(600, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Get Token"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtToken
        '
        Me.txtToken.Location = New System.Drawing.Point(76, 58)
        Me.txtToken.Multiline = True
        Me.txtToken.Name = "txtToken"
        Me.txtToken.Size = New System.Drawing.Size(518, 51)
        Me.txtToken.TabIndex = 3
        '
        'txtCookie
        '
        Me.txtCookie.Location = New System.Drawing.Point(76, 127)
        Me.txtCookie.Multiline = True
        Me.txtCookie.Name = "txtCookie"
        Me.txtCookie.Size = New System.Drawing.Size(518, 55)
        Me.txtCookie.TabIndex = 4
        '
        'txtUID
        '
        Me.txtUID.Location = New System.Drawing.Point(76, 25)
        Me.txtUID.Name = "txtUID"
        Me.txtUID.Size = New System.Drawing.Size(518, 20)
        Me.txtUID.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "UID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Token:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cookie:"
        '
        'btnCopyToken
        '
        Me.btnCopyToken.Location = New System.Drawing.Point(600, 57)
        Me.btnCopyToken.Name = "btnCopyToken"
        Me.btnCopyToken.Size = New System.Drawing.Size(75, 51)
        Me.btnCopyToken.TabIndex = 10
        Me.btnCopyToken.Text = "Copy"
        Me.btnCopyToken.UseVisualStyleBackColor = True
        '
        'btnCopyCookie
        '
        Me.btnCopyCookie.Location = New System.Drawing.Point(600, 130)
        Me.btnCopyCookie.Name = "btnCopyCookie"
        Me.btnCopyCookie.Size = New System.Drawing.Size(75, 52)
        Me.btnCopyCookie.TabIndex = 11
        Me.btnCopyCookie.Text = "Copy"
        Me.btnCopyCookie.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(659, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Công cụ lấy cookie, token full quyền an toàn, không checkpoint từ app facebook tr" &
    "ên điện thoại, máy ảo LDPlayer"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.PBar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 315)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(697, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(527, 17)
        Me.ToolStripStatusLabel1.Text = "Developed by Nguyen Huu Dat - J2TEAM Community - https://fb.com/groups/j2team.com" &
    "munity"
        '
        'PBar
        '
        Me.PBar.Name = "PBar"
        Me.PBar.Size = New System.Drawing.Size(100, 16)
        Me.PBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.PBar.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(563, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "- Yêu cầu android đã được root, mở USB debug mode (Nếu không được hãy thử đổi kiể" &
    "u kết nối USB trên điện thoại)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(392, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "- Chỉ mở 1 thiết bị khi lấy. VD nếu lấy từ điện thoại thì nên tắt máy ảo và ngược" &
    " lại."
        '
        'BackgroundWorker1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 337)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCopyCookie)
        Me.Controls.Add(Me.btnCopyToken)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUID)
        Me.Controls.Add(Me.txtCookie)
        Me.Controls.Add(Me.txtToken)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Get Token Full quyền v1.0"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtToken As TextBox
    Friend WithEvents txtCookie As TextBox
    Friend WithEvents txtUID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCopyToken As Button
    Friend WithEvents btnCopyCookie As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PBar As ToolStripProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
