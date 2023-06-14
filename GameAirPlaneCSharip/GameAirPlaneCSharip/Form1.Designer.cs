namespace GameAirPlaneCSharip
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Lab_Life = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Panel_Main = new System.Windows.Forms.Panel();
            this.Tank2 = new System.Windows.Forms.PictureBox();
            this.Bullet2 = new System.Windows.Forms.PictureBox();
            this.Tank1 = new System.Windows.Forms.PictureBox();
            this.Bullet1 = new System.Windows.Forms.PictureBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tank2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tank1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lab_Life
            // 
            this.Lab_Life.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_Life.AutoSize = true;
            this.Lab_Life.BackColor = System.Drawing.Color.Transparent;
            this.Lab_Life.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Life.ForeColor = System.Drawing.Color.White;
            this.Lab_Life.Location = new System.Drawing.Point(1003, 32);
            this.Lab_Life.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_Life.Name = "Lab_Life";
            this.Lab_Life.Size = new System.Drawing.Size(27, 30);
            this.Lab_Life.TabIndex = 4;
            this.Lab_Life.Text = "3";
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(927, 32);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(66, 30);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "CPU";
            // 
            // Panel_Main
            // 
            this.Panel_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Main.BackColor = System.Drawing.Color.Black;
            this.Panel_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Main.Controls.Add(this.Tank2);
            this.Panel_Main.Controls.Add(this.Bullet2);
            this.Panel_Main.Controls.Add(this.Tank1);
            this.Panel_Main.Controls.Add(this.Bullet1);
            this.Panel_Main.Location = new System.Drawing.Point(0, 0);
            this.Panel_Main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.Size = new System.Drawing.Size(919, 569);
            this.Panel_Main.TabIndex = 6;
            // 
            // Tank2
            // 
            this.Tank2.BackColor = System.Drawing.Color.Transparent;
            this.Tank2.Image = global::GameAirPlaneCSharip.Properties.Resources.airplaneRight;
            this.Tank2.Location = new System.Drawing.Point(4, 4);
            this.Tank2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tank2.Name = "Tank2";
            this.Tank2.Size = new System.Drawing.Size(92, 77);
            this.Tank2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tank2.TabIndex = 2;
            this.Tank2.TabStop = false;
            // 
            // Bullet2
            // 
            this.Bullet2.BackColor = System.Drawing.Color.Transparent;
            this.Bullet2.Image = global::GameAirPlaneCSharip.Properties.Resources.bomb;
            this.Bullet2.Location = new System.Drawing.Point(36, 89);
            this.Bullet2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bullet2.Name = "Bullet2";
            this.Bullet2.Size = new System.Drawing.Size(28, 29);
            this.Bullet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bullet2.TabIndex = 3;
            this.Bullet2.TabStop = false;
            // 
            // Tank1
            // 
            this.Tank1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Tank1.BackColor = System.Drawing.Color.Transparent;
            this.Tank1.Image = global::GameAirPlaneCSharip.Properties.Resources.airplane1;
            this.Tank1.Location = new System.Drawing.Point(441, 475);
            this.Tank1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tank1.Name = "Tank1";
            this.Tank1.Size = new System.Drawing.Size(71, 83);
            this.Tank1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tank1.TabIndex = 2;
            this.Tank1.TabStop = false;
            // 
            // Bullet1
            // 
            this.Bullet1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Bullet1.BackColor = System.Drawing.Color.Transparent;
            this.Bullet1.Image = global::GameAirPlaneCSharip.Properties.Resources.Bullet2;
            this.Bullet1.Location = new System.Drawing.Point(471, 425);
            this.Bullet1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bullet1.Name = "Bullet1";
            this.Bullet1.Size = new System.Drawing.Size(6, 31);
            this.Bullet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Bullet1.TabIndex = 3;
            this.Bullet1.TabStop = false;
            // 
            // Button1
            // 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button1.BackColor = System.Drawing.SystemColors.ControlText;
            this.Button1.FlatAppearance.BorderSize = 2;
            this.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(923, 508);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(115, 45);
            this.Button1.TabIndex = 11;
            this.Button1.Text = "RePlay";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button2.BackColor = System.Drawing.SystemColors.ControlText;
            this.Button2.FlatAppearance.BorderSize = 2;
            this.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Location = new System.Drawing.Point(923, 455);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(115, 45);
            this.Button2.TabIndex = 12;
            this.Button2.Text = "Stop";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1041, 565);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Panel_Main);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Lab_Life);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel_Main.ResumeLayout(false);
            this.Panel_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tank2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tank1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.PictureBox Tank1;
        private System.Windows.Forms.PictureBox Tank2;
        private System.Windows.Forms.PictureBox Bullet1;
        private System.Windows.Forms.PictureBox Bullet2;
        private System.Windows.Forms.Label Lab_Life;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Panel Panel_Main;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Timer Timer1;

    }
}

