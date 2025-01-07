using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Banking_System
{
    public partial class Form3 : Form
    {
        private string connectionString = "Data Source=DESKTOP-VS7EEEQ;Initial Catalog=Banking_System;Integrated Security=True;Encrypt=False;";

        public Form3()
        {
            InitializeComponent();
        }

        private void sign_up_next_button_Click(object sender, EventArgs e)
        {
            // Retrieve values from textboxes
            string account_no = account_no_textbox.Text;
            string contact_no = contact_textbox.Text;
            string cnic_no = cnic_textbox.Text;
            string name = full_name_textbox.Text;
            string date_of_birth = dob_textbox.Text; // Store the DOB text for parsing later
            string address = address_textbox.Text;
            string email = email_textbox.Text;
            string username = username_textbox.Text;
            string password = password_textbox.Text;
            string balanceText = initial_deposit_textbox.Text; // Change the variable name here

            // Check if all textboxes are filled
            if (string.IsNullOrWhiteSpace(account_no) || string.IsNullOrWhiteSpace(contact_no) ||
                string.IsNullOrWhiteSpace(cnic_no) || string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(date_of_birth) || string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(balanceText))
            {
                MessageBox.Show("Please fill in all fields.");
                return; // Stop further processing
            }

            // Validate account_no
            if (account_no.Length != 10)
            {
                MessageBox.Show("Account number must be 10 digits.");
                return; // Stop further processing
            }

            // Validate contact_no
            if (contact_no.Length != 11)
            {
                MessageBox.Show("Contact number must be 11 digits.");
                return; // Stop further processing
            }

            // Validate cnic_no
            if (cnic_no.Length != 13)
            {
                MessageBox.Show("CNIC number must be 15 digits.");
                return; // Stop further processing
            }

            // Parse date of birth
            if (!DateTime.TryParse(date_of_birth, out DateTime dateOfBirth))
            {
                MessageBox.Show("Please enter a valid date of birth.");
                return; // Stop further processing
            }

            // Parse initial balance
            if (!int.TryParse(balanceText, out int balance)) // Use the new variable name here
            {
                MessageBox.Show("Please enter a valid balance.");
                return; // Stop further processing
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Users (account_no, name, date_of_birth, address, contact_no, email, username, password, cnic_no, balance) " +
                                   "VALUES (@account_no, @name, @date_of_birth, @address, @contact_no, @email, @username, @password, @cnic_no, @balance)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Adding parameters to the query
                        command.Parameters.AddWithValue("@account_no", account_no);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@date_of_birth", dateOfBirth);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@contact_no", contact_no);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password); // Consider hashing this
                        command.Parameters.AddWithValue("@cnic_no", cnic_no);
                        command.Parameters.AddWithValue("@balance", balance);

                        // Executing the command
                        int result = command.ExecuteNonQuery();

                        // Check if the insertion was successful
                        if (result > 0)
                        {
                            MessageBox.Show("User registered successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Error in user registration.");
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
