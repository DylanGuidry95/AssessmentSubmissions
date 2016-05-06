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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            Main.HomeScreen = this;
            GetFiles();
        }

        private void GetFiles()
        {
            foreach (string s in System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory() + "/Class/", "*.xml", System.IO.SearchOption.AllDirectories))
            {
                SchoolFactory.YearOne a = SaveLoad<SchoolFactory.YearOne>.Deserialize(s);
                classes.Items.Add(a.Name);
            }
        }

        private void CreateClass_Click(object sender, EventArgs e)
        {
            if (className.Text == "YearOne")
            {
                Main.school.Create(className.Text);
                Mock m = new Mock();
                m.Show();
                m.Activate();      
            }
            else
            {
                MessageBox.Show("Not a valid class type.\nEnter YearOne or YearTwo.");
            }
        }

        private void SelectClass_Click(object sender, EventArgs e)
        {
            Main.CurrentClass = SaveLoad<SchoolFactory.YearOne>.Deserialize(System.IO.Directory.GetCurrentDirectory() + "/Class/" + classes.Text + ".xml");
            Mock m = new Mock();
            m.Show();
            m.Activate();
        }
    }
}
