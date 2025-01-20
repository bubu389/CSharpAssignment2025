using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using ObjectsGettersSetters;

namespace ApplicationLogic
{
    internal class StudentService
    {

        // Loading the record based on the Student Id card number
        public static Student Load(string idCardNo)
        {
            return StudentDA.Load(idCardNo);

        }

        // Onload the list of type student is loaded with all student object instances

        public static List<Student> Load()
        {
            return StudentDA.Load();
        }

        // function with Id card validation
        private static bool ValidateModel(Student student)
        {

            // Validate the student instance by checking if the students Id Card attribute is either empty or null
            if (string.IsNullOrEmpty(student.IdCard))
            {

                return false;
            }
            return true;
        }

        //save function

        public static bool Save(Student student)
        {

            bool isValid = ValidateModel(student); // Call the ValidateModel Method
            if (isValid) // Always true
            {
                return StudentDA.Save(student);
            }
            else
            {
                return false;

            }
        }
    }
}
