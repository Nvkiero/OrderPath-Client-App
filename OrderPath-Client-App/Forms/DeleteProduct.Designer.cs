namespace OrderPath_Client_App.Forms.Sellers
{
    partial class DeleteProduct
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
            bttn_productDelete = new Button();
            label1 = new Label();
            lb_Fullname = new Label();
            txb_productID = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // bttn_productDelete
            // 
            bttn_productDelete.Font = new Font("Segoe UI", 18F);
            bttn_productDelete.Location = new Point(234, 232);
            bttn_productDelete.Name = "bttn_productDelete";
            bttn_productDelete.Size = new Size(310, 66);
            bttn_productDelete.TabIndex = 47;
            bttn_productDelete.Text = "Xóa";
            bttn_productDelete.UseVisualStyleBackColor = true;
            bttn_productDelete.Click += bttn_productDelete_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(273, 57);
            label1.TabIndex = 46;
            label1.Text = "Xóa Sản Phẩm";
            // 
            // lb_Fullname
            // 
            lb_Fullname.Font = new Font("Microsoft Sans Serif", 10F);
            lb_Fullname.Location = new Point(188, 153);
            lb_Fullname.Margin = new Padding(4, 0, 4, 0);
            lb_Fullname.Name = "lb_Fullname";
            lb_Fullname.Size = new Size(59, 33);
            lb_Fullname.TabIndex = 35;
            lb_Fullname.Text = "ID";
            // 
            // txb_productID
            // 
            txb_productID.Location = new Point(254, 153);
            txb_productID.Name = "txb_productID";
            txb_productID.Size = new Size(293, 31);
            txb_productID.TabIndex = 41;
            txb_productID.TextChanged += txb_productName_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.Location = new Point(221, 92);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(354, 33);
            label2.TabIndex = 48;
            label2.Text = "Vui lòng nhập ID sản phẩm cần xóa";
            // 
            // DeleteProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 356);
            Controls.Add(label2);
            Controls.Add(bttn_productDelete);
            Controls.Add(label1);
            Controls.Add(lb_Fullname);
            Controls.Add(txb_productID);
            Name = "DeleteProduct";
            Text = "DeleteProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttn_productDelete;
        private Label label1;
        private Label lb_Fullname;
        private TextBox txb_productID;
        private Label label2;
    }
}