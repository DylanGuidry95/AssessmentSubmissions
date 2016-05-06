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
    public partial class EditStudent : Form
    {
        public EditStudent()
        {
            InitializeComponent();
            infoName.Text = Main.CurrentStudent.Name;
        }

        private void confirmRequest_Click(object sender, EventArgs e)
        {
            Main.CurrentStudent.GitHub = infoGit.Text;
            Uri uri = null;
            if(!Uri.TryCreate(infoWebsite.Text, UriKind.Absolute, out uri) || null == uri)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show("Website is invalid.\nDo you wish to enter a valid url?", "Warning", buttons);
                if (result == DialogResult.No)
                {
                    Main.StudentEdit.Close();
                }
            }
            else
            {
                Main.CurrentStudent.Website = infoWebsite.Text;
                this.Close();
            }
        }

        private void cancelRequest_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show("Changes will not be saved.\nContinue?", "Warning", buttons);
            if (result == DialogResult.Yes)
            {
                Main.StudentEdit.Close();
            }
        }
    }
}
