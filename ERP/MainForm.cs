using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ERP
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public MainForm()
        {
            InitializeComponent();

            mainPanel.Controls.Clear();
            LoginForm loginForm = new LoginForm();
            loginForm.TopLevel = false;
            mainPanel.Controls.Add(loginForm);
            loginForm.Show();
            loginForm.Dock = DockStyle.Fill;
        }

        private void btnBack_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
            Panel mainPanel = mainForm.Controls["mainPanel"] as Panel;
            mainPanel.Controls.Clear();

            LoginForm loginForm = new LoginForm();
            loginForm.TopLevel = false;
            mainPanel.Controls.Add(loginForm);
            loginForm.Show();
            loginForm.Dock = DockStyle.Fill;
        }
    }
}
