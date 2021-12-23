using CrystalDecisions.CrystalReports.Engine;
using RetailConnectPOS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailConnectPOS.Options
{
    public partial class frmPay : Form
    {
        ReportDocument cryRpt = new ReportDocument();
        int RecptNo;
        public frmPay(int InvNum)
        {
            InitializeComponent();
            RecptNo = InvNum;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            //ReportDocument cryRpt = new ReportDocument();
            //cryRpt.Load(@"C:\Users\User\Desktop\RetailConnectPOS\RetailConnectPOS\CrystalReport1.rpt");
            //crystalReportViewer1.ReportSource = cryRpt;
            //crystalReportViewer1.Refresh();
        }

        private void Pay_Load(object sender, EventArgs e)
        {
            

            }

        private void btnPay_Click(object sender, EventArgs e)
            {
            SqlConnection cnn;
            string connectionString = null;
            string sql = null;

            connectionString = @"Data Source = .\SQLEXPRESS;initial catalog = PosLocal; User = sa; Password = 8891911";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            sql = "SELECT * FROM TSALES WHERE INVNUM='" + RecptNo + "'";
            SqlDataAdapter dscmd = new SqlDataAdapter(sql, cnn);
            RetailConnectDS ds = new RetailConnectDS();
            dscmd.Fill(ds, "TSALES");
            //MessageBox.Show(ds.Tables["TSALES"].Rows.Count.ToString());
            cnn.Close();
            //InvoiceReciept.InvoiceReciept objRpt = new InvoiceReciept.InvoiceReciept();
            cryRpt.Load(@"C:\InvoiceReciept\InvoiceReciept.rpt");
            cryRpt.SetDataSource(ds);            
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
            }

        private void btnPayClose_Click(object sender, EventArgs e)
            {
            this.Close();
            }
        }
}
