using System.Drawing;
using System.Windows.Forms;

namespace OrderPath_Client_App
{
    partial class FormMainUsers : Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleHeader = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleRows = new System.Windows.Forms.DataGridViewCellStyle();

            this.tb_ThanhTimKiem = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();

            // Define Columns matching your SQL Schema
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImage = new System.Windows.Forms.DataGridViewImageColumn(); // For 'Image'
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn(); // For 'Name'
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn(); // For 'Category'
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn(); // For 'Price'
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn(); // For 'Description'
            this.colBuy = new System.Windows.Forms.DataGridViewButtonColumn(); // Action Button

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();

            // 
            // tb_ThanhTimKiem
            // 
            this.tb_ThanhTimKiem.Location = new System.Drawing.Point(12, 12);
            this.tb_ThanhTimKiem.Name = "tb_ThanhTimKiem";
            this.tb_ThanhTimKiem.Size = new System.Drawing.Size(463, 29);
            this.tb_ThanhTimKiem.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            // Note: Ensure you have this resource or remove this line if it causes errors
            this.pictureBox1.Image = global::OrderPath_Client_App.Properties.Resources.lovepik_shopping_cart_icon_png_image_401363020_wh1200;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(507, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(716, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 111);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_search.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.ForeColor = System.Drawing.Color.White;
            this.bt_search.Location = new System.Drawing.Point(12, 58);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(463, 65);
            this.bt_search.TabIndex = 3;
            this.bt_search.Text = "Tìm kiếm";
            this.bt_search.UseVisualStyleBackColor = false;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            // --- HEADER STYLE (Orange Theme) ---
            dataGridViewCellStyleHeader.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyleHeader.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyleHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyleHeader.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyleHeader.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyleHeader.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyleHeader.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyleHeader;
            this.dgvProducts.ColumnHeadersHeight = 40;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // --- ADD COLUMNS ---
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colImage,
            this.colName,
            this.colCategory,
            this.colPrice,
            this.colDescription,
            this.colBuy});

            // --- ROW STYLE ---
            dataGridViewCellStyleRows.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyleRows.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyleRows.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyleRows.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyleRows.SelectionBackColor = System.Drawing.Color.PapayaWhip; // Light Orange Selection
            dataGridViewCellStyleRows.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyleRows.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyleRows;

            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.GridColor = System.Drawing.Color.PeachPuff;
            this.dgvProducts.Location = new System.Drawing.Point(12, 140); // Below the search button
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowTemplate.Height = 80; // Taller rows for images
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(854, 608);
            this.dgvProducts.TabIndex = 4;

            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false; // Hide ID
            // 
            // colImage
            // 
            this.colImage.DataPropertyName = "Image";
            this.colImage.HeaderText = "Hình ảnh";
            this.colImage.Name = "colImage";
            this.colImage.ReadOnly = true;
            this.colImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colImage.FillWeight = 60F;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Tên Sản Phẩm";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.FillWeight = 120F;
            // 
            // colCategory
            // 
            this.colCategory.DataPropertyName = "Category";
            this.colCategory.HeaderText = "Danh mục";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            this.colCategory.FillWeight = 80F;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "Giá";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.FillWeight = 60F;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "Description";
            this.colDescription.HeaderText = "Mô tả";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // colBuy
            // 
            this.colBuy.HeaderText = "Mua hàng";
            this.colBuy.Name = "colBuy";
            this.colBuy.ReadOnly = true;
            this.colBuy.Text = "Thêm vào giỏ";
            this.colBuy.UseColumnTextForButtonValue = true;
            this.colBuy.FillWeight = 70F;

            // 
            // FormMainUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(878, 760);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_ThanhTimKiem);
            this.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMainUsers";
            this.Text = "Trang Chủ - OrderPath";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ThanhTimKiem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewImageColumn colImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewButtonColumn colBuy;
    }
}