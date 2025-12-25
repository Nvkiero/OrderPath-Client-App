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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
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
            pbx_productImg = new PictureBox();
            btn_browseImg = new Button();
            ((System.ComponentModel.ISupportInitialize)num_productQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_productImg).BeginInit();
            SuspendLayout();
            // 
            // txb_productCategory
            // 
            resources.ApplyResources(txb_productCategory, "txb_productCategory");
            txb_productCategory.Name = "txb_productCategory";
            // 
            // txb_productDescribtion
            // 
            resources.ApplyResources(txb_productDescribtion, "txb_productDescribtion");
            txb_productDescribtion.Name = "txb_productDescribtion";
            // 
            // txb_productImgUrl
            // 
            resources.ApplyResources(txb_productImgUrl, "txb_productImgUrl");
            txb_productImgUrl.Name = "txb_productImgUrl";
            // 
            // lb_Age
            // 
            resources.ApplyResources(lb_Age, "lb_Age");
            lb_Age.Name = "lb_Age";
            // 
            // lb_phone
            // 
            resources.ApplyResources(lb_phone, "lb_phone");
            lb_phone.Name = "lb_phone";
            // 
            // lb_usrname
            // 
            resources.ApplyResources(lb_usrname, "lb_usrname");
            lb_usrname.Name = "lb_usrname";
            // 
            // lb_email
            // 
            resources.ApplyResources(lb_email, "lb_email");
            lb_email.Name = "lb_email";
            // 
            // lb_ngaySinh
            // 
            resources.ApplyResources(lb_ngaySinh, "lb_ngaySinh");
            lb_ngaySinh.Name = "lb_ngaySinh";
            // 
            // lb_Fullname
            // 
            resources.ApplyResources(lb_Fullname, "lb_Fullname");
            lb_Fullname.Name = "lb_Fullname";
            // 
            // txb_productPrice
            // 
            resources.ApplyResources(txb_productPrice, "txb_productPrice");
            txb_productPrice.Name = "txb_productPrice";
            // 
            // txb_productName
            // 
            resources.ApplyResources(txb_productName, "txb_productName");
            txb_productName.Name = "txb_productName";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // bttn_productAdd
            // 
            resources.ApplyResources(bttn_productAdd, "bttn_productAdd");
            bttn_productAdd.Name = "bttn_productAdd";
            bttn_productAdd.UseVisualStyleBackColor = true;
            bttn_productAdd.Click += bttn_productAdd_Click;
            // 
            // num_productQuantity
            // 
            resources.ApplyResources(num_productQuantity, "num_productQuantity");
            num_productQuantity.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            num_productQuantity.Name = "num_productQuantity";
            // 
            // pbx_productImg
            // 
            resources.ApplyResources(pbx_productImg, "pbx_productImg");
            pbx_productImg.Name = "pbx_productImg";
            pbx_productImg.TabStop = false;
            // 
            // btn_browseImg
            // 
            resources.ApplyResources(btn_browseImg, "btn_browseImg");
            btn_browseImg.Name = "btn_browseImg";
            btn_browseImg.UseVisualStyleBackColor = true;
            btn_browseImg.Click += btn_browseImg_Click;
            // 
            // AddProduct
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_browseImg);
            Controls.Add(pbx_productImg);
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
            Load += AddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)num_productQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_productImg).EndInit();
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
        private PictureBox pbx_productImg;
        private Button btn_browseImg;
    }
}