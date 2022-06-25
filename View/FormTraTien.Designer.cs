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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_CaHai = new System.Windows.Forms.RadioButton();
            this.rdo_DaNop = new System.Windows.Forms.RadioButton();
            this.rdo_ChuaNop = new System.Windows.Forms.RadioButton();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_TraTien = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btn_xem = new CustomButton.VBButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TraTien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_CaHai);
            this.groupBox1.Controls.Add(this.rdo_DaNop);
            this.groupBox1.Controls.Add(this.rdo_ChuaNop);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(61, 197);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(213, 138);
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
            this.rdo_CaHai.Size = new System.Drawing.Size(70, 23);
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
            this.rdo_DaNop.Size = new System.Drawing.Size(145, 23);
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
            this.rdo_ChuaNop.Size = new System.Drawing.Size(145, 23);
            this.rdo_ChuaNop.TabIndex = 0;
            this.rdo_ChuaNop.TabStop = true;
            this.rdo_ChuaNop.Text = "Phòng còn nợ tiền";
            this.rdo_ChuaNop.UseVisualStyleBackColor = true;
            this.rdo_ChuaNop.CheckedChanged += new System.EventHandler(this.rdo_ChuaNop_CheckedChanged);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(5, 54);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(178, 26);
            this.txt_TimKiem.TabIndex = 3;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimKiem.Location = new System.Drawing.Point(9, 20);
            this.lbl_TimKiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(174, 19);
            this.lbl_TimKiem.TabIndex = 4;
            this.lbl_TimKiem.Text = "Tìm kiếm theo tên phòng";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.btn_xem);
            this.panel4.Controls.Add(this.dgv_TraTien);
            this.panel4.Controls.Add(this.lblHeader);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(9, 9);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 496);
            this.panel4.TabIndex = 11;
            this.panel4.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // dgv_TraTien
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgv_TraTien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_TraTien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TraTien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_TraTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_TraTien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TraTien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TraTien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_TraTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TraTien.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_TraTien.EnableHeadersVisualStyles = false;
            this.dgv_TraTien.Location = new System.Drawing.Point(289, 76);
            this.dgv_TraTien.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_TraTien.Name = "dgv_TraTien";
            this.dgv_TraTien.RowHeadersWidth = 51;
            this.dgv_TraTien.RowTemplate.Height = 24;
            this.dgv_TraTien.Size = new System.Drawing.Size(430, 304);
            this.dgv_TraTien.TabIndex = 28;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(285, 23);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(195, 32);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Trả tiền phòng";
            // 
            // btn_xem
            // 
            this.btn_xem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_xem.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_xem.BorderColor = System.Drawing.Color.DimGray;
            this.btn_xem.BorderRadius = 5;
            this.btn_xem.BorderSize = 3;
            this.btn_xem.FlatAppearance.BorderSize = 0;
            this.btn_xem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xem.ForeColor = System.Drawing.Color.White;
            this.btn_xem.Location = new System.Drawing.Point(438, 395);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(112, 43);
            this.btn_xem.TabIndex = 33;
            this.btn_xem.Text = "Xem chi tiết";
            this.btn_xem.TextColor = System.Drawing.Color.White;
            this.btn_xem.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.txt_TimKiem);
            this.panel1.Controls.Add(this.lbl_TimKiem);
            this.panel1.Location = new System.Drawing.Point(61, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 100);
            this.panel1.TabIndex = 34;
            // 
            // FormTraTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(794, 514);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 70);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTraTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormTienThang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TraTien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_CaHai;
        private System.Windows.Forms.RadioButton rdo_DaNop;
        private System.Windows.Forms.RadioButton rdo_ChuaNop;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_TraTien;
        private System.Windows.Forms.Label lblHeader;
        private CustomButton.VBButton btn_xem;
        private System.Windows.Forms.Panel panel1;
    }
}