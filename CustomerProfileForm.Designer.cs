namespace Cinema_Booking_System
{
    partial class CustomerProfileForm
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
            customerFirstNameLabel = new Label();
            customerLastNameLabel = new Label();
            phone = new Label();
            customerRankLabel = new Label();
            label2 = new Label();
            customerProfileFirstNameLabel = new Label();
            customerProfileLastNameLabel = new Label();
            customerProfileEmailLabel = new Label();
            customerProfilePhoneLabel = new Label();
            customerProfileRankLabel = new Label();
            customerProfileReturnButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            customerProfilePointsLabel = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Adobe Devanagari", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(295, 20);
            label1.Name = "label1";
            label1.Size = new Size(138, 60);
            label1.TabIndex = 0;
            label1.Text = "Profile";
            // 
            // customerFirstNameLabel
            // 
            customerFirstNameLabel.AutoSize = true;
            customerFirstNameLabel.BackColor = SystemColors.ButtonFace;
            customerFirstNameLabel.Font = new Font("Adobe Devanagari", 16F, FontStyle.Bold, GraphicsUnit.Point);
            customerFirstNameLabel.Location = new Point(183, 82);
            customerFirstNameLabel.Name = "customerFirstNameLabel";
            customerFirstNameLabel.Size = new Size(168, 43);
            customerFirstNameLabel.TabIndex = 1;
            customerFirstNameLabel.Text = "First Name: ";
            // 
            // customerLastNameLabel
            // 
            customerLastNameLabel.AutoSize = true;
            customerLastNameLabel.BackColor = SystemColors.ButtonFace;
            customerLastNameLabel.Font = new Font("Adobe Devanagari", 16F, FontStyle.Bold, GraphicsUnit.Point);
            customerLastNameLabel.Location = new Point(192, 125);
            customerLastNameLabel.Name = "customerLastNameLabel";
            customerLastNameLabel.Size = new Size(157, 43);
            customerLastNameLabel.TabIndex = 2;
            customerLastNameLabel.Text = "Last Name:";
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.BackColor = SystemColors.ButtonFace;
            phone.Font = new Font("Adobe Devanagari", 16F, FontStyle.Bold, GraphicsUnit.Point);
            phone.Location = new Point(247, 212);
            phone.Name = "phone";
            phone.Size = new Size(103, 43);
            phone.TabIndex = 3;
            phone.Text = "Phone:";
            // 
            // customerRankLabel
            // 
            customerRankLabel.AutoSize = true;
            customerRankLabel.BackColor = SystemColors.ButtonFace;
            customerRankLabel.Font = new Font("Adobe Devanagari", 16F, FontStyle.Bold, GraphicsUnit.Point);
            customerRankLabel.Location = new Point(261, 291);
            customerRankLabel.Name = "customerRankLabel";
            customerRankLabel.Size = new Size(90, 43);
            customerRankLabel.TabIndex = 4;
            customerRankLabel.Text = "Rank:";
            customerRankLabel.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Adobe Devanagari", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(247, 169);
            label2.Name = "label2";
            label2.Size = new Size(98, 43);
            label2.TabIndex = 5;
            label2.Text = "Email:";
            // 
            // customerProfileFirstNameLabel
            // 
            customerProfileFirstNameLabel.AutoSize = true;
            customerProfileFirstNameLabel.BackColor = SystemColors.ButtonFace;
            customerProfileFirstNameLabel.Font = new Font("Adobe Devanagari", 16F, FontStyle.Regular, GraphicsUnit.Point);
            customerProfileFirstNameLabel.Location = new Point(356, 89);
            customerProfileFirstNameLabel.Name = "customerProfileFirstNameLabel";
            customerProfileFirstNameLabel.Size = new Size(90, 43);
            customerProfileFirstNameLabel.TabIndex = 6;
            customerProfileFirstNameLabel.Text = "label3";
            customerProfileFirstNameLabel.Click += label3_Click_1;
            // 
            // customerProfileLastNameLabel
            // 
            customerProfileLastNameLabel.AutoSize = true;
            customerProfileLastNameLabel.BackColor = SystemColors.ButtonFace;
            customerProfileLastNameLabel.Font = new Font("Adobe Devanagari", 16F, FontStyle.Regular, GraphicsUnit.Point);
            customerProfileLastNameLabel.Location = new Point(356, 132);
            customerProfileLastNameLabel.Name = "customerProfileLastNameLabel";
            customerProfileLastNameLabel.Size = new Size(90, 43);
            customerProfileLastNameLabel.TabIndex = 7;
            customerProfileLastNameLabel.Text = "label4";
            customerProfileLastNameLabel.Click += customerProfileLastNameLabel_Click;
            // 
            // customerProfileEmailLabel
            // 
            customerProfileEmailLabel.AutoSize = true;
            customerProfileEmailLabel.BackColor = SystemColors.ButtonFace;
            customerProfileEmailLabel.Font = new Font("Adobe Devanagari", 16F, FontStyle.Regular, GraphicsUnit.Point);
            customerProfileEmailLabel.Location = new Point(356, 175);
            customerProfileEmailLabel.Name = "customerProfileEmailLabel";
            customerProfileEmailLabel.Size = new Size(90, 43);
            customerProfileEmailLabel.TabIndex = 8;
            customerProfileEmailLabel.Text = "label5";
            // 
            // customerProfilePhoneLabel
            // 
            customerProfilePhoneLabel.AutoSize = true;
            customerProfilePhoneLabel.BackColor = SystemColors.ButtonFace;
            customerProfilePhoneLabel.Font = new Font("Adobe Devanagari", 16F, FontStyle.Regular, GraphicsUnit.Point);
            customerProfilePhoneLabel.Location = new Point(356, 212);
            customerProfilePhoneLabel.Name = "customerProfilePhoneLabel";
            customerProfilePhoneLabel.Size = new Size(90, 43);
            customerProfilePhoneLabel.TabIndex = 9;
            customerProfilePhoneLabel.Text = "label6";
            customerProfilePhoneLabel.Click += label6_Click;
            // 
            // customerProfileRankLabel
            // 
            customerProfileRankLabel.AutoSize = true;
            customerProfileRankLabel.BackColor = SystemColors.ButtonFace;
            customerProfileRankLabel.Font = new Font("Adobe Devanagari", 16F, FontStyle.Regular, GraphicsUnit.Point);
            customerProfileRankLabel.Location = new Point(357, 291);
            customerProfileRankLabel.Name = "customerProfileRankLabel";
            customerProfileRankLabel.Size = new Size(90, 43);
            customerProfileRankLabel.TabIndex = 10;
            customerProfileRankLabel.Text = "label7";
            // 
            // customerProfileReturnButton
            // 
            customerProfileReturnButton.BackColor = SystemColors.Highlight;
            customerProfileReturnButton.BackgroundImage = Properties.Resources.blu;
            customerProfileReturnButton.Font = new Font("Montserrat Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            customerProfileReturnButton.ForeColor = SystemColors.ButtonFace;
            customerProfileReturnButton.Location = new Point(296, 384);
            customerProfileReturnButton.Name = "customerProfileReturnButton";
            customerProfileReturnButton.Size = new Size(192, 54);
            customerProfileReturnButton.TabIndex = 11;
            customerProfileReturnButton.Text = "RETURN";
            customerProfileReturnButton.UseVisualStyleBackColor = false;
            customerProfileReturnButton.Click += customerProfileReturnButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.Image = Properties.Resources.account;
            pictureBox1.Location = new Point(439, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonFace;
            pictureBox2.Image = Properties.Resources.bgg;
            pictureBox2.Location = new Point(-4, -8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(811, 467);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Adobe Devanagari", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(247, 255);
            label3.Name = "label3";
            label3.Size = new Size(102, 43);
            label3.TabIndex = 14;
            label3.Text = "Points:";
            // 
            // customerProfilePointsLabel
            // 
            customerProfilePointsLabel.AutoSize = true;
            customerProfilePointsLabel.BackColor = SystemColors.ButtonFace;
            customerProfilePointsLabel.Font = new Font("Adobe Devanagari", 16F, FontStyle.Regular, GraphicsUnit.Point);
            customerProfilePointsLabel.Location = new Point(356, 248);
            customerProfilePointsLabel.Name = "customerProfilePointsLabel";
            customerProfilePointsLabel.Size = new Size(158, 43);
            customerProfilePointsLabel.TabIndex = 15;
            customerProfilePointsLabel.Text = "pointsLabel";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonFace;
            pictureBox3.Image = Properties.Resources.istockphoto_903533082_612x612;
            pictureBox3.Location = new Point(89, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(595, 349);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // CustomerProfileForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(customerProfilePointsLabel);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(customerProfileReturnButton);
            Controls.Add(customerProfileRankLabel);
            Controls.Add(customerProfilePhoneLabel);
            Controls.Add(customerProfileEmailLabel);
            Controls.Add(customerProfileLastNameLabel);
            Controls.Add(customerProfileFirstNameLabel);
            Controls.Add(label2);
            Controls.Add(customerRankLabel);
            Controls.Add(phone);
            Controls.Add(customerLastNameLabel);
            Controls.Add(customerFirstNameLabel);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Name = "CustomerProfileForm";
            Text = "CustomerProfileForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label customerFirstNameLabel;
        private Label customerLastNameLabel;
        private Label phone;
        private Label customerRankLabel;
        private Label label2;
        private Label customerProfileFirstNameLabel;
        private Label customerProfileLastNameLabel;
        private Label customerProfileEmailLabel;
        private Label customerProfilePhoneLabel;
        private Label customerProfileRankLabel;
        private Button customerProfileReturnButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label customerProfilePointsLabel;
        private PictureBox pictureBox3;
    }
}