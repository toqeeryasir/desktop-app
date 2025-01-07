using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Banking_System
{
    public partial class Form4 : Form
    {
        private string account_no;
        private string connectionString = "Data Source=DESKTOP-VS7EEEQ;Initial Catalog=Banking_System;Integrated Security=True;Encrypt=False";

        public Form4(string account_no)
        {
            InitializeComponent();
            this.account_no = account_no;
        }

        private void add_balance_add_button_Click(object sender, EventArgs e)
        {
            int added_balance = int.Parse(add_balance_textbox.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Retrieve the current balance from the Users table
                string select_query = "SELECT balance FROM Users WHERE account_no = @account_no";
                SqlCommand selectCommand = new SqlCommand(select_query, connection);
                selectCommand.Parameters.AddWithValue("@account_no", account_no);

                object result = selectCommand.ExecuteScalar();

                // Handle null or non-int values
                int current_balance = 0;
                if (result != null && result != DBNull.Value)
                {
                    current_balance = Convert.ToInt32(result);
                }

                // Calculate the new balance
                int updated_balance = current_balance + added_balance;

                // Update the balance in the Users table
                string updateQuery = "UPDATE Users SET balance = @updated_balance WHERE account_no = @account_no";
                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@updated_balance", updated_balance);
                updateCommand.Parameters.AddWithValue("@account_no", account_no);

                updateCommand.ExecuteNonQuery();

                MessageBox.Show("Balance updated successfully!");
            }
        }
    }
}
