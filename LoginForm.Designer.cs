namespace Cinema_Booking_System
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            idLabel = new Label();
            passwordLabel = new Label();
            instructionLabel = new Label();
            idTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            output = new Label();
            logInFormReturnButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(267, 151);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(21, 15);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(267, 196);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(60, 15);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password:";
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            instructionLabel.Location = new Point(258, 100);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(232, 19);
            instructionLabel.TabIndex = 2;
            instructionLabel.Text = "Please Enter Your Account Details";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(391, 143);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(100, 23);
            idTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(391, 193);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(100, 23);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.HotTrack;
            loginButton.BackgroundImage = Properties.Resources.Untitled;
            loginButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = SystemColors.ButtonHighlight;
            loginButton.Location = new Point(401, 268);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // output
            // 
            output.AutoSize = true;
            output.Location = new Point(267, 236);
            output.Name = "output";
            output.Size = new Size(0, 15);
            output.TabIndex = 6;
            // 
            // logInFormReturnButton
            // 
            logInFormReturnButton.BackColor = SystemColors.HotTrack;
            logInFormReturnButton.BackgroundImage = Properties.Resources.Untitled1;
            logInFormReturnButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            logInFormReturnButton.ForeColor = SystemColors.ButtonHighlight;
            logInFormReturnButton.Location = new Point(258, 268);
            logInFormReturnButton.Margin = new Padding(2);
            logInFormReturnButton.Name = "logInFormReturnButton";
            logInFormReturnButton.Size = new Size(78, 23);
            logInFormReturnButton.TabIndex = 7;
            logInFormReturnButton.Text = "Return";
            logInFormReturnButton.UseVisualStyleBackColor = false;
            logInFormReturnButton.Click += logInFormReturnButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.istockphoto_903533082_612x612;
            pictureBox1.Location = new Point(232, 88);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.Image = Properties.Resources.Untitled;
            pictureBox2.Location = new Point(-6, -6);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(827, 469);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logInFormReturnButton);
            Controls.Add(output);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(idTextBox);
            Controls.Add(instructionLabel);
            Controls.Add(passwordLabel);
            Controls.Add(idLabel);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "LoginForm";
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idLabel;
        private Label passwordLabel;
        private Label instructionLabel;
        private TextBox idTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Label output;
        private Button logInFormReturnButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}