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
            this.textBoxTitleOfBookDisplay = new System.Windows.Forms.TextBox();
            this.buttonEditBook = new System.Windows.Forms.Button();
            this.comboBoxChooseAGenre = new System.Windows.Forms.ComboBox();
            this.buttonEditTitle = new System.Windows.Forms.Button();
            this.buttonEditGenre = new System.Windows.Forms.Button();
            this.comboBoxChooseAnAuthor = new System.Windows.Forms.ComboBox();
            this.buttonEditAnAuthor = new System.Windows.Forms.Button();
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
            // textBoxTitleOfBookDisplay
            // 
            this.textBoxTitleOfBookDisplay.Location = new System.Drawing.Point(12, 154);
            this.textBoxTitleOfBookDisplay.Name = "textBoxTitleOfBookDisplay";
            this.textBoxTitleOfBookDisplay.Size = new System.Drawing.Size(181, 20);
            this.textBoxTitleOfBookDisplay.TabIndex = 3;
            // 
            // buttonEditBook
            // 
            this.buttonEditBook.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditBook.Location = new System.Drawing.Point(12, 195);
            this.buttonEditBook.Name = "buttonEditBook";
            this.buttonEditBook.Size = new System.Drawing.Size(99, 31);
            this.buttonEditBook.TabIndex = 4;
            this.buttonEditBook.Text = "Edit a book";
            this.buttonEditBook.UseVisualStyleBackColor = true;
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
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 238);
            this.Controls.Add(this.buttonEditAnAuthor);
            this.Controls.Add(this.comboBoxChooseAnAuthor);
            this.Controls.Add(this.buttonEditGenre);
            this.Controls.Add(this.buttonEditTitle);
            this.Controls.Add(this.comboBoxChooseAGenre);
            this.Controls.Add(this.buttonEditBook);
            this.Controls.Add(this.textBoxTitleOfBookDisplay);
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
        private System.Windows.Forms.TextBox textBoxTitleOfBookDisplay;
        private System.Windows.Forms.Button buttonEditBook;
        private System.Windows.Forms.ComboBox comboBoxChooseAGenre;
        private System.Windows.Forms.Button buttonEditTitle;
        private System.Windows.Forms.Button buttonEditGenre;
        private System.Windows.Forms.ComboBox comboBoxChooseAnAuthor;
        private System.Windows.Forms.Button buttonEditAnAuthor;
    }
}