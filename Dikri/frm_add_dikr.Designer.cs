
namespace Dikri
{
    partial class frm_add_dikr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_dikr));
            this.lblCmbList = new System.Windows.Forms.Label();
            this.cmb_List = new System.Windows.Forms.ComboBox();
            this.lblTxtDikr = new System.Windows.Forms.Label();
            this.lblTxtRepeat = new System.Windows.Forms.Label();
            this.txt_dikr = new System.Windows.Forms.TextBox();
            this.txt_repeat = new System.Windows.Forms.TextBox();
            this.lblTxtNumber = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.tbl_container = new System.Windows.Forms.TableLayoutPanel();
            this.btn_close = new System.Windows.Forms.Button();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.btn_minimise = new System.Windows.Forms.Button();
            this.btn_add_dikr = new System.Windows.Forms.Button();
            this.tbl_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCmbList
            // 
            this.lblCmbList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCmbList.AutoSize = true;
            this.tbl_container.SetColumnSpan(this.lblCmbList, 3);
            this.lblCmbList.Font = new System.Drawing.Font("Noto Kufi Arabic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmbList.ForeColor = System.Drawing.Color.White;
            this.lblCmbList.Location = new System.Drawing.Point(15, 73);
            this.lblCmbList.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.lblCmbList.Name = "lblCmbList";
            this.lblCmbList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCmbList.Size = new System.Drawing.Size(524, 27);
            this.lblCmbList.TabIndex = 24;
            this.lblCmbList.Text = "إختر قائمة الذكر:";
            // 
            // cmb_List
            // 
            this.cmb_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.tbl_container.SetColumnSpan(this.cmb_List, 3);
            this.cmb_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_List.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_List.Font = new System.Drawing.Font("Noto Kufi Arabic", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmb_List.ForeColor = System.Drawing.Color.White;
            this.cmb_List.FormattingEnabled = true;
            this.cmb_List.Location = new System.Drawing.Point(15, 100);
            this.cmb_List.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.cmb_List.Name = "cmb_List";
            this.cmb_List.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_List.Size = new System.Drawing.Size(524, 48);
            this.cmb_List.TabIndex = 16;
            this.cmb_List.SelectedIndexChanged += new System.EventHandler(this.cmbList_SelectedIndexChanged);
            // 
            // lblTxtDikr
            // 
            this.lblTxtDikr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTxtDikr.AutoSize = true;
            this.tbl_container.SetColumnSpan(this.lblTxtDikr, 3);
            this.lblTxtDikr.Font = new System.Drawing.Font("Noto Kufi Arabic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtDikr.ForeColor = System.Drawing.Color.White;
            this.lblTxtDikr.Location = new System.Drawing.Point(15, 415);
            this.lblTxtDikr.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.lblTxtDikr.Name = "lblTxtDikr";
            this.lblTxtDikr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTxtDikr.Size = new System.Drawing.Size(524, 27);
            this.lblTxtDikr.TabIndex = 23;
            this.lblTxtDikr.Text = "الذكر:";
            // 
            // lblTxtRepeat
            // 
            this.lblTxtRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTxtRepeat.AutoSize = true;
            this.tbl_container.SetColumnSpan(this.lblTxtRepeat, 3);
            this.lblTxtRepeat.Font = new System.Drawing.Font("Noto Kufi Arabic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtRepeat.ForeColor = System.Drawing.Color.White;
            this.lblTxtRepeat.Location = new System.Drawing.Point(15, 301);
            this.lblTxtRepeat.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.lblTxtRepeat.Name = "lblTxtRepeat";
            this.lblTxtRepeat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTxtRepeat.Size = new System.Drawing.Size(524, 27);
            this.lblTxtRepeat.TabIndex = 22;
            this.lblTxtRepeat.Text = "عدد التكرار:";
            // 
            // txt_dikr
            // 
            this.txt_dikr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.txt_dikr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_container.SetColumnSpan(this.txt_dikr, 3);
            this.txt_dikr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_dikr.Font = new System.Drawing.Font("Noto Kufi Arabic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dikr.ForeColor = System.Drawing.Color.White;
            this.txt_dikr.Location = new System.Drawing.Point(15, 442);
            this.txt_dikr.Margin = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.txt_dikr.Multiline = true;
            this.txt_dikr.Name = "txt_dikr";
            this.txt_dikr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_dikr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_dikr.Size = new System.Drawing.Size(524, 186);
            this.txt_dikr.TabIndex = 20;
            // 
            // txt_repeat
            // 
            this.txt_repeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.txt_repeat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_container.SetColumnSpan(this.txt_repeat, 3);
            this.txt_repeat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_repeat.Font = new System.Drawing.Font("Noto Kufi Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_repeat.ForeColor = System.Drawing.Color.White;
            this.txt_repeat.Location = new System.Drawing.Point(15, 328);
            this.txt_repeat.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.txt_repeat.Name = "txt_repeat";
            this.txt_repeat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_repeat.Size = new System.Drawing.Size(524, 41);
            this.txt_repeat.TabIndex = 19;
            this.txt_repeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_repeat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRepeat_KeyPress);
            // 
            // lblTxtNumber
            // 
            this.lblTxtNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTxtNumber.AutoSize = true;
            this.tbl_container.SetColumnSpan(this.lblTxtNumber, 3);
            this.lblTxtNumber.Font = new System.Drawing.Font("Noto Kufi Arabic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtNumber.ForeColor = System.Drawing.Color.White;
            this.lblTxtNumber.Location = new System.Drawing.Point(15, 187);
            this.lblTxtNumber.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.lblTxtNumber.Name = "lblTxtNumber";
            this.lblTxtNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTxtNumber.Size = new System.Drawing.Size(524, 27);
            this.lblTxtNumber.TabIndex = 17;
            this.lblTxtNumber.Text = "الذِّكر رقم:";
            // 
            // txt_number
            // 
            this.txt_number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.txt_number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_container.SetColumnSpan(this.txt_number, 3);
            this.txt_number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_number.Font = new System.Drawing.Font("Noto Kufi Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_number.ForeColor = System.Drawing.Color.White;
            this.txt_number.Location = new System.Drawing.Point(15, 214);
            this.txt_number.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.txt_number.Name = "txt_number";
            this.txt_number.ReadOnly = true;
            this.txt_number.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_number.Size = new System.Drawing.Size(524, 41);
            this.txt_number.TabIndex = 18;
            this.txt_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbl_container
            // 
            this.tbl_container.ColumnCount = 3;
            this.tbl_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.205776F));
            this.tbl_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.00722F));
            this.tbl_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.63653F));
            this.tbl_container.Controls.Add(this.btn_close, 0, 0);
            this.tbl_container.Controls.Add(this.lblHeaderTitle, 2, 0);
            this.tbl_container.Controls.Add(this.btn_minimise, 1, 0);
            this.tbl_container.Controls.Add(this.lblCmbList, 0, 1);
            this.tbl_container.Controls.Add(this.cmb_List, 0, 2);
            this.tbl_container.Controls.Add(this.lblTxtNumber, 0, 3);
            this.tbl_container.Controls.Add(this.txt_number, 0, 4);
            this.tbl_container.Controls.Add(this.lblTxtRepeat, 0, 5);
            this.tbl_container.Controls.Add(this.txt_repeat, 0, 6);
            this.tbl_container.Controls.Add(this.lblTxtDikr, 0, 7);
            this.tbl_container.Controls.Add(this.txt_dikr, 0, 8);
            this.tbl_container.Controls.Add(this.btn_add_dikr, 0, 9);
            this.tbl_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_container.ForeColor = System.Drawing.Color.White;
            this.tbl_container.Location = new System.Drawing.Point(0, 0);
            this.tbl_container.Name = "tbl_container";
            this.tbl_container.RowCount = 10;
            this.tbl_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tbl_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tbl_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbl_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tbl_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbl_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tbl_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbl_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tbl_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tbl_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbl_container.Size = new System.Drawing.Size(554, 719);
            this.tbl_container.TabIndex = 28;
            this.tbl_container.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseDown);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_close.Location = new System.Drawing.Point(3, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(45, 51);
            this.btn_close.TabIndex = 11;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btnX_Click);
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Noto Kufi Arabic", 8F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHeaderTitle.Location = new System.Drawing.Point(464, 0);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHeaderTitle.Size = new System.Drawing.Size(87, 57);
            this.lblHeaderTitle.TabIndex = 15;
            this.lblHeaderTitle.Text = "الذِّكر اليومي";
            this.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_minimise
            // 
            this.btn_minimise.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimise.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_minimise.FlatAppearance.BorderSize = 0;
            this.btn_minimise.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_minimise.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btn_minimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimise.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.btn_minimise.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_minimise.Location = new System.Drawing.Point(54, 3);
            this.btn_minimise.Name = "btn_minimise";
            this.btn_minimise.Size = new System.Drawing.Size(45, 51);
            this.btn_minimise.TabIndex = 12;
            this.btn_minimise.Text = "-";
            this.btn_minimise.UseVisualStyleBackColor = false;
            this.btn_minimise.Click += new System.EventHandler(this.btnMinimise_Click);
            // 
            // btn_add_dikr
            // 
            this.tbl_container.SetColumnSpan(this.btn_add_dikr, 3);
            this.btn_add_dikr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_dikr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_add_dikr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_add_dikr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btn_add_dikr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_dikr.Font = new System.Drawing.Font("Noto Kufi Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_dikr.ForeColor = System.Drawing.Color.White;
            this.btn_add_dikr.Location = new System.Drawing.Point(15, 643);
            this.btn_add_dikr.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn_add_dikr.Name = "btn_add_dikr";
            this.btn_add_dikr.Size = new System.Drawing.Size(524, 51);
            this.btn_add_dikr.TabIndex = 21;
            this.btn_add_dikr.Text = "إضافة";
            this.btn_add_dikr.UseVisualStyleBackColor = true;
            this.btn_add_dikr.Click += new System.EventHandler(this.btnAddDikr_Click);
            // 
            // frm_add_dikr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(554, 719);
            this.Controls.Add(this.tbl_container);
            this.Font = new System.Drawing.Font("Noto Kufi Arabic", 10F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frm_add_dikr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_add_dikr";
            this.Load += new System.EventHandler(this.frm_add_dikr_Load);
            this.tbl_container.ResumeLayout(false);
            this.tbl_container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCmbList;
        private System.Windows.Forms.ComboBox cmb_List;
        private System.Windows.Forms.Label lblTxtDikr;
        private System.Windows.Forms.Label lblTxtRepeat;
        private System.Windows.Forms.TextBox txt_dikr;
        private System.Windows.Forms.TextBox txt_repeat;
        private System.Windows.Forms.Label lblTxtNumber;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.TableLayoutPanel tbl_container;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Button btn_minimise;
        private System.Windows.Forms.Button btn_add_dikr;
    }
}