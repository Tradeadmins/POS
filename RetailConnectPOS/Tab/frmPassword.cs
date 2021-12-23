using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailConnectPOS.Tab
{
    public partial class frmPassword : Form
    {
        TextBox txtName;
        public frmPassword()
        {
            InitializeComponent();
        }

        private void frmPassword_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtpassword;
        }

        private void txtpassword_Click(object sender, EventArgs e)
            {
            txtName = txtpassword;
            }

        private void btnKeyboardclose_Click(object sender, EventArgs e)
            {
            this.Close();
            }
        
        private void btn1_Click(object sender, EventArgs e)
            {
            if (txtName != null)
                {
                txtpassword.Text += btn1.Text;
                }
            }

        private void btn2_Click(object sender, EventArgs e)
            {
            if (txtName != null)
                {
                txtpassword.Text += btn2.Text;
                }
            }

        private void btn3_Click(object sender, EventArgs e)
            {
            if (txtName != null)
                {
                txtpassword.Text += btn3.Text;
                }
            }

        private void btn4_Click(object sender, EventArgs e)
            {
            if (txtName != null)
                {
                txtpassword.Text += btn4.Text;
                }
            }

        private void btn5_Click(object sender, EventArgs e)
            {
            if (txtName != null)
                {
                txtpassword.Text += btn5.Text;
                }
            }

        private void btn6_Click(object sender, EventArgs e)
            {
            if (txtName != null)
                {
                txtpassword.Text += btn6.Text;
                }
            }


        private void btn7_Click(object sender, EventArgs e)
            {
            if (txtName != null)
                {
                txtpassword.Text += btn7.Text;
                }
            }

        private void btn8_Click(object sender, EventArgs e)
            {
            if (txtName != null)
                {
                txtpassword.Text += btn8.Text;
                }
            }

        private void btn9_Click(object sender, EventArgs e)
            {
            if (txtName != null)
                {
                txtpassword.Text += btn9.Text;
                }
            }

        private void btn0_Click(object sender, EventArgs e)
            {
            if (txtName != null)
                {
                txtpassword.Text += btn0.Text;
                }
            }

        private void btn00_Click(object sender, EventArgs e)
            {
            if (txtName != null)
                {
                txtpassword.Text += btn00.Text;
                }
            }

        private void btn_Click(object sender, EventArgs e)
            {
            if (txtName != null)
                {
                txtpassword.Text += btn.Text;
                }
            }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
            {
            if (keyData == (Keys.Enter))
                {
                btnEnter.PerformClick();
                }

            return base.ProcessCmdKey(ref msg, keyData);
            }

        private void btnBack_Click(object sender, EventArgs e)
            {
            txtpassword.Text = txtpassword.Text.Substring(0, txtpassword.Text.Length - 1);
            }

        private void btnRefresh_Click(object sender, EventArgs e)
            {
            txtpassword.Text = "";
            }
        }
    }
