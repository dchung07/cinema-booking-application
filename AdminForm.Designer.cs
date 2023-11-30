namespace Cinema_Booking_System
{
    partial class AdminForm
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
            logoutButton = new Button();
            CustomersBtn = new Button();
            StaffBtn = new Button();
            label1 = new Label();
            staffImage = new PictureBox();
            customerImage = new PictureBox();
            pictureBox1 = new PictureBox();
            passwordManagerBtn = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)staffImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // logoutButton
            // 
            logoutButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            logoutButton.Location = new Point(267, 306);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(105, 42);
            logoutButton.TabIndex = 1;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // CustomersBtn
            // 
            CustomersBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CustomersBtn.Location = new Point(68, 224);
            CustomersBtn.Name = "CustomersBtn";
            CustomersBtn.Size = new Size(223, 32);
            CustomersBtn.TabIndex = 2;
            CustomersBtn.Text = "View Customers";
            CustomersBtn.UseVisualStyleBackColor = true;
            CustomersBtn.Click += CustomersBtn_Click;
            // 
            // StaffBtn
            // 
            StaffBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            StaffBtn.Location = new Point(347, 224);
            StaffBtn.Name = "StaffBtn";
            StaffBtn.Size = new Size(223, 32);
            StaffBtn.TabIndex = 3;
            StaffBtn.Text = "View Staff";
            StaffBtn.UseVisualStyleBackColor = true;
            StaffBtn.Click += StaffBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Desktop;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(237, 29);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 4;
            label1.Text = "Administrator";
            // 
            // staffImage
            // 
            staffImage.Image = Properties.Resources.a1cfc248b655fe9f0afe918a0ceae4d9;
            staffImage.Location = new Point(347, 99);
            staffImage.Name = "staffImage";
            staffImage.Size = new Size(223, 157);
            staffImage.SizeMode = PictureBoxSizeMode.StretchImage;
            staffImage.TabIndex = 5;
            staffImage.TabStop = false;
            staffImage.Click += staffImage_Click;
            // 
            // customerImage
            // 
            customerImage.Image = Properties.Resources.AdobeStock_298516782_scaled;
            customerImage.Location = new Point(68, 99);
            customerImage.Name = "customerImage";
            customerImage.Size = new Size(223, 157);
            customerImage.SizeMode = PictureBoxSizeMode.StretchImage;
            customerImage.TabIndex = 6;
            customerImage.TabStop = false;
            customerImage.Click += customerImage_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cinema_movie_theater_with_blank_screen_and_red_seat_vector;
            pictureBox1.Location = new Point(-1, 272);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(642, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // passwordManagerBtn
            // 
            passwordManagerBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passwordManagerBtn.Location = new Point(12, 317);
            passwordManagerBtn.Name = "passwordManagerBtn";
            passwordManagerBtn.Size = new Size(158, 26);
            passwordManagerBtn.TabIndex = 8;
            passwordManagerBtn.Text = "        Password Manager";
            passwordManagerBtn.UseVisualStyleBackColor = true;
            passwordManagerBtn.Click += passwordManagerBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = Properties.Resources.password_key_icon_221146;
            pictureBox2.Location = new Point(12, 317);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(638, 369);
            Controls.Add(CustomersBtn);
            Controls.Add(label1);
            Controls.Add(StaffBtn);
            Controls.Add(logoutButton);
            Controls.Add(customerImage);
            Controls.Add(staffImage);
            Controls.Add(pictureBox2);
            Controls.Add(passwordManagerBtn);
            Controls.Add(pictureBox1);
            Name = "AdminForm";
            Text = "Admin";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)staffImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logoutButton;
        private Button CustomersBtn;
        private Button StaffBtn;
        private Label label1;
        private PictureBox staffImage;
        private PictureBox customerImage;
        private PictureBox pictureBox1;
        private Button passwordManagerBtn;
        private PictureBox pictureBox2;
    }
}