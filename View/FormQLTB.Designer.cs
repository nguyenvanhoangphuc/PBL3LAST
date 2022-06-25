namespace QuanLyPhongTroLinQ.View
{
    partial class FormQLTB
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new CustomButton.VBButton();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.cbTT = new System.Windows.Forms.CheckBox();
            this.cbLoaiTB = new System.Windows.Forms.CheckBox();
            this.cbPhong = new System.Windows.Forms.CheckBox();
            this.butDefault = new CustomButton.VBButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnUpdate = new CustomButton.VBButton();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVThietBi = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel30.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.SystemColors.Control;
            this.panel30.Controls.Add(this.label3);
            this.panel30.Controls.Add(this.DGVThietBi);
            this.panel30.Controls.Add(this.panel1);
            this.panel30.Controls.Add(this.btnUpdate);
            this.panel30.Controls.Add(this.label2);
            this.panel30.Location = new System.Drawing.Point(10, 11);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(776, 496);
            this.panel30.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.gbSearch);
            this.panel1.Controls.Add(this.butDefault);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(287, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 167);
            this.panel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nhập thông tin cần tìm kiếm";
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
            this.btnSearch.Location = new System.Drawing.Point(10, 105);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 43);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.cbTT);
            this.gbSearch.Controls.Add(this.cbLoaiTB);
            this.gbSearch.Controls.Add(this.cbPhong);
            this.gbSearch.Location = new System.Drawing.Point(10, 51);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(2);
            this.gbSearch.Size = new System.Drawing.Size(367, 49);
            this.gbSearch.TabIndex = 11;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search theo:";
            // 
            // cbTT
            // 
            this.cbTT.AutoSize = true;
            this.cbTT.Location = new System.Drawing.Point(224, 17);
            this.cbTT.Margin = new System.Windows.Forms.Padding(2);
            this.cbTT.Name = "cbTT";
            this.cbTT.Size = new System.Drawing.Size(74, 17);
            this.cbTT.TabIndex = 0;
            this.cbTT.Text = "Tình trạng";
            this.cbTT.UseVisualStyleBackColor = true;
            // 
            // cbLoaiTB
            // 
            this.cbLoaiTB.AutoSize = true;
            this.cbLoaiTB.Location = new System.Drawing.Point(118, 17);
            this.cbLoaiTB.Margin = new System.Windows.Forms.Padding(2);
            this.cbLoaiTB.Name = "cbLoaiTB";
            this.cbLoaiTB.Size = new System.Drawing.Size(102, 17);
            this.cbLoaiTB.TabIndex = 0;
            this.cbLoaiTB.Text = "Tên Loại thiết bị";
            this.cbLoaiTB.UseVisualStyleBackColor = true;
            // 
            // cbPhong
            // 
            this.cbPhong.AutoSize = true;
            this.cbPhong.Location = new System.Drawing.Point(24, 17);
            this.cbPhong.Margin = new System.Windows.Forms.Padding(2);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(79, 17);
            this.cbPhong.TabIndex = 0;
            this.cbPhong.Text = "Tên Phòng";
            this.cbPhong.UseVisualStyleBackColor = true;
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
            this.butDefault.Location = new System.Drawing.Point(265, 105);
            this.butDefault.Name = "butDefault";
            this.butDefault.Size = new System.Drawing.Size(112, 43);
            this.butDefault.TabIndex = 30;
            this.butDefault.Text = "Default";
            this.butDefault.TextColor = System.Drawing.Color.White;
            this.butDefault.UseVisualStyleBackColor = false;
            this.butDefault.Click += new System.EventHandler(this.butDefault_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(171, 21);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(206, 26);
            this.txtSearch.TabIndex = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpdate.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpdate.BorderColor = System.Drawing.Color.DimGray;
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.BorderSize = 3;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(78, 329);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 43);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quản lý thiết bị";
            // 
            // DGVThietBi
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.DGVThietBi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVThietBi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVThietBi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVThietBi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVThietBi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVThietBi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVThietBi.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVThietBi.EnableHeadersVisualStyles = false;
            this.DGVThietBi.Location = new System.Drawing.Point(38, 105);
            this.DGVThietBi.Margin = new System.Windows.Forms.Padding(2);
            this.DGVThietBi.Name = "DGVThietBi";
            this.DGVThietBi.RowHeadersWidth = 51;
            this.DGVThietBi.RowTemplate.Height = 24;
            this.DGVThietBi.Size = new System.Drawing.Size(700, 186);
            this.DGVThietBi.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Bảng danh sách thiết bị";
            // 
            // FormQLTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 514);
            this.Controls.Add(this.panel30);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 70);
            this.Name = "FormQLTB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormQLTB";
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVThietBi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.CheckBox cbTT;
        private System.Windows.Forms.CheckBox cbLoaiTB;
        private System.Windows.Forms.CheckBox cbPhong;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CustomButton.VBButton btnSearch;
        private CustomButton.VBButton butDefault;
        private CustomButton.VBButton btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGVThietBi;
    }
}