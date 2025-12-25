namespace OrderPath_Client_App.Forms
{
    partial class ProductDetail
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
            pbx_productImg = new PictureBox();
            num_productQuantity = new NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)pbx_productImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_productQuantity).BeginInit();
            SuspendLayout();
            // 
            // pbx_productImg
            // 
            pbx_productImg.ImeMode = ImeMode.NoControl;
            pbx_productImg.Location = new Point(794, 165);
            pbx_productImg.Name = "pbx_productImg";
            pbx_productImg.Size = new Size(159, 178);
            pbx_productImg.TabIndex = 51;
            pbx_productImg.TabStop = false;
            // 
            // num_productQuantity
            // 
            num_productQuantity.Location = new Point(449, 286);
            num_productQuantity.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            num_productQuantity.Name = "num_productQuantity";
            num_productQuantity.ReadOnly = true;
            num_productQuantity.Size = new Size(293, 31);
            num_productQuantity.TabIndex = 50;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(413, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(397, 57);
            label1.TabIndex = 48;
            label1.Text = "Thông tin sản phẩm";
            // 
            // txb_productCategory
            // 
            txb_productCategory.Location = new Point(449, 408);
            txb_productCategory.Name = "txb_productCategory";
            txb_productCategory.ReadOnly = true;
            txb_productCategory.Size = new Size(293, 31);
            txb_productCategory.TabIndex = 47;
            // 
            // txb_productDescribtion
            // 
            txb_productDescribtion.Location = new Point(449, 467);
            txb_productDescribtion.Multiline = true;
            txb_productDescribtion.Name = "txb_productDescribtion";
            txb_productDescribtion.ReadOnly = true;
            txb_productDescribtion.Size = new Size(520, 85);
            txb_productDescribtion.TabIndex = 46;
            // 
            // txb_productImgUrl
            // 
            txb_productImgUrl.Location = new Point(449, 345);
            txb_productImgUrl.Name = "txb_productImgUrl";
            txb_productImgUrl.ReadOnly = true;
            txb_productImgUrl.Size = new Size(293, 31);
            txb_productImgUrl.TabIndex = 45;
            // 
            // lb_Age
            // 
            lb_Age.ImeMode = ImeMode.NoControl;
            lb_Age.Location = new Point(214, 415);
            lb_Age.Margin = new Padding(4, 0, 4, 0);
            lb_Age.Name = "lb_Age";
            lb_Age.Size = new Size(164, 33);
            lb_Age.TabIndex = 42;
            lb_Age.Text = "Danh mục";
            // 
            // lb_phone
            // 
            lb_phone.ImeMode = ImeMode.NoControl;
            lb_phone.Location = new Point(214, 474);
            lb_phone.Margin = new Padding(4, 0, 4, 0);
            lb_phone.Name = "lb_phone";
            lb_phone.Size = new Size(164, 33);
            lb_phone.TabIndex = 41;
            lb_phone.Text = "Mô tả";
            // 
            // lb_usrname
            // 
            lb_usrname.ImeMode = ImeMode.NoControl;
            lb_usrname.Location = new Point(214, 352);
            lb_usrname.Margin = new Padding(4, 0, 4, 0);
            lb_usrname.Name = "lb_usrname";
            lb_usrname.Size = new Size(164, 33);
            lb_usrname.TabIndex = 40;
            lb_usrname.Text = "Link ảnh";
            // 
            // lb_email
            // 
            lb_email.ImeMode = ImeMode.NoControl;
            lb_email.Location = new Point(214, 292);
            lb_email.Margin = new Padding(4, 0, 4, 0);
            lb_email.Name = "lb_email";
            lb_email.Size = new Size(164, 33);
            lb_email.TabIndex = 39;
            lb_email.Text = "Tồn kho";
            // 
            // lb_ngaySinh
            // 
            lb_ngaySinh.ImeMode = ImeMode.NoControl;
            lb_ngaySinh.Location = new Point(214, 232);
            lb_ngaySinh.Margin = new Padding(4, 0, 4, 0);
            lb_ngaySinh.Name = "lb_ngaySinh";
            lb_ngaySinh.Size = new Size(164, 33);
            lb_ngaySinh.TabIndex = 38;
            lb_ngaySinh.Text = "Giá";
            // 
            // lb_Fullname
            // 
            lb_Fullname.Font = new Font("Microsoft Sans Serif", 8.25F);
            lb_Fullname.ImeMode = ImeMode.NoControl;
            lb_Fullname.Location = new Point(214, 172);
            lb_Fullname.Margin = new Padding(4, 0, 4, 0);
            lb_Fullname.Name = "lb_Fullname";
            lb_Fullname.Size = new Size(164, 33);
            lb_Fullname.TabIndex = 37;
            lb_Fullname.Text = "Tên sản phẩm";
            // 
            // txb_productPrice
            // 
            txb_productPrice.Location = new Point(449, 229);
            txb_productPrice.Name = "txb_productPrice";
            txb_productPrice.ReadOnly = true;
            txb_productPrice.Size = new Size(293, 31);
            txb_productPrice.TabIndex = 44;
            // 
            // txb_productName
            // 
            txb_productName.Location = new Point(449, 165);
            txb_productName.Name = "txb_productName";
            txb_productName.ReadOnly = true;
            txb_productName.Size = new Size(293, 31);
            txb_productName.TabIndex = 43;
            // 
            // ProductDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 690);
            Controls.Add(pbx_productImg);
            Controls.Add(num_productQuantity);
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
            Name = "ProductDetail";
            Text = "ProductDetail";
            ((System.ComponentModel.ISupportInitialize)pbx_productImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_productQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbx_productImg;
        private NumericUpDown num_productQuantity;
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
    }
}