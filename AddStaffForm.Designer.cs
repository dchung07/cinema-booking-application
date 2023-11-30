namespace Cinema_Booking_System
{
    partial class AddStaffForm
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
            staffID = new TextBox();
            staffLastName = new TextBox();
            staffFirstName = new TextBox();
            staffEmail = new TextBox();
            staffPhone = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            addBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(112, 41);
            label1.Name = "label1";
            label1.Size = new Size(31, 21);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // staffID
            // 
            staffID.Location = new Point(154, 41);
            staffID.Name = "staffID";
            staffID.Size = new Size(160, 23);
            staffID.TabIndex = 1;
            // 
            // staffLastName
            // 
            staffLastName.Location = new Point(154, 99);
            staffLastName.Name = "staffLastName";
            staffLastName.Size = new Size(160, 23);
            staffLastName.TabIndex = 3;
            // 
            // staffFirstName
            // 
            staffFirstName.Location = new Point(154, 70);
            staffFirstName.Name = "staffFirstName";
            staffFirstName.Size = new Size(160, 23);
            staffFirstName.TabIndex = 2;
            // 
            // staffEmail
            // 
            staffEmail.Location = new Point(154, 128);
            staffEmail.Name = "staffEmail";
            staffEmail.Size = new Size(160, 23);
            staffEmail.TabIndex = 4;
            // 
            // staffPhone
            // 
            staffPhone.Location = new Point(154, 157);
            staffPhone.Name = "staffPhone";
            staffPhone.Size = new Size(160, 23);
            staffPhone.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(47, 70);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 6;
            label2.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(49, 101);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 7;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(86, 130);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 8;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Info;
            label5.Location = new Point(80, 159);
            label5.Name = "label5";
            label5.Size = new Size(63, 21);
            label5.TabIndex = 9;
            label5.Text = "Phone:";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(195, 200);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 33);
            addBtn.TabIndex = 10;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(80, 200);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 33);
            cancelBtn.TabIndex = 11;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // AddStaffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(366, 245);
            Controls.Add(cancelBtn);
            Controls.Add(addBtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(staffPhone);
            Controls.Add(staffEmail);
            Controls.Add(staffFirstName);
            Controls.Add(staffLastName);
            Controls.Add(staffID);
            Controls.Add(label1);
            Name = "AddStaffForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Staff";
            Load += AddStaffForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox staffID;
        private TextBox staffLastName;
        private TextBox staffFirstName;
        private TextBox staffEmail;
        private TextBox staffPhone;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button addBtn;
        private Button cancelBtn;
    }
}