namespace Login
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.v_timer = new System.Windows.Forms.Timer(this.components);
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.html5 = new System.Windows.Forms.Button();
            this.Second = new System.Windows.Forms.Button();
            this.First = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // v_timer
            // 
            this.v_timer.Tick += new System.EventHandler(this.v_timer_Tick);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.White;
            this.exit.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exit.Location = new System.Drawing.Point(394, 414);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(184, 53);
            this.exit.TabIndex = 10;
            this.exit.Text = "나가기";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(150, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(663, 128);
            this.label1.TabIndex = 9;
            this.label1.Text = "EunTaek 투어";
            // 
            // html5
            // 
            this.html5.BackColor = System.Drawing.Color.White;
            this.html5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.html5.Location = new System.Drawing.Point(394, 335);
            this.html5.Name = "html5";
            this.html5.Size = new System.Drawing.Size(184, 50);
            this.html5.TabIndex = 8;
            this.html5.Text = "홈페이지";
            this.html5.UseVisualStyleBackColor = false;
            this.html5.Click += new System.EventHandler(this.html5_Click);
            // 
            // Second
            // 
            this.Second.BackColor = System.Drawing.Color.White;
            this.Second.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Second.Location = new System.Drawing.Point(394, 262);
            this.Second.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(184, 48);
            this.Second.TabIndex = 7;
            this.Second.Text = "예약 현황";
            this.Second.UseVisualStyleBackColor = false;
            this.Second.Click += new System.EventHandler(this.Second_Click);
            // 
            // First
            // 
            this.First.BackColor = System.Drawing.Color.White;
            this.First.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.First.Location = new System.Drawing.Point(394, 173);
            this.First.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(184, 55);
            this.First.TabIndex = 6;
            this.First.Text = "예약 검색";
            this.First.UseVisualStyleBackColor = false;
            this.First.Click += new System.EventHandler(this.First_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(979, 507);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(979, 507);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.html5);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.First);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "여행";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer v_timer;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button html5;
        private System.Windows.Forms.Button Second;
        private System.Windows.Forms.Button First;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}