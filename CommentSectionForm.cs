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
    public partial class CommentSectionForm : Form
    {

        //Change the file path to a full path in this file if relative does not work as intended

        private string movieName = "";
        public CommentSectionForm(string movieName, string customerId)
        {
            InitializeComponent();
            this.movieName = movieName;
            this.Load += CommentSectionForm_Load;
            //On load we want to showcase the comments.
        }

        private void CommentSectionForm_Load(object sender, EventArgs e)
        {

            string[] segments = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Comments.txt"));

            commentTable.Columns.Add("movieName", "Movie Name");
            commentTable.Columns.Add("CommenterID", "Commenter ID");
            commentTable.Columns.Add("Comment", "Comment");

            foreach (string segment in segments)
            {
                //Split the data per ';' to accomodate for the white spaces in the movies, and comments.
                string[] data = segment.Split(";");

                string commentMovieName = data[0];
                string commenterID = data[1];
                string comment = data[2];

                if (commentMovieName == movieName)
                {
                    commentTable.Rows.Add(commentMovieName, commenterID, comment);
                }
            }
        }


        private void returnCommentSectionButton_Click(object sender, EventArgs e)
        {
            MovieBookingForm form = new MovieBookingForm();
            form.Show();
            this.Close();
        }
    }
}
