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
            tb_ThanhTimKiem = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            bt_search = new Button();
            dgvProducts = new DataGridView();
            pn_ = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            pn_.SuspendLayout();
            SuspendLayout();
            // 
            // tb_ThanhTimKiem
            // 
            tb_ThanhTimKiem.Location = new Point(3, 107);
            tb_ThanhTimKiem.Name = "tb_ThanhTimKiem";
            tb_ThanhTimKiem.Size = new Size(850, 40);
            tb_ThanhTimKiem.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.lovepik_shopping_cart_icon_png_image_401363020_wh1200;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(854, 180);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(1176, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 111);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // bt_search
            // 
            bt_search.Location = new Point(859, 107);
            bt_search.Name = "bt_search";
            bt_search.Size = new Size(217, 43);
            bt_search.TabIndex = 3;
            bt_search.Text = "Tìm kiếm";
            bt_search.UseVisualStyleBackColor = true;
            bt_search.Click += bt_search_Click_1;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeight = 34;
            dgvProducts.Location = new Point(-2, 180);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.RowTemplate.Height = 60;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(850, 580);
            dgvProducts.TabIndex = 4;
            dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;
            // 
            // pn_
            // 
            pn_.BackColor = Color.FromArgb(255, 128, 0);
            pn_.Controls.Add(pictureBox2);
            pn_.Controls.Add(bt_search);
            pn_.Controls.Add(tb_ThanhTimKiem);
            pn_.Location = new Point(-2, 0);
            pn_.Name = "pn_";
            pn_.Size = new Size(1337, 150);
            pn_.TabIndex = 5;
            // 
            // FormMainUsers
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 760);
            Controls.Add(pn_);
            Controls.Add(pictureBox1);
            Controls.Add(dgvProducts);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormMainUsers";
            Text = "FormMainUsers";
            Load += FormMainUsers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            pn_.ResumeLayout(false);
            pn_.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tb_ThanhTimKiem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button bt_search;
        private DataGridView dgvProducts;
        private Panel pn_;
    }
}