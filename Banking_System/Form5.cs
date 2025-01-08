using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Banking_System
{
    public partial class Form5 : Form
    {
        private string connectionString = "Data Source=DESKTOP-VS7EEEQ;Initial Catalog=Banking_System;Integrated Security=True;Encrypt=False";
        private string account_no;

        public Form5(string account_no)
        {
            InitializeComponent();
            this.account_no = account_no;
            // Optionally, load the balance when the form loads
            LoadBalance();
        }

        private void LoadBalance()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Retrieve the current balance from the Users table
                string select_query = "SELECT balance FROM Users WHERE account_no = @account_no";
                SqlCommand selectCommand = new SqlCommand(select_query, connection);
                selectCommand.Parameters.AddWithValue("@account_no", account_no);

                object result = selectCommand.ExecuteScalar();

                // Handle null or non-int values
                if (result != null && result != DBNull.Value)
                {
                    int current_balance = Convert.ToInt32(result);
                    check_balance_textbox.Text = current_balance.ToString();
                }
                else
                {
                    MessageBox.Show("Account not found or balance is null.");
                }
            }
        }

        private void check_balance_done_button_Click(object sender, EventArgs e)
        {
            // Reload the balance when the button is clicked
            LoadBalance();
        }
    }
}
