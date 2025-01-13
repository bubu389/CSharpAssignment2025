using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsGettersSetters
{

    [Serializable]
    public class Person // Changed from internal to public
    {

        // Identification of the attributes

        // private attributes
        private string p_Name, p_Surname, p_IdCard; // type string

        // These variables can also be declared seperatly ; 
        // private string p_Name;
        // private string p_Surname;
        // private string p_IdCard;

        private DateTime p_DateOfBirth; // type date
        private int p_ContactNumber; // number without any decimal points

        // default constructor;


        public Person() { } // parameterless


        // Override Constructor (There can be more than one)
        // In the override consructor all the parameters will be passed for any instance of the object [ Person (in this case) ] 

        public Person(string name, string surname, string idCard, string address, DateTime dateOfBirth, int contactNumber) // includes parameters
        {
            this.p_Name = name;
            this.p_Surname = surname;
            this.p_IdCard = idCard;
            this.p_DateOfBirth = dateOfBirth;
            this.p_ContactNumber = contactNumber;
        }


        //  --- Get and Set Methods ---

        public string Name // get and set method for name
        {
            get { return p_Name; } // returns the value of the attribute (Getter)
            set { this.p_Name = value; } // overwrites the value of the attribute (Override)
        }

        public string Surname // get and set method for Surname
        {
            get { return p_Surname; }
            set { this.p_Surname = value; }
        }
        public string IdCard // get and set method for IdCard
        {
            get { return p_IdCard; }
            set { this.p_IdCard = value; }
        }

        public DateTime DateOfBirth // get and set method for DateOfBirth
        {
            get { return p_DateOfBirth; }
            set { this.p_DateOfBirth = value; }
        }

        public int ContactNumber // get and set method for ContactNumber
        {
            get { return p_ContactNumber; }
            set { this.p_ContactNumber = value; }
        }


    }
}
