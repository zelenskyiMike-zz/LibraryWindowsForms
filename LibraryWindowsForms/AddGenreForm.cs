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
    public partial class AddGenreForm : Form
    {
        SqlConnection connection = new SqlConnection(
          @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename= C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\LibraryDB.mdf;
            Integrated Security=True;Connect Timeout=30");

        public AddGenreForm()
        {
            InitializeComponent();
        }
        private void buttonAddGenre_Click(object sender, EventArgs e)
        {
            AddGenre();
        }

        private void AddGenre()
        {
            Regex checkAuthorTextBox = new Regex(@"\d");
            if (textBoxAddGenre.Text == "" || checkAuthorTextBox.IsMatch(textBoxAddGenre.Text))
            {
                labelIsError.Text = "The title of genre can't be empty or contain numbers";
                labelIsError.ForeColor = Color.Red;
            }
            if (textBoxAddGenre.Text != "" && !checkAuthorTextBox.IsMatch(textBoxAddGenre.Text))
            {
                SqlCommand addAuthorCommand = new SqlCommand(
               @"insert into Authors values ('" + textBoxAddGenre.Text + "')", connection);

                connection.Open();
                addAuthorCommand.ExecuteNonQuery();
                connection.Close();

                labelIsError.Text = "Success";
                labelIsError.ForeColor = Color.Green;
            }
        }
    }
}
