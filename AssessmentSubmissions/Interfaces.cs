using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        Grades Grade { get; set; }
    }

    public interface IClass
    {
        ArrayList Students { get; set; }
        void AddStudent(IStudents s);
    }

    public interface ISchoolFactory
    {
        IClass Create(string n);
    }
}
