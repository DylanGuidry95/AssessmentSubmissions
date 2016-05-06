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
        DataGrid dg;
        public AssignmentCreation()
        {
            InitializeComponent();
            CreateGrid();
            dg.ClearGrid();
            GetFiles();
        }

        private void GetFiles()
        {
            foreach (string s in System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory() + "/Assignment/", "*.xml", System.IO.SearchOption.AllDirectories))
            {
                Assignment a = SaveLoad<Assignment>.Deserialize(s);
                Main.CurrentClass.AllAssignments.Add(a);
                assignmentList.Items.Add(a.Name);
            }
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
            if (name.Text != "")
            {
                Assignment a = new Assignment(name.Text);
                foreach (DataGrid.Row r in dg.Rows)
                {
                    a.CreateRequirement(r.Cells[0].Data, r.Cells[1].Data);
                }
                SaveLoad<Assignment>.Serialize(@"\Assignment\" + a.Name, a);
                if(Main.CurrentClass.AllAssignments.Count == 0)
                {
                    Main.CurrentClass.AllAssignments.Add(a);
                }
                else
                {
                    bool exist = false;
                    foreach (Assignment assign in Main.CurrentClass.AllAssignments)
                    {
                        if(assign.Name == a.Name)
                        {
                            exist = true;
                        }
                    }
                    if(exist == false)
                    {
                        Main.CurrentClass.AllAssignments.Add(a);
                    }
                }
                Main.CurrentAssignment = a;
                UpdateList();
                assignmentList.SelectedIndex = assignmentList.Items.IndexOf(a);
            }
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
                dg.ClearGrid();
                CreateGrid();
            }
        }

        private void CreateGrid()
        {
            dg = new DataGrid(assignementView, this);
            dg.ColHeaders.Add(evidence);
            dg.ColHeaders.Add(def);
        }

        private void assignementView_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                dg.Create();
            }
        }

        private void evidence_SizeChanged(object sender, EventArgs e)
        {
            dg.AdjustColSize(evidence);
        }

        private void def_SizeChanged(object sender, EventArgs e)
        {
            dg.AdjustColSize(evidence);
        }

        private void assignmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            dg.ClearGrid();
            CreateGrid();
            foreach(Assignment a in Main.CurrentClass.AllAssignments)
            {
                if(a.Name == assignmentList.Text)
                {
                    Main.CurrentAssignment = a;
                    int index = 0;
                    foreach (Assignment.AssignementRequirements r in Main.CurrentAssignment.Requirements)
                    {
                        dg.Create();
                        dg.Rows[index].Cells[0].Textbox.Text = r.Description;
                        dg.Rows[index].Cells[1].Textbox.Text = r.Definition;
                        index++;
                    }
                }
            }

        }
    }
}
