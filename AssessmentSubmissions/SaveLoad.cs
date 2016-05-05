using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Collections;

namespace AssessmentSubmissions
{
    /// <summary>
    /// Generic class that can be inherited by any other class that requires 
    /// information to be serialized and deseralized and needs to inherit from 
    /// Form class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class SaveLoad<T>
    {
        /// <summary>
        /// Creates a file that we can populate with all the 
        /// serializable data inside of the Object we pass in for the 
        /// argument of type T
        /// 
        /// I used a generic type here so that we can pass in any data type
        /// we need.
        /// 
        /// This function will create a file regardless if there is a file with 
        /// the same name located at the directory. It will just replae the old file
        /// with the new.
        /// </summary>
        /// <param name="s">Name of the file</param>
        /// <param name="t">Data we are passing in to be serialized</param>
        public static void Serialize(string s, T t)
        {
            using (FileStream fs = File.Create(Program.SaveDirectory + s + ".xml")) //Creates a FileStream using information from the file we created
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T)); //Creates a new BinaryFormatter to give us access to the Serialize function
                //We call the Serialize method and pass in the FileStream we created and the data inside of the object we passed into the function
                //When the data is being serialized it is being wrote into the created file in the form of bits and bytes there for if you open up the
                //file it is not human readable with the exception of the variables we declared.
                //To have the file in a human readable form we would use the SoapFormatter method
                serializer.Serialize(fs, t);
                fs.Close(); //Allways close your files when you are done using them
            }
        }

        /// <summary>
        /// This function is very similar to the serialize function we created above but the difference is 
        /// instead of writting to the file we will be reading the information into our application
        /// 
        /// We use a return type of T for this function so we can use this to assign the data we read in and
        /// assign it to any other data type as long as the data is compatiable.
        /// </summary>
        /// <param name="s">Name of the file we are looking for</param>
        /// <returns></returns>
        public static T Deserialize(string s)
        {
            T t; //We will use the as the return value
            using (FileStream fs = File.OpenRead(s)) //Same process as Serialize but instead of create we use OpenRead
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(T)); //Creates a new binaryFormatter that will give us access to the Deseralize function
                //We then call the Deserialize method and give it the arguments of the FileStream we created that contains all the data inside of the file
                //we opened and are reading from.
                //We take all this information and cast it as the return type and then set the variable we created at the head of the function equal to the
                //value of the Deseaialize method
                t = (T)deserializer.Deserialize(fs);
                fs.Close(); //Allways close your files when you are done using them
            }
            return t; //We then return t
        }

        /// <summary>
        /// Searches the designated file directory and all sub directories for all files
        /// that are saved in an XML format and adds them to a temporary list that we will 
        /// use as the return value whe the function is called 
        /// </summary>
        /// <returns> List of strings that we use to stroe all of the file paths for user created items </returns>
        public static List<string> FileNames()
        {
            List<string> temp = new List<string>(); //Data type to store our return value
            //Loops through each of the strings located in the directory and subdirectories of
            //the designated path. In this instance we are searching for files located at or below the Save_Files
            //Directory that are saved in an XML format and then adds those paths to our retrun value
            foreach (string s in Directory.GetFiles(Program.SaveDirectory, "*.xml", SearchOption.AllDirectories))
            {
                temp.Add(s);
            }
            //Returns are populated list with all of our file paths
            return temp;
        }
    }
}
