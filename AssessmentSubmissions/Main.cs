using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentSubmissions
{
    class Main
    {
        public static Home HomeScreen; //refrence to the HomeScreen form of the app
        public static Mock ClassInfo; //refrence to the class information form of the app
        public static StudentForm StudentCreation; //refrence to the create student form of the app

        public static SchoolFactory school = new SchoolFactory(); //refrence to the SchoolFactory class
    }
}
