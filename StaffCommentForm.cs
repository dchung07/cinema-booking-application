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
    public partial class StaffCommentForm : Form {
        public Form StaffForm { get; set; }

        public StaffCommentForm() {
            InitializeComponent();
        }

        private void StaffCommentForm_Load(object sender, EventArgs e) {
            string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Comments.txt"));

            // Populate listview with data from Comments.txt
            foreach (string line in lines) {
                string[] data = line.Split(';');
                string[] row = { data[0], data[1], data[2] };
                var commentItem = new ListViewItem(row);
                commentList.Items.Add(commentItem);
            }
        }

        private void Remove_Click(object sender, EventArgs e) {
            string line = "";
            string tempFile = Path.GetTempFileName();
            StreamReader r = File.OpenText(Path.Combine(Directory.GetCurrentDirectory(), "Comments.txt"));
            StreamWriter w = new StreamWriter(tempFile);

            while ((line = r.ReadLine()) != null) {
                string[] data = line.Split(';');
                string comment = commentList.SelectedItems[0].SubItems[2].Text;

                if (data[2] != comment) {
                    w.WriteLine(line);
                }
            }



            r.Close();
            w.Close();

            File.Delete("Comments.txt");
            File.Move(tempFile, "Comments.txt");

            if (commentList.Items.Count > 0) {
                commentList.Items.Remove(commentList.SelectedItems[0]);
            }
        }

        private void exit_Click(object sender, EventArgs e) {
            StaffForm.Show();
            this.Close();
        }
    }
}
