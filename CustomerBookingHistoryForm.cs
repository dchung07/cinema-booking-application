using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel.Design.Serialization;

namespace Cinema_Booking_System {
    public partial class CustomerBookingHistoryForm : Form {

        //Change the file path to a full path in this file if relative does not work as intended

        public string CustomerFormId { get; set; }
        public string selectedCustomerId = "";
        public string selectedMovieName = "";
        public string selectedQuantity = "";
        public CustomerBookingHistoryForm() {
            InitializeComponent();
            movieBookingHistoryTable.CellClick += movieBookingHistoryTableCellClick_1;
        }


        //On Cell click we want to return the moviename, customer name, quantity name of the row. 
        //This is so that we can send it through to the cancel customer button
        private void movieBookingHistoryTableCellClick_1(object sender, EventArgs args) {
            //If at least one row is selected, then the button is enabled, otherwise it is disabled.
            cancelCustomerBookingButton.Enabled = movieBookingHistoryTable.SelectedRows.Count > 0;

            if (movieBookingHistoryTable.SelectedRows.Count > 0) {
                // IMPORTANT: Cells for selectedCustomerID and selectedMovieName have been switched due to incorrect naming.
                // Code will currently work as is with removal from bookings text file.
                selectedCustomerId = movieBookingHistoryTable.SelectedRows[0].Cells["bookingHistoryMovieName"].Value.ToString();
                selectedMovieName = movieBookingHistoryTable.SelectedRows[0].Cells["bookingHistoryCustomerName"].Value.ToString();
                selectedQuantity = movieBookingHistoryTable.SelectedRows[0].Cells["bookingHistoryQuantity"].Value.ToString();
            }
        }

        private void bookingHistoryCloseButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        //In the cancel button, we check if the row is valid with null checks. 
        private void cancelCustomerBookingButton_Click(object sender, EventArgs e) {

            if (string.IsNullOrEmpty(selectedCustomerId) || string.IsNullOrEmpty(selectedMovieName) || string.IsNullOrEmpty(selectedQuantity)) {
                MessageBox.Show("Please select a booking to cancel.");
                return;
            }

            string line = "";
            string tempFile = Path.GetTempFileName();
            StreamReader r = File.OpenText(Path.Combine(Directory.GetCurrentDirectory(), "Bookings.txt"));
            StreamWriter w = new StreamWriter(tempFile);

            while ((line = r.ReadLine()) != null) {
                string booking = selectedMovieName + ";" + selectedCustomerId + ";" + selectedQuantity;
                MessageBox.Show(booking);

                if (line != booking) {
                    w.WriteLine(line);
                }
            }



            r.Close();
            w.Close();

            File.Delete("Bookings.txt");
            File.Move(tempFile, "Bookings.txt");

            //Reset variables

            selectedCustomerId = "";
            selectedMovieName = "";
            selectedQuantity = "";

            MessageBox.Show("Booking has been canceled.");

            //Reload data table after change
            movieBookingHistoryTable.Rows.Clear();
            CustomerBookingHistoryForm_Load_1(sender, e);

        }

        private void CustomerBookingHistoryForm_Load_1(object sender, EventArgs e) {
            string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Bookings.txt"));

            // Adding info from the text file into DataGridView
            foreach (string line in lines) {
                string[] data = line.Split(';');

                string movieName = data[0];
                string id = data[1];
                string tickets = data[2];

                if (id == CustomerFormId) {
                    movieBookingHistoryTable.Rows.Add(movieName, id, tickets);
                }




            }
        }

    }
}
