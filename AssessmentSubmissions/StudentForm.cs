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
        public StudentForm()
        {
            InitializeComponent();
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            Main.CurrentClass.AddStudent(Main.student.Create(studentName.Text));
            Main.ClassInfo.UpdateClassList();
            this.Close();
        }
    }
}
