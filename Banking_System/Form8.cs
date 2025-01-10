using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Banking_System
{
    public partial class Form8 : Form
    {
        private string connectionString = "Data Source=DESKTOP-VS7EEEQ;Initial Catalog=Banking_System;Integrated Security=True;Encrypt=False";

        public Form8()
        {
            InitializeComponent();
        }

        private void admin_next_button_Click(object sender, EventArgs e)
        {
            string password = admin_password_textbox.Text; // Ensure you have a textbox named password_textbox

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if a password is already set in the database
                string select_query = "SELECT password FROM Admin WHERE password IS NOT NULL";
                SqlCommand selectCommand = new SqlCommand(select_query, connection);
                object result = selectCommand.ExecuteScalar();

                if (result == null) // No password set
                {
                    // Insert the new password into the database
                    string insert_query = "INSERT INTO Admin (password) VALUES (@password)";
                    SqlCommand insertCommand = new SqlCommand(insert_query, connection);
                    insertCommand.Parameters.AddWithValue("@password", password);
                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("You'r Admin now and password set successfully!");
                    // Optionally redirect to Form9 or keep on the same form for further actions
                }
                else // Password already set, check for a match
                {
                    string storedPassword = result.ToString();
                    if (storedPassword == password)
                    {
                        // Redirect to Form9
                        Form9 form9 = new Form9();
                        form9.StartPosition = FormStartPosition.CenterScreen;
                        form9.Show();
                        this.Hide(); // Hide Form8
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password. Please try again.");
                    }
                }
            }
        }
    }
}
