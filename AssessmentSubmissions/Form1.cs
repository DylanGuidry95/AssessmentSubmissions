using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace AssessmentSubmissions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void LoadInformation(string fileName)
        {
            string[] text = File.ReadAllLines(fileName);
            foreach (string t in text)
            {
                Data.Text += t + "\n";
            }
        }

        void SaveInformation(string fileName)
        {
            string[] splitData = Data.Text.Split('\n');
            File.WriteAllText(Directory.GetCurrentDirectory() + "/" + fileName + ".txt", "");
            foreach (string s in splitData)
            {
                string save = CheckUrl(s);
                File.AppendAllText(Directory.GetCurrentDirectory() + "/" + fileName + ".txt", save + "\n");
            }
        }

        string CheckUrl(string s)
        {
            Uri uri = null;
            string[] split = s.Split(' ');
            if (split.Count() > 1)
            {
                if (Uri.TryCreate(split[1], UriKind.Absolute, out uri) || null == uri)
                {
                    string newS = " > " + split[1];
                    s = split[0] + newS;
                    return s;
                }
            }
            return s;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        void SaveData()
        {
            Stream myStream;
            string t = saveFileDialog1.FileName;
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.Title = "Save Download Urls";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    t = saveFileDialog1.FileName;
                    myStream.Close();
                }
            }

            string[] splitData = Data.Text.Split('\n');
            File.WriteAllText(t, "");
            foreach (string s in splitData)
            {
                string save = CheckUrl(s);
                File.AppendAllText(t, save + "\n");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Data.Text != "")
            {
                SaveData();
            }
            Data.Text = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                LoadInformation(openFileDialog1.FileName);
                sr.Close();
            }
        }
    }
}
