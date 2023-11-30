using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Cinema_Booking_System {
    public partial class StaffMoviesForm : Form {

        public Form StaffForm { get; set; }

        public StaffMoviesForm() {
            InitializeComponent();
        }

        private void StaffMoviesForm_Load(object sender, EventArgs e) {
            string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Movies.txt"));

            // Populate listview with data from Movies.txt
            foreach (string line in lines) {
                string[] data = line.Split(';');
                string[] row = { data[0], data[1], data[2], data[4], data[5] };
                var movieItem = new ListViewItem(row);
                movieList.Items.Add(movieItem);
            }
        }


        private void exit_Click(object sender, EventArgs e) {
            StaffForm.Show();
            this.Close();
        }

        private void Remove_Click(object sender, EventArgs e) {
            // Update Movies txt File
            string line = "";
            string tempFile = Path.GetTempFileName();
            StreamReader r = File.OpenText(Path.Combine(Directory.GetCurrentDirectory(), "Movies.txt"));
            StreamWriter w = new StreamWriter(tempFile);

            while ((line = r.ReadLine()) != null) {
                string[] data = line.Split(';');
                string[] movie = movieList.SelectedItems[0].Text.Split(";");

                if (data[0] != movie[0]) {
                    w.WriteLine(line);
                }
            }



            r.Close();
            w.Close();

            File.Delete("Movies.txt");
            File.Move(tempFile, "Movies.txt");


            // Update User View
            if (movieList.Items.Count > 0) {
                movieList.Items.Remove(movieList.SelectedItems[0]);
            }

        }

        private void Add_Click(object sender, EventArgs e) {

            if (titleTextBox.Text == "" || genreComboBox.Text == "" || runTimeNumBox.Value.ToString() == "") {
                MessageBox.Show("Please fill all fields with valid data.");
                return;
            }


            // Update User View
            string sessionDays = sessionDayFrom.Value.ToString("dd/MM/yyyy") + "-" + sessionDayTo.Value.ToString("dd/MM/yyyy");
            List<String> sessionTimes = sessionTimesListBox.CheckedItems.OfType<String>().ToList();
            String selectedSessions = "";

            foreach (String i in sessionTimes) {
                selectedSessions = selectedSessions + "{" + i + "|150}" + ", ";
            }

            string[] row = { titleTextBox.Text, genreComboBox.Text, runTimeNumBox.Value.ToString(), sessionDays, selectedSessions };
            var movieItem = new ListViewItem(row);
            movieList.Items.Add(movieItem);



            // Update Txt File
            StreamWriter w = File.AppendText(Path.Combine(Directory.GetCurrentDirectory(), "Movies.txt"));
            w.WriteLine($"{titleTextBox.Text};{genreComboBox.Text};{runTimeNumBox.Value.ToString()};12;{sessionDays};{selectedSessions}");
            w.Close();


            titleTextBox.Text = "";
            genreComboBox.Text = "";
            runTimeNumBox.Value = 0;
            sessionDayFrom.Value = DateTime.Today;
            sessionDayTo.Value = DateTime.Today;
            for (int i = 0; i < sessionTimesListBox.Items.Count; i++) {
                sessionTimesListBox.SetItemChecked(i, false);
            }
        }
    }
}
