namespace Cinema_Booking_System {
    partial class StaffCommentForm {
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
            Remove = new Button();
            commentList = new ListView();
            Movie = new ColumnHeader();
            User = new ColumnHeader();
            Comment = new ColumnHeader();
            exit = new Button();
            SuspendLayout();
            // 
            // Remove
            // 
            Remove.Location = new Point(12, 251);
            Remove.Name = "Remove";
            Remove.Size = new Size(101, 31);
            Remove.TabIndex = 6;
            Remove.Text = "Remove";
            Remove.UseVisualStyleBackColor = true;
            Remove.Click += Remove_Click;
            // 
            // commentList
            // 
            commentList.BackColor = SystemColors.ControlDark;
            commentList.Columns.AddRange(new ColumnHeader[] { Movie, User, Comment });
            commentList.FullRowSelect = true;
            commentList.Location = new Point(12, 12);
            commentList.Name = "commentList";
            commentList.Size = new Size(605, 203);
            commentList.TabIndex = 4;
            commentList.UseCompatibleStateImageBehavior = false;
            commentList.View = View.Details;
            // 
            // Movie
            // 
            Movie.Text = "Movie";
            Movie.Width = 150;
            // 
            // User
            // 
            User.Text = "User ID";
            User.Width = 100;
            // 
            // Comment
            // 
            Comment.Text = "Comment";
            Comment.Width = 500;
            // 
            // exit
            // 
            exit.Location = new Point(515, 247);
            exit.Name = "exit";
            exit.Size = new Size(102, 35);
            exit.TabIndex = 7;
            exit.Text = "Return";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // StaffCommentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.blk;
            ClientSize = new Size(670, 320);
            Controls.Add(exit);
            Controls.Add(Remove);
            Controls.Add(commentList);
            Name = "StaffCommentForm";
            Text = "Comment Manager";
            Load += StaffCommentForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Remove;
        private ListView commentList;
        private ColumnHeader Movie;
        private ColumnHeader User;
        private ColumnHeader Comment;
        private Button exit;
    }
}