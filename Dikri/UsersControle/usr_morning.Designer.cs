
namespace Dikri
{
    partial class usr_morning
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
            this.lbl_dikr = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_number = new System.Windows.Forms.Label();
            this.lbl_title_dikr = new System.Windows.Forms.Label();
            this.lbl_alias_repeat = new System.Windows.Forms.Label();
            this.btn_count = new System.Windows.Forms.Button();
            this.btn_repeat = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_dikr
            // 
            this.lbl_dikr.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_dikr, 2);
            this.lbl_dikr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_dikr.Location = new System.Drawing.Point(227, 59);
            this.lbl_dikr.Name = "lbl_dikr";
            this.lbl_dikr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_dikr.Size = new System.Drawing.Size(666, 537);
            this.lbl_dikr.TabIndex = 3;
            this.lbl_dikr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_number, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_title_dikr, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_alias_repeat, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_dikr, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_count, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_repeat, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_next, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_previous, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1120, 747);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lbl_number.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_number.Location = new System.Drawing.Point(3, 0);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(218, 40);
            this.lbl_number.TabIndex = 0;
            this.lbl_number.Text = "رقم الذكر:01";
            this.lbl_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_title_dikr
            // 
            this.lbl_title_dikr.AutoSize = true;
            this.lbl_title_dikr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_title_dikr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.lbl_title_dikr.Location = new System.Drawing.Point(899, 0);
            this.lbl_title_dikr.Name = "lbl_title_dikr";
            this.lbl_title_dikr.Size = new System.Drawing.Size(218, 59);
            this.lbl_title_dikr.TabIndex = 1;
            this.lbl_title_dikr.Text = "أذكار الصباح";
            this.lbl_title_dikr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_alias_repeat
            // 
            this.lbl_alias_repeat.AutoSize = true;
            this.lbl_alias_repeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lbl_alias_repeat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_alias_repeat.Location = new System.Drawing.Point(563, 596);
            this.lbl_alias_repeat.Name = "lbl_alias_repeat";
            this.lbl_alias_repeat.Size = new System.Drawing.Size(330, 44);
            this.lbl_alias_repeat.TabIndex = 2;
            this.lbl_alias_repeat.Text = ":عدد التكرار";
            this.lbl_alias_repeat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_count
            // 
            this.btn_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_count.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_count.FlatAppearance.BorderSize = 0;
            this.btn_count.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btn_count.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_count.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_count.Location = new System.Drawing.Point(224, 596);
            this.btn_count.Margin = new System.Windows.Forms.Padding(0);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(336, 44);
            this.btn_count.TabIndex = 4;
            this.btn_count.UseVisualStyleBackColor = false;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // btn_repeat
            // 
            this.btn_repeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tableLayoutPanel1.SetColumnSpan(this.btn_repeat, 2);
            this.btn_repeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_repeat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_repeat.FlatAppearance.BorderSize = 0;
            this.btn_repeat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btn_repeat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_repeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_repeat.Location = new System.Drawing.Point(224, 643);
            this.btn_repeat.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btn_repeat.Name = "btn_repeat";
            this.btn_repeat.Size = new System.Drawing.Size(672, 56);
            this.btn_repeat.TabIndex = 5;
            this.btn_repeat.Text = "إعادة";
            this.btn_repeat.UseVisualStyleBackColor = false;
            this.btn_repeat.Click += new System.EventHandler(this.btn_repeat_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btn_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Location = new System.Drawing.Point(0, 59);
            this.btn_next.Margin = new System.Windows.Forms.Padding(0);
            this.btn_next.Name = "btn_next";
            this.tableLayoutPanel1.SetRowSpan(this.btn_next, 2);
            this.btn_next.Size = new System.Drawing.Size(50, 581);
            this.btn_next.TabIndex = 6;
            this.btn_next.Text = "←";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_previous.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_previous.FlatAppearance.BorderSize = 0;
            this.btn_previous.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btn_previous.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_previous.Location = new System.Drawing.Point(1070, 59);
            this.btn_previous.Margin = new System.Windows.Forms.Padding(0);
            this.btn_previous.Name = "btn_previous";
            this.tableLayoutPanel1.SetRowSpan(this.btn_previous, 2);
            this.btn_previous.Size = new System.Drawing.Size(50, 581);
            this.btn_previous.TabIndex = 7;
            this.btn_previous.Text = "→";
            this.btn_previous.UseVisualStyleBackColor = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // usr_morning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Noto Kufi Arabic", 15.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "usr_morning";
            this.Size = new System.Drawing.Size(1120, 747);
            this.Load += new System.EventHandler(this.usr_morning_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_dikr;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.Label lbl_title_dikr;
        private System.Windows.Forms.Label lbl_alias_repeat;
        private System.Windows.Forms.Button btn_count;
        private System.Windows.Forms.Button btn_repeat;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_previous;
    }
}
