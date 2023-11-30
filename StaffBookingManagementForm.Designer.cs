namespace Cinema_Booking_System {
    partial class StaffBookingManagementForm {
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
            exit = new Button();
            bookingList = new ListView();
            Title = new ColumnHeader();
            CustomerID = new ColumnHeader();
            Tickets = new ColumnHeader();
            label1 = new Label();
            custTextBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Remove
            // 
            Remove.Location = new Point(29, 399);
            Remove.Name = "Remove";
            Remove.Size = new Size(101, 31);
            Remove.TabIndex = 7;
            Remove.Text = "Remove";
            Remove.UseVisualStyleBackColor = true;
            Remove.Click += Remove_Click;
            // 
            // exit
            // 
            exit.Location = new Point(593, 395);
            exit.Name = "exit";
            exit.Size = new Size(102, 35);
            exit.TabIndex = 5;
            exit.Text = "Return";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // bookingList
            // 
            bookingList.BackColor = SystemColors.ControlDark;
            bookingList.Columns.AddRange(new ColumnHeader[] { Title, CustomerID, Tickets });
            bookingList.FullRowSelect = true;
            bookingList.Location = new Point(29, 80);
            bookingList.Name = "bookingList";
            bookingList.Size = new Size(727, 283);
            bookingList.TabIndex = 4;
            bookingList.UseCompatibleStateImageBehavior = false;
            bookingList.View = View.Details;
            // 
            // Title
            // 
            Title.Text = "Title";
            Title.Width = 150;
            // 
            // CustomerID
            // 
            CustomerID.Text = "Customer ID";
            CustomerID.Width = 100;
            // 
            // Tickets
            // 
            Tickets.Text = "Tickets";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Image = Properties.Resources.blk;
            label1.Location = new Point(38, 33);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 13;
            label1.Text = "Customer ID:";
            // 
            // custTextBox
            // 
            custTextBox.BackColor = SystemColors.ControlDark;
            custTextBox.Location = new Point(120, 25);
            custTextBox.Name = "custTextBox";
            custTextBox.Size = new Size(175, 23);
            custTextBox.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(329, 18);
            button1.Name = "button1";
            button1.Size = new Size(102, 35);
            button1.TabIndex = 14;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StaffBookingManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.blk;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(custTextBox);
            Controls.Add(Remove);
            Controls.Add(exit);
            Controls.Add(bookingList);
            Name = "StaffBookingManagementForm";
            Text = "StaffBookingManagementForm";
            Load += StaffBookingManagementForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Remove;
        private Button exit;
        private ListView bookingList;
        private ColumnHeader Title;
        private ColumnHeader CustomerID;
        private ColumnHeader Tickets;
        private Label label1;
        private TextBox custTextBox;
        private Button button1;
    }
}