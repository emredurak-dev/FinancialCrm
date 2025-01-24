using FinancialCrm.Models;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBanks : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        public FrmBanks()
        {
            InitializeComponent();
        }

        private void FrmBanks_Load(object sender, System.EventArgs e)
        {
            //banka bakiyeleri
            var ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankasi").Select(y => y.BankBalance).FirstOrDefault();
            var vakifBankBalance = db.Banks.Where(x => x.BankTitle == "Vakif Bank").Select(y => y.BankBalance).FirstOrDefault();
            var isBankBalance = db.Banks.Where(x => x.BankTitle == "Is Bankasi").Select(y => y.BankBalance).FirstOrDefault();

            lblZiraatBankBalance.Text = ziraatBankBalance.ToString() + " ₺";
            lblVakifBankBalance.Text = vakifBankBalance.ToString() + " ₺";
            lblIsBankBalance.Text = isBankBalance.ToString() + " ₺";

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

        private void button3_Click(object sender, System.EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, System.EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, System.EventArgs e)
        {
            FrmBankTransactions frm = new FrmBankTransactions();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, System.EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }
    }
}
