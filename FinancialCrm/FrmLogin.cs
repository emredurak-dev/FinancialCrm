using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmLogin : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        FrmDashboard frmDashboard = new FrmDashboard();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password cannot be left blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            using (var context = new FinancialCrmDbEntities())
            {
                var user = context.Users.FirstOrDefault(x => x.Username == username && x.Password == password);
                if (user != null)
                {
                    MessageBox.Show("Welcome...");
                    frmDashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}