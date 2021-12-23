using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagedList;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RetailConnectPOS.Model;

namespace RetailConnectPOS.Options
{
    public partial class frmSKU : Form
    {
        DBModelContext db = new DBModelContext();
        SqlConnection con = new SqlConnection(@"Data Source = .\SQLEXPRESS;initial catalog = PosLocal; User = sa; Password = 8891911");

        string barcode;
        public frmSKU()
        {
            InitializeComponent();
            fillsku();
        }
        void fillsku()
        {
            SqlCommand cmd = new SqlCommand("select PRDCODE,PRDNAME,REGPRICE,ALTCODE,VATIN from STOCK", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            gridSKU.DataSource = dt;
        }
        private void btnSKUClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSKUClose_Click_1(object sender, EventArgs e)
        {
                this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        { 
           con.Open();
           SqlDataAdapter adapt = new SqlDataAdapter("select PRDCODE,PRDNAME,REGPRICE,ALTCODE,VATIN from STOCK where PRDCODE like '" + txtSearch.Text + "%' OR PRDNAME like '"+txtSearch.Text+ "%' OR ALTCODE like '"+txtSearch.Text+"%' ", con);
           DataTable dt = new DataTable();
           adapt.Fill(dt);
           gridSKU.DataSource = dt;
           con.Close();
        }

        private void gridSKU_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = gridSKU.Rows[index];
            label6.Text = selectedRow.Cells["PRDCODE"].Value.ToString();
            //Dashboard.frmCashier Cashier = new Dashboard.frmCashier("","","","","","",barcode);
                                               
            }
        }
}
