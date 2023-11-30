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
    public partial class CustomerProfileForm : Form
    {
        public string CustomerFormId { get; set; }
        public Form CustomerForm { get; set; }

        public CustomerProfileForm()
        {
            InitializeComponent();
            this.Load += CustomerProfileForm_Load;
        }

        private void CustomerProfileForm_Load(object sender, EventArgs e)
        {
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

                    customerProfileFirstNameLabel.Text = firstName;
                    customerProfileLastNameLabel.Text = lastName;
                    customerProfileEmailLabel.Text = email;
                    customerProfilePhoneLabel.Text = phone;
                    customerProfilePointsLabel.Text = points;
                    customerProfileRankLabel.Text = status;

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






        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void customerProfileReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void customerProfileLastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
