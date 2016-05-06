using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssessmentSubmissions
{
    public enum Grades
    {
        competent,
        not_yet_competent,
        absent
    }

    public interface IStudents
    {
        string Name { get; set; }
        string GitHub { get; set; }
        string Website { get; set; }
        ArrayList Assignments { get; set; }
    }

    public interface IStudentFactory
    {
        IStudents Create(string name);
    }

    public interface IAssignment
    {
        string Name { get; set; }
        string FeedBackForm { get; set; }
        ArrayList Requirements { get; set; }
        Grades Grade { get; set; }
    }

    public interface IClass
    {
        ArrayList Students { get; set; }
        ArrayList AllAssignments { get; set; }
        void AddStudent(IStudents s);
    }

    public interface ISchoolFactory
    {
        IClass Create(string n);
    }

    public interface ICell
    {
        Form owner { get; set; }
        float PositionX { get; set; }
        float PositionY { get; set; }
        string Data { get; set; }
        TextBox Textbox { get; set; }
    }

    public interface IRow
    {
        List<ICell> Cells { get; set; }
    }

    public interface IGridFactory
    {
        List<DataGrid.Row> Rows { get; set; }
        List<TextBox> ColHeaders { get; set; }
        void CreateColHeader(string n);
        IRow Create();
    }
}
