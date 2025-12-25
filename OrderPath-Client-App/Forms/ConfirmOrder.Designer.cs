namespace OrderPath_Client_App.Forms.Sellers.QuanLyDonHang
{
    partial class ConfirmOrder
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
            bttn_orderConfirm = new Button();
            label1 = new Label();
            lb_Fullname = new Label();
            txb_confirmID = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.Location = new Point(221, 101);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(255, 33);
            label2.TabIndex = 53;
            label2.Text = "Vui lòng nhập ID đơn hàng";
            // 
            // bttn_orderConfirm
            // 
            bttn_orderConfirm.Font = new Font("Segoe UI", 18F);
            bttn_orderConfirm.Location = new Point(201, 243);
            bttn_orderConfirm.Name = "bttn_orderConfirm";
            bttn_orderConfirm.Size = new Size(310, 66);
            bttn_orderConfirm.TabIndex = 52;
            bttn_orderConfirm.Text = "Xác nhận";
            bttn_orderConfirm.UseVisualStyleBackColor = true;
            bttn_orderConfirm.Click += bttn_orderConfirm_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(188, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(351, 57);
            label1.TabIndex = 51;
            label1.Text = "Xác nhận đơn hàng";
            // 
            // lb_Fullname
            // 
            lb_Fullname.Font = new Font("Microsoft Sans Serif", 10F);
            lb_Fullname.Location = new Point(155, 164);
            lb_Fullname.Margin = new Padding(4, 0, 4, 0);
            lb_Fullname.Name = "lb_Fullname";
            lb_Fullname.Size = new Size(59, 33);
            lb_Fullname.TabIndex = 49;
            lb_Fullname.Text = "ID";
            // 
            // txb_confirmID
            // 
            txb_confirmID.Location = new Point(221, 164);
            txb_confirmID.Name = "txb_confirmID";
            txb_confirmID.Size = new Size(293, 31);
            txb_confirmID.TabIndex = 50;
            // 
            // ConfirmOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 418);
            Controls.Add(label2);
            Controls.Add(bttn_orderConfirm);
            Controls.Add(label1);
            Controls.Add(lb_Fullname);
            Controls.Add(txb_confirmID);
            Name = "ConfirmOrder";
            Text = "ConfirmOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button bttn_orderConfirm;
        private Label label1;
        private Label lb_Fullname;
        private TextBox txb_confirmID;
    }
}