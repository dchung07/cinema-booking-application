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
    public partial class AddStaffForm : Form
    {
        public Form viewStaffForm { get; set; }

        public AddStaffForm()
        {
            InitializeComponent();
        }

        private void AddStaffForm_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            String id = staffID.Text;
            String firstName = staffFirstName.Text;
            String lastName = staffLastName.Text;
            String email = staffEmail.Text;
            String phone = staffPhone.Text;

            string staffData = $"{id}\t{firstName}\t{lastName}\t{email}\t{phone}";

            List<string> lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Staff.txt")).ToList();
            lines.Add(staffData);
            File.WriteAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Staff.txt"), lines);

            /*File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), "Staff.txt"), staffData);*/

            //generate random password for newly added staff
            String password = GeneratePassword();

            //add to Credentials txt file
            string credentials = $"{id}\t{password}\tS";

            List<string> credLines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Credentials.txt")).ToList();
            credLines.Add(credentials);
            File.WriteAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Credentials.txt"), credLines);

            /*File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), "Credentials.txt"), credentials);*/

            this.Close();

            if (viewStaffForm is ViewStaffForm staffForm)
            {
                DataGridView staffTable = staffForm.GetStaffTable();
                staffTable.Rows.Add(id, firstName, lastName, email, phone);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private String GeneratePassword()
        {
            String availableChars = "abcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < 6; i++)
            {
                password.Append(availableChars[random.Next(availableChars.Length)]);
            }

            return password.ToString();
        }
    }
}
