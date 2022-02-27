
namespace Dikri
{
    partial class frm_auto_dikr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_auto_dikr));
            this.lbl_dikr = new System.Windows.Forms.Label();
            this.btn_count = new System.Windows.Forms.Button();
            this.lbl_close = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tmr_hide = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_dikr
            // 
            this.lbl_dikr.AutoSize = true;
            this.lbl_dikr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_dikr, 2);
            this.lbl_dikr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_dikr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_dikr.ForeColor = System.Drawing.Color.White;
            this.lbl_dikr.Location = new System.Drawing.Point(0, 0);
            this.lbl_dikr.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_dikr.Name = "lbl_dikr";
            this.lbl_dikr.Padding = new System.Windows.Forms.Padding(10);
            this.lbl_dikr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_dikr.Size = new System.Drawing.Size(636, 262);
            this.lbl_dikr.TabIndex = 0;
            this.lbl_dikr.Text = "أذكار اليوم";
            this.lbl_dikr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_dikr.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_dikr_MouseDown);
            // 
            // btn_count
            // 
            this.btn_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btn_count.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_count.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btn_count.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btn_count.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_count.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_count.ForeColor = System.Drawing.Color.White;
            this.btn_count.Location = new System.Drawing.Point(0, 262);
            this.btn_count.Margin = new System.Windows.Forms.Padding(0);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(318, 45);
            this.btn_count.TabIndex = 7;
            this.btn_count.Text = "01";
            this.btn_count.UseVisualStyleBackColor = false;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // lbl_close
            // 
            this.lbl_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.lbl_close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lbl_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.lbl_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lbl_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_close.ForeColor = System.Drawing.Color.White;
            this.lbl_close.Location = new System.Drawing.Point(318, 262);
            this.lbl_close.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(318, 45);
            this.lbl_close.TabIndex = 8;
            this.lbl_close.Text = "إخفاء";
            this.lbl_close.UseVisualStyleBackColor = false;
            this.lbl_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_count, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_close, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_dikr, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.5615F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.4385F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(636, 307);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tmr_hide
            // 
            this.tmr_hide.Interval = 1000;
            this.tmr_hide.Tick += new System.EventHandler(this.tmr_hide_Tick);
            // 
            // frm_auto_dikr
            // 
            this.AcceptButton = this.btn_count;
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.lbl_close;
            this.ClientSize = new System.Drawing.Size(636, 307);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Noto Kufi Arabic", 15.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "frm_auto_dikr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_auto_dikr";
            this.Load += new System.EventHandler(this.frm_auto_dikr_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_dikr;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button lbl_close;
        private System.Windows.Forms.Button btn_count;
        private System.Windows.Forms.Timer tmr_hide;
    }
}