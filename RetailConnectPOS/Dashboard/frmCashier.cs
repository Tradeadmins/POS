using RetailConnectPOS.Model;
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

namespace RetailConnectPOS.Dashboard
    {
    /* Author :    Moreheahs Inc, Indore, MP, India.
       Email:      info@moreyeahs.Com
       Advance POS : http://www.moreyeahs.com  
   */

    public partial class frmCashier : Form
        {
        DBModelContext db = new DBModelContext();
        SqlConnection con = new SqlConnection(@"Data Source = .\SQLEXPRESS;initial catalog = PosLocal; User = sa; Password =8891911 ");
        int rowid;
        int invnum;
        string UserName;
        string UserID;       
        string StoreCode;
        string StoreName;
        string Address1;
        string Address2;
        string prcode;


        public frmCashier(string uname, string uid, string scode, string sname, string saddress1, string saddress2)
            {
            InitializeComponent();
            timer1.Start();
            UserName = uname;
            UserID = uid;
            StoreCode = scode;
            StoreName = sname;
            Address1 = saddress1;
            Address2 = saddress2;
            }

        private void timer1_Tick(object sender, EventArgs e)
            {
            DateTime showDateTime = DateTime.Now;
            this.lalbelDateTime.Text = showDateTime.ToString();
            }

        private void frmCashier_Load(object sender, EventArgs e)
            {
            lblUsername.Text = UserName;
            lblStoreName.Text = StoreName;
            lblStoreCode.Text = StoreCode;
            lblAddress1.Text = Address1;
            lblAddress2.Text = Address2;
            string ScreenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
            string ScreenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();
            lblReso.Text = (ScreenWidth + "X" + ScreenHeight);
            fillsku();
            fillitemmaster();
            CalculateItem();
            txtBarcodeReaderBox.Focus();
            }
        void fillitemmaster()
            {
            SqlCommand cmd = new SqlCommand("select * from Sales", con);
            //con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                {
                double cost;
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                    cost = Convert.ToDouble(dt.Rows[i]["QTY"]) * Convert.ToDouble(dt.Rows[i]["PRICE"]);
                    dt.Rows[i]["COST"] = cost;
                    }
                }
            con.Close();
            gridItemMaster.DataSource = dt;
            gridItemMaster.Columns["SeqNo"].Visible = false;
            gridItemMaster.Columns["CREATEDATE"].Visible = false;
            gridItemMaster.Columns["STORECODE"].Visible = false;
            gridItemMaster.Columns["DESCCODE"].Visible = false;
            gridItemMaster.Columns["ORGPRICE"].Visible = false;
            gridItemMaster.Columns["REGPRICE"].Visible = false;
            gridItemMaster.Columns["DISCOUNT"].Visible = false;
            gridItemMaster.Columns["PRKEY"].Visible = false;
            gridItemMaster.Columns["REGPRKEY"].Visible = false;
            gridItemMaster.Columns["PRNO"].Visible = false;
            gridItemMaster.Columns["PRTYPECODE"].Visible = false;
            gridItemMaster.Columns["TPRICE"].Visible = false;
            gridItemMaster.Columns["STYPE"].Visible = false;
            gridItemMaster.Columns["USERID"].Visible = false;
            gridItemMaster.Columns["CUSTOMERCODE"].Visible = false;
            gridItemMaster.Columns["STAFFCODE"].Visible = false;
            gridItemMaster.Columns["COMMISION"].Visible = false;
            gridItemMaster.Columns["REMARK"].Visible = false;
            gridItemMaster.Columns["ALTCODE"].Visible = false;
            gridItemMaster.Columns["PRICECHG"].Visible = false;
            gridItemMaster.Columns["SALPOINT"].Visible = false;
            gridItemMaster.Columns["TNOW"].Visible = false;
            gridItemMaster.Columns["AUTHID"].Visible = false;
            gridItemMaster.Columns["GROUPID"].Visible = false;
            gridItemMaster.Columns["GROUPID2"].Visible = false;
            gridItemMaster.Columns["LINKID"].Visible = false;
            gridItemMaster.Columns["CREDITCARDNAME"].Visible = false;
            gridItemMaster.Columns["VATPRICE"].Visible = false;
            gridItemMaster.Columns["VATIN"].Visible = false;
            gridItemMaster.Columns["PRICELVL"].Visible = false;
            gridItemMaster.Columns["VAT"].Visible = false;
            gridItemMaster.Columns["GSTPRICE"].Visible = false;
            gridItemMaster.Columns["UNITGSTPRICE"].Visible = false;
            gridItemMaster.Columns["GSTDISCOUNT"].Visible = false;
            gridItemMaster.Columns["ITEMDISCGST"].Visible = false;
            gridItemMaster.Columns["GSTAmtR4"].Visible = false;
            gridItemMaster.Columns["PRDNAME2"].Visible = false;
            gridItemMaster.Columns["XYSET"].Visible = false;

            }
        void fillsku()
            {
            SqlCommand cmd = new SqlCommand("select PRDCODE,PRDNAME,REGPRICE,ALTCODE,VATIN from STOCK", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();            
            }
        private void btnAppClose_Click(object sender, EventArgs e)
            {
            if
               (
                   MessageBox.Show
                   (
                       "Quit the Application",
                       "Exit Application Dialog",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning,
                       MessageBoxDefaultButton.Button2 // hit Enter == No !
                   )
                   == DialogResult.Yes
               )
                {
                Application.Exit();
                }
            }




        private void btnSKU_Click(object sender, EventArgs e)
            {
            //panelSKU.Show();
            //panelBottom2.Hide();
            Options.frmSKU SKU = new Options.frmSKU();
            SKU.Show();
            }

        private void btnSKU_MouseEnter(object sender, EventArgs e)
            {
            btnSKU.BackColor = Color.LightSteelBlue;
            btnSKU.ForeColor = Color.White;
            }

        private void btnSKU_MouseLeave(object sender, EventArgs e)
            {
            btnSKU.BackColor = Color.LightSkyBlue;
            btnSKU.ForeColor = Color.Black;
            }
        private void btnSKUClose_Click(object sender, EventArgs e)
            {
            
            }


        private void btnPOSReport_Click(object sender, EventArgs e)
            {
            Options.frmPOSReport POSReport = new Options.frmPOSReport();
            POSReport.Show();
            }

        private void btnPOSReport_MouseEnter(object sender, EventArgs e)
            {
            btnPOSReport.BackColor = Color.LightSteelBlue;
            btnPOSReport.ForeColor = Color.White;
            }

        private void btnPOSReport_MouseLeave(object sender, EventArgs e)
            {
            btnPOSReport.BackColor = Color.LightSkyBlue;
            btnPOSReport.ForeColor = Color.Black;
            }

        private void btnCheckPrice_Click(object sender, EventArgs e)
            {
            Options.frmCheckPrice CheckPrice = new Options.frmCheckPrice();
            CheckPrice.Show();
            }

        private void btnCheckPrice_MouseEnter(object sender, EventArgs e)
            {
            btnCheckPrice.BackColor = Color.LightSteelBlue;
            btnCheckPrice.ForeColor = Color.White;
            }

        private void btnCheckPrice_MouseLeave(object sender, EventArgs e)
            {
            btnCheckPrice.BackColor = Color.LightSkyBlue;
            btnCheckPrice.ForeColor = Color.Black;
            }

        private void btnTotal_Click(object sender, EventArgs e)
            {
            Options.frmSeekResume SeeRkResume = new Options.frmSeekResume();
            SeeRkResume.Show();
            }

        private void btnTotal_MouseEnter(object sender, EventArgs e)
            {
            btnTotal.BackColor = Color.LightSteelBlue;
            btnTotal.ForeColor = Color.White;
            }

        private void btnTotal_MouseLeave(object sender, EventArgs e)
            {
            btnTotal.BackColor = Color.LightSkyBlue;
            btnTotal.ForeColor = Color.Black;
            }

        private void btnOpenDrawer_Click(object sender, EventArgs e)
            {

            }

        private void btnOpenDrawer_MouseEnter(object sender, EventArgs e)
            {
            btnOpenDrawer.BackColor = Color.LightSteelBlue;
            btnOpenDrawer.ForeColor = Color.White;
            }

        private void btnOpenDrawer_MouseLeave(object sender, EventArgs e)
            {
            btnOpenDrawer.BackColor = Color.LightSkyBlue;
            btnOpenDrawer.ForeColor = Color.Black;
            }

        private void btnPWP_Click(object sender, EventArgs e)
            {

            }

        private void btnPWP_MouseEnter(object sender, EventArgs e)
            {
            btnPWP.BackColor = Color.LightSteelBlue;
            btnPWP.ForeColor = Color.White;
            }

        private void btnPWP_MouseLeave(object sender, EventArgs e)
            {
            btnPWP.BackColor = Color.LightSkyBlue;
            btnPWP.ForeColor = Color.Black;
            }

        private void btnCash_Click(object sender, EventArgs e)
            {

            }

        private void btnCash_MouseEnter(object sender, EventArgs e)
            {
            btnCash.BackColor = Color.LightSteelBlue;
            btnCash.ForeColor = Color.White;
            }

        private void btnCash_MouseLeave(object sender, EventArgs e)
            {
            btnCash.BackColor = Color.LightSkyBlue;
            btnCash.ForeColor = Color.Black;
            }

        private void btnChnagePrice_Click(object sender, EventArgs e)
            {

            }

        private void btnChnagePrice_MouseEnter(object sender, EventArgs e)
            {
            btnChnagePrice.BackColor = Color.LightSteelBlue;
            btnChnagePrice.ForeColor = Color.White;
            }

        private void btnChnagePrice_MouseLeave(object sender, EventArgs e)
            {
            btnChnagePrice.BackColor = Color.LightSkyBlue;
            btnChnagePrice.ForeColor = Color.Black;
            }

        private void btnCreditSales_Click(object sender, EventArgs e)
            {
            Options.frmCreditSales CreditSales = new Options.frmCreditSales();
            CreditSales.Show();
            }

        private void btnCreditSales_MouseEnter(object sender, EventArgs e)
            {
            btnCreditSales.BackColor = Color.LightSteelBlue;
            btnCreditSales.ForeColor = Color.White;
            }

        private void btnCreditSales_MouseLeave(object sender, EventArgs e)
            {
            btnCreditSales.BackColor = Color.LightSkyBlue;
            btnCreditSales.ForeColor = Color.Black;
            }

        private void btnReprintInvoice_Click(object sender, EventArgs e)
            {
            Options.frmPrintInvoice ReprintInvoice = new Options.frmPrintInvoice();
            ReprintInvoice.Show();
            }

        private void btnReprintInvoice_MouseEnter(object sender, EventArgs e)
            {
            btnReprintInvoice.BackColor = Color.LightSteelBlue;
            btnReprintInvoice.ForeColor = Color.White;
            }

        private void btnReprintInvoice_MouseLeave(object sender, EventArgs e)
            {
            btnReprintInvoice.BackColor = Color.LightSkyBlue;
            btnReprintInvoice.ForeColor = Color.Black;
            }

        private void btnSalesReturn_Click(object sender, EventArgs e)
            {
            Options.frmSalesReturn SalesReturn = new Options.frmSalesReturn();
            SalesReturn.Show();
            }

        private void btnSalesReturn_MouseEnter(object sender, EventArgs e)
            {
            btnSalesReturn.BackColor = Color.LightSteelBlue;
            btnSalesReturn.ForeColor = Color.White;
            }

        private void btnSalesReturn_MouseLeave(object sender, EventArgs e)
            {
            btnSalesReturn.BackColor = Color.LightSkyBlue;
            btnSalesReturn.ForeColor = Color.Black;
            }

        private void btnCancelItem_Click(object sender, EventArgs e)
            {
            int selectedCount = gridItemMaster.SelectedRows.Count;
            while (selectedCount > 0)
                {
                if (!gridItemMaster.SelectedRows[0].IsNewRow)
                    rowid = gridItemMaster.SelectedRows[0].Index;
                prcode = gridItemMaster.Rows[rowid].Cells["PRDCODE"].Value.ToString();
                SqlCommand cmd = new SqlCommand("Delete SALES Where PRDCODE=@Id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", prcode);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                selectedCount--;
                }
            fillitemmaster();
            CalculateItem();
            txtQuantity.Text = "1";
            }
        void CalculateItem()
            {
            if (gridItemMaster.RowCount > 0)
                {
                double tot = 0;

                for (int i = 0; i <= gridItemMaster.RowCount - 1; i++)
                    {
                    tot += Convert.ToDouble(gridItemMaster.Rows[i].Cells["COST"].Value);
                    }
                lblTotal.Text = tot.ToString();

                int qty = 0;
                for (int x = 0; x < gridItemMaster.Rows.Count; x++)
                    {
                    qty += Convert.ToInt32(gridItemMaster.Rows[x].Cells["QTY"].Value);
                    }
                lblqty.Text = qty.ToString();
                }
            }

        private void btnCancelItem_MouseEnter(object sender, EventArgs e)
            {
            btnCancelItem.BackColor = Color.LightSteelBlue;
            btnCancelItem.ForeColor = Color.White;
            }

        private void btnCancelItem_MouseLeave(object sender, EventArgs e)
            {
            btnCancelItem.BackColor = Color.LightSkyBlue;
            btnCancelItem.ForeColor = Color.Black;
            }

        private void btnSettings_Click(object sender, EventArgs e)
            {
            SettingsDebug.frmSettings Setting = new SettingsDebug.frmSettings();
            Setting.Show();
            }
        private void btnPanelPayShow_Click(object sender, EventArgs e)
            {
            panelPay.Width = 373;
            btnPanelPayHide.Show();
            btnPanelPayShow.Hide();
            }

        private void btnPanelPayHide_Click(object sender, EventArgs e)
            {
            panelPay.Width = 35;
            btnPanelPayHide.Hide();
            btnPanelPayShow.Show();
            }

        private int a = 1;
        private void btnQuanIncrease_Click(object sender, EventArgs e)
            {
            a++;
            txtQuantity.Text = a.ToString();
            }

        private void btnQuantityDecrease_Click(object sender, EventArgs e)
            {
            if (a >= 2)
                {
                a--;
                txtQuantity.Text = a.ToString();
                }
            else
                {
                MessageBox.Show("Quantity Cannot Be Less Than One", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

        public int Finditem(string item)
            {
            int k = -1;
            if (gridItemMaster.Rows.Count > 0)
                {
                foreach (DataGridViewRow row in gridItemMaster.Rows)
                    {
                    if (row.Cells[0].Value != null)
                        {
                        if (row.Cells[0].Value.ToString().Equals(item))
                            {
                            k = row.Index;
                            break;
                            }
                        }
                    }
                }
            return k;
            }

        private void txtBarcodeReaderBox_TextChanged(object sender, EventArgs e)
            {
            //{
            //        try
            //        {
            //            SqlCommand cmd = new SqlCommand("select * from STOCK where PRDCODE= '" + txtBarcodeReaderBox.Text + "' ", con);
            //            con.Open();
            //            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //            DataTable dt = new DataTable();
            //            sda.Fill(dt);
            //            if (dt.Rows.Count > 0)
            //            {
            //                cmd = new SqlCommand("select * from SALES where PRDCODE = @PRDCODE", con);
            //                cmd.Parameters.AddWithValue("@PRDCODE", dt.Rows[0]["PRDCODE"].ToString());
            //                SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
            //                DataTable dt1 = new DataTable();
            //                sda1.Fill(dt1);
            //                SqlDataReader sdr = cmd.ExecuteReader();
            //                if (sdr.Read())
            //                {
            //                    try
            //                    {
            //                        sdr.Close();
            //                        cmd = new SqlCommand("Update SALES set QTY=@QTY Where PRDCODE= '" + dt.Rows[0]["PRDCODE"] + "'", con);
            //                        cmd.CommandType = CommandType.Text;
            //                        cmd.Parameters.AddWithValue("@QTY", Convert.ToInt32(dt1.Rows[0]["QTY"]) + Convert.ToInt32(txtQuantity.Text));
            //                        cmd.ExecuteNonQuery();
            //                        CalculateItem();
            //                    }
            //                    catch (Exception ex)
            //                    {
            //                        MessageBox.Show(ex.Message.ToString());
            //                    }

            //                }
            //                else
            //                {
            //                    try
            //                    {
            //                        sdr.Close();
            //                        cmd = new SqlCommand("insert into SALES(CREATEDATE,STORECODE,PRDCODE,PRDNAME,DESCCODE,QTY,PRICE,COST,ORGPRICE,REGPRICE,DISCOUNT,PRKEY,REGPRKEY,PRNO,PRTYPECODE,TPRICE,STYPE,USERID,CUSTOMERCODE,STAFFCODE,COMMISION,REMARK,ALTCODE,PRICECHG,SALPOINT,TNOW,AUTHID,GROUPID,GROUPID2,LINKID,CREDITCARDNAME,VATPRICE,VATIN,PRICELVL,VAT,GSTPRICE,UNITGSTPRICE,GSTDISCOUNT,ITEMDISCGST,GSTAmtR4,PRDNAME2,XYSET)Values(@CREATEDATE,@STORECODE,@PRDCODE,@PRDNAME,@DESCCODE,@QTY,@PRICE,@COST,@ORGPRICE,@REGPRICE,@DISCOUNT,@PRKEY,@REGPRKEY,@PRNO,@PRTYPECODE,@TPRICE,@STYPE,@USERID,@CUSTOMERCODE,@STAFFCODE,@COMMISION,@REMARK,@ALTCODE,@PRICECHG,@SALPOINT,@TNOW,@AUTHID,@GROUPID,@GROUPID2,@LINKID,@CREDITCARDNAME,@VATPRICE,@VATIN,@PRICELVL,@VAT,@GSTPRICE,@UNITGSTPRICE,@GSTDISCOUNT,@ITEMDISCGST,@GSTAmtR4,@PRDNAME2,@XYSET)", con);
            //                        cmd.CommandType = CommandType.Text;
            //                        cmd.Parameters.AddWithValue("@CREATEDATE", DateTime.Now);
            //                        cmd.Parameters.AddWithValue("@STORECODE", "HQ");
            //                        cmd.Parameters.AddWithValue("@PRDCODE", dt.Rows[0]["PRDCODE"].ToString());
            //                        cmd.Parameters.AddWithValue("@PRDNAME", dt.Rows[0]["PRDNAME"].ToString());
            //                        cmd.Parameters.AddWithValue("@DESCCODE", dt.Rows[0]["DESCCODE"].ToString());
            //                        cmd.Parameters.AddWithValue("@QTY", Convert.ToInt32(txtQuantity.Text));
            //                        cmd.Parameters.AddWithValue("@PRICE", Convert.ToDouble(dt.Rows[0]["PRICE"]));
            //                        cmd.Parameters.AddWithValue("@COST", Convert.ToDouble(dt.Rows[0]["PRICE"]) * Convert.ToDouble(txtQuantity.Text));
            //                        cmd.Parameters.AddWithValue("@ORGPRICE", Convert.ToInt32(dt.Rows[0]["REGPRICE"]));
            //                        cmd.Parameters.AddWithValue("@REGPRICE", Convert.ToInt32(dt.Rows[0]["REGPRICE"]));
            //                        cmd.Parameters.AddWithValue("@DISCOUNT", "");
            //                        cmd.Parameters.AddWithValue("@PRKEY", dt.Rows[0]["PRKEY"].ToString());
            //                        cmd.Parameters.AddWithValue("@REGPRKEY", dt.Rows[0]["REGPRKEY"].ToString());
            //                        cmd.Parameters.AddWithValue("@PRNO", dt.Rows[0]["PRNO"].ToString());
            //                        cmd.Parameters.AddWithValue("@PRTYPECODE", dt.Rows[0]["PRTYPECODE"].ToString());
            //                        cmd.Parameters.AddWithValue("@TPRICE", "");
            //                        cmd.Parameters.AddWithValue("@STYPE", "");
            //                        cmd.Parameters.AddWithValue("@USERID", "");
            //                        cmd.Parameters.AddWithValue("@CUSTOMERCODE", "");
            //                        cmd.Parameters.AddWithValue("@STAFFCODE", "");
            //                        cmd.Parameters.AddWithValue("@COMMISION", "");
            //                        cmd.Parameters.AddWithValue("@REMARK", "");
            //                        cmd.Parameters.AddWithValue("@ALTCODE", dt.Rows[0]["ALTCODE"].ToString());
            //                        cmd.Parameters.AddWithValue("@PRICECHG", "");
            //                        cmd.Parameters.AddWithValue("@SALPOINT", "");
            //                        cmd.Parameters.AddWithValue("@TNOW", "");
            //                        cmd.Parameters.AddWithValue("@AUTHID", "");
            //                        cmd.Parameters.AddWithValue("@GROUPID", "");
            //                        cmd.Parameters.AddWithValue("@GROUPID2", "");
            //                        cmd.Parameters.AddWithValue("@LINKID", "");
            //                        cmd.Parameters.AddWithValue("@CREDITCARDNAME", "");
            //                        cmd.Parameters.AddWithValue("@VATPRICE", Convert.ToInt32(dt.Rows[0]["VATPRICE"]));
            //                        cmd.Parameters.AddWithValue("@VATIN", dt.Rows[0]["VATIN"].ToString());
            //                        cmd.Parameters.AddWithValue("@PRICELVL", "");
            //                        cmd.Parameters.AddWithValue("@VAT", Convert.ToInt32(dt.Rows[0]["VAT"]));
            //                        cmd.Parameters.AddWithValue("@GSTPRICE", "");
            //                        cmd.Parameters.AddWithValue("@UNITGSTPRICE", Convert.ToInt32(dt.Rows[0]["REGPRICE"]));
            //                        cmd.Parameters.AddWithValue("@GSTDISCOUNT", "");
            //                        cmd.Parameters.AddWithValue("@ITEMDISCGST", "");
            //                        cmd.Parameters.AddWithValue("@GSTAmtR4", "");
            //                        cmd.Parameters.AddWithValue("@PRDNAME2", dt.Rows[0]["PRDNAME2"].ToString());
            //                        cmd.Parameters.AddWithValue("@XYSET", "");
            //                        cmd.ExecuteNonQuery();
            //                    }
            //                    catch (Exception ex)
            //                    {
            //                        MessageBox.Show(ex.Message.ToString());
            //                    }

            //                }
            //            }
            //            else
            //            {
            //                //MessageBox.Show("Hi");
            //            }
            //            fillitemmaster();
            //            CalculateItem();
            //            con.Close();
            //            //txtBarcodeReaderBox.Text = "";
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message.ToString());
            //        }
            //}
            }

        private void gridSKU_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            int index = e.RowIndex;// get the Row Index
            
            
            
            panelBottom2.Show();
            }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
            {
            if (keyData == (Keys.Escape))
                {
                btnAppClose.PerformClick(); //Closes the Applicat
                }
            //}
            else if (keyData == (Keys.F5))
                {

                }
            else if (keyData == (Keys.Shift | Keys.Up))
                {
                btnQuanIncrease.PerformClick(); //Increase Quantity Value 
                }
            else if (keyData == (Keys.Shift | Keys.Down))
                {
                btnQuantityDecrease.PerformClick(); //Increase Quantity Value 
                }

            return base.ProcessCmdKey(ref msg, keyData);
            }

        private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }

        private void txtBarcodeReaderBox_KeyPress(object sender, KeyPressEventArgs e)
            {
            if (e.KeyChar == (char)Keys.Enter && txtBarcodeReaderBox.Text == "" && gridItemMaster.Rows.Count > 1) // return
                {
                e.Handled = true;
                MessageBox.Show("Do You Want To Proced For Payment???");

                txtBarcodeReaderBox.Text = "";
                }
            if (e.KeyChar == (char)Keys.Enter && txtBarcodeReaderBox.Text != "") // return
                {
                try
                    {
                    SqlCommand cmd = new SqlCommand("select * from STOCK where PRDCODE= '" + txtBarcodeReaderBox.Text + "' ", con);
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                        {
                        cmd = new SqlCommand("select * from SALES where PRDCODE = @PRDCODE", con);
                        cmd.Parameters.AddWithValue("@PRDCODE", dt.Rows[0]["PRDCODE"].ToString());
                        SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
                        DataTable dt1 = new DataTable();
                        sda1.Fill(dt1);
                        SqlDataReader sdr = cmd.ExecuteReader();
                        if (sdr.Read())
                            {
                            try
                                {
                                sdr.Close();
                                cmd = new SqlCommand("Update SALES set QTY=@QTY Where PRDCODE= '" + dt.Rows[0]["PRDCODE"] + "'", con);
                                cmd.CommandType = CommandType.Text;
                                cmd.Parameters.AddWithValue("@QTY", Convert.ToInt32(dt1.Rows[0]["QTY"]) + Convert.ToInt32(txtQuantity.Text));
                                cmd.ExecuteNonQuery();
                                CalculateItem();
                                txtBarcodeReaderBox.Text = "";
                                }
                            catch (Exception ex)
                                {
                                MessageBox.Show(ex.Message.ToString());
                                }

                            }
                        else
                            {
                            try
                                {
                                sdr.Close();
                                cmd = new SqlCommand("insert into SALES(CREATEDATE,STORECODE,PRDCODE,PRDNAME,DESCCODE,QTY,PRICE,COST,ORGPRICE,REGPRICE,DISCOUNT,PRKEY,REGPRKEY,PRNO,PRTYPECODE,TPRICE,STYPE,USERID,CUSTOMERCODE,STAFFCODE,COMMISION,REMARK,ALTCODE,PRICECHG,SALPOINT,TNOW,AUTHID,GROUPID,GROUPID2,LINKID,CREDITCARDNAME,VATPRICE,VATIN,PRICELVL,VAT,GSTPRICE,UNITGSTPRICE,GSTDISCOUNT,ITEMDISCGST,GSTAmtR4,PRDNAME2,XYSET)Values(@CREATEDATE,@STORECODE,@PRDCODE,@PRDNAME,@DESCCODE,@QTY,@PRICE,@COST,@ORGPRICE,@REGPRICE,@DISCOUNT,@PRKEY,@REGPRKEY,@PRNO,@PRTYPECODE,@TPRICE,@STYPE,@USERID,@CUSTOMERCODE,@STAFFCODE,@COMMISION,@REMARK,@ALTCODE,@PRICECHG,@SALPOINT,@TNOW,@AUTHID,@GROUPID,@GROUPID2,@LINKID,@CREDITCARDNAME,@VATPRICE,@VATIN,@PRICELVL,@VAT,@GSTPRICE,@UNITGSTPRICE,@GSTDISCOUNT,@ITEMDISCGST,@GSTAmtR4,@PRDNAME2,@XYSET)", con);
                                cmd.CommandType = CommandType.Text;
                                cmd.Parameters.AddWithValue("@CREATEDATE", DateTime.Now);
                                cmd.Parameters.AddWithValue("@STORECODE", "HQ");
                                cmd.Parameters.AddWithValue("@PRDCODE", dt.Rows[0]["PRDCODE"].ToString());
                                cmd.Parameters.AddWithValue("@PRDNAME", dt.Rows[0]["PRDNAME"].ToString());
                                cmd.Parameters.AddWithValue("@DESCCODE", dt.Rows[0]["DESCCODE"].ToString());
                                cmd.Parameters.AddWithValue("@QTY", Convert.ToInt32(txtQuantity.Text));
                                cmd.Parameters.AddWithValue("@PRICE", Convert.ToDouble(dt.Rows[0]["PRICE"]));
                                cmd.Parameters.AddWithValue("@COST", Convert.ToDouble(dt.Rows[0]["PRICE"]) * Convert.ToDouble(txtQuantity.Text));
                                cmd.Parameters.AddWithValue("@ORGPRICE", Convert.ToInt32(dt.Rows[0]["REGPRICE"]));
                                cmd.Parameters.AddWithValue("@REGPRICE", Convert.ToInt32(dt.Rows[0]["REGPRICE"]));
                                cmd.Parameters.AddWithValue("@DISCOUNT", "");
                                cmd.Parameters.AddWithValue("@PRKEY", dt.Rows[0]["PRKEY"].ToString());
                                cmd.Parameters.AddWithValue("@REGPRKEY", dt.Rows[0]["REGPRKEY"].ToString());
                                cmd.Parameters.AddWithValue("@PRNO", dt.Rows[0]["PRNO"].ToString());
                                cmd.Parameters.AddWithValue("@PRTYPECODE", dt.Rows[0]["PRTYPECODE"].ToString());
                                cmd.Parameters.AddWithValue("@TPRICE", "");
                                cmd.Parameters.AddWithValue("@STYPE", "");
                                cmd.Parameters.AddWithValue("@USERID", "");
                                cmd.Parameters.AddWithValue("@CUSTOMERCODE", "");
                                cmd.Parameters.AddWithValue("@STAFFCODE", "");
                                cmd.Parameters.AddWithValue("@COMMISION", "");
                                cmd.Parameters.AddWithValue("@REMARK", "");
                                cmd.Parameters.AddWithValue("@ALTCODE", dt.Rows[0]["ALTCODE"].ToString());
                                cmd.Parameters.AddWithValue("@PRICECHG", "");
                                cmd.Parameters.AddWithValue("@SALPOINT", "");
                                cmd.Parameters.AddWithValue("@TNOW", "");
                                cmd.Parameters.AddWithValue("@AUTHID", "");
                                cmd.Parameters.AddWithValue("@GROUPID", "");
                                cmd.Parameters.AddWithValue("@GROUPID2", "");
                                cmd.Parameters.AddWithValue("@LINKID", "");
                                cmd.Parameters.AddWithValue("@CREDITCARDNAME", "");
                                cmd.Parameters.AddWithValue("@VATPRICE", Convert.ToInt32(dt.Rows[0]["VATPRICE"]));
                                cmd.Parameters.AddWithValue("@VATIN", dt.Rows[0]["VATIN"].ToString());
                                cmd.Parameters.AddWithValue("@PRICELVL", "");
                                cmd.Parameters.AddWithValue("@VAT", Convert.ToInt32(dt.Rows[0]["VAT"]));
                                cmd.Parameters.AddWithValue("@GSTPRICE", "");
                                cmd.Parameters.AddWithValue("@UNITGSTPRICE", Convert.ToInt32(dt.Rows[0]["REGPRICE"]));
                                cmd.Parameters.AddWithValue("@GSTDISCOUNT", "");
                                cmd.Parameters.AddWithValue("@ITEMDISCGST", "");
                                cmd.Parameters.AddWithValue("@GSTAmtR4", "");
                                cmd.Parameters.AddWithValue("@PRDNAME2", dt.Rows[0]["PRDNAME2"].ToString());
                                cmd.Parameters.AddWithValue("@XYSET", "");
                                cmd.ExecuteNonQuery();
                                txtBarcodeReaderBox.Text = "";
                                }
                            catch (Exception ex)
                                {
                                MessageBox.Show(ex.Message.ToString());
                                }
                            }
                        }
                    else
                        {
                        MessageBox.Show("Sorry!!!Product Code Does Not Exit!!!");
                        }
                    fillitemmaster();
                    CalculateItem();
                    con.Close();
                    //txtBarcodeReaderBox.Text = "";                    
                    }
                catch (Exception ex)
                    {
                    MessageBox.Show(ex.Message.ToString());
                    }
                }
            }

        private void btnPay_MouseEnter(object sender, EventArgs e)
            {
            btnPay.BackColor = Color.LightSteelBlue;
            btnPay.ForeColor = Color.White;
            }

        private void btnPay_MouseLeave(object sender, EventArgs e)
            {
            btnPay.BackColor = Color.LightSkyBlue;
            btnPay.ForeColor = Color.Black;
            }

        private void btnPay_Click(object sender, EventArgs e)
            {
            if (lblTotal.Text == "0" || lblTotal.Text == "0.00")
                {
                MessageBox.Show("Sorry ! You don't have enough product in Item cart \n  Please Add to cart", "Yes or No", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                }
            else if (gridItemMaster.Rows.Count <= 0)
                {
                MessageBox.Show("Sorry ! You don't have enough product in Item cart \n  Please Add to cart", "Yes or No", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                }
            else
                {
                try
                    {
                    SqlCommand cmd = new SqlCommand("select * from SALES", con);
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                        {
                        cmd = new SqlCommand("SELECT MAX(INVNUM) as INVNUM FROM TSALES", con);
                        SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
                        DataTable dt1 = new DataTable();
                        sda1.Fill(dt1);
                        invnum = Convert.ToInt32(dt1.Rows[0]["INVNUM"]) + 1;
                        for (int i = 0; i <= dt.Rows.Count - 1; i++)
                            {
                            cmd = new SqlCommand("insert into TSALES(CREATEDATE,STORECODE,PRDCODE,PRDNAME,QTY,COST,ORGPRICE,PRICE,REGPRICE,DISCOUNT,PRKEY,REGPRKEY,PRNO,PRTYPECODE,TPRICE,STYPE,INVNUM,USERID,CUSTOMERCODE,COUNTERCODE,STAFFCODE,COMMISION,POSTED,POSTDATE,DOWNLOADDATE3,BANKPAY,REMARK,PAYMENTDATE,ALTCODE,RIREASON,PRICECHG,SALPOINT,TNOW,DOWNLOADDATE1,DOWNLOADDATE2,DOWNLOADDATE4,UPLOADDATE1,UPLOADDATE2,POSAUDIT_NO,PH1CODE,RACE,MPPOSTED,AuthID,HISTORY_COST,SUPPLIER_COST,SUPP_CLAIM,ORG_COST,REMARK2,CCODE,CCFRACTION,SHIFT,SHIFT_ID,VATIN,VATPRICE,PRICELVL,GSTPRICE)Values(@CREATEDATE,@STORECODE,@PRDCODE,@PRDNAME,@QTY,@COST,@ORGPRICE,@PRICE,@REGPRICE,@DISCOUNT,@PRKEY,@REGPRKEY,@PRNO,@PRTYPECODE,@TPRICE,@STYPE,@INVNUM,@USERID,@CUSTOMERCODE,@COUNTERCODE,@STAFFCODE,@COMMISION,@POSTED,@POSTDATE,@DOWNLOADDATE3,@BANKPAY,@REMARK,@PAYMENTDATE,@ALTCODE,@RIREASON,@PRICECHG,@SALPOINT,@TNOW,@DOWNLOADDATE1,@DOWNLOADDATE2,@DOWNLOADDATE4,@UPLOADDATE1,@UPLOADDATE2,@POSAUDIT_NO,@PH1CODE,@RACE,@MPPOSTED,@AuthID,@HISTORY_COST,@SUPPLIER_COST,@SUPP_CLAIM,@ORG_COST,@REMARK2,@CCODE,@CCFRACTION,@SHIFT,@SHIFT_ID,@VATIN,@VATPRICE,@PRICELVL,@GSTPRICE)", con);
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@CREATEDATE", DateTime.Now);
                            cmd.Parameters.AddWithValue("@STORECODE", "HQ");
                            cmd.Parameters.AddWithValue("@PRDCODE", dt.Rows[i]["PRDCODE"].ToString());
                            cmd.Parameters.AddWithValue("@PRDNAME", dt.Rows[i]["PRDNAME"].ToString());
                            cmd.Parameters.AddWithValue("@QTY", Convert.ToDouble(dt.Rows[i]["QTY"]));
                            cmd.Parameters.AddWithValue("@COST", Convert.ToDouble(dt.Rows[i]["COST"]));
                            cmd.Parameters.AddWithValue("@ORGPRICE", Convert.ToDouble(dt.Rows[i]["ORGPRICE"]));
                            cmd.Parameters.AddWithValue("@PRICE", Convert.ToDouble(dt.Rows[i]["PRICE"]));
                            cmd.Parameters.AddWithValue("@REGPRICE", Convert.ToDouble(dt.Rows[i]["REGPRICE"]));
                            cmd.Parameters.AddWithValue("@DISCOUNT", "");
                            cmd.Parameters.AddWithValue("@PRKEY", dt.Rows[i]["PRKEY"].ToString());
                            cmd.Parameters.AddWithValue("@REGPRKEY", dt.Rows[i]["REGPRKEY"].ToString());
                            cmd.Parameters.AddWithValue("@PRNO", dt.Rows[i]["PRNO"].ToString());
                            cmd.Parameters.AddWithValue("@PRTYPECODE", dt.Rows[i]["PRTYPECODE"].ToString());
                            cmd.Parameters.AddWithValue("@TPRICE", Convert.ToDouble(dt.Rows[i]["TPRICE"]));
                            cmd.Parameters.AddWithValue("@STYPE", dt.Rows[i]["STYPE"].ToString());
                            cmd.Parameters.AddWithValue("@INVNUM", invnum);
                            cmd.Parameters.AddWithValue("@USERID", dt.Rows[i]["USERID"].ToString());
                            cmd.Parameters.AddWithValue("@CUSTOMERCODE", dt.Rows[i]["CUSTOMERCODE"].ToString());
                            cmd.Parameters.AddWithValue("@COUNTERCODE", "");
                            cmd.Parameters.AddWithValue("@STAFFCODE", dt.Rows[i]["STAFFCODE"].ToString());
                            cmd.Parameters.AddWithValue("@COMMISION", Convert.ToDouble(dt.Rows[i]["COMMISION"]));
                            cmd.Parameters.AddWithValue("@POSTED", "1");
                            cmd.Parameters.AddWithValue("@POSTDATE", DateTime.Now);
                            cmd.Parameters.AddWithValue("@DOWNLOADDATE3", "");
                            cmd.Parameters.AddWithValue("@BANKPAY", "");
                            cmd.Parameters.AddWithValue("@REMARK", dt.Rows[i]["REMARK"].ToString());
                            cmd.Parameters.AddWithValue("@PAYMENTDATE", "");
                            cmd.Parameters.AddWithValue("@ALTCODE", dt.Rows[i]["ALTCODE"].ToString());
                            cmd.Parameters.AddWithValue("@RIREASON", "");
                            cmd.Parameters.AddWithValue("@PRICECHG", Convert.ToDouble(dt.Rows[i]["PRICECHG"]));
                            cmd.Parameters.AddWithValue("@SALPOINT", Convert.ToDouble(dt.Rows[i]["SALPOINT"]));
                            cmd.Parameters.AddWithValue("@TNOW", DateTime.Now);
                            cmd.Parameters.AddWithValue("@DOWNLOADDATE1", "");
                            cmd.Parameters.AddWithValue("@DOWNLOADDATE2", "");
                            cmd.Parameters.AddWithValue("@DOWNLOADDATE4", "");
                            cmd.Parameters.AddWithValue("@UPLOADDATE1", "");
                            cmd.Parameters.AddWithValue("@UPLOADDATE2", "");
                            cmd.Parameters.AddWithValue("@POSAUDIT_NO", "");
                            cmd.Parameters.AddWithValue("@PH1CODE", "");
                            cmd.Parameters.AddWithValue("@RACE", "");
                            cmd.Parameters.AddWithValue("@MPPOSTED", "");
                            cmd.Parameters.AddWithValue("@AuthID", dt.Rows[i]["AuthID"].ToString());
                            cmd.Parameters.AddWithValue("@HISTORY_COST", "");
                            cmd.Parameters.AddWithValue("@SUPPLIER_COST", "");
                            cmd.Parameters.AddWithValue("@SUPP_CLAIM", "");
                            cmd.Parameters.AddWithValue("@ORG_COST", "");
                            cmd.Parameters.AddWithValue("@REMARK2", "");
                            cmd.Parameters.AddWithValue("@CCODE", "");
                            cmd.Parameters.AddWithValue("@CCFRACTION", "");
                            cmd.Parameters.AddWithValue("@SHIFT", "");
                            cmd.Parameters.AddWithValue("@SHIFT_ID", "");
                            cmd.Parameters.AddWithValue("@VATIN", dt.Rows[i]["VATIN"].ToString());
                            cmd.Parameters.AddWithValue("@VATPRICE", Convert.ToDouble(dt.Rows[i]["VATPRICE"]));
                            cmd.Parameters.AddWithValue("@PRICELVL", "");
                            cmd.Parameters.AddWithValue("@GSTPRICE", Convert.ToDouble(dt.Rows[i]["GSTPRICE"]));
                            cmd.ExecuteNonQuery();
                            }
                        cmd = new SqlCommand("Truncate Table SALES", con);
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        fillitemmaster();
                        CalculateItem();
                        txtBarcodeReaderBox.Text = "";

                        }
                    }
                catch (Exception ex)
                    {
                    MessageBox.Show(ex.Message.ToString());
                    }

                }
            Options.frmPay Pay = new Options.frmPay(invnum);
            Pay.Show();

            }

        private void btnCancelOrder_Click(object sender, EventArgs e)
            {
            SqlCommand cmd = new SqlCommand("Truncate Table SALES", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            lblqty.Text = "0";
            lblTotal.Text = "0.00";
            txtBarcodeReaderBox.Text = "";
            a = 1;
            txtQuantity.Text = a.ToString();
            fillitemmaster();
            CalculateItem();

            }

        private void btnCancelOrder_MouseEnter(object sender, EventArgs e)
            {
            btnCancelOrder.BackColor = Color.LightSteelBlue;
            btnCancelOrder.ForeColor = Color.White;
            }

        private void btnCancelOrder_MouseLeave(object sender, EventArgs e)
            {
            btnCancelOrder.BackColor = Color.LightSkyBlue;
            btnCancelOrder.ForeColor = Color.Black;
            }
        }
    }

        

        

