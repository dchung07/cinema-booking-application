using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Booking_System
{

    public partial class CustomersCommentHistoryForm : Form
    {

        //Change the file path to a full path in this file if relative does not work as intended

        public string CustomerFormId { get; set; }
        public CustomersCommentHistoryForm()
        {
            InitializeComponent();
            this.Load += CustomerCommentHistoryForm_Load;
        }

        private void CustomerCommentHistoryForm_Load(object sender, EventArgs e)
        {
            string[] segments = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Comments.txt"));

            

            string customerId = CustomerFormId;

            if (customerId != null)
            {
                foreach (string segment in segments)
                {
                    string[] data = segment.Split(';');
                    string movieName = data[0];
                    string id = data[1];
                    string comment = data[2];

                    if (id == customerId)
                    {
                        customerCommentHistoryTable.Rows.Add(movieName, comment);
                    }
                }
            }
            else
            {

            }
        }

        private void commentHistoryCustomerCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
