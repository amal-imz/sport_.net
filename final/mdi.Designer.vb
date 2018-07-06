<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdi))
        Me.p_pr = New System.Windows.Forms.PictureBox()
        Me.p_spo = New System.Windows.Forms.PictureBox()
        Me.p_emp = New System.Windows.Forms.PictureBox()
        Me.p_cl = New System.Windows.Forms.PictureBox()
        Me.B_spo = New DevComponents.DotNetBar.ButtonX()
        Me.B_pr = New DevComponents.DotNetBar.ButtonX()
        Me.B_emp = New DevComponents.DotNetBar.ButtonX()
        Me.B_cl = New DevComponents.DotNetBar.ButtonX()
        Me.b_qtt = New DevComponents.DotNetBar.ButtonX()
        Me.b_acl = New DevComponents.DotNetBar.ButtonX()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.anel = New DevComponents.DotNetBar.PanelEx()
        Me.b_login = New DevComponents.DotNetBar.ButtonX()
        Me.b_logout = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        CType(Me.p_pr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p_spo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p_emp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p_cl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.anel.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'p_pr
        '
        Me.p_pr.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.p_pr.Image = CType(resources.GetObject("p_pr.Image"), System.Drawing.Image)
        Me.p_pr.Location = New System.Drawing.Point(927, 3)
        Me.p_pr.Name = "p_pr"
        Me.p_pr.Size = New System.Drawing.Size(129, 73)
        Me.p_pr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.p_pr.TabIndex = 16
        Me.p_pr.TabStop = False
        '
        'p_spo
        '
        Me.p_spo.Image = CType(resources.GetObject("p_spo.Image"), System.Drawing.Image)
        Me.p_spo.Location = New System.Drawing.Point(689, 3)
        Me.p_spo.Name = "p_spo"
        Me.p_spo.Size = New System.Drawing.Size(129, 73)
        Me.p_spo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.p_spo.TabIndex = 15
        Me.p_spo.TabStop = False
        '
        'p_emp
        '
        Me.p_emp.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p_emp.Image = CType(resources.GetObject("p_emp.Image"), System.Drawing.Image)
        Me.p_emp.Location = New System.Drawing.Point(299, 3)
        Me.p_emp.Name = "p_emp"
        Me.p_emp.Size = New System.Drawing.Size(129, 73)
        Me.p_emp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.p_emp.TabIndex = 9
        Me.p_emp.TabStop = False
        '
        'p_cl
        '
        Me.p_cl.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.p_cl.Image = CType(resources.GetObject("p_cl.Image"), System.Drawing.Image)
        Me.p_cl.Location = New System.Drawing.Point(488, 3)
        Me.p_cl.Name = "p_cl"
        Me.p_cl.Size = New System.Drawing.Size(129, 73)
        Me.p_cl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.p_cl.TabIndex = 10
        Me.p_cl.TabStop = False
        '
        'B_spo
        '
        Me.B_spo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.B_spo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.B_spo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_spo.Location = New System.Drawing.Point(689, 71)
        Me.B_spo.Name = "B_spo"
        Me.B_spo.Size = New System.Drawing.Size(129, 33)
        Me.B_spo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.B_spo.TabIndex = 11
        Me.B_spo.Text = "Sport"
        '
        'B_pr
        '
        Me.B_pr.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.B_pr.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.B_pr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_pr.Location = New System.Drawing.Point(927, 71)
        Me.B_pr.Name = "B_pr"
        Me.B_pr.Size = New System.Drawing.Size(129, 33)
        Me.B_pr.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.B_pr.TabIndex = 12
        Me.B_pr.Text = "Prix"
        '
        'B_emp
        '
        Me.B_emp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.B_emp.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.B_emp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.B_emp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_emp.Location = New System.Drawing.Point(299, 71)
        Me.B_emp.Name = "B_emp"
        Me.B_emp.Size = New System.Drawing.Size(129, 33)
        Me.B_emp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.B_emp.TabIndex = 13
        Me.B_emp.Text = "Employer"
        '
        'B_cl
        '
        Me.B_cl.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.B_cl.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.B_cl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_cl.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.B_cl.Location = New System.Drawing.Point(488, 71)
        Me.B_cl.Name = "B_cl"
        Me.B_cl.Size = New System.Drawing.Size(129, 33)
        Me.B_cl.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.B_cl.TabIndex = 14
        Me.B_cl.Text = "Client"
        Me.B_cl.TextColor = System.Drawing.SystemColors.HotTrack
        '
        'b_qtt
        '
        Me.b_qtt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.b_qtt.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.b_qtt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_qtt.Image = CType(resources.GetObject("b_qtt.Image"), System.Drawing.Image)
        Me.b_qtt.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.b_qtt.Location = New System.Drawing.Point(1191, 7)
        Me.b_qtt.Name = "b_qtt"
        Me.b_qtt.Size = New System.Drawing.Size(113, 87)
        Me.b_qtt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.b_qtt.TabIndex = 17
        Me.b_qtt.TextColor = System.Drawing.Color.Red
        '
        'b_acl
        '
        Me.b_acl.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.b_acl.BackColor = System.Drawing.SystemColors.Control
        Me.b_acl.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.b_acl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_acl.Image = CType(resources.GetObject("b_acl.Image"), System.Drawing.Image)
        Me.b_acl.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.b_acl.Location = New System.Drawing.Point(56, 24)
        Me.b_acl.Name = "b_acl"
        Me.b_acl.Size = New System.Drawing.Size(169, 52)
        Me.b_acl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.b_acl.TabIndex = 18
        Me.b_acl.TextColor = System.Drawing.Color.LightSeaGreen
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(2, 641)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(176, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(963, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 37)
        Me.Label1.TabIndex = 1
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx1.Location = New System.Drawing.Point(-7, 2)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1371, 45)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 19
        Me.PanelEx1.Text = "* * * * * Fitness Your Way* * * * *"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(1232, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 33)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(908, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 37)
        Me.Label2.TabIndex = 20
        '
        'anel
        '
        Me.anel.CanvasColor = System.Drawing.SystemColors.Control
        Me.anel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.anel.Controls.Add(Me.b_login)
        Me.anel.Controls.Add(Me.b_logout)
        Me.anel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.anel.Location = New System.Drawing.Point(2, 676)
        Me.anel.Name = "anel"
        Me.anel.Size = New System.Drawing.Size(1374, 74)
        Me.anel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.anel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.anel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.anel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.anel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.anel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.anel.Style.GradientAngle = 90
        Me.anel.TabIndex = 21
        Me.anel.Text = "Welcome To Fitness Am@L ImeZZgou@ne"
        '
        'b_login
        '
        Me.b_login.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.b_login.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.b_login.Image = CType(resources.GetObject("b_login.Image"), System.Drawing.Image)
        Me.b_login.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.b_login.Location = New System.Drawing.Point(1167, 12)
        Me.b_login.Name = "b_login"
        Me.b_login.Size = New System.Drawing.Size(164, 44)
        Me.b_login.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.b_login.TabIndex = 0
        '
        'b_logout
        '
        Me.b_logout.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.b_logout.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.b_logout.Image = CType(resources.GetObject("b_logout.Image"), System.Drawing.Image)
        Me.b_logout.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.b_logout.Location = New System.Drawing.Point(1167, 12)
        Me.b_logout.Name = "b_logout"
        Me.b_logout.Size = New System.Drawing.Size(164, 44)
        Me.b_logout.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.b_logout.TabIndex = 23
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.p_emp)
        Me.PanelEx3.Controls.Add(Me.B_emp)
        Me.PanelEx3.Controls.Add(Me.p_cl)
        Me.PanelEx3.Controls.Add(Me.B_cl)
        Me.PanelEx3.Controls.Add(Me.p_spo)
        Me.PanelEx3.Controls.Add(Me.B_spo)
        Me.PanelEx3.Controls.Add(Me.p_pr)
        Me.PanelEx3.Controls.Add(Me.B_pr)
        Me.PanelEx3.Controls.Add(Me.b_qtt)
        Me.PanelEx3.Controls.Add(Me.b_acl)
        Me.PanelEx3.Location = New System.Drawing.Point(-22, 46)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(1386, 106)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 27
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(-1, 146)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(1362, 536)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 28
        Me.PictureBox6.TabStop = False
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(2, 158)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX1.Size = New System.Drawing.Size(134, 50)
        Me.LabelX1.TabIndex = 19
        Me.LabelX1.Text = "by Amal  5/9/2017"
        '
        'mdi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 737)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PanelEx3)
        Me.Controls.Add(Me.anel)
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Gray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mdi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.p_pr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p_spo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p_emp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p_cl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.anel.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents p_pr As System.Windows.Forms.PictureBox
    Friend WithEvents p_spo As System.Windows.Forms.PictureBox
    Friend WithEvents p_emp As System.Windows.Forms.PictureBox
    Friend WithEvents p_cl As System.Windows.Forms.PictureBox
    Friend WithEvents B_spo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents B_pr As DevComponents.DotNetBar.ButtonX
    Friend WithEvents B_emp As DevComponents.DotNetBar.ButtonX
    Friend WithEvents B_cl As DevComponents.DotNetBar.ButtonX
    Friend WithEvents b_qtt As DevComponents.DotNetBar.ButtonX
    Friend WithEvents b_acl As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents anel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents b_logout As DevComponents.DotNetBar.ButtonX
    Friend WithEvents b_login As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
End Class
