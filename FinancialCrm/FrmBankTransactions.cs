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

    public partial class FrmBankTransactions : Form
    {
        public FrmBankTransactions()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void btnBankTransactions_Click(object sender, EventArgs e)
        {
            FrmBankTransactions frm = new FrmBankTransactions();
            frm.Show();
            this.Hide();
        }

        private void FrmBankTransactions_Load(object sender, EventArgs e)
        {
            //banka hareketleri
            var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess1.Description + "  " + bankProcess1.Amount + "₺" + "  " + bankProcess1.ProcessDate.ToString();

            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + "  " + bankProcess2.Amount + "₺" + "  " + bankProcess2.ProcessDate.ToString();

            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + "  " + bankProcess3.Amount + "₺" + "  " + bankProcess3.ProcessDate.ToString();

            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + "  " + bankProcess4.Amount + "₺" + "  " + bankProcess4.ProcessDate.ToString();

            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description + "  " + bankProcess5.Amount + "₺" + "  " + bankProcess5.ProcessDate.ToString();

            var bankProcess6 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(6).Skip(5).FirstOrDefault();
            lblBankProcess6.Text = bankProcess6.Description + "  " + bankProcess6.Amount + "₺" + "  " + bankProcess6.ProcessDate.ToString();

            var bankProcess7 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(7).Skip(6).FirstOrDefault();
            lblBankProcess7.Text = bankProcess7.Description + "  " + bankProcess7.Amount + "₺" + "  " + bankProcess7.ProcessDate.ToString();

            var bankProcess8 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(8).Skip(7).FirstOrDefault();
            lblBankProcess8.Text = bankProcess8.Description + "  " + bankProcess8.Amount + "₺" + "  " + bankProcess8.ProcessDate.ToString();
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }
    }
}
