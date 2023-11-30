namespace Cinema_Booking_System
{
    partial class ManagePasswordForm
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
            ID = new TextBox();
            password = new TextBox();
            label2 = new Label();
            label3 = new Label();
            confirmBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HighlightText;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(55, 14);
            label1.Name = "label1";
            label1.Size = new Size(210, 25);
            label1.TabIndex = 0;
            label1.Text = "* Password Manager *";
            // 
            // ID
            // 
            ID.Location = new Point(159, 64);
            ID.Name = "ID";
            ID.Size = new Size(122, 23);
            ID.TabIndex = 1;
            // 
            // password
            // 
            password.Location = new Point(159, 93);
            password.Name = "password";
            password.Size = new Size(122, 23);
            password.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(121, 66);
            label2.Name = "label2";
            label2.Size = new Size(31, 21);
            label2.TabIndex = 3;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(27, 95);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 4;
            label3.Text = "New Password:";
            // 
            // confirmBtn
            // 
            confirmBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            confirmBtn.ForeColor = Color.FromArgb(0, 192, 0);
            confirmBtn.Location = new Point(180, 133);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(75, 27);
            confirmBtn.TabIndex = 5;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancelBtn.Location = new Point(55, 133);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 27);
            cancelBtn.TabIndex = 6;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // ManagePasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(316, 172);
            Controls.Add(cancelBtn);
            Controls.Add(confirmBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(password);
            Controls.Add(ID);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "ManagePasswordForm";
            Text = "ManagePasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ID;
        private TextBox password;
        private Label label2;
        private Label label3;
        private Button confirmBtn;
        private Button cancelBtn;
    }
}