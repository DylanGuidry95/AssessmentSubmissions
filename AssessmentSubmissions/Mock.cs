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
        public Mock()
        {
            InitializeComponent();
            Main.ClassInfo = this;
            Main.ClassInfo.Activate();
            Main.HomeScreen.Close();
            textBox1.Text = Main.ActiveClass;
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
                    StudentForm s = new StudentForm();
                    Main.StudentCreation = s;
                    Main.StudentCreation.Show();
                }
            }
        }

        public void UpdateClassList()
        {
            foreach(IStudents s in Main.CurrentClass.Students)
            {
                if(!StudentNames.Items.Contains(s.Name))
                    StudentNames.Items.Add(s.Name);
            }
        }

        private void StudentNames_SelectedIndexChanged(object sender, EventArgs e)
        {
           foreach(IStudents s in Main.CurrentClass.Students)
            {
                if (StudentNames.Text == s.Name)
                    SetInfo(s.Name, s.GitHub, s.Website);
            }
        }

        private void SetInfo(string name, string github, string url)
        {
            studentInfo.Text = "Name:" + name + "\n" +
                                "GitHub: " + github + "\n" +
                                "Website: " + url;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveLoad<SchoolFactory.YearOne>.Serialize("YearOne", Main.CurrentClass);
        }
    }
}
