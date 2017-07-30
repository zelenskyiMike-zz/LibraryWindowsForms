namespace LibraryWindowsForms
{
    partial class Form1
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
            this.buttonTakeBook = new System.Windows.Forms.Button();
            this.buttonEditBook = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataLibraryGridView)).BeginInit();
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
            this.dataLibraryGridView.Size = new System.Drawing.Size(638, 332);
            this.dataLibraryGridView.TabIndex = 1;
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteBook.Location = new System.Drawing.Point(674, 132);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(189, 43);
            this.buttonDeleteBook.TabIndex = 10;
            this.buttonDeleteBook.Text = "Delete a book";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.buttonDeleteBook_Click);
            // 
            // buttonTakeBook
            // 
            this.buttonTakeBook.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTakeBook.Location = new System.Drawing.Point(674, 61);
            this.buttonTakeBook.Name = "buttonTakeBook";
            this.buttonTakeBook.Size = new System.Drawing.Size(189, 43);
            this.buttonTakeBook.TabIndex = 11;
            this.buttonTakeBook.Text = "Take a book";
            this.buttonTakeBook.UseVisualStyleBackColor = true;
            // 
            // buttonEditBook
            // 
            this.buttonEditBook.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditBook.Location = new System.Drawing.Point(674, 196);
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
            this.buttonAddBook.Location = new System.Drawing.Point(674, 257);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(189, 43);
            this.buttonAddBook.TabIndex = 15;
            this.buttonAddBook.Text = "Add a book";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 405);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.buttonEditBook);
            this.Controls.Add(this.buttonTakeBook);
            this.Controls.Add(this.buttonDeleteBook);
            this.Controls.Add(this.dataLibraryGridView);
            this.Controls.Add(this.labelProgName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataLibraryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProgName;
        private System.Windows.Forms.DataGridView dataLibraryGridView;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.Button buttonTakeBook;
        private System.Windows.Forms.Button buttonEditBook;
        private System.Windows.Forms.Button buttonAddBook;
    }
}

