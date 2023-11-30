// University of Technology Sydney Spring Session 2023
// 31927 - Application Development With .NET
//
// Assignment 2: Windows Forms Application
// Cinema Booking System - Login Form Functionality
//
// Written by Justin Widjaya - 13602091,  
//            David Chung - 14288397,
//            Rosa Long - 98137351
//

namespace Cinema_Booking_System
{
    public partial class LoginForm : Form
    {


        private string id = "";
        private string password = "";

        // Constructor for Login Menu
        public LoginForm()
        {
            InitializeComponent();
        }

        // Getter for User ID
        // Passed to next form
        public string GetId()
        {
            return this.id;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            id = "";
            password = "";
        }

        // Code to function when loginButton is clicked
        // Checks Credentials.txt file for valid inputs
        // If Valid --> Shows next form
        // If Invalid --> Error Message + Clears textboxes
        //
        private void loginButton_Click(object sender, EventArgs e)
        {
            string line = "";

            id = idTextBox.Text;
            password = passwordTextBox.Text;

            // Credentials.txt data format:
            // Three columns separated by tab character:
            // Column 0 is ID
            // Column 1 is Password
            // Column 2 is Character Denoting Usertype: C, S, A (Customer, Staff, Admin)
            StreamReader r = File.OpenText(Path.Combine(Directory.GetCurrentDirectory(), "Credentials.txt"));

            while ((line = r.ReadLine()) != null)
            {
                string[] data = line.Split('\t');

                if (data[0] == id)
                {
                    if (data[1] == password)
                    {
                        output.Text = "Valid Credentials.";

                        if (data[2] == "C")
                        {
                            var customerForm = new CustomerForm();
                            customerForm.customerFormId = id;
                            customerForm.loginForm = this;
                            customerForm.Show();
                        }
                        else if (data[2] == "S")
                        {
                            var staffForm = new StaffForm();
                            staffForm.loginForm = this;
                            staffForm.Show();
                        }
                        else if (data[2] == "A")
                        {
                            var adminForm = new AdminForm();
                            adminForm.loginForm = this;
                            adminForm.Show();
                        }


                        idTextBox.Text = "";
                        passwordTextBox.Text = "";
                        output.Text = "";


                        this.Hide();

                        r.Close();
                        return;
                    }
                }
            }

            output.Text = "Invalid Credentials Entered.\nAccess Denied. Please try again.";
            idTextBox.Text = "";
            passwordTextBox.Text = "";

            r.Close();
        }

        // Censors password when entered in textbox
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
        }

        private void logInFormReturnButton_Click(object sender, EventArgs e)
        {
            LandingPageForm landingPageForm = new LandingPageForm();
            landingPageForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}