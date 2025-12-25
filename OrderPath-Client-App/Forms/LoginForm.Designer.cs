namespace OrderPath_Client_App
{
    partial class LoginForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pb_exit = new PictureBox();
            lb_TenDangNhap = new Label();
            tb_TenDangNhap = new TextBox();
            pn_LoginForm = new Panel();
            lblForgotPassword = new Label();
            bt_DangKy = new Button();
            label1 = new Label();
            lb_Hoac = new Label();
            bt_DangNhap = new Button();
            panel3 = new Panel();
            pb_PassWordChar = new PictureBox();
            lb_MatKhau = new Label();
            tb_MatKhau = new TextBox();
            pn_DangNhap = new Panel();
            lb_TieuDe = new Label();
            pb_HinhNen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_exit).BeginInit();
            pn_LoginForm.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_PassWordChar).BeginInit();
            pn_DangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_HinhNen).BeginInit();
            SuspendLayout();
            // 
            // pb_exit
            // 
            pb_exit.Image = (Image)resources.GetObject("pb_exit.Image");
            pb_exit.Location = new Point(330, 3);
            pb_exit.Name = "pb_exit";
            pb_exit.Size = new Size(137, 121);
            pb_exit.SizeMode = PictureBoxSizeMode.CenterImage;
            pb_exit.TabIndex = 1;
            pb_exit.TabStop = false;
            pb_exit.Click += pb_exit_click;
            // 
            // lb_TenDangNhap
            // 
            lb_TenDangNhap.BackColor = SystemColors.ButtonFace;
            lb_TenDangNhap.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_TenDangNhap.ForeColor = Color.Black;
            lb_TenDangNhap.Location = new Point(0, 3);
            lb_TenDangNhap.Name = "lb_TenDangNhap";
            lb_TenDangNhap.Size = new Size(339, 121);
            lb_TenDangNhap.TabIndex = 2;
            lb_TenDangNhap.Text = "Đăng Nhập";
            lb_TenDangNhap.TextAlign = ContentAlignment.MiddleCenter;
            lb_TenDangNhap.Click += lb_TenDangNhap_Click;
            // 
            // tb_TenDangNhap
            // 
            tb_TenDangNhap.BackColor = Color.WhiteSmoke;
            tb_TenDangNhap.BorderStyle = BorderStyle.FixedSingle;
            tb_TenDangNhap.Location = new Point(0, 0);
            tb_TenDangNhap.Multiline = true;
            tb_TenDangNhap.Name = "tb_TenDangNhap";
            tb_TenDangNhap.Size = new Size(360, 35);
            tb_TenDangNhap.TabIndex = 4;
            tb_TenDangNhap.TextChanged += tb_TenDangNhap_TextChanged;
            tb_TenDangNhap.MouseEnter += tb_TenDangNhap_Enter;
            tb_TenDangNhap.MouseLeave += tb_TenDangNhap_Leave;
            // 
            // pn_LoginForm
            // 
            pn_LoginForm.BackColor = Color.White;
            pn_LoginForm.Controls.Add(lblForgotPassword);
            pn_LoginForm.Controls.Add(bt_DangKy);
            pn_LoginForm.Controls.Add(label1);
            pn_LoginForm.Controls.Add(pb_exit);
            pn_LoginForm.Controls.Add(lb_Hoac);
            pn_LoginForm.Controls.Add(bt_DangNhap);
            pn_LoginForm.Controls.Add(panel3);
            pn_LoginForm.Controls.Add(pn_DangNhap);
            pn_LoginForm.Controls.Add(lb_TenDangNhap);
            pn_LoginForm.Location = new Point(732, 83);
            pn_LoginForm.Name = "pn_LoginForm";
            pn_LoginForm.Size = new Size(470, 523);
            pn_LoginForm.TabIndex = 4;
            pn_LoginForm.Paint += panel1_Paint;
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.BackColor = Color.Transparent;
            lblForgotPassword.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblForgotPassword.ForeColor = Color.Gray;
            lblForgotPassword.Location = new Point(42, 327);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(203, 41);
            lblForgotPassword.TabIndex = 11;
            lblForgotPassword.Text = "Quên mật khẩu?";
            lblForgotPassword.TextAlign = ContentAlignment.MiddleLeft;
            lblForgotPassword.Click += lblForgotPassword_Click;
            // 
            // bt_DangKy
            // 
            bt_DangKy.BackColor = SystemColors.Control;
            bt_DangKy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_DangKy.ForeColor = Color.FromArgb(255, 128, 0);
            bt_DangKy.Location = new Point(253, 451);
            bt_DangKy.Name = "bt_DangKy";
            bt_DangKy.Size = new Size(156, 32);
            bt_DangKy.TabIndex = 10;
            bt_DangKy.Text = "Đăng ký";
            bt_DangKy.UseVisualStyleBackColor = false;
            bt_DangKy.Click += bt_DangKy_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(42, 447);
            label1.Name = "label1";
            label1.Size = new Size(203, 41);
            label1.TabIndex = 9;
            label1.Text = "Bạn chưa từng sử dụng?";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lb_Hoac
            // 
            lb_Hoac.BackColor = Color.Transparent;
            lb_Hoac.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Hoac.ForeColor = Color.Gray;
            lb_Hoac.Location = new Point(42, 395);
            lb_Hoac.Name = "lb_Hoac";
            lb_Hoac.Size = new Size(360, 53);
            lb_Hoac.TabIndex = 8;
            lb_Hoac.Text = "----------Hoặc----------";
            lb_Hoac.TextAlign = ContentAlignment.MiddleCenter;
            lb_Hoac.Click += lb_Hoac_Click;
            // 
            // bt_DangNhap
            // 
            bt_DangNhap.BackColor = Color.FromArgb(255, 128, 0);
            bt_DangNhap.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_DangNhap.ForeColor = Color.Transparent;
            bt_DangNhap.Location = new Point(42, 257);
            bt_DangNhap.Name = "bt_DangNhap";
            bt_DangNhap.Size = new Size(360, 47);
            bt_DangNhap.TabIndex = 7;
            bt_DangNhap.Text = "Đăng nhập";
            bt_DangNhap.UseVisualStyleBackColor = false;
            bt_DangNhap.Click += bt_DangNhap_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pb_PassWordChar);
            panel3.Controls.Add(lb_MatKhau);
            panel3.Controls.Add(tb_MatKhau);
            panel3.Location = new Point(42, 203);
            panel3.Name = "panel3";
            panel3.Size = new Size(360, 35);
            panel3.TabIndex = 6;
            panel3.Paint += panel3_Paint;
            // 
            // pb_PassWordChar
            // 
            pb_PassWordChar.Image = (Image)resources.GetObject("pb_PassWordChar.Image");
            pb_PassWordChar.Location = new Point(325, 0);
            pb_PassWordChar.Name = "pb_PassWordChar";
            pb_PassWordChar.Size = new Size(35, 35);
            pb_PassWordChar.SizeMode = PictureBoxSizeMode.Zoom;
            pb_PassWordChar.TabIndex = 11;
            pb_PassWordChar.TabStop = false;
            pb_PassWordChar.Click += pb_PassWordChar_Click;
            // 
            // lb_MatKhau
            // 
            lb_MatKhau.AutoSize = true;
            lb_MatKhau.BackColor = Color.WhiteSmoke;
            lb_MatKhau.ForeColor = Color.Gray;
            lb_MatKhau.Location = new Point(16, 2);
            lb_MatKhau.Name = "lb_MatKhau";
            lb_MatKhau.Size = new Size(104, 27);
            lb_MatKhau.TabIndex = 4;
            lb_MatKhau.Text = "Mật khẩu";
            lb_MatKhau.Click += lb_MatKhau_Click;
            // 
            // tb_MatKhau
            // 
            tb_MatKhau.BackColor = Color.WhiteSmoke;
            tb_MatKhau.BorderStyle = BorderStyle.FixedSingle;
            tb_MatKhau.Location = new Point(0, 0);
            tb_MatKhau.Multiline = true;
            tb_MatKhau.Name = "tb_MatKhau";
            tb_MatKhau.PasswordChar = '*';
            tb_MatKhau.Size = new Size(360, 35);
            tb_MatKhau.TabIndex = 5;
            tb_MatKhau.TextChanged += tb_MatKhau_TextChanged;
            tb_MatKhau.MouseEnter += tb_MatKhau_Enter;
            tb_MatKhau.MouseLeave += tb_MatKhau_Leave;
            // 
            // pn_DangNhap
            // 
            pn_DangNhap.Controls.Add(lb_TieuDe);
            pn_DangNhap.Controls.Add(tb_TenDangNhap);
            pn_DangNhap.Location = new Point(42, 151);
            pn_DangNhap.Name = "pn_DangNhap";
            pn_DangNhap.Size = new Size(360, 35);
            pn_DangNhap.TabIndex = 5;
            // 
            // lb_TieuDe
            // 
            lb_TieuDe.AutoSize = true;
            lb_TieuDe.BackColor = Color.WhiteSmoke;
            lb_TieuDe.ForeColor = Color.Gray;
            lb_TieuDe.Location = new Point(16, 2);
            lb_TieuDe.Name = "lb_TieuDe";
            lb_TieuDe.Size = new Size(154, 27);
            lb_TieuDe.TabIndex = 4;
            lb_TieuDe.Text = "Tên đăng nhập";
            lb_TieuDe.Click += label1_Click;
            // 
            // pb_HinhNen
            // 
            pb_HinhNen.Image = (Image)resources.GetObject("pb_HinhNen.Image");
            pb_HinhNen.Location = new Point(137, 83);
            pb_HinhNen.Name = "pb_HinhNen";
            pb_HinhNen.Size = new Size(387, 564);
            pb_HinhNen.SizeMode = PictureBoxSizeMode.Zoom;
            pb_HinhNen.TabIndex = 5;
            pb_HinhNen.TabStop = false;
            pb_HinhNen.Click += pb_HinhNen_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1234, 672);
            Controls.Add(pb_HinhNen);
            Controls.Add(pn_LoginForm);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginForm";
            Text = "Đăng Nhập";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pb_exit).EndInit();
            pn_LoginForm.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_PassWordChar).EndInit();
            pn_DangNhap.ResumeLayout(false);
            pn_DangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_HinhNen).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pb_exit;
        private Label lb_TenDangNhap;
        private TextBox tb_TenDangNhap;
        private Panel pn_LoginForm;
        private Label lb_TieuDe;
        private Panel pn_DangNhap;
        private Panel panel3;
        private Label lb_MatKhau;
        private TextBox tb_MatKhau;
        private Button bt_DangNhap;
        private Button bt_DangKy;
        private Label label1;
        private Label lb_Hoac;
        private PictureBox pb_HinhNen;
        private PictureBox pb_PassWordChar;
        private Label lblForgotPassword;
    }
}
