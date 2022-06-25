namespace QuanLyPhongTroLinQ.View
{
    partial class AddLichSuSuaChua
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
            this.cbbPhong = new System.Windows.Forms.ComboBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbLoaiTB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateSuaChua = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new CustomButton.VBButton();
            this.btnCancel = new CustomButton.VBButton();
            this.btnAdd = new CustomButton.VBButton();
            this.SuspendLayout();
            // 
            // cbbPhong
            // 
            this.cbbPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.cbbPhong.FormattingEnabled = true;
            this.cbbPhong.Location = new System.Drawing.Point(242, 87);
            this.cbbPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbPhong.Name = "cbbPhong";
            this.cbbPhong.Size = new System.Drawing.Size(178, 28);
            this.cbbPhong.TabIndex = 18;
            this.cbbPhong.SelectedIndexChanged += new System.EventHandler(this.cbbPhong_SelectedIndexChanged);
            // 
            // txtSoTien
            // 
            this.txtSoTien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTien.Location = new System.Drawing.Point(242, 219);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(178, 29);
            this.txtSoTien.TabIndex = 11;
            this.txtSoTien.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 221);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số tiền sửa chữa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên loại thiết bị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(52, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vui lòng điều đầy đủ thông tin sau";
            // 
            // cbbLoaiTB
            // 
            this.cbbLoaiTB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.cbbLoaiTB.FormattingEnabled = true;
            this.cbbLoaiTB.Location = new System.Drawing.Point(242, 128);
            this.cbbLoaiTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbLoaiTB.Name = "cbbLoaiTB";
            this.cbbLoaiTB.Size = new System.Drawing.Size(178, 28);
            this.cbbLoaiTB.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày sửa chữa";
            // 
            // dateSuaChua
            // 
            this.dateSuaChua.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSuaChua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSuaChua.Location = new System.Drawing.Point(242, 178);
            this.dateSuaChua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateSuaChua.Name = "dateSuaChua";
            this.dateSuaChua.Size = new System.Drawing.Size(178, 26);
            this.dateSuaChua.TabIndex = 19;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnReset.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnReset.BorderColor = System.Drawing.Color.DimGray;
            this.btnReset.BorderRadius = 5;
            this.btnReset.BorderSize = 3;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(185, 296);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 43);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "Reset";
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCancel.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCancel.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.BorderSize = 3;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(312, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 43);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.BorderColor = System.Drawing.Color.DimGray;
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.BorderSize = 3;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(58, 296);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 43);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddLichSuSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 382);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dateSuaChua);
            this.Controls.Add(this.cbbLoaiTB);
            this.Controls.Add(this.cbbPhong);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddLichSuSuaChua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddLichSuSuaChua";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbPhong;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbLoaiTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateSuaChua;
        private CustomButton.VBButton btnReset;
        private CustomButton.VBButton btnCancel;
        private CustomButton.VBButton btnAdd;
    }
}