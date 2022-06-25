namespace QuanLyPhongTroLinQ.View
{
    partial class FormHoaDon
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
            this.text_HoaDon = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.but_Browse = new System.Windows.Forms.Button();
            this.btn_xuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_HoaDon
            // 
            this.text_HoaDon.Location = new System.Drawing.Point(40, 91);
            this.text_HoaDon.Name = "text_HoaDon";
            this.text_HoaDon.Size = new System.Drawing.Size(495, 373);
            this.text_HoaDon.TabIndex = 0;
            this.text_HoaDon.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path :";
            // 
            // txt_Path
            // 
            this.txt_Path.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Path.Location = new System.Drawing.Point(103, 29);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(336, 30);
            this.txt_Path.TabIndex = 2;
            // 
            // but_Browse
            // 
            this.but_Browse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Browse.Location = new System.Drawing.Point(445, 24);
            this.but_Browse.Name = "but_Browse";
            this.but_Browse.Size = new System.Drawing.Size(90, 39);
            this.but_Browse.TabIndex = 3;
            this.but_Browse.Text = "Browse";
            this.but_Browse.UseVisualStyleBackColor = true;
            this.but_Browse.Click += new System.EventHandler(this.but_Browse_Click);
            // 
            // btn_xuat
            // 
            this.btn_xuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuat.Location = new System.Drawing.Point(189, 470);
            this.btn_xuat.Name = "btn_xuat";
            this.btn_xuat.Size = new System.Drawing.Size(202, 35);
            this.btn_xuat.TabIndex = 4;
            this.btn_xuat.Text = "Xuất hóa đơn";
            this.btn_xuat.UseVisualStyleBackColor = true;
            this.btn_xuat.Click += new System.EventHandler(this.btn_xuat_Click);
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 539);
            this.Controls.Add(this.btn_xuat);
            this.Controls.Add(this.but_Browse);
            this.Controls.Add(this.txt_Path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_HoaDon);
            this.Name = "FormHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất hóa đơn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox text_HoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Button but_Browse;
        private System.Windows.Forms.Button btn_xuat;
    }
}