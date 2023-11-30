using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Cinema_Booking_System
{
    public partial class ManageStaffForm : Form
    {
        public Form viewStaffForm { get; set; }

        public ManageStaffForm()
        {
            InitializeComponent();

        }

        private void ManageStaffForm_Load(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            String changeStaffID = staffID.Text;
            String changeStaffFName = staffFirstName.Text;
            String changeStaffLName = staffLastName.Text;
            String changeStaffEmail = staffEmail.Text;
            String changeStaffPhone = staffPhone.Text;

            string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Staff.txt"));
            List<string> newLines = new List<string>();

            foreach (string line in lines)
            {
                string[] info = line.Split('\t');

                if (info[0] == changeStaffID)
                {
                    // Update information
                    info[1] = changeStaffFName;
                    info[2] = changeStaffLName;
                    info[3] = changeStaffEmail;
                    info[4] = changeStaffPhone;
                }
                string updatedStaff = string.Join("\t", info);
                newLines.Add(updatedStaff);
            }
            File.WriteAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Staff.txt"), newLines);

            this.Close();

            if (viewStaffForm is ViewStaffForm staffForm)
            {
                staffForm.UpdateStaffTbl(changeStaffID, changeStaffFName, changeStaffLName, changeStaffEmail, changeStaffPhone);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void PopulateFields(String id, String firstName, String lastName, String email, String phone)
        {
            staffID.Text = id;
            staffFirstName.Text = firstName;
            staffLastName.Text = lastName;
            staffEmail.Text = email;
            staffPhone.Text = phone;
        }
    }
}
