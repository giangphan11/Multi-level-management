namespace GUI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboThanhPho = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtSLKH = new System.Windows.Forms.TextBox();
            this.gvKhachHang = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSLHD = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhPhoCbo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn thành phố:";
            // 
            // cboThanhPho
            // 
            this.cboThanhPho.FormattingEnabled = true;
            this.cboThanhPho.Location = new System.Drawing.Point(176, 21);
            this.cboThanhPho.Name = "cboThanhPho";
            this.cboThanhPho.Size = new System.Drawing.Size(226, 33);
            this.cboThanhPho.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(421, 18);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(93, 36);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtSLKH
            // 
            this.txtSLKH.Enabled = false;
            this.txtSLKH.Location = new System.Drawing.Point(249, 63);
            this.txtSLKH.Name = "txtSLKH";
            this.txtSLKH.Size = new System.Drawing.Size(78, 30);
            this.txtSLKH.TabIndex = 3;
            // 
            // gvKhachHang
            // 
            this.gvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.thanhPhoCbo,
            this.Column4});
            this.gvKhachHang.Location = new System.Drawing.Point(17, 99);
            this.gvKhachHang.Name = "gvKhachHang";
            this.gvKhachHang.RowHeadersWidth = 51;
            this.gvKhachHang.RowTemplate.Height = 24;
            this.gvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvKhachHang.Size = new System.Drawing.Size(882, 256);
            this.gvKhachHang.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh sách khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh sách hoá đơn:";
            // 
            // txtSLHD
            // 
            this.txtSLHD.Enabled = false;
            this.txtSLHD.Location = new System.Drawing.Point(249, 361);
            this.txtSLHD.Name = "txtSLHD";
            this.txtSLHD.Size = new System.Drawing.Size(78, 30);
            this.txtSLHD.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(17, 407);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(882, 201);
            this.dataGridView2.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã KH";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Cty";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // thanhPhoCbo
            // 
            this.thanhPhoCbo.HeaderText = "Thành phố";
            this.thanhPhoCbo.MinimumWidth = 6;
            this.thanhPhoCbo.Name = "thanhPhoCbo";
            this.thanhPhoCbo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.thanhPhoCbo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.thanhPhoCbo.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Điện thoại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(752, 367);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 34);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Trở về";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 697);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.gvKhachHang);
            this.Controls.Add(this.txtSLHD);
            this.Controls.Add(this.txtSLKH);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cboThanhPho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboThanhPho;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtSLKH;
        private System.Windows.Forms.DataGridView gvKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSLHD;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn thanhPhoCbo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnBack;
    }
}

