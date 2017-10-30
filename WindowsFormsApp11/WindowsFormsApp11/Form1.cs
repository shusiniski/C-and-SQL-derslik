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

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var studName = Namebox.Text;
            var studAge = Convert.ToInt32(Agebox.Text);
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\P203\Documents\Programming.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            var query = "insert student (studentName,studentAge) values ('"+studName+"', "+studAge+")";
            SqlCommand command = new SqlCommand(query, conn);
            command.ExecuteNonQuery();

        }
    }
}
