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
    public partial class AssignmentCreation : Form
    {
        public AssignmentCreation()
        {
            InitializeComponent();
        }
        int numRows = 0;
        private void assignmentView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void UpdateList()
        {
            foreach(Assignment a in Main.CurrentClass.AllAssignments)
            {
                if(!assignmentList.Items.Contains(a.Name))
                {
                    assignmentList.Items.Add(a.Name);
                }
            }
        }

        private void saveItem_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void discard_Click(object sender, EventArgs e)
        {
            string message = "All changes will be lost do you wish to continue?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, "", buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                name.Text = "";
            }
        }

        private void start()
        {

        }
        private void assignmentBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
