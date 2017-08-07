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
           @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename= C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\LibraryDB.mdf;
            Integrated Security=True;Connect Timeout=30");

        public AddForm()
        {
            InitializeComponent();
            LoadAuthors();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Regex checkYearEnter = new Regex(@"[1-2]?[0-9]{4}");

            if(textBoxNameOfBook.Text == "")
            {
                label3.ForeColor = Color.Red;
            }

            if (!checkYearEnter.IsMatch(textBoxYearOfPublish.Text))
            {
                label4.Text = "Enter a corect year of this book's publish";
                label4.ForeColor = Color.Red;
            }

            if (checkYearEnter.IsMatch(textBoxYearOfPublish.Text) && textBoxNameOfBook.Text != "")
            {
                //query
            }
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
        }
    }
}
