namespace LibraryWindowsForms
{
    partial class LibraryForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelProgName = new System.Windows.Forms.Label();
            this.dataLibraryGridView = new System.Windows.Forms.DataGridView();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.buttonEditBook = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.libraryDBDataSet = new LibraryWindowsForms.LibraryDBDataSet();
            this.buttonTakeBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataLibraryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProgName
            // 
            this.labelProgName.AutoSize = true;
            this.labelProgName.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgName.Location = new System.Drawing.Point(13, 13);
            this.labelProgName.Name = "labelProgName";
            this.labelProgName.Size = new System.Drawing.Size(117, 24);
            this.labelProgName.TabIndex = 0;
            this.labelProgName.Text = "BigLibrary";
            // 
            // dataLibraryGridView
            // 
            this.dataLibraryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLibraryGridView.Location = new System.Drawing.Point(13, 61);
            this.dataLibraryGridView.Name = "dataLibraryGridView";
            this.dataLibraryGridView.ReadOnly = true;
            this.dataLibraryGridView.Size = new System.Drawing.Size(613, 332);
            this.dataLibraryGridView.TabIndex = 1;
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteBook.Location = new System.Drawing.Point(646, 132);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(189, 43);
            this.buttonDeleteBook.TabIndex = 10;
            this.buttonDeleteBook.Text = "Delete a book";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.buttonDeleteBook_Click);
            // 
            // buttonEditBook
            // 
            this.buttonEditBook.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditBook.Location = new System.Drawing.Point(646, 196);
            this.buttonEditBook.Name = "buttonEditBook";
            this.buttonEditBook.Size = new System.Drawing.Size(189, 43);
            this.buttonEditBook.TabIndex = 13;
            this.buttonEditBook.Text = "Edit";
            this.buttonEditBook.UseVisualStyleBackColor = true;
            this.buttonEditBook.Click += new System.EventHandler(this.buttonEditBook_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBook.Location = new System.Drawing.Point(646, 257);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(189, 43);
            this.buttonAddBook.TabIndex = 15;
            this.buttonAddBook.Text = "Add a book";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonTakeBook
            // 
            this.buttonTakeBook.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTakeBook.Location = new System.Drawing.Point(646, 61);
            this.buttonTakeBook.Name = "buttonTakeBook";
            this.buttonTakeBook.Size = new System.Drawing.Size(189, 43);
            this.buttonTakeBook.TabIndex = 16;
            this.buttonTakeBook.Text = "Take a book";
            this.buttonTakeBook.UseVisualStyleBackColor = true;
            this.buttonTakeBook.Click += new System.EventHandler(this.buttonTakeBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 17;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTakeBook);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.buttonEditBook);
            this.Controls.Add(this.buttonDeleteBook);
            this.Controls.Add(this.dataLibraryGridView);
            this.Controls.Add(this.labelProgName);
            this.Name = "LibraryForm";
            this.Text = "LibraryApp";
            ((System.ComponentModel.ISupportInitialize)(this.dataLibraryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProgName;
        private System.Windows.Forms.DataGridView dataLibraryGridView;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.Button buttonEditBook;
        private System.Windows.Forms.Button buttonAddBook;
        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.Button buttonTakeBook;
        private System.Windows.Forms.Label label1;
    }
}

