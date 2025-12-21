namespace OrderPath_Client_App.Forms
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnSendOTP = new Button();
            lblOTP = new Label();
            lblNewPassword = new Label();
            txtOTP = new TextBox();
            btnConfirmnNewPass = new Button();
            lblFogotPassword = new Label();
            txtNewPassword = new TextBox();
            pbNewPass = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbNewPass).BeginInit();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(24, 66);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email: ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(167, 59);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(276, 27);
            txtEmail.TabIndex = 1;
            // 
            // btnSendOTP
            // 
            btnSendOTP.Location = new Point(449, 57);
            btnSendOTP.Name = "btnSendOTP";
            btnSendOTP.Size = new Size(94, 29);
            btnSendOTP.TabIndex = 2;
            btnSendOTP.Text = "Gửi OTP";
            btnSendOTP.UseVisualStyleBackColor = true;
            btnSendOTP.Click += btnSendOTP_Click;
            // 
            // lblOTP
            // 
            lblOTP.AutoSize = true;
            lblOTP.Location = new Point(24, 99);
            lblOTP.Name = "lblOTP";
            lblOTP.Size = new Size(42, 20);
            lblOTP.TabIndex = 3;
            lblOTP.Text = "OTP: ";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(24, 132);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(107, 20);
            lblNewPassword.TabIndex = 4;
            lblNewPassword.Text = "Mật khẩu mới: ";
            // 
            // txtOTP
            // 
            txtOTP.Location = new Point(167, 92);
            txtOTP.Name = "txtOTP";
            txtOTP.Size = new Size(170, 27);
            txtOTP.TabIndex = 5;
            // 
            // btnConfirmnNewPass
            // 
            btnConfirmnNewPass.Location = new Point(167, 158);
            btnConfirmnNewPass.Name = "btnConfirmnNewPass";
            btnConfirmnNewPass.Size = new Size(94, 29);
            btnConfirmnNewPass.TabIndex = 7;
            btnConfirmnNewPass.Text = "Xác nhận";
            btnConfirmnNewPass.UseVisualStyleBackColor = true;
            btnConfirmnNewPass.Click += btnConfirmnNewPass_Click;
            // 
            // lblFogotPassword
            // 
            lblFogotPassword.AutoSize = true;
            lblFogotPassword.Font = new Font("Segoe UI", 12F);
            lblFogotPassword.Location = new Point(167, 19);
            lblFogotPassword.Name = "lblFogotPassword";
            lblFogotPassword.Size = new Size(170, 28);
            lblFogotPassword.TabIndex = 8;
            lblFogotPassword.Text = "QUÊN MẬT KHẨU";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(167, 125);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(170, 27);
            txtNewPassword.TabIndex = 9;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // pbNewPass
            // 
            pbNewPass.Image = (Image)resources.GetObject("pbNewPass.Image");
            pbNewPass.Location = new Point(343, 125);
            pbNewPass.Name = "pbNewPass";
            pbNewPass.Size = new Size(27, 27);
            pbNewPass.SizeMode = PictureBoxSizeMode.Zoom;
            pbNewPass.TabIndex = 23;
            pbNewPass.TabStop = false;
            pbNewPass.Click += pbNewPass_Click;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 206);
            Controls.Add(pbNewPass);
            Controls.Add(txtNewPassword);
            Controls.Add(lblFogotPassword);
            Controls.Add(btnConfirmnNewPass);
            Controls.Add(txtOTP);
            Controls.Add(lblNewPassword);
            Controls.Add(lblOTP);
            Controls.Add(btnSendOTP);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Name = "ForgotPasswordForm";
            Text = "ForgotPassword";
            ((System.ComponentModel.ISupportInitialize)pbNewPass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnSendOTP;
        private Label lblOTP;
        private Label lblNewPassword;
        private TextBox txtOTP;
        private Button btnConfirmnNewPass;
        private Label lblFogotPassword;
        private TextBox txtNewPassword;
        private PictureBox pbNewPass;
    }
}