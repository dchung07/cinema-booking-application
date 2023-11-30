namespace Cinema_Booking_System
{
    partial class ViewCustomerForm
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
            closeBtn = new Button();
            customerTbl = new DataGridView();
            addCustomerBtn = new Button();
            manageCustomerBtn = new Button();
            deleteCustomerBtn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            customerID = new DataGridViewTextBoxColumn();
            customerFirstName = new DataGridViewTextBoxColumn();
            customerLastName = new DataGridViewTextBoxColumn();
            customerEmail = new DataGridViewTextBoxColumn();
            customerPhone = new DataGridViewTextBoxColumn();
            customerPoints = new DataGridViewTextBoxColumn();
            customerStatus = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)customerTbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(591, 364);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(165, 74);
            closeBtn.TabIndex = 0;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // customerTbl
            // 
            customerTbl.AllowUserToAddRows = false;
            customerTbl.AllowUserToDeleteRows = false;
            customerTbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerTbl.Columns.AddRange(new DataGridViewColumn[] { customerID, customerFirstName, customerLastName, customerEmail, customerPhone, customerPoints, customerStatus });
            customerTbl.Location = new Point(46, 60);
            customerTbl.Name = "customerTbl";
            customerTbl.ReadOnly = true;
            customerTbl.RowHeadersWidth = 62;
            customerTbl.RowTemplate.Height = 25;
            customerTbl.Size = new Size(710, 280);
            customerTbl.TabIndex = 1;
            // 
            // addCustomerBtn
            // 
            addCustomerBtn.Location = new Point(46, 364);
            addCustomerBtn.Name = "addCustomerBtn";
            addCustomerBtn.Size = new Size(165, 74);
            addCustomerBtn.TabIndex = 2;
            addCustomerBtn.Text = "Add Customer";
            addCustomerBtn.UseVisualStyleBackColor = true;
            addCustomerBtn.Click += addCustomerBtn_Click;
            // 
            // manageCustomerBtn
            // 
            manageCustomerBtn.Location = new Point(229, 364);
            manageCustomerBtn.Name = "manageCustomerBtn";
            manageCustomerBtn.Size = new Size(165, 74);
            manageCustomerBtn.TabIndex = 3;
            manageCustomerBtn.Text = "Manage Customer";
            manageCustomerBtn.UseVisualStyleBackColor = true;
            manageCustomerBtn.Click += manageCustomerBtn_Click;
            // 
            // deleteCustomerBtn
            // 
            deleteCustomerBtn.Location = new Point(411, 364);
            deleteCustomerBtn.Name = "deleteCustomerBtn";
            deleteCustomerBtn.Size = new Size(165, 74);
            deleteCustomerBtn.TabIndex = 4;
            deleteCustomerBtn.Text = "Delete Customer";
            deleteCustomerBtn.UseVisualStyleBackColor = true;
            deleteCustomerBtn.Click += deleteCustomerBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(343, 9);
            label1.Name = "label1";
            label1.Size = new Size(168, 37);
            label1.TabIndex = 5;
            label1.Text = "CUSTOMERS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vecteezy_gold_add_user_icon_on_transparent_background_free_png_12629502_637;
            pictureBox1.Location = new Point(285, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // customerID
            // 
            customerID.HeaderText = "ID";
            customerID.MinimumWidth = 8;
            customerID.Name = "customerID";
            customerID.ReadOnly = true;
            customerID.Width = 60;
            // 
            // customerFirstName
            // 
            customerFirstName.HeaderText = "First Name";
            customerFirstName.MinimumWidth = 8;
            customerFirstName.Name = "customerFirstName";
            customerFirstName.ReadOnly = true;
            // 
            // customerLastName
            // 
            customerLastName.HeaderText = "Last Name";
            customerLastName.MinimumWidth = 8;
            customerLastName.Name = "customerLastName";
            customerLastName.ReadOnly = true;
            // 
            // customerEmail
            // 
            customerEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customerEmail.HeaderText = "Email";
            customerEmail.MinimumWidth = 8;
            customerEmail.Name = "customerEmail";
            customerEmail.ReadOnly = true;
            // 
            // customerPhone
            // 
            customerPhone.HeaderText = "Phone";
            customerPhone.MinimumWidth = 8;
            customerPhone.Name = "customerPhone";
            customerPhone.ReadOnly = true;
            customerPhone.Width = 80;
            // 
            // customerPoints
            // 
            customerPoints.HeaderText = "Points";
            customerPoints.MinimumWidth = 8;
            customerPoints.Name = "customerPoints";
            customerPoints.ReadOnly = true;
            customerPoints.Width = 60;
            // 
            // customerStatus
            // 
            customerStatus.HeaderText = "Status";
            customerStatus.MinimumWidth = 8;
            customerStatus.Name = "customerStatus";
            customerStatus.ReadOnly = true;
            customerStatus.Width = 60;
            // 
            // ViewCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(deleteCustomerBtn);
            Controls.Add(manageCustomerBtn);
            Controls.Add(addCustomerBtn);
            Controls.Add(customerTbl);
            Controls.Add(closeBtn);
            Name = "ViewCustomerForm";
            Text = "View Customers";
            Load += ViewCustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)customerTbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closeBtn;
        private DataGridView customerTbl;
        private Button addCustomerBtn;
        private Button manageCustomerBtn;
        private Button deleteCustomerBtn;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn customerID;
        private DataGridViewTextBoxColumn customerFirstName;
        private DataGridViewTextBoxColumn customerLastName;
        private DataGridViewTextBoxColumn customerEmail;
        private DataGridViewTextBoxColumn customerPhone;
        private DataGridViewTextBoxColumn customerPoints;
        private DataGridViewTextBoxColumn customerStatus;
    }
}