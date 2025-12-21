namespace OrderPath_Client_App.Forms.Sellers.QuanLyDonHang
{
    partial class GetOrder
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
            dgv_productList = new DataGridView();
            ColumnOrderID = new DataGridViewTextBoxColumn();
            ColumnCusID = new DataGridViewTextBoxColumn();
            ColumnTotal = new DataGridViewTextBoxColumn();
            ColumnStatus = new DataGridViewTextBoxColumn();
            ColumnDate = new DataGridViewTextBoxColumn();
            bttn_getProductList = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_productList).BeginInit();
            SuspendLayout();
            // 
            // dgv_productList
            // 
            dgv_productList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_productList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_productList.Columns.AddRange(new DataGridViewColumn[] { ColumnOrderID, ColumnCusID, ColumnTotal, ColumnStatus, ColumnDate });
            dgv_productList.Location = new Point(38, 166);
            dgv_productList.Name = "dgv_productList";
            dgv_productList.RowHeadersWidth = 62;
            dgv_productList.Size = new Size(992, 346);
            dgv_productList.TabIndex = 56;
            // 
            // ColumnOrderID
            // 
            ColumnOrderID.HeaderText = "OrderID";
            ColumnOrderID.MinimumWidth = 8;
            ColumnOrderID.Name = "ColumnOrderID";
            // 
            // ColumnCusID
            // 
            ColumnCusID.HeaderText = "CustomerID";
            ColumnCusID.MinimumWidth = 8;
            ColumnCusID.Name = "ColumnCusID";
            // 
            // ColumnTotal
            // 
            ColumnTotal.HeaderText = "Total";
            ColumnTotal.MinimumWidth = 8;
            ColumnTotal.Name = "ColumnTotal";
            // 
            // ColumnStatus
            // 
            ColumnStatus.HeaderText = "Status";
            ColumnStatus.MinimumWidth = 8;
            ColumnStatus.Name = "ColumnStatus";
            // 
            // ColumnDate
            // 
            ColumnDate.HeaderText = "Date";
            ColumnDate.MinimumWidth = 8;
            ColumnDate.Name = "ColumnDate";
            // 
            // bttn_getProductList
            // 
            bttn_getProductList.Font = new Font("Segoe UI", 15F);
            bttn_getProductList.Location = new Point(62, 72);
            bttn_getProductList.Name = "bttn_getProductList";
            bttn_getProductList.Size = new Size(133, 61);
            bttn_getProductList.TabIndex = 55;
            bttn_getProductList.Text = "Load";
            bttn_getProductList.UseVisualStyleBackColor = true;
            bttn_getProductList.Click += bttn_getProductList_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(354, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(367, 57);
            label1.TabIndex = 54;
            label1.Text = "Danh sách đơn hàng";
            // 
            // GetOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 531);
            Controls.Add(dgv_productList);
            Controls.Add(bttn_getProductList);
            Controls.Add(label1);
            Name = "GetOrder";
            Text = "GetOrder";
            ((System.ComponentModel.ISupportInitialize)dgv_productList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_productList;
        private Button bttn_getProductList;
        private Label label1;
        private DataGridViewTextBoxColumn ColumnOrderID;
        private DataGridViewTextBoxColumn ColumnCusID;
        private DataGridViewTextBoxColumn ColumnTotal;
        private DataGridViewTextBoxColumn ColumnStatus;
        private DataGridViewTextBoxColumn ColumnDate;
    }
}