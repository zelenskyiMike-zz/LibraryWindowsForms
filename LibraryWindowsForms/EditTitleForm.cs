using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryWindowsForms
{
    public partial class EditTitleForm : Form
    {
        public EditTitleForm()
        {
            InitializeComponent();

            EditForm editForm = new EditForm();

            textBoxTitleOfBookValue.Text = editForm.bookTitlePresentValue;
        }
    }
}
