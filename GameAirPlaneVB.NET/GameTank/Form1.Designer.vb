<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Lab_Life = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel_Main = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Tank2 = New System.Windows.Forms.PictureBox()
        Me.Bullet2 = New System.Windows.Forms.PictureBox()
        Me.Tank1 = New System.Windows.Forms.PictureBox()
        Me.Bullet1 = New System.Windows.Forms.PictureBox()
        Me.Panel_Main.SuspendLayout()
        CType(Me.Tank2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tank1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Lab_Life
        '
        Me.Lab_Life.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lab_Life.AutoSize = True
        Me.Lab_Life.BackColor = System.Drawing.Color.Transparent
        Me.Lab_Life.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Life.ForeColor = System.Drawing.Color.White
        Me.Lab_Life.Location = New System.Drawing.Point(752, 24)
        Me.Lab_Life.Name = "Lab_Life"
        Me.Lab_Life.Size = New System.Drawing.Size(21, 24)
        Me.Lab_Life.TabIndex = 4
        Me.Lab_Life.Text = "3"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(695, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "CPU"
        '
        'Panel_Main
        '
        Me.Panel_Main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Main.BackColor = System.Drawing.Color.Black
        'Me.Panel_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Main.Controls.Add(Me.Tank2)
        Me.Panel_Main.Controls.Add(Me.Bullet2)
        Me.Panel_Main.Controls.Add(Me.Tank1)
        Me.Panel_Main.Controls.Add(Me.Bullet1)
        Me.Panel_Main.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(689, 427)
        Me.Panel_Main.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(692, 381)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 34)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "RePlay"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(692, 341)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 34)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Tank2
        '
        Me.Tank2.BackColor = System.Drawing.Color.Transparent
        Me.Tank2.Image = Global.GameTank.My.Resources.Resources.airplaneRight
        Me.Tank2.Location = New System.Drawing.Point(3, 3)
        Me.Tank2.Name = "Tank2"
        Me.Tank2.Size = New System.Drawing.Size(69, 58)
        Me.Tank2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Tank2.TabIndex = 2
        Me.Tank2.TabStop = False
        '
        'Bullet2
        '
        Me.Bullet2.BackColor = System.Drawing.Color.Transparent
        Me.Bullet2.Image = Global.GameTank.My.Resources.Resources.bomb
        Me.Bullet2.Location = New System.Drawing.Point(27, 67)
        Me.Bullet2.Name = "Bullet2"
        Me.Bullet2.Size = New System.Drawing.Size(21, 22)
        Me.Bullet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet2.TabIndex = 3
        Me.Bullet2.TabStop = False
        '
        'Tank1
        '
        Me.Tank1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Tank1.BackColor = System.Drawing.Color.Transparent
        Me.Tank1.Image = Global.GameTank.My.Resources.Resources.airplane1
        Me.Tank1.Location = New System.Drawing.Point(331, 356)
        Me.Tank1.Name = "Tank1"
        Me.Tank1.Size = New System.Drawing.Size(53, 62)
        Me.Tank1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Tank1.TabIndex = 2
        Me.Tank1.TabStop = False
        '
        'Bullet1
        '
        Me.Bullet1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Bullet1.BackColor = System.Drawing.Color.Transparent
        Me.Bullet1.Image = Global.GameTank.My.Resources.Resources.Bullet2
        Me.Bullet1.Location = New System.Drawing.Point(353, 319)
        Me.Bullet1.Name = "Bullet1"
        Me.Bullet1.Size = New System.Drawing.Size(6, 31)
        Me.Bullet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Bullet1.TabIndex = 3
        Me.Bullet1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        'Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(781, 424)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel_Main)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lab_Life)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel_Main.ResumeLayout(False)
        Me.Panel_Main.PerformLayout()
        CType(Me.Tank2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tank1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tank1 As System.Windows.Forms.PictureBox
    Friend WithEvents Tank2 As System.Windows.Forms.PictureBox
    Friend WithEvents Bullet1 As System.Windows.Forms.PictureBox
    Friend WithEvents Bullet2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Lab_Life As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel_Main As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
