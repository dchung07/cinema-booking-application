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
    public partial class ManageCustomerForm : Form
    {
        public Form viewCustomerForm { get; set; }

        public ManageCustomerForm()
        {
            InitializeComponent();
        }

        private void ManageCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            String changeCusID = customerID.Text;
            String changeCusFName = customerFirstName.Text;
            String changeCusLName = customerLastName.Text;
            String changeCusEmail = customerEmail.Text;
            String changeCusPhone = customerPhone.Text;
            String changeCusPoints = customerPoints.Text;
            String changeCusStatus = customerStatus.Text;

            string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Customers.txt"));
            List<string> newLines = new List<string>();

            foreach (string line in lines)
            {
                string[] info = line.Split('\t');

                if (info[0] == changeCusID)
                {
                    // Update information
                    info[1] = changeCusFName;
                    info[2] = changeCusLName;
                    info[3] = changeCusEmail;
                    info[4] = changeCusPhone;
                    info[5] = changeCusPoints;
                    info[6] = changeCusStatus;
                }
                string updatedCus = string.Join("\t", info);
                newLines.Add(updatedCus);
            }

            File.WriteAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Customers.txt"), newLines);

            this.Close();

            if (viewCustomerForm is ViewCustomerForm customerForm)
            {
                customerForm.UpdateCustomerTbl(changeCusID, changeCusFName, changeCusLName, changeCusEmail, changeCusPhone, changeCusPoints, changeCusStatus);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void PopulateFields(String id, String firstName, String lastName, String email, String phone, String points, String status)
        {
            customerID.Text = id;
            customerFirstName.Text = firstName;
            customerLastName.Text = lastName;
            customerEmail.Text = email;
            customerPhone.Text = phone;
            customerPoints.Text = points;
            customerStatus.Text = status;
        }
    }
}
