using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccount
{
    public partial class frmBankAccount : Form
    {
        public frmBankAccount()
        {
            InitializeComponent();
        }

        decimal checkingaccountbalance = 0m;
        decimal savingsaccountbalance = 0m;
        decimal allaccountbalance = 0m;
        
        private void btnProcess_Click(object sender, EventArgs e)
        { 
            if (!IsValiddata())
                return;
             lblMessage.Text = "";

            decimal transactionamount = Convert.ToDecimal(txtTransactionAmount.Text);


            if (cboAccountType.SelectedIndex == 0)     //  Checking
            {
                if (cboTransactionType.SelectedIndex == 0)  // Deposit
                {
                    checkingaccountbalance += transactionamount;
                    lblCheckingAccountBalance.Text = checkingaccountbalance.ToString("c");
                    txtTransactionAmount.Text = "";
                    allaccountbalance = checkingaccountbalance + savingsaccountbalance;
                    lblAllAccountsBalance.Text = allaccountbalance.ToString("c");

                }
                if (cboTransactionType.SelectedIndex == 1)  // Withdrawal from checking
                {
                    if (transactionamount > checkingaccountbalance)
                    {
                        lblMessage.Text = "Insufficient balance";
                        return;
                    }

                    checkingaccountbalance -= transactionamount;
                    lblCheckingAccountBalance.Text = checkingaccountbalance.ToString("c");
                    txtTransactionAmount.Text = "";
                    allaccountbalance = checkingaccountbalance + savingsaccountbalance;
                    lblAllAccountsBalance.Text = allaccountbalance.ToString("c");
                }

                if (cboTransactionType.SelectedIndex == 2)  // transfer from checking to savings
                {  

                    if (transactionamount > checkingaccountbalance)
                    {
                        lblMessage.Text = "Insufficient balance";
                        return;
                    }
                    
                    var accounts = new Accounts();
                    var frmTransfer = new frmTransfer();
                     accounts.Checkingaccountbalance = checkingaccountbalance;
                    accounts.Savingsaccountbalance = savingsaccountbalance;
                    accounts = frmTransfer.TransferFunds(accounts);
                    
                }

            }
            
            if (cboAccountType.SelectedIndex == 1)  // savings account
            {
                if (cboTransactionType.SelectedIndex == 0) // deposit on savings
                {
                    savingsaccountbalance += transactionamount;
                    lblSavingsAccountBalance.Text = savingsaccountbalance.ToString("c");
                    txtTransactionAmount.Text = "";
                    allaccountbalance = checkingaccountbalance + savingsaccountbalance;
                    lblAllAccountsBalance.Text = allaccountbalance.ToString("c");
                }

                if (cboTransactionType.SelectedIndex == 1)  // Withdrawal from checking
                {
                    if (transactionamount > checkingaccountbalance)
                    {
                        lblMessage.Text = "Insufficient balance";
                        return;
                    }

                    savingsaccountbalance -= transactionamount;
                    lblSavingsAccountBalance.Text = savingsaccountbalance.ToString("c");
                    txtTransactionAmount.Text = "";
                    allaccountbalance = checkingaccountbalance + savingsaccountbalance;
                    lblAllAccountsBalance.Text = allaccountbalance.ToString();
                }
                if (cboTransactionType.SelectedIndex == 2)  // Transfer to checking
                {
                    if (transactionamount > checkingaccountbalance)
                    {
                        lblMessage.Text = "Insufficient balance";
                        return;
                    } 
                    var frmTransfer = new frmTransfer();
                    var accounts = new Accounts();
                    accounts.Savingsaccountbalance = savingsaccountbalance;
                    accounts.Checkingaccountbalance = checkingaccountbalance;
                    accounts = frmTransfer.TransferFunds(accounts);   
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear all controls where data is being displayed
            cboAccountType.Text = "";
            cboTransactionType.Text = "";
            txtTransactionAmount.Text = "";
            lblMessage.Text = "";
            lblSavingsAccountBalance.Text = "";
            lblCheckingAccountBalance.Text = "";
            lblAllAccountsBalance.Text = "";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void cboAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAccountType.SelectedIndex>-1)
              cboTransactionType.Focus();     
        }
        private void cboTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTransactionType.SelectedIndex > -1)
                txtTransactionAmount.Focus();
            // When user selects one of the 3 transaction types set the focus on the txtTransactionAmount text boxes
        }

        public bool IsValiddata()
        {

            if (!Staticvalidator.ISelected(cboAccountType.SelectedIndex))
            {
                lblMessage.Text = "Select Account Type";
                return false;
            }

            if (!Staticvalidator.ISelected(cboTransactionType.SelectedIndex))
            {
                lblMessage.Text = "Select Transaction Type";
                return false;
            }

            if (!Staticvalidator.IsDecimal(txtTransactionAmount.Text))
            {
                lblMessage.Text = "Type in Numeric value";
                return false;
            }
            return true;

        }
        private void frmBankAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
