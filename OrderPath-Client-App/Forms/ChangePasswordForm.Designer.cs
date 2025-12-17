namespace OrderPath_Client_App.Forms
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            txtNewPass = new TextBox();
            lblChangePassword = new Label();
            btnConfirmnNewPass = new Button();
            txtOldPass = new TextBox();
            lblNewPassword = new Label();
            lblOldPassword = new Label();
            txtConfirmPass = new TextBox();
            lblConfirmNewPassword = new Label();
            pbOldPass = new PictureBox();
            pbNewPass = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbOldPass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNewPass).BeginInit();
            SuspendLayout();
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(186, 105);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(219, 27);
            txtNewPass.TabIndex = 18;
            txtNewPass.UseSystemPasswordChar = true;
            // 
            // lblChangePassword
            // 
            lblChangePassword.AutoSize = true;
            lblChangePassword.Font = new Font("Segoe UI", 12F);
            lblChangePassword.Location = new Point(183, 27);
            lblChangePassword.Name = "lblChangePassword";
            lblChangePassword.Size = new Size(150, 28);
            lblChangePassword.TabIndex = 17;
            lblChangePassword.Text = "ĐỔI MẬT KHẨU";
            // 
            // btnConfirmnNewPass
            // 
            btnConfirmnNewPass.Location = new Point(183, 180);
            btnConfirmnNewPass.Name = "btnConfirmnNewPass";
            btnConfirmnNewPass.Size = new Size(94, 29);
            btnConfirmnNewPass.TabIndex = 16;
            btnConfirmnNewPass.Text = "Xác nhận";
            btnConfirmnNewPass.UseVisualStyleBackColor = true;
            btnConfirmnNewPass.Click += btnConfirmnNewPass_Click;
            // 
            // txtOldPass
            // 
            txtOldPass.Location = new Point(186, 72);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.Size = new Size(219, 27);
            txtOldPass.TabIndex = 15;
            txtOldPass.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(26, 112);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(107, 20);
            lblNewPassword.TabIndex = 14;
            lblNewPassword.Text = "Mật khẩu mới: ";
            // 
            // lblOldPassword
            // 
            lblOldPassword.AutoSize = true;
            lblOldPassword.Location = new Point(26, 79);
            lblOldPassword.Name = "lblOldPassword";
            lblOldPassword.Size = new Size(96, 20);
            lblOldPassword.TabIndex = 13;
            lblOldPassword.Text = "Mật khẩu cũ: ";
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Location = new Point(186, 138);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(219, 27);
            txtConfirmPass.TabIndex = 20;
            txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // lblConfirmNewPassword
            // 
            lblConfirmNewPassword.AutoSize = true;
            lblConfirmNewPassword.Location = new Point(26, 145);
            lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            lblConfirmNewPassword.Size = new Size(141, 20);
            lblConfirmNewPassword.TabIndex = 19;
            lblConfirmNewPassword.Text = "Xác nhận mật khẩu: ";
            // 
            // pbOldPass
            // 
            pbOldPass.Image = (Image)resources.GetObject("pbOldPass.Image");
            pbOldPass.Location = new Point(411, 72);
            pbOldPass.Name = "pbOldPass";
            pbOldPass.Size = new Size(27, 27);
            pbOldPass.SizeMode = PictureBoxSizeMode.Zoom;
            pbOldPass.TabIndex = 21;
            pbOldPass.TabStop = false;
            pbOldPass.Click += pbOldPass_Click;
            // 
            // pbNewPass
            // 
            pbNewPass.Image = (Image)resources.GetObject("pbNewPass.Image");
            pbNewPass.Location = new Point(411, 105);
            pbNewPass.Name = "pbNewPass";
            pbNewPass.Size = new Size(27, 27);
            pbNewPass.SizeMode = PictureBoxSizeMode.Zoom;
            pbNewPass.TabIndex = 22;
            pbNewPass.TabStop = false;
            pbNewPass.Click += pbNewPass_Click;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 230);
            Controls.Add(pbNewPass);
            Controls.Add(pbOldPass);
            Controls.Add(txtConfirmPass);
            Controls.Add(lblConfirmNewPassword);
            Controls.Add(txtNewPass);
            Controls.Add(lblChangePassword);
            Controls.Add(btnConfirmnNewPass);
            Controls.Add(txtOldPass);
            Controls.Add(lblNewPassword);
            Controls.Add(lblOldPassword);
            Name = "ChangePasswordForm";
            Text = "ChangePassword";
            ((System.ComponentModel.ISupportInitialize)pbOldPass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNewPass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNewPass;
        private Label lblChangePassword;
        private Button btnConfirmnNewPass;
        private TextBox txtOldPass;
        private Label lblNewPassword;
        private Label lblOldPassword;
        private TextBox txtConfirmPass;
        private Label lblConfirmNewPassword;
        private PictureBox pbOldPass;
        private PictureBox pbNewPass;
    }
}