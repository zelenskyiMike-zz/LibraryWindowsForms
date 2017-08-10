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

        DeleteForm deleteForm;
        AddForm addForm;
        EditForm editForm;

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
            if (deleteForm == null || deleteForm.IsDisposed)
            {
                deleteForm = new DeleteForm();
                deleteForm.Show();
                
            }
            else
            {
                MessageBox.Show("This window has already been opened", "BigLibrary");
            }
            
        }

        private void addABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addForm == null || addForm.IsDisposed)
            {
                addForm = new AddForm();
                addForm.Show();

            }
            else
            {
                MessageBox.Show("This window has already been opened", "BigLibrary");
            }
        }

        private void editABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editForm == null || editForm.IsDisposed)
            {
                editForm = new EditForm();
                editForm.Show();

            }
            else
            {
                MessageBox.Show("This window has already been opened", "BigLibrary");
            }
        }


        public void ShowTable()
        {
            connection.Open();
            DataSet dataSet = new DataSet();
            DataTable bookViewTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                @"Select Authors.fullNameOfAuthor, Genres.fullNameOfGenre,Books.nameOfBook,Books.yearOfPublish
                  From Authors inner join Books on Authors.idAuthor = Books.idAuthor 
                               inner join Genres on Genres.idGenre = Books.idGenre
                               order by Books.idAuthor", connection);
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
