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
        DataGrid dg;

        public Mock()
        {
            InitializeComponent();
            Main.ClassInfo = this;
            Main.ClassInfo.Activate();
            Main.HomeScreen.Close();
            CreateGrid();
            dg.ClearGrid();
            GetFiles();
            UpdateAssignments();
        }

        private void GetFiles()
        {
            foreach (string s in System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory() + "/Students/", "*.xml", System.IO.SearchOption.AllDirectories))
            {
                StudentFactory.Student a = SaveLoad<StudentFactory.Student>.Deserialize(s);
                foreach(StudentFactory.Student student in Main.CurrentClass.Students)
                {
                    if(a.Name == student.Name)
                    {
                        StudentNames.Items.Add(a.Name);
                    }
                }
            }
        }

        private void CreateGrid()
        {
            dg = new DataGrid(studentAssignments, this);
            dg.ColHeaders.Add(colOne);
            dg.ColHeaders.Add(colTwo);
            dg.ColHeaders.Add(colThree);
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
           foreach(StudentFactory.Student s in Main.CurrentClass.Students)
            {
                if (StudentNames.Text == s.Name)
                {
                    SetInfo(s.Name, s.GitHub, s.Website);
                    Main.CurrentStudent = s;
                    dg.ClearGrid();
                    CreateGrid();
                    UpdateAssignments();
                    DisplayAssignmentLog();
                }
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
            SaveLoad<SchoolFactory.YearOne>.Serialize("/Class/" + Main.CurrentClass.Name, Main.CurrentClass);
            foreach(StudentFactory.Student s in Main.CurrentClass.Students)
            {
                SaveLoad<StudentFactory.Student>.Serialize("/Students/" + s.Name, s);
            }
        }

        private void editStudent_Click(object sender, EventArgs e)
        {
            Main.StudentEdit = new EditStudent();
            Main.StudentEdit.Show();
        }

        private void AssignmentEditor_Click(object sender, EventArgs e)
        {
            AssignmentCreation a = new AssignmentCreation();
            Main.AssignmentCreate = a;
            Main.AssignmentCreate.Show();
        }

        public void UpdateAssignments()
        {
            foreach(StudentFactory.Student s in Main.CurrentClass.Students)
            {
                foreach (Assignment a in Main.CurrentClass.AllAssignments)
                {
                    bool exist = false;
                    foreach (Assignment assign in s.Assignments)
                    {
                        if(a.Name == assign.Name)
                        {
                            exist = true;
                        }
                    }
                    if (exist == false)
                    {
                        s.Assignments.Add(a);
                    }
                }
            }
        }

        private void DisplayAssignmentLog()
        {
            int index = 0;
            foreach(Assignment a in Main.CurrentStudent.Assignments)
            {
                dg.Create();
                dg.Rows[index].Cells[0].Textbox.Text = a.Name;
                dg.Rows[index].Cells[1].Textbox.Text = a.Grade.ToString();
                dg.Rows[index].Cells[2].Textbox.Text = "N/A";
                index++;
            }
        }

        private void studentAssignments_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dg.Create();
            }
        }

        private void Mock_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
