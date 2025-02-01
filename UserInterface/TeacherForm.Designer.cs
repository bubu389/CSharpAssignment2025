namespace UserInterface
{
    partial class frmTeacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblIdCard = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtIdCard = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.MaskedTextBox();
            this.txtContactNumber = new System.Windows.Forms.MaskedTextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.erpProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erpProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AccessibleName = "lblName";
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(53, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AccessibleName = "lblSurname";
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(430, 55);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname:";
            // 
            // lblAddress
            // 
            this.lblAddress.AccessibleName = "lblAdress";
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(53, 284);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address:";
            // 
            // lblIdCard
            // 
            this.lblIdCard.AccessibleName = "lblIdCard";
            this.lblIdCard.AutoSize = true;
            this.lblIdCard.Location = new System.Drawing.Point(430, 133);
            this.lblIdCard.Name = "lblIdCard";
            this.lblIdCard.Size = new System.Drawing.Size(41, 13);
            this.lblIdCard.TabIndex = 3;
            this.lblIdCard.Text = "IdCard:";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AccessibleName = "lblContactNumber";
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(53, 213);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(87, 13);
            this.lblContactNumber.TabIndex = 4;
            this.lblContactNumber.Text = "Contact Number:";
            // 
            // lblClassName
            // 
            this.lblClassName.AccessibleName = "lblClassName";
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(430, 213);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(66, 13);
            this.lblClassName.TabIndex = 5;
            this.lblClassName.Text = "Class Name:";
            // 
            // lblSubject
            // 
            this.lblSubject.AccessibleName = "lblSubject";
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(53, 355);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(46, 13);
            this.lblSubject.TabIndex = 6;
            this.lblSubject.Text = "Subject:";
            // 
            // lblSalary
            // 
            this.lblSalary.AccessibleName = "lblSalary";
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(430, 352);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(39, 13);
            this.lblSalary.TabIndex = 7;
            this.lblSalary.Text = "Salary:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(184, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(225, 20);
            this.txtName.TabIndex = 8;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(184, 281);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(590, 20);
            this.txtAddress.TabIndex = 9;
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(184, 352);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(225, 20);
            this.txtSubject.TabIndex = 11;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(549, 52);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(225, 20);
            this.txtSurname.TabIndex = 12;
            this.txtSurname.Leave += new System.EventHandler(this.txtSurname_Leave);
            // 
            // txtIdCard
            // 
            this.txtIdCard.Location = new System.Drawing.Point(549, 130);
            this.txtIdCard.Name = "txtIdCard";
            this.txtIdCard.Size = new System.Drawing.Size(225, 20);
            this.txtIdCard.TabIndex = 13;
            this.txtIdCard.Leave += new System.EventHandler(this.txtIdCard_Leave);
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(549, 206);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(225, 20);
            this.txtClassName.TabIndex = 14;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(549, 348);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(225, 20);
            this.txtSalary.TabIndex = 15;
            // 
            // lblDOB
            // 
            this.lblDOB.AccessibleName = "lblSalary";
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(53, 133);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(69, 13);
            this.lblDOB.TabIndex = 16;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(184, 130);
            this.txtDOB.Mask = "00/00/0000";
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(225, 20);
            this.txtDOB.TabIndex = 17;
            this.txtDOB.ValidatingType = typeof(System.DateTime);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(184, 206);
            this.txtContactNumber.Mask = "00000000";
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(225, 20);
            this.txtContactNumber.TabIndex = 18;
            this.txtContactNumber.Leave += new System.EventHandler(this.txtContactNumber_Leave);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(699, 415);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(456, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(618, 415);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(537, 415);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // erpProvider
            // 
            this.erpProvider.ContainerControl = this;
            // 
            // frmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.txtIdCard);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.lblIdCard);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Name = "frmTeacher";
            this.Text = "Teacher Window";
            this.Load += new System.EventHandler(this.frmTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblIdCard;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtIdCard;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.MaskedTextBox txtDOB;
        private System.Windows.Forms.MaskedTextBox txtContactNumber;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ErrorProvider erpProvider;
    }
}

