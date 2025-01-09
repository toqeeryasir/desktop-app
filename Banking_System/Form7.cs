using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Banking_System
{
    public partial class Form7 : Form
    {
        private string account_no;
        private string connectionString = "Data Source=DESKTOP-VS7EEEQ;Initial Catalog=Banking_System;Integrated Security=True;Encrypt=False";

        public Form7(string account_no)
        {
            InitializeComponent();
            this.account_no = account_no;

            // Load current user details into the text boxes
            LoadUserDetails();
        }

        private void LoadUserDetails()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Retrieve the current user details
                string select_query = "SELECT name, contact_no, email, address FROM Users WHERE account_no = @account_no";
                SqlCommand selectCommand = new SqlCommand(select_query, connection);
                selectCommand.Parameters.AddWithValue("@account_no", account_no);

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read())
                {
                    edit_full_name_textbox.Text = reader["name"].ToString(); // Changed to "name"
                    edit_contact_no_textbox.Text = reader["contact_no"].ToString();
                    edit_email_textbox.Text = reader["email"].ToString();
                    edit_address_textbox.Text = reader["address"].ToString();
                }
                reader.Close();
            }
        }

        private void edit_account_button_Click(object sender, EventArgs e)
        {
            string fullName = edit_full_name_textbox.Text;
            string contactNo = edit_contact_no_textbox.Text;
            string email = edit_email_textbox.Text;
            string address = edit_address_textbox.Text;

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(contactNo) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Update the user details in the database
                string update_query = "UPDATE Users SET name = @name, contact_no = @contact_no, email = @email, address = @address WHERE account_no = @account_no";
                SqlCommand updateCommand = new SqlCommand(update_query, connection);
                updateCommand.Parameters.AddWithValue("@name", fullName); // Changed to "name"
                updateCommand.Parameters.AddWithValue("@contact_no", contactNo);
                updateCommand.Parameters.AddWithValue("@email", email);
                updateCommand.Parameters.AddWithValue("@address", address);
                updateCommand.Parameters.AddWithValue("@account_no", account_no);

                int rowsAffected = updateCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User details updated successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to update user details.");
                }
            }
        }
    }
}
