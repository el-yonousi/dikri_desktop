
namespace Dikri
{
    partial class usr_setting
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ck_notification = new System.Windows.Forms.CheckBox();
            this.nmrc_period = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc_period)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_save, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ck_notification, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nmrc_period, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(969, 620);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Noto Kufi Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(487, 375);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(236, 56);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(487, 186);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(236, 93);
            this.label1.TabIndex = 1;
            this.label1.Text = "الإشعارات:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(487, 279);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(236, 93);
            this.label2.TabIndex = 2;
            this.label2.Text = "المدة بين الإشعار بالدقائق:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ck_notification
            // 
            this.ck_notification.AutoSize = true;
            this.ck_notification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ck_notification.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ck_notification.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.ck_notification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ck_notification.Font = new System.Drawing.Font("Noto Kufi Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_notification.Location = new System.Drawing.Point(245, 189);
            this.ck_notification.Name = "ck_notification";
            this.ck_notification.Size = new System.Drawing.Size(236, 87);
            this.ck_notification.TabIndex = 3;
            this.ck_notification.Text = "تشغيل";
            this.ck_notification.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ck_notification.UseCompatibleTextRendering = true;
            this.ck_notification.UseVisualStyleBackColor = false;
            // 
            // nmrc_period
            // 
            this.nmrc_period.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nmrc_period.Font = new System.Drawing.Font("Noto Kufi Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrc_period.Location = new System.Drawing.Point(245, 306);
            this.nmrc_period.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nmrc_period.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrc_period.Name = "nmrc_period";
            this.nmrc_period.Size = new System.Drawing.Size(236, 38);
            this.nmrc_period.TabIndex = 4;
            this.nmrc_period.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrc_period.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // usr_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Noto Kufi Arabic", 15.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "usr_setting";
            this.Size = new System.Drawing.Size(969, 620);
            this.Load += new System.EventHandler(this.usr_setting_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc_period)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ck_notification;
        private System.Windows.Forms.NumericUpDown nmrc_period;
    }
}
