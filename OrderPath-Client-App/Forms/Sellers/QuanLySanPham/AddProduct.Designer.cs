namespace OrderPath_Client_App.Forms.Sellers
{
    partial class AddProduct
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
            label1 = new Label();
            bttn_productAdd = new Button();
            num_productQuantity = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)num_productQuantity).BeginInit();
            SuspendLayout();
            // 
            // txb_productCategory
            // 
            txb_productCategory.Location = new Point(279, 359);
            txb_productCategory.Name = "txb_productCategory";
            txb_productCategory.Size = new Size(293, 31);
            txb_productCategory.TabIndex = 30;
            // 
            // txb_productDescribtion
            // 
            txb_productDescribtion.Location = new Point(279, 418);
            txb_productDescribtion.Multiline = true;
            txb_productDescribtion.Name = "txb_productDescribtion";
            txb_productDescribtion.Size = new Size(520, 85);
            txb_productDescribtion.TabIndex = 29;
            // 
            // txb_productImgUrl
            // 
            txb_productImgUrl.Location = new Point(279, 296);
            txb_productImgUrl.Name = "txb_productImgUrl";
            txb_productImgUrl.Size = new Size(293, 31);
            txb_productImgUrl.TabIndex = 28;
            // 
            // lb_Age
            // 
            lb_Age.Location = new Point(44, 366);
            lb_Age.Margin = new Padding(4, 0, 4, 0);
            lb_Age.Name = "lb_Age";
            lb_Age.Size = new Size(164, 33);
            lb_Age.TabIndex = 23;
            lb_Age.Text = "Danh mục";
            // 
            // lb_phone
            // 
            lb_phone.Location = new Point(44, 425);
            lb_phone.Margin = new Padding(4, 0, 4, 0);
            lb_phone.Name = "lb_phone";
            lb_phone.Size = new Size(164, 33);
            lb_phone.TabIndex = 22;
            lb_phone.Text = "Mô tả";
            // 
            // lb_usrname
            // 
            lb_usrname.Location = new Point(44, 303);
            lb_usrname.Margin = new Padding(4, 0, 4, 0);
            lb_usrname.Name = "lb_usrname";
            lb_usrname.Size = new Size(164, 33);
            lb_usrname.TabIndex = 21;
            lb_usrname.Text = "Link ảnh";
            // 
            // lb_email
            // 
            lb_email.Location = new Point(44, 243);
            lb_email.Margin = new Padding(4, 0, 4, 0);
            lb_email.Name = "lb_email";
            lb_email.Size = new Size(164, 33);
            lb_email.TabIndex = 20;
            lb_email.Text = "Tồn kho";
            // 
            // lb_ngaySinh
            // 
            lb_ngaySinh.Location = new Point(44, 183);
            lb_ngaySinh.Margin = new Padding(4, 0, 4, 0);
            lb_ngaySinh.Name = "lb_ngaySinh";
            lb_ngaySinh.Size = new Size(164, 33);
            lb_ngaySinh.TabIndex = 19;
            lb_ngaySinh.Text = "Giá";
            // 
            // lb_Fullname
            // 
            lb_Fullname.Font = new Font("Microsoft Sans Serif", 8.25F);
            lb_Fullname.Location = new Point(44, 123);
            lb_Fullname.Margin = new Padding(4, 0, 4, 0);
            lb_Fullname.Name = "lb_Fullname";
            lb_Fullname.Size = new Size(164, 33);
            lb_Fullname.TabIndex = 18;
            lb_Fullname.Text = "Tên sản phẩm";
            // 
            // txb_productPrice
            // 
            txb_productPrice.Location = new Point(279, 180);
            txb_productPrice.Name = "txb_productPrice";
            txb_productPrice.Size = new Size(293, 31);
            txb_productPrice.TabIndex = 26;
            // 
            // txb_productName
            // 
            txb_productName.Location = new Point(279, 116);
            txb_productName.Name = "txb_productName";
            txb_productName.Size = new Size(293, 31);
            txb_productName.TabIndex = 25;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(256, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(397, 57);
            label1.TabIndex = 32;
            label1.Text = "THÊM SẢN PHẨM";
            // 
            // bttn_productAdd
            // 
            bttn_productAdd.Font = new Font("Segoe UI", 18F);
            bttn_productAdd.Location = new Point(262, 533);
            bttn_productAdd.Name = "bttn_productAdd";
            bttn_productAdd.Size = new Size(310, 66);
            bttn_productAdd.TabIndex = 33;
            bttn_productAdd.Text = "Thêm";
            bttn_productAdd.UseVisualStyleBackColor = true;
            bttn_productAdd.Click += bttn_productAdd_Click;
            // 
            // num_productQuantity
            // 
            num_productQuantity.Location = new Point(279, 237);
            num_productQuantity.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            num_productQuantity.Name = "num_productQuantity";
            num_productQuantity.Size = new Size(293, 31);
            num_productQuantity.TabIndex = 34;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 639);
            Controls.Add(num_productQuantity);
            Controls.Add(bttn_productAdd);
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
            Name = "AddProduct";
            Text = "AddProduct";
            Load += AddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)num_productQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Label label1;
        private Button bttn_productAdd;
        private NumericUpDown num_productQuantity;
    }
}