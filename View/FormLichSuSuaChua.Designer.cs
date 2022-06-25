namespace QuanLyPhongTroLinQ.View
{
    partial class FormLichSuSuaChua
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateSuaChua = new System.Windows.Forms.DateTimePicker();
            this.cbbPhong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnAdd = new CustomButton.VBButton();
            this.DGVLSSuaChua = new System.Windows.Forms.DataGridView();
            this.btnDel = new CustomButton.VBButton();
            this.btnUpdate = new CustomButton.VBButton();
            this.btnDefault = new CustomButton.VBButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLSSuaChua)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.DGVLSSuaChua);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.btnDel);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lblTieuDe);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(9, 9);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 496);
            this.panel4.TabIndex = 11;
            // 
            // dateSuaChua
            // 
            this.dateSuaChua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSuaChua.Location = new System.Drawing.Point(148, 59);
            this.dateSuaChua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateSuaChua.Name = "dateSuaChua";
            this.dateSuaChua.Size = new System.Drawing.Size(208, 26);
            this.dateSuaChua.TabIndex = 9;
            this.dateSuaChua.ValueChanged += new System.EventHandler(this.dateSuaChua_ValueChanged);
            // 
            // cbbPhong
            // 
            this.cbbPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPhong.FormattingEnabled = true;
            this.cbbPhong.Location = new System.Drawing.Point(148, 15);
            this.cbbPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbPhong.Name = "cbbPhong";
            this.cbbPhong.Size = new System.Drawing.Size(208, 27);
            this.cbbPhong.TabIndex = 8;
            this.cbbPhong.SelectedIndexChanged += new System.EventHandler(this.cbbPhong_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trước đó cho đến:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lịch sử sửa chữa";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(19, 58);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(138, 17);
            this.lblTieuDe.TabIndex = 3;
            this.lblTieuDe.Text = "Lịch sử các lần sửa chữa";
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
            this.btnAdd.Location = new System.Drawing.Point(43, 321);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 46);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DGVLSSuaChua
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.DGVLSSuaChua.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVLSSuaChua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVLSSuaChua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVLSSuaChua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVLSSuaChua.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVLSSuaChua.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVLSSuaChua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVLSSuaChua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVLSSuaChua.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVLSSuaChua.EnableHeadersVisualStyles = false;
            this.DGVLSSuaChua.Location = new System.Drawing.Point(22, 76);
            this.DGVLSSuaChua.Margin = new System.Windows.Forms.Padding(2);
            this.DGVLSSuaChua.Name = "DGVLSSuaChua";
            this.DGVLSSuaChua.RowHeadersWidth = 51;
            this.DGVLSSuaChua.RowTemplate.Height = 24;
            this.DGVLSSuaChua.Size = new System.Drawing.Size(713, 225);
            this.DGVLSSuaChua.TabIndex = 33;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDel.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDel.BorderColor = System.Drawing.Color.DimGray;
            this.btnDel.BorderRadius = 5;
            this.btnDel.BorderSize = 3;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(263, 321);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(74, 46);
            this.btnDel.TabIndex = 32;
            this.btnDel.Text = "Delete";
            this.btnDel.TextColor = System.Drawing.Color.White;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(153, 321);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 46);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDefault.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDefault.BorderColor = System.Drawing.Color.DimGray;
            this.btnDefault.BorderRadius = 5;
            this.btnDefault.BorderSize = 3;
            this.btnDefault.FlatAppearance.BorderSize = 0;
            this.btnDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefault.ForeColor = System.Drawing.Color.White;
            this.btnDefault.Location = new System.Drawing.Point(138, 94);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(97, 46);
            this.btnDefault.TabIndex = 32;
            this.btnDefault.Text = "Default";
            this.btnDefault.TextColor = System.Drawing.Color.White;
            this.btnDefault.UseVisualStyleBackColor = false;
            this.btnDefault.Click += new System.EventHandler(this.butDefault_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnDefault);
            this.panel1.Controls.Add(this.dateSuaChua);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbbPhong);
            this.panel1.Location = new System.Drawing.Point(370, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 150);
            this.panel1.TabIndex = 34;
            // 
            // FormLichSuSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 514);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 70);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormLichSuSuaChua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormLichSuSuaChua";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLSSuaChua)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.DateTimePicker dateSuaChua;
        private System.Windows.Forms.ComboBox cbbPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomButton.VBButton btnAdd;
        private System.Windows.Forms.DataGridView DGVLSSuaChua;
        private CustomButton.VBButton btnDefault;
        private CustomButton.VBButton btnUpdate;
        private CustomButton.VBButton btnDel;
        private System.Windows.Forms.Panel panel1;
    }
}