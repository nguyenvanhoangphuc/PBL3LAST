namespace QuanLyPhongTroLinQ.View
{
    partial class FormQLTB
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
            this.panel30 = new System.Windows.Forms.Panel();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.cbTT = new System.Windows.Forms.CheckBox();
            this.cbLoaiTB = new System.Windows.Forms.CheckBox();
            this.cbPhong = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.DGVThietBi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.butDefault = new System.Windows.Forms.Button();
            this.panel30.SuspendLayout();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel30.Controls.Add(this.butDefault);
            this.panel30.Controls.Add(this.gbSearch);
            this.panel30.Controls.Add(this.txtSearch);
            this.panel30.Controls.Add(this.btnSearch);
            this.panel30.Controls.Add(this.btnUpdate);
            this.panel30.Controls.Add(this.DGVThietBi);
            this.panel30.Controls.Add(this.label2);
            this.panel30.Location = new System.Drawing.Point(13, 13);
            this.panel30.Margin = new System.Windows.Forms.Padding(4);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(1034, 611);
            this.panel30.TabIndex = 1;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.cbTT);
            this.gbSearch.Controls.Add(this.cbLoaiTB);
            this.gbSearch.Controls.Add(this.cbPhong);
            this.gbSearch.Location = new System.Drawing.Point(382, 222);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(490, 74);
            this.gbSearch.TabIndex = 11;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search theo:";
            // 
            // cbTT
            // 
            this.cbTT.AutoSize = true;
            this.cbTT.Location = new System.Drawing.Point(347, 36);
            this.cbTT.Name = "cbTT";
            this.cbTT.Size = new System.Drawing.Size(88, 20);
            this.cbTT.TabIndex = 0;
            this.cbTT.Text = "Tình trạng";
            this.cbTT.UseVisualStyleBackColor = true;
            // 
            // cbLoaiTB
            // 
            this.cbLoaiTB.AutoSize = true;
            this.cbLoaiTB.Location = new System.Drawing.Point(192, 36);
            this.cbLoaiTB.Name = "cbLoaiTB";
            this.cbLoaiTB.Size = new System.Drawing.Size(123, 20);
            this.cbLoaiTB.TabIndex = 0;
            this.cbLoaiTB.Text = "Tên Loại thiết bị";
            this.cbLoaiTB.UseVisualStyleBackColor = true;
            // 
            // cbPhong
            // 
            this.cbPhong.AutoSize = true;
            this.cbPhong.Location = new System.Drawing.Point(41, 36);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(95, 20);
            this.cbPhong.TabIndex = 0;
            this.cbPhong.Text = "Tên Phòng";
            this.cbPhong.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(598, 157);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(274, 30);
            this.txtSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.ForeColor = System.Drawing.Color.Yellow;
            this.btnSearch.Location = new System.Drawing.Point(418, 147);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 50);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.ForeColor = System.Drawing.Color.Yellow;
            this.btnUpdate.Location = new System.Drawing.Point(149, 147);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 50);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // DGVThietBi
            // 
            this.DGVThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVThietBi.Location = new System.Drawing.Point(110, 329);
            this.DGVThietBi.Name = "DGVThietBi";
            this.DGVThietBi.RowHeadersWidth = 51;
            this.DGVThietBi.RowTemplate.Height = 24;
            this.DGVThietBi.Size = new System.Drawing.Size(809, 237);
            this.DGVThietBi.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 49);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quản lý thiết bị";
            // 
            // butDefault
            // 
            this.butDefault.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butDefault.ForeColor = System.Drawing.Color.Yellow;
            this.butDefault.Location = new System.Drawing.Point(149, 242);
            this.butDefault.Name = "butDefault";
            this.butDefault.Size = new System.Drawing.Size(100, 50);
            this.butDefault.TabIndex = 12;
            this.butDefault.Text = "Default";
            this.butDefault.UseVisualStyleBackColor = false;
            this.butDefault.Click += new System.EventHandler(this.butDefault_Click);
            // 
            // FormQLTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 633);
            this.Controls.Add(this.panel30);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 70);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormQLTB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormQLTB";
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVThietBi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.DataGridView DGVThietBi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.CheckBox cbTT;
        private System.Windows.Forms.CheckBox cbLoaiTB;
        private System.Windows.Forms.CheckBox cbPhong;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button butDefault;
    }
}