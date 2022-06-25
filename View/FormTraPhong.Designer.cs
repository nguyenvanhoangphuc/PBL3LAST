namespace QuanLyPhongTroLinQ.View
{
    partial class FormTraPhong
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
            this.lblNote = new System.Windows.Forms.Label();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lblTraPhong = new System.Windows.Forms.Label();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.btnTraPhong = new CustomButton.VBButton();
            this.btnHuy = new CustomButton.VBButton();
            this.panel30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.SystemColors.Control;
            this.panel30.Controls.Add(this.btnHuy);
            this.panel30.Controls.Add(this.btnTraPhong);
            this.panel30.Controls.Add(this.dgvPhong);
            this.panel30.Controls.Add(this.lblNote);
            this.panel30.Controls.Add(this.lblLoaiPhong);
            this.panel30.Controls.Add(this.cboLoaiPhong);
            this.panel30.Controls.Add(this.lblTraPhong);
            this.panel30.Location = new System.Drawing.Point(10, 7);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(776, 496);
            this.panel30.TabIndex = 1;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNote.ForeColor = System.Drawing.Color.Maroon;
            this.lblNote.Location = new System.Drawing.Point(35, 457);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(344, 32);
            this.lblNote.TabIndex = 21;
            this.lblNote.Text = "Ghi chú : nếu muốn xem thông tin phòng\r\ncó thể nhấn double click chuột trái vào t" +
    "ên phòng";
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblLoaiPhong.ForeColor = System.Drawing.Color.Maroon;
            this.lblLoaiPhong.Location = new System.Drawing.Point(95, 83);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(85, 16);
            this.lblLoaiPhong.TabIndex = 18;
            this.lblLoaiPhong.Text = "Loại phòng";
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.FormattingEnabled = true;
            this.cboLoaiPhong.Location = new System.Drawing.Point(183, 80);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(121, 21);
            this.cboLoaiPhong.TabIndex = 17;
            this.cboLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cboLoaiPhong_SelectedIndexChanged);
            // 
            // lblTraPhong
            // 
            this.lblTraPhong.AutoSize = true;
            this.lblTraPhong.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTraPhong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTraPhong.Location = new System.Drawing.Point(311, 22);
            this.lblTraPhong.Name = "lblTraPhong";
            this.lblTraPhong.Size = new System.Drawing.Size(155, 40);
            this.lblTraPhong.TabIndex = 8;
            this.lblTraPhong.Text = "Trả phòng";
            // 
            // dgvPhong
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvPhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhong.EnableHeadersVisualStyles = false;
            this.dgvPhong.Location = new System.Drawing.Point(76, 106);
            this.dgvPhong.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.RowTemplate.Height = 24;
            this.dgvPhong.Size = new System.Drawing.Size(618, 258);
            this.dgvPhong.TabIndex = 30;
            this.dgvPhong.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPhong_RowHeaderMouseDoubleClick);
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
            this.btnTraPhong.Location = new System.Drawing.Point(153, 383);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(128, 43);
            this.btnTraPhong.TabIndex = 34;
            this.btnTraPhong.Text = "Trả phòng";
            this.btnTraPhong.TextColor = System.Drawing.Color.White;
            this.btnTraPhong.UseVisualStyleBackColor = false;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
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
            this.btnHuy.Location = new System.Drawing.Point(504, 383);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(128, 43);
            this.btnHuy.TabIndex = 35;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextColor = System.Drawing.Color.White;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FormTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 514);
            this.Controls.Add(this.panel30);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(490, 170);
            this.Name = "FormTraPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormLoaiPhong";
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Label lblTraPhong;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.DataGridView dgvPhong;
        private CustomButton.VBButton btnHuy;
        private CustomButton.VBButton btnTraPhong;
    }
}