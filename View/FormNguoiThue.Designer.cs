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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_DT = new System.Windows.Forms.RadioButton();
            this.rdo_CCCD = new System.Windows.Forms.RadioButton();
            this.rdo_QQ = new System.Windows.Forms.RadioButton();
            this.rdo_SDT = new System.Windows.Forms.RadioButton();
            this.rdo_HVT = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dGV_NguoiThue = new System.Windows.Forms.DataGridView();
            this.btn_Them = new CustomButton.VBButton();
            this.btn_Sua = new CustomButton.VBButton();
            this.btn_Xoa = new CustomButton.VBButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_NguoiThue)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(156, 11);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(289, 20);
            this.txt_TimKiem.TabIndex = 2;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_DT);
            this.groupBox1.Controls.Add(this.rdo_CCCD);
            this.groupBox1.Controls.Add(this.rdo_QQ);
            this.groupBox1.Controls.Add(this.rdo_SDT);
            this.groupBox1.Controls.Add(this.rdo_HVT);
            this.groupBox1.Location = new System.Drawing.Point(2, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(460, 40);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm người thuê theo";
            // 
            // rdo_DT
            // 
            this.rdo_DT.AutoSize = true;
            this.rdo_DT.Location = new System.Drawing.Point(379, 14);
            this.rdo_DT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdo_DT.Name = "rdo_DT";
            this.rdo_DT.Size = new System.Drawing.Size(63, 17);
            this.rdo_DT.TabIndex = 0;
            this.rdo_DT.TabStop = true;
            this.rdo_DT.Text = "Đã thuê";
            this.rdo_DT.UseVisualStyleBackColor = true;
            // 
            // rdo_CCCD
            // 
            this.rdo_CCCD.AutoSize = true;
            this.rdo_CCCD.Location = new System.Drawing.Point(256, 14);
            this.rdo_CCCD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdo_CCCD.Name = "rdo_CCCD";
            this.rdo_CCCD.Size = new System.Drawing.Size(119, 17);
            this.rdo_CCCD.TabIndex = 0;
            this.rdo_CCCD.TabStop = true;
            this.rdo_CCCD.Text = "Căn cước công dân";
            this.rdo_CCCD.UseVisualStyleBackColor = true;
            // 
            // rdo_QQ
            // 
            this.rdo_QQ.AutoSize = true;
            this.rdo_QQ.Location = new System.Drawing.Point(180, 14);
            this.rdo_QQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdo_QQ.Name = "rdo_QQ";
            this.rdo_QQ.Size = new System.Drawing.Size(72, 17);
            this.rdo_QQ.TabIndex = 0;
            this.rdo_QQ.TabStop = true;
            this.rdo_QQ.Text = "Quê quán";
            this.rdo_QQ.UseVisualStyleBackColor = true;
            // 
            // rdo_SDT
            // 
            this.rdo_SDT.AutoSize = true;
            this.rdo_SDT.Location = new System.Drawing.Point(88, 14);
            this.rdo_SDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdo_SDT.Name = "rdo_SDT";
            this.rdo_SDT.Size = new System.Drawing.Size(88, 17);
            this.rdo_SDT.TabIndex = 0;
            this.rdo_SDT.TabStop = true;
            this.rdo_SDT.Text = "Số điện thoại";
            this.rdo_SDT.UseVisualStyleBackColor = true;
            // 
            // rdo_HVT
            // 
            this.rdo_HVT.AutoSize = true;
            this.rdo_HVT.Location = new System.Drawing.Point(22, 14);
            this.rdo_HVT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdo_HVT.Name = "rdo_HVT";
            this.rdo_HVT.Size = new System.Drawing.Size(72, 17);
            this.rdo_HVT.TabIndex = 0;
            this.rdo_HVT.TabStop = true;
            this.rdo_HVT.Text = "Họ và tên";
            this.rdo_HVT.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btn_Xoa);
            this.panel4.Controls.Add(this.btn_Sua);
            this.panel4.Controls.Add(this.btn_Them);
            this.panel4.Controls.Add(this.dGV_NguoiThue);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(9, 9);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 496);
            this.panel4.TabIndex = 11;
            // 
            // dGV_NguoiThue
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dGV_NguoiThue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_NguoiThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_NguoiThue.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dGV_NguoiThue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV_NguoiThue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGV_NguoiThue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_NguoiThue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_NguoiThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_NguoiThue.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_NguoiThue.EnableHeadersVisualStyles = false;
            this.dGV_NguoiThue.Location = new System.Drawing.Point(35, 91);
            this.dGV_NguoiThue.Margin = new System.Windows.Forms.Padding(2);
            this.dGV_NguoiThue.Name = "dGV_NguoiThue";
            this.dGV_NguoiThue.RowHeadersWidth = 51;
            this.dGV_NguoiThue.RowTemplate.Height = 24;
            this.dGV_NguoiThue.Size = new System.Drawing.Size(713, 264);
            this.dGV_NguoiThue.TabIndex = 27;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Them.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Them.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Them.BorderRadius = 5;
            this.btn_Them.BorderSize = 3;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(18, 382);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(85, 55);
            this.btn_Them.TabIndex = 28;
            this.btn_Them.Text = "Thêm người thuê mới";
            this.btn_Them.TextColor = System.Drawing.Color.White;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Sua.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Sua.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Sua.BorderRadius = 5;
            this.btn_Sua.BorderSize = 3;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(104, 381);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(85, 55);
            this.btn_Sua.TabIndex = 29;
            this.btn_Sua.Text = "Chỉnh sửa thông tin";
            this.btn_Sua.TextColor = System.Drawing.Color.White;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Xoa.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Xoa.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Xoa.BorderRadius = 5;
            this.btn_Xoa.BorderSize = 3;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(190, 382);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(85, 55);
            this.btn_Xoa.TabIndex = 30;
            this.btn_Xoa.Text = "Xóa người thuê";
            this.btn_Xoa.TextColor = System.Drawing.Color.White;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 40);
            this.label1.TabIndex = 31;
            this.label1.Text = "Danh sách người thuê";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txt_TimKiem);
            this.panel1.Location = new System.Drawing.Point(281, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 80);
            this.panel1.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nhập thông tin cần tìm kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Bảng danh sách người thuê";
            // 
            // FormNguoiThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 514);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 70);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormNguoiThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormNguoiThue";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_NguoiThue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_DT;
        private System.Windows.Forms.RadioButton rdo_CCCD;
        private System.Windows.Forms.RadioButton rdo_QQ;
        private System.Windows.Forms.RadioButton rdo_SDT;
        private System.Windows.Forms.RadioButton rdo_HVT;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dGV_NguoiThue;
        private CustomButton.VBButton btn_Xoa;
        private CustomButton.VBButton btn_Sua;
        private CustomButton.VBButton btn_Them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}