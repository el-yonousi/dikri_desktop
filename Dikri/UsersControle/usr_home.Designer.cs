
namespace Dikri
{
    partial class usr_home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usr_home));
            this.label1 = new System.Windows.Forms.Label();
            this.tmr_clock = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_time_sec = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_to_long = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_total_count = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Noto Kufi Arabic", 54F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(187, 147);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(857, 221);
            this.label1.TabIndex = 0;
            this.label1.Text = "أذكار اليوم";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tmr_clock
            // 
            this.tmr_clock.Interval = 1000;
            this.tmr_clock.Tick += new System.EventHandler(this.tmr_clock_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_time_sec, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_time, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_to_long, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_total_count, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1233, 738);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lbl_time_sec
            // 
            this.lbl_time_sec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_time_sec.Font = new System.Drawing.Font("Noto Kufi Arabic", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_time_sec.Location = new System.Drawing.Point(126, 0);
            this.lbl_time_sec.Name = "lbl_time_sec";
            this.lbl_time_sec.Size = new System.Drawing.Size(55, 65);
            this.lbl_time_sec.TabIndex = 8;
            this.lbl_time_sec.Text = "00";
            this.lbl_time_sec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_time
            // 
            this.lbl_time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_time.Font = new System.Drawing.Font("Noto Kufi Arabic", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_time.Location = new System.Drawing.Point(3, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(117, 65);
            this.lbl_time.TabIndex = 7;
            this.lbl_time.Text = "00:00";
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Noto Kufi Arabic", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(187, 368);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(857, 73);
            this.label2.TabIndex = 2;
            this.label2.Text = "ألا بذكري الله تطمئن القلوب";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_to_long
            // 
            this.lbl_to_long.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_to_long.Font = new System.Drawing.Font("Noto Kufi Arabic", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_to_long.Location = new System.Drawing.Point(187, 441);
            this.lbl_to_long.Name = "lbl_to_long";
            this.lbl_to_long.Size = new System.Drawing.Size(857, 73);
            this.lbl_to_long.TabIndex = 3;
            this.lbl_to_long.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Noto Kufi Arabic", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(187, 514);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(857, 73);
            this.label4.TabIndex = 4;
            this.label4.Text = "عدد الأذكار المقروءة:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbl_total_count
            // 
            this.lbl_total_count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_total_count.Font = new System.Drawing.Font("Noto Kufi Arabic", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_total_count.Location = new System.Drawing.Point(187, 587);
            this.lbl_total_count.Name = "lbl_total_count";
            this.lbl_total_count.Size = new System.Drawing.Size(857, 73);
            this.lbl_total_count.TabIndex = 5;
            this.lbl_total_count.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(187, 660);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label6.Size = new System.Drawing.Size(857, 78);
            this.label6.TabIndex = 6;
            this.label6.Text = "Created by EL YONOUSI CopyRight 03 - 30 - 2020";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1085, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // usr_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Noto Kufi Arabic", 15.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "usr_home";
            this.Size = new System.Drawing.Size(1233, 738);
            this.Load += new System.EventHandler(this.usr_home_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmr_clock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_to_long;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_total_count;
        private System.Windows.Forms.Label lbl_time_sec;
        private System.Windows.Forms.Label lbl_time;
    }
}
