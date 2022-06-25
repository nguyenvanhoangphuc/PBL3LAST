namespace QuanLyPhongTroLinQ.View
{
    partial class FormQLNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblChoDuyet = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.cbTen = new System.Windows.Forms.CheckBox();
            this.cbCCCD = new System.Windows.Forms.CheckBox();
            this.cbQueQuan = new System.Windows.Forms.CheckBox();
            this.cbSDT = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new CustomButton.VBButton();
            this.btnDefault = new CustomButton.VBButton();
            this.btnDel = new CustomButton.VBButton();
            this.btnUpdate = new CustomButton.VBButton();
            this.btnAdd = new CustomButton.VBButton();
            this.DGVNhanVien = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.DGVNhanVien);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.lblChoDuyet);
            this.panel4.Controls.Add(this.btnDel);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lblTieuDe);
            this.panel4.Location = new System.Drawing.Point(9, 9);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 496);
            this.panel4.TabIndex = 11;
            // 
            // lblChoDuyet
            // 
            this.lblChoDuyet.AutoSize = true;
            this.lblChoDuyet.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoDuyet.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblChoDuyet.Location = new System.Drawing.Point(589, 73);
            this.lblChoDuyet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoDuyet.Name = "lblChoDuyet";
            this.lblChoDuyet.Size = new System.Drawing.Size(143, 15);
            this.lblChoDuyet.TabIndex = 6;
            this.lblChoDuyet.Text = "Nhân viên chờ được duyệt";
            this.lblChoDuyet.Click += new System.EventHandler(this.lblChoDuyet_Click);
            this.lblChoDuyet.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            this.lblChoDuyet.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.cbTen);
            this.gbSearch.Controls.Add(this.cbCCCD);
            this.gbSearch.Controls.Add(this.cbQueQuan);
            this.gbSearch.Controls.Add(this.cbSDT);
            this.gbSearch.Location = new System.Drawing.Point(14, 36);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSearch.Size = new System.Drawing.Size(281, 36);
            this.gbSearch.TabIndex = 5;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search theo:";
            // 
            // cbTen
            // 
            this.cbTen.AutoSize = true;
            this.cbTen.Location = new System.Drawing.Point(25, 15);
            this.cbTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTen.Name = "cbTen";
            this.cbTen.Size = new System.Drawing.Size(45, 17);
            this.cbTen.TabIndex = 4;
            this.cbTen.Text = "Ten";
            this.cbTen.UseVisualStyleBackColor = true;
            // 
            // cbCCCD
            // 
            this.cbCCCD.AutoSize = true;
            this.cbCCCD.Location = new System.Drawing.Point(203, 15);
            this.cbCCCD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCCCD.Name = "cbCCCD";
            this.cbCCCD.Size = new System.Drawing.Size(55, 17);
            this.cbCCCD.TabIndex = 4;
            this.cbCCCD.Text = "CCCD";
            this.cbCCCD.UseVisualStyleBackColor = true;
            // 
            // cbQueQuan
            // 
            this.cbQueQuan.AutoSize = true;
            this.cbQueQuan.Location = new System.Drawing.Point(74, 15);
            this.cbQueQuan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbQueQuan.Name = "cbQueQuan";
            this.cbQueQuan.Size = new System.Drawing.Size(73, 17);
            this.cbQueQuan.TabIndex = 4;
            this.cbQueQuan.Text = "Quê quán";
            this.cbQueQuan.UseVisualStyleBackColor = true;
            // 
            // cbSDT
            // 
            this.cbSDT.AutoSize = true;
            this.cbSDT.Location = new System.Drawing.Point(151, 15);
            this.cbSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSDT.Name = "cbSDT";
            this.cbSDT.Size = new System.Drawing.Size(48, 17);
            this.cbSDT.TabIndex = 4;
            this.cbSDT.Text = "SDT";
            this.cbSDT.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản lý nhân viên";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(29, 73);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(180, 15);
            this.lblTieuDe.TabIndex = 3;
            this.lblTieuDe.Text = "Bảng danh sách các nhân viên";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(145, 3);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(169, 29);
            this.txtSearch.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnDefault);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.gbSearch);
            this.panel1.Location = new System.Drawing.Point(386, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 118);
            this.panel1.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Thông tin cần tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSearch.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSearch.BorderColor = System.Drawing.Color.DimGray;
            this.btnSearch.BorderRadius = 5;
            this.btnSearch.BorderSize = 3;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(31, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 34);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDefault.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDefault.BorderColor = System.Drawing.Color.DimGray;
            this.btnDefault.BorderRadius = 5;
            this.btnDefault.BorderSize = 3;
            this.btnDefault.FlatAppearance.BorderSize = 0;
            this.btnDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefault.ForeColor = System.Drawing.Color.White;
            this.btnDefault.Location = new System.Drawing.Point(211, 73);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(103, 34);
            this.btnDefault.TabIndex = 25;
            this.btnDefault.Text = "Default";
            this.btnDefault.TextColor = System.Drawing.Color.White;
            this.btnDefault.UseVisualStyleBackColor = false;
            this.btnDefault.Click += new System.EventHandler(this.butDefault_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDel.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDel.BorderColor = System.Drawing.Color.DimGray;
            this.btnDel.BorderRadius = 5;
            this.btnDel.BorderSize = 3;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(179, 363);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(74, 65);
            this.btnDel.TabIndex = 29;
            this.btnDel.Text = "Del";
            this.btnDel.TextColor = System.Drawing.Color.White;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpdate.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpdate.BorderColor = System.Drawing.Color.DimGray;
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.BorderSize = 3;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(99, 363);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 65);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.BorderColor = System.Drawing.Color.DimGray;
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.BorderSize = 3;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(19, 363);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 65);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DGVNhanVien
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.DGVNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVNhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVNhanVien.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVNhanVien.EnableHeadersVisualStyles = false;
            this.DGVNhanVien.Location = new System.Drawing.Point(19, 90);
            this.DGVNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.DGVNhanVien.Name = "DGVNhanVien";
            this.DGVNhanVien.RowHeadersWidth = 51;
            this.DGVNhanVien.RowTemplate.Height = 24;
            this.DGVNhanVien.Size = new System.Drawing.Size(713, 247);
            this.DGVNhanVien.TabIndex = 33;
            // 
            // FormQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 514);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 70);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormQLNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormNguoiDung";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.CheckBox cbTen;
        private System.Windows.Forms.CheckBox cbCCCD;
        private System.Windows.Forms.CheckBox cbQueQuan;
        private System.Windows.Forms.CheckBox cbSDT;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblChoDuyet;
        private System.Windows.Forms.Label label1;
        private CustomButton.VBButton btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private CustomButton.VBButton btnSearch;
        private CustomButton.VBButton btnDefault;
        private CustomButton.VBButton btnDel;
        private CustomButton.VBButton btnUpdate;
        private System.Windows.Forms.DataGridView DGVNhanVien;
    }
}