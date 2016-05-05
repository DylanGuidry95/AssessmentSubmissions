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
                    Main.StudentCreation.Show();
                }
            }
        }

        private void StudentNames_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void SetInfo(string name, string github, string url)
        {
            studentInfo.Text = "Name:" + name + "\n" +
                                "GitHub: " + github + "\n" +
                                "Website: " + url;
        }
    }
}
