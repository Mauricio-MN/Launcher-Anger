<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Play = New System.Windows.Forms.Button()
        Me.Options = New System.Windows.Forms.Button()
        Me.ProgressDown = New System.Windows.Forms.ProgressBar()
        Me.siteBt = New System.Windows.Forms.Button()
        Me.registerBt = New System.Windows.Forms.Button()
        Me.guidesBt = New System.Windows.Forms.Button()
        Me.InfoUpdate = New System.Windows.Forms.Label()
        Me.forumBt = New System.Windows.Forms.Button()
        Me.forceUpadateBt = New System.Windows.Forms.Button()
        Me.CheckSpeak = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.newsBt = New System.Windows.Forms.Button()
        Me.minimizeBt = New System.Windows.Forms.Button()
        Me.closeBt = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Play
        '
        Me.Play.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Play.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Play.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Play.FlatAppearance.BorderSize = 10
        Me.Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Play.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Play.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Play.Location = New System.Drawing.Point(805, 430)
        Me.Play.Margin = New System.Windows.Forms.Padding(4)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(249, 91)
        Me.Play.TabIndex = 0
        Me.Play.Text = "Play"
        Me.Play.UseVisualStyleBackColor = False
        '
        'Options
        '
        Me.Options.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Options.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Options.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Options.ForeColor = System.Drawing.Color.White
        Me.Options.Location = New System.Drawing.Point(328, 0)
        Me.Options.Margin = New System.Windows.Forms.Padding(4)
        Me.Options.Name = "Options"
        Me.Options.Size = New System.Drawing.Size(165, 31)
        Me.Options.TabIndex = 3
        Me.Options.Text = "Options"
        Me.Options.UseVisualStyleBackColor = True
        '
        'ProgressDown
        '
        Me.ProgressDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ProgressDown.BackColor = System.Drawing.Color.White
        Me.ProgressDown.ForeColor = System.Drawing.Color.Gold
        Me.ProgressDown.Location = New System.Drawing.Point(0, 521)
        Me.ProgressDown.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressDown.Name = "ProgressDown"
        Me.ProgressDown.Size = New System.Drawing.Size(1055, 20)
        Me.ProgressDown.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressDown.TabIndex = 4
        Me.ProgressDown.UseWaitCursor = True
        '
        'siteBt
        '
        Me.siteBt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.siteBt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.siteBt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.siteBt.ForeColor = System.Drawing.Color.White
        Me.siteBt.Location = New System.Drawing.Point(492, 0)
        Me.siteBt.Margin = New System.Windows.Forms.Padding(4)
        Me.siteBt.Name = "siteBt"
        Me.siteBt.Size = New System.Drawing.Size(165, 31)
        Me.siteBt.TabIndex = 5
        Me.siteBt.Text = "Site"
        Me.siteBt.UseVisualStyleBackColor = True
        '
        'registerBt
        '
        Me.registerBt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.registerBt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.registerBt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerBt.ForeColor = System.Drawing.Color.White
        Me.registerBt.Location = New System.Drawing.Point(656, 0)
        Me.registerBt.Margin = New System.Windows.Forms.Padding(4)
        Me.registerBt.Name = "registerBt"
        Me.registerBt.Size = New System.Drawing.Size(165, 31)
        Me.registerBt.TabIndex = 6
        Me.registerBt.Text = "Register"
        Me.registerBt.UseVisualStyleBackColor = True
        '
        'guidesBt
        '
        Me.guidesBt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.guidesBt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.guidesBt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guidesBt.ForeColor = System.Drawing.Color.White
        Me.guidesBt.Location = New System.Drawing.Point(164, 0)
        Me.guidesBt.Margin = New System.Windows.Forms.Padding(4)
        Me.guidesBt.Name = "guidesBt"
        Me.guidesBt.Size = New System.Drawing.Size(165, 31)
        Me.guidesBt.TabIndex = 8
        Me.guidesBt.Text = "Guides"
        Me.guidesBt.UseVisualStyleBackColor = True
        '
        'InfoUpdate
        '
        Me.InfoUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.InfoUpdate.AutoSize = True
        Me.InfoUpdate.BackColor = System.Drawing.Color.Black
        Me.InfoUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoUpdate.ForeColor = System.Drawing.Color.White
        Me.InfoUpdate.Location = New System.Drawing.Point(-1, 495)
        Me.InfoUpdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.InfoUpdate.Name = "InfoUpdate"
        Me.InfoUpdate.Size = New System.Drawing.Size(105, 20)
        Me.InfoUpdate.TabIndex = 9
        Me.InfoUpdate.Text = "Update Info"
        Me.InfoUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'forumBt
        '
        Me.forumBt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.forumBt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.forumBt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forumBt.ForeColor = System.Drawing.Color.White
        Me.forumBt.Location = New System.Drawing.Point(0, 0)
        Me.forumBt.Margin = New System.Windows.Forms.Padding(4)
        Me.forumBt.Name = "forumBt"
        Me.forumBt.Size = New System.Drawing.Size(165, 31)
        Me.forumBt.TabIndex = 7
        Me.forumBt.Text = "Forum"
        Me.forumBt.UseVisualStyleBackColor = True
        '
        'forceUpadateBt
        '
        Me.forceUpadateBt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.forceUpadateBt.BackColor = System.Drawing.Color.OrangeRed
        Me.forceUpadateBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.forceUpadateBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.forceUpadateBt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.forceUpadateBt.Location = New System.Drawing.Point(0, 465)
        Me.forceUpadateBt.Margin = New System.Windows.Forms.Padding(4)
        Me.forceUpadateBt.Name = "forceUpadateBt"
        Me.forceUpadateBt.Size = New System.Drawing.Size(137, 26)
        Me.forceUpadateBt.TabIndex = 12
        Me.forceUpadateBt.Text = "FORCE UPDATE"
        Me.forceUpadateBt.UseVisualStyleBackColor = False
        '
        'CheckSpeak
        '
        Me.CheckSpeak.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckSpeak.AutoSize = True
        Me.CheckSpeak.BackColor = System.Drawing.Color.Black
        Me.CheckSpeak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CheckSpeak.ForeColor = System.Drawing.Color.White
        Me.CheckSpeak.Location = New System.Drawing.Point(0, 437)
        Me.CheckSpeak.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckSpeak.Name = "CheckSpeak"
        Me.CheckSpeak.Size = New System.Drawing.Size(153, 21)
        Me.CheckSpeak.TabIndex = 13
        Me.CheckSpeak.Text = "Launcher Speaking"
        Me.CheckSpeak.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.newsBt)
        Me.Panel1.Controls.Add(Me.minimizeBt)
        Me.Panel1.Controls.Add(Me.closeBt)
        Me.Panel1.Controls.Add(Me.Options)
        Me.Panel1.Controls.Add(Me.forumBt)
        Me.Panel1.Controls.Add(Me.guidesBt)
        Me.Panel1.Controls.Add(Me.registerBt)
        Me.Panel1.Controls.Add(Me.siteBt)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1055, 31)
        Me.Panel1.TabIndex = 10
        '
        'newsBt
        '
        Me.newsBt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.newsBt.BackColor = System.Drawing.Color.RoyalBlue
        Me.newsBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newsBt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newsBt.ForeColor = System.Drawing.Color.White
        Me.newsBt.Location = New System.Drawing.Point(828, 0)
        Me.newsBt.Margin = New System.Windows.Forms.Padding(4)
        Me.newsBt.Name = "newsBt"
        Me.newsBt.Size = New System.Drawing.Size(143, 31)
        Me.newsBt.TabIndex = 16
        Me.newsBt.Text = "News"
        Me.newsBt.UseVisualStyleBackColor = False
        '
        'minimizeBt
        '
        Me.minimizeBt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimizeBt.BackColor = System.Drawing.Color.RoyalBlue
        Me.minimizeBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimizeBt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimizeBt.ForeColor = System.Drawing.Color.White
        Me.minimizeBt.Location = New System.Drawing.Point(979, 0)
        Me.minimizeBt.Margin = New System.Windows.Forms.Padding(4)
        Me.minimizeBt.Name = "minimizeBt"
        Me.minimizeBt.Size = New System.Drawing.Size(33, 31)
        Me.minimizeBt.TabIndex = 19
        Me.minimizeBt.Text = "-"
        Me.minimizeBt.UseVisualStyleBackColor = False
        '
        'closeBt
        '
        Me.closeBt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeBt.BackColor = System.Drawing.Color.RoyalBlue
        Me.closeBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeBt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBt.ForeColor = System.Drawing.Color.White
        Me.closeBt.Location = New System.Drawing.Point(1021, 0)
        Me.closeBt.Margin = New System.Windows.Forms.Padding(4)
        Me.closeBt.Name = "closeBt"
        Me.closeBt.Size = New System.Drawing.Size(33, 31)
        Me.closeBt.TabIndex = 18
        Me.closeBt.Text = "X"
        Me.closeBt.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 8000
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1055, 540)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Black
        Me.CheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(0, 409)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(124, 21)
        Me.CheckBox1.TabIndex = 19
        Me.CheckBox1.Text = "Custom opengl"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'angengeLauncher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1056, 540)
        Me.ControlBox = False
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CheckSpeak)
        Me.Controls.Add(Me.forceUpadateBt)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Play)
        Me.Controls.Add(Me.InfoUpdate)
        Me.Controls.Add(Me.ProgressDown)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "angengeLauncher"
        Me.Text = "Muangenge Launcher"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Play As System.Windows.Forms.Button
    Friend WithEvents Options As System.Windows.Forms.Button
    Friend WithEvents ProgressDown As System.Windows.Forms.ProgressBar
    Friend WithEvents siteBt As System.Windows.Forms.Button
    Friend WithEvents registerBt As System.Windows.Forms.Button
    Friend WithEvents guidesBt As System.Windows.Forms.Button
    Friend WithEvents InfoUpdate As System.Windows.Forms.Label
    Friend WithEvents forumBt As System.Windows.Forms.Button
    Friend WithEvents forceUpadateBt As System.Windows.Forms.Button
    Friend WithEvents CheckSpeak As System.Windows.Forms.CheckBox
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents newsBt As System.Windows.Forms.Button
    Friend WithEvents minimizeBt As System.Windows.Forms.Button
    Friend WithEvents closeBt As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
