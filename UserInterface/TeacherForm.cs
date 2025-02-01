using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using ObjectsGettersSetters;
using ApplicationLogic;
using System.Diagnostics.Tracing;

namespace UserInterface
{
    public partial class frmTeacher : Form
    {
        public frmTeacher()
        {
            InitializeComponent();
        }

        private void InitTeacherList() { 
        
            var teachers = TeacherService.Load();

            foreach (var teacher in teachers) { 
            
                this.txtName.Text = teacher.Name;
                this.txtSurname.Text = teacher.Surname;
                this.txtIdCard.Text = teacher.IdCard;
                this.txtDOB.Text = Convert.ToString(teacher.DateOfBirth);
                this.txtSalary.Text = Convert.ToString(teacher.Salary);
                this.txtClassName.Text = teacher.ClassTeacher;
                this.txtContactNumber.Text = Convert.ToString(teacher.ContactNumber);
                this.txtSubject.Text = teacher.Subject;
                this.txtAddress.Text = teacher.Address;

            }
        }

        public void ClearComponents()
        {

            this.txtName.Text = "";
            this.txtSurname.Text = "";
            this.txtIdCard.Text = "";
            this.txtDOB.Text = "";
            this.txtSalary.Text = "";
            this.txtClassName.Text = "";
            this.txtContactNumber.Text = "";
            this.txtSubject.Text = "";
            this.txtAddress.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear entry values?", "Clearing Values", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                ClearComponents();

            }
            else {
                return; // do nothing
            }
        }

        private void frmTeacher_Load(object sender, EventArgs e)
        {
            this.btnEdit.Enabled = false;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(this.txtName.Text, "^[a-zA-Z]+$")) // or "^[a-zA-Z]+$"
            {
                //Showing a Message box to the end user informing the user about the incorrect entry,
                MessageBox.Show("This text box only accepts alphabetical characters", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Reset the submitted entry
                this.txtName.Text = ""; // or this.txtName.ResetText();
                // Set the focus back to the text box
                this.txtName.Focus();
            }
        }

        private void txtSurname_Leave(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(this.txtSurname.Text, "^[a-zA-Z]+$"))
            {
                //Showing a Message box to the end user informing the user about the incorrect entry,
                MessageBox.Show("This text box only accepts alphabetical characters", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Reset the submitted entry
                this.txtSurname.Text = ""; // or this.txtName.ResetText();

                // Set the focus back to the text box
                this.txtSurname.Focus();
            }
        }

        private void txtIdCard_Leave(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(this.txtIdCard.Text, "^[0-9]{8}"))
            {
                //Showing a Message box to the end user informing the user about the incorrect entry,
                MessageBox.Show("This text box only accepts 8 numerical characters", "Invalid ID Card Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Reset the submitted entry
                this.txtIdCard.Text = ""; // or this.txtName.ResetText();
                // Set the focus back to the text box
                this.txtIdCard.Focus();
            }
        }

        private void txtContactNumber_Leave(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(this.txtContactNumber.Text, "^[0-9]{8}"))
            {
                //Showing a Message box to the end user informing the user about the incorrect entry,
                MessageBox.Show("This text box only accepts 10 numerical characters", "Invalid Contact Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Reset the submitted entry
                this.txtContactNumber.Text = ""; // or this.txtName.ResetText();
                // Set the focus back to the text box
                this.txtContactNumber.Focus();
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(this.txtAddress.Text, "^[a-zA-Z0-9 ]"))
            {
                //Showing a Message box to the end user informing the user about the incorrect entry,
                MessageBox.Show("This text box only accepts alphabetical characters", "Invalid Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Reset the submitted entry
                this.txtAddress.Text = ""; // or this.txtName.ResetText();
                // Set the focus back to the text box
                this.txtAddress.Focus();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Calling the ClearComponents Method to dispose the text from the form components
            ClearComponents();
            // Showing an input box for the end user to submit the ID Card Number
            string userInput;
            userInput = Microsoft.VisualBasic.Interaction.InputBox("Please enter the ID Card Number", "Search Teacher's Record", "", 0, 0);


            // Load the teacher record based on the ID Card Number
            var teachers = TeacherService.Load(userInput);

            if (teachers != null)
            {

                this.txtName.Text = teachers.Name;
                this.txtSurname.Text = teachers.Surname;
                this.txtIdCard.Text = teachers.IdCard;
                this.txtDOB.Text = Convert.ToString(teachers.DateOfBirth);
                this.txtSalary.Text = Convert.ToString(teachers.Salary);
                this.txtClassName.Text = teachers.ClassTeacher;
                this.txtContactNumber.Text = Convert.ToString(teachers.ContactNumber);
                this.txtSubject.Text = teachers.Subject;
                this.txtAddress.Text = teachers.Address;

                // enable edit button 
                this.btnEdit.Enabled = true;



            }
            else {
                // using string interpolation to display the message box 
                // you can also use concatenation ': ' + userInput
                MessageBox.Show($"No record found with the submitted ID number : {userInput}", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //keep the edit button disabled
                this.btnEdit.Enabled = false; //ensuring it stays disabled
            }


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Creating a new instance of Teacher Class Object
            Teacher myTeacher = new Teacher();

            // Assigning the teachers object attributes with the newly submitted values
            myTeacher.Name = this.txtName.Text;
            myTeacher.Surname = this.txtSurname.Text;
            myTeacher.IdCard = this.txtIdCard.Text;
            myTeacher.DateOfBirth = DateTime.Parse(this.txtDOB.Text.ToString());
            myTeacher.Salary = float.Parse(this.txtSalary.Text);
            myTeacher.ClassTeacher = this.txtClassName.Text;
            myTeacher.ContactNumber = Convert.ToInt32(this.txtContactNumber.Text);
            myTeacher.Subject = this.txtSubject.Text;
            myTeacher.Address = this.txtAddress.Text;


            // Call the Save Method from the TeacherService Class
            TeacherService.Save(myTeacher);

            // Show a message box to the end user informing the user that the record has been updated
            MessageBox.Show("Record has been updated successfully", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.btnEdit.Enabled = false; // disable the edit button

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Creating a new instance of Teacher Class Object
            Teacher myTeacher = new Teacher();

            // Attributes 
            String cID, name, surname, address, subject, className;
            int contactNumber = 0;
            float salary = 0F;
            DateTime dob;

            Boolean quit = true;

            // Assigning the teachers object attributes with the newly submitted values
            do {

                // Assigning the variable name with the submitted text in the text box txtName
                name = this.txtName.Text;

                // Checking if the name variable is not null 
                if (name != null)
                {
                    if (name == "")
                    {
                        // Showing a Message box to the end user informing the user about the incorrect entry,
                        MessageBox.Show("Name cannot be empty", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Initiating the error provider to inform the end user about the incorrect entry
                        this.erpProvider.SetError(this.txtName, "Name cannot be empty");

                        quit = true;

                        break;
                    }
                    else
                    {
                        quit = false;
                        this.erpProvider.Dispose();
                    }
                }
                else
                {
                    return;
                }

                // Assigning the variable surname with the submitted text in the text box txtSurname
                surname = this.txtSurname.Text;

                // Checking if the surname variable is not null 
                if (surname != null)
                {
                    if (surname == "")
                    {
                        // Showing a Message box to the end user informing the user about the incorrect entry,
                        MessageBox.Show("Surname cannot be empty", "Invalid Surname", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Initiating the error provider to inform the end user about the incorrect entry
                        this.erpProvider.SetError(this.txtSurname, "Surname cannot be empty");

                        quit = true;
                        break;
                    }
                    else
                    {
                        quit = false;
                        this.erpProvider.Dispose();
                    }
                }
                else
                {
                    return;
                }

                address = this.txtAddress.Text;

                // Checking if the address variable is not null 
                if (address != null)
                {
                    if (address == "")
                    {
                        // Showing a Message box to the end user informing the user about the incorrect entry,
                        MessageBox.Show("Address cannot be empty", "Invalid Address", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Initiating the error provider to inform the end user about the incorrect entry
                        this.erpProvider.SetError(this.txtAddress, "Address cannot be empty");
                        quit = true;
                        break;
                    }
                    else
                    {
                        quit = false;
                        this.erpProvider.Dispose();
                    }
                }
                else
                {
                    return;
                }

                subject = this.txtSubject.Text;

                // Checking if the subject variable is not null 
                if (subject != null)
                {
                    if (subject == "")
                    {
                        // Showing a Message box to the end user informing the user about the incorrect entry,
                        MessageBox.Show("Subject cannot be empty", "Invalid Subject", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Initiating the error provider to inform the end user about the incorrect entry
                        this.erpProvider.SetError(this.txtSubject, "Subject cannot be empty");
                        quit = true;
                        break;
                    }
                    else
                    {
                        quit = false;
                        this.erpProvider.Dispose();
                    }
                }
                else
                {
                    return;
                }

                cID = this.txtIdCard.Text;

                // Checking if the cID variable is not null

                if (cID != null)
                {
                    if (cID == "")
                    {
                        // Showing a Message box to the end user informing the user about the incorrect entry,
                        MessageBox.Show("ID Card cannot be empty", "Invalid ID Card", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Initiating the error provider to inform the end user about the incorrect entry
                        this.erpProvider.SetError(this.txtIdCard, "ID Card cannot be empty");

                        quit = true;
                        break;
                    }
                    else
                    {
                        quit = false;
                        this.erpProvider.Dispose();
                    }
                }
                else
                {
                    return;
                }

                contactNumber = int.Parse(this.txtContactNumber.Text);

                if (contactNumber != 0)
                {
                    if (contactNumber == 0)
                    {
                        // Showing a Message box to the end user informing the user about the incorrect entry,
                        MessageBox.Show("Contact Number cannot be empty", "Invalid Contact Number", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Initiating the error provider to inform the end user about the incorrect entry
                        this.erpProvider.SetError(this.txtContactNumber, "Contact Number cannot be empty");

                        quit = true;
                        break;
                    }
                    else
                    {
                        quit = false;
                        this.erpProvider.Dispose();
                    }
                }
                else
                {
                    return;
                }

                salary = float.Parse(this.txtSalary.Text);

                if (salary != 0)
                {
                    if (salary == 0)
                    {
                        // Showing a Message box to the end user informing the user about the incorrect entry,
                        MessageBox.Show("Salary cannot be empty", "Invalid Salary", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Initiating the error provider to inform the end user about the incorrect entry
                        this.erpProvider.SetError(this.txtSalary, "Salary cannot be empty");

                        quit = true;
                        break;
                    }
                    else
                    {
                        quit = false;
                        this.erpProvider.Dispose();
                    }
                }
                else
                {
                    return;
                }


                className = this.txtClassName.Text;


                if (className != null)
                {
                    if (className == "")
                    {
                        // Showing a Message box to the end user informing the user about the incorrect entry,
                        MessageBox.Show("Class Name cannot be empty", "Invalid Class Name", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Initiating the error provider to inform the end user about the incorrect entry
                        this.erpProvider.SetError(this.txtClassName, "Class Name cannot be empty");

                        quit = true;
                        break;
                    }
                    else
                    {
                        quit = false;
                        this.erpProvider.Dispose();
                    }
                }
                else
                {
                    return;
                }

                dob = DateTime.Parse(this.txtDOB.Text);

                if (dob != null)
                {
                    if (dob > DateTime.Today)
                    {
                        // Showing a Message box to the end user informing the user about the incorrect entry,
                        MessageBox.Show("Date of Birth is Invalid", "Invalid Date of Birth", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Initiating the error provider to inform the end user about the incorrect entry
                        this.erpProvider.SetError(this.txtDOB, "DOB Required");

                        quit = true;

                        break;
                    }
                    else
                    {
                        quit = false;
                        this.erpProvider.Dispose();
                    }
                }
                else
                {
                    return;
                }

                // Assigning the teachers object attributes with the newly submitted values
                myTeacher.Name = name;
                myTeacher.Surname = surname;
                myTeacher.IdCard = cID;
                myTeacher.DateOfBirth = dob;
                myTeacher.Salary = salary;
                myTeacher.ClassTeacher = className;
                myTeacher.ContactNumber = contactNumber;
                myTeacher.Subject = subject;
                myTeacher.Address = address;


                // Call the Save Method from the TeacherService Class
                TeacherService.Save(myTeacher);

                // Show a message box to the end user informing the user that the record has been updated
                MessageBox.Show("Record has been created successfully", "Record Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            while (quit);







        }
    }
}
