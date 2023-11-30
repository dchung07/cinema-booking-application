namespace Cinema_Booking_System {
    partial class StaffForm {
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // logoutButton
            // 
            logoutButton.BackColor = SystemColors.InfoText;
            logoutButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            logoutButton.ForeColor = SystemColors.Control;
            logoutButton.Location = new Point(371, 18);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(106, 47);
            logoutButton.TabIndex = 1;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Desktop;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(23, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(263, 33);
            label1.TabIndex = 2;
            label1.Text = "DOT NET CINEMA";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InfoText;
            button1.BackgroundImage = Properties.Resources.bgg;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(269, 225);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(208, 41);
            button1.TabIndex = 6;
            button1.Text = "Manage Movies";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InfoText;
            button2.BackgroundImage = Properties.Resources.bgg;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(32, 225);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(208, 41);
            button2.TabIndex = 7;
            button2.Text = "Manage Customer Details";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.InfoText;
            button3.BackgroundImage = Properties.Resources.bgg;
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(269, 169);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(208, 41);
            button3.TabIndex = 8;
            button3.Text = "Manage Comments";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.InfoText;
            button4.BackgroundImage = Properties.Resources.bgg;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(32, 169);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(208, 41);
            button4.TabIndex = 9;
            button4.Text = "Manage Customer Bookings";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._360_F_225395390_OTi0yV3mgW4z6cEQrcIFHIEcqXnn3X6H;
            ClientSize = new Size(516, 291);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(logoutButton);
            Name = "StaffForm";
            Text = "Staff Menu";
            Load += StaffForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logoutButton;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}