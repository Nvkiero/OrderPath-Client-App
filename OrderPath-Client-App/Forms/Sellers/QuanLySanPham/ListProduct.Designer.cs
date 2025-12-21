namespace OrderPath_Client_App.Forms.Sellers
{
    partial class ListProduct
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
            bttn_getProductList = new Button();
            label1 = new Label();
            dgv_productList = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnPrice = new DataGridViewTextBoxColumn();
            ColumnQuantity = new DataGridViewTextBoxColumn();
            ColumnImg = new DataGridViewTextBoxColumn();
            ColumnStatus = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_productList).BeginInit();
            SuspendLayout();
            // 
            // bttn_getProductList
            // 
            bttn_getProductList.Font = new Font("Segoe UI", 15F);
            bttn_getProductList.Location = new Point(49, 84);
            bttn_getProductList.Name = "bttn_getProductList";
            bttn_getProductList.Size = new Size(133, 61);
            bttn_getProductList.TabIndex = 52;
            bttn_getProductList.Text = "Load";
            bttn_getProductList.UseVisualStyleBackColor = true;
            bttn_getProductList.Click += bttn_getProductList_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(341, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(367, 57);
            label1.TabIndex = 51;
            label1.Text = "Danh sách vật phẩm";
            // 
            // dgv_productList
            // 
            dgv_productList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_productList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_productList.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnName, ColumnPrice, ColumnQuantity, ColumnImg, ColumnStatus });
            dgv_productList.Location = new Point(25, 178);
            dgv_productList.Name = "dgv_productList";
            dgv_productList.RowHeadersWidth = 62;
            dgv_productList.Size = new Size(992, 346);
            dgv_productList.TabIndex = 53;
            // 
            // ColumnID
            // 
            ColumnID.HeaderText = "ID";
            ColumnID.MinimumWidth = 8;
            ColumnID.Name = "ColumnID";
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Name";
            ColumnName.MinimumWidth = 8;
            ColumnName.Name = "ColumnName";
            // 
            // ColumnPrice
            // 
            ColumnPrice.HeaderText = "Price";
            ColumnPrice.MinimumWidth = 8;
            ColumnPrice.Name = "ColumnPrice";
            // 
            // ColumnQuantity
            // 
            ColumnQuantity.HeaderText = "Quantity";
            ColumnQuantity.MinimumWidth = 8;
            ColumnQuantity.Name = "ColumnQuantity";
            // 
            // ColumnImg
            // 
            ColumnImg.HeaderText = "Image";
            ColumnImg.MinimumWidth = 8;
            ColumnImg.Name = "ColumnImg";
            // 
            // ColumnStatus
            // 
            ColumnStatus.HeaderText = "Status";
            ColumnStatus.MinimumWidth = 8;
            ColumnStatus.Name = "ColumnStatus";
            // 
            // ListProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 548);
            Controls.Add(dgv_productList);
            Controls.Add(bttn_getProductList);
            Controls.Add(label1);
            Name = "ListProduct";
            Text = "ListProduct";
            ((System.ComponentModel.ISupportInitialize)dgv_productList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button bttn_getProductList;
        private Label label1;
        private DataGridView dgv_productList;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnPrice;
        private DataGridViewTextBoxColumn ColumnQuantity;
        private DataGridViewTextBoxColumn ColumnImg;
        private DataGridViewTextBoxColumn ColumnStatus;
    }
}