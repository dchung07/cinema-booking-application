using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Booking_System {
    public partial class StaffBookingManagementForm : Form {
        public Form StaffForm { get; set; }
        public StaffBookingManagementForm() {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e) {
            StaffForm.Show();
            this.Close();
        }

        private void Remove_Click(object sender, EventArgs e) {
            string line = "";
            string tempFile = Path.GetTempFileName();
            StreamReader r = File.OpenText(Path.Combine(Directory.GetCurrentDirectory(), "Bookings.txt"));
            StreamWriter w = new StreamWriter(tempFile);

            while ((line = r.ReadLine()) != null) {

                string booking = bookingList.SelectedItems[0].SubItems[0].Text + ";" + bookingList.SelectedItems[0].SubItems[1].Text + ";" + bookingList.SelectedItems[0].SubItems[2].Text;

                if (line != booking) {
                    w.WriteLine(line);
                }
            }



            r.Close();
            w.Close();

            File.Delete("Bookings.txt");
            File.Move(tempFile, "Bookings.txt");

            if (bookingList.Items.Count > 0) {
                bookingList.Items.Remove(bookingList.SelectedItems[0]);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (custTextBox.Text == "") {
                bookingList.Items.Clear();
                string[] lines1 = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Bookings.txt"));

                // Populate listview with data from Bookings.txt
                foreach (string line in lines1) {
                    string[] data = line.Split(';');
                    string[] row = { data[0], data[1], data[2] };
                    var bookingItem = new ListViewItem(row);
                    bookingList.Items.Add(bookingItem);
                }
                return;
            }
            String custID = custTextBox.Text;
            bookingList.Items.Clear();

            string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Bookings.txt"));

            // Populate listview with data from Bookings.txt
            foreach (string line in lines) {
                string[] data = line.Split(';');
                if (data[1] == custID) {
                    string[] row = { data[0], data[1], data[2] };
                    var bookingItem = new ListViewItem(row);
                    bookingList.Items.Add(bookingItem);
                }

            }

        }

        private void StaffBookingManagementForm_Load(object sender, EventArgs e) {
            string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Bookings.txt"));

            // Populate listview with data from Bookings.txt
            foreach (string line in lines) {
                string[] data = line.Split(';');
                string[] row = { data[0], data[1], data[2] };
                var bookingItem = new ListViewItem(row);
                bookingList.Items.Add(bookingItem);
            }
        }

    }
}
