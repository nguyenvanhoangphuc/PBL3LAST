
namespace QuanLyPhongTroLinQ.View
{
    partial class FormDSPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new CustomButton.VBButton();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.cbID = new System.Windows.Forms.CheckBox();
            this.cbTT = new System.Windows.Forms.CheckBox();
            this.cbTen = new System.Windows.Forms.CheckBox();
            this.cbLoai = new System.Windows.Forms.CheckBox();
            this.vbButton4 = new CustomButton.VBButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.DGVPhongTro = new System.Windows.Forms.DataGridView();
            this.vbButton5 = new CustomButton.VBButton();
            this.btnDel = new CustomButton.VBButton();
            this.btnUpdate = new CustomButton.VBButton();
            this.btnAdd = new CustomButton.VBButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPhongTro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.DGVPhongTro);
            this.panel4.Controls.Add(this.vbButton5);
            this.panel4.Controls.Add(this.btnDel);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lblTieuDe);
            this.panel4.Location = new System.Drawing.Point(9, 9);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 496);
            this.panel4.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.gbSearch);
            this.panel1.Controls.Add(this.vbButton4);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(396, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 118);
            this.panel1.TabIndex = 27;
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
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.cbID);
            this.gbSearch.Controls.Add(this.cbTT);
            this.gbSearch.Controls.Add(this.cbTen);
            this.gbSearch.Controls.Add(this.cbLoai);
            this.gbSearch.Location = new System.Drawing.Point(14, 36);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(2);
            this.gbSearch.Size = new System.Drawing.Size(326, 36);
            this.gbSearch.TabIndex = 5;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search theo:";
            // 
            // cbID
            // 
            this.cbID.AutoSize = true;
            this.cbID.Location = new System.Drawing.Point(49, 15);
            this.cbID.Margin = new System.Windows.Forms.Padding(2);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(37, 17);
            this.cbID.TabIndex = 4;
            this.cbID.Text = "ID";
            this.cbID.UseVisualStyleBackColor = true;
            // 
            // cbTT
            // 
            this.cbTT.AutoSize = true;
            this.cbTT.Location = new System.Drawing.Point(255, 15);
            this.cbTT.Margin = new System.Windows.Forms.Padding(2);
            this.cbTT.Name = "cbTT";
            this.cbTT.Size = new System.Drawing.Size(74, 17);
            this.cbTT.TabIndex = 4;
            this.cbTT.Text = "Tình trạng";
            this.cbTT.UseVisualStyleBackColor = true;
            // 
            // cbTen
            // 
            this.cbTen.AutoSize = true;
            this.cbTen.Location = new System.Drawing.Point(90, 15);
            this.cbTen.Margin = new System.Windows.Forms.Padding(2);
            this.cbTen.Name = "cbTen";
            this.cbTen.Size = new System.Drawing.Size(78, 17);
            this.cbTen.TabIndex = 4;
            this.cbTen.Text = "Tên phòng";
            this.cbTen.UseVisualStyleBackColor = true;
            // 
            // cbLoai
            // 
            this.cbLoai.AutoSize = true;
            this.cbLoai.Location = new System.Drawing.Point(172, 15);
            this.cbLoai.Margin = new System.Windows.Forms.Padding(2);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(79, 17);
            this.cbLoai.TabIndex = 4;
            this.cbLoai.Text = "Loại phòng";
            this.cbLoai.UseVisualStyleBackColor = true;
            // 
            // vbButton4
            // 
            this.vbButton4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.vbButton4.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.vbButton4.BorderColor = System.Drawing.Color.DimGray;
            this.vbButton4.BorderRadius = 5;
            this.vbButton4.BorderSize = 3;
            this.vbButton4.FlatAppearance.BorderSize = 0;
            this.vbButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton4.ForeColor = System.Drawing.Color.White;
            this.vbButton4.Location = new System.Drawing.Point(240, 73);
            this.vbButton4.Name = "vbButton4";
            this.vbButton4.Size = new System.Drawing.Size(103, 34);
            this.vbButton4.TabIndex = 25;
            this.vbButton4.Text = "Default";
            this.vbButton4.TextColor = System.Drawing.Color.White;
            this.vbButton4.UseVisualStyleBackColor = false;
            this.vbButton4.Click += new System.EventHandler(this.butDefault_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(145, 3);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(195, 29);
            this.txtSearch.TabIndex = 0;
            // 
            // DGVPhongTro
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.DGVPhongTro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVPhongTro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPhongTro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVPhongTro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVPhongTro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVPhongTro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPhongTro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVPhongTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVPhongTro.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVPhongTro.EnableHeadersVisualStyles = false;
            this.DGVPhongTro.Location = new System.Drawing.Point(29, 110);
            this.DGVPhongTro.Margin = new System.Windows.Forms.Padding(2);
            this.DGVPhongTro.Name = "DGVPhongTro";
            this.DGVPhongTro.RowHeadersWidth = 51;
            this.DGVPhongTro.RowTemplate.Height = 24;
            this.DGVPhongTro.Size = new System.Drawing.Size(713, 225);
            this.DGVPhongTro.TabIndex = 26;
            // 
            // vbButton5
            // 
            this.vbButton5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.vbButton5.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.vbButton5.BorderColor = System.Drawing.Color.DimGray;
            this.vbButton5.BorderRadius = 5;
            this.vbButton5.BorderSize = 3;
            this.vbButton5.FlatAppearance.BorderSize = 0;
            this.vbButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton5.ForeColor = System.Drawing.Color.White;
            this.vbButton5.Location = new System.Drawing.Point(269, 362);
            this.vbButton5.Name = "vbButton5";
            this.vbButton5.Size = new System.Drawing.Size(74, 65);
            this.vbButton5.TabIndex = 25;
            this.vbButton5.Text = "Xem người thuê";
            this.vbButton5.TextColor = System.Drawing.Color.White;
            this.vbButton5.UseVisualStyleBackColor = false;
            this.vbButton5.Click += new System.EventHandler(this.butXemNguoiThue_Click);
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
            this.btnDel.Location = new System.Drawing.Point(189, 362);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(74, 65);
            this.btnDel.TabIndex = 25;
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
            this.btnUpdate.Location = new System.Drawing.Point(109, 362);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 65);
            this.btnUpdate.TabIndex = 25;
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
            this.btnAdd.Location = new System.Drawing.Point(29, 362);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 65);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh sách phòng trọ";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(68, 91);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(171, 17);
            this.lblTieuDe.TabIndex = 3;
            this.lblTieuDe.Text = "Bảng danh sách các phòng trọ";
            // 
            // FormDSPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(794, 514);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 70);
            this.Name = "FormDSPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPhongTro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.CheckBox cbTT;
        private System.Windows.Forms.CheckBox cbTen;
        private System.Windows.Forms.CheckBox cbLoai;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox cbID;
        private CustomButton.VBButton btnAdd;
        private System.Windows.Forms.DataGridView DGVPhongTro;
        private CustomButton.VBButton vbButton5;
        private CustomButton.VBButton vbButton4;
        private CustomButton.VBButton btnSearch;
        private CustomButton.VBButton btnDel;
        private CustomButton.VBButton btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}