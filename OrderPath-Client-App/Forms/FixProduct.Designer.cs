namespace OrderPath_Client_App.Forms.Sellers
{
    partial class FixProduct
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
            num_productQuantity = new NumericUpDown();
            bttn_productFix = new Button();
            label1 = new Label();
            txb_productCategory = new TextBox();
            txb_productDescribtion = new TextBox();
            txb_productImgUrl = new TextBox();
            lb_Age = new Label();
            lb_phone = new Label();
            lb_usrname = new Label();
            lb_email = new Label();
            lb_ngaySinh = new Label();
            lb_Fullname = new Label();
            txb_productPrice = new TextBox();
            txb_productName = new TextBox();
            label2 = new Label();
            txb_productID = new TextBox();
            pbx_productImg = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)num_productQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_productImg).BeginInit();
            SuspendLayout();
            // 
            // num_productQuantity
            // 
            num_productQuantity.Location = new Point(470, 295);
            num_productQuantity.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            num_productQuantity.Name = "num_productQuantity";
            num_productQuantity.Size = new Size(293, 31);
            num_productQuantity.TabIndex = 48;
            // 
            // bttn_productFix
            // 
            bttn_productFix.Font = new Font("Segoe UI", 18F);
            bttn_productFix.Location = new Point(453, 591);
            bttn_productFix.Name = "bttn_productFix";
            bttn_productFix.Size = new Size(310, 63);
            bttn_productFix.TabIndex = 47;
            bttn_productFix.Text = "Sửa";
            bttn_productFix.UseVisualStyleBackColor = true;
            bttn_productFix.Click += bttn_productFix_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(445, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(397, 54);
            label1.TabIndex = 46;
            label1.Text = "SỬA SẢN PHẨM";
            // 
            // txb_productCategory
            // 
            txb_productCategory.Location = new Point(470, 417);
            txb_productCategory.Name = "txb_productCategory";
            txb_productCategory.Size = new Size(293, 31);
            txb_productCategory.TabIndex = 45;
            // 
            // txb_productDescribtion
            // 
            txb_productDescribtion.Location = new Point(470, 476);
            txb_productDescribtion.Multiline = true;
            txb_productDescribtion.Name = "txb_productDescribtion";
            txb_productDescribtion.Size = new Size(520, 82);
            txb_productDescribtion.TabIndex = 44;
            // 
            // txb_productImgUrl
            // 
            txb_productImgUrl.Location = new Point(470, 354);
            txb_productImgUrl.Name = "txb_productImgUrl";
            txb_productImgUrl.Size = new Size(293, 31);
            txb_productImgUrl.TabIndex = 43;
            // 
            // lb_Age
            // 
            lb_Age.Location = new Point(235, 424);
            lb_Age.Margin = new Padding(4, 0, 4, 0);
            lb_Age.Name = "lb_Age";
            lb_Age.Size = new Size(164, 30);
            lb_Age.TabIndex = 40;
            lb_Age.Text = "Danh mục";
            // 
            // lb_phone
            // 
            lb_phone.Location = new Point(235, 483);
            lb_phone.Margin = new Padding(4, 0, 4, 0);
            lb_phone.Name = "lb_phone";
            lb_phone.Size = new Size(164, 30);
            lb_phone.TabIndex = 39;
            lb_phone.Text = "Mô tả";
            // 
            // lb_usrname
            // 
            lb_usrname.Location = new Point(235, 361);
            lb_usrname.Margin = new Padding(4, 0, 4, 0);
            lb_usrname.Name = "lb_usrname";
            lb_usrname.Size = new Size(164, 30);
            lb_usrname.TabIndex = 38;
            lb_usrname.Text = "Link ảnh";
            // 
            // lb_email
            // 
            lb_email.Location = new Point(235, 301);
            lb_email.Margin = new Padding(4, 0, 4, 0);
            lb_email.Name = "lb_email";
            lb_email.Size = new Size(164, 30);
            lb_email.TabIndex = 37;
            lb_email.Text = "Tồn kho";
            // 
            // lb_ngaySinh
            // 
            lb_ngaySinh.Location = new Point(235, 241);
            lb_ngaySinh.Margin = new Padding(4, 0, 4, 0);
            lb_ngaySinh.Name = "lb_ngaySinh";
            lb_ngaySinh.Size = new Size(164, 30);
            lb_ngaySinh.TabIndex = 36;
            lb_ngaySinh.Text = "Giá";
            // 
            // lb_Fullname
            // 
            lb_Fullname.Font = new Font("Microsoft Sans Serif", 8.25F);
            lb_Fullname.Location = new Point(235, 181);
            lb_Fullname.Margin = new Padding(4, 0, 4, 0);
            lb_Fullname.Name = "lb_Fullname";
            lb_Fullname.Size = new Size(164, 30);
            lb_Fullname.TabIndex = 35;
            lb_Fullname.Text = "Tên sản phẩm";
            // 
            // txb_productPrice
            // 
            txb_productPrice.Location = new Point(470, 238);
            txb_productPrice.Name = "txb_productPrice";
            txb_productPrice.Size = new Size(293, 31);
            txb_productPrice.TabIndex = 42;
            // 
            // txb_productName
            // 
            txb_productName.Location = new Point(470, 174);
            txb_productName.Name = "txb_productName";
            txb_productName.Size = new Size(293, 31);
            txb_productName.TabIndex = 41;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.Location = new Point(235, 128);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(164, 30);
            label2.TabIndex = 49;
            label2.Text = "ID";
            // 
            // txb_productID
            // 
            txb_productID.Location = new Point(470, 121);
            txb_productID.Name = "txb_productID";
            txb_productID.Size = new Size(293, 31);
            txb_productID.TabIndex = 50;
            // 
            // pbx_productImg
            // 
            pbx_productImg.ImeMode = ImeMode.NoControl;
            pbx_productImg.Location = new Point(831, 121);
            pbx_productImg.Name = "pbx_productImg";
            pbx_productImg.Size = new Size(159, 178);
            pbx_productImg.TabIndex = 51;
            pbx_productImg.TabStop = false;
            // 
            // FixProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 702);
            Controls.Add(pbx_productImg);
            Controls.Add(label2);
            Controls.Add(txb_productID);
            Controls.Add(num_productQuantity);
            Controls.Add(bttn_productFix);
            Controls.Add(label1);
            Controls.Add(txb_productCategory);
            Controls.Add(txb_productDescribtion);
            Controls.Add(txb_productImgUrl);
            Controls.Add(lb_Age);
            Controls.Add(lb_phone);
            Controls.Add(lb_usrname);
            Controls.Add(lb_email);
            Controls.Add(lb_ngaySinh);
            Controls.Add(lb_Fullname);
            Controls.Add(txb_productPrice);
            Controls.Add(txb_productName);
            Name = "FixProduct";
            Text = "FixProduct";
            ((System.ComponentModel.ISupportInitialize)num_productQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_productImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown num_productQuantity;
        private Button bttn_productFix;
        private Label label1;
        private TextBox txb_productCategory;
        private TextBox txb_productDescribtion;
        private TextBox txb_productImgUrl;
        private Label lb_Age;
        private Label lb_phone;
        private Label lb_usrname;
        private Label lb_email;
        private Label lb_ngaySinh;
        private Label lb_Fullname;
        private TextBox txb_productPrice;
        private TextBox txb_productName;
        private Label label2;
        private TextBox txb_productID;
        private PictureBox pbx_productImg;
    }
}