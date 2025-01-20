using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectsGettersSetters;
using DataAccess;
namespace ApplicationLogic
{
    public class TeacherService
    {
        // Loading the record based on the teachers Id card number
        public static Teacher Load(string idCardNo)
        {
            return TeacherDA.Load(idCardNo);

        }

        // Onload the list of type teacher is loaded with all teacher object instances

        public static List<Teacher> Load()
        {
            return TeacherDA.Load();
        }

        // function with Id card validation
        private static bool ValidateModel(Teacher teacher) {

            // Validate the teacher instance by checking if the Teachers Id Card attribute is either empty or null
            if (string.IsNullOrEmpty(teacher.IdCard)) {

                return false;
            }
            return true;
        }

        //save function

        public static bool Save(Teacher teacher) { 
            
            bool isValid = ValidateModel(teacher); // Call the ValidateModel Method
            if (isValid) // Always true
            {
                return TeacherDA.Save(teacher);
            }
            else
            {
                return false;

            }
        }

    }
}
