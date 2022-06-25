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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTenPhong = new System.Windows.Forms.ComboBox();
            this.gbTT.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbTenLoaiTB
            // 
            this.cbbTenLoaiTB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.cbbTenLoaiTB.FormattingEnabled = true;
            this.cbbTenLoaiTB.Location = new System.Drawing.Point(270, 167);
            this.cbbTenLoaiTB.Name = "cbbTenLoaiTB";
            this.cbbTenLoaiTB.Size = new System.Drawing.Size(236, 33);
            this.cbbTenLoaiTB.TabIndex = 18;
            // 
            // gbTT
            // 
            this.gbTT.Controls.Add(this.rbutHong);
            this.gbTT.Controls.Add(this.rbutTot);
            this.gbTT.Location = new System.Drawing.Point(225, 237);
            this.gbTT.Name = "gbTT";
            this.gbTT.Size = new System.Drawing.Size(281, 49);
            this.gbTT.TabIndex = 17;
            this.gbTT.TabStop = false;
            this.gbTT.Text = "Tình trạng thiết bị";
            // 
            // rbutHong
            // 
            this.rbutHong.AutoSize = true;
            this.rbutHong.Location = new System.Drawing.Point(194, 23);
            this.rbutHong.Name = "rbutHong";
            this.rbutHong.Size = new System.Drawing.Size(61, 20);
            this.rbutHong.TabIndex = 0;
            this.rbutHong.TabStop = true;
            this.rbutHong.Text = "Hỏng";
            this.rbutHong.UseVisualStyleBackColor = true;
            // 
            // rbutTot
            // 
            this.rbutTot.AutoSize = true;
            this.rbutTot.Location = new System.Drawing.Point(67, 23);
            this.rbutTot.Name = "rbutTot";
            this.rbutTot.Size = new System.Drawing.Size(65, 20);
            this.rbutTot.TabIndex = 0;
            this.rbutTot.TabStop = true;
            this.rbutTot.Text = "HD tốt";
            this.rbutTot.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(87, 350);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 50);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(410, 350);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 50);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(248, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 50);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tình trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên loại TB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(47, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vui lòng điều đầy đủ thông tin sau";
            // 
            // cbbTenPhong
            // 
            this.cbbTenPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.cbbTenPhong.FormattingEnabled = true;
            this.cbbTenPhong.Location = new System.Drawing.Point(270, 100);
            this.cbbTenPhong.Name = "cbbTenPhong";
            this.cbbTenPhong.Size = new System.Drawing.Size(236, 33);
            this.cbbTenPhong.TabIndex = 18;
            // 
            // FormUpdateTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 453);
            this.Controls.Add(this.cbbTenPhong);
            this.Controls.Add(this.cbbTenLoaiTB);
            this.Controls.Add(this.gbTT);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTenPhong;
    }
}