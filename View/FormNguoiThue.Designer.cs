namespace QuanLyPhongTroLinQ.View
{
    partial class FormNguoiThue
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.dGV_NguoiThue = new System.Windows.Forms.DataGridView();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_DT = new System.Windows.Forms.RadioButton();
            this.rdo_CCCD = new System.Windows.Forms.RadioButton();
            this.rdo_QQ = new System.Windows.Forms.RadioButton();
            this.rdo_SDT = new System.Windows.Forms.RadioButton();
            this.rdo_HVT = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_NguoiThue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(107, 445);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(153, 58);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm người thuê mới";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(404, 445);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(215, 58);
            this.btn_Sua.TabIndex = 0;
            this.btn_Sua.Text = "Chỉnh sửa thông tin người thuê";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(724, 445);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(218, 58);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "Xóa một hoặc nhiều người thuê";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // dGV_NguoiThue
            // 
            this.dGV_NguoiThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_NguoiThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_NguoiThue.Location = new System.Drawing.Point(107, 164);
            this.dGV_NguoiThue.Name = "dGV_NguoiThue";
            this.dGV_NguoiThue.RowHeadersWidth = 51;
            this.dGV_NguoiThue.RowTemplate.Height = 24;
            this.dGV_NguoiThue.Size = new System.Drawing.Size(834, 208);
            this.dGV_NguoiThue.TabIndex = 1;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(368, 101);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(292, 22);
            this.txt_TimKiem.TabIndex = 2;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Location = new System.Drawing.Point(105, 39);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(155, 16);
            this.lbl_TimKiem.TabIndex = 3;
            this.lbl_TimKiem.Text = "Tìm kiếm người thuê theo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_DT);
            this.groupBox1.Controls.Add(this.rdo_CCCD);
            this.groupBox1.Controls.Add(this.rdo_QQ);
            this.groupBox1.Controls.Add(this.rdo_SDT);
            this.groupBox1.Controls.Add(this.rdo_HVT);
            this.groupBox1.Location = new System.Drawing.Point(283, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 49);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // rdo_DT
            // 
            this.rdo_DT.AutoSize = true;
            this.rdo_DT.Location = new System.Drawing.Point(580, 17);
            this.rdo_DT.Name = "rdo_DT";
            this.rdo_DT.Size = new System.Drawing.Size(73, 20);
            this.rdo_DT.TabIndex = 0;
            this.rdo_DT.TabStop = true;
            this.rdo_DT.Text = "Đã thuê";
            this.rdo_DT.UseVisualStyleBackColor = true;
            // 
            // rdo_CCCD
            // 
            this.rdo_CCCD.AutoSize = true;
            this.rdo_CCCD.Location = new System.Drawing.Point(402, 17);
            this.rdo_CCCD.Name = "rdo_CCCD";
            this.rdo_CCCD.Size = new System.Drawing.Size(143, 20);
            this.rdo_CCCD.TabIndex = 0;
            this.rdo_CCCD.TabStop = true;
            this.rdo_CCCD.Text = "Căn cước công dân";
            this.rdo_CCCD.UseVisualStyleBackColor = true;
            // 
            // rdo_QQ
            // 
            this.rdo_QQ.AutoSize = true;
            this.rdo_QQ.Location = new System.Drawing.Point(279, 17);
            this.rdo_QQ.Name = "rdo_QQ";
            this.rdo_QQ.Size = new System.Drawing.Size(86, 20);
            this.rdo_QQ.TabIndex = 0;
            this.rdo_QQ.TabStop = true;
            this.rdo_QQ.Text = "Quê quán";
            this.rdo_QQ.UseVisualStyleBackColor = true;
            // 
            // rdo_SDT
            // 
            this.rdo_SDT.AutoSize = true;
            this.rdo_SDT.Location = new System.Drawing.Point(142, 17);
            this.rdo_SDT.Name = "rdo_SDT";
            this.rdo_SDT.Size = new System.Drawing.Size(106, 20);
            this.rdo_SDT.TabIndex = 0;
            this.rdo_SDT.TabStop = true;
            this.rdo_SDT.Text = "Số điện thoại";
            this.rdo_SDT.UseVisualStyleBackColor = true;
            // 
            // rdo_HVT
            // 
            this.rdo_HVT.AutoSize = true;
            this.rdo_HVT.Location = new System.Drawing.Point(29, 17);
            this.rdo_HVT.Name = "rdo_HVT";
            this.rdo_HVT.Size = new System.Drawing.Size(85, 20);
            this.rdo_HVT.TabIndex = 0;
            this.rdo_HVT.TabStop = true;
            this.rdo_HVT.Text = "Họ và tên";
            this.rdo_HVT.UseVisualStyleBackColor = true;
            // 
            // FormNguoiThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 564);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.dGV_NguoiThue);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNguoiThue";
            this.Text = "FormNguoiThue";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_NguoiThue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView dGV_NguoiThue;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_DT;
        private System.Windows.Forms.RadioButton rdo_CCCD;
        private System.Windows.Forms.RadioButton rdo_QQ;
        private System.Windows.Forms.RadioButton rdo_SDT;
        private System.Windows.Forms.RadioButton rdo_HVT;
    }
}