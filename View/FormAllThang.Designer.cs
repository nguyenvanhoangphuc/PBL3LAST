namespace QuanLyPhongTroLinQ.View
{
    partial class FormAllThang
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
            this.dgv_DSThang = new System.Windows.Forms.DataGridView();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_CaHai = new System.Windows.Forms.RadioButton();
            this.rdo_DaNop = new System.Windows.Forms.RadioButton();
            this.rdo_ChuaNop = new System.Windows.Forms.RadioButton();
            this.lbl_TenPhong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vbButton1 = new CustomButton.VBButton();
            this.vbButton2 = new CustomButton.VBButton();
            this.vbButton3 = new CustomButton.VBButton();
            this.vbButton4 = new CustomButton.VBButton();
            this.vbButton5 = new CustomButton.VBButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSThang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DSThang
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgv_DSThang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DSThang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_DSThang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DSThang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_DSThang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DSThang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DSThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DSThang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DSThang.EnableHeadersVisualStyles = false;
            this.dgv_DSThang.Location = new System.Drawing.Point(27, 124);
            this.dgv_DSThang.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_DSThang.Name = "dgv_DSThang";
            this.dgv_DSThang.RowHeadersWidth = 51;
            this.dgv_DSThang.RowTemplate.Height = 24;
            this.dgv_DSThang.Size = new System.Drawing.Size(771, 231);
            this.dgv_DSThang.TabIndex = 0;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(142, 59);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(157, 20);
            this.txt_TimKiem.TabIndex = 1;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Location = new System.Drawing.Point(26, 62);
            this.lbl_TimKiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(99, 13);
            this.lbl_TimKiem.TabIndex = 2;
            this.lbl_TimKiem.Text = "Tìm kiếm theo ngày";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_CaHai);
            this.groupBox1.Controls.Add(this.rdo_DaNop);
            this.groupBox1.Controls.Add(this.rdo_ChuaNop);
            this.groupBox1.Location = new System.Drawing.Point(494, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(304, 58);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chế độ hiển thị";
            // 
            // rdo_CaHai
            // 
            this.rdo_CaHai.AutoSize = true;
            this.rdo_CaHai.Location = new System.Drawing.Point(232, 25);
            this.rdo_CaHai.Margin = new System.Windows.Forms.Padding(2);
            this.rdo_CaHai.Name = "rdo_CaHai";
            this.rdo_CaHai.Size = new System.Drawing.Size(55, 17);
            this.rdo_CaHai.TabIndex = 0;
            this.rdo_CaHai.TabStop = true;
            this.rdo_CaHai.Text = "Cả hai";
            this.rdo_CaHai.UseVisualStyleBackColor = true;
            this.rdo_CaHai.CheckedChanged += new System.EventHandler(this.rdo_CaHai_CheckedChanged);
            // 
            // rdo_DaNop
            // 
            this.rdo_DaNop.AutoSize = true;
            this.rdo_DaNop.Location = new System.Drawing.Point(133, 25);
            this.rdo_DaNop.Margin = new System.Windows.Forms.Padding(2);
            this.rdo_DaNop.Name = "rdo_DaNop";
            this.rdo_DaNop.Size = new System.Drawing.Size(93, 17);
            this.rdo_DaNop.TabIndex = 0;
            this.rdo_DaNop.TabStop = true;
            this.rdo_DaNop.Text = "Tháng đã nộp";
            this.rdo_DaNop.UseVisualStyleBackColor = true;
            this.rdo_DaNop.CheckedChanged += new System.EventHandler(this.rdo_DaNop_CheckedChanged);
            // 
            // rdo_ChuaNop
            // 
            this.rdo_ChuaNop.AutoSize = true;
            this.rdo_ChuaNop.Location = new System.Drawing.Point(21, 25);
            this.rdo_ChuaNop.Margin = new System.Windows.Forms.Padding(2);
            this.rdo_ChuaNop.Name = "rdo_ChuaNop";
            this.rdo_ChuaNop.Size = new System.Drawing.Size(104, 17);
            this.rdo_ChuaNop.TabIndex = 0;
            this.rdo_ChuaNop.TabStop = true;
            this.rdo_ChuaNop.Text = "Tháng chưa nộp";
            this.rdo_ChuaNop.UseVisualStyleBackColor = true;
            this.rdo_ChuaNop.CheckedChanged += new System.EventHandler(this.rdo_ChuaNop_CheckedChanged);
            // 
            // lbl_TenPhong
            // 
            this.lbl_TenPhong.AutoSize = true;
            this.lbl_TenPhong.Location = new System.Drawing.Point(26, 22);
            this.lbl_TenPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TenPhong.Name = "lbl_TenPhong";
            this.lbl_TenPhong.Size = new System.Drawing.Size(60, 13);
            this.lbl_TenPhong.TabIndex = 4;
            this.lbl_TenPhong.Text = "Ten Phong";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Định dạng: MM/DD/YYYY";
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.vbButton1.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.vbButton1.BorderColor = System.Drawing.Color.DimGray;
            this.vbButton1.BorderRadius = 5;
            this.vbButton1.BorderSize = 3;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.ForeColor = System.Drawing.Color.White;
            this.vbButton1.Location = new System.Drawing.Point(37, 383);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(110, 57);
            this.vbButton1.TabIndex = 8;
            this.vbButton1.Text = "Thêm tháng mới";
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
            this.vbButton1.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // vbButton2
            // 
            this.vbButton2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.vbButton2.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.vbButton2.BorderColor = System.Drawing.Color.DimGray;
            this.vbButton2.BorderRadius = 5;
            this.vbButton2.BorderSize = 3;
            this.vbButton2.FlatAppearance.BorderSize = 0;
            this.vbButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton2.ForeColor = System.Drawing.Color.White;
            this.vbButton2.Location = new System.Drawing.Point(198, 383);
            this.vbButton2.Name = "vbButton2";
            this.vbButton2.Size = new System.Drawing.Size(110, 57);
            this.vbButton2.TabIndex = 8;
            this.vbButton2.Text = "Sửa tháng mới nhất";
            this.vbButton2.TextColor = System.Drawing.Color.White;
            this.vbButton2.UseVisualStyleBackColor = false;
            this.vbButton2.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // vbButton3
            // 
            this.vbButton3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.vbButton3.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.vbButton3.BorderColor = System.Drawing.Color.DimGray;
            this.vbButton3.BorderRadius = 5;
            this.vbButton3.BorderSize = 3;
            this.vbButton3.FlatAppearance.BorderSize = 0;
            this.vbButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton3.ForeColor = System.Drawing.Color.White;
            this.vbButton3.Location = new System.Drawing.Point(359, 383);
            this.vbButton3.Name = "vbButton3";
            this.vbButton3.Size = new System.Drawing.Size(110, 57);
            this.vbButton3.TabIndex = 8;
            this.vbButton3.Text = "Xóa tháng mới nhất";
            this.vbButton3.TextColor = System.Drawing.Color.White;
            this.vbButton3.UseVisualStyleBackColor = false;
            this.vbButton3.Click += new System.EventHandler(this.btn_Xoa_Click);
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
            this.vbButton4.Location = new System.Drawing.Point(520, 383);
            this.vbButton4.Name = "vbButton4";
            this.vbButton4.Size = new System.Drawing.Size(110, 57);
            this.vbButton4.TabIndex = 8;
            this.vbButton4.Text = "Nạp tiền hoặc bỏ nạp tiền";
            this.vbButton4.TextColor = System.Drawing.Color.White;
            this.vbButton4.UseVisualStyleBackColor = false;
            this.vbButton4.Click += new System.EventHandler(this.btn_nap_Click);
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
            this.vbButton5.Location = new System.Drawing.Point(681, 383);
            this.vbButton5.Name = "vbButton5";
            this.vbButton5.Size = new System.Drawing.Size(110, 57);
            this.vbButton5.TabIndex = 8;
            this.vbButton5.Text = "Xuất hóa đơn tháng chưa nộp";
            this.vbButton5.TextColor = System.Drawing.Color.White;
            this.vbButton5.UseVisualStyleBackColor = false;
            this.vbButton5.Click += new System.EventHandler(this.btn_xuat_Click);
            // 
            // FormAllThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 469);
            this.Controls.Add(this.vbButton5);
            this.Controls.Add(this.vbButton4);
            this.Controls.Add(this.vbButton3);
            this.Controls.Add(this.vbButton2);
            this.Controls.Add(this.vbButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_TenPhong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.dgv_DSThang);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAllThang";
            this.Text = "FormAllThang";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSThang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DSThang;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_CaHai;
        private System.Windows.Forms.RadioButton rdo_DaNop;
        private System.Windows.Forms.RadioButton rdo_ChuaNop;
        private System.Windows.Forms.Label lbl_TenPhong;
        private System.Windows.Forms.Label label1;
        private CustomButton.VBButton vbButton1;
        private CustomButton.VBButton vbButton2;
        private CustomButton.VBButton vbButton3;
        private CustomButton.VBButton vbButton4;
        private CustomButton.VBButton vbButton5;
    }
}