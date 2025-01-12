using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Banking_System
{
    public partial class Form9 : Form
    {
        private string connectionString = "Data Source=DESKTOP-VS7EEEQ;Initial Catalog=Banking_System;Integrated Security=True;Encrypt=False";

        public Form9()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void LoadUserData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Query to select all user details
                string select_query = "SELECT user_id, name, date_of_birth, address, contact_no, email, username, password, cnic_no, account_no, balance FROM Users";
                SqlCommand selectCommand = new SqlCommand(select_query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable; // Ensure you have a DataGridView named usersDataGridView
            }
        }
    }
}
