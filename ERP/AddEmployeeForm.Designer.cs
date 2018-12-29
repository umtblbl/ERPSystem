namespace ERP
{
    partial class AddEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxLogin = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.dTimeBirthday = new System.Windows.Forms.DateTimePicker();
            this.dTimeStartofwork = new System.Windows.Forms.DateTimePicker();
            this.cboxDepartment = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSurname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorGender = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAge = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDepartmen = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSurname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDepartmen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxLogin);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.dTimeBirthday);
            this.groupBox1.Controls.Add(this.dTimeStartofwork);
            this.groupBox1.Controls.Add(this.cboxDepartment);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtGender);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(295, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 556);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Information";
            // 
            // checkBoxLogin
            // 
            this.checkBoxLogin.AutoSize = true;
            this.checkBoxLogin.Location = new System.Drawing.Point(56, 412);
            this.checkBoxLogin.Name = "checkBoxLogin";
            this.checkBoxLogin.Size = new System.Drawing.Size(138, 24);
            this.checkBoxLogin.TabIndex = 28;
            this.checkBoxLogin.Text = "Unit authority?";
            this.checkBoxLogin.UseVisualStyleBackColor = true;
            this.checkBoxLogin.CheckedChanged += new System.EventHandler(this.checkBoxLogin_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(192, 495);
            this.txtPassword.MaxLength = 8;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(205, 26);
            this.txtPassword.TabIndex = 30;
            this.txtPassword.Visible = false;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtPassword_PreviewKeyDown);
            // 
            // dTimeBirthday
            // 
            this.dTimeBirthday.Location = new System.Drawing.Point(191, 370);
            this.dTimeBirthday.Name = "dTimeBirthday";
            this.dTimeBirthday.Size = new System.Drawing.Size(205, 26);
            this.dTimeBirthday.TabIndex = 19;
            // 
            // dTimeStartofwork
            // 
            this.dTimeStartofwork.Location = new System.Drawing.Point(191, 324);
            this.dTimeStartofwork.Name = "dTimeStartofwork";
            this.dTimeStartofwork.Size = new System.Drawing.Size(205, 26);
            this.dTimeStartofwork.TabIndex = 18;
            // 
            // cboxDepartment
            // 
            this.cboxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDepartment.FormattingEnabled = true;
            this.cboxDepartment.Items.AddRange(new object[] {
            "Purchasing Specialist",
            "Intern",
            "Senior Software Development",
            "Software Architect",
            "Mobile Developer Architect",
            "Backend Developer",
            "Frontend Developer",
            "System Administrator",
            "Project Administrator",
            "Mobile App Developer",
            "Web Developer"});
            this.cboxDepartment.Location = new System.Drawing.Point(191, 275);
            this.cboxDepartment.Name = "cboxDepartment";
            this.cboxDepartment.Size = new System.Drawing.Size(205, 28);
            this.cboxDepartment.TabIndex = 17;
            this.cboxDepartment.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cboxDepartment_PreviewKeyDown);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(192, 453);
            this.txtUserName.MaxLength = 8;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(205, 26);
            this.txtUserName.TabIndex = 29;
            this.txtUserName.Visible = false;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            this.txtUserName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtUserName_PreviewKeyDown);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(191, 229);
            this.txtAge.MaxLength = 3;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(205, 26);
            this.txtAge.TabIndex = 11;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtAge.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtAge_PreviewKeyDown);
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(191, 183);
            this.txtGender.MaxLength = 10;
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(205, 26);
            this.txtGender.TabIndex = 10;
            this.txtGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGender_KeyPress);
            this.txtGender.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtGender_PreviewKeyDown);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(54, 496);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(104, 25);
            this.lblPassword.TabIndex = 27;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Visible = false;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(191, 142);
            this.txtSurname.MaxLength = 24;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(205, 26);
            this.txtSurname.TabIndex = 9;
            this.txtSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurname_KeyPress);
            this.txtSurname.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtSurname_PreviewKeyDown);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.Location = new System.Drawing.Point(54, 454);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(116, 25);
            this.lblUserName.TabIndex = 26;
            this.lblUserName.Text = "User Name:";
            this.lblUserName.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(191, 100);
            this.txtName.MaxLength = 24;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(205, 26);
            this.txtName.TabIndex = 8;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtName_PreviewKeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(51, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Department:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(51, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Age:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(51, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start of work:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(51, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birthday:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(51, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(614, 650);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 55);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(413, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 40);
            this.label7.TabIndex = 20;
            this.label7.Text = "Add Employee";
            // 
            // errorName
            // 
            this.errorName.ContainerControl = this;
            // 
            // errorSurname
            // 
            this.errorSurname.ContainerControl = this;
            // 
            // errorGender
            // 
            this.errorGender.ContainerControl = this;
            // 
            // errorAge
            // 
            this.errorAge.ContainerControl = this;
            // 
            // errorDepartmen
            // 
            this.errorDepartmen.ContainerControl = this;
            // 
            // errorID
            // 
            this.errorID.ContainerControl = this;
            // 
            // errorPassword
            // 
            this.errorPassword.ContainerControl = this;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 750);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSurname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDepartmen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dTimeBirthday;
        private System.Windows.Forms.DateTimePicker dTimeStartofwork;
        private System.Windows.Forms.ComboBox cboxDepartment;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.ErrorProvider errorSurname;
        private System.Windows.Forms.ErrorProvider errorGender;
        private System.Windows.Forms.ErrorProvider errorAge;
        private System.Windows.Forms.ErrorProvider errorDepartmen;
        private System.Windows.Forms.ErrorProvider errorID;
        private System.Windows.Forms.ErrorProvider errorPassword;
    }
}