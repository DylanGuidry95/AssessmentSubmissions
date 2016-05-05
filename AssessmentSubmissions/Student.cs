using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentSubmissions
{
    [Serializable]
    public class Assignement
    {
        public enum Grades
        {
            competent,
            not_yet_competent,
            absence
        }
        private string m_name;
        private DateTime m_dueDate;
        private DateTime m_reassesmentDate;
        private Grades m_grade;
        public Assignement(string n, DateTime d)
        {
            m_name = n;
            m_dueDate = d;
        }
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        public DateTime DueDate
        {
            get { return m_dueDate; }
            set { m_dueDate = value; }
        }
        public DateTime ReassmentDate
        {
            get { return m_reassesmentDate; }
            set { m_reassesmentDate = value; }
        }
        public Grades Grade
        {
            get { return m_grade; }
            set { m_grade = value; }
        }
    }

    [Serializable]
    public class Student
    {
        private string m_name;
        private string m_gitUser;
        private string m_website;
        private Dictionary<Assignement, string> m_assignments;
        public Student(string n, string g, string u)
        {
            m_name = n;
            m_gitUser = g;
            m_website = u;
            m_assignments = new Dictionary<Assignement, string>();
        }
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        public string GitHub
        {
            get { return m_gitUser; }
            set { m_gitUser = value; }
        }
        public string Website
        {
            get { return m_website; }
            set { m_website = value; }
        }
    }

    [Serializable]
    public class ClassYear
    {
        private List<Student> m_enrolledStudents;
        private List<Assignement> m_classAssignments;
        private string m_className;
        public ClassYear(string n)
        {
            m_className = n;
        }
        public List<Student>EnrolledStudents
        {
            get { return m_enrolledStudents; }
            set { m_enrolledStudents = value; }
        }
        public List<Assignement>ClassAssignments
        {
            get { return m_classAssignments; }
            set { m_classAssignments = value; }
        }
    }
}
