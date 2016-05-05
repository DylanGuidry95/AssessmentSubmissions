using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssessmentSubmissions
{
    public partial class Mock : Form
    {
        List<Student> Students = new List<Student>();
        List<Assignement> Assignments = new List<Assignement>();

        public Mock()
        {
            InitializeComponent();
        }

        private void StudentNames_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                string message = "Do you wanna add a new student to this class?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, "", buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    StudentForm s = new StudentForm(this);
                    s.Show();
                }
            }
  
        }

        public void AddStudents(Student s)
        {
            Students.Add(s);
            StudentNames.Items.Add(s.Name);
        }

        private void StudentNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Student s in Students)
            {
                if(s.Name == StudentNames.SelectedItem.ToString())
                {
                    SetInfo(s.Name, s.GitHub, s.Website);
                }
            }
        }

        private void SetInfo(string name, string github, string url)
        {
            studentInfo.Text = "Name:" + name + "\n" +
                                "GitHub: " + github + "\n" +
                                "Website: " + url;
        }
    }
}
