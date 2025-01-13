using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using ObjectsGettersSetters;

namespace DataAccess
{
    public class StudentDA
    {

        private const string DataRepositoryFolder = "data\\students\\"; // Folder Location
        private const string FileExtention = ".bin"; // File Extention (Bianry File)

        private static void PrepareRepository() {

            // Check if the folder exists
            if (!Directory.Exists(DataRepositoryFolder)) {

                Directory.CreateDirectory(DataRepositoryFolder); // If it doesn't exist it will create the folder
                Console.WriteLine("Data Repository Created"); // Message to the user
            }
        }

        private static string GetRepositoryFilePath(string idCardNo) { 
        
            PrepareRepository(); // Call the PrepareRepository Method
            string targetPath = string.Format(DataRepositoryFolder, "{0}" + FileExtention + idCardNo);
            return targetPath;
        }

        private static bool Save(Student student)
        {
            BinaryFormatter myBinaryFormatter = new BinaryFormatter();
            string targetPath = GetRepositoryFilePath(student.IdCard);

            using (StreamWriter myStreamWriter = new StreamWriter(targetPath, false, Encoding.UTF8)) { // using is like break

                myBinaryFormatter.Serialize(myStreamWriter.BaseStream, student);
                
            }
            return true;
        }

        private static Student Load(string idCardNo) { 
            
            string targetPath = GetRepositoryFilePath(idCardNo);
            { 

                if (File.Exists(targetPath)) {

                    BinaryFormatter myBinaryFormatter = new BinaryFormatter();
                    using (StreamReader myStream = new StreamReader(targetPath)) {

                        return myBinaryFormatter.Deserialize(myStream.BaseStream) as Student;
                    }
                }
                return null; // Nothing will be returned

            }
        }

        public static List<Student> Load() { 
            
            List<Student> myList = new List<Student>();
            string targetPath = DataRepositoryFolder;
            if (Directory.Exists(targetPath)) { 
            
                DirectoryInfo myDirecoryInfo = new DirectoryInfo(targetPath);
                FileInfo[] files = myDirecoryInfo.GetFiles("*" + FileExtention); // Anything  + .bin

                BinaryFormatter myBinaryformatter = new BinaryFormatter();
                foreach (var file in files) // loop
                {

                    string path = file.FullName;
                    using (StreamReader myStream = new StreamReader(path)) {

                        myList.Add(myBinaryformatter.Deserialize(myStream.BaseStream) as Student);


                    }

                }

            }
            return myList;

        }
    }
}
