using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Banking_System
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=DESKTOP-VS7EEEQ;Initial Catalog=Banking_System;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void sign_in_button_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.CenterScreen;
            form2.Show();
        }
        
    }
}
