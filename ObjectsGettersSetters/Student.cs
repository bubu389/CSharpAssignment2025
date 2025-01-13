using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsGettersSetters
{
    [Serializable]
    public class Student : Person
    {

        // Private Attributes

        private string s_Subject, s_Class;
        
        // Deafult Constructor
        public Student() : base() { } // Consistansy between the parent class (Person Class)

        // Override Constructor
        public Student(string name, string surname, string idCard, string address,
                       DateTime dateOfBirth, int contactNumber, string subject, string Class)
                       : base(name, surname, idCard, address,
                              dateOfBirth, contactNumber)
        {
            this.s_Subject = subject;
            this.s_Class = Class;
        }

        // --- Get and Set Methods ---

        public string Subject
        {
            get { return s_Subject; }
            set { this.s_Subject = value; }
        }

        public string ClassStudent
        {
            get { return s_Class; }
            set { this.s_Class = value; }
        }




    }
}
