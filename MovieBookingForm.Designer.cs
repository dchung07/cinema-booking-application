namespace Cinema_Booking_System
{
    partial class MovieBookingForm
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
            movieBookingTitleLabel = new Label();
            movieTable = new DataGridView();
            bookingMovieName = new DataGridViewTextBoxColumn();
            bookingMovieGenre = new DataGridViewTextBoxColumn();
            bookingMovieRuntime = new DataGridViewTextBoxColumn();
            bookingMoviePrice = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            bookMovieReturnButton = new Button();
            purchaseButton = new Button();
            viewCommentsButton = new Button();
            addCommentButton = new Button();
            ((System.ComponentModel.ISupportInitialize)movieTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // movieBookingTitleLabel
            // 
            movieBookingTitleLabel.AutoSize = true;
            movieBookingTitleLabel.BackColor = SystemColors.Desktop;
            movieBookingTitleLabel.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold, GraphicsUnit.Point);
            movieBookingTitleLabel.ForeColor = SystemColors.ButtonFace;
            movieBookingTitleLabel.Location = new Point(162, 5);
            movieBookingTitleLabel.Margin = new Padding(2, 0, 2, 0);
            movieBookingTitleLabel.Name = "movieBookingTitleLabel";
            movieBookingTitleLabel.Size = new Size(260, 44);
            movieBookingTitleLabel.TabIndex = 0;
            movieBookingTitleLabel.Text = "Book a Movie";
            // 
            // movieTable
            // 
            movieTable.AllowUserToAddRows = false;
            movieTable.AllowUserToDeleteRows = false;
            movieTable.BackgroundColor = SystemColors.ButtonHighlight;
            movieTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            movieTable.Columns.AddRange(new DataGridViewColumn[] { bookingMovieName, bookingMovieGenre, bookingMovieRuntime, bookingMoviePrice });
            movieTable.Location = new Point(28, 58);
            movieTable.Margin = new Padding(2, 2, 2, 2);
            movieTable.Name = "movieTable";
            movieTable.ReadOnly = true;
            movieTable.RowHeadersWidth = 62;
            movieTable.RowTemplate.Height = 33;
            movieTable.Size = new Size(500, 162);
            movieTable.TabIndex = 1;
            movieTable.CellContentClick += movieTable_CellContentClick;
            // 
            // bookingMovieName
            // 
            bookingMovieName.HeaderText = "Movie Name";
            bookingMovieName.MinimumWidth = 8;
            bookingMovieName.Name = "bookingMovieName";
            bookingMovieName.ReadOnly = true;
            bookingMovieName.Width = 250;
            // 
            // bookingMovieGenre
            // 
            bookingMovieGenre.HeaderText = "Genre";
            bookingMovieGenre.MinimumWidth = 8;
            bookingMovieGenre.Name = "bookingMovieGenre";
            bookingMovieGenre.ReadOnly = true;
            bookingMovieGenre.Width = 150;
            // 
            // bookingMovieRuntime
            // 
            bookingMovieRuntime.HeaderText = "Runtime (Minutes)";
            bookingMovieRuntime.MinimumWidth = 8;
            bookingMovieRuntime.Name = "bookingMovieRuntime";
            bookingMovieRuntime.ReadOnly = true;
            bookingMovieRuntime.Width = 150;
            // 
            // bookingMoviePrice
            // 
            bookingMoviePrice.HeaderText = "Price ($)";
            bookingMoviePrice.MinimumWidth = 8;
            bookingMoviePrice.Name = "bookingMoviePrice";
            bookingMoviePrice.ReadOnly = true;
            bookingMoviePrice.Width = 150;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._73578b94f836a03;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(567, 277);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // bookMovieReturnButton
            // 
            bookMovieReturnButton.BackgroundImage = Properties.Resources._360_F_336456579_K00FCLKIIbG6vtiWbnbqVcUuvVv35GSF;
            bookMovieReturnButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            bookMovieReturnButton.ForeColor = SystemColors.ButtonHighlight;
            bookMovieReturnButton.Location = new Point(456, 232);
            bookMovieReturnButton.Margin = new Padding(2, 2, 2, 2);
            bookMovieReturnButton.Name = "bookMovieReturnButton";
            bookMovieReturnButton.Size = new Size(87, 36);
            bookMovieReturnButton.TabIndex = 3;
            bookMovieReturnButton.Text = "Return";
            bookMovieReturnButton.UseVisualStyleBackColor = true;
            bookMovieReturnButton.Click += bookMovieReturnButton_Click;
            // 
            // purchaseButton
            // 
            purchaseButton.BackgroundImage = Properties.Resources.blu;
            purchaseButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            purchaseButton.ForeColor = SystemColors.ButtonHighlight;
            purchaseButton.Location = new Point(15, 232);
            purchaseButton.Margin = new Padding(2, 2, 2, 2);
            purchaseButton.Name = "purchaseButton";
            purchaseButton.Size = new Size(102, 36);
            purchaseButton.TabIndex = 4;
            purchaseButton.Text = "Purchase";
            purchaseButton.UseVisualStyleBackColor = true;
            purchaseButton.Click += purchaseButton_Click;
            // 
            // viewCommentsButton
            // 
            viewCommentsButton.BackgroundImage = Properties.Resources.blk;
            viewCommentsButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            viewCommentsButton.ForeColor = SystemColors.ButtonHighlight;
            viewCommentsButton.Location = new Point(121, 233);
            viewCommentsButton.Margin = new Padding(2, 2, 2, 2);
            viewCommentsButton.Name = "viewCommentsButton";
            viewCommentsButton.Size = new Size(168, 34);
            viewCommentsButton.TabIndex = 5;
            viewCommentsButton.Text = "View Comments";
            viewCommentsButton.UseVisualStyleBackColor = true;
            viewCommentsButton.Click += viewCommentsButton_Click;
            // 
            // addCommentButton
            // 
            addCommentButton.BackgroundImage = Properties.Resources.Untitled1;
            addCommentButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            addCommentButton.ForeColor = SystemColors.ButtonHighlight;
            addCommentButton.Location = new Point(298, 233);
            addCommentButton.Margin = new Padding(2, 2, 2, 2);
            addCommentButton.Name = "addCommentButton";
            addCommentButton.Size = new Size(153, 34);
            addCommentButton.TabIndex = 6;
            addCommentButton.Text = "Add Comment";
            addCommentButton.UseVisualStyleBackColor = true;
            addCommentButton.Click += addCommentButton_Click;
            // 
            // MovieBookingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(addCommentButton);
            Controls.Add(viewCommentsButton);
            Controls.Add(purchaseButton);
            Controls.Add(bookMovieReturnButton);
            Controls.Add(movieTable);
            Controls.Add(movieBookingTitleLabel);
            Controls.Add(pictureBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MovieBookingForm";
            Text = "MovieBookingForm";
            ((System.ComponentModel.ISupportInitialize)movieTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label movieBookingTitleLabel;
        private DataGridView movieTable;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn bookingMovieName;
        private DataGridViewTextBoxColumn bookingMovieGenre;
        private DataGridViewTextBoxColumn bookingMovieRuntime;
        private DataGridViewTextBoxColumn bookingMoviePrice;
        private Button bookMovieReturnButton;
        private Button purchaseButton;
        private Button viewCommentsButton;
        private Button addCommentButton;
    }
}