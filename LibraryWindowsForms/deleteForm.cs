using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text;
using System.IO;
using System.Drawing;

namespace LibraryWindowsForms
{
    public partial class DeleteForm : Form
    {
        SqlConnection connection = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename= C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\LibraryDB.mdf;
            Integrated Security=True;Connect Timeout=30");
        public DeleteForm()
        {
            InitializeComponent();
            loadBookList();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteBook();
            loadBookList();
            label3.Text = "Deleted";
            label3.ForeColor = Color.Green;
        }
        
        private void DeleteBook()
        {
            SqlCommand deleteCommand = new SqlCommand(
                @"delete Books 
                   where nameOfBook like '" + comboBoxShowBookName.Text + "'", connection);
                                    
            connection.Open();
            deleteCommand.ExecuteNonQuery();
            connection.Close();
        }

        private void loadBookList()
        {
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(@"select * from Books", connection);
            DataTable bookNameTable = new DataTable();
            dataAdapter.Fill(bookNameTable);
            connection.Close();

            comboBoxShowBookName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxShowBookName.DataSource = bookNameTable;
            comboBoxShowBookName.DisplayMember = "nameOfBook";
            comboBoxShowBookName.ValueMember = "idBook";
        }
    }
}
