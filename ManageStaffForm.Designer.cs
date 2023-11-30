namespace Cinema_Booking_System
{
    partial class ManageStaffForm
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
            updateBtn = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            staffPhone = new TextBox();
            staffEmail = new TextBox();
            staffFirstName = new TextBox();
            staffLastName = new TextBox();
            staffID = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(80, 200);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 33);
            cancelBtn.TabIndex = 23;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(198, 200);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(75, 33);
            updateBtn.TabIndex = 22;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Info;
            label5.Location = new Point(80, 159);
            label5.Name = "label5";
            label5.Size = new Size(63, 21);
            label5.TabIndex = 21;
            label5.Text = "Phone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(86, 130);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 20;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(49, 101);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 19;
            label3.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(47, 70);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 18;
            label2.Text = "First Name:";
            // 
            // staffPhone
            // 
            staffPhone.Location = new Point(154, 157);
            staffPhone.Name = "staffPhone";
            staffPhone.Size = new Size(160, 23);
            staffPhone.TabIndex = 5;
            // 
            // staffEmail
            // 
            staffEmail.Location = new Point(154, 128);
            staffEmail.Name = "staffEmail";
            staffEmail.Size = new Size(160, 23);
            staffEmail.TabIndex = 4;
            // 
            // staffFirstName
            // 
            staffFirstName.Location = new Point(154, 70);
            staffFirstName.Name = "staffFirstName";
            staffFirstName.Size = new Size(160, 23);
            staffFirstName.TabIndex = 2;
            // 
            // staffLastName
            // 
            staffLastName.Location = new Point(154, 99);
            staffLastName.Name = "staffLastName";
            staffLastName.Size = new Size(160, 23);
            staffLastName.TabIndex = 3;
            // 
            // staffID
            // 
            staffID.Location = new Point(154, 41);
            staffID.Name = "staffID";
            staffID.Size = new Size(160, 23);
            staffID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(112, 41);
            label1.Name = "label1";
            label1.Size = new Size(31, 21);
            label1.TabIndex = 12;
            label1.Text = "ID:";
            // 
            // ManageStaffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(366, 245);
            Controls.Add(cancelBtn);
            Controls.Add(updateBtn);
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
            Name = "ManageStaffForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Manage Staff";
            Load += ManageStaffForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelBtn;
        private Button updateBtn;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox staffPhone;
        private TextBox staffEmail;
        private TextBox staffFirstName;
        private TextBox staffLastName;
        private TextBox staffID;
        private Label label1;
    }
}