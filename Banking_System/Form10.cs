using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_System
{
    public partial class Form10 : Form
    {
        private string connectionString = "Data Source=DESKTOP-VS7EEEQ;Initial Catalog=Banking_System;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        private string accountNo;
        public Form10(string accountNo)
        {
            InitializeComponent();
            this.accountNo = accountNo;
        }

        private void add_balalnce_button_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(accountNo);
            form4.StartPosition = FormStartPosition.CenterScreen;
            form4.Show();
            this.Hide();

            Form6 form6 = new Form6(accountNo);
            form6.Hide();
            Form5 form5 = new Form5(accountNo);
            form5.Hide();
            Form7 form7 = new Form7(accountNo);
            form7.Hide();
        }

        private void withdraw_button_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(accountNo);
            form6.StartPosition = FormStartPosition.CenterScreen;
            form6.Show();
            this.Hide();

            Form4 form4 = new Form4(accountNo);
            form4.Hide();
            Form5 form5 = new Form5(accountNo);
            form5.Hide();
            Form7 form7 = new Form7(accountNo);
            form7.Hide();
        }

        private void Check_balance_button_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(accountNo);
            form5.StartPosition = FormStartPosition.CenterScreen;
            form5.Show();
            this.Hide();

            Form4 form4 = new Form4(accountNo);
            form4.Hide();
            Form6 form6 = new Form6(accountNo);
            form6.Hide();
            Form7 form7 = new Form7(accountNo);
            form7.Hide();
        }

        private void edit_account_button_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(accountNo);
            form7.StartPosition = FormStartPosition.CenterScreen;
            form7.Show();
            this.Hide();

            Form4 form4 = new Form4(accountNo);
            form4.Hide();
            Form6 form6 = new Form6(accountNo);
            form6.Hide();
            Form5 form5 = new Form5(accountNo);
            form5.Hide();
        }
    }
}
