namespace OrderPath_Client_App.Forms.Sellers.QuanLyDonHang
{
    partial class DeleteOrder
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
            label2 = new Label();
            bttn_orderDelete = new Button();
            label1 = new Label();
            lb_Fullname = new Label();
            txb_deleteID = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.Location = new Point(212, 125);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(255, 33);
            label2.TabIndex = 58;
            label2.Text = "Vui lòng nhập ID đơn hàng";
            // 
            // bttn_orderDelete
            // 
            bttn_orderDelete.Font = new Font("Segoe UI", 18F);
            bttn_orderDelete.Location = new Point(192, 267);
            bttn_orderDelete.Name = "bttn_orderDelete";
            bttn_orderDelete.Size = new Size(310, 66);
            bttn_orderDelete.TabIndex = 57;
            bttn_orderDelete.Text = "Xác nhận";
            bttn_orderDelete.UseVisualStyleBackColor = true;
            bttn_orderDelete.Click += bttn_orderDelete_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(212, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(264, 57);
            label1.TabIndex = 56;
            label1.Text = "Hủy đơn hàng";
            // 
            // lb_Fullname
            // 
            lb_Fullname.Font = new Font("Microsoft Sans Serif", 10F);
            lb_Fullname.Location = new Point(146, 188);
            lb_Fullname.Margin = new Padding(4, 0, 4, 0);
            lb_Fullname.Name = "lb_Fullname";
            lb_Fullname.Size = new Size(59, 33);
            lb_Fullname.TabIndex = 54;
            lb_Fullname.Text = "ID";
            // 
            // txb_deleteID
            // 
            txb_deleteID.Location = new Point(212, 188);
            txb_deleteID.Name = "txb_deleteID";
            txb_deleteID.Size = new Size(293, 31);
            txb_deleteID.TabIndex = 55;
            // 
            // DeleteOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 380);
            Controls.Add(label2);
            Controls.Add(bttn_orderDelete);
            Controls.Add(label1);
            Controls.Add(lb_Fullname);
            Controls.Add(txb_deleteID);
            Name = "DeleteOrder";
            Text = "DeleteOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button bttn_orderDelete;
        private Label label1;
        private Label lb_Fullname;
        private TextBox txb_deleteID;
    }
}