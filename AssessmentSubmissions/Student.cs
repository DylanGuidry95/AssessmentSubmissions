﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentSubmissions
{
    class StudentFactory : IStudentFactory
    {
        class Student : IStudents
        {
            private string m_name;                          //Name of the student

            private string m_gitUser;                       //GitHub user name the student will use to version work

            private string m_website;                       //Website URL the student uses to show his/her work on the web

            List<IAssignment> m_assignment;                 //List of assignments the student is responsible to complete 
                                                            //thorugh out his/her time at AIE
            /// <summary>
            /// Constructor for object of type student
            /// Take the value of the argument passed in and sets the variable
            /// m_name to its value. This name will be how students will be identified
            /// in the system for easy access to their assignment record and other information
            /// associated with that student.
            /// </summary>
            /// <param name="n">Value that will be assigned to the variable m_name</param>
            public Student(string n) { m_name = n; }  
            
            /// <summary>
            /// Property that is being implemented from the IStudents interface.
            /// This will be used by out side classes to get the values and add
            /// to the list of assignments the student has had assigned to them.
            /// </summary>      
            public List<IAssignment> Assignments
            {
                get { return m_assignment; } //Gets the value of m_assignment and returns it
                set { m_assignment = value; } //Changes the value of m_assignement to the value of Assignments
            }

            /// <summary>
            /// Property that is being implemented from the IStudents interface.
            /// This will be used by out side classes to get the value and modify
            /// the value of m_name.
            /// </summary> 
            public string Name
            {
                get { return m_name; } //returns the value of m_name.
                set { m_name = value; } //changes the value of m_name to the value of Name.
            }

            /// <summary>
            /// Property that is being implemented from the IStudents interface.
            /// This will be used by out side classes to get the value and modify
            /// the value of m_gitUser.
            /// </summary>
            public string GitHub
            {
                get { return m_gitUser; } //returns the value of m_gitUser
                set { m_gitUser = value; } //Sets the vlaue of m_gitUser to the value of GitHub
            }

            /// <summary>
            /// Property that is being implemented from the IStudents interface.
            /// This will be used by out side classes to get the value and modify
            /// the value of m_website.
            /// </summary>
            public string Website
            {
                get { return m_website; } //returns the value of m_website
                set { m_website = value; } //sets the value of m_website to the value of Website
            }
        }

        /// <summary>
        /// Property that is being implemented from the IStudentFactory interface.
        /// Creates a new student with the name set the value
        /// of the argument passed in.
        /// </summary>
        /// <param name="name">value that will be used in creating a new student object</param>
        /// <returns></returns>
        public IStudents Create(string name)
        {
            return new Student(name);
        }
    }

    class SchoolFactory : ISchoolFactory
    {
        class YearOne : IClass
        {
            IStudentFactory StudentFactory;
            private List<IStudents> m_students; //List of studetns in the class

            /// <summary>
            /// Contrustor used to create a new instance of a year two class
            /// </summary>
            public YearOne() { }

            /// <summary>
            /// Property that is being implemented from the IClass interface.
            /// Allows objects from outside this class to modify and retrive the
            /// value assigned to m_students.
            /// </summary>
            public List<IStudents> Students
            {
                get { return m_students; } //returns the value of m_students
                set { m_students = value; } //sets the value of m_students to the value of Students
            }

            /// <summary>
            /// Property that is being implemented from the IClass interface.
            /// Will allow the user to add new studetns to the class even after the class
            /// has been created without creating an entierly new list of studetns.
            /// </summary>
            /// <returns>s is the student we are trying to add the list of students in the class</returns>
            public void AddStudent(IStudents s)
            {
                if (!m_students.Contains(s)) //If the student is not allready in the class we add him 
                    m_students.Add(s); //Adds the student passed in to the function to the list of students
                else //if the student is all ready in the class we let the user know they are trying to add the same student to the class
                    System.Windows.Forms.MessageBox.Show("Student allready enrolled in this class");
            }
        }

        class YearTwo : IClass
        {
            IStudentFactory StudentFactory;
            private List<IStudents> m_students; //List of studetns in the class

            /// <summary>
            /// Contrustor used to create a new instance of a year two class
            /// </summary>
            public YearTwo() { }

            /// <summary>
            /// Property that is being implemented from the IClass interface.
            /// Allows objects from outside this class to modify and retrive the
            /// value assigned to m_students.
            /// </summary>
            public List<IStudents> Students
            {
                get { return m_students; } //returns the value of m_students
                set { m_students = value; } //sets the value of m_students to the value of Students
            }

            /// <summary>
            /// Property that is being implemented from the IClass interface.
            /// Will allow the user to add new studetns to the class even after the class
            /// has been created without creating an entierly new list of studetns.
            /// </summary>
            /// <returns>s is the student we are trying to add the list of students in the class</returns>
            public void AddStudent(IStudents s)
            {
                if (!m_students.Contains(s)) //If the student is not allready in the class we add him 
                    m_students.Add(s); //Adds the student passed in to the function to the list of students
                else //if the student is all ready in the class we let the user know they are trying to add the same student to the class
                    System.Windows.Forms.MessageBox.Show("Student allready enrolled in this class");
            }
        }

        public IClass Create(string n)
        {
            switch(n)
            {
                case "YearOne":
                    return new YearOne();
                case "YearTwo":
                    return new YearTwo();
                default:
                    break;
            }
            return null;
        }
    }

    class Assignment : IAssignment
    {
        private string m_assignmentName; //Name of the assignment
        private string m_formAddress; //Location the form is located at for retrival
        private Grades m_grade; //Grade student earned on assessment

        /// <summary>
        /// Constror use when the user wants to create a new assignment.
        /// the value of the string argument passed into the function call
        /// will be applied to the value of m_assignmentName.
        /// </summary>
        /// <param name="n">Value to be assigned to the value of m_assignmentName</param>
        public Assignment(string n)
        {
            m_assignmentName = n; //Sets m_assingmentName equal to the value of the argument n
        }

        /// <summary>
        /// Property that is being implemented from the IAssignment interface.
        /// Allows objects that are not of this type to retrive and modify the value
        /// of the variable m_assignmentName.
        /// </summary>
        public string Name
        {
            get { return m_assignmentName; } //returns the value of m_assignmentName
            set { m_assignmentName = value; } //sets the value of m_assignmentName to the value of Name
        }

        /// <summary>
        /// Property that is being implemented from the IAssignment interface.
        /// Allows objects that are not of this type to retrive and modify the value
        /// of the variable m_formAddress.
        /// </summary>
        public string FeedBackForm
        {
            get { return m_formAddress; } //returns the value of m_formAddress
            set { m_formAddress = value; } //sets the value of m_formAddress to the value of FeedBackForm
        }

        /// <summary>
        /// Property that is being implemented from the IAssignment interface.
        /// Allows objects that are not of this type to retrive and modify the value
        /// of the variable m_grade.
        /// </summary>
        public Grades Grade
        {
            get { return m_grade; } //returns the value of m_grade
            set { m_grade = value; } //sets the value of m_grade to the value of Grade
        }
    }
}
