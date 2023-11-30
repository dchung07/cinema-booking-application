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
    public partial class AddCommentForm : Form
    {

        //Change the file path to a full path in this file if relative does not work as intended

        private string customerId;
        private string movieName = "";
        public AddCommentForm(string movieName, string customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
            this.movieName = movieName;
            commentReviewTitleLabel.Text = "Write a Review for: " + movieName;
        }

        private void returnAddCommentButton_Click(object sender, EventArgs e)
        {
            MovieBookingForm movieBookingForm = new MovieBookingForm();
            movieBookingForm.Show();
            this.Close();
        }

        private void commentSubmitButton_Click(object sender, EventArgs e)
        {
            string description = addCommentTextBox.Text;
            string commentData = $"{movieName};{customerId};{description}";

            using (var file = File.AppendText(Path.Combine(Directory.GetCurrentDirectory(), "Comments.txt")))
            {
                file.WriteLine(commentData);
            }

            MessageBox.Show("Successfully Left a Commment!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MovieBookingForm movieBookingForm = new MovieBookingForm();
            movieBookingForm.Show();
            this.Close();
        }
    }
}
