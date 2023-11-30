namespace Cinema_Booking_System
{
    partial class CommentSectionForm
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
            commentTable = new DataGridView();
            commentMovieName = new DataGridViewTextBoxColumn();
            commentSectionReviewerName = new DataGridViewTextBoxColumn();
            commentSectionComment = new DataGridViewTextBoxColumn();
            label1 = new Label();
            returnCommentSectionButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)commentTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // commentTable
            // 
            commentTable.AllowUserToAddRows = false;
            commentTable.AllowUserToDeleteRows = false;
            commentTable.BackgroundColor = SystemColors.ButtonHighlight;
            commentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            commentTable.Columns.AddRange(new DataGridViewColumn[] { commentMovieName, commentSectionReviewerName, commentSectionComment });
            commentTable.Location = new Point(24, 90);
            commentTable.Name = "commentTable";
            commentTable.ReadOnly = true;
            commentTable.RowHeadersWidth = 62;
            commentTable.RowTemplate.Height = 33;
            commentTable.Size = new Size(749, 270);
            commentTable.TabIndex = 2;
            // 
            // commentMovieName
            // 
            commentMovieName.HeaderText = "Movie Name";
            commentMovieName.MinimumWidth = 8;
            commentMovieName.Name = "commentMovieName";
            commentMovieName.ReadOnly = true;
            commentMovieName.Width = 200;
            // 
            // commentSectionReviewerName
            // 
            commentSectionReviewerName.HeaderText = "Commenter Name";
            commentSectionReviewerName.MinimumWidth = 8;
            commentSectionReviewerName.Name = "commentSectionReviewerName";
            commentSectionReviewerName.ReadOnly = true;
            commentSectionReviewerName.Width = 110;
            // 
            // commentSectionComment
            // 
            commentSectionComment.HeaderText = "Comment";
            commentSectionComment.MinimumWidth = 8;
            commentSectionComment.Name = "commentSectionComment";
            commentSectionComment.ReadOnly = true;
            commentSectionComment.Width = 400;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HotTrack;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(180, 17);
            label1.Name = "label1";
            label1.Size = new Size(463, 70);
            label1.TabIndex = 3;
            label1.Text = "Comment Section";
            // 
            // returnCommentSectionButton
            // 
            returnCommentSectionButton.BackgroundImage = Properties.Resources.blk;
            returnCommentSectionButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            returnCommentSectionButton.ForeColor = SystemColors.ButtonHighlight;
            returnCommentSectionButton.Location = new Point(309, 381);
            returnCommentSectionButton.Name = "returnCommentSectionButton";
            returnCommentSectionButton.Size = new Size(172, 57);
            returnCommentSectionButton.TabIndex = 5;
            returnCommentSectionButton.Text = "Return";
            returnCommentSectionButton.UseVisualStyleBackColor = true;
            returnCommentSectionButton.Click += returnCommentSectionButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.istockphoto_903533082_612x612;
            pictureBox1.Location = new Point(17, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(771, 367);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._360_F_336456579_K00FCLKIIbG6vtiWbnbqVcUuvVv35GSF;
            pictureBox2.Location = new Point(-8, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(812, 454);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // CommentSectionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(returnCommentSectionButton);
            Controls.Add(label1);
            Controls.Add(commentTable);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "CommentSectionForm";
            Text = "CommentSectionForm";
            ((System.ComponentModel.ISupportInitialize)commentTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView commentTable;
        private Label label1;
        private DataGridViewTextBoxColumn commentMovieName;
        private DataGridViewTextBoxColumn commentSectionReviewerName;
        private DataGridViewTextBoxColumn commentSectionComment;
        private Button returnCommentSectionButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}