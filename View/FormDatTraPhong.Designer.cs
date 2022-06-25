namespace QuanLyPhongTroLinQ.View
{
    partial class FormDatTraPhong
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
            this.btnTraPhong = new CustomButton.VBButton();
            this.btnDatPhong = new CustomButton.VBButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.Color.White;
            this.panel30.Controls.Add(this.btnTraPhong);
            this.panel30.Controls.Add(this.btnDatPhong);
            this.panel30.Controls.Add(this.dgv);
            this.panel30.Controls.Add(this.txtSDT);
            this.panel30.Controls.Add(this.lblSDT);
            this.panel30.Controls.Add(this.lblHeader);
            this.panel30.Location = new System.Drawing.Point(10, 7);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(776, 496);
            this.panel30.TabIndex = 1;
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
            this.btnTraPhong.Location = new System.Drawing.Point(428, 427);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(267, 41);
            this.btnTraPhong.TabIndex = 35;
            this.btnTraPhong.Text = "Trả Phòng";
            this.btnTraPhong.TextColor = System.Drawing.Color.White;
            this.btnTraPhong.UseVisualStyleBackColor = false;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
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
            this.btnDatPhong.Location = new System.Drawing.Point(83, 426);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(267, 41);
            this.btnDatPhong.TabIndex = 35;
            this.btnDatPhong.Text = "Đặt Phòng";
            this.btnDatPhong.TextColor = System.Drawing.Color.White;
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // dgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Location = new System.Drawing.Point(50, 166);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(681, 207);
            this.dgv.TabIndex = 34;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(129, 127);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(150, 20);
            this.txtSDT.TabIndex = 17;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(80, 129);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(29, 13);
            this.lblSDT.TabIndex = 16;
            this.lblSDT.Text = "SDT";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeader.Location = new System.Drawing.Point(269, 26);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(238, 40);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "Đặt - Trả Phòng";
            // 
            // FormDatTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 514);
            this.Controls.Add(this.panel30);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 70);
            this.Name = "FormDatTraPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormLoaiPhong";
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.DataGridView dgv;
        private CustomButton.VBButton btnTraPhong;
        private CustomButton.VBButton btnDatPhong;
    }
}