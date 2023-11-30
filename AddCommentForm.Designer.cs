namespace Cinema_Booking_System
{
    partial class AddCommentForm
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
            commentReviewTitleLabel = new Label();
            addCommentTextBox = new TextBox();
            commentSubmitButton = new Button();
            returnAddCommentButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // commentReviewTitleLabel
            // 
            commentReviewTitleLabel.AutoSize = true;
            commentReviewTitleLabel.BackColor = SystemColors.Desktop;
            commentReviewTitleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            commentReviewTitleLabel.ForeColor = SystemColors.ButtonHighlight;
            commentReviewTitleLabel.Location = new Point(65, 57);
            commentReviewTitleLabel.Name = "commentReviewTitleLabel";
            commentReviewTitleLabel.Size = new Size(244, 45);
            commentReviewTitleLabel.TabIndex = 0;
            commentReviewTitleLabel.Text = "Write a Review";
            // 
            // addCommentTextBox
            // 
            addCommentTextBox.Location = new Point(97, 180);
            addCommentTextBox.Name = "addCommentTextBox";
            addCommentTextBox.Size = new Size(551, 31);
            addCommentTextBox.TabIndex = 1;
            // 
            // commentSubmitButton
            // 
            commentSubmitButton.BackgroundImage = Properties.Resources.blu;
            commentSubmitButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            commentSubmitButton.ForeColor = SystemColors.ButtonHighlight;
            commentSubmitButton.Location = new Point(352, 379);
            commentSubmitButton.Name = "commentSubmitButton";
            commentSubmitButton.Size = new Size(145, 59);
            commentSubmitButton.TabIndex = 2;
            commentSubmitButton.Text = "Submit";
            commentSubmitButton.UseVisualStyleBackColor = true;
            commentSubmitButton.Click += commentSubmitButton_Click;
            // 
            // returnAddCommentButton
            // 
            returnAddCommentButton.BackgroundImage = Properties.Resources.blk;
            returnAddCommentButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            returnAddCommentButton.ForeColor = SystemColors.ButtonHighlight;
            returnAddCommentButton.Location = new Point(503, 379);
            returnAddCommentButton.Name = "returnAddCommentButton";
            returnAddCommentButton.Size = new Size(145, 59);
            returnAddCommentButton.TabIndex = 3;
            returnAddCommentButton.Text = "Return";
            returnAddCommentButton.UseVisualStyleBackColor = true;
            returnAddCommentButton.Click += returnAddCommentButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.istockphoto_903533082_612x612;
            pictureBox1.Location = new Point(56, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(644, 321);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._360_F_225395390_OTi0yV3mgW4z6cEQrcIFHIEcqXnn3X6H;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(808, 462);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // AddCommentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(returnAddCommentButton);
            Controls.Add(commentSubmitButton);
            Controls.Add(addCommentTextBox);
            Controls.Add(commentReviewTitleLabel);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "AddCommentForm";
            Text = "AddCommentForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label commentReviewTitleLabel;
        private TextBox addCommentTextBox;
        private Button commentSubmitButton;
        private Button returnAddCommentButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}