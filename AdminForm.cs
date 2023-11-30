// University of Technology Sydney Spring Session 2023
// 31927 - Application Development With .NET
//
// Assignment 2: Windows Forms Application
// Cinema Booking System - Admin Form Functionality
//
// Written by Justin Widjaya - 13602091,  
//            David Chung - 14288397,
//            Rosa Long - 98137351
//

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
    public partial class AdminForm : Form
    {

        public Form loginForm { get; set; }

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.loginForm.Show();
            this.Close();
        }

        private void CustomersBtn_Click(object sender, EventArgs e)
        {
            var viewCustomerForm = new ViewCustomerForm();
            viewCustomerForm.adminForm = this;
            viewCustomerForm.Show();
            this.Hide();
        }

        private void StaffBtn_Click(object sender, EventArgs e)
        {
            var viewStaffForm = new ViewStaffForm();
            viewStaffForm.adminForm = this;
            viewStaffForm.Show();
            this.Hide();
        }

        private void customerImage_Click(object sender, EventArgs e)
        {
            var viewCustomerForm = new ViewCustomerForm();
            viewCustomerForm.adminForm = this;
            viewCustomerForm.Show();
            this.Hide();
        }

        private void staffImage_Click(object sender, EventArgs e)
        {
            var viewStaffForm = new ViewStaffForm();
            viewStaffForm.adminForm = this;
            viewStaffForm.Show();
            this.Hide();
        }

        private void passwordManagerBtn_Click(object sender, EventArgs e)
        {
            var managePasswordForm = new ManagePasswordForm();
            managePasswordForm.adminForm = this;
            managePasswordForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var managePasswordForm = new ManagePasswordForm();
            managePasswordForm.adminForm = this;
            managePasswordForm.Show();
        }
    }
}
