namespace Cinema_Booking_System
{
    partial class CustomersCommentHistoryForm
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
            customerCommentHistoryTable = new DataGridView();
            customerCommentMovieName = new DataGridViewTextBoxColumn();
            customerCommentComment = new DataGridViewTextBoxColumn();
            commentHistoryCustomerCloseButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)customerCommentHistoryTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Desktop;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(245, 20);
            label1.Name = "label1";
            label1.Size = new Size(286, 45);
            label1.TabIndex = 0;
            label1.Text = "Comment History";
            // 
            // customerCommentHistoryTable
            // 
            customerCommentHistoryTable.AllowUserToAddRows = false;
            customerCommentHistoryTable.AllowUserToDeleteRows = false;
            customerCommentHistoryTable.BackgroundColor = SystemColors.ButtonHighlight;
            customerCommentHistoryTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerCommentHistoryTable.Columns.AddRange(new DataGridViewColumn[] { customerCommentMovieName, customerCommentComment });
            customerCommentHistoryTable.Location = new Point(12, 79);
            customerCommentHistoryTable.Name = "customerCommentHistoryTable";
            customerCommentHistoryTable.ReadOnly = true;
            customerCommentHistoryTable.RowHeadersWidth = 62;
            customerCommentHistoryTable.RowTemplate.Height = 33;
            customerCommentHistoryTable.Size = new Size(776, 270);
            customerCommentHistoryTable.TabIndex = 2;
            // 
            // customerCommentMovieName
            // 
            customerCommentMovieName.HeaderText = "Movie Name";
            customerCommentMovieName.MinimumWidth = 8;
            customerCommentMovieName.Name = "customerCommentMovieName";
            customerCommentMovieName.ReadOnly = true;
            customerCommentMovieName.Width = 250;
            // 
            // customerCommentComment
            // 
            customerCommentComment.HeaderText = "Comment";
            customerCommentComment.MinimumWidth = 8;
            customerCommentComment.Name = "customerCommentComment";
            customerCommentComment.ReadOnly = true;
            customerCommentComment.Width = 450;
            // 
            // commentHistoryCustomerCloseButton
            // 
            commentHistoryCustomerCloseButton.BackgroundImage = Properties.Resources.blk;
            commentHistoryCustomerCloseButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            commentHistoryCustomerCloseButton.ForeColor = SystemColors.ButtonHighlight;
            commentHistoryCustomerCloseButton.Location = new Point(305, 382);
            commentHistoryCustomerCloseButton.Name = "commentHistoryCustomerCloseButton";
            commentHistoryCustomerCloseButton.Size = new Size(141, 56);
            commentHistoryCustomerCloseButton.TabIndex = 3;
            commentHistoryCustomerCloseButton.Text = "Close";
            commentHistoryCustomerCloseButton.UseVisualStyleBackColor = true;
            commentHistoryCustomerCloseButton.Click += commentHistoryCustomerCloseButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._73578b94f836a03;
            pictureBox1.Location = new Point(-7, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(813, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // CustomersCommentHistoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(commentHistoryCustomerCloseButton);
            Controls.Add(customerCommentHistoryTable);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "CustomersCommentHistoryForm";
            Text = "CustomersCommentHistoryForm";
            ((System.ComponentModel.ISupportInitialize)customerCommentHistoryTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView customerCommentHistoryTable;
        private DataGridViewTextBoxColumn customerCommentMovieName;
        private DataGridViewTextBoxColumn customerCommentComment;
        private Button commentHistoryCustomerCloseButton;
        private PictureBox pictureBox1;
    }
}