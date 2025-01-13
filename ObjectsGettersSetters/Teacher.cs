using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsGettersSetters
{
    [Serializable]
    public class Teacher : Person
    {
        // Private Attributes
        private string t_Subject, t_Class;
        private float t_Salary;

        // Default Constructor
        public Teacher() : base() { }

        // Override Constructor
        public Teacher(string name, string surname, string idCard, string address,
                       DateTime dateOfBirth, int contactNumber, string subject, string Class, float salary)
                       : base(name, surname, idCard, address,
                              dateOfBirth, contactNumber)
        {
            this.t_Subject = subject;
            this.t_Class = Class;
            this.t_Salary = salary;
        }

        // --- Get and Set Methods ---
        public string Subject
        {
            get { return t_Subject; }
            set { this.t_Subject = value; }
        }

        public string ClassTeacher
        {
            get { return t_Class; }
            set { this.t_Class = value; }
        }

        public float Salary
        {
            get { return t_Salary; }
            set { this.t_Salary = value; }
        }


    }
}
