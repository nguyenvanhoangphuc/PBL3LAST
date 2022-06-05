namespace QuanLyPhongTroLinQ.View
{
    partial class FormLoaiPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel30 = new System.Windows.Forms.Panel();
            this.lblLoaiPhong1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnXemThietBi = new System.Windows.Forms.Button();
            this.panel30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel30.Controls.Add(this.lblLoaiPhong1);
            this.panel30.Controls.Add(this.dgv);
            this.panel30.Controls.Add(this.btnHienThi);
            this.panel30.Controls.Add(this.btnXemThietBi);
            this.panel30.Location = new System.Drawing.Point(13, 9);
            this.panel30.Margin = new System.Windows.Forms.Padding(4);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(1034, 611);
            this.panel30.TabIndex = 1;
            // 
            // lblLoaiPhong1
            // 
            this.lblLoaiPhong1.AutoSize = true;
            this.lblLoaiPhong1.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblLoaiPhong1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLoaiPhong1.Location = new System.Drawing.Point(430, 32);
            this.lblLoaiPhong1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoaiPhong1.Name = "lblLoaiPhong1";
            this.lblLoaiPhong1.Size = new System.Drawing.Size(210, 49);
            this.lblLoaiPhong1.TabIndex = 8;
            this.lblLoaiPhong1.Text = "Loại phòng";
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Location = new System.Drawing.Point(75, 235);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(887, 330);
            this.dgv.TabIndex = 15;
            // 
            // btnHienThi
            // 
            this.btnHienThi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHienThi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.ForeColor = System.Drawing.Color.Yellow;
            this.btnHienThi.Location = new System.Drawing.Point(171, 147);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(4);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(240, 51);
            this.btnHienThi.TabIndex = 14;
            this.btnHienThi.Text = "Hiển thị các loại phòng";
            this.btnHienThi.UseVisualStyleBackColor = false;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnXemThietBi
            // 
            this.btnXemThietBi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXemThietBi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemThietBi.ForeColor = System.Drawing.Color.Yellow;
            this.btnXemThietBi.Location = new System.Drawing.Point(537, 147);
            this.btnXemThietBi.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemThietBi.Name = "btnXemThietBi";
            this.btnXemThietBi.Size = new System.Drawing.Size(344, 51);
            this.btnXemThietBi.TabIndex = 13;
            this.btnXemThietBi.Text = "Xem danh sách thiết bị trong phòng";
            this.btnXemThietBi.UseVisualStyleBackColor = false;
            this.btnXemThietBi.Click += new System.EventHandler(this.btnXemThietBi_Click);
            // 
            // FormLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 633);
            this.Controls.Add(this.panel30);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 70);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLoaiPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormLoaiPhong";
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Button btnXemThietBi;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblLoaiPhong1;
    }
}