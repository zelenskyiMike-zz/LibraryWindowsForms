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

        EditTitleForm editTitleForm;


        public EditForm()
        {
            InitializeComponent();
            LoadBookList();
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            LoadAllBookInfo();
        }
        private void buttonEditBook_Click(object sender, EventArgs e)
        {
            UpdateAllBookInfo();
        }

        private void buttonEditTitle_Click(object sender, EventArgs e)
        {
            editTitleForm = new EditTitleForm();
            editTitleForm.ShowDialog();
            
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
        private void ChooseBookInfo(out int idAuthor, out int idGenre, out int yearOfPublish)
        {
            //int idAuthor;
            //int idGenre;

            SqlCommand takeGenreID = new SqlCommand(
                       @"select idGenre from Books where nameOfBook like'" + comboBoxChooseABook.Text + "'", connection);
            SqlCommand takeAuthorID = new SqlCommand(
                       @"select idAuthor from Books where nameOfBook like'" + comboBoxChooseABook.Text + "'", connection);
            SqlCommand takeYearOfPublish = new SqlCommand(
                       @"select YearOfPublish from Books where nameOfBook like'" + comboBoxChooseABook.Text + "'", connection);

            connection.Open();
            idAuthor = (int)takeAuthorID.ExecuteScalar();
            idGenre = (int)takeGenreID.ExecuteScalar();
            yearOfPublish = (int)takeYearOfPublish.ExecuteScalar();
            connection.Close();
        }

        private void LoadAllBookInfo()
        {
            ChooseBookInfo(out int idAuthor, out int idGenre, out int yearOfPublish);

            connection.Open();
            SqlDataAdapter genresDataAdapter = new SqlDataAdapter(@"select * from Genres", connection);
            DataTable genreNameTable = new DataTable();
            genresDataAdapter.Fill(genreNameTable);

            SqlDataAdapter authorsDataAdapter = new SqlDataAdapter(@"select * from Authors", connection);
            DataTable authorNameTable = new DataTable();
            authorsDataAdapter.Fill(authorNameTable);

            SqlDataAdapter yearDataAdapter = new SqlDataAdapter(@"select * from Books", connection);
            DataTable yearOfPublishTable = new DataTable();
            yearDataAdapter.Fill(yearOfPublishTable);

            connection.Close();
            
            comboBoxChooseAGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChooseAGenre.DataSource = genreNameTable;
            comboBoxChooseAGenre.DisplayMember = "fullNameOfGenre";
            comboBoxChooseAGenre.ValueMember = "idGenre";
            comboBoxChooseAGenre.SelectedIndex = idGenre - 1;


            comboBoxChooseAnAuthor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChooseAnAuthor.DataSource = authorNameTable;
            comboBoxChooseAnAuthor.DisplayMember = "fullNameOfAuthor";
            comboBoxChooseAnAuthor.ValueMember = "idAuthor";
            comboBoxChooseAnAuthor.SelectedIndex = idAuthor - 1;
            
           
            textBoxYearOfPublishDisplay.Text = yearOfPublish.ToString();

        }
       
        private void UpdateAllBookInfo()
        {
            //update Books
            //set idGenre = 1
            //where nameOfBook like 'Повесть новых лет'


            SqlCommand UpdateTitle = new SqlCommand(
                      @"update Books set nameOfBook = '" + comboBoxChooseABook.Text + "'" +
                      " where nameOfBook like '" + comboBoxChooseABook.Text + "'", connection);
            SqlCommand UpdateGenre = new SqlCommand(
                       @"update Books set Books.idGenre = " + comboBoxChooseAGenre.SelectedIndex+1+ "" +
                       " where nameOfBook like '" + comboBoxChooseABook.Text + "'", connection);
            SqlCommand UpdateAuthor = new SqlCommand(
                       @"update Books set idAuthor = " + comboBoxChooseAnAuthor.SelectedIndex+1 + "" +
                       " where nameOfBook like '" + comboBoxChooseABook.Text + "'", connection);
            SqlCommand UpdateYearOfPublish = new SqlCommand(
                       @"update Books set yearOfPublish = " + textBoxYearOfPublishDisplay.Text + "" +
                       "  where nameOfBook like '" + comboBoxChooseABook.Text + "'", connection);

            connection.Open();
            UpdateTitle.ExecuteNonQuery();
            UpdateAuthor.ExecuteNonQuery();
            UpdateGenre.ExecuteNonQuery();
            UpdateYearOfPublish.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Success");
            //label1.Text = comboBoxChooseAGenre.Text;
            //label2.Text = comboBoxChooseAGenre.SelectedIndex.ToString();
        }
    }
}
