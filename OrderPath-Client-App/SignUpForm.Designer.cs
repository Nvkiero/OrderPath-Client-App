using System.Windows.Forms;
namespace OrderPath_Client_App
{
    partial class SignUpForm : Form
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
            lb_DangKi = new Label();
            pn_FormDangKi = new Panel();
            bt_DangKi = new Button();
            tb_gmail = new TextBox();
            lb_gmail = new Label();
            lb_XacNhan = new Label();
            tb_XacNhan = new TextBox();
            tb_MatKhau = new TextBox();
            lb_PassWord = new Label();
            tb_HoTen = new TextBox();
            lb_TenDangNhap = new Label();
            tb_TenDangNhap = new TextBox();
            lb_HoTen = new Label();
            pn_FormDangKi.SuspendLayout();
            SuspendLayout();
            // 
            // lb_DangKi
            // 
            lb_DangKi.Font = new Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_DangKi.Location = new Point(13, 9);
            lb_DangKi.Name = "lb_DangKi";
            lb_DangKi.Size = new Size(522, 55);
            lb_DangKi.TabIndex = 0;
            lb_DangKi.Text = "Đăng kí";
            lb_DangKi.TextAlign = ContentAlignment.MiddleCenter;
            lb_DangKi.Click += lb_DangKi_Click;
            // 
            // pn_FormDangKi
            // 
            pn_FormDangKi.BackColor = Color.White;
            pn_FormDangKi.Controls.Add(bt_DangKi);
            pn_FormDangKi.Controls.Add(tb_gmail);
            pn_FormDangKi.Controls.Add(lb_gmail);
            pn_FormDangKi.Controls.Add(lb_XacNhan);
            pn_FormDangKi.Controls.Add(tb_XacNhan);
            pn_FormDangKi.Controls.Add(tb_MatKhau);
            pn_FormDangKi.Controls.Add(lb_PassWord);
            pn_FormDangKi.Controls.Add(tb_HoTen);
            pn_FormDangKi.Controls.Add(lb_TenDangNhap);
            pn_FormDangKi.Controls.Add(tb_TenDangNhap);
            pn_FormDangKi.Controls.Add(lb_HoTen);
            pn_FormDangKi.Controls.Add(lb_DangKi);
            pn_FormDangKi.Location = new Point(-1, 0);
            pn_FormDangKi.Name = "pn_FormDangKi";
            pn_FormDangKi.Size = new Size(549, 657);
            pn_FormDangKi.TabIndex = 1;
            // 
            // bt_DangKi
            // 
            bt_DangKi.Location = new Point(159, 562);
            bt_DangKi.Name = "bt_DangKi";
            bt_DangKi.Size = new Size(206, 50);
            bt_DangKi.TabIndex = 11;
            bt_DangKi.Text = "Đăng kí";
            bt_DangKi.UseVisualStyleBackColor = true;
            bt_DangKi.Click += bt_DangKi_Click;
            // 
            // tb_gmail
            // 
            tb_gmail.Location = new Point(273, 459);
            tb_gmail.Name = "tb_gmail";
            tb_gmail.Size = new Size(262, 35);
            tb_gmail.TabIndex = 10;
            // 
            // lb_gmail
            // 
            lb_gmail.Location = new Point(13, 456);
            lb_gmail.Name = "lb_gmail";
            lb_gmail.Size = new Size(210, 38);
            lb_gmail.TabIndex = 9;
            lb_gmail.Text = "Gmail";
            lb_gmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_XacNhan
            // 
            lb_XacNhan.Location = new Point(13, 373);
            lb_XacNhan.Name = "lb_XacNhan";
            lb_XacNhan.Size = new Size(210, 38);
            lb_XacNhan.TabIndex = 8;
            lb_XacNhan.Text = "Xác nhận mật khẩu";
            lb_XacNhan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_XacNhan
            // 
            tb_XacNhan.Location = new Point(273, 373);
            tb_XacNhan.Name = "tb_XacNhan";
            tb_XacNhan.Size = new Size(262, 35);
            tb_XacNhan.TabIndex = 7;
            // 
            // tb_MatKhau
            // 
            tb_MatKhau.Location = new Point(273, 288);
            tb_MatKhau.Name = "tb_MatKhau";
            tb_MatKhau.Size = new Size(262, 35);
            tb_MatKhau.TabIndex = 6;
            // 
            // lb_PassWord
            // 
            lb_PassWord.Location = new Point(13, 288);
            lb_PassWord.Name = "lb_PassWord";
            lb_PassWord.Size = new Size(172, 38);
            lb_PassWord.TabIndex = 5;
            lb_PassWord.Text = "Mật khẩu";
            lb_PassWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_HoTen
            // 
            tb_HoTen.Location = new Point(273, 130);
            tb_HoTen.Name = "tb_HoTen";
            tb_HoTen.Size = new Size(262, 35);
            tb_HoTen.TabIndex = 4;
            // 
            // lb_TenDangNhap
            // 
            lb_TenDangNhap.Location = new Point(13, 207);
            lb_TenDangNhap.Name = "lb_TenDangNhap";
            lb_TenDangNhap.Size = new Size(172, 38);
            lb_TenDangNhap.TabIndex = 3;
            lb_TenDangNhap.Text = "Tên Đăng Nhập";
            lb_TenDangNhap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_TenDangNhap
            // 
            tb_TenDangNhap.Location = new Point(273, 207);
            tb_TenDangNhap.Name = "tb_TenDangNhap";
            tb_TenDangNhap.Size = new Size(262, 35);
            tb_TenDangNhap.TabIndex = 2;
            // 
            // lb_HoTen
            // 
            lb_HoTen.Location = new Point(13, 130);
            lb_HoTen.Name = "lb_HoTen";
            lb_HoTen.Size = new Size(172, 38);
            lb_HoTen.TabIndex = 1;
            lb_HoTen.Text = "Họ Tên";
            lb_HoTen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 656);
            Controls.Add(pn_FormDangKi);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SignUpForm";
            Text = "Đăng ký";
            Load += SignUpForm_Load;
            pn_FormDangKi.ResumeLayout(false);
            pn_FormDangKi.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lb_DangKi;
        private Panel pn_FormDangKi;
        private TextBox tb_TenDangNhap;
        private Label lb_HoTen;
        private Label lb_TenDangNhap;
        private TextBox tb_HoTen;
        private TextBox tb_MatKhau;
        private Label lb_PassWord;
        private Label lb_XacNhan;
        private TextBox tb_XacNhan;
        private TextBox tb_gmail;
        private Label lb_gmail;
        private Button bt_DangKi;
    }

}
