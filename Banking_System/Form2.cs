using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Banking_System
{
    public partial class Form2 : Form
    {
        private string connectionString = "Data Source=DESKTOP-VS7EEEQ;Initial Catalog=Banking_System;Integrated Security=True;Encrypt=False;"; // Removed Trust Server Certificate

        public Form2()
        {
            InitializeComponent();
        }

        private void sign_up_button_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.StartPosition = FormStartPosition.CenterScreen;
            form3.Show();
            this.Hide();
        }

        private void admin_button_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.StartPosition = FormStartPosition.CenterScreen;
            form8.Show();
            this.Hide();
        }

        private void sign_in_next_button_Click(object sender, EventArgs e)
        {
            string account_no = account_no_password_taxtbox.Text;
            string password = sign_in_password_taxtbox.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Users WHERE account_no = @account_no AND password = @password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Adding parameters to the query
                        command.Parameters.AddWithValue("@account_no", account_no);
                        command.Parameters.AddWithValue("@password", password);

                        // Execute the query
                        int result = (int)command.ExecuteScalar();

                        // Check if a matching record exists
                        if (result > 0)
                        {
                            Form10 form10 = new Form10(account_no);
                            form10.StartPosition = FormStartPosition.CenterScreen;
                            form10.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid account number or password.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
