namespace Cinema_Booking_System
{
    partial class PurchaseForm
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
            purchaseFormTitleLabel = new Label();
            label2 = new Label();
            selectQuantityTicketsBox = new ComboBox();
            label1 = new Label();
            colorDialog1 = new ColorDialog();
            ticketPriceLabel = new Label();
            purchaseTicketConfirmButton = new Button();
            discountedPriceLabel = new Label();
            discountedTicketPriceLabel = new Label();
            rankDiscountStatusLabel = new Label();
            purchaseTicketCancelButton = new Button();
            label3 = new Label();
            singleTicketPrice = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // purchaseFormTitleLabel
            // 
            purchaseFormTitleLabel.AutoSize = true;
            purchaseFormTitleLabel.BackColor = SystemColors.Desktop;
            purchaseFormTitleLabel.Font = new Font("SimSun-ExtB", 14F, FontStyle.Bold, GraphicsUnit.Point);
            purchaseFormTitleLabel.ForeColor = SystemColors.ButtonFace;
            purchaseFormTitleLabel.Location = new Point(19, 18);
            purchaseFormTitleLabel.Margin = new Padding(2, 0, 2, 0);
            purchaseFormTitleLabel.Name = "purchaseFormTitleLabel";
            purchaseFormTitleLabel.Size = new Size(174, 19);
            purchaseFormTitleLabel.TabIndex = 0;
            purchaseFormTitleLabel.Text = "Purchase Ticket";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(139, 83);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 1;
            label2.Text = "Select Quantity:";
            // 
            // selectQuantityTicketsBox
            // 
            selectQuantityTicketsBox.FormattingEnabled = true;
            selectQuantityTicketsBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            selectQuantityTicketsBox.Location = new Point(290, 86);
            selectQuantityTicketsBox.Margin = new Padding(2, 2, 2, 2);
            selectQuantityTicketsBox.Name = "selectQuantityTicketsBox";
            selectQuantityTicketsBox.Size = new Size(129, 23);
            selectQuantityTicketsBox.TabIndex = 2;
            selectQuantityTicketsBox.SelectedIndexChanged += selectQuantityTicketsBox_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(124, 112);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 30);
            label1.TabIndex = 3;
            label1.Text = "Original Price:";
            // 
            // ticketPriceLabel
            // 
            ticketPriceLabel.AutoSize = true;
            ticketPriceLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ticketPriceLabel.Location = new Point(318, 112);
            ticketPriceLabel.Margin = new Padding(2, 0, 2, 0);
            ticketPriceLabel.Name = "ticketPriceLabel";
            ticketPriceLabel.Size = new Size(60, 30);
            ticketPriceLabel.TabIndex = 4;
            ticketPriceLabel.Text = "Price";
            ticketPriceLabel.Click += ticketPriceLabel_Click;
            // 
            // purchaseTicketConfirmButton
            // 
            purchaseTicketConfirmButton.BackgroundImage = Properties.Resources.blk;
            purchaseTicketConfirmButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            purchaseTicketConfirmButton.ForeColor = SystemColors.ButtonFace;
            purchaseTicketConfirmButton.Location = new Point(326, 230);
            purchaseTicketConfirmButton.Margin = new Padding(2, 2, 2, 2);
            purchaseTicketConfirmButton.Name = "purchaseTicketConfirmButton";
            purchaseTicketConfirmButton.Size = new Size(225, 33);
            purchaseTicketConfirmButton.TabIndex = 5;
            purchaseTicketConfirmButton.Text = "Confirm Purchase";
            purchaseTicketConfirmButton.UseVisualStyleBackColor = true;
            purchaseTicketConfirmButton.Click += purchaseTicketConfirmButton_Click;
            // 
            // discountedPriceLabel
            // 
            discountedPriceLabel.AutoSize = true;
            discountedPriceLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            discountedPriceLabel.Location = new Point(318, 147);
            discountedPriceLabel.Margin = new Padding(2, 0, 2, 0);
            discountedPriceLabel.Name = "discountedPriceLabel";
            discountedPriceLabel.Size = new Size(60, 30);
            discountedPriceLabel.TabIndex = 7;
            discountedPriceLabel.Text = "Price";
            // 
            // discountedTicketPriceLabel
            // 
            discountedTicketPriceLabel.AutoSize = true;
            discountedTicketPriceLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            discountedTicketPriceLabel.Location = new Point(90, 147);
            discountedTicketPriceLabel.Margin = new Padding(2, 0, 2, 0);
            discountedTicketPriceLabel.Name = "discountedTicketPriceLabel";
            discountedTicketPriceLabel.Size = new Size(194, 30);
            discountedTicketPriceLabel.TabIndex = 6;
            discountedTicketPriceLabel.Text = "Discounted Price:";
            // 
            // rankDiscountStatusLabel
            // 
            rankDiscountStatusLabel.AutoSize = true;
            rankDiscountStatusLabel.Font = new Font("Impact", 18F, FontStyle.Bold, GraphicsUnit.Point);
            rankDiscountStatusLabel.Location = new Point(90, 188);
            rankDiscountStatusLabel.Margin = new Padding(2, 0, 2, 0);
            rankDiscountStatusLabel.Name = "rankDiscountStatusLabel";
            rankDiscountStatusLabel.Size = new Size(223, 29);
            rankDiscountStatusLabel.TabIndex = 8;
            rankDiscountStatusLabel.Text = "Rank level Discount";
            // 
            // purchaseTicketCancelButton
            // 
            purchaseTicketCancelButton.BackgroundImage = Properties.Resources.red;
            purchaseTicketCancelButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            purchaseTicketCancelButton.ForeColor = SystemColors.ButtonFace;
            purchaseTicketCancelButton.Location = new Point(220, 230);
            purchaseTicketCancelButton.Margin = new Padding(2, 2, 2, 2);
            purchaseTicketCancelButton.Name = "purchaseTicketCancelButton";
            purchaseTicketCancelButton.Size = new Size(102, 33);
            purchaseTicketCancelButton.TabIndex = 9;
            purchaseTicketCancelButton.Text = "Cancel";
            purchaseTicketCancelButton.UseVisualStyleBackColor = true;
            purchaseTicketCancelButton.Click += purchaseTicketCancelButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(112, 51);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(169, 25);
            label3.TabIndex = 10;
            label3.Text = "Single Ticket Price:";
            // 
            // singleTicketPrice
            // 
            singleTicketPrice.AutoSize = true;
            singleTicketPrice.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            singleTicketPrice.Location = new Point(290, 51);
            singleTicketPrice.Margin = new Padding(2, 0, 2, 0);
            singleTicketPrice.Name = "singleTicketPrice";
            singleTicketPrice.Size = new Size(60, 30);
            singleTicketPrice.TabIndex = 11;
            singleTicketPrice.Text = "Price";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.istockphoto_903533082_612x612;
            pictureBox1.Location = new Point(15, 11);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(526, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.blk;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(570, 276);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // PurchaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(singleTicketPrice);
            Controls.Add(label3);
            Controls.Add(purchaseTicketCancelButton);
            Controls.Add(rankDiscountStatusLabel);
            Controls.Add(discountedPriceLabel);
            Controls.Add(discountedTicketPriceLabel);
            Controls.Add(purchaseTicketConfirmButton);
            Controls.Add(ticketPriceLabel);
            Controls.Add(label1);
            Controls.Add(selectQuantityTicketsBox);
            Controls.Add(label2);
            Controls.Add(purchaseFormTitleLabel);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Margin = new Padding(2, 2, 2, 2);
            Name = "PurchaseForm";
            Text = "PurchaseForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label purchaseFormTitleLabel;
        private Label label2;
        private ComboBox selectQuantityTicketsBox;
        private Label label1;
        private ColorDialog colorDialog1;
        private Label ticketPriceLabel;
        private Button purchaseTicketConfirmButton;
        private Label discountedPriceLabel;
        private Label discountedTicketPriceLabel;
        private Label rankDiscountStatusLabel;
        private Button purchaseTicketCancelButton;
        private Label label3;
        private Label singleTicketPrice;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}