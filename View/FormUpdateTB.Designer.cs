namespace QuanLyPhongTroLinQ.View
{
    partial class FormUpdateTB
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
            this.cbbTenLoaiTB = new System.Windows.Forms.ComboBox();
            this.gbTT = new System.Windows.Forms.GroupBox();
            this.rbutHong = new System.Windows.Forms.RadioButton();
            this.rbutTot = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTenPhong = new System.Windows.Forms.ComboBox();
            this.btnReset = new CustomButton.VBButton();
            this.btnCancel = new CustomButton.VBButton();
            this.btnUpdate = new CustomButton.VBButton();
            this.gbTT.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbTenLoaiTB
            // 
            this.cbbTenLoaiTB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.cbbTenLoaiTB.FormattingEnabled = true;
            this.cbbTenLoaiTB.Location = new System.Drawing.Point(202, 136);
            this.cbbTenLoaiTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbTenLoaiTB.Name = "cbbTenLoaiTB";
            this.cbbTenLoaiTB.Size = new System.Drawing.Size(178, 28);
            this.cbbTenLoaiTB.TabIndex = 18;
            // 
            // gbTT
            // 
            this.gbTT.Controls.Add(this.rbutHong);
            this.gbTT.Controls.Add(this.rbutTot);
            this.gbTT.Location = new System.Drawing.Point(202, 193);
            this.gbTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbTT.Name = "gbTT";
            this.gbTT.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbTT.Size = new System.Drawing.Size(178, 40);
            this.gbTT.TabIndex = 17;
            this.gbTT.TabStop = false;
            // 
            // rbutHong
            // 
            this.rbutHong.AutoSize = true;
            this.rbutHong.Location = new System.Drawing.Point(106, 17);
            this.rbutHong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbutHong.Name = "rbutHong";
            this.rbutHong.Size = new System.Drawing.Size(51, 17);
            this.rbutHong.TabIndex = 0;
            this.rbutHong.TabStop = true;
            this.rbutHong.Text = "Hỏng";
            this.rbutHong.UseVisualStyleBackColor = true;
            // 
            // rbutTot
            // 
            this.rbutTot.AutoSize = true;
            this.rbutTot.Location = new System.Drawing.Point(4, 17);
            this.rbutTot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbutTot.Name = "rbutTot";
            this.rbutTot.Size = new System.Drawing.Size(56, 17);
            this.rbutTot.TabIndex = 0;
            this.rbutTot.TabStop = true;
            this.rbutTot.Text = "HD tốt";
            this.rbutTot.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tình trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên loại TB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vui lòng điều đầy đủ thông tin sau";
            // 
            // cbbTenPhong
            // 
            this.cbbTenPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.cbbTenPhong.FormattingEnabled = true;
            this.cbbTenPhong.Location = new System.Drawing.Point(202, 81);
            this.cbbTenPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbTenPhong.Name = "cbbTenPhong";
            this.cbbTenPhong.Size = new System.Drawing.Size(178, 28);
            this.cbbTenPhong.TabIndex = 18;
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
            this.btnReset.Location = new System.Drawing.Point(156, 281);
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
            this.btnCancel.Location = new System.Drawing.Point(296, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 43);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(16, 281);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 43);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FormUpdateTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 368);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbbTenPhong);
            this.Controls.Add(this.cbbTenLoaiTB);
            this.Controls.Add(this.gbTT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormUpdateTB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUpdateTB";
            this.gbTT.ResumeLayout(false);
            this.gbTT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTenLoaiTB;
        private System.Windows.Forms.GroupBox gbTT;
        private System.Windows.Forms.RadioButton rbutHong;
        private System.Windows.Forms.RadioButton rbutTot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTenPhong;
        private CustomButton.VBButton btnReset;
        private CustomButton.VBButton btnCancel;
        private CustomButton.VBButton btnUpdate;
    }
}