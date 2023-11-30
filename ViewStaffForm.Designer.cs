namespace Cinema_Booking_System
{
    partial class ViewStaffForm
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
            staffTbl = new DataGridView();
            staffID = new DataGridViewTextBoxColumn();
            staffFirstName = new DataGridViewTextBoxColumn();
            staffLastName = new DataGridViewTextBoxColumn();
            staffEmail = new DataGridViewTextBoxColumn();
            staffPhone = new DataGridViewTextBoxColumn();
            addStaffBtn = new Button();
            manageStaffBtn = new Button();
            deleteStaffBtn = new Button();
            closeBtn = new Button();
            label1 = new Label();
            staffPhoto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)staffTbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)staffPhoto).BeginInit();
            SuspendLayout();
            // 
            // staffTbl
            // 
            staffTbl.AllowUserToAddRows = false;
            staffTbl.AllowUserToDeleteRows = false;
            staffTbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            staffTbl.Columns.AddRange(new DataGridViewColumn[] { staffID, staffFirstName, staffLastName, staffEmail, staffPhone });
            staffTbl.Location = new Point(21, 60);
            staffTbl.Name = "staffTbl";
            staffTbl.ReadOnly = true;
            staffTbl.RowTemplate.Height = 25;
            staffTbl.Size = new Size(580, 280);
            staffTbl.TabIndex = 2;
            // 
            // staffID
            // 
            staffID.HeaderText = "ID";
            staffID.Name = "staffID";
            staffID.ReadOnly = true;
            staffID.Width = 80;
            // 
            // staffFirstName
            // 
            staffFirstName.HeaderText = "First Name";
            staffFirstName.Name = "staffFirstName";
            staffFirstName.ReadOnly = true;
            // 
            // staffLastName
            // 
            staffLastName.HeaderText = "Last Name";
            staffLastName.Name = "staffLastName";
            staffLastName.ReadOnly = true;
            // 
            // staffEmail
            // 
            staffEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            staffEmail.HeaderText = "Email";
            staffEmail.Name = "staffEmail";
            staffEmail.ReadOnly = true;
            // 
            // staffPhone
            // 
            staffPhone.HeaderText = "Phone";
            staffPhone.Name = "staffPhone";
            staffPhone.ReadOnly = true;
            staffPhone.Width = 80;
            // 
            // addStaffBtn
            // 
            addStaffBtn.Location = new Point(46, 364);
            addStaffBtn.Name = "addStaffBtn";
            addStaffBtn.Size = new Size(165, 74);
            addStaffBtn.TabIndex = 3;
            addStaffBtn.Text = "Add Staff";
            addStaffBtn.UseVisualStyleBackColor = true;
            addStaffBtn.Click += addStaffBtn_Click;
            // 
            // manageStaffBtn
            // 
            manageStaffBtn.Location = new Point(228, 364);
            manageStaffBtn.Name = "manageStaffBtn";
            manageStaffBtn.Size = new Size(165, 74);
            manageStaffBtn.TabIndex = 4;
            manageStaffBtn.Text = "Manage Staff";
            manageStaffBtn.UseVisualStyleBackColor = true;
            manageStaffBtn.Click += manageStaffBtn_Click;
            // 
            // deleteStaffBtn
            // 
            deleteStaffBtn.Location = new Point(411, 364);
            deleteStaffBtn.Name = "deleteStaffBtn";
            deleteStaffBtn.Size = new Size(165, 74);
            deleteStaffBtn.TabIndex = 5;
            deleteStaffBtn.Text = "Delete Staff";
            deleteStaffBtn.UseVisualStyleBackColor = true;
            deleteStaffBtn.Click += deleteStaffBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(591, 364);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(165, 74);
            closeBtn.TabIndex = 6;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Desktop;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(355, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 37);
            label1.TabIndex = 7;
            label1.Text = "STAFF";
            // 
            // staffPhoto
            // 
            staffPhoto.Image = Properties.Resources.istockphoto_824033902_612x612;
            staffPhoto.Location = new Point(622, 60);
            staffPhoto.Name = "staffPhoto";
            staffPhoto.Size = new Size(156, 280);
            staffPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            staffPhoto.TabIndex = 8;
            staffPhoto.TabStop = false;
            // 
            // ViewStaffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(staffPhoto);
            Controls.Add(label1);
            Controls.Add(closeBtn);
            Controls.Add(deleteStaffBtn);
            Controls.Add(manageStaffBtn);
            Controls.Add(addStaffBtn);
            Controls.Add(staffTbl);
            Name = "ViewStaffForm";
            Text = "View Staff";
            Load += ViewStaffForm_Load;
            ((System.ComponentModel.ISupportInitialize)staffTbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)staffPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView staffTbl;
        private Button addStaffBtn;
        private Button manageStaffBtn;
        private Button deleteStaffBtn;
        private Button closeBtn;
        private Label label1;
        private DataGridViewTextBoxColumn staffID;
        private DataGridViewTextBoxColumn staffFirstName;
        private DataGridViewTextBoxColumn staffLastName;
        private DataGridViewTextBoxColumn staffEmail;
        private DataGridViewTextBoxColumn staffPhone;
        private PictureBox staffPhoto;
    }
}