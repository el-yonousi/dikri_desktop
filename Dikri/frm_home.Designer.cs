
namespace Dikri
{
    partial class frm_home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_home));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.btn_minimise = new System.Windows.Forms.Button();
            this.btn_maximise = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.pnl_right_side_bar = new System.Windows.Forms.Panel();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_add_dikr = new System.Windows.Forms.Button();
            this.btn_sleep = new System.Windows.Forms.Button();
            this.btn_evening = new System.Windows.Forms.Button();
            this.btn_morning = new System.Windows.Forms.Button();
            this.btn_wake_up = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_container = new System.Windows.Forms.Panel();
            this.tmr_auto_dikr = new System.Windows.Forms.Timer(this.components);
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_right_side_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnl_header.Controls.Add(this.btn_minimise);
            this.pnl_header.Controls.Add(this.btn_maximise);
            this.pnl_header.Controls.Add(this.label1);
            this.pnl_header.Controls.Add(this.btn_exit);
            this.pnl_header.Controls.Add(this.pictureBox1);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1337, 47);
            this.pnl_header.TabIndex = 0;
            this.pnl_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_header_MouseDown);
            // 
            // btn_minimise
            // 
            this.btn_minimise.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_minimise.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_minimise.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btn_minimise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btn_minimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimise.Font = new System.Drawing.Font("Noto Kufi Arabic", 14F, System.Drawing.FontStyle.Bold);
            this.btn_minimise.Location = new System.Drawing.Point(94, 0);
            this.btn_minimise.Name = "btn_minimise";
            this.btn_minimise.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btn_minimise.Size = new System.Drawing.Size(47, 47);
            this.btn_minimise.TabIndex = 10;
            this.btn_minimise.Text = "-";
            this.btn_minimise.UseVisualStyleBackColor = true;
            this.btn_minimise.Click += new System.EventHandler(this.btn_minimise_Click);
            // 
            // btn_maximise
            // 
            this.btn_maximise.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_maximise.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_maximise.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btn_maximise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btn_maximise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximise.Font = new System.Drawing.Font("Noto Kufi Arabic", 14F, System.Drawing.FontStyle.Bold);
            this.btn_maximise.Location = new System.Drawing.Point(47, 0);
            this.btn_maximise.Name = "btn_maximise";
            this.btn_maximise.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btn_maximise.Size = new System.Drawing.Size(47, 47);
            this.btn_maximise.TabIndex = 9;
            this.btn_maximise.Text = "_";
            this.btn_maximise.UseVisualStyleBackColor = true;
            this.btn_maximise.Click += new System.EventHandler(this.btn_maximise_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Noto Kufi Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1234, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "ذكري";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_exit
            // 
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Noto Kufi Arabic", 14F, System.Drawing.FontStyle.Bold);
            this.btn_exit.Location = new System.Drawing.Point(0, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btn_exit.Size = new System.Drawing.Size(47, 47);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1301, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox1.Size = new System.Drawing.Size(36, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_home
            // 
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Location = new System.Drawing.Point(0, 90);
            this.btn_home.Name = "btn_home";
            this.btn_home.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btn_home.Size = new System.Drawing.Size(249, 79);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "الصفحة الرئيسية";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // pnl_right_side_bar
            // 
            this.pnl_right_side_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnl_right_side_bar.Controls.Add(this.btn_settings);
            this.pnl_right_side_bar.Controls.Add(this.btn_add_dikr);
            this.pnl_right_side_bar.Controls.Add(this.btn_sleep);
            this.pnl_right_side_bar.Controls.Add(this.btn_evening);
            this.pnl_right_side_bar.Controls.Add(this.btn_morning);
            this.pnl_right_side_bar.Controls.Add(this.btn_wake_up);
            this.pnl_right_side_bar.Controls.Add(this.btn_home);
            this.pnl_right_side_bar.Controls.Add(this.label6);
            this.pnl_right_side_bar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_right_side_bar.Location = new System.Drawing.Point(1088, 47);
            this.pnl_right_side_bar.Name = "pnl_right_side_bar";
            this.pnl_right_side_bar.Size = new System.Drawing.Size(249, 769);
            this.pnl_right_side_bar.TabIndex = 1;
            // 
            // btn_settings
            // 
            this.btn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_settings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Location = new System.Drawing.Point(0, 485);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btn_settings.Size = new System.Drawing.Size(249, 79);
            this.btn_settings.TabIndex = 9;
            this.btn_settings.Text = "الإعدادات";
            this.btn_settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_add_dikr
            // 
            this.btn_add_dikr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_add_dikr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_dikr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_add_dikr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_add_dikr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btn_add_dikr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btn_add_dikr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_dikr.Location = new System.Drawing.Point(0, 690);
            this.btn_add_dikr.Name = "btn_add_dikr";
            this.btn_add_dikr.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btn_add_dikr.Size = new System.Drawing.Size(249, 79);
            this.btn_add_dikr.TabIndex = 7;
            this.btn_add_dikr.Text = "إضافة ذكر";
            this.btn_add_dikr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add_dikr.UseVisualStyleBackColor = false;
            this.btn_add_dikr.Click += new System.EventHandler(this.btn_add_dikr_Click);
            // 
            // btn_sleep
            // 
            this.btn_sleep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sleep.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sleep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_sleep.FlatAppearance.BorderSize = 0;
            this.btn_sleep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_sleep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_sleep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sleep.Location = new System.Drawing.Point(0, 406);
            this.btn_sleep.Name = "btn_sleep";
            this.btn_sleep.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btn_sleep.Size = new System.Drawing.Size(249, 79);
            this.btn_sleep.TabIndex = 6;
            this.btn_sleep.Text = "أذكار النوم";
            this.btn_sleep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sleep.UseVisualStyleBackColor = true;
            this.btn_sleep.Click += new System.EventHandler(this.btn_sleep_Click);
            // 
            // btn_evening
            // 
            this.btn_evening.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_evening.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_evening.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_evening.FlatAppearance.BorderSize = 0;
            this.btn_evening.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_evening.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_evening.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_evening.Location = new System.Drawing.Point(0, 327);
            this.btn_evening.Name = "btn_evening";
            this.btn_evening.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btn_evening.Size = new System.Drawing.Size(249, 79);
            this.btn_evening.TabIndex = 5;
            this.btn_evening.Text = "أذكار المساء";
            this.btn_evening.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_evening.UseVisualStyleBackColor = true;
            this.btn_evening.Click += new System.EventHandler(this.btn_evening_Click);
            // 
            // btn_morning
            // 
            this.btn_morning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_morning.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_morning.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_morning.FlatAppearance.BorderSize = 0;
            this.btn_morning.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_morning.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_morning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_morning.Location = new System.Drawing.Point(0, 248);
            this.btn_morning.Name = "btn_morning";
            this.btn_morning.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btn_morning.Size = new System.Drawing.Size(249, 79);
            this.btn_morning.TabIndex = 4;
            this.btn_morning.Text = "أذكار الصباح";
            this.btn_morning.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_morning.UseVisualStyleBackColor = true;
            this.btn_morning.Click += new System.EventHandler(this.btn_morning_Click);
            // 
            // btn_wake_up
            // 
            this.btn_wake_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_wake_up.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_wake_up.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_wake_up.FlatAppearance.BorderSize = 0;
            this.btn_wake_up.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_wake_up.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_wake_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_wake_up.Location = new System.Drawing.Point(0, 169);
            this.btn_wake_up.Name = "btn_wake_up";
            this.btn_wake_up.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btn_wake_up.Size = new System.Drawing.Size(249, 79);
            this.btn_wake_up.TabIndex = 3;
            this.btn_wake_up.Text = "أذكار الإستيقاظ";
            this.btn_wake_up.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_wake_up.UseVisualStyleBackColor = true;
            this.btn_wake_up.Click += new System.EventHandler(this.btn_wake_up_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 90);
            this.label6.TabIndex = 8;
            this.label6.Text = "•••";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_container
            // 
            this.pnl_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_container.Location = new System.Drawing.Point(0, 47);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(1088, 769);
            this.pnl_container.TabIndex = 2;
            // 
            // tmr_auto_dikr
            // 
            this.tmr_auto_dikr.Interval = 1000;
            this.tmr_auto_dikr.Tick += new System.EventHandler(this.tmr_auto_dikr_Tick);
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1337, 816);
            this.Controls.Add(this.pnl_container);
            this.Controls.Add(this.pnl_right_side_bar);
            this.Controls.Add(this.pnl_header);
            this.Font = new System.Drawing.Font("Noto Kufi Arabic", 15.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(9);
            this.MinimumSize = new System.Drawing.Size(1337, 816);
            this.Name = "frm_home";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_right_side_bar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel pnl_right_side_bar;
        private System.Windows.Forms.Button btn_sleep;
        private System.Windows.Forms.Button btn_evening;
        private System.Windows.Forms.Button btn_morning;
        private System.Windows.Forms.Button btn_wake_up;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_minimise;
        private System.Windows.Forms.Button btn_maximise;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_add_dikr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnl_container;
        private System.Windows.Forms.Timer tmr_auto_dikr;
        private System.Windows.Forms.Button btn_settings;
    }
}

