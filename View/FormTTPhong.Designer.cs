namespace QuanLyPhongTroLinQ.View
{
    partial class FormTTPhong
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
            this.panel30 = new System.Windows.Forms.Panel();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtSoChuDien = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.lblDSTV = new System.Windows.Forms.Label();
            this.lblTienHienTai = new System.Windows.Forms.Label();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.lblSoChuDien = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnTraPhong = new CustomButton.VBButton();
            this.btnDong = new CustomButton.VBButton();
            this.dgvNguoiThue = new System.Windows.Forms.DataGridView();
            this.panel30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiThue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.SystemColors.Control;
            this.panel30.Controls.Add(this.dgvNguoiThue);
            this.panel30.Controls.Add(this.btnDong);
            this.panel30.Controls.Add(this.btnTraPhong);
            this.panel30.Controls.Add(this.txtLoaiPhong);
            this.panel30.Controls.Add(this.txtSoTien);
            this.panel30.Controls.Add(this.txtSoChuDien);
            this.panel30.Controls.Add(this.txtTenPhong);
            this.panel30.Controls.Add(this.lblDSTV);
            this.panel30.Controls.Add(this.lblTienHienTai);
            this.panel30.Controls.Add(this.lblLoaiPhong);
            this.panel30.Controls.Add(this.lblSoChuDien);
            this.panel30.Controls.Add(this.lblNote);
            this.panel30.Controls.Add(this.lblTenPhong);
            this.panel30.Controls.Add(this.lblHeader);
            this.panel30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel30.Location = new System.Drawing.Point(10, 8);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(774, 496);
            this.panel30.TabIndex = 1;
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Location = new System.Drawing.Point(343, 108);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(232, 22);
            this.txtLoaiPhong.TabIndex = 22;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(343, 184);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(232, 22);
            this.txtSoTien.TabIndex = 22;
            // 
            // txtSoChuDien
            // 
            this.txtSoChuDien.Location = new System.Drawing.Point(343, 145);
            this.txtSoChuDien.Name = "txtSoChuDien";
            this.txtSoChuDien.Size = new System.Drawing.Size(232, 22);
            this.txtSoChuDien.TabIndex = 22;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(343, 71);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(232, 22);
            this.txtTenPhong.TabIndex = 22;
            // 
            // lblDSTV
            // 
            this.lblDSTV.AutoSize = true;
            this.lblDSTV.ForeColor = System.Drawing.Color.Maroon;
            this.lblDSTV.Location = new System.Drawing.Point(269, 225);
            this.lblDSTV.Name = "lblDSTV";
            this.lblDSTV.Size = new System.Drawing.Size(241, 16);
            this.lblDSTV.TabIndex = 18;
            this.lblDSTV.Text = "Danh sách thành viên trong phòng";
            // 
            // lblTienHienTai
            // 
            this.lblTienHienTai.AutoSize = true;
            this.lblTienHienTai.ForeColor = System.Drawing.Color.Maroon;
            this.lblTienHienTai.Location = new System.Drawing.Point(206, 187);
            this.lblTienHienTai.Name = "lblTienHienTai";
            this.lblTienHienTai.Size = new System.Drawing.Size(110, 16);
            this.lblTienHienTai.TabIndex = 18;
            this.lblTienHienTai.Text = "Số tiền hiện tại";
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.ForeColor = System.Drawing.Color.Maroon;
            this.lblLoaiPhong.Location = new System.Drawing.Point(206, 110);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(85, 16);
            this.lblLoaiPhong.TabIndex = 18;
            this.lblLoaiPhong.Text = "Loại phòng";
            // 
            // lblSoChuDien
            // 
            this.lblSoChuDien.AutoSize = true;
            this.lblSoChuDien.ForeColor = System.Drawing.Color.Maroon;
            this.lblSoChuDien.Location = new System.Drawing.Point(206, 149);
            this.lblSoChuDien.Name = "lblSoChuDien";
            this.lblSoChuDien.Size = new System.Drawing.Size(89, 16);
            this.lblSoChuDien.TabIndex = 18;
            this.lblSoChuDien.Text = "Số chữ điện";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(156, 453);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(341, 32);
            this.lblNote.TabIndex = 21;
            this.lblNote.Text = "Ghi chú : Không thể trả phòng nếu số tiền hiện tại\r\nđang âm";
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.ForeColor = System.Drawing.Color.Maroon;
            this.lblTenPhong.Location = new System.Drawing.Point(206, 74);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(82, 16);
            this.lblTenPhong.TabIndex = 18;
            this.lblTenPhong.Text = "Tên phòng";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeader.Location = new System.Drawing.Point(284, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(240, 40);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "Thông tin phòng";
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTraPhong.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTraPhong.BorderColor = System.Drawing.Color.DimGray;
            this.btnTraPhong.BorderRadius = 5;
            this.btnTraPhong.BorderSize = 3;
            this.btnTraPhong.FlatAppearance.BorderSize = 0;
            this.btnTraPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraPhong.ForeColor = System.Drawing.Color.White;
            this.btnTraPhong.Location = new System.Drawing.Point(189, 394);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(112, 43);
            this.btnTraPhong.TabIndex = 30;
            this.btnTraPhong.Text = "Trả phòng";
            this.btnTraPhong.TextColor = System.Drawing.Color.White;
            this.btnTraPhong.UseVisualStyleBackColor = false;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDong.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDong.BorderColor = System.Drawing.Color.DimGray;
            this.btnDong.BorderRadius = 5;
            this.btnDong.BorderSize = 3;
            this.btnDong.FlatAppearance.BorderSize = 0;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(479, 394);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(112, 43);
            this.btnDong.TabIndex = 31;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextColor = System.Drawing.Color.White;
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // dgvNguoiThue
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvNguoiThue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNguoiThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguoiThue.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvNguoiThue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNguoiThue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNguoiThue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNguoiThue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNguoiThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNguoiThue.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNguoiThue.EnableHeadersVisualStyles = false;
            this.dgvNguoiThue.Location = new System.Drawing.Point(77, 247);
            this.dgvNguoiThue.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNguoiThue.Name = "dgvNguoiThue";
            this.dgvNguoiThue.RowHeadersWidth = 51;
            this.dgvNguoiThue.RowTemplate.Height = 24;
            this.dgvNguoiThue.Size = new System.Drawing.Size(623, 142);
            this.dgvNguoiThue.TabIndex = 32;
            // 
            // FormTTPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 514);
            this.Controls.Add(this.panel30);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 70);
            this.Name = "FormTTPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormLoaiPhong";
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiThue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.TextBox txtSoChuDien;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.Label lblSoChuDien;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Label lblDSTV;
        private System.Windows.Forms.Label lblTienHienTai;
        private CustomButton.VBButton btnDong;
        private CustomButton.VBButton btnTraPhong;
        private System.Windows.Forms.DataGridView dgvNguoiThue;
    }
}