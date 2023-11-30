namespace Cinema_Booking_System
{
    partial class AddCustomerForm
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
            cancelBtn = new Button();
            addBtn = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            customerPhone = new TextBox();
            customerEmail = new TextBox();
            customerFirstName = new TextBox();
            customerLastName = new TextBox();
            customerID = new TextBox();
            label1 = new Label();
            label6 = new Label();
            customerStatus = new ComboBox();
            label7 = new Label();
            customerPoints = new TextBox();
            SuspendLayout();
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(68, 237);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 33);
            cancelBtn.TabIndex = 23;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(197, 237);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 33);
            addBtn.TabIndex = 22;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Info;
            label5.Location = new Point(80, 134);
            label5.Name = "label5";
            label5.Size = new Size(63, 21);
            label5.TabIndex = 5;
            label5.Text = "Phone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(86, 106);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 4;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(49, 77);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 3;
            label3.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(47, 48);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 2;
            label2.Text = "First Name:";
            // 
            // customerPhone
            // 
            customerPhone.Location = new Point(154, 136);
            customerPhone.Name = "customerPhone";
            customerPhone.Size = new Size(160, 23);
            customerPhone.TabIndex = 5;
            // 
            // customerEmail
            // 
            customerEmail.Location = new Point(154, 107);
            customerEmail.Name = "customerEmail";
            customerEmail.Size = new Size(160, 23);
            customerEmail.TabIndex = 4;
            // 
            // customerFirstName
            // 
            customerFirstName.Location = new Point(154, 49);
            customerFirstName.Name = "customerFirstName";
            customerFirstName.Size = new Size(160, 23);
            customerFirstName.TabIndex = 2;
            // 
            // customerLastName
            // 
            customerLastName.Location = new Point(154, 78);
            customerLastName.Name = "customerLastName";
            customerLastName.Size = new Size(160, 23);
            customerLastName.TabIndex = 3;
            // 
            // customerID
            // 
            customerID.Location = new Point(154, 20);
            customerID.Name = "customerID";
            customerID.Size = new Size(160, 23);
            customerID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(112, 19);
            label1.Name = "label1";
            label1.Size = new Size(31, 21);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Info;
            label6.Location = new Point(82, 193);
            label6.Name = "label6";
            label6.Size = new Size(61, 21);
            label6.TabIndex = 7;
            label6.Text = "Status:";
            // 
            // customerStatus
            // 
            customerStatus.FormattingEnabled = true;
            customerStatus.Items.AddRange(new object[] { "Bronze", "Silver", "Gold" });
            customerStatus.Location = new Point(154, 195);
            customerStatus.Name = "customerStatus";
            customerStatus.Size = new Size(160, 23);
            customerStatus.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Info;
            label7.Location = new Point(81, 162);
            label7.Name = "label7";
            label7.Size = new Size(62, 21);
            label7.TabIndex = 6;
            label7.Text = "Points:";
            // 
            // customerPoints
            // 
            customerPoints.Location = new Point(154, 165);
            customerPoints.Name = "customerPoints";
            customerPoints.Size = new Size(160, 23);
            customerPoints.TabIndex = 6;
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(366, 293);
            Controls.Add(customerPoints);
            Controls.Add(label7);
            Controls.Add(customerStatus);
            Controls.Add(label6);
            Controls.Add(cancelBtn);
            Controls.Add(addBtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(customerPhone);
            Controls.Add(customerEmail);
            Controls.Add(customerFirstName);
            Controls.Add(customerLastName);
            Controls.Add(customerID);
            Controls.Add(label1);
            Name = "AddCustomerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Customer";
            Load += AddCustomerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelBtn;
        private Button addBtn;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox customerPhone;
        private TextBox customerEmail;
        private TextBox customerFirstName;
        private TextBox customerLastName;
        private TextBox customerID;
        private Label label1;
        private Label label6;
        private ComboBox customerStatus;
        private Label label7;
        private TextBox customerPoints;
    }
}