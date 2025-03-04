namespace thinger.MTHProject
{
    partial class FrmMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_TitleName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MiddlePanel = new System.Windows.Forms.Panel();
            this.AlarmPanel = new System.Windows.Forms.Panel();
            this.btn_Right = new System.Windows.Forms.Button();
            this.btn_Left = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_CurrentTime = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.CorePanel = new thinger.MTHConttrolLib.PanelEX();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.naviButton6 = new thinger.MTHConttrolLib.NaviButton();
            this.naviButton3 = new thinger.MTHConttrolLib.NaviButton();
            this.naviButton5 = new thinger.MTHConttrolLib.NaviButton();
            this.naviButton2 = new thinger.MTHConttrolLib.NaviButton();
            this.naviButton4 = new thinger.MTHConttrolLib.NaviButton();
            this.naviButton1 = new thinger.MTHConttrolLib.NaviButton();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MiddlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.CorePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopPanel.Controls.Add(this.naviButton6);
            this.TopPanel.Controls.Add(this.naviButton3);
            this.TopPanel.Controls.Add(this.naviButton5);
            this.TopPanel.Controls.Add(this.naviButton2);
            this.TopPanel.Controls.Add(this.naviButton4);
            this.TopPanel.Controls.Add(this.naviButton1);
            this.TopPanel.Controls.Add(this.btn_Exit);
            this.TopPanel.Controls.Add(this.lbl_TitleName);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1440, 133);
            this.TopPanel.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackgroundImage = global::thinger.MTHProject.Properties.Resources.Exit;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(1335, -3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(112, 47);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // lbl_TitleName
            // 
            this.lbl_TitleName.Font = new System.Drawing.Font("微软雅黑", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_TitleName.ForeColor = System.Drawing.Color.White;
            this.lbl_TitleName.Location = new System.Drawing.Point(537, 34);
            this.lbl_TitleName.Name = "lbl_TitleName";
            this.lbl_TitleName.Size = new System.Drawing.Size(365, 54);
            this.lbl_TitleName.TabIndex = 1;
            this.lbl_TitleName.Text = "多路温湿度采集监控系统";
            this.lbl_TitleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 20.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "THINGER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::thinger.MTHProject.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MiddlePanel
            // 
            this.MiddlePanel.BackColor = System.Drawing.Color.Transparent;
            this.MiddlePanel.Controls.Add(this.AlarmPanel);
            this.MiddlePanel.Controls.Add(this.btn_Right);
            this.MiddlePanel.Controls.Add(this.btn_Left);
            this.MiddlePanel.Controls.Add(this.lbl_Title);
            this.MiddlePanel.Controls.Add(this.pictureBox2);
            this.MiddlePanel.Controls.Add(this.label6);
            this.MiddlePanel.Controls.Add(this.label3);
            this.MiddlePanel.Controls.Add(this.lbl_CurrentTime);
            this.MiddlePanel.Controls.Add(this.lbl_User);
            this.MiddlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MiddlePanel.Location = new System.Drawing.Point(0, 133);
            this.MiddlePanel.Name = "MiddlePanel";
            this.MiddlePanel.Size = new System.Drawing.Size(1440, 65);
            this.MiddlePanel.TabIndex = 1;
            // 
            // AlarmPanel
            // 
            this.AlarmPanel.BackgroundImage = global::thinger.MTHProject.Properties.Resources.Alarm;
            this.AlarmPanel.Location = new System.Drawing.Point(909, 14);
            this.AlarmPanel.Name = "AlarmPanel";
            this.AlarmPanel.Size = new System.Drawing.Size(380, 40);
            this.AlarmPanel.TabIndex = 3;
            // 
            // btn_Right
            // 
            this.btn_Right.BackgroundImage = global::thinger.MTHProject.Properties.Resources.Right;
            this.btn_Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Right.FlatAppearance.BorderSize = 0;
            this.btn_Right.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Right.Location = new System.Drawing.Point(807, 9);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(71, 47);
            this.btn_Right.TabIndex = 2;
            this.btn_Right.UseVisualStyleBackColor = true;
            // 
            // btn_Left
            // 
            this.btn_Left.BackgroundImage = global::thinger.MTHProject.Properties.Resources.Left;
            this.btn_Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Left.FlatAppearance.BorderSize = 0;
            this.btn_Left.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Left.Location = new System.Drawing.Point(557, 7);
            this.btn_Left.Name = "btn_Left";
            this.btn_Left.Size = new System.Drawing.Size(77, 47);
            this.btn_Left.TabIndex = 2;
            this.btn_Left.UseVisualStyleBackColor = true;
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Image = global::thinger.MTHProject.Properties.Resources.Current;
            this.lbl_Title.Location = new System.Drawing.Point(634, 7);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(184, 49);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "集中监控";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::thinger.MTHProject.Properties.Resources.User;
            this.pictureBox2.Location = new System.Drawing.Point(3, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1310, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "通信状态";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(127, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "欢迎登录！现在时间是";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CurrentTime
            // 
            this.lbl_CurrentTime.AutoSize = true;
            this.lbl_CurrentTime.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CurrentTime.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.lbl_CurrentTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.lbl_CurrentTime.Location = new System.Drawing.Point(293, 19);
            this.lbl_CurrentTime.Name = "lbl_CurrentTime";
            this.lbl_CurrentTime.Size = new System.Drawing.Size(203, 22);
            this.lbl_CurrentTime.TabIndex = 1;
            this.lbl_CurrentTime.Text = "2023年3月12日 15:14:00";
            this.lbl_CurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_User
            // 
            this.lbl_User.BackColor = System.Drawing.Color.Transparent;
            this.lbl_User.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.lbl_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.lbl_User.Location = new System.Drawing.Point(29, 15);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(92, 30);
            this.lbl_User.TabIndex = 1;
            this.lbl_User.Text = "管理员";
            this.lbl_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CorePanel
            // 
            this.CorePanel.BackColor = System.Drawing.Color.Transparent;
            this.CorePanel.BoderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(79)))), ((int)(((byte)(150)))));
            this.CorePanel.BorderWidh = 3;
            this.CorePanel.BottomGap = 10;
            this.CorePanel.Controls.Add(this.MainPanel);
            this.CorePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CorePanel.LeftGap = 20;
            this.CorePanel.Location = new System.Drawing.Point(0, 198);
            this.CorePanel.Name = "CorePanel";
            this.CorePanel.Padding = new System.Windows.Forms.Padding(23, 13, 23, 13);
            this.CorePanel.RightGap = 20;
            this.CorePanel.Size = new System.Drawing.Size(1440, 762);
            this.CorePanel.TabIndex = 2;
            this.CorePanel.TopGap = 10;
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(23, 13);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1394, 736);
            this.MainPanel.TabIndex = 0;
            // 
            // naviButton6
            // 
            this.naviButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton6.BackgroundImage")));
            this.naviButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton6.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.naviButton6.IsLeft = false;
            this.naviButton6.IsSelect = false;
            this.naviButton6.Location = new System.Drawing.Point(1299, 82);
            this.naviButton6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.naviButton6.Name = "naviButton6";
            this.naviButton6.Size = new System.Drawing.Size(129, 43);
            this.naviButton6.TabIndex = 3;
            this.naviButton6.TitleName = "用户管理";
            this.naviButton6.Click += new System.EventHandler(this.CommonNaviButton_Click);
            // 
            // naviButton3
            // 
            this.naviButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton3.BackgroundImage")));
            this.naviButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton3.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.naviButton3.IsLeft = true;
            this.naviButton3.IsSelect = false;
            this.naviButton3.Location = new System.Drawing.Point(329, 82);
            this.naviButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.naviButton3.Name = "naviButton3";
            this.naviButton3.Size = new System.Drawing.Size(129, 43);
            this.naviButton3.TabIndex = 3;
            this.naviButton3.TitleName = "配方管理";
            this.naviButton3.Click += new System.EventHandler(this.CommonNaviButton_Click);
            // 
            // naviButton5
            // 
            this.naviButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton5.BackgroundImage")));
            this.naviButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton5.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.naviButton5.IsLeft = false;
            this.naviButton5.IsSelect = false;
            this.naviButton5.Location = new System.Drawing.Point(1138, 82);
            this.naviButton5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.naviButton5.Name = "naviButton5";
            this.naviButton5.Size = new System.Drawing.Size(129, 43);
            this.naviButton5.TabIndex = 3;
            this.naviButton5.TitleName = "历史趋势";
            this.naviButton5.Click += new System.EventHandler(this.CommonNaviButton_Click);
            // 
            // naviButton2
            // 
            this.naviButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton2.BackgroundImage")));
            this.naviButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton2.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.naviButton2.IsLeft = true;
            this.naviButton2.IsSelect = false;
            this.naviButton2.Location = new System.Drawing.Point(168, 82);
            this.naviButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.naviButton2.Name = "naviButton2";
            this.naviButton2.Size = new System.Drawing.Size(129, 43);
            this.naviButton2.TabIndex = 3;
            this.naviButton2.TitleName = "参数设置";
            this.naviButton2.Click += new System.EventHandler(this.CommonNaviButton_Click);
            // 
            // naviButton4
            // 
            this.naviButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton4.BackgroundImage")));
            this.naviButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton4.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.naviButton4.IsLeft = false;
            this.naviButton4.IsSelect = false;
            this.naviButton4.Location = new System.Drawing.Point(982, 82);
            this.naviButton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.naviButton4.Name = "naviButton4";
            this.naviButton4.Size = new System.Drawing.Size(129, 43);
            this.naviButton4.TabIndex = 3;
            this.naviButton4.TitleName = "报警追溯";
            this.naviButton4.Click += new System.EventHandler(this.CommonNaviButton_Click);
            // 
            // naviButton1
            // 
            this.naviButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton1.BackgroundImage")));
            this.naviButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton1.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.naviButton1.IsLeft = true;
            this.naviButton1.IsSelect = false;
            this.naviButton1.Location = new System.Drawing.Point(12, 82);
            this.naviButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.naviButton1.Name = "naviButton1";
            this.naviButton1.Size = new System.Drawing.Size(129, 43);
            this.naviButton1.TabIndex = 3;
            this.naviButton1.TitleName = "集中监控";
            this.naviButton1.Click += new System.EventHandler(this.CommonNaviButton_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::thinger.MTHProject.Properties.Resources.Main;
            this.ClientSize = new System.Drawing.Size(1440, 960);
            this.Controls.Add(this.CorePanel);
            this.Controls.Add(this.MiddlePanel);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MiddlePanel.ResumeLayout(false);
            this.MiddlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.CorePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_TitleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel MiddlePanel;
        private System.Windows.Forms.Panel AlarmPanel;
        private System.Windows.Forms.Button btn_Right;
        private System.Windows.Forms.Button btn_Left;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_CurrentTime;
        private System.Windows.Forms.Label lbl_User;
        private MTHConttrolLib.NaviButton naviButton3;
        private MTHConttrolLib.NaviButton naviButton2;
        private MTHConttrolLib.NaviButton naviButton1;
        private MTHConttrolLib.NaviButton naviButton6;
        private MTHConttrolLib.NaviButton naviButton5;
        private MTHConttrolLib.NaviButton naviButton4;
        private MTHConttrolLib.PanelEX CorePanel;
        private System.Windows.Forms.Panel MainPanel;
    }
}

