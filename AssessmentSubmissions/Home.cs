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
        }

        private void CreateClass_Click(object sender, EventArgs e)
        {
            if (className.Text == "YearOne" || className.Text == "YearTwo")
            {
                Main.school.Create(className.Text);
                Main.ActiveClass = className.Text;
                Mock m = new Mock();
                m.Show();
                m.Activate();      
            }
            else
            {
                MessageBox.Show("Not a valid class type.\nEnter YearOne or YearTwo.");
            }
        }
    }
}
