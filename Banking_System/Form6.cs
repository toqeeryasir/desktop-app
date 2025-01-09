using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Banking_System
{
    public partial class Form6 : Form
    {
        private string account_no;
        private string connectionString = "Data Source=DESKTOP-VS7EEEQ;Initial Catalog=Banking_System;Integrated Security=True;Encrypt=False";

        public Form6(string account_no)
        {
            InitializeComponent();
            this.account_no = account_no;
        }

        private void withdraw_button_Click(object sender, EventArgs e)
        {
            // Check if the textbox name is correct
            if (decimal.TryParse(withdraw_textbox.Text, out decimal withdrawAmount))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve the current balance
                    string select_query = "SELECT balance FROM Users WHERE account_no = @account_no";
                    SqlCommand selectCommand = new SqlCommand(select_query, connection);
                    selectCommand.Parameters.AddWithValue("@account_no", account_no);

                    object result = selectCommand.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int current_balance = Convert.ToInt32(result);

                        // Check if the withdrawal amount is valid
                        if (withdrawAmount <= current_balance)
                        {
                            // Calculate the new balance
                            int new_balance = current_balance - (int)withdrawAmount;

                            // Update the balance in the database
                            string update_query = "UPDATE Users SET balance = @new_balance WHERE account_no = @account_no";
                            SqlCommand updateCommand = new SqlCommand(update_query, connection);
                            updateCommand.Parameters.AddWithValue("@new_balance", new_balance);
                            updateCommand.Parameters.AddWithValue("@account_no", account_no);

                            updateCommand.ExecuteNonQuery();
                            MessageBox.Show("Withdrawal successful! New balance: " + new_balance);
                        }
                        else
                        {
                            MessageBox.Show("Insufficient balance!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Account not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }
    }
}
