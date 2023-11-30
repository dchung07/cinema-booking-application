namespace Cinema_Booking_System {
    partial class StaffMoviesForm {
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
            movieList = new ListView();
            Title = new ColumnHeader();
            Genre = new ColumnHeader();
            RunTime = new ColumnHeader();
            SessionDays = new ColumnHeader();
            SessionTimes = new ColumnHeader();
            exit = new Button();
            Add = new Button();
            Remove = new Button();
            titleTextBox = new TextBox();
            genreComboBox = new ComboBox();
            runTimeNumBox = new NumericUpDown();
            sessionDayFrom = new DateTimePicker();
            sessionDayTo = new DateTimePicker();
            sessionTimesListBox = new CheckedListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)runTimeNumBox).BeginInit();
            SuspendLayout();
            // 
            // movieList
            // 
            movieList.BackColor = SystemColors.ControlDark;
            movieList.Columns.AddRange(new ColumnHeader[] { Title, Genre, RunTime, SessionDays, SessionTimes });
            movieList.FullRowSelect = true;
            movieList.Location = new Point(89, 168);
            movieList.Name = "movieList";
            movieList.Size = new Size(605, 203);
            movieList.TabIndex = 0;
            movieList.UseCompatibleStateImageBehavior = false;
            movieList.View = View.Details;
            // 
            // Title
            // 
            Title.Text = "Title";
            Title.Width = 150;
            // 
            // Genre
            // 
            Genre.Text = "Genre";
            // 
            // RunTime
            // 
            RunTime.Text = "Runtime";
            // 
            // SessionDays
            // 
            SessionDays.Text = "Session Days";
            SessionDays.Width = 150;
            // 
            // SessionTimes
            // 
            SessionTimes.Text = "Session Times";
            SessionTimes.Width = 150;
            // 
            // exit
            // 
            exit.Location = new Point(653, 403);
            exit.Name = "exit";
            exit.Size = new Size(102, 35);
            exit.TabIndex = 1;
            exit.Text = "Return";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Add
            // 
            Add.Location = new Point(87, 407);
            Add.Name = "Add";
            Add.Size = new Size(101, 31);
            Add.TabIndex = 2;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Remove
            // 
            Remove.Location = new Point(222, 407);
            Remove.Name = "Remove";
            Remove.Size = new Size(101, 31);
            Remove.TabIndex = 3;
            Remove.Text = "Remove";
            Remove.UseVisualStyleBackColor = true;
            Remove.Click += Remove_Click;
            // 
            // titleTextBox
            // 
            titleTextBox.BackColor = SystemColors.ControlDark;
            titleTextBox.Location = new Point(137, 12);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(175, 23);
            titleTextBox.TabIndex = 4;
            // 
            // genreComboBox
            // 
            genreComboBox.BackColor = SystemColors.ControlDark;
            genreComboBox.FormattingEnabled = true;
            genreComboBox.Items.AddRange(new object[] { "Action", "Adventure", "Biography", "Comedy", "Crime", "Documentary", "Drama", "Fantasy", "Historical", "Horror", "Martial Arts", "Musical", "Mystery", "Romance", "Science Fiction", "Superhero", "Thriller", "War", "Western" });
            genreComboBox.Location = new Point(137, 51);
            genreComboBox.Name = "genreComboBox";
            genreComboBox.Size = new Size(91, 23);
            genreComboBox.TabIndex = 5;
            // 
            // runTimeNumBox
            // 
            runTimeNumBox.BackColor = SystemColors.ControlDark;
            runTimeNumBox.Location = new Point(137, 91);
            runTimeNumBox.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            runTimeNumBox.Name = "runTimeNumBox";
            runTimeNumBox.Size = new Size(91, 23);
            runTimeNumBox.TabIndex = 6;
            // 
            // sessionDayFrom
            // 
            sessionDayFrom.CalendarMonthBackground = SystemColors.ControlDark;
            sessionDayFrom.CustomFormat = "dd/MM/yyyy";
            sessionDayFrom.Format = DateTimePickerFormat.Custom;
            sessionDayFrom.Location = new Point(405, 12);
            sessionDayFrom.Name = "sessionDayFrom";
            sessionDayFrom.ShowUpDown = true;
            sessionDayFrom.Size = new Size(203, 23);
            sessionDayFrom.TabIndex = 8;
            // 
            // sessionDayTo
            // 
            sessionDayTo.CalendarMonthBackground = SystemColors.ControlDark;
            sessionDayTo.CustomFormat = "dd/MM/yyyy";
            sessionDayTo.Format = DateTimePickerFormat.Custom;
            sessionDayTo.Location = new Point(614, 12);
            sessionDayTo.Name = "sessionDayTo";
            sessionDayTo.ShowUpDown = true;
            sessionDayTo.Size = new Size(203, 23);
            sessionDayTo.TabIndex = 9;
            // 
            // sessionTimesListBox
            // 
            sessionTimesListBox.BackColor = SystemColors.ControlDark;
            sessionTimesListBox.CheckOnClick = true;
            sessionTimesListBox.FormattingEnabled = true;
            sessionTimesListBox.HorizontalScrollbar = true;
            sessionTimesListBox.Items.AddRange(new object[] { "00:00", "00:30", "01:00", "01:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30" });
            sessionTimesListBox.Location = new Point(405, 51);
            sessionTimesListBox.MultiColumn = true;
            sessionTimesListBox.Name = "sessionTimesListBox";
            sessionTimesListBox.Size = new Size(329, 112);
            sessionTimesListBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Image = Properties.Resources.blk;
            label1.Location = new Point(87, 20);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 11;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Image = Properties.Resources.blk;
            label2.Location = new Point(78, 59);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 12;
            label2.Text = "Genre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Image = Properties.Resources.blk;
            label3.Location = new Point(27, 99);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 13;
            label3.Text = "Runtime (mins):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Image = Properties.Resources.blk;
            label4.Location = new Point(318, 15);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 14;
            label4.Text = "Session Days:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Image = Properties.Resources.blk;
            label5.Location = new Point(312, 51);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 15;
            label5.Text = "Session Times:";
            // 
            // StaffMoviesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.blk;
            ClientSize = new Size(824, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sessionTimesListBox);
            Controls.Add(sessionDayTo);
            Controls.Add(sessionDayFrom);
            Controls.Add(runTimeNumBox);
            Controls.Add(genreComboBox);
            Controls.Add(titleTextBox);
            Controls.Add(Remove);
            Controls.Add(Add);
            Controls.Add(exit);
            Controls.Add(movieList);
            Name = "StaffMoviesForm";
            Text = "Movie Management Menu";
            Load += StaffMoviesForm_Load;
            ((System.ComponentModel.ISupportInitialize)runTimeNumBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView movieList;
        private Button @return;
        private Button exit;
        private ColumnHeader Title;
        private ColumnHeader Genre;
        private ColumnHeader RunTime;
        private ColumnHeader SessionDays;
        private ColumnHeader SessionTimes;
        private Button Add;
        private Button Remove;
        private TextBox titleTextBox;
        private ComboBox genreComboBox;
        private NumericUpDown runTimeNumBox;
        private DateTimePicker sessionDayFrom;
        private DateTimePicker sessionDayTo;
        private CheckedListBox sessionTimesListBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}