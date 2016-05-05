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
    public partial class StudentForm : Form
    {
        Mock Parent;

        public StudentForm(Mock p)
        {
            InitializeComponent();
            Parent = p;
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            Parent.AddStudents(new Student(studentName.Text, githubName.Text, webUrl.Text));
            this.Close();
        }
    }
}
