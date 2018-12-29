namespace ERP
{
    partial class ListingEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListingEmployeeForm));
            this.gridListingEmployee = new System.Windows.Forms.DataGridView();
            this.btnRemoveEmployee = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxDepartment = new System.Windows.Forms.ComboBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSurname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDepartment = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridListingEmployee)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSurname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // gridListingEmployee
            // 
            this.gridListingEmployee.AllowUserToAddRows = false;
            this.gridListingEmployee.AllowUserToDeleteRows = false;
            this.gridListingEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListingEmployee.Location = new System.Drawing.Point(12, 12);
            this.gridListingEmployee.Name = "gridListingEmployee";
            this.gridListingEmployee.RowTemplate.Height = 28;
            this.gridListingEmployee.Size = new System.Drawing.Size(1000, 430);
            this.gridListingEmployee.TabIndex = 1;
            this.gridListingEmployee.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridListingEmployee_CellMouseClick);
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveEmployee.ImageOptions.Image")));
            this.btnRemoveEmployee.Location = new System.Drawing.Point(748, 526);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(264, 46);
            this.btnRemoveEmployee.TabIndex = 2;
            this.btnRemoveEmployee.Text = "Remove Employee";
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxDepartment);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 512);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 129);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Information";
            // 
            // cboxDepartment
            // 
            this.cboxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDepartment.FormattingEnabled = true;
            this.cboxDepartment.Items.AddRange(new object[] {
            "Intern",
            "Senior Software Development",
            "Software Architect",
            "Backend Developer",
            "Frontend Developer",
            "System Administrator",
            "Project Administrator",
            "Purchasing Specialist",
            "Mobile App Developer",
            "Web Developer",
            ""});
            this.cboxDepartment.Location = new System.Drawing.Point(152, 81);
            this.cboxDepartment.Name = "cboxDepartment";
            this.cboxDepartment.Size = new System.Drawing.Size(205, 28);
            this.cboxDepartment.TabIndex = 17;
            this.cboxDepartment.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cboxDepartment_PreviewKeyDown);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(482, 38);
            this.txtSurname.MaxLength = 24;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(205, 26);
            this.txtSurname.TabIndex = 9;
            this.txtSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurname_KeyPress);
            this.txtSurname.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtSurname_PreviewKeyDown);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(152, 39);
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
            this.label8.Location = new System.Drawing.Point(15, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Department:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(378, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(748, 593);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(264, 46);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update Employee";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "*Please select the user you want to delete or update.";
            // 
            // errorName
            // 
            this.errorName.ContainerControl = this;
            // 
            // errorSurname
            // 
            this.errorSurname.ContainerControl = this;
            // 
            // errorDepartment
            // 
            this.errorDepartment.ContainerControl = this;
            // 
            // ListingEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 703);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemoveEmployee);
            this.Controls.Add(this.gridListingEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListingEmployeeForm";
            this.Text = "Refresh";
            this.Load += new System.EventHandler(this.ListingEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridListingEmployee)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSurname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridListingEmployee;
        private DevExpress.XtraEditors.SimpleButton btnRemoveEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxDepartment;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.ErrorProvider errorSurname;
        private System.Windows.Forms.ErrorProvider errorDepartment;
    }
}