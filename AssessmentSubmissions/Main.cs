using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssessmentSubmissions
{
    class Main
    {
        public static Home HomeScreen; //refrence to the HomeScreen form of the app
        public static Mock ClassInfo; //refrence to the class information form of the app
        public static StudentForm StudentCreation; //refrence to the create student form of the app
        public static EditStudent StudentEdit; //refrence to the student info editor form of the app
        public static AssignmentCreation AssignmentCreate; //refrence to the assignment editor form of the app

        public static SchoolFactory school = new SchoolFactory(); //refrence to the SchoolFactory class

        public static StudentFactory student = new StudentFactory(); //refrence to the StudentFactory class

        public static SchoolFactory.YearOne CurrentClass;
        public static SchoolFactory.YearTwo YearTwoClass;

        public static StudentFactory.Student CurrentStudent;
        public static Assignment CurrentAssignment;
    }

    public class DataGrid : IGridFactory
    {
        /// <summary>
        /// Row object that defines what it means for an object to be an object of type
        /// Row
        /// </summary>
        public class Row : IRow
        {
            /// <summary>
            /// Cell object that defines what it means to
            /// be an object of type cell
            /// </summary>
            class Cell : ICell
            {
                private float m_xPos, m_yPos;
                private string m_data;
                private TextBox m_textBox;
                private Form m_owner;
                private TextBox m_colHead; 

                public Cell(float x, float y)
                {
                    m_xPos = x;
                    m_yPos = y;
                    m_textBox = new TextBox();
                    m_textBox.TextChanged += M_textBox_TextChanged;
                    m_textBox.AutoSize = true;
                }

                private void M_textBox_TextChanged(object sender, EventArgs e)
                {
                    if(m_textBox.Width > m_colHead.Width)
                    {
                        m_colHead.Width = m_textBox.Width;   
                    }
                    m_data = m_textBox.Text;
                }

                public Form owner
                {
                    get { return m_owner; }
                    set { m_owner = value; }
                }

                public TextBox ColHeader
                {
                    get { return m_colHead; }
                    set { m_colHead = value; }
                }

                public float PositionX
                {
                    get { return m_xPos; }
                    set { m_xPos = value; }
                }

                public float PositionY
                {
                    get { return m_yPos; }
                    set { m_yPos = value; }
                }

                public string Data
                {
                    get { return m_data; }
                    set { m_data = value; }
                }

                public TextBox Textbox
                {
                    get { return m_textBox; }
                    set { m_textBox = value; }
                }
            }

            public Form formOwner;

            public float xPos, yPos;

            private List<ICell> m_cells;

            public Row()
            {
                m_cells = new List<ICell>();
            }

            float xoffset = 3;
            public void SetCells(ICell c)
            {
                c.owner.Controls.Add(c.Textbox);
                c.PositionX = xoffset;
                c.PositionY = yPos;
                c.Textbox.Location = new System.Drawing.Point((int)c.PositionX, (int)c.PositionY);
                xoffset += 106;
            }

            public List<ICell> Cells
            {
                get { return m_cells; }
                set { m_cells = value; }
            }

            public ICell Create(int num)
            {
                for(int i = 0; i < num; i++)
                {
                    Cell c = new Cell(xPos, yPos);
                    c.owner = formOwner;
                    m_cells.Add(c);
                }
                return null;
            }
        }

        private List<Row> m_rows;
        private List<TextBox> m_colheaders;

        Panel Grid;
        Form formOwner;

        public void AdjustColSize(TextBox t)
        {
            if(m_colheaders.Contains(t))
            {
                foreach (Row r in m_rows)
                {
                    r.Cells[m_colheaders.IndexOf(t)].Textbox.Width = t.Width;
                }
            }
        }

        public void ClearGrid()
        {
            foreach (Row r in m_rows)
            {
                foreach (ICell cell in r.Cells)
                {
                    if(cell.Textbox != null)
                        Grid.Controls.Remove(cell.Textbox);
                }
            }
        }

        public DataGrid(Panel g, Form h)
        {
            Grid = g;
            formOwner = h;
            m_colheaders = new List<TextBox>();
            m_rows = new List<Row>();
        }

        public List<Row> Rows
        {
            get { return m_rows; }
            set { m_rows = value; }
        }

        public List<TextBox> ColHeaders
        {
            get { return m_colheaders; }
            set { m_colheaders = value; }
        }

        public void CreateColHeader(string n)
        {
            TextBox l = new TextBox();
            l.Location = new System.Drawing.Point(m_colheaders.Last<TextBox>().Location.X, m_colheaders.Last<TextBox>().Location.Y + 106);
            l.Size = m_colheaders.Last<TextBox>().Size;
            l.Text = n;
            m_colheaders.Add(l);
            l.AutoSize = true;
            l.ReadOnly = true;
            formOwner.Controls.Add(l);
        }

        public IRow Create()
        {
            if(m_rows.Count == 0)
            {
                Row r = new Row();
                m_rows.Add(r);
                r.yPos = m_colheaders[0].Location.Y + 26;
                r.xPos = m_colheaders[0].Location.X;
                r.formOwner = formOwner;
                r.Create(m_colheaders.Count());
                foreach (ICell c in r.Cells)
                {
                    r.SetCells(c);
                    c.ColHeader = m_colheaders[r.Cells.IndexOf(c)];
                    c.Textbox.Width = c.ColHeader.Width;
                    Grid.Controls.Add(c.Textbox);
                }
                return r;
            }
            else if (m_rows.Count > 0)
            {
                Row r = new Row();             
                m_rows.Add(r);
                r.yPos = m_rows[m_rows.Count - 2].Cells[0].PositionY + 26;
                r.xPos = m_colheaders[0].Location.X;
                r.formOwner = formOwner;
                r.Create(m_colheaders.Count());
                foreach(ICell c in r.Cells)
                {
                    r.SetCells(c);
                    c.ColHeader = m_colheaders[r.Cells.IndexOf(c)];
                    c.Textbox.Width = c.ColHeader.Width;
                    Grid.Controls.Add(c.Textbox);
                }
                return r;
            }
            return null;
        }
    }
}
