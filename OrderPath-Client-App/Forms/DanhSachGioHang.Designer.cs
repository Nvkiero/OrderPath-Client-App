namespace OrderPath_Client_App.Forms
{
    partial class DanhSachGioHang
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
            dgvGioHang = new DataGridView();
            btnXoa = new Button();
            btnThanhToan = new Button();
            lblTongTien = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
            SuspendLayout();
            // 
            // dgvGioHang
            // 
            dgvGioHang.AllowUserToAddRows = false;
            dgvGioHang.AllowUserToDeleteRows = false;
            dgvGioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGioHang.Location = new Point(12, 12);
            dgvGioHang.Name = "dgvGioHang";
            dgvGioHang.RowHeadersWidth = 62;
            dgvGioHang.Size = new Size(916, 350);
            dgvGioHang.TabIndex = 0;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(12, 380);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 40);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa SP";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(150, 380);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(150, 40);
            btnThanhToan.TabIndex = 2;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTongTien.Location = new Point(700, 390);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(152, 32);
            lblTongTien.TabIndex = 3;
            lblTongTien.Text = "Tổng tiền: 0";
            // 
            // DanhSachGioHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(940, 491);
            Controls.Add(lblTongTien);
            Controls.Add(btnThanhToan);
            Controls.Add(btnXoa);
            Controls.Add(dgvGioHang);
            ForeColor = Color.Black;
            Name = "DanhSachGioHang";
            Text = "Danh Sách Giỏ Hàng";
            Load += DanhSachGioHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        // Fields
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lblTongTien;

        #endregion
    }
}