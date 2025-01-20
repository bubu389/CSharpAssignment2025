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
    }
}
