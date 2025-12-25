namespace OrderPath_Client_App.Forms
{
    partial class OrderPath
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System.Windows.Forms.Button btnShowMap;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            splitContainer = new SplitContainer();
            dgvOrders = new DataGridView();
            dgvOrderItems = new DataGridView();
            btnShowMap = new Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(255, 128, 0);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1200, 60);
            panelHeader.TabIndex = 1;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📦 THEO DÕI ĐƠN HÀNG";
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 60);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(dgvOrders);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(dgvOrderItems);
            splitContainer.Panel2.Controls.Add(btnShowMap);
            splitContainer.Size = new Size(1200, 640);
            splitContainer.SplitterDistance = 967;
            splitContainer.TabIndex = 0;
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeight = 34;
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.Location = new Point(0, 0);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 62;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(967, 640);
            dgvOrders.TabIndex = 0;
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.ColumnHeadersHeight = 34;
            dgvOrderItems.Dock = DockStyle.Top;
            dgvOrderItems.Location = new Point(0, 0);
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.RowHeadersWidth = 62;
            dgvOrderItems.Size = new Size(229, 400);
            dgvOrderItems.TabIndex = 0;
            // 
            // btnShowMap
            // 
            btnShowMap.Dock = DockStyle.Bottom;
            btnShowMap.Location = new Point(0, 590);
            btnShowMap.Name = "btnShowMap";
            btnShowMap.Size = new Size(229, 50);
            btnShowMap.TabIndex = 1;
            btnShowMap.Text = "🌍 Xem vị trí Shipper";
            //btnShowMap.Click += BtnShowMap_Click;
            // 
            // OrderPath
            // 
            ClientSize = new Size(1200, 700);
            Controls.Add(splitContainer);
            Controls.Add(panelHeader);
            Name = "OrderPath";
            Text = "OrderPath";
            panelHeader.ResumeLayout(false);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
