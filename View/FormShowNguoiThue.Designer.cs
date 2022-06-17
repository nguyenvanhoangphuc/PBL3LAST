namespace QuanLyPhongTroLinQ.View
{
    partial class FormShowNguoiThue
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
            this.DGVNguoiThue = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNguoiThue)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVNguoiThue
            // 
            this.DGVNguoiThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNguoiThue.Location = new System.Drawing.Point(64, 112);
            this.DGVNguoiThue.Name = "DGVNguoiThue";
            this.DGVNguoiThue.RowHeadersWidth = 51;
            this.DGVNguoiThue.RowTemplate.Height = 24;
            this.DGVNguoiThue.Size = new System.Drawing.Size(668, 290);
            this.DGVNguoiThue.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(55, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách các người thuê của phòng ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(680, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "?";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(333, 440);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(111, 44);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FormShowNguoiThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVNguoiThue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormShowNguoiThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormShowNguoiThue";
            ((System.ComponentModel.ISupportInitialize)(this.DGVNguoiThue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVNguoiThue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
    }
}