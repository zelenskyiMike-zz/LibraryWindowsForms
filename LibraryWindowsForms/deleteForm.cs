using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text;
using System.IO;

namespace LibraryWindowsForms
{
    public partial class deleteForm : Form
    {
        SqlConnection connection = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename= C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\LibraryDB.mdf;
            Integrated Security=True;Connect Timeout=30");

        public deleteForm()
        {
            InitializeComponent();


            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(@"select * from Books", connection);
            DataTable bookNameTable = new DataTable();
            dataAdapter.Fill(bookNameTable);
            connection.Close();

            comboBox1.DataSource = bookNameTable;
            comboBox1.DisplayMember = "nameOfBook";
            comboBox1.ValueMember = "idBook";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = comboBox1.Text;
        }
    }
}
