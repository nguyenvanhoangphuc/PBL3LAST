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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVNguoiThue = new System.Windows.Forms.DataGridView();
            this.btnOK = new CustomButton.VBButton();
            this.lblSophong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNguoiThue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(41, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách các người thuê của phòng";
            // 
            // DGVNguoiThue
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.DGVNguoiThue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVNguoiThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVNguoiThue.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVNguoiThue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVNguoiThue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVNguoiThue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVNguoiThue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVNguoiThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVNguoiThue.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVNguoiThue.EnableHeadersVisualStyles = false;
            this.DGVNguoiThue.Location = new System.Drawing.Point(48, 109);
            this.DGVNguoiThue.Margin = new System.Windows.Forms.Padding(2);
            this.DGVNguoiThue.Name = "DGVNguoiThue";
            this.DGVNguoiThue.RowHeadersWidth = 51;
            this.DGVNguoiThue.RowTemplate.Height = 24;
            this.DGVNguoiThue.Size = new System.Drawing.Size(491, 245);
            this.DGVNguoiThue.TabIndex = 28;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOK.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOK.BorderColor = System.Drawing.Color.DimGray;
            this.btnOK.BorderRadius = 5;
            this.btnOK.BorderSize = 3;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(237, 359);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 43);
            this.btnOK.TabIndex = 32;
            this.btnOK.Text = "OK";
            this.btnOK.TextColor = System.Drawing.Color.White;
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // lblSophong
            // 
            this.lblSophong.AutoSize = true;
            this.lblSophong.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSophong.Location = new System.Drawing.Point(543, 22);
            this.lblSophong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSophong.Name = "lblSophong";
            this.lblSophong.Size = new System.Drawing.Size(30, 40);
            this.lblSophong.TabIndex = 1;
            this.lblSophong.Text = "?";
            // 
            // FormShowNguoiThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 421);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.DGVNguoiThue);
            this.Controls.Add(this.lblSophong);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormShowNguoiThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormShowNguoiThue";
            this.Click += new System.EventHandler(this.btnOK_Click);
            ((System.ComponentModel.ISupportInitialize)(this.DGVNguoiThue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVNguoiThue;
        private CustomButton.VBButton btnOK;
        private System.Windows.Forms.Label lblSophong;
    }
}