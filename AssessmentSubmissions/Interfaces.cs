using System;
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

    interface IStudents
    {
        string Name { get; set; }
        string GitHub { get; set; }
        string Website { get; set; }
        List<IAssignment> Assignments { get; set; }
    }

    interface IStudentFactory
    {
        IStudents Create(string name);
    }

    interface IAssignment
    {
        string Name { get; set; }
        string FeedBackForm { get; set; }
        Grades Grade { get; set; }
    }

    interface IClass
    {
        List<IStudents> Students { get; set; }
        void AddStudent(IStudents s);
    }

    interface ISchoolFactory
    {
        IClass Create(string n);
    }
}
