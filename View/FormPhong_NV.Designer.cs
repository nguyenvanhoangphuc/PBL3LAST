
namespace QuanLyPhongTroLinQ.View
{
    partial class FormPhong_NV
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
            this.butDefault = new CustomButton.VBButton();
            this.btnSearch = new CustomButton.VBButton();
            this.lblNote = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.cbTT = new System.Windows.Forms.CheckBox();
            this.cbTen = new System.Windows.Forms.CheckBox();
            this.cbLoai = new System.Windows.Forms.CheckBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.DGVPhongTro = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPhongTro)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.DGVPhongTro);
            this.panel4.Controls.Add(this.lblNote);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lblTieuDe);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(9, 9);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 496);
            this.panel4.TabIndex = 10;
            // 
            // butDefault
            // 
            this.butDefault.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.butDefault.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.butDefault.BorderColor = System.Drawing.Color.DimGray;
            this.butDefault.BorderRadius = 5;
            this.butDefault.BorderSize = 3;
            this.butDefault.FlatAppearance.BorderSize = 0;
            this.butDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDefault.ForeColor = System.Drawing.Color.White;
            this.butDefault.Location = new System.Drawing.Point(305, 94);
            this.butDefault.Name = "butDefault";
            this.butDefault.Size = new System.Drawing.Size(112, 43);
            this.butDefault.TabIndex = 30;
            this.butDefault.Text = "Default";
            this.butDefault.TextColor = System.Drawing.Color.White;
            this.butDefault.UseVisualStyleBackColor = false;
            this.butDefault.Click += new System.EventHandler(this.butDefault_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSearch.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSearch.BorderColor = System.Drawing.Color.DimGray;
            this.btnSearch.BorderRadius = 5;
            this.btnSearch.BorderSize = 3;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(22, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 43);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNote.Location = new System.Drawing.Point(14, 363);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(260, 32);
            this.lblNote.TabIndex = 7;
            this.lblNote.Text = "Ghi chú : Có thể xem thiết bị 1 phòng \r\nbằng cách double click chuột trái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh sách phòng trọ";
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.cbTT);
            this.gbSearch.Controls.Add(this.cbTen);
            this.gbSearch.Controls.Add(this.cbLoai);
            this.gbSearch.Location = new System.Drawing.Point(22, 53);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(2);
            this.gbSearch.Size = new System.Drawing.Size(406, 36);
            this.gbSearch.TabIndex = 5;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search theo:";
            // 
            // cbTT
            // 
            this.cbTT.AutoSize = true;
            this.cbTT.Location = new System.Drawing.Point(321, 15);
            this.cbTT.Margin = new System.Windows.Forms.Padding(2);
            this.cbTT.Name = "cbTT";
            this.cbTT.Size = new System.Drawing.Size(74, 17);
            this.cbTT.TabIndex = 4;
            this.cbTT.Text = "Tình trạng";
            this.cbTT.UseVisualStyleBackColor = true;
            // 
            // cbTen
            // 
            this.cbTen.AutoSize = true;
            this.cbTen.Location = new System.Drawing.Point(99, 15);
            this.cbTen.Margin = new System.Windows.Forms.Padding(2);
            this.cbTen.Name = "cbTen";
            this.cbTen.Size = new System.Drawing.Size(78, 17);
            this.cbTen.TabIndex = 4;
            this.cbTen.Text = "Tên phòng";
            this.cbTen.UseVisualStyleBackColor = true;
            // 
            // cbLoai
            // 
            this.cbLoai.AutoSize = true;
            this.cbLoai.Location = new System.Drawing.Point(208, 15);
            this.cbLoai.Margin = new System.Windows.Forms.Padding(2);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(79, 17);
            this.cbLoai.TabIndex = 4;
            this.cbLoai.Text = "Loại phòng";
            this.cbLoai.UseVisualStyleBackColor = true;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(14, 67);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(171, 17);
            this.lblTieuDe.TabIndex = 3;
            this.lblTieuDe.Text = "Bảng danh sách các phòng trọ";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(163, 9);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(265, 29);
            this.txtSearch.TabIndex = 0;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPhongTro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVPhongTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVPhongTro.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVPhongTro.EnableHeadersVisualStyles = false;
            this.DGVPhongTro.Location = new System.Drawing.Point(17, 86);
            this.DGVPhongTro.Margin = new System.Windows.Forms.Padding(2);
            this.DGVPhongTro.Name = "DGVPhongTro";
            this.DGVPhongTro.RowHeadersWidth = 51;
            this.DGVPhongTro.RowTemplate.Height = 24;
            this.DGVPhongTro.Size = new System.Drawing.Size(745, 245);
            this.DGVPhongTro.TabIndex = 31;
            this.DGVPhongTro.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVPhongTro_RowHeaderMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.butDefault);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.gbSearch);
            this.panel1.Location = new System.Drawing.Point(315, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 145);
            this.panel1.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập thông tin cần tìm kiếm";
            // 
            // FormPhong_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(794, 514);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 70);
            this.Name = "FormPhong_NV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPhongTro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.CheckBox cbTT;
        private System.Windows.Forms.CheckBox cbTen;
        private System.Windows.Forms.CheckBox cbLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNote;
        private CustomButton.VBButton butDefault;
        private CustomButton.VBButton btnSearch;
        private System.Windows.Forms.DataGridView DGVPhongTro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}