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
    public partial class FrmDashboard : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        int count = 0;
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString() + " ₺";

            var lastBankProcessAmount = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Amount).FirstOrDefault();
            lblIsBankProcessAmount.Text = lastBankProcessAmount.ToString() + " ₺";

            //chart1 kodlari
            var bankData = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Series1");
            foreach (var item in bankData)
            {
                series.Points.AddXY(item.BankTitle, item.BankBalance);
            }

            //chart2 kodlari
            var billData = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            foreach (var item in billData)
            {
                series2.Points.AddXY(item.BillTitle, item.BillAmount);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count % 7 == 0)
            {
                var billTitle1 = db.Bills.Where(x => x.BillTitle == "Elektrik Faturasi").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Elektrik Faturasi";
                lblBillAmount.Text = billTitle1.ToString() + " ₺";
            }
            if (count % 7 == 1)
            {
                var billTitle2 = db.Bills.Where(x => x.BillTitle == "Dogalgaz Faturasi").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Dogalgaz Faturasi";
                lblBillAmount.Text = billTitle2.ToString() + " ₺";
            }
            if (count % 7 == 2)
            {
                var billTitle3 = db.Bills.Where(x => x.BillTitle == "Su Faturasi").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Su Faturasi";
                lblBillAmount.Text = billTitle3.ToString() + " ₺";
            }
            if (count % 7 == 3)
            {
                var billTitle4 = db.Bills.Where(x => x.BillTitle == "Internet Faturasi").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Internet Faturasi";
                lblBillAmount.Text = billTitle4.ToString() + " ₺";
            }
            if (count % 7 == 4)
            {
                var billTitle5 = db.Bills.Where(x => x.BillTitle == "Telefon Faturasi").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Telefon Faturasi";
                lblBillAmount.Text = billTitle5.ToString() + " ₺";
            }
            if (count % 7 == 5)
            {
                var billTitle6 = db.Bills.Where(x => x.BillTitle == "Netflix Premium").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Netflix Premium";
                lblBillAmount.Text = billTitle6.ToString() + " ₺";
            }
            if (count % 7 == 6)
            {
                var billTitle7 = db.Bills.Where(x => x.BillTitle == "Spotify Premium").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Spotify Premium";
                lblBillAmount.Text = billTitle7.ToString() + " ₺";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmBankTransactions frm = new FrmBankTransactions();
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
