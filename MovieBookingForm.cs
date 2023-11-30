using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Booking_System
{
    public partial class MovieBookingForm : Form
    {
        public string CustomerFormId { get; set; }
        public string customerId;


        private string selectedMovieName;
        private string selectedMoviePrice;
        public MovieBookingForm()
        {
            InitializeComponent();
            this.Load += MovieBookingForm_Load;
            movieTable.CellClick += movieTableCellClick;

        }


        private void MovieBookingForm_Load(object sender, EventArgs e)
        {

            string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Movies.txt"));

            // Adding info from the text file into DataGridView
            foreach (string line in lines)
            {
                string[] data = line.Split(';');
                movieTable.Rows.Add(data);
            }

            string customerData = GetCustomerDataById("Customers.txt", CustomerFormId);

            if (customerData != null)
            {
                string[] segment = customerData.Split('\t');
                if (segment.Length >= 6)
                {
                    string id = segment[0];
                    string firstName = segment[1];
                    string lastName = segment[2];
                    string email = segment[3];
                    string phone = segment[4];
                    string points = segment[5];
                    string status = segment[6];

                    customerId = id;
                }
            }
            else
            {

            }
        }


        private string GetCustomerDataById(string customersFilePath, string userId)
        {

            string[] segments = File.ReadAllLines(customersFilePath);

            foreach (string s in segments)
            {
                string[] segment = s.Split('\t');

                if (segment.Length >= 6 && segment[0] == userId)
                {
                    return s;
                }
            }



            return null;
        }

        private void movieTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bookMovieReturnButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void movieTableCellClick(object sender, EventArgs args)
        {
            purchaseButton.Enabled = movieTable.SelectedRows.Count > 0;
            viewCommentsButton.Enabled = movieTable.SelectedRows.Count > 0;
            addCommentButton.Enabled = movieTable.SelectedRows.Count > 0;

            if (movieTable.SelectedRows.Count > 0)
            {
                selectedMovieName = movieTable.SelectedRows[0].Cells["bookingMovieName"].Value.ToString();
                selectedMoviePrice = movieTable.SelectedRows[0].Cells["bookingMoviePrice"].Value.ToString();
            }

        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            PurchaseForm purchaseForm = new PurchaseForm(selectedMovieName, selectedMoviePrice, customerId);
            purchaseForm.CustomerFormId = customerId;
            purchaseForm.Show();
            this.Close();
        }

        private void viewCommentsButton_Click(object sender, EventArgs e)
        {
            CommentSectionForm commentSectionForm = new CommentSectionForm(selectedMovieName, customerId);
            commentSectionForm.Show();
            this.Close();
        }

        private void addCommentButton_Click(object sender, EventArgs e)
        {
            AddCommentForm addCommentForm = new AddCommentForm(selectedMovieName, customerId);
            addCommentForm.Show();
            this.Close();
        }
    }
}
