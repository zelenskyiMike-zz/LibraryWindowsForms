namespace LibraryWindowsForms
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.textBoxNameOfBook = new System.Windows.Forms.TextBox();
            this.textBoxYearOfPublish = new System.Windows.Forms.TextBox();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelNameOfBook = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.buttonAddABook = new System.Windows.Forms.Button();
            this.buttonAddGenre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(12, 45);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(223, 21);
            this.comboBoxAuthor.TabIndex = 0;
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(12, 93);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(223, 21);
            this.comboBoxGenre.TabIndex = 1;
            // 
            // textBoxNameOfBook
            // 
            this.textBoxNameOfBook.Location = new System.Drawing.Point(13, 141);
            this.textBoxNameOfBook.Name = "textBoxNameOfBook";
            this.textBoxNameOfBook.Size = new System.Drawing.Size(222, 20);
            this.textBoxNameOfBook.TabIndex = 2;
            // 
            // textBoxYearOfPublish
            // 
            this.textBoxYearOfPublish.Location = new System.Drawing.Point(12, 189);
            this.textBoxYearOfPublish.Name = "textBoxYearOfPublish";
            this.textBoxYearOfPublish.Size = new System.Drawing.Size(222, 20);
            this.textBoxYearOfPublish.TabIndex = 3;
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAuthor.Location = new System.Drawing.Point(241, 45);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(118, 32);
            this.buttonAddAuthor.TabIndex = 4;
            this.buttonAddAuthor.Text = "Add Author";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(12, 29);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(177, 13);
            this.labelAuthor.TabIndex = 8;
            this.labelAuthor.Text = "Choose an author or add a new one";
            // 
            // labelNameOfBook
            // 
            this.labelNameOfBook.AutoSize = true;
            this.labelNameOfBook.Location = new System.Drawing.Point(12, 125);
            this.labelNameOfBook.Name = "labelNameOfBook";
            this.labelNameOfBook.Size = new System.Drawing.Size(118, 13);
            this.labelNameOfBook.TabIndex = 9;
            this.labelNameOfBook.Text = "Enter the name of book";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(12, 173);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(121, 13);
            this.labelYear.TabIndex = 10;
            this.labelYear.Text = "Enter the year of publish";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(12, 77);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(168, 13);
            this.labelGenre.TabIndex = 11;
            this.labelGenre.Text = "Choose a genre or add a new one";
            // 
            // buttonAddABook
            // 
            this.buttonAddABook.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddABook.Location = new System.Drawing.Point(12, 221);
            this.buttonAddABook.Name = "buttonAddABook";
            this.buttonAddABook.Size = new System.Drawing.Size(118, 32);
            this.buttonAddABook.TabIndex = 12;
            this.buttonAddABook.Text = "Add a book";
            this.buttonAddABook.UseVisualStyleBackColor = true;
            this.buttonAddABook.Click += new System.EventHandler(this.buttonAddABook_Click);
            // 
            // buttonAddGenre
            // 
            this.buttonAddGenre.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddGenre.Location = new System.Drawing.Point(241, 93);
            this.buttonAddGenre.Name = "buttonAddGenre";
            this.buttonAddGenre.Size = new System.Drawing.Size(118, 32);
            this.buttonAddGenre.TabIndex = 13;
            this.buttonAddGenre.Text = "Add Genre";
            this.buttonAddGenre.UseVisualStyleBackColor = true;
            this.buttonAddGenre.Click += new System.EventHandler(this.buttonAddGenre_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 265);
            this.Controls.Add(this.buttonAddGenre);
            this.Controls.Add(this.buttonAddABook);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelNameOfBook);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.buttonAddAuthor);
            this.Controls.Add(this.textBoxYearOfPublish);
            this.Controls.Add(this.textBoxNameOfBook);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.comboBoxAuthor);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAuthor;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.TextBox textBoxNameOfBook;
        private System.Windows.Forms.TextBox textBoxYearOfPublish;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelNameOfBook;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Button buttonAddABook;
        private System.Windows.Forms.Button buttonAddGenre;
    }
}