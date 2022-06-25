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
            this.dgv_DSThang = new System.Windows.Forms.DataGridView();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_CaHai = new System.Windows.Forms.RadioButton();
            this.rdo_DaNop = new System.Windows.Forms.RadioButton();
            this.rdo_ChuaNop = new System.Windows.Forms.RadioButton();
            this.lbl_TenPhong = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_nap = new System.Windows.Forms.Button();
            this.btn_xuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSThang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DSThang
            // 
            this.dgv_DSThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSThang.Location = new System.Drawing.Point(37, 153);
            this.dgv_DSThang.Name = "dgv_DSThang";
            this.dgv_DSThang.RowHeadersWidth = 51;
            this.dgv_DSThang.RowTemplate.Height = 24;
            this.dgv_DSThang.Size = new System.Drawing.Size(1028, 284);
            this.dgv_DSThang.TabIndex = 0;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(217, 73);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(208, 30);
            this.txt_TimKiem.TabIndex = 1;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimKiem.Location = new System.Drawing.Point(34, 76);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(177, 23);
            this.lbl_TimKiem.TabIndex = 2;
            this.lbl_TimKiem.Text = "Tìm kiếm theo ngày";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_CaHai);
            this.groupBox1.Controls.Add(this.rdo_DaNop);
            this.groupBox1.Controls.Add(this.rdo_ChuaNop);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(575, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 71);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chế độ hiển thị";
            // 
            // rdo_CaHai
            // 
            this.rdo_CaHai.AutoSize = true;
            this.rdo_CaHai.Location = new System.Drawing.Point(387, 31);
            this.rdo_CaHai.Name = "rdo_CaHai";
            this.rdo_CaHai.Size = new System.Drawing.Size(85, 27);
            this.rdo_CaHai.TabIndex = 0;
            this.rdo_CaHai.TabStop = true;
            this.rdo_CaHai.Text = "Cả hai";
            this.rdo_CaHai.UseVisualStyleBackColor = true;
            this.rdo_CaHai.CheckedChanged += new System.EventHandler(this.rdo_CaHai_CheckedChanged);
            // 
            // rdo_DaNop
            // 
            this.rdo_DaNop.AutoSize = true;
            this.rdo_DaNop.Location = new System.Drawing.Point(217, 31);
            this.rdo_DaNop.Name = "rdo_DaNop";
            this.rdo_DaNop.Size = new System.Drawing.Size(144, 27);
            this.rdo_DaNop.TabIndex = 0;
            this.rdo_DaNop.TabStop = true;
            this.rdo_DaNop.Text = "Tháng đã nộp";
            this.rdo_DaNop.UseVisualStyleBackColor = true;
            this.rdo_DaNop.CheckedChanged += new System.EventHandler(this.rdo_DaNop_CheckedChanged);
            // 
            // rdo_ChuaNop
            // 
            this.rdo_ChuaNop.AutoSize = true;
            this.rdo_ChuaNop.Location = new System.Drawing.Point(28, 31);
            this.rdo_ChuaNop.Name = "rdo_ChuaNop";
            this.rdo_ChuaNop.Size = new System.Drawing.Size(165, 27);
            this.rdo_ChuaNop.TabIndex = 0;
            this.rdo_ChuaNop.TabStop = true;
            this.rdo_ChuaNop.Text = "Tháng chưa nộp";
            this.rdo_ChuaNop.UseVisualStyleBackColor = true;
            this.rdo_ChuaNop.CheckedChanged += new System.EventHandler(this.rdo_ChuaNop_CheckedChanged);
            // 
            // lbl_TenPhong
            // 
            this.lbl_TenPhong.AutoSize = true;
            this.lbl_TenPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenPhong.Location = new System.Drawing.Point(34, 27);
            this.lbl_TenPhong.Name = "lbl_TenPhong";
            this.lbl_TenPhong.Size = new System.Drawing.Size(98, 23);
            this.lbl_TenPhong.TabIndex = 4;
            this.lbl_TenPhong.Text = "Ten Phong";
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(38, 483);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(143, 55);
            this.btn_Them.TabIndex = 5;
            this.btn_Them.Text = "Thêm tháng mới";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(243, 483);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(159, 55);
            this.btn_Sua.TabIndex = 5;
            this.btn_Sua.Text = "Sửa tháng mới nhất";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(465, 483);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(156, 55);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.Text = "Xóa tháng mới nhất";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Định dạng: MM/DD/YYYY";
            // 
            // btn_nap
            // 
            this.btn_nap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nap.Location = new System.Drawing.Point(683, 483);
            this.btn_nap.Name = "btn_nap";
            this.btn_nap.Size = new System.Drawing.Size(162, 55);
            this.btn_nap.TabIndex = 7;
            this.btn_nap.Text = "Nạp tiền hoặc bỏ nạp tiền";
            this.btn_nap.UseVisualStyleBackColor = true;
            this.btn_nap.Click += new System.EventHandler(this.btn_nap_Click);
            // 
            // btn_xuat
            // 
            this.btn_xuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuat.Location = new System.Drawing.Point(901, 483);
            this.btn_xuat.Name = "btn_xuat";
            this.btn_xuat.Size = new System.Drawing.Size(164, 55);
            this.btn_xuat.TabIndex = 7;
            this.btn_xuat.Text = "Xuất hóa đơn tháng chưa nộp";
            this.btn_xuat.UseVisualStyleBackColor = true;
            this.btn_xuat.Click += new System.EventHandler(this.btn_xuat_Click);
            // 
            // FormAllThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 577);
            this.Controls.Add(this.btn_xuat);
            this.Controls.Add(this.btn_nap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.lbl_TenPhong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.dgv_DSThang);
            this.Name = "FormAllThang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_nap;
        private System.Windows.Forms.Button btn_xuat;
    }
}