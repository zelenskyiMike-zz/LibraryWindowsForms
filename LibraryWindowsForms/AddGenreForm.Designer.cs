namespace LibraryWindowsForms
{
    partial class AddGenreForm
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
            this.buttonAddGenre = new System.Windows.Forms.Button();
            this.textBoxAddGenre = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelIsError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddGenre
            // 
            this.buttonAddGenre.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddGenre.Location = new System.Drawing.Point(229, 12);
            this.buttonAddGenre.Name = "buttonAddGenre";
            this.buttonAddGenre.Size = new System.Drawing.Size(75, 28);
            this.buttonAddGenre.TabIndex = 5;
            this.buttonAddGenre.Text = "Add";
            this.buttonAddGenre.UseVisualStyleBackColor = true;
            this.buttonAddGenre.Click += new System.EventHandler(this.buttonAddGenre_Click);
            // 
            // textBoxAddGenre
            // 
            this.textBoxAddGenre.Location = new System.Drawing.Point(12, 18);
            this.textBoxAddGenre.Name = "textBoxAddGenre";
            this.textBoxAddGenre.Size = new System.Drawing.Size(202, 20);
            this.textBoxAddGenre.TabIndex = 4;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 2);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(111, 13);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Enter the title of genre";
            // 
            // labelIsError
            // 
            this.labelIsError.AutoSize = true;
            this.labelIsError.Location = new System.Drawing.Point(12, 41);
            this.labelIsError.Name = "labelIsError";
            this.labelIsError.Size = new System.Drawing.Size(0, 13);
            this.labelIsError.TabIndex = 7;
            // 
            // AddGenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 59);
            this.Controls.Add(this.labelIsError);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonAddGenre);
            this.Controls.Add(this.textBoxAddGenre);
            this.Name = "AddGenreForm";
            this.Text = "AddGenreForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddGenre;
        private System.Windows.Forms.TextBox textBoxAddGenre;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelIsError;
    }
}