using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LandiLab4Se426
{
    public partial class Midterm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetResults_Click(object sender, EventArgs e)
        {
            string owner = "";
            string account_id = "";
            decimal total_amount_in_accounts = 0;

            wsBanking.BankingService bank = new wsBanking.BankingService();
            wsBanking.BankInformation account_info;
            account_info = bank.GetBankInformation();

            for (int i = 0; i < account_info.accounts.Length; i++)
            {
                owner = account_info.OwnerName;
                account_id = account_info.AccountID;
                total_amount_in_accounts = total_amount_in_accounts + account_info.accounts[i].Amount;
            }
            txtShowResults.Text = "Owner: " + owner + Environment.NewLine;
            txtShowResults.Text += "Account ID: " + account_id + Environment.NewLine;
            txtShowResults.Text += "Total Amount: " + Convert.ToString(total_amount_in_accounts);

        }
    }
}