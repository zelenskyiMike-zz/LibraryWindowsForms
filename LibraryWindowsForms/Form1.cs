using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LibraryWindowsForms
{
    public partial class LibraryForm : Form
    {
        SqlConnection connection = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename= C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\LibraryDB.mdf;
            Integrated Security=True;Connect Timeout=30");

        public LibraryForm()
        {
            InitializeComponent();

            connection.Open();
            DataSet dataSet = new DataSet();
            DataTable bookViewTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                @"Select Authors.fullNameOfAuthor, Genres.fullNameOfGenre,Books.nameOfBook,Books.yearOfPublish
                  From Authors inner join Books on Authors.idAuthor = Books.idAuthor 
                               inner join Genres on Genres.idGenre = Books.idGenre", connection);
            dataAdapter.Fill(dataSet, "allBooksInfo");
            dataLibraryGridView.AutoGenerateColumns = true;
            dataLibraryGridView.DataSource = dataSet;
            dataLibraryGridView.DataMember = "allBooksInfo";
            
            dataLibraryGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            connection.Close(); 
        }

        private void buttonTakeBook_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditBook_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {

        }

       
    }
}
