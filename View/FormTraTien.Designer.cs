namespace QuanLyPhongTroLinQ.View
{
    partial class FormTraTien
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
            this.dgv_TraTien = new System.Windows.Forms.DataGridView();
            this.btn_xem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_CaHai = new System.Windows.Forms.RadioButton();
            this.rdo_DaNop = new System.Windows.Forms.RadioButton();
            this.rdo_ChuaNop = new System.Windows.Forms.RadioButton();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TraTien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_TraTien
            // 
            this.dgv_TraTien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TraTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TraTien.Location = new System.Drawing.Point(315, 29);
            this.dgv_TraTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_TraTien.Name = "dgv_TraTien";
            this.dgv_TraTien.RowHeadersWidth = 51;
            this.dgv_TraTien.RowTemplate.Height = 24;
            this.dgv_TraTien.Size = new System.Drawing.Size(381, 284);
            this.dgv_TraTien.TabIndex = 0;
            // 
            // btn_xem
            // 
            this.btn_xem.BackColor = System.Drawing.Color.Black;
            this.btn_xem.ForeColor = System.Drawing.Color.Yellow;
            this.btn_xem.Location = new System.Drawing.Point(453, 358);
            this.btn_xem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(116, 32);
            this.btn_xem.TabIndex = 1;
            this.btn_xem.Text = "Xem chi tiết";
            this.btn_xem.UseVisualStyleBackColor = false;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_CaHai);
            this.groupBox1.Controls.Add(this.rdo_DaNop);
            this.groupBox1.Controls.Add(this.rdo_ChuaNop);
            this.groupBox1.Location = new System.Drawing.Point(52, 145);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(177, 145);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chế độ hiển thị";
            // 
            // rdo_CaHai
            // 
            this.rdo_CaHai.AutoSize = true;
            this.rdo_CaHai.Location = new System.Drawing.Point(38, 106);
            this.rdo_CaHai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.rdo_DaNop.Location = new System.Drawing.Point(38, 68);
            this.rdo_DaNop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdo_DaNop.Name = "rdo_DaNop";
            this.rdo_DaNop.Size = new System.Drawing.Size(113, 17);
            this.rdo_DaNop.TabIndex = 0;
            this.rdo_DaNop.TabStop = true;
            this.rdo_DaNop.Text = "Phòng đã nộp tiền";
            this.rdo_DaNop.UseVisualStyleBackColor = true;
            this.rdo_DaNop.CheckedChanged += new System.EventHandler(this.rdo_DaNop_CheckedChanged);
            // 
            // rdo_ChuaNop
            // 
            this.rdo_ChuaNop.AutoSize = true;
            this.rdo_ChuaNop.Location = new System.Drawing.Point(38, 32);
            this.rdo_ChuaNop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdo_ChuaNop.Name = "rdo_ChuaNop";
            this.rdo_ChuaNop.Size = new System.Drawing.Size(112, 17);
            this.rdo_ChuaNop.TabIndex = 0;
            this.rdo_ChuaNop.TabStop = true;
            this.rdo_ChuaNop.Text = "Phòng còn nợ tiền";
            this.rdo_ChuaNop.UseVisualStyleBackColor = true;
            this.rdo_ChuaNop.CheckedChanged += new System.EventHandler(this.rdo_ChuaNop_CheckedChanged);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(52, 72);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(178, 20);
            this.txt_TimKiem.TabIndex = 3;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Location = new System.Drawing.Point(50, 39);
            this.lbl_TimKiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(124, 13);
            this.lbl_TimKiem.TabIndex = 4;
            this.lbl_TimKiem.Text = "Tìm kiếm theo tên phòng";
            // 
            // FormTraTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(748, 420);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_xem);
            this.Controls.Add(this.dgv_TraTien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTraTien";
            this.Text = "FormTienThang";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TraTien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_TraTien;
        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_CaHai;
        private System.Windows.Forms.RadioButton rdo_DaNop;
        private System.Windows.Forms.RadioButton rdo_ChuaNop;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label lbl_TimKiem;
    }
}