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
            this.DGVNVChon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChoose = new System.Windows.Forms.Button();
            this.DGVNVDuyet = new System.Windows.Forms.DataGridView();
            this.butConf = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNVChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNVDuyet)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVNVChon
            // 
            this.DGVNVChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNVChon.Location = new System.Drawing.Point(60, 70);
            this.DGVNVChon.Name = "DGVNVChon";
            this.DGVNVChon.RowHeadersWidth = 51;
            this.DGVNVChon.RowTemplate.Height = 24;
            this.DGVNVChon.Size = new System.Drawing.Size(590, 200);
            this.DGVNVChon.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(87, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh sách nhân viên chờ được duyệt";
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.ForeColor = System.Drawing.Color.Yellow;
            this.btnChoose.Location = new System.Drawing.Point(674, 140);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(150, 54);
            this.btnChoose.TabIndex = 6;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // DGVNVDuyet
            // 
            this.DGVNVDuyet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNVDuyet.Location = new System.Drawing.Point(60, 327);
            this.DGVNVDuyet.Name = "DGVNVDuyet";
            this.DGVNVDuyet.RowHeadersWidth = 51;
            this.DGVNVDuyet.RowTemplate.Height = 24;
            this.DGVNVDuyet.Size = new System.Drawing.Size(590, 200);
            this.DGVNVDuyet.TabIndex = 7;
            // 
            // butConf
            // 
            this.butConf.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butConf.ForeColor = System.Drawing.Color.Yellow;
            this.butConf.Location = new System.Drawing.Point(674, 394);
            this.butConf.Name = "butConf";
            this.butConf.Size = new System.Drawing.Size(150, 54);
            this.butConf.TabIndex = 8;
            this.butConf.Text = "Confirm";
            this.butConf.UseVisualStyleBackColor = false;
            this.butConf.Click += new System.EventHandler(this.butConf_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(87, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 42);
            this.label2.TabIndex = 9;
            this.label2.Text = "Danh sách nhân viên đã chọn";
            // 
            // FormNVChoDuyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butConf);
            this.Controls.Add(this.DGVNVDuyet);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVNVChon);
            this.Name = "FormNVChoDuyet";
            this.Text = "FormNVChoDuyet";
            ((System.ComponentModel.ISupportInitialize)(this.DGVNVChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNVDuyet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVNVChon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.DataGridView DGVNVDuyet;
        private System.Windows.Forms.Button butConf;
        private System.Windows.Forms.Label label2;
    }
}