using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace FinancialCrm
{

    public partial class FrmSpendings : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private string connectionString = "Data Source=DESKTOP-HJCF1IL;Initial Catalog=FinancialCrmDb;Integrated Security=True;TrustServerCertificate=True";

        public FrmSpendings()
        {
            InitializeComponent();
        }

        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT CategoryId, CategoryName FROM Categories";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable categories = new DataTable();

                connection.Open();
                adapter.Fill(categories);

                cmbCategory.DataSource = categories;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryId";
            }
        }

        private void btnSpendingList_Click(object sender, EventArgs e)
        {
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateSpending_Click(object sender, EventArgs e)
        {
            string title = txtSpendingTitle.Text;
            decimal amount = decimal.Parse(txtSpendingAmount.Text);
            string date = mskSpendingDate.Text;
            string category = cmbCategory.SelectedValue.ToString();

            Spendings spendings = new Spendings();
            spendings.SpendingTitle = title;
            spendings.SpendingAmount = amount;
            spendings.SpendingDate = DateTime.Parse(date);
            spendings.CategoryId = int.Parse(category);
            db.Spendings.Add(spendings);
            db.SaveChanges();
            MessageBox.Show("Successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnDeleteSpending_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendingId.Text);
            var removeValue = db.Spendings.Find(id);
            db.Spendings.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateSpending_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendingId.Text);
            string title = txtSpendingTitle.Text;
            decimal amount = decimal.Parse(txtSpendingAmount.Text);
            string date = mskSpendingDate.Text;
            string category = cmbCategory.SelectedValue.ToString();
            var values2 = db.Spendings.Find(id);
            values2.SpendingTitle = title;
            values2.SpendingAmount = amount;
            values2.SpendingDate = DateTime.Parse(date);
            values2.CategoryId = int.Parse(category);
            db.SaveChanges();
            MessageBox.Show("Successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            this.Hide();
        }

        private void btnBankTransactions_Click(object sender, EventArgs e)
        {
            FrmBankTransactions frm = new FrmBankTransactions();
            frm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
