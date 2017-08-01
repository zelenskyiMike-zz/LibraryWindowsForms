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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snlskmlcLalalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addABookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editABookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLibraryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelProgName
            // 
            this.labelProgName.AutoSize = true;
            this.labelProgName.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgName.Location = new System.Drawing.Point(256, 23);
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
            this.buttonDeleteBook.Size = new System.Drawing.Size(135, 44);
            this.buttonDeleteBook.TabIndex = 10;
            this.buttonDeleteBook.Text = "Delete a book";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.buttonDeleteBook_Click);
            // 
            // buttonEditBook
            // 
            this.buttonEditBook.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditBook.Location = new System.Drawing.Point(796, 62);
            this.buttonEditBook.Name = "buttonEditBook";
            this.buttonEditBook.Size = new System.Drawing.Size(135, 44);
            this.buttonEditBook.TabIndex = 13;
            this.buttonEditBook.Text = "Edit";
            this.buttonEditBook.UseVisualStyleBackColor = true;
            this.buttonEditBook.Click += new System.EventHandler(this.buttonEditBook_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBook.Location = new System.Drawing.Point(796, 132);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(135, 44);
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
            this.buttonTakeBook.Location = new System.Drawing.Point(643, 61);
            this.buttonTakeBook.Name = "buttonTakeBook";
            this.buttonTakeBook.Size = new System.Drawing.Size(138, 45);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(975, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.snlskmlcLalalaToolStripMenuItem,
            this.deleteBookToolStripMenuItem,
            this.addABookToolStripMenuItem,
            this.editABookToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.mainToolStripMenuItem.Text = "Options";
            // 
            // snlskmlcLalalaToolStripMenuItem
            // 
            this.snlskmlcLalalaToolStripMenuItem.Name = "snlskmlcLalalaToolStripMenuItem";
            this.snlskmlcLalalaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.snlskmlcLalalaToolStripMenuItem.Text = "Take a book";
            // 
            // deleteBookToolStripMenuItem
            // 
            this.deleteBookToolStripMenuItem.Name = "deleteBookToolStripMenuItem";
            this.deleteBookToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteBookToolStripMenuItem.Text = "Delete book";
            // 
            // addABookToolStripMenuItem
            // 
            this.addABookToolStripMenuItem.Name = "addABookToolStripMenuItem";
            this.addABookToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addABookToolStripMenuItem.Text = "Add a book";
            // 
            // editABookToolStripMenuItem
            // 
            this.editABookToolStripMenuItem.Name = "editABookToolStripMenuItem";
            this.editABookToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editABookToolStripMenuItem.Text = "Edit a book";
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTakeBook);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.buttonEditBook);
            this.Controls.Add(this.buttonDeleteBook);
            this.Controls.Add(this.dataLibraryGridView);
            this.Controls.Add(this.labelProgName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LibraryForm";
            this.Text = "LibraryApp";
            ((System.ComponentModel.ISupportInitialize)(this.dataLibraryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snlskmlcLalalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addABookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editABookToolStripMenuItem;
    }
}

