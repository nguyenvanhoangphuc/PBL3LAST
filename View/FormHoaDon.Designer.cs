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
            this.but_Browse = new CustomButton.VBButton();
            this.btn_xuat = new CustomButton.VBButton();
            this.SuspendLayout();
            // 
            // text_HoaDon
            // 
            this.text_HoaDon.Location = new System.Drawing.Point(30, 74);
            this.text_HoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_HoaDon.Name = "text_HoaDon";
            this.text_HoaDon.Size = new System.Drawing.Size(372, 304);
            this.text_HoaDon.TabIndex = 0;
            this.text_HoaDon.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path :";
            // 
            // txt_Path
            // 
            this.txt_Path.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Path.Location = new System.Drawing.Point(77, 24);
            this.txt_Path.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(253, 26);
            this.txt_Path.TabIndex = 2;
            // 
            // but_Browse
            // 
            this.but_Browse.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.but_Browse.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.but_Browse.BorderColor = System.Drawing.Color.DimGray;
            this.but_Browse.BorderRadius = 5;
            this.but_Browse.BorderSize = 3;
            this.but_Browse.FlatAppearance.BorderSize = 0;
            this.but_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Browse.ForeColor = System.Drawing.Color.White;
            this.but_Browse.Location = new System.Drawing.Point(335, 20);
            this.but_Browse.Name = "but_Browse";
            this.but_Browse.Size = new System.Drawing.Size(84, 33);
            this.but_Browse.TabIndex = 34;
            this.but_Browse.Text = "Browse";
            this.but_Browse.TextColor = System.Drawing.Color.White;
            this.but_Browse.UseVisualStyleBackColor = false;
            this.but_Browse.Click += new System.EventHandler(this.but_Browse_Click);
            // 
            // btn_xuat
            // 
            this.btn_xuat.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_xuat.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_xuat.BorderColor = System.Drawing.Color.DimGray;
            this.btn_xuat.BorderRadius = 5;
            this.btn_xuat.BorderSize = 3;
            this.btn_xuat.FlatAppearance.BorderSize = 0;
            this.btn_xuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xuat.ForeColor = System.Drawing.Color.White;
            this.btn_xuat.Location = new System.Drawing.Point(157, 383);
            this.btn_xuat.Name = "btn_xuat";
            this.btn_xuat.Size = new System.Drawing.Size(126, 33);
            this.btn_xuat.TabIndex = 33;
            this.btn_xuat.Text = "Xuất hóa đơn";
            this.btn_xuat.TextColor = System.Drawing.Color.White;
            this.btn_xuat.UseVisualStyleBackColor = false;
            this.btn_xuat.ContextMenuStripChanged += new System.EventHandler(this.btn_xuat_Click);
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 438);
            this.Controls.Add(this.but_Browse);
            this.Controls.Add(this.btn_xuat);
            this.Controls.Add(this.txt_Path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_HoaDon);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private CustomButton.VBButton but_Browse;
        private CustomButton.VBButton btn_xuat;
    }
}