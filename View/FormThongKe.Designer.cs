namespace QuanLyPhongTroLinQ.View
{
    partial class FormThongKe
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
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            this.cbbYear = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPhongHienTai = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSophong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXemChiTiet = new CustomButton.VBButton();
            this.btnRevert = new CustomButton.VBButton();
            this.DGVThongKe = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.DGVThongKe);
            this.panel4.Controls.Add(this.btnRevert);
            this.panel4.Controls.Add(this.cbbMonth);
            this.panel4.Controls.Add(this.cbbYear);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(9, 9);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 496);
            this.panel4.TabIndex = 11;
            // 
            // cbbMonth
            // 
            this.cbbMonth.FormattingEnabled = true;
            this.cbbMonth.Location = new System.Drawing.Point(428, 100);
            this.cbbMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Size = new System.Drawing.Size(92, 21);
            this.cbbMonth.TabIndex = 10;
            this.cbbMonth.SelectedIndexChanged += new System.EventHandler(this.cbbMonth_SelectedIndexChanged);
            // 
            // cbbYear
            // 
            this.cbbYear.FormattingEnabled = true;
            this.cbbYear.Location = new System.Drawing.Point(223, 100);
            this.cbbYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbYear.Name = "cbbYear";
            this.cbbYear.Size = new System.Drawing.Size(92, 21);
            this.cbbYear.TabIndex = 10;
            this.cbbYear.SelectedIndexChanged += new System.EventHandler(this.cbbYear_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "vào tháng: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Thống kê theo năm: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGreen;
            this.panel2.Controls.Add(this.lblPhongHienTai);
            this.panel2.Controls.Add(this.btnXemChiTiet);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(589, 202);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 180);
            this.panel2.TabIndex = 8;
            // 
            // lblPhongHienTai
            // 
            this.lblPhongHienTai.AutoSize = true;
            this.lblPhongHienTai.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhongHienTai.Location = new System.Drawing.Point(72, 60);
            this.lblPhongHienTai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhongHienTai.Name = "lblPhongHienTai";
            this.lblPhongHienTai.Size = new System.Drawing.Size(26, 32);
            this.lblPhongHienTai.TabIndex = 3;
            this.lblPhongHienTai.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(16, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chi tiết phòng số:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.lblSophong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(589, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 78);
            this.panel1.TabIndex = 7;
            // 
            // lblSophong
            // 
            this.lblSophong.AutoSize = true;
            this.lblSophong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSophong.ForeColor = System.Drawing.Color.Red;
            this.lblSophong.Location = new System.Drawing.Point(74, 43);
            this.lblSophong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSophong.Name = "lblSophong";
            this.lblSophong.Size = new System.Drawing.Size(20, 22);
            this.lblSophong.TabIndex = 0;
            this.lblSophong.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số phòng hiện có:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thống kê sửa chữa thiết bị";
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXemChiTiet.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXemChiTiet.BorderColor = System.Drawing.Color.DimGray;
            this.btnXemChiTiet.BorderRadius = 5;
            this.btnXemChiTiet.BorderSize = 3;
            this.btnXemChiTiet.FlatAppearance.BorderSize = 0;
            this.btnXemChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnXemChiTiet.Location = new System.Drawing.Point(21, 106);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(128, 43);
            this.btnXemChiTiet.TabIndex = 34;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.TextColor = System.Drawing.Color.White;
            this.btnXemChiTiet.UseVisualStyleBackColor = false;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // btnRevert
            // 
            this.btnRevert.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRevert.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRevert.BorderColor = System.Drawing.Color.DimGray;
            this.btnRevert.BorderRadius = 5;
            this.btnRevert.BorderSize = 3;
            this.btnRevert.FlatAppearance.BorderSize = 0;
            this.btnRevert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevert.ForeColor = System.Drawing.Color.White;
            this.btnRevert.Location = new System.Drawing.Point(610, 399);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(128, 43);
            this.btnRevert.TabIndex = 33;
            this.btnRevert.Text = "Trở lại";
            this.btnRevert.TextColor = System.Drawing.Color.White;
            this.btnRevert.UseVisualStyleBackColor = false;
            this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // DGVThongKe
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.DGVThongKe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVThongKe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVThongKe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVThongKe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVThongKe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVThongKe.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVThongKe.EnableHeadersVisualStyles = false;
            this.DGVThongKe.Location = new System.Drawing.Point(33, 141);
            this.DGVThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.DGVThongKe.Name = "DGVThongKe";
            this.DGVThongKe.RowHeadersWidth = 51;
            this.DGVThongKe.RowTemplate.Height = 24;
            this.DGVThongKe.Size = new System.Drawing.Size(538, 312);
            this.DGVThongKe.TabIndex = 35;
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 514);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 70);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormThongKe";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSophong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPhongHienTai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbMonth;
        private System.Windows.Forms.ComboBox cbbYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private CustomButton.VBButton btnXemChiTiet;
        private CustomButton.VBButton btnRevert;
        private System.Windows.Forms.DataGridView DGVThongKe;
    }
}