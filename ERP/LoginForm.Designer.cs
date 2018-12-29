namespace ERP
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLoginUnitAdmin = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoginPurchasingAdmin = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoginAdministrator = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAbout = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLoginUnitAdmin);
            this.groupBox2.Controls.Add(this.btnLoginPurchasingAdmin);
            this.groupBox2.Controls.Add(this.btnLoginAdministrator);
            this.groupBox2.Location = new System.Drawing.Point(283, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(729, 176);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input Type";
            // 
            // btnLoginUnitAdmin
            // 
            this.btnLoginUnitAdmin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoginUnitAdmin.ImageOptions.Image")));
            this.btnLoginUnitAdmin.Location = new System.Drawing.Point(485, 55);
            this.btnLoginUnitAdmin.Name = "btnLoginUnitAdmin";
            this.btnLoginUnitAdmin.Size = new System.Drawing.Size(209, 73);
            this.btnLoginUnitAdmin.TabIndex = 4;
            this.btnLoginUnitAdmin.Text = "Unit Admin";
            this.btnLoginUnitAdmin.Click += new System.EventHandler(this.btnLoginUnitAdmin_Click);
            // 
            // btnLoginPurchasingAdmin
            // 
            this.btnLoginPurchasingAdmin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoginPurchasingAdmin.ImageOptions.Image")));
            this.btnLoginPurchasingAdmin.Location = new System.Drawing.Point(261, 55);
            this.btnLoginPurchasingAdmin.Name = "btnLoginPurchasingAdmin";
            this.btnLoginPurchasingAdmin.Size = new System.Drawing.Size(202, 73);
            this.btnLoginPurchasingAdmin.TabIndex = 3;
            this.btnLoginPurchasingAdmin.Text = "Purchasing Admin";
            this.btnLoginPurchasingAdmin.Click += new System.EventHandler(this.btnLoginPurchasingAdmin_Click);
            // 
            // btnLoginAdministrator
            // 
            this.btnLoginAdministrator.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoginAdministrator.ImageOptions.Image")));
            this.btnLoginAdministrator.Location = new System.Drawing.Point(36, 55);
            this.btnLoginAdministrator.Name = "btnLoginAdministrator";
            this.btnLoginAdministrator.Size = new System.Drawing.Size(209, 73);
            this.btnLoginAdministrator.TabIndex = 2;
            this.btnLoginAdministrator.Text = "Administrator";
            this.btnLoginAdministrator.Click += new System.EventHandler(this.btnLoginAdministrator_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Location = new System.Drawing.Point(396, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 182);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(39, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(39, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Name:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(159, 102);
            this.txtPassword.MaxLength = 8;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(251, 27);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtPassword_PreviewKeyDown);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(159, 56);
            this.txtID.MaxLength = 8;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(251, 27);
            this.txtID.TabIndex = 0;
            this.txtID.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtID_PreviewKeyDown);
            // 
            // btnExit
            // 
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(639, 563);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 47);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.ImageOptions.Image")));
            this.btnAbout.Location = new System.Drawing.Point(496, 563);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(121, 47);
            this.btnAbout.TabIndex = 13;
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label3.Location = new System.Drawing.Point(520, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 39);
            this.label3.TabIndex = 12;
            this.label3.Text = "ERP System";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 8F);
            this.label4.Location = new System.Drawing.Point(424, 624);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(456, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Info: Winter is coming. New winter theme is ready :)";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 743);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnLoginUnitAdmin;
        private DevExpress.XtraEditors.SimpleButton btnLoginPurchasingAdmin;
        private DevExpress.XtraEditors.SimpleButton btnLoginAdministrator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtID;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnAbout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}