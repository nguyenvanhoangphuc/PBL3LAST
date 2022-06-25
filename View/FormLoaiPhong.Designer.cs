namespace QuanLyPhongTroLinQ.View
{
    partial class FormLoaiPhong
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
            this.panel30 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblLoaiPhong1 = new System.Windows.Forms.Label();
            this.btnXemThietBi = new CustomButton.VBButton();
            this.panel30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.Color.White;
            this.panel30.Controls.Add(this.btnXemThietBi);
            this.panel30.Controls.Add(this.dgv);
            this.panel30.Controls.Add(this.lblLoaiPhong1);
            this.panel30.Location = new System.Drawing.Point(10, 7);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(776, 496);
            this.panel30.TabIndex = 1;
            // 
            // dgv
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Location = new System.Drawing.Point(30, 165);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(713, 247);
            this.dgv.TabIndex = 34;
            // 
            // lblLoaiPhong1
            // 
            this.lblLoaiPhong1.AutoSize = true;
            this.lblLoaiPhong1.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblLoaiPhong1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLoaiPhong1.Location = new System.Drawing.Point(322, 26);
            this.lblLoaiPhong1.Name = "lblLoaiPhong1";
            this.lblLoaiPhong1.Size = new System.Drawing.Size(171, 40);
            this.lblLoaiPhong1.TabIndex = 8;
            this.lblLoaiPhong1.Text = "Loại phòng";
            // 
            // btnXemThietBi
            // 
            this.btnXemThietBi.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXemThietBi.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXemThietBi.BorderColor = System.Drawing.Color.DimGray;
            this.btnXemThietBi.BorderRadius = 5;
            this.btnXemThietBi.BorderSize = 3;
            this.btnXemThietBi.FlatAppearance.BorderSize = 0;
            this.btnXemThietBi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemThietBi.ForeColor = System.Drawing.Color.White;
            this.btnXemThietBi.Location = new System.Drawing.Point(329, 417);
            this.btnXemThietBi.Name = "btnXemThietBi";
            this.btnXemThietBi.Size = new System.Drawing.Size(130, 65);
            this.btnXemThietBi.TabIndex = 35;
            this.btnXemThietBi.Text = "Xem danh sách thiết bị trong phòng";
            this.btnXemThietBi.TextColor = System.Drawing.Color.White;
            this.btnXemThietBi.UseVisualStyleBackColor = false;
            this.btnXemThietBi.Click += new System.EventHandler(this.btnXemThietBi_Click);
            // 
            // FormLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 514);
            this.Controls.Add(this.panel30);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 70);
            this.Name = "FormLoaiPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormLoaiPhong";
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Label lblLoaiPhong1;
        private System.Windows.Forms.DataGridView dgv;
        private CustomButton.VBButton btnXemThietBi;
    }
}