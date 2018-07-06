<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class client
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(client))
        Me.Grid1 = New System.Windows.Forms.DataGridView()
        Me.supprime = New System.Windows.Forms.Button()
        Me.modifer = New System.Windows.Forms.Button()
        Me.recherche = New System.Windows.Forms.Button()
        Me.Fermer = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ajouter = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.Button()
        Me.path = New System.Windows.Forms.TextBox()
        Me.G1 = New System.Windows.Forms.GroupBox()
        Me.m = New System.Windows.Forms.RadioButton()
        Me.f = New System.Windows.Forms.RadioButton()
        Me.parcourir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Qr1 = New Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.c1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.t_no = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.t_pr = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.t_em = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.ButtonX6 = New DevComponents.DotNetBar.ButtonX()
        Me.ajt = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX5 = New DevComponents.DotNetBar.ButtonX()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.G1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Qr1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        Me.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid1.Location = New System.Drawing.Point(389, 464)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(507, 112)
        Me.Grid1.TabIndex = 11
        '
        'supprime
        '
        Me.supprime.BackColor = System.Drawing.SystemColors.ControlLight
        Me.supprime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supprime.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.supprime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.supprime.Location = New System.Drawing.Point(360, 29)
        Me.supprime.Name = "supprime"
        Me.supprime.Size = New System.Drawing.Size(10, 11)
        Me.supprime.TabIndex = 34
        Me.supprime.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.supprime.UseVisualStyleBackColor = False
        '
        'modifer
        '
        Me.modifer.BackColor = System.Drawing.SystemColors.ControlLight
        Me.modifer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modifer.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.modifer.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.modifer.Location = New System.Drawing.Point(230, 24)
        Me.modifer.Name = "modifer"
        Me.modifer.Size = New System.Drawing.Size(10, 11)
        Me.modifer.TabIndex = 33
        Me.modifer.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.modifer.UseVisualStyleBackColor = False
        '
        'recherche
        '
        Me.recherche.BackColor = System.Drawing.SystemColors.ControlLight
        Me.recherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recherche.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.recherche.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.recherche.Location = New System.Drawing.Point(159, 26)
        Me.recherche.Name = "recherche"
        Me.recherche.Size = New System.Drawing.Size(10, 11)
        Me.recherche.TabIndex = 32
        Me.recherche.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.recherche.UseVisualStyleBackColor = False
        '
        'Fermer
        '
        Me.Fermer.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Fermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fermer.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Fermer.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Fermer.Location = New System.Drawing.Point(1327, 29)
        Me.Fermer.Name = "Fermer"
        Me.Fermer.Size = New System.Drawing.Size(10, 11)
        Me.Fermer.TabIndex = 31
        Me.Fermer.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Fermer.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(1026, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(10, 10)
        Me.Button1.TabIndex = 30
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ajouter
        '
        Me.ajouter.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ajouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ajouter.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ajouter.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ajouter.Location = New System.Drawing.Point(1238, 25)
        Me.ajouter.Name = "ajouter"
        Me.ajouter.Size = New System.Drawing.Size(10, 10)
        Me.ajouter.TabIndex = 29
        Me.ajouter.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ajouter.UseVisualStyleBackColor = False
        '
        'save
        '
        Me.save.BackColor = System.Drawing.Color.LightGray
        Me.save.Location = New System.Drawing.Point(14, 99)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(127, 35)
        Me.save.TabIndex = 48
        Me.save.Text = "save"
        Me.save.UseVisualStyleBackColor = False
        '
        'path
        '
        Me.path.Location = New System.Drawing.Point(14, 62)
        Me.path.Name = "path"
        Me.path.Size = New System.Drawing.Size(127, 22)
        Me.path.TabIndex = 47
        '
        'G1
        '
        Me.G1.Controls.Add(Me.m)
        Me.G1.Controls.Add(Me.f)
        Me.G1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.G1.Location = New System.Drawing.Point(25, 177)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(119, 73)
        Me.G1.TabIndex = 44
        Me.G1.TabStop = False
        Me.G1.Text = "Sexe"
        '
        'm
        '
        Me.m.AutoSize = True
        Me.m.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m.ForeColor = System.Drawing.SystemColors.Highlight
        Me.m.Location = New System.Drawing.Point(2, 43)
        Me.m.Name = "m"
        Me.m.Size = New System.Drawing.Size(78, 20)
        Me.m.TabIndex = 1
        Me.m.TabStop = True
        Me.m.Text = "Msculin"
        Me.m.UseVisualStyleBackColor = True
        '
        'f
        '
        Me.f.AutoSize = True
        Me.f.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f.ForeColor = System.Drawing.SystemColors.Highlight
        Me.f.Location = New System.Drawing.Point(2, 19)
        Me.f.Name = "f"
        Me.f.Size = New System.Drawing.Size(80, 20)
        Me.f.TabIndex = 0
        Me.f.TabStop = True
        Me.f.Text = "Féminin"
        Me.f.UseVisualStyleBackColor = True
        '
        'parcourir
        '
        Me.parcourir.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.parcourir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parcourir.ForeColor = System.Drawing.Color.Blue
        Me.parcourir.Location = New System.Drawing.Point(361, 140)
        Me.parcourir.Name = "parcourir"
        Me.parcourir.Size = New System.Drawing.Size(113, 30)
        Me.parcourir.TabIndex = 43
        Me.parcourir.Text = "parcourir"
        Me.parcourir.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(361, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(762, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 37
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Qr1
        '
        Me.Qr1.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M
        Me.Qr1.Image = CType(resources.GetObject("Qr1.Image"), System.Drawing.Image)
        Me.Qr1.Location = New System.Drawing.Point(55, 6)
        Me.Qr1.Name = "Qr1"
        Me.Qr1.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two
        Me.Qr1.Size = New System.Drawing.Size(51, 50)
        Me.Qr1.TabIndex = 49
        Me.Qr1.TabStop = False
        Me.Qr1.Text = "Qr1"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom
        Me.LabelX1.Location = New System.Drawing.Point(25, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(134, 23)
        Me.LabelX1.TabIndex = 51
        Me.LabelX1.Text = "ID"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelX2.Location = New System.Drawing.Point(25, 40)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(134, 23)
        Me.LabelX2.TabIndex = 52
        Me.LabelX2.Text = "Nom"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelX3.Location = New System.Drawing.Point(25, 83)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(134, 23)
        Me.LabelX3.TabIndex = 53
        Me.LabelX3.Text = "Prénom"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelX4.Location = New System.Drawing.Point(25, 124)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(134, 23)
        Me.LabelX4.TabIndex = 54
        Me.LabelX4.Text = "Email"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'c1
        '
        Me.c1.DisplayMember = "Text"
        Me.c1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.c1.FormattingEnabled = True
        Me.c1.ItemHeight = 16
        Me.c1.Location = New System.Drawing.Point(202, 6)
        Me.c1.Name = "c1"
        Me.c1.Size = New System.Drawing.Size(134, 22)
        Me.c1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.c1.TabIndex = 55
        '
        't_no
        '
        '
        '
        '
        Me.t_no.Border.Class = "TextBoxBorder"
        Me.t_no.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t_no.Location = New System.Drawing.Point(202, 41)
        Me.t_no.Name = "t_no"
        Me.t_no.Size = New System.Drawing.Size(134, 22)
        Me.t_no.TabIndex = 56
        '
        't_pr
        '
        '
        '
        '
        Me.t_pr.Border.Class = "TextBoxBorder"
        Me.t_pr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t_pr.Location = New System.Drawing.Point(202, 86)
        Me.t_pr.Name = "t_pr"
        Me.t_pr.Size = New System.Drawing.Size(134, 22)
        Me.t_pr.TabIndex = 57
        '
        't_em
        '
        '
        '
        '
        Me.t_em.Border.Class = "TextBoxBorder"
        Me.t_em.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.t_em.Location = New System.Drawing.Point(202, 120)
        Me.t_em.Name = "t_em"
        Me.t_em.Size = New System.Drawing.Size(134, 22)
        Me.t_em.TabIndex = 58
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.PictureBox1)
        Me.GroupPanel1.Controls.Add(Me.GroupPanel2)
        Me.GroupPanel1.Controls.Add(Me.t_em)
        Me.GroupPanel1.Controls.Add(Me.parcourir)
        Me.GroupPanel1.Controls.Add(Me.t_pr)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.G1)
        Me.GroupPanel1.Controls.Add(Me.t_no)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.c1)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(389, 82)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(507, 376)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 59
        Me.GroupPanel1.Text = "CLIENT"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.Qr1)
        Me.GroupPanel2.Controls.Add(Me.path)
        Me.GroupPanel2.Controls.Add(Me.save)
        Me.GroupPanel2.Location = New System.Drawing.Point(185, 151)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(161, 199)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 59
        Me.GroupPanel2.Text = "QR"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Button1)
        Me.PanelEx1.Controls.Add(Me.supprime)
        Me.PanelEx1.Controls.Add(Me.recherche)
        Me.PanelEx1.Controls.Add(Me.ajouter)
        Me.PanelEx1.Controls.Add(Me.Fermer)
        Me.PanelEx1.Controls.Add(Me.modifer)
        Me.PanelEx1.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx1.Location = New System.Drawing.Point(2, 2)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1381, 74)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 60
        Me.PanelEx1.Text = "Fitness Your Way      *****      Fitness Your Way  ******     Fitness Your Way  "
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.BackColor = System.Drawing.SystemColors.Info
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = CType(resources.GetObject("ButtonX1.Image"), System.Drawing.Image)
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(0, 10)
        Me.ButtonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom
        Me.ButtonX1.Location = New System.Drawing.Point(60, 17)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(107, 41)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.ButtonX1.TabIndex = 64
        Me.ButtonX1.Text = "raz"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.ButtonX6)
        Me.PanelEx2.Controls.Add(Me.ajt)
        Me.PanelEx2.Controls.Add(Me.ButtonX3)
        Me.PanelEx2.Controls.Add(Me.ButtonX4)
        Me.PanelEx2.Controls.Add(Me.ButtonX5)
        Me.PanelEx2.Controls.Add(Me.ButtonX1)
        Me.PanelEx2.Location = New System.Drawing.Point(70, 608)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(1164, 75)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 63
        '
        'ButtonX6
        '
        Me.ButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX6.Location = New System.Drawing.Point(628, 17)
        Me.ButtonX6.Name = "ButtonX6"
        Me.ButtonX6.Size = New System.Drawing.Size(117, 41)
        Me.ButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX6.TabIndex = 64
        Me.ButtonX6.Text = "Rechercher"
        '
        'ajt
        '
        Me.ajt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ajt.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ajt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ajt.Location = New System.Drawing.Point(253, 17)
        Me.ajt.Name = "ajt"
        Me.ajt.Size = New System.Drawing.Size(117, 41)
        Me.ajt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ajt.TabIndex = 0
        Me.ajt.Text = "Ajouter"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX3.Location = New System.Drawing.Point(442, 17)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(105, 41)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 0
        Me.ButtonX3.Text = "Modifier"
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX4.Location = New System.Drawing.Point(795, 17)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(135, 41)
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX4.TabIndex = 0
        Me.ButtonX4.Text = "Supprimer"
        '
        'ButtonX5
        '
        Me.ButtonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX5.Location = New System.Drawing.Point(999, 17)
        Me.ButtonX5.Name = "ButtonX5"
        Me.ButtonX5.Size = New System.Drawing.Size(108, 41)
        Me.ButtonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX5.TabIndex = 0
        Me.ButtonX5.Text = "Fermer"
        '
        'client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1378, 780)
        Me.Controls.Add(Me.PanelEx2)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "client"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.G1.ResumeLayout(False)
        Me.G1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Qr1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid1 As System.Windows.Forms.DataGridView
    Friend WithEvents supprime As System.Windows.Forms.Button
    Friend WithEvents modifer As System.Windows.Forms.Button
    Friend WithEvents recherche As System.Windows.Forms.Button
    Friend WithEvents Fermer As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ajouter As System.Windows.Forms.Button
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents path As System.Windows.Forms.TextBox
    Friend WithEvents G1 As System.Windows.Forms.GroupBox
    Friend WithEvents m As System.Windows.Forms.RadioButton
    Friend WithEvents f As System.Windows.Forms.RadioButton
    Friend WithEvents parcourir As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Qr1 As Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents c1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents t_no As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents t_pr As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents t_em As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ajt As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX5 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX6 As DevComponents.DotNetBar.ButtonX

End Class
