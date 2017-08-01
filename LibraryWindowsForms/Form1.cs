using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text;
using System.IO;

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

            ShowTable();


        }

        private void takeABookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteForm deleteForm = new deleteForm();
            deleteForm.Show();
        }

        private void addABookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editABookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
  
        private void DeleteBook()
        {            
            SqlCommand deleteCommand = new SqlCommand(
                @"delete Books 
                  where idBook = " + dataLibraryGridView.CurrentRow.Index + "", connection);
            connection.Open();
            deleteCommand.ExecuteNonQuery();
            connection.Close();
        }
        private void ShowTable()
        {
            connection.Open();
            DataSet dataSet = new DataSet();
            DataTable bookViewTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                @"Select Books.idBook, Authors.fullNameOfAuthor, Genres.fullNameOfGenre,Books.nameOfBook,Books.yearOfPublish
                  From Authors inner join Books on Authors.idAuthor = Books.idAuthor 
                               inner join Genres on Genres.idGenre = Books.idGenre", connection);
            dataAdapter.Fill(dataSet, "allBooksInfo");
            dataLibraryGridView.AutoGenerateColumns = true;
            dataLibraryGridView.DataSource = dataSet;
            dataLibraryGridView.DataMember = "allBooksInfo";

            dataLibraryGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataLibraryGridView.AllowUserToAddRows = false;
            connection.Close();
        }



        //private void buttonTakeBook_Click(object sender, EventArgs e)
        //{
        //    int deleteIndex = dataLibraryGridView.SelectedCells[0].RowIndex;


        //    //!!!!!!!!!!!!!!!
        //    using (StreamWriter streamWriter = new StreamWriter(writePath, true, Encoding.Default))
        //    {
        //        streamWriter.WriteLine();
        //    }
        //}

    }
}
