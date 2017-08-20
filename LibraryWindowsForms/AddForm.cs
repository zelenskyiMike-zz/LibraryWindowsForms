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
using System.Text.RegularExpressions;

namespace LibraryWindowsForms
{
    public partial class AddForm : Form
    {
        SqlConnection connection = new SqlConnection(
           @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\LibraryWindowsForms\LibraryDB.mdf;
             Integrated Security=True;Connect Timeout=30");

        public event EventHandler<ClickingEventArgs> Clicking;

        
        AddAuthorForm addAuthorForm;
        AddGenreForm addGenreForm;
        

        public AddForm()
        {
            InitializeComponent();
            LoadAuthors();
            LoadGenres();
            
        }

       

        public void buttonAddABook_Click(object sender, EventArgs e)
        {

            bool isClicked = false;

            if (Clicking != null)
                Clicking(this, new ClickingEventArgs(isClicked = true));
            //    string labelYearText = labelYear.Text;

            //    Regex checkOldYearsEnter = new Regex(@"^[1]{1}[0-9]{1}[0-9]{1}[0-9]{1}");
            //    Regex checkNewYearEnter = new Regex(@"^[2]{1}[0]{1}[0]{1}[0-9]{1}");
            //    Regex checkNewestYearEnter = new Regex(@"^[2]{1}[0]{1}[1]{1}[0-7]{1}");

            //    if (textBoxNameOfBook.Text == "")
            //    {
            //        labelNameOfBook.ForeColor = Color.Red;
            //    }
            //    //{
            //        if (!checkOldYearsEnter.IsMatch(textBoxYearOfPublish.Text) || !checkNewYearEnter.IsMatch(textBoxYearOfPublish.Text) ||
            //            !checkNewestYearEnter.IsMatch(textBoxYearOfPublish.Text))
            //        {
            //            labelYear.ForeColor = Color.Red;
            //        }



            //        if (checkOldYearsEnter.IsMatch(textBoxYearOfPublish.Text) || checkNewYearEnter.IsMatch(textBoxYearOfPublish.Text) ||
            //                checkNewestYearEnter.IsMatch(textBoxYearOfPublish.Text) && textBoxNameOfBook.Text != "")
            //        {
            //            AddABook();
            //            labelNameOfBook.ForeColor = Color.Black;
            //            labelYear.ForeColor = Color.Black;
            //            MessageBox.Show("The book has been added successfuly", "BigLibrary");

            //        }

        }

        

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            addAuthorForm = new AddAuthorForm();
            this.Hide();
            addAuthorForm.ShowDialog();
            this.Show();
            LoadAuthors();
        }

        private void buttonAddGenre_Click(object sender, EventArgs e)
        {
            addGenreForm = new AddGenreForm();
            this.Hide();
            addGenreForm.ShowDialog();
            this.Show();
            LoadGenres();
        }





        private void LoadAuthors()
        {
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(@"select * from Authors", connection);
            DataTable authorNameTable = new DataTable();
            dataAdapter.Fill(authorNameTable);
            connection.Close();

            comboBoxAuthor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAuthor.DataSource = authorNameTable;
            comboBoxAuthor.DisplayMember = "fullNameOfAuthor";
            comboBoxAuthor.ValueMember = "idAuthor";
        }
        private void LoadGenres()
        {
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(@"select * from Genres", connection);
            DataTable genreNameTable = new DataTable();
            dataAdapter.Fill(genreNameTable);
            connection.Close();

            comboBoxGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGenre.DataSource = genreNameTable;
            comboBoxGenre.DisplayMember = "fullNameOfGenre";
            comboBoxGenre.ValueMember = "idGenre";
        }

        private void AddABook()
        {
            int idAuthor;
            int idGenre;
            SqlCommand takeAuthorID = new SqlCommand(
                       @"select idAuthor from Authors where fullNameOfAuthor like'" + comboBoxAuthor.Text + "'", connection);

            SqlCommand takeGenreID = new SqlCommand(
                       @"select idGenre from Genres where fullNameOfGenre like'" + comboBoxGenre.Text + "'", connection);

            connection.Open();
            idAuthor = (int)takeAuthorID.ExecuteScalar();
            idGenre = (int)takeGenreID.ExecuteScalar();
            connection.Close();

            SqlCommand addABook = new SqlCommand(
                       @"insert into Books values (
                       " + idAuthor + "," + idGenre + ",'" + textBoxNameOfBook.Text + "'," + textBoxYearOfPublish.Text + ")", connection);
            connection.Open();
            addABook.ExecuteNonQuery();
            connection.Close();
        }

        
    }
}
