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

namespace LibraryWindowsForms
{
    public partial class EditForm : Form
    {
        SqlConnection connection = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename= C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\LibraryDB.mdf;
            Integrated Security=True;Connect Timeout=30");
        public EditForm()
        {
            InitializeComponent();
            LoadBookList();
        }


        private void buttonChoose_Click(object sender, EventArgs e)
        {
            LoadGenres();
            LoadAuthors();

        }

        private void LoadBookList()
        {
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(@"select * from Books", connection);
            DataTable bookNameTable = new DataTable();
            dataAdapter.Fill(bookNameTable);
            connection.Close();

            comboBoxChooseABook.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChooseABook.DataSource = bookNameTable;
            comboBoxChooseABook.DisplayMember = "nameOfBook";
            comboBoxChooseABook.ValueMember = "idBook";
        }
        private void ChooseBookInfo(out int idAuthor, out int idGenre)
        {
            //int idAuthor;
            //int idGenre;

            SqlCommand takeGenreID = new SqlCommand(
                       @"select idGenre from Books where fullNameOfGenre like'" + comboBoxChooseABook.Text + "'", connection);
            SqlCommand takeAuthorID = new SqlCommand(
                       @"select idAuthor from Books where fullNameOfAuthor like'" + comboBoxChooseABook.Text + "'", connection);

            connection.Open();
            idAuthor = (int)takeAuthorID.ExecuteScalar();
            idGenre = (int)takeGenreID.ExecuteScalar();
            connection.Close();
        }

        private void LoadGenres()
        {
            ChooseBookInfo(out int idAuthor, out int idGenre);

            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(@"select * from Genres", connection);
            DataTable genreNameTable = new DataTable();
            dataAdapter.Fill(genreNameTable);
            connection.Close();

            comboBoxChooseAGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChooseAGenre.DataSource = genreNameTable;
            comboBoxChooseAGenre.DisplayMember = "fullNameOfGenre";
            comboBoxChooseAGenre.ValueMember = "idGenre";
            comboBoxChooseAGenre.SelectedIndex = idGenre;
        }
        private void LoadAuthors()
        {
            ChooseBookInfo(out int idAuthor, out int idGenre);

            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(@"select * from Authors", connection);
            DataTable authorNameTable = new DataTable();
            dataAdapter.Fill(authorNameTable);
            connection.Close();

            comboBoxChooseAnAuthor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChooseAnAuthor.DataSource = authorNameTable;
            comboBoxChooseAnAuthor.DisplayMember = "fullNameOfAuthor";
            comboBoxChooseAnAuthor.ValueMember = "idAuthor";
            comboBoxChooseAnAuthor.SelectedIndex = idAuthor;
        }
    }
}
