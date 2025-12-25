namespace OrderPath_Client_App.Forms
{
    partial class SellerGUI
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
            label1 = new Label();
            label2 = new Label();
            bttn_guiDelPro = new Button();
            bttn_guiFixPro = new Button();
            bttn_guiGetProList = new Button();
            bttn_guiGetOrdList = new Button();
            bttn_guiDelOrd = new Button();
            bttn_guiConfOrd = new Button();
            bttn_guiAddPro = new Button();
            dgv_productList = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnPrice = new DataGridViewTextBoxColumn();
            ColumnQuantity = new DataGridViewTextBoxColumn();
            ColumnImg = new DataGridViewImageColumn();
            ColumnStatus = new DataGridViewTextBoxColumn();
            dgv_ordList = new DataGridView();
            ColumnOrderID = new DataGridViewTextBoxColumn();
            ColumnCusID = new DataGridViewTextBoxColumn();
            ColumnTotal = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ColumnDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_productList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_ordList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(450, 9);
            label1.Name = "label1";
            label1.Size = new Size(345, 41);
            label1.TabIndex = 0;
            label1.Text = "Chào mừng chủ Shop";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(34, 63);
            label2.Name = "label2";
            label2.Size = new Size(412, 32);
            label2.TabIndex = 1;
            label2.Text = "Vui lòng chọn tác vụ muốn thực hiện";
            // 
            // bttn_guiDelPro
            // 
            bttn_guiDelPro.Font = new Font("Segoe UI", 12F);
            bttn_guiDelPro.Location = new Point(347, 222);
            bttn_guiDelPro.Name = "bttn_guiDelPro";
            bttn_guiDelPro.Size = new Size(210, 55);
            bttn_guiDelPro.TabIndex = 3;
            bttn_guiDelPro.Text = "Xóa sản phẩm";
            bttn_guiDelPro.UseVisualStyleBackColor = true;
            bttn_guiDelPro.Click += bttn_guiDelPro_Click;
            // 
            // bttn_guiFixPro
            // 
            bttn_guiFixPro.Font = new Font("Segoe UI", 12F);
            bttn_guiFixPro.Location = new Point(347, 133);
            bttn_guiFixPro.Name = "bttn_guiFixPro";
            bttn_guiFixPro.Size = new Size(210, 52);
            bttn_guiFixPro.TabIndex = 4;
            bttn_guiFixPro.Text = "Sửa sản phẩm";
            bttn_guiFixPro.UseVisualStyleBackColor = true;
            bttn_guiFixPro.Click += bttn_guiFixPro_Click;
            // 
            // bttn_guiGetProList
            // 
            bttn_guiGetProList.Font = new Font("Segoe UI", 12F);
            bttn_guiGetProList.Location = new Point(34, 222);
            bttn_guiGetProList.Name = "bttn_guiGetProList";
            bttn_guiGetProList.Size = new Size(296, 55);
            bttn_guiGetProList.TabIndex = 5;
            bttn_guiGetProList.Text = "Lấy danh sách vật phẩm";
            bttn_guiGetProList.UseVisualStyleBackColor = true;
            bttn_guiGetProList.Click += bttn_guiGetProList_Click;
            // 
            // bttn_guiGetOrdList
            // 
            bttn_guiGetOrdList.Font = new Font("Segoe UI", 12F);
            bttn_guiGetOrdList.Location = new Point(659, 133);
            bttn_guiGetOrdList.Name = "bttn_guiGetOrdList";
            bttn_guiGetOrdList.RightToLeft = RightToLeft.No;
            bttn_guiGetOrdList.Size = new Size(321, 55);
            bttn_guiGetOrdList.TabIndex = 6;
            bttn_guiGetOrdList.Text = "Lấy danh sách đơn hàng";
            bttn_guiGetOrdList.UseVisualStyleBackColor = true;
            bttn_guiGetOrdList.Click += bttn_guiGetOrdList_Click;
            // 
            // bttn_guiDelOrd
            // 
            bttn_guiDelOrd.Font = new Font("Segoe UI", 12F);
            bttn_guiDelOrd.Location = new Point(940, 222);
            bttn_guiDelOrd.Name = "bttn_guiDelOrd";
            bttn_guiDelOrd.RightToLeft = RightToLeft.No;
            bttn_guiDelOrd.Size = new Size(230, 55);
            bttn_guiDelOrd.TabIndex = 7;
            bttn_guiDelOrd.Text = "Hủy đơn hàng";
            bttn_guiDelOrd.UseVisualStyleBackColor = true;
            bttn_guiDelOrd.Click += bttn_guiDelOrd_Click;
            // 
            // bttn_guiConfOrd
            // 
            bttn_guiConfOrd.Font = new Font("Segoe UI", 12F);
            bttn_guiConfOrd.Location = new Point(659, 223);
            bttn_guiConfOrd.Name = "bttn_guiConfOrd";
            bttn_guiConfOrd.RightToLeft = RightToLeft.No;
            bttn_guiConfOrd.Size = new Size(230, 54);
            bttn_guiConfOrd.TabIndex = 8;
            bttn_guiConfOrd.Text = "Xác nhận đơn hàng";
            bttn_guiConfOrd.UseVisualStyleBackColor = true;
            bttn_guiConfOrd.Click += bttn_guiConfOrd_Click;
            // 
            // bttn_guiAddPro
            // 
            bttn_guiAddPro.Font = new Font("Segoe UI", 12F);
            bttn_guiAddPro.Location = new Point(34, 132);
            bttn_guiAddPro.Name = "bttn_guiAddPro";
            bttn_guiAddPro.Size = new Size(236, 55);
            bttn_guiAddPro.TabIndex = 9;
            bttn_guiAddPro.Text = "Thêm sản phẩm";
            bttn_guiAddPro.UseVisualStyleBackColor = true;
            bttn_guiAddPro.Click += bttn_guiAddPro_Click;
            // 
            // dgv_productList
            // 
            dgv_productList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_productList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_productList.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnName, ColumnPrice, ColumnQuantity, ColumnImg, ColumnStatus });
            dgv_productList.Location = new Point(34, 306);
            dgv_productList.Name = "dgv_productList";
            dgv_productList.RowHeadersWidth = 62;
            dgv_productList.Size = new Size(594, 360);
            dgv_productList.TabIndex = 54;
            dgv_productList.CellContentDoubleClick += dgv_productList_CellContentDoubleClick;
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
            // dgv_ordList
            // 
            dgv_ordList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ordList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ordList.Columns.AddRange(new DataGridViewColumn[] { ColumnOrderID, ColumnCusID, ColumnTotal, dataGridViewTextBoxColumn1, ColumnDate });
            dgv_ordList.Location = new Point(659, 306);
            dgv_ordList.Name = "dgv_ordList";
            dgv_ordList.RowHeadersWidth = 62;
            dgv_ordList.Size = new Size(584, 360);
            dgv_ordList.TabIndex = 57;
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
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Status";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // ColumnDate
            // 
            ColumnDate.HeaderText = "Date";
            ColumnDate.MinimumWidth = 8;
            ColumnDate.Name = "ColumnDate";
            // 
            // SellerGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 694);
            Controls.Add(dgv_ordList);
            Controls.Add(dgv_productList);
            Controls.Add(bttn_guiAddPro);
            Controls.Add(bttn_guiConfOrd);
            Controls.Add(bttn_guiDelOrd);
            Controls.Add(bttn_guiGetOrdList);
            Controls.Add(bttn_guiGetProList);
            Controls.Add(bttn_guiFixPro);
            Controls.Add(bttn_guiDelPro);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SellerGUI";
            Text = "SellerGUI";
            ((System.ComponentModel.ISupportInitialize)dgv_productList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_ordList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button bttn_guiDelPro;
        private Button bttn_guiFixPro;
        private Button bttn_guiGetProList;
        private Button bttn_guiGetOrdList;
        private Button bttn_guiDelOrd;
        private Button bttn_guiConfOrd;
        private Button bttn_guiAddPro;
        private DataGridView dgv_productList;
        private DataGridView dgv_ordList;
        private DataGridViewTextBoxColumn ColumnOrderID;
        private DataGridViewTextBoxColumn ColumnCusID;
        private DataGridViewTextBoxColumn ColumnTotal;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ColumnDate;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnPrice;
        private DataGridViewTextBoxColumn ColumnQuantity;
        private DataGridViewImageColumn ColumnImg;
        private DataGridViewTextBoxColumn ColumnStatus;
    }
}