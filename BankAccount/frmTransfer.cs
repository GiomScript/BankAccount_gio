using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccount
{
    public partial class frmTransfer : Form
    {
        private Accounts allAccounts = null;
         public frmTransfer()
        {
            InitializeComponent();

        }

        public Accounts TransferFunds(Accounts accounts)
        {
            allAccounts = accounts;
            ShowDialog();
            return allAccounts;
        }
        
        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (!IsValiddata())
                return;

            lblMessage.Text = "";
            decimal Amount = Convert.ToDecimal(txtAmount.Text);

            if (cboSelectAccountFrom.SelectedIndex==1)
            {
                if (allAccounts.Savingsaccountbalance < Amount)
                {
                    lblMessage.Text = "Insufficient Funds";
                    return;
                }
                allAccounts.Savingsaccountbalance=allAccounts.Savingsaccountbalance- Amount;
                allAccounts.Checkingaccountbalance = allAccounts.Checkingaccountbalance + Amount;

                lblSavingsAccountbalance.Text =allAccounts.Savingsaccountbalance.ToString();
                lblCheckingAccountbalance.Text = allAccounts.Checkingaccountbalance.ToString();
            }

            if (cboSelectAccountFrom.SelectedIndex==0)
            {
                if (allAccounts.Checkingaccountbalance < Amount)
                {
                    lblMessage.Text = "Insufficient funds";
                    return;
                }
                allAccounts.Checkingaccountbalance =allAccounts.Checkingaccountbalance- Amount;
                allAccounts.Savingsaccountbalance=allAccounts.Savingsaccountbalance+ Amount;
                lblCheckingAccountbalance.Text = allAccounts.Checkingaccountbalance.ToString();
                lblSavingsAccountbalance.Text = allAccounts.Savingsaccountbalance.ToString();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblCheckingAccountbalance.Text = "";
            lblSavingsAccountbalance.Text = "";
            txtAmount.Text = "";
            lblMessage.Text = "";
            cboSelectAccountFrom.Items.Clear();
            cboSelectAccountTo.Items.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool IsValiddata()
        {
            if (!Staticvalidator.ISelected(cboSelectAccountFrom.SelectedIndex))
            {
                lblMessage.Text = "Select account type";
                return false;
            }

            if (!Staticvalidator.ISelected(cboSelectAccountTo.SelectedIndex))
            {
                lblMessage.Text = "Select account type to";
                return false;
            }

            if (cboSelectAccountFrom.SelectedItem == cboSelectAccountTo.SelectedItem)
            {
                lblMessage.Text = "same account selected";
                return false;
            }

            if (!Staticvalidator.IsDecimal(txtAmount.Text))
            {
                lblMessage.Text = "Enter Numeric value";
                return false;
            }
            return true;
        }

        private void frmTransfer_Load(object sender, EventArgs e)
        {
            lblSavingsAccountbalance.Text = allAccounts.Savingsaccountbalance.ToString();
            lblCheckingAccountbalance.Text = allAccounts.Checkingaccountbalance.ToString();
        }
    } 
    
}
