<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.C1 = New System.Windows.Forms.ComboBox()
        Me.T1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.pro = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(808, 498)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'C1
        '
        Me.C1.FormattingEnabled = True
        Me.C1.Location = New System.Drawing.Point(436, 234)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(332, 21)
        Me.C1.TabIndex = 2
        '
        'T1
        '
        '
        '
        '
        Me.T1.Border.Class = "TextBoxBorder"
        Me.T1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.T1.Location = New System.Drawing.Point(436, 318)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(332, 20)
        Me.T1.TabIndex = 3
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(192, 407)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(425, 47)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 4
        Me.ButtonX1.Text = "Se connecter"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.LabelX1.Location = New System.Drawing.Point(359, 119)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.SingleLineColor = System.Drawing.SystemColors.ButtonShadow
        Me.LabelX1.Size = New System.Drawing.Size(122, 42)
        Me.LabelX1.TabIndex = 5
        Me.LabelX1.Text = "Authentification"
        '
        'pro
        '
        '
        '
        '
        Me.pro.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.pro.Location = New System.Drawing.Point(359, 167)
        Me.pro.Name = "pro"
        Me.pro.Size = New System.Drawing.Size(122, 23)
        Me.pro.TabIndex = 6
        Me.pro.Text = "ProgressBarX1"
        '
        'grid
        '
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(103, 480)
        Me.grid.Name = "grid"
        Me.grid.Size = New System.Drawing.Size(590, 74)
        Me.grid.TabIndex = 7
        '
        'Timer1
        '
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(806, 472)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.pro)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.C1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(20, 40)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents C1 As System.Windows.Forms.ComboBox
    Friend WithEvents T1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents pro As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
