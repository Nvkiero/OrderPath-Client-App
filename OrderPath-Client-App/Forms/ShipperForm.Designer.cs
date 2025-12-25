namespace OrderPath_Client_App.Forms
{
    partial class ShipperForm
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

            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatusAction = new System.Windows.Forms.Label();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.grpProfile = new System.Windows.Forms.GroupBox();
            this.lblTotalDeliveriesVal = new System.Windows.Forms.Label();
            this.lblVehicleVal = new System.Windows.Forms.Label();
            this.lblPhoneVal = new System.Windows.Forms.Label();
            this.lblCompanyNameVal = new System.Windows.Forms.Label();
            this.lblStaticDeliveries = new System.Windows.Forms.Label();
            this.lblStaticVehicle = new System.Windows.Forms.Label();
            this.lblStaticPhone = new System.Windows.Forms.Label();
            this.lblStaticCompany = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.pnlActions.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.grpProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabOrders);
            this.tabControlMain.Controls.Add(this.tabProfile);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(800, 450);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabOrders
            // 
            this.tabOrders.Controls.Add(this.dgvOrders);
            this.tabOrders.Controls.Add(this.pnlActions);
            this.tabOrders.Location = new System.Drawing.Point(4, 24);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrders.Size = new System.Drawing.Size(792, 422);
            this.tabOrders.TabIndex = 0;
            this.tabOrders.Text = "Active Orders";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrders.EnableHeadersVisualStyles = false;
            this.dgvOrders.GridColor = System.Drawing.Color.SandyBrown;

            // Header Style
            dataGridViewCellStyleHeader.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyleHeader.BackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyleHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyleHeader.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyleHeader.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyleHeader.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyleHeader.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyleHeader;

            // Row Style
            dataGridViewCellStyleRows.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyleRows.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyleRows.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyleRows.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyleRows.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyleRows.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyleRows.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.DefaultCellStyle = dataGridViewCellStyleRows;

            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(3, 3);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(786, 316);
            this.dgvOrders.TabIndex = 1;
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlActions.Controls.Add(this.btnRefresh);
            this.pnlActions.Controls.Add(this.btnUpdateStatus);
            this.pnlActions.Controls.Add(this.cmbStatus);
            this.pnlActions.Controls.Add(this.lblStatusAction);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActions.Location = new System.Drawing.Point(3, 319);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(786, 100);
            this.pnlActions.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(420, 30);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.BackColor = System.Drawing.Color.OrangeRed;
            this.btnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateStatus.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStatus.Location = new System.Drawing.Point(290, 30);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(120, 30);
            this.btnUpdateStatus.TabIndex = 2;
            this.btnUpdateStatus.Text = "Update Order";
            this.btnUpdateStatus.UseVisualStyleBackColor = false;
            this.btnUpdateStatus.Click += new System.EventHandler(this.BtnUpdateStatus_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pending",
            "Shipping",
            "Delivered",
            "Cancelled"});
            this.cmbStatus.Location = new System.Drawing.Point(130, 32);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(150, 23);
            this.cmbStatus.TabIndex = 1;
            // 
            // lblStatusAction
            // 
            this.lblStatusAction.AutoSize = true;
            this.lblStatusAction.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblStatusAction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatusAction.Location = new System.Drawing.Point(30, 35);
            this.lblStatusAction.Name = "lblStatusAction";
            this.lblStatusAction.Size = new System.Drawing.Size(87, 15);
            this.lblStatusAction.TabIndex = 0;
            this.lblStatusAction.Text = "Update Status:";
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.grpProfile);
            this.tabProfile.Location = new System.Drawing.Point(4, 24);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(792, 422);
            this.tabProfile.TabIndex = 1;
            this.tabProfile.Text = "My Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // grpProfile
            // 
            this.grpProfile.Controls.Add(this.lblTotalDeliveriesVal);
            this.grpProfile.Controls.Add(this.lblVehicleVal);
            this.grpProfile.Controls.Add(this.lblPhoneVal);
            this.grpProfile.Controls.Add(this.lblCompanyNameVal);
            this.grpProfile.Controls.Add(this.lblStaticDeliveries);
            this.grpProfile.Controls.Add(this.lblStaticVehicle);
            this.grpProfile.Controls.Add(this.lblStaticPhone);
            this.grpProfile.Controls.Add(this.lblStaticCompany);
            this.grpProfile.ForeColor = System.Drawing.Color.SaddleBrown;
            this.grpProfile.Location = new System.Drawing.Point(20, 20);
            this.grpProfile.Name = "grpProfile";
            this.grpProfile.Size = new System.Drawing.Size(400, 200);
            this.grpProfile.TabIndex = 0;
            this.grpProfile.TabStop = false;
            this.grpProfile.Text = "Shipper Details";
            // 
            // lblTotalDeliveriesVal
            // 
            this.lblTotalDeliveriesVal.AutoSize = true;
            this.lblTotalDeliveriesVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDeliveriesVal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalDeliveriesVal.Location = new System.Drawing.Point(150, 140);
            this.lblTotalDeliveriesVal.Name = "lblTotalDeliveriesVal";
            this.lblTotalDeliveriesVal.Size = new System.Drawing.Size(21, 19);
            this.lblTotalDeliveriesVal.TabIndex = 7;
            this.lblTotalDeliveriesVal.Text = "...";
            // 
            // lblVehicleVal
            // 
            this.lblVehicleVal.AutoSize = true;
            this.lblVehicleVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVehicleVal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVehicleVal.Location = new System.Drawing.Point(150, 100);
            this.lblVehicleVal.Name = "lblVehicleVal";
            this.lblVehicleVal.Size = new System.Drawing.Size(21, 19);
            this.lblVehicleVal.TabIndex = 6;
            this.lblVehicleVal.Text = "...";
            // 
            // lblPhoneVal
            // 
            this.lblPhoneVal.AutoSize = true;
            this.lblPhoneVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhoneVal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPhoneVal.Location = new System.Drawing.Point(150, 60);
            this.lblPhoneVal.Name = "lblPhoneVal";
            this.lblPhoneVal.Size = new System.Drawing.Size(21, 19);
            this.lblPhoneVal.TabIndex = 5;
            this.lblPhoneVal.Text = "...";
            // 
            // lblCompanyNameVal
            // 
            this.lblCompanyNameVal.AutoSize = true;
            this.lblCompanyNameVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCompanyNameVal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCompanyNameVal.Location = new System.Drawing.Point(150, 25);
            this.lblCompanyNameVal.Name = "lblCompanyNameVal";
            this.lblCompanyNameVal.Size = new System.Drawing.Size(21, 19);
            this.lblCompanyNameVal.TabIndex = 4;
            this.lblCompanyNameVal.Text = "...";
            // 
            // lblStaticDeliveries
            // 
            this.lblStaticDeliveries.AutoSize = true;
            this.lblStaticDeliveries.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStaticDeliveries.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblStaticDeliveries.Location = new System.Drawing.Point(20, 142);
            this.lblStaticDeliveries.Name = "lblStaticDeliveries";
            this.lblStaticDeliveries.Size = new System.Drawing.Size(95, 15);
            this.lblStaticDeliveries.TabIndex = 3;
            this.lblStaticDeliveries.Text = "Total Deliveries:";
            // 
            // lblStaticVehicle
            // 
            this.lblStaticVehicle.AutoSize = true;
            this.lblStaticVehicle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStaticVehicle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblStaticVehicle.Location = new System.Drawing.Point(20, 102);
            this.lblStaticVehicle.Name = "lblStaticVehicle";
            this.lblStaticVehicle.Size = new System.Drawing.Size(49, 15);
            this.lblStaticVehicle.TabIndex = 2;
            this.lblStaticVehicle.Text = "Vehicle:";
            // 
            // lblStaticPhone
            // 
            this.lblStaticPhone.AutoSize = true;
            this.lblStaticPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStaticPhone.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblStaticPhone.Location = new System.Drawing.Point(20, 62);
            this.lblStaticPhone.Name = "lblStaticPhone";
            this.lblStaticPhone.Size = new System.Drawing.Size(45, 15);
            this.lblStaticPhone.TabIndex = 1;
            this.lblStaticPhone.Text = "Phone:";
            // 
            // lblStaticCompany
            // 
            // FIX: Changed Text from "Company:" to "Username:"
            this.lblStaticCompany.AutoSize = true;
            this.lblStaticCompany.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStaticCompany.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblStaticCompany.Location = new System.Drawing.Point(20, 27);
            this.lblStaticCompany.Name = "lblStaticCompany";
            this.lblStaticCompany.Size = new System.Drawing.Size(61, 15);
            this.lblStaticCompany.TabIndex = 0;
            this.lblStaticCompany.Text = "Username:";
            // 
            // ShipperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "ShipperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shipper Dashboard";
            this.tabControlMain.ResumeLayout(false);
            this.tabOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            this.tabProfile.ResumeLayout(false);
            this.grpProfile.ResumeLayout(false);
            this.grpProfile.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatusAction;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox grpProfile;
        private System.Windows.Forms.Label lblStaticCompany;
        private System.Windows.Forms.Label lblTotalDeliveriesVal;
        private System.Windows.Forms.Label lblVehicleVal;
        private System.Windows.Forms.Label lblPhoneVal;
        private System.Windows.Forms.Label lblCompanyNameVal;
        private System.Windows.Forms.Label lblStaticDeliveries;
        private System.Windows.Forms.Label lblStaticVehicle;
        private System.Windows.Forms.Label lblStaticPhone;
    }
}