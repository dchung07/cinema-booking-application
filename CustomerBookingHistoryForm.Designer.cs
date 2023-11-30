namespace Cinema_Booking_System {
    partial class CustomerBookingHistoryForm {
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
            label1 = new Label();
            movieBookingHistoryTable = new DataGridView();
            bookingHistoryCustomerName = new DataGridViewTextBoxColumn();
            bookingHistoryMovieName = new DataGridViewTextBoxColumn();
            bookingHistoryQuantity = new DataGridViewTextBoxColumn();
            bookingHistoryCloseButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            cancelCustomerBookingButton = new Button();
            ((System.ComponentModel.ISupportInitialize)movieBookingHistoryTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Desktop;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(187, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 30);
            label1.TabIndex = 0;
            label1.Text = "Booking History";
            // 
            // movieBookingHistoryTable
            // 
            movieBookingHistoryTable.AllowUserToAddRows = false;
            movieBookingHistoryTable.AllowUserToDeleteRows = false;
            movieBookingHistoryTable.BackgroundColor = SystemColors.ButtonHighlight;
            movieBookingHistoryTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            movieBookingHistoryTable.Columns.AddRange(new DataGridViewColumn[] { bookingHistoryCustomerName, bookingHistoryMovieName, bookingHistoryQuantity });
            movieBookingHistoryTable.Location = new Point(47, 53);
            movieBookingHistoryTable.Margin = new Padding(2);
            movieBookingHistoryTable.Name = "movieBookingHistoryTable";
            movieBookingHistoryTable.ReadOnly = true;
            movieBookingHistoryTable.RowHeadersWidth = 62;
            movieBookingHistoryTable.RowTemplate.Height = 33;
            movieBookingHistoryTable.Size = new Size(472, 162);
            movieBookingHistoryTable.TabIndex = 2;
            // 
            // bookingHistoryCustomerName
            // 
            bookingHistoryCustomerName.HeaderText = "Customer Name";
            bookingHistoryCustomerName.MinimumWidth = 8;
            bookingHistoryCustomerName.Name = "bookingHistoryCustomerName";
            bookingHistoryCustomerName.ReadOnly = true;
            bookingHistoryCustomerName.Width = 150;
            // 
            // bookingHistoryMovieName
            // 
            bookingHistoryMovieName.HeaderText = "Movie Name";
            bookingHistoryMovieName.MinimumWidth = 8;
            bookingHistoryMovieName.Name = "bookingHistoryMovieName";
            bookingHistoryMovieName.ReadOnly = true;
            bookingHistoryMovieName.Width = 350;
            // 
            // bookingHistoryQuantity
            // 
            bookingHistoryQuantity.HeaderText = "Quantity";
            bookingHistoryQuantity.MinimumWidth = 8;
            bookingHistoryQuantity.Name = "bookingHistoryQuantity";
            bookingHistoryQuantity.ReadOnly = true;
            bookingHistoryQuantity.Width = 150;
            // 
            // bookingHistoryCloseButton
            // 
            bookingHistoryCloseButton.BackgroundImage = Properties.Resources.blk;
            bookingHistoryCloseButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            bookingHistoryCloseButton.ForeColor = SystemColors.ButtonFace;
            bookingHistoryCloseButton.Location = new Point(300, 227);
            bookingHistoryCloseButton.Margin = new Padding(2);
            bookingHistoryCloseButton.Name = "bookingHistoryCloseButton";
            bookingHistoryCloseButton.Size = new Size(90, 36);
            bookingHistoryCloseButton.TabIndex = 3;
            bookingHistoryCloseButton.Text = "Close";
            bookingHistoryCloseButton.UseVisualStyleBackColor = true;
            bookingHistoryCloseButton.Click += bookingHistoryCloseButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.istockphoto_903533082_612x612;
            pictureBox1.Location = new Point(23, 14);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 209);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.blu;
            pictureBox2.Location = new Point(-1, -4);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(565, 277);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // cancelCustomerBookingButton
            // 
            cancelCustomerBookingButton.BackgroundImage = Properties.Resources.cinema_4609877_640;
            cancelCustomerBookingButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            cancelCustomerBookingButton.ForeColor = SystemColors.ButtonFace;
            cancelCustomerBookingButton.Location = new Point(187, 227);
            cancelCustomerBookingButton.Margin = new Padding(2);
            cancelCustomerBookingButton.Name = "cancelCustomerBookingButton";
            cancelCustomerBookingButton.Size = new Size(90, 36);
            cancelCustomerBookingButton.TabIndex = 6;
            cancelCustomerBookingButton.Text = "Cancel Booking";
            cancelCustomerBookingButton.UseVisualStyleBackColor = true;
            cancelCustomerBookingButton.Click += cancelCustomerBookingButton_Click;
            // 
            // CustomerBookingHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(cancelCustomerBookingButton);
            Controls.Add(bookingHistoryCloseButton);
            Controls.Add(movieBookingHistoryTable);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Margin = new Padding(2);
            Name = "CustomerBookingHistoryForm";
            Text = "CustomerBookingHistoryForm";
            Load += CustomerBookingHistoryForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)movieBookingHistoryTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView movieBookingHistoryTable;
        private DataGridViewTextBoxColumn bookingHistoryCustomerName;
        private DataGridViewTextBoxColumn bookingHistoryMovieName;
        private DataGridViewTextBoxColumn bookingHistoryQuantity;
        private Button bookingHistoryCloseButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button cancelCustomerBookingButton;
    }
}