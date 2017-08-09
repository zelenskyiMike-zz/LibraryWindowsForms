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
    public partial class AddAuthorForm : Form
    {
        SqlConnection connection = new SqlConnection(
          @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename= C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\LibraryDB.mdf;
            Integrated Security=True;Connect Timeout=30");

        public AddAuthorForm()
        {
            InitializeComponent();
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthor();
        }

        private void AddAuthor()
        {
            Regex checkAuthorTextBox = new Regex(@"\d");
            if (textBoxAddAuthor.Text == "" || checkAuthorTextBox.IsMatch(textBoxAddAuthor.Text))
            {
                labelIsError.Text = "The name of Author can't be empty or contain numbers";
                labelIsError.ForeColor = Color.Red;
            }
            if (textBoxAddAuthor.Text != "" && !checkAuthorTextBox.IsMatch(textBoxAddAuthor.Text))
            {
                SqlCommand addAuthorCommand = new SqlCommand(
               @"insert into Authors values ('" + textBoxAddAuthor.Text + "')", connection);

                connection.Open();
                addAuthorCommand.ExecuteNonQuery();
                connection.Close();

                labelIsError.Text = "Success";
                labelIsError.ForeColor = Color.Green;
            }
        }
    }
}
