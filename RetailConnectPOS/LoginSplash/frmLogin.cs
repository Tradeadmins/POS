using RetailConnectPOS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailConnectPOS.LoginSplash
    {
    public partial class frmLogin : Form
        {
        DBModelContext db = new DBModelContext();
        TextBox txtName;

        public frmLogin()
            {          
            InitializeComponent();
            panelKeypad.Hide();
            }

        private void frmLogin_Load(object sender, EventArgs e)
            {
            var List1 = (from u in db.STOREs
                         where u.PRIMARY == 1
                         select u).SingleOrDefault();
            if (List1 != null)
                {
                lblStoreCode.Text = List1.STORECODE;
                lblStoreName.Text = List1.STORENAME;
                lblAddress1.Text = List1.ADDRESS1;
                lblAddress2.Text = List1.ADDRESS2;
                
                }
            txtName = txtPassword;
            timer1.Start();
            }

        private void btnLogin_Click(object sender, EventArgs e)
            {
            panelKeypad.Show();
            pictureBox3.Hide();
            }

        private void btnSetup_Click(object sender, EventArgs e)
            {
            SettingsDebug.frmSettings Settings = new SettingsDebug.frmSettings();
            Settings.Show();
            }

        private void btn1_Click(object sender, EventArgs e)
            {
            if (txtName != null)
                {
                txtPassword.Text += btn1.Text;
                }
            }

        private void btn2_Click(object sender, EventArgs e)
            {
            if (txtName != null)
                {
                txtPassword.Text += btn2.Text;
                }
            }

        private void btn3_Click(object sender, EventArgs e)
            {
            if (txtName != null)
                {
                txtPassword.Text += btn3.Text;
                }
            }

        private void btn4_Click(object sender, EventArgs e)
            {
            if (txtName != null)
                {
                txtPassword.Text += btn4.Text;
                }
            }

        private void btn5_Click(object sender, EventArgs e)
            {
            if (txtName != null)
                {
                txtPassword.Text += btn5.Text;
                }
            }

        private void btn6_Click(object sender, EventArgs e)
            {
            if (txtName != null)
                {
                txtPassword.Text += btn6.Text;
                }
            }

        private void btn7_Click(object sender, EventArgs e)
            {
            if (txtName != null)
                {
                txtPassword.Text += btn7.Text;
                }
            }

        private void btn8_Click(object sender, EventArgs e)
            {
            if (txtName != null)
                {
                txtPassword.Text += btn8.Text;
                }
            }

        private void btn9_Click(object sender, EventArgs e)
            {
            if (txtName != null)
                {
                txtPassword.Text += btn9.Text;
                }
            }

        private void btn0_Click(object sender, EventArgs e)
            {
            if (txtName != null)
                {
                txtPassword.Text += btn0.Text;
                }
            }

        private void btn00_Click(object sender, EventArgs e)
            {
            if (txtName != null)
                {
                txtPassword.Text += btn00.Text;
                }
            }

        private void btn_Click(object sender, EventArgs e)
            {
            if (txtName != null)
                {
                txtPassword.Text += btn.Text;
                }
            }

        private void btnBack_Click(object sender, EventArgs e)
            {
            txtPassword.Text = txtPassword.Text.Substring(0, txtPassword.Text.Length - 1);
            }

        private void btnRefresh_Click(object sender, EventArgs e)
            {
            txtPassword.Text = "";
            }

        private void btnEnter_Click(object sender, EventArgs e)
            {
            try
                {
                if (txtPassword.Text == "")
                    {
                    MessageBox.Show("Password Cannot Be Blank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPassword.Focus();
                    }
                else
                    {
                    var List1 = (from u in db.STOREs
                                 where u.PRIMARY == 1
                                 select u).SingleOrDefault();
                    var List = (from u in db.PUSERs
                                where u.UserPassword == txtPassword.Text
                                select u).SingleOrDefault();
                    if (List != null)
                        {
                        lblUserID.Text = List.UserID;
                        lblUser.Text = List.UserName;
                        lblStoreCode.Text = List1.STORECODE;
                        lblStoreName.Text = List1.STORENAME;
                        lblAddress1.Text = List1.ADDRESS1;
                        lblAddress2.Text = List1.ADDRESS2;
                        MessageBox.Show("User Verfied! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Dashboard.frmCashier Cashier = new Dashboard.frmCashier(lblUser.Text, lblUserID.Text, lblStoreCode.Text, lblStoreName.Text, lblAddress1.Text, lblAddress2.Text);
                        Cashier.Show();
                        }
                    else
                        {
                        MessageBox.Show("Wrong Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPassword.Text = "";
                        txtPassword.Focus();
                        }
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
                };
            }

        private void timer1_Tick(object sender, EventArgs e)
            {
            lalbelDateTime.Text = DateTime.Now.ToString("hh:mm:ss");
            }

        private void btnKeyboardclose_Click(object sender, EventArgs e)
            {
            panelKeypad.Hide();
            pictureBox3.Show();
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
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
            {
            if (keyData == (Keys.Escape))
                {
                btnAppClose.PerformClick();
                }
            return base.ProcessCmdKey(ref msg, keyData);
            }
        }
    }



