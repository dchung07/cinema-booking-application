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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void signUpFormReturnButton_Click(object sender, EventArgs e)
        {
            LandingPageForm landingPageForm = new LandingPageForm();
            landingPageForm.Show();
            this.Hide();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int minID = 100000;
            int maxID = 999999;

            int randomID = random.Next(minID, maxID + 1);
            string randomIDToString = randomID.ToString("D6");

            string id = randomIDToString;
            string firstName = signUpFirstNameTextBox.Text;
            string lastName = signUpLastNameTextBox.Text;
            string email = signUpEmailTextBox.Text;
            string phone = signUpPhoneTextBox.Text;
            string points = "0";
            string status = "Bronze";
            string password = signUpPasswordTextBox.Text;

            string customerData = $"{id}\t{firstName}\t{lastName}\t{email}\t{phone}\t{points}\t{status}";

            using (var file = File.AppendText(Path.Combine(Directory.GetCurrentDirectory(), "Customers.txt")))
            {
                file.WriteLine(customerData);
            }

            string customerCredentialsData = $"{id}\t{password}\t{"t"}";

            using (var file = File.AppendText(Path.Combine(Directory.GetCurrentDirectory(), "Credentials.txt")))
            {
                file.WriteLine(customerCredentialsData);
            }

            MessageBox.Show("Successfully signed up", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }


    }
}
