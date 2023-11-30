namespace Cinema_Booking_System
{
    partial class SignUpForm
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
            signUpLabel = new Label();
            signUpFirstNameLabel = new Label();
            signUpLastNameLabel = new Label();
            signUpEmailLabel = new Label();
            signUpPasswordLabel = new Label();
            signUpFirstNameTextBox = new TextBox();
            signUpLastNameTextBox = new TextBox();
            signUpEmailTextBox = new TextBox();
            signUpPasswordTextBox = new TextBox();
            signUpButton = new Button();
            signUpFormReturnButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            signUpPhoneTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // signUpLabel
            // 
            signUpLabel.AutoSize = true;
            signUpLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            signUpLabel.Location = new Point(229, 27);
            signUpLabel.Margin = new Padding(2, 0, 2, 0);
            signUpLabel.Name = "signUpLabel";
            signUpLabel.Size = new Size(65, 19);
            signUpLabel.TabIndex = 0;
            signUpLabel.Text = "SIGN UP";
            // 
            // signUpFirstNameLabel
            // 
            signUpFirstNameLabel.AutoSize = true;
            signUpFirstNameLabel.Location = new Point(150, 79);
            signUpFirstNameLabel.Margin = new Padding(2, 0, 2, 0);
            signUpFirstNameLabel.Name = "signUpFirstNameLabel";
            signUpFirstNameLabel.Size = new Size(67, 15);
            signUpFirstNameLabel.TabIndex = 1;
            signUpFirstNameLabel.Text = "First Name:";
            // 
            // signUpLastNameLabel
            // 
            signUpLastNameLabel.AutoSize = true;
            signUpLastNameLabel.Location = new Point(151, 109);
            signUpLastNameLabel.Margin = new Padding(2, 0, 2, 0);
            signUpLastNameLabel.Name = "signUpLastNameLabel";
            signUpLastNameLabel.Size = new Size(66, 15);
            signUpLastNameLabel.TabIndex = 2;
            signUpLastNameLabel.Text = "Last Name:";
            // 
            // signUpEmailLabel
            // 
            signUpEmailLabel.AutoSize = true;
            signUpEmailLabel.Location = new Point(180, 137);
            signUpEmailLabel.Margin = new Padding(2, 0, 2, 0);
            signUpEmailLabel.Name = "signUpEmailLabel";
            signUpEmailLabel.Size = new Size(39, 15);
            signUpEmailLabel.TabIndex = 3;
            signUpEmailLabel.Text = "Email:";
            // 
            // signUpPasswordLabel
            // 
            signUpPasswordLabel.AutoSize = true;
            signUpPasswordLabel.Location = new Point(157, 190);
            signUpPasswordLabel.Margin = new Padding(2, 0, 2, 0);
            signUpPasswordLabel.Name = "signUpPasswordLabel";
            signUpPasswordLabel.Size = new Size(60, 15);
            signUpPasswordLabel.TabIndex = 4;
            signUpPasswordLabel.Text = "Password:";
            // 
            // signUpFirstNameTextBox
            // 
            signUpFirstNameTextBox.Location = new Point(248, 79);
            signUpFirstNameTextBox.Margin = new Padding(2, 2, 2, 2);
            signUpFirstNameTextBox.Name = "signUpFirstNameTextBox";
            signUpFirstNameTextBox.Size = new Size(106, 23);
            signUpFirstNameTextBox.TabIndex = 5;
            // 
            // signUpLastNameTextBox
            // 
            signUpLastNameTextBox.Location = new Point(248, 107);
            signUpLastNameTextBox.Margin = new Padding(2, 2, 2, 2);
            signUpLastNameTextBox.Name = "signUpLastNameTextBox";
            signUpLastNameTextBox.Size = new Size(106, 23);
            signUpLastNameTextBox.TabIndex = 6;
            // 
            // signUpEmailTextBox
            // 
            signUpEmailTextBox.Location = new Point(248, 137);
            signUpEmailTextBox.Margin = new Padding(2, 2, 2, 2);
            signUpEmailTextBox.Name = "signUpEmailTextBox";
            signUpEmailTextBox.Size = new Size(106, 23);
            signUpEmailTextBox.TabIndex = 7;
            // 
            // signUpPasswordTextBox
            // 
            signUpPasswordTextBox.Location = new Point(248, 190);
            signUpPasswordTextBox.Margin = new Padding(2, 2, 2, 2);
            signUpPasswordTextBox.Name = "signUpPasswordTextBox";
            signUpPasswordTextBox.Size = new Size(106, 23);
            signUpPasswordTextBox.TabIndex = 8;
            // 
            // signUpButton
            // 
            signUpButton.BackgroundImage = Properties.Resources._360_F_336456579_K00FCLKIIbG6vtiWbnbqVcUuvVv35GSF;
            signUpButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            signUpButton.ForeColor = SystemColors.ButtonFace;
            signUpButton.Location = new Point(260, 219);
            signUpButton.Margin = new Padding(2, 2, 2, 2);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(78, 25);
            signUpButton.TabIndex = 9;
            signUpButton.Text = "SIGN UP";
            signUpButton.UseVisualStyleBackColor = true;
            signUpButton.Click += signUpButton_Click;
            // 
            // signUpFormReturnButton
            // 
            signUpFormReturnButton.BackgroundImage = Properties.Resources._360_F_336456579_K00FCLKIIbG6vtiWbnbqVcUuvVv35GSF;
            signUpFormReturnButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            signUpFormReturnButton.ForeColor = SystemColors.ButtonFace;
            signUpFormReturnButton.Location = new Point(157, 219);
            signUpFormReturnButton.Margin = new Padding(2, 2, 2, 2);
            signUpFormReturnButton.Name = "signUpFormReturnButton";
            signUpFormReturnButton.Size = new Size(78, 25);
            signUpFormReturnButton.TabIndex = 10;
            signUpFormReturnButton.Text = "Return";
            signUpFormReturnButton.UseVisualStyleBackColor = true;
            signUpFormReturnButton.Click += signUpFormReturnButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._360_F_336456579_K00FCLKIIbG6vtiWbnbqVcUuvVv35GSF;
            pictureBox1.Location = new Point(-8, -4);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(570, 278);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.istockphoto_903533082_612x612;
            pictureBox2.Location = new Point(128, 7);
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(265, 250);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 164);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 13;
            label1.Text = "Phone:";
            // 
            // signUpPhoneTextBox
            // 
            signUpPhoneTextBox.Location = new Point(248, 163);
            signUpPhoneTextBox.Margin = new Padding(2, 2, 2, 2);
            signUpPhoneTextBox.Name = "signUpPhoneTextBox";
            signUpPhoneTextBox.Size = new Size(106, 23);
            signUpPhoneTextBox.TabIndex = 14;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(signUpPhoneTextBox);
            Controls.Add(label1);
            Controls.Add(signUpFormReturnButton);
            Controls.Add(signUpButton);
            Controls.Add(signUpPasswordTextBox);
            Controls.Add(signUpEmailTextBox);
            Controls.Add(signUpLastNameTextBox);
            Controls.Add(signUpFirstNameTextBox);
            Controls.Add(signUpPasswordLabel);
            Controls.Add(signUpEmailLabel);
            Controls.Add(signUpLastNameLabel);
            Controls.Add(signUpFirstNameLabel);
            Controls.Add(signUpLabel);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "SignUpForm";
            Text = "SignUpForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label signUpLabel;
        private Label signUpFirstNameLabel;
        private Label signUpLastNameLabel;
        private Label signUpEmailLabel;
        private Label signUpPasswordLabel;
        private TextBox signUpFirstNameTextBox;
        private TextBox signUpLastNameTextBox;
        private TextBox signUpEmailTextBox;
        private TextBox signUpPasswordTextBox;
        private Button signUpButton;
        private Button signUpFormReturnButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox signUpPhoneTextBox;
    }
}