namespace QuanLyPhongTroLinQ.View
{
    partial class FormNVChoDuyet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVNVChon = new System.Windows.Forms.DataGridView();
            this.DGVNVDuyet = new System.Windows.Forms.DataGridView();
            this.btnChoose = new CustomButton.VBButton();
            this.btnConf = new CustomButton.VBButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNVChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNVDuyet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh sách nhân viên chờ được duyệt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 261);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Danh sách nhân viên đã chọn";
            // 
            // DGVNVChon
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.DGVNVChon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVNVChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVNVChon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVNVChon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVNVChon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVNVChon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVNVChon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVNVChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVNVChon.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVNVChon.EnableHeadersVisualStyles = false;
            this.DGVNVChon.Location = new System.Drawing.Point(57, 73);
            this.DGVNVChon.Margin = new System.Windows.Forms.Padding(2);
            this.DGVNVChon.Name = "DGVNVChon";
            this.DGVNVChon.RowHeadersWidth = 51;
            this.DGVNVChon.RowTemplate.Height = 24;
            this.DGVNVChon.Size = new System.Drawing.Size(430, 142);
            this.DGVNVChon.TabIndex = 27;
            // 
            // DGVNVDuyet
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.DGVNVDuyet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVNVDuyet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVNVDuyet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVNVDuyet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVNVDuyet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVNVDuyet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVNVDuyet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVNVDuyet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVNVDuyet.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVNVDuyet.EnableHeadersVisualStyles = false;
            this.DGVNVDuyet.Location = new System.Drawing.Point(57, 279);
            this.DGVNVDuyet.Margin = new System.Windows.Forms.Padding(2);
            this.DGVNVDuyet.Name = "DGVNVDuyet";
            this.DGVNVDuyet.RowHeadersWidth = 51;
            this.DGVNVDuyet.RowTemplate.Height = 24;
            this.DGVNVDuyet.Size = new System.Drawing.Size(430, 142);
            this.DGVNVDuyet.TabIndex = 28;
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnChoose.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnChoose.BorderColor = System.Drawing.Color.DimGray;
            this.btnChoose.BorderRadius = 5;
            this.btnChoose.BorderSize = 3;
            this.btnChoose.FlatAppearance.BorderSize = 0;
            this.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoose.ForeColor = System.Drawing.Color.White;
            this.btnChoose.Location = new System.Drawing.Point(506, 124);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(112, 43);
            this.btnChoose.TabIndex = 29;
            this.btnChoose.Text = "Choose";
            this.btnChoose.TextColor = System.Drawing.Color.White;
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnConf
            // 
            this.btnConf.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConf.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConf.BorderColor = System.Drawing.Color.DimGray;
            this.btnConf.BorderRadius = 5;
            this.btnConf.BorderSize = 3;
            this.btnConf.FlatAppearance.BorderSize = 0;
            this.btnConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConf.ForeColor = System.Drawing.Color.White;
            this.btnConf.Location = new System.Drawing.Point(506, 330);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(112, 43);
            this.btnConf.TabIndex = 29;
            this.btnConf.Text = "Confirm";
            this.btnConf.TextColor = System.Drawing.Color.White;
            this.btnConf.UseVisualStyleBackColor = false;
            this.btnConf.Click += new System.EventHandler(this.butConf_Click);
            // 
            // FormNVChoDuyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 457);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.DGVNVDuyet);
            this.Controls.Add(this.DGVNVChon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormNVChoDuyet";
            this.Text = "FormNVChoDuyet";
            ((System.ComponentModel.ISupportInitialize)(this.DGVNVChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNVDuyet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVNVChon;
        private System.Windows.Forms.DataGridView DGVNVDuyet;
        private CustomButton.VBButton btnChoose;
        private CustomButton.VBButton btnConf;
    }
}