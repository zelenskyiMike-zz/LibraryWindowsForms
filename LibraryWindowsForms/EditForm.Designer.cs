namespace LibraryWindowsForms
{
    partial class EditForm
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
            this.comboBoxChooseABook = new System.Windows.Forms.ComboBox();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.textBoxYearOfPublishDisplay = new System.Windows.Forms.TextBox();
            this.buttonEditBook = new System.Windows.Forms.Button();
            this.comboBoxChooseAGenre = new System.Windows.Forms.ComboBox();
            this.buttonEditTitle = new System.Windows.Forms.Button();
            this.buttonEditGenre = new System.Windows.Forms.Button();
            this.comboBoxChooseAnAuthor = new System.Windows.Forms.ComboBox();
            this.buttonEditAnAuthor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxChooseABook
            // 
            this.comboBoxChooseABook.FormattingEnabled = true;
            this.comboBoxChooseABook.Location = new System.Drawing.Point(12, 21);
            this.comboBoxChooseABook.Name = "comboBoxChooseABook";
            this.comboBoxChooseABook.Size = new System.Drawing.Size(181, 21);
            this.comboBoxChooseABook.TabIndex = 0;
            // 
            // buttonChoose
            // 
            this.buttonChoose.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChoose.Location = new System.Drawing.Point(318, 14);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(99, 31);
            this.buttonChoose.TabIndex = 1;
            this.buttonChoose.Text = "Choose";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // textBoxYearOfPublishDisplay
            // 
            this.textBoxYearOfPublishDisplay.Location = new System.Drawing.Point(12, 154);
            this.textBoxYearOfPublishDisplay.Name = "textBoxYearOfPublishDisplay";
            this.textBoxYearOfPublishDisplay.Size = new System.Drawing.Size(181, 20);
            this.textBoxYearOfPublishDisplay.TabIndex = 3;
            // 
            // buttonEditBook
            // 
            this.buttonEditBook.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditBook.Location = new System.Drawing.Point(199, 147);
            this.buttonEditBook.Name = "buttonEditBook";
            this.buttonEditBook.Size = new System.Drawing.Size(99, 31);
            this.buttonEditBook.TabIndex = 4;
            this.buttonEditBook.Text = "Edit a book";
            this.buttonEditBook.UseVisualStyleBackColor = true;
            this.buttonEditBook.Click += new System.EventHandler(this.buttonEditBook_Click);
            // 
            // comboBoxChooseAGenre
            // 
            this.comboBoxChooseAGenre.FormattingEnabled = true;
            this.comboBoxChooseAGenre.Location = new System.Drawing.Point(12, 65);
            this.comboBoxChooseAGenre.Name = "comboBoxChooseAGenre";
            this.comboBoxChooseAGenre.Size = new System.Drawing.Size(181, 21);
            this.comboBoxChooseAGenre.TabIndex = 5;
            // 
            // buttonEditTitle
            // 
            this.buttonEditTitle.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditTitle.Location = new System.Drawing.Point(199, 14);
            this.buttonEditTitle.Name = "buttonEditTitle";
            this.buttonEditTitle.Size = new System.Drawing.Size(99, 31);
            this.buttonEditTitle.TabIndex = 6;
            this.buttonEditTitle.Text = "Edit title";
            this.buttonEditTitle.UseVisualStyleBackColor = true;
            this.buttonEditTitle.Click += new System.EventHandler(this.buttonEditTitle_Click);
            // 
            // buttonEditGenre
            // 
            this.buttonEditGenre.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditGenre.Location = new System.Drawing.Point(199, 58);
            this.buttonEditGenre.Name = "buttonEditGenre";
            this.buttonEditGenre.Size = new System.Drawing.Size(99, 31);
            this.buttonEditGenre.TabIndex = 7;
            this.buttonEditGenre.Text = "Edit genre";
            this.buttonEditGenre.UseVisualStyleBackColor = true;
            this.buttonEditGenre.Click += new System.EventHandler(this.buttonEditGenre_Click);
            // 
            // comboBoxChooseAnAuthor
            // 
            this.comboBoxChooseAnAuthor.FormattingEnabled = true;
            this.comboBoxChooseAnAuthor.Location = new System.Drawing.Point(12, 110);
            this.comboBoxChooseAnAuthor.Name = "comboBoxChooseAnAuthor";
            this.comboBoxChooseAnAuthor.Size = new System.Drawing.Size(181, 21);
            this.comboBoxChooseAnAuthor.TabIndex = 8;
            // 
            // buttonEditAnAuthor
            // 
            this.buttonEditAnAuthor.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditAnAuthor.Location = new System.Drawing.Point(199, 103);
            this.buttonEditAnAuthor.Name = "buttonEditAnAuthor";
            this.buttonEditAnAuthor.Size = new System.Drawing.Size(99, 31);
            this.buttonEditAnAuthor.TabIndex = 9;
            this.buttonEditAnAuthor.Text = "Edit author";
            this.buttonEditAnAuthor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 238);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEditAnAuthor);
            this.Controls.Add(this.comboBoxChooseAnAuthor);
            this.Controls.Add(this.buttonEditGenre);
            this.Controls.Add(this.buttonEditTitle);
            this.Controls.Add(this.comboBoxChooseAGenre);
            this.Controls.Add(this.buttonEditBook);
            this.Controls.Add(this.textBoxYearOfPublishDisplay);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.comboBoxChooseABook);
            this.Name = "EditForm";
            this.Text = "  ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChooseABook;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.TextBox textBoxYearOfPublishDisplay;
        private System.Windows.Forms.Button buttonEditBook;
        private System.Windows.Forms.ComboBox comboBoxChooseAGenre;
        private System.Windows.Forms.Button buttonEditTitle;
        private System.Windows.Forms.Button buttonEditGenre;
        private System.Windows.Forms.ComboBox comboBoxChooseAnAuthor;
        private System.Windows.Forms.Button buttonEditAnAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}