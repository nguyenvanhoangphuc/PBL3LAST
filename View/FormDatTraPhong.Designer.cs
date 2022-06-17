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
            this.panel30 = new System.Windows.Forms.Panel();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.panel30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.Color.White;
            this.panel30.Controls.Add(this.txtSDT);
            this.panel30.Controls.Add(this.lblSDT);
            this.panel30.Controls.Add(this.lblHeader);
            this.panel30.Controls.Add(this.dgv);
            this.panel30.Controls.Add(this.btnDatPhong);
            this.panel30.Controls.Add(this.btnTraPhong);
            this.panel30.Location = new System.Drawing.Point(13, 9);
            this.panel30.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(1035, 610);
            this.panel30.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(172, 156);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(199, 22);
            this.txtSDT.TabIndex = 17;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(107, 159);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(35, 16);
            this.lblSDT.TabIndex = 16;
            this.lblSDT.Text = "SDT";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeader.Location = new System.Drawing.Point(359, 32);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(292, 49);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "Đặt - Trả Phòng";
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Location = new System.Drawing.Point(105, 243);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(821, 167);
            this.dgv.TabIndex = 15;
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDatPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.ForeColor = System.Drawing.Color.Yellow;
            this.btnDatPhong.Location = new System.Drawing.Point(105, 466);
            this.btnDatPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(344, 50);
            this.btnDatPhong.TabIndex = 14;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTraPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraPhong.ForeColor = System.Drawing.Color.Yellow;
            this.btnTraPhong.Location = new System.Drawing.Point(583, 466);
            this.btnTraPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(344, 50);
            this.btnTraPhong.TabIndex = 13;
            this.btnTraPhong.Text = "Trả Phòng";
            this.btnTraPhong.UseVisualStyleBackColor = false;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // FormDatTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 633);
            this.Controls.Add(this.panel30);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 70);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
    }
}