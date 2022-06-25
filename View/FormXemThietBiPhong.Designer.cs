
namespace QuanLyPhongTroLinQ.View
{
    partial class FormXemThietBiPhong
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.btnDong = new CustomButton.VBButton();
            this.DGVPhongTro = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPhongTro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.DGVPhongTro);
            this.panel4.Controls.Add(this.btnDong);
            this.panel4.Controls.Add(this.lblTenPhong);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lblTieuDe);
            this.panel4.Controls.Add(this.txtTenPhong);
            this.panel4.Location = new System.Drawing.Point(9, 9);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 495);
            this.panel4.TabIndex = 10;
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhong.Location = new System.Drawing.Point(254, 121);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(97, 22);
            this.lblTenPhong.TabIndex = 8;
            this.lblTenPhong.Text = "Tên phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh sách thiết bị phòng";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(237, 161);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(338, 40);
            this.lblTieuDe.TabIndex = 3;
            this.lblTieuDe.Text = "Bảng danh sách thiết bị";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhong.Location = new System.Drawing.Point(390, 119);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(117, 29);
            this.txtTenPhong.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDong.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDong.BorderColor = System.Drawing.Color.DimGray;
            this.btnDong.BorderRadius = 5;
            this.btnDong.BorderSize = 3;
            this.btnDong.FlatAppearance.BorderSize = 0;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(340, 408);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(112, 43);
            this.btnDong.TabIndex = 31;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextColor = System.Drawing.Color.White;
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // DGVPhongTro
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.DGVPhongTro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVPhongTro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPhongTro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVPhongTro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVPhongTro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVPhongTro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPhongTro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVPhongTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVPhongTro.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVPhongTro.EnableHeadersVisualStyles = false;
            this.DGVPhongTro.Location = new System.Drawing.Point(85, 212);
            this.DGVPhongTro.Margin = new System.Windows.Forms.Padding(2);
            this.DGVPhongTro.Name = "DGVPhongTro";
            this.DGVPhongTro.RowHeadersWidth = 51;
            this.DGVPhongTro.RowTemplate.Height = 24;
            this.DGVPhongTro.Size = new System.Drawing.Size(623, 176);
            this.DGVPhongTro.TabIndex = 33;
            // 
            // FormXemThietBiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(794, 514);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 70);
            this.Name = "FormXemThietBiPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPhongTro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenPhong;
        private CustomButton.VBButton btnDong;
        private System.Windows.Forms.DataGridView DGVPhongTro;
    }
}