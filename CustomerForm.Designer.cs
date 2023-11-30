namespace Cinema_Booking_System {
    partial class CustomerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            logoutButton = new Button();
            label1 = new Label();
            customerProfileButton = new Button();
            customerFormBookMovieButton = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            commentHistoryButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // logoutButton
            // 
            logoutButton.BackColor = SystemColors.InfoText;
            logoutButton.BackgroundImage = Properties.Resources.blk;
            logoutButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            logoutButton.ForeColor = SystemColors.Control;
            logoutButton.Location = new Point(440, 14);
            logoutButton.Margin = new Padding(2, 2, 2, 2);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(111, 41);
            logoutButton.TabIndex = 0;
            logoutButton.Text = "Log Out";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Desktop;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(22, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(263, 33);
            label1.TabIndex = 1;
            label1.Text = "DOT NET CINEMA";
            // 
            // customerProfileButton
            // 
            customerProfileButton.BackColor = SystemColors.InfoText;
            customerProfileButton.BackgroundImage = Properties.Resources.blu;
            customerProfileButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            customerProfileButton.ForeColor = SystemColors.ButtonHighlight;
            customerProfileButton.Location = new Point(344, 14);
            customerProfileButton.Margin = new Padding(2, 2, 2, 2);
            customerProfileButton.Name = "customerProfileButton";
            customerProfileButton.Size = new Size(92, 41);
            customerProfileButton.TabIndex = 2;
            customerProfileButton.Text = "Profile";
            customerProfileButton.UseVisualStyleBackColor = false;
            customerProfileButton.Click += customerProfileButton_Click;
            // 
            // customerFormBookMovieButton
            // 
            customerFormBookMovieButton.BackColor = SystemColors.Desktop;
            customerFormBookMovieButton.BackgroundImage = Properties.Resources.red;
            customerFormBookMovieButton.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point);
            customerFormBookMovieButton.ForeColor = SystemColors.ButtonHighlight;
            customerFormBookMovieButton.Location = new Point(143, 217);
            customerFormBookMovieButton.Margin = new Padding(2, 2, 2, 2);
            customerFormBookMovieButton.Name = "customerFormBookMovieButton";
            customerFormBookMovieButton.Size = new Size(267, 40);
            customerFormBookMovieButton.TabIndex = 3;
            customerFormBookMovieButton.Text = "Book a Movie!";
            customerFormBookMovieButton.UseVisualStyleBackColor = false;
            customerFormBookMovieButton.Click += customerFormBookMovieButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._360_F_225395390_OTi0yV3mgW4z6cEQrcIFHIEcqXnn3X6H;
            pictureBox1.Location = new Point(-12, 0);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(582, 278);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InfoText;
            button1.BackgroundImage = Properties.Resources.bgg;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(300, 167);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(208, 41);
            button1.TabIndex = 5;
            button1.Text = "Booking History";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // commentHistoryButton
            // 
            commentHistoryButton.BackColor = SystemColors.InfoText;
            commentHistoryButton.BackgroundImage = Properties.Resources.bgg;
            commentHistoryButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            commentHistoryButton.ForeColor = SystemColors.Control;
            commentHistoryButton.Location = new Point(78, 167);
            commentHistoryButton.Margin = new Padding(2, 2, 2, 2);
            commentHistoryButton.Name = "commentHistoryButton";
            commentHistoryButton.Size = new Size(208, 41);
            commentHistoryButton.TabIndex = 6;
            commentHistoryButton.Text = "Comment History";
            commentHistoryButton.UseVisualStyleBackColor = false;
            commentHistoryButton.Click += commentHistoryButton_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(commentHistoryButton);
            Controls.Add(button1);
            Controls.Add(logoutButton);
            Controls.Add(customerProfileButton);
            Controls.Add(label1);
            Controls.Add(customerFormBookMovieButton);
            Controls.Add(pictureBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CustomerForm";
            Text = "Customer Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logoutButton;
        private Label label1;
        private Button customerProfileButton;
        private Button customerFormBookMovieButton;
        private PictureBox pictureBox1;
        private Button button1;
        private Button commentHistoryButton;
    }
}