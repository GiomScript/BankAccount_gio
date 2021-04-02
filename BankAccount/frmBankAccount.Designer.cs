namespace BankAccount
{
    partial class frmBankAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboAccountType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTransactionAmount = new System.Windows.Forms.TextBox();
            this.cboTransactionType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCheckingAccountBalance = new System.Windows.Forms.Label();
            this.lblSavingsAccountBalance = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAllAccountsBalance = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Account Type";
            // 
            // cboAccountType
            // 
            this.cboAccountType.FormattingEnabled = true;
            this.cboAccountType.Items.AddRange(new object[] {
            "Checking",
            "Savings"});
            this.cboAccountType.Location = new System.Drawing.Point(288, 16);
            this.cboAccountType.Name = "cboAccountType";
            this.cboAccountType.Size = new System.Drawing.Size(148, 33);
            this.cboAccountType.TabIndex = 1;
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Transaction Amount";
            // 
            // txtTransactionAmount
            // 
            this.txtTransactionAmount.Location = new System.Drawing.Point(288, 106);
            this.txtTransactionAmount.Name = "txtTransactionAmount";
            this.txtTransactionAmount.Size = new System.Drawing.Size(148, 30);
            this.txtTransactionAmount.TabIndex = 3;
            // 
            // cboTransactionType
            // 
            this.cboTransactionType.FormattingEnabled = true;
            this.cboTransactionType.Items.AddRange(new object[] {
            "Deposit",
            "Withdrawal",
            "Transfer"});
            this.cboTransactionType.Location = new System.Drawing.Point(288, 62);
            this.cboTransactionType.Name = "cboTransactionType";
            this.cboTransactionType.Size = new System.Drawing.Size(148, 33);
            this.cboTransactionType.TabIndex = 5;
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Transaction Type";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(527, 16);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(139, 29);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(527, 64);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(139, 29);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(527, 106);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 29);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Checking Account Balance";
            // 
            // lblCheckingAccountBalance
            // 
            this.lblCheckingAccountBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCheckingAccountBalance.Location = new System.Drawing.Point(284, 146);
            this.lblCheckingAccountBalance.Name = "lblCheckingAccountBalance";
            this.lblCheckingAccountBalance.Size = new System.Drawing.Size(152, 25);
            this.lblCheckingAccountBalance.TabIndex = 11;
            // 
            // lblSavingsAccountBalance
            // 
            this.lblSavingsAccountBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSavingsAccountBalance.Location = new System.Drawing.Point(284, 188);
            this.lblSavingsAccountBalance.Name = "lblSavingsAccountBalance";
            this.lblSavingsAccountBalance.Size = new System.Drawing.Size(152, 25);
            this.lblSavingsAccountBalance.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Savings Account Balance";
            // 
            // lblAllAccountsBalance
            // 
            this.lblAllAccountsBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAllAccountsBalance.Location = new System.Drawing.Point(284, 228);
            this.lblAllAccountsBalance.Name = "lblAllAccountsBalance";
            this.lblAllAccountsBalance.Size = new System.Drawing.Size(152, 25);
            this.lblAllAccountsBalance.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "All Accounts Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Message";
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Location = new System.Drawing.Point(236, 269);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(485, 57);
            this.lblMessage.TabIndex = 17;
            // 
            // frmBankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 427);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAllAccountsBalance);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblSavingsAccountBalance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCheckingAccountBalance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.cboTransactionType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTransactionAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboAccountType);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBankAccount";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmBankAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAccountType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTransactionAmount;
        private System.Windows.Forms.ComboBox cboTransactionType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCheckingAccountBalance;
        private System.Windows.Forms.Label lblSavingsAccountBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAllAccountsBalance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMessage;
    }
}

