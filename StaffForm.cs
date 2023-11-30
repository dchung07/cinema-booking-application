// University of Technology Sydney Spring Session 2023
// 31927 - Application Development With .NET
//
// Assignment 2: Windows Forms Application
// Cinema Booking System - Staff Form Functionality
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

namespace Cinema_Booking_System {
    public partial class StaffForm : Form {

        public Form loginForm { get; set; }

        public StaffForm() {
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e) {

        }

        private void logoutButton_Click(object sender, EventArgs e) {
            this.loginForm.Show();
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e) {
            var StaffMoviesForm = new StaffMoviesForm();
            StaffMoviesForm.StaffForm = this;
            StaffMoviesForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e) {
            var StaffCommentForm = new StaffCommentForm();
            StaffCommentForm.StaffForm = this;
            StaffCommentForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) {
            var manageCustomerForm = new ViewCustomerForm();
            manageCustomerForm.StaffForm = this;
            manageCustomerForm.staffFlag = 1;
            manageCustomerForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e) {
            var bookingManagement = new StaffBookingManagementForm();
            bookingManagement.StaffForm = this;
            bookingManagement.Show();
            this.Hide();
        }
    }
}
