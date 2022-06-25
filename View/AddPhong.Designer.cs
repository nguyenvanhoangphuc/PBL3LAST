namespace QuanLyPhongTroLinQ.View
{
    partial class AddPhong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoChuDien = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbutTTF = new System.Windows.Forms.RadioButton();
            this.rbutTT = new System.Windows.Forms.RadioButton();
            this.cbbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.btnAdd = new CustomButton.VBButton();
            this.btnCancel = new CustomButton.VBButton();
            this.btnReset = new CustomButton.VBButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vui lòng điều đầy đủ thông tin sau";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tình trạng";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(190, 94);
            this.txtTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(178, 29);
            this.txtTen.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 230);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số chữ điện";
            // 
            // txtSoChuDien
            // 
            this.txtSoChuDien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoChuDien.Location = new System.Drawing.Point(190, 228);
            this.txtSoChuDien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoChuDien.Name = "txtSoChuDien";
            this.txtSoChuDien.Size = new System.Drawing.Size(178, 29);
            this.txtSoChuDien.TabIndex = 1;
            this.txtSoChuDien.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbutTTF);
            this.groupBox1.Controls.Add(this.rbutTT);
            this.groupBox1.Location = new System.Drawing.Point(190, 170);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(177, 46);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rbutTTF
            // 
            this.rbutTTF.AutoSize = true;
            this.rbutTTF.Location = new System.Drawing.Point(98, 19);
            this.rbutTTF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbutTTF.Name = "rbutTTF";
            this.rbutTTF.Size = new System.Drawing.Size(50, 17);
            this.rbutTTF.TabIndex = 0;
            this.rbutTTF.TabStop = true;
            this.rbutTTF.Text = "False";
            this.rbutTTF.UseVisualStyleBackColor = true;
            // 
            // rbutTT
            // 
            this.rbutTT.AutoSize = true;
            this.rbutTT.Location = new System.Drawing.Point(14, 19);
            this.rbutTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbutTT.Name = "rbutTT";
            this.rbutTT.Size = new System.Drawing.Size(47, 17);
            this.rbutTT.TabIndex = 0;
            this.rbutTT.TabStop = true;
            this.rbutTT.Text = "True";
            this.rbutTT.UseVisualStyleBackColor = true;
            // 
            // cbbLoaiPhong
            // 
            this.cbbLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.cbbLoaiPhong.FormattingEnabled = true;
            this.cbbLoaiPhong.Location = new System.Drawing.Point(190, 138);
            this.cbbLoaiPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbLoaiPhong.Name = "cbbLoaiPhong";
            this.cbbLoaiPhong.Size = new System.Drawing.Size(178, 28);
            this.cbbLoaiPhong.TabIndex = 4;
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
            this.btnAdd.Location = new System.Drawing.Point(26, 293);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 43);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(280, 293);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 43);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnReset.Location = new System.Drawing.Point(153, 293);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 43);
            this.btnReset.TabIndex = 33;
            this.btnReset.Text = "Reset";
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // AddPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 367);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbbLoaiPhong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoChuDien);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPhong";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoChuDien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbutTTF;
        private System.Windows.Forms.RadioButton rbutTT;
        private System.Windows.Forms.ComboBox cbbLoaiPhong;
        private CustomButton.VBButton btnAdd;
        private CustomButton.VBButton btnCancel;
        private CustomButton.VBButton btnReset;
    }
}