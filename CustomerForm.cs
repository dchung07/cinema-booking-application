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
    public partial class CustomerForm : Form {

        public Form loginForm { get; set; }
        public CustomerForm() {
            InitializeComponent();
        }


        public string customerFormId { get; set; }

        public string getID() { return customerFormId; }


        private void CustomerForm_Load(object sender, EventArgs e)
        {
            //From loginform, the id is sent recieved, this is chained throughout the forms so that we can know who is logged in at all times
            if (loginForm is LoginForm)
            {
                string loggedInUserId = ((LoginForm)loginForm).GetId();
                customerFormId = loggedInUserId;
            }
        }

        private void logoutButton_Click(object sender, EventArgs e) {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void customerProfileButton_Click(object sender, EventArgs e) {

            var profileForm = new CustomerProfileForm();
            profileForm.CustomerForm = this;
            profileForm.CustomerFormId = customerFormId;
            profileForm.Show();

        }


        private void customerFormBookMovieButton_Click(object sender, EventArgs e) {
            MovieBookingForm movieBookingForm = new MovieBookingForm();
            movieBookingForm.CustomerFormId = customerFormId;
            movieBookingForm.Show();

        }

        private void logoutButton_Click_1(object sender, EventArgs e) {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void commentHistoryButton_Click(object sender, EventArgs e) {
            CustomersCommentHistoryForm commentsForm = new CustomersCommentHistoryForm();
            commentsForm.CustomerFormId = customerFormId;
            commentsForm.Show();
        }

        private void button1_Click(object sender, EventArgs e) {
            CustomerBookingHistoryForm cBookingHistory = new CustomerBookingHistoryForm();
            cBookingHistory.CustomerFormId = customerFormId;
            cBookingHistory.Show();
        }
    }
}
