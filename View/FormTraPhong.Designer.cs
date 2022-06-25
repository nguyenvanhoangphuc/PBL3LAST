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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel30 = new System.Windows.Forms.Panel();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lblTraPhong = new System.Windows.Forms.Label();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.panel30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel30.Controls.Add(this.lblNote);
            this.panel30.Controls.Add(this.lblLoaiPhong);
            this.panel30.Controls.Add(this.cboLoaiPhong);
            this.panel30.Controls.Add(this.lblTraPhong);
            this.panel30.Controls.Add(this.dgvPhong);
            this.panel30.Controls.Add(this.btnHuy);
            this.panel30.Controls.Add(this.btnTraPhong);
            this.panel30.Location = new System.Drawing.Point(13, 9);
            this.panel30.Margin = new System.Windows.Forms.Padding(4);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(1035, 610);
            this.panel30.TabIndex = 1;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNote.ForeColor = System.Drawing.Color.Maroon;
            this.lblNote.Location = new System.Drawing.Point(47, 562);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(422, 40);
            this.lblNote.TabIndex = 21;
            this.lblNote.Text = "Ghi chú : nếu muốn xem thông tin phòng\r\ncó thể nhấn double click chuột trái vào t" +
    "ên phòng";
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblLoaiPhong.ForeColor = System.Drawing.Color.Maroon;
            this.lblLoaiPhong.Location = new System.Drawing.Point(127, 102);
            this.lblLoaiPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(101, 20);
            this.lblLoaiPhong.TabIndex = 18;
            this.lblLoaiPhong.Text = "Loại phòng";
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.FormattingEnabled = true;
            this.cboLoaiPhong.Location = new System.Drawing.Point(244, 98);
            this.cboLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(160, 24);
            this.cboLoaiPhong.TabIndex = 17;
            this.cboLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cboLoaiPhong_SelectedIndexChanged);
            // 
            // lblTraPhong
            // 
            this.lblTraPhong.AutoSize = true;
            this.lblTraPhong.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTraPhong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTraPhong.Location = new System.Drawing.Point(415, 27);
            this.lblTraPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTraPhong.Name = "lblTraPhong";
            this.lblTraPhong.Size = new System.Drawing.Size(192, 49);
            this.lblTraPhong.TabIndex = 8;
            this.lblTraPhong.Text = "Trả phòng";
            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhong.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPhong.Location = new System.Drawing.Point(108, 165);
            this.dgvPhong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPhong.MultiSelect = false;
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.Size = new System.Drawing.Size(819, 266);
            this.dgvPhong.TabIndex = 15;
            this.dgvPhong.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPhong_RowHeaderMouseDoubleClick);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Yellow;
            this.btnHuy.Location = new System.Drawing.Point(713, 479);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(193, 50);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTraPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraPhong.ForeColor = System.Drawing.Color.Yellow;
            this.btnTraPhong.Location = new System.Drawing.Point(132, 479);
            this.btnTraPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(193, 50);
            this.btnTraPhong.TabIndex = 13;
            this.btnTraPhong.Text = "Trả phòng";
            this.btnTraPhong.UseVisualStyleBackColor = false;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // FormTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 633);
            this.Controls.Add(this.panel30);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(490, 170);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Label lblTraPhong;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.Label lblNote;
    }
}