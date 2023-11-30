namespace Cinema_Booking_System
{
    partial class LandingPageForm
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
            landingPageLogInButton = new Button();
            landingPageSignUpButton = new Button();
            pictureBox1 = new PictureBox();
            landingPageExitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(105, 75);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(354, 44);
            label1.TabIndex = 0;
            label1.Text = "DOT NET CINEMA";
            // 
            // landingPageLogInButton
            // 
            landingPageLogInButton.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            landingPageLogInButton.Location = new Point(157, 188);
            landingPageLogInButton.Margin = new Padding(2);
            landingPageLogInButton.Name = "landingPageLogInButton";
            landingPageLogInButton.Size = new Size(108, 29);
            landingPageLogInButton.TabIndex = 1;
            landingPageLogInButton.Text = "LOG IN";
            landingPageLogInButton.UseVisualStyleBackColor = true;
            landingPageLogInButton.Click += landingPageLogInButton_Click;
            // 
            // landingPageSignUpButton
            // 
            landingPageSignUpButton.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            landingPageSignUpButton.Location = new Point(299, 188);
            landingPageSignUpButton.Margin = new Padding(2);
            landingPageSignUpButton.Name = "landingPageSignUpButton";
            landingPageSignUpButton.Size = new Size(128, 29);
            landingPageSignUpButton.TabIndex = 2;
            landingPageSignUpButton.Text = "SIGN UP";
            landingPageSignUpButton.UseVisualStyleBackColor = true;
            landingPageSignUpButton.Click += landingPageSignUpButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vecteezy_theater_curtain_clipart_design_illustration_9400742_31;
            pictureBox1.Location = new Point(-22, -18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(605, 279);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // landingPageExitButton
            // 
            landingPageExitButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            landingPageExitButton.Location = new Point(229, 232);
            landingPageExitButton.Name = "landingPageExitButton";
            landingPageExitButton.Size = new Size(108, 29);
            landingPageExitButton.TabIndex = 4;
            landingPageExitButton.Text = "EXIT";
            landingPageExitButton.UseVisualStyleBackColor = true;
            landingPageExitButton.Click += landingPageExitButton_Click;
            // 
            // LandingPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(560, 270);
            Controls.Add(landingPageExitButton);
            Controls.Add(landingPageSignUpButton);
            Controls.Add(landingPageLogInButton);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "LandingPageForm";
            Text = "LandingPageForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button landingPageLogInButton;
        private Button landingPageSignUpButton;
        private PictureBox pictureBox1;
        private Button landingPageExitButton;
    }
}