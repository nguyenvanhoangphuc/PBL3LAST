namespace QuanLyPhongTroLinQ.View
{
    partial class FormDatPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel30 = new System.Windows.Forms.Panel();
            this.btn_BoChon = new CustomButton.VBButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.dgvCoTheChon = new System.Windows.Forms.DataGridView();
            this.dgvDaChon = new System.Windows.Forms.DataGridView();
            this.btn_Chon = new CustomButton.VBButton();
            this.btnDatPhong = new CustomButton.VBButton();
            this.btnHuy = new CustomButton.VBButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoTheChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaChon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.SystemColors.Control;
            this.panel30.Controls.Add(this.btnHuy);
            this.panel30.Controls.Add(this.btnDatPhong);
            this.panel30.Controls.Add(this.dgvDaChon);
            this.panel30.Controls.Add(this.dgvCoTheChon);
            this.panel30.Controls.Add(this.dgvPhong);
            this.panel30.Controls.Add(this.btn_Chon);
            this.panel30.Controls.Add(this.btn_BoChon);
            this.panel30.Controls.Add(this.label2);
            this.panel30.Controls.Add(this.cboLoaiPhong);
            this.panel30.Controls.Add(this.txtSDT);
            this.panel30.Controls.Add(this.lblSDT);
            this.panel30.Controls.Add(this.lblHeader);
            this.panel30.Controls.Add(this.panel1);
            this.panel30.Location = new System.Drawing.Point(10, 7);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(776, 496);
            this.panel30.TabIndex = 1;
            // 
            // btn_BoChon
            // 
            this.btn_BoChon.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_BoChon.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_BoChon.BorderColor = System.Drawing.Color.DimGray;
            this.btn_BoChon.BorderRadius = 5;
            this.btn_BoChon.BorderSize = 3;
            this.btn_BoChon.FlatAppearance.BorderSize = 0;
            this.btn_BoChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BoChon.ForeColor = System.Drawing.Color.White;
            this.btn_BoChon.Location = new System.Drawing.Point(504, 312);
            this.btn_BoChon.Name = "btn_BoChon";
            this.btn_BoChon.Size = new System.Drawing.Size(108, 26);
            this.btn_BoChon.TabIndex = 24;
            this.btn_BoChon.Text = "Bỏ chọn";
            this.btn_BoChon.TextColor = System.Drawing.Color.White;
            this.btn_BoChon.UseVisualStyleBackColor = false;
            this.btn_BoChon.Click += new System.EventHandler(this.btnBoChon_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Location = new System.Drawing.Point(56, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "LoaiPhong";
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.FormattingEnabled = true;
            this.cboLoaiPhong.Location = new System.Drawing.Point(156, 79);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(121, 21);
            this.cboLoaiPhong.TabIndex = 19;
            this.cboLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cboLoaiPhong_SelectedIndexChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(156, 202);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(121, 20);
            this.txtSDT.TabIndex = 18;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblSDT.Location = new System.Drawing.Point(56, 205);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(29, 13);
            this.lblSDT.TabIndex = 17;
            this.lblSDT.Text = "SDT";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeader.Location = new System.Drawing.Point(308, 26);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(160, 40);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "Đặt phòng";
            // 
            // dgvPhong
            // 
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvPhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvPhong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhong.DefaultCellStyle = dataGridViewCellStyle27;
            this.dgvPhong.EnableHeadersVisualStyles = false;
            this.dgvPhong.Location = new System.Drawing.Point(59, 105);
            this.dgvPhong.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.RowTemplate.Height = 24;
            this.dgvPhong.Size = new System.Drawing.Size(646, 77);
            this.dgvPhong.TabIndex = 25;
            // 
            // dgvCoTheChon
            // 
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvCoTheChon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvCoTheChon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCoTheChon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCoTheChon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCoTheChon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCoTheChon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvCoTheChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCoTheChon.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvCoTheChon.EnableHeadersVisualStyles = false;
            this.dgvCoTheChon.Location = new System.Drawing.Point(59, 230);
            this.dgvCoTheChon.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCoTheChon.Name = "dgvCoTheChon";
            this.dgvCoTheChon.RowHeadersWidth = 51;
            this.dgvCoTheChon.RowTemplate.Height = 24;
            this.dgvCoTheChon.Size = new System.Drawing.Size(319, 77);
            this.dgvCoTheChon.TabIndex = 26;
            // 
            // dgvDaChon
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvDaChon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvDaChon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDaChon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDaChon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDaChon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDaChon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDaChon.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgvDaChon.EnableHeadersVisualStyles = false;
            this.dgvDaChon.Location = new System.Drawing.Point(384, 230);
            this.dgvDaChon.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDaChon.Name = "dgvDaChon";
            this.dgvDaChon.RowHeadersWidth = 51;
            this.dgvDaChon.RowTemplate.Height = 24;
            this.dgvDaChon.Size = new System.Drawing.Size(319, 77);
            this.dgvDaChon.TabIndex = 27;
            // 
            // btn_Chon
            // 
            this.btn_Chon.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Chon.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Chon.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Chon.BorderRadius = 5;
            this.btn_Chon.BorderSize = 3;
            this.btn_Chon.FlatAppearance.BorderSize = 0;
            this.btn_Chon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Chon.ForeColor = System.Drawing.Color.White;
            this.btn_Chon.Location = new System.Drawing.Point(169, 312);
            this.btn_Chon.Name = "btn_Chon";
            this.btn_Chon.Size = new System.Drawing.Size(108, 26);
            this.btn_Chon.TabIndex = 24;
            this.btn_Chon.Text = "Chọn";
            this.btn_Chon.TextColor = System.Drawing.Color.White;
            this.btn_Chon.UseVisualStyleBackColor = false;
            this.btn_Chon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDatPhong.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDatPhong.BorderColor = System.Drawing.Color.DimGray;
            this.btnDatPhong.BorderRadius = 5;
            this.btnDatPhong.BorderSize = 3;
            this.btnDatPhong.FlatAppearance.BorderSize = 0;
            this.btnDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatPhong.ForeColor = System.Drawing.Color.White;
            this.btnDatPhong.Location = new System.Drawing.Point(445, 394);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(258, 53);
            this.btnDatPhong.TabIndex = 28;
            this.btnDatPhong.Text = "Hủy";
            this.btnDatPhong.TextColor = System.Drawing.Color.White;
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnHuy.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnHuy.BorderColor = System.Drawing.Color.DimGray;
            this.btnHuy.BorderRadius = 5;
            this.btnHuy.BorderSize = 3;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(74, 394);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(258, 53);
            this.btnHuy.TabIndex = 30;
            this.btnHuy.Text = "Đặt phòng";
            this.btnHuy.TextColor = System.Drawing.Color.White;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Location = new System.Drawing.Point(35, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 288);
            this.panel1.TabIndex = 31;
            // 
            // FormDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 514);
            this.Controls.Add(this.panel30);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 70);
            this.Name = "FormDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormLoaiPhong";
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoTheChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaChon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private CustomButton.VBButton btn_BoChon;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridView dgvDaChon;
        private System.Windows.Forms.DataGridView dgvCoTheChon;
        private CustomButton.VBButton btn_Chon;
        private CustomButton.VBButton btnHuy;
        private CustomButton.VBButton btnDatPhong;
        private System.Windows.Forms.Panel panel1;
    }
}