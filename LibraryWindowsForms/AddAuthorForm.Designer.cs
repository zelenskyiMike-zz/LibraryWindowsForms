namespace LibraryWindowsForms
{
    partial class AddAuthorForm
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
            this.textBoxAddAuthor = new System.Windows.Forms.TextBox();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.labelAddAuthor = new System.Windows.Forms.Label();
            this.labelIsError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAddAuthor
            // 
            this.textBoxAddAuthor.Location = new System.Drawing.Point(12, 17);
            this.textBoxAddAuthor.Name = "textBoxAddAuthor";
            this.textBoxAddAuthor.Size = new System.Drawing.Size(202, 20);
            this.textBoxAddAuthor.TabIndex = 2;
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAuthor.Location = new System.Drawing.Point(229, 11);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(75, 28);
            this.buttonAddAuthor.TabIndex = 3;
            this.buttonAddAuthor.Text = "Add";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // labelAddAuthor
            // 
            this.labelAddAuthor.AutoSize = true;
            this.labelAddAuthor.Location = new System.Drawing.Point(12, 1);
            this.labelAddAuthor.Name = "labelAddAuthor";
            this.labelAddAuthor.Size = new System.Drawing.Size(125, 13);
            this.labelAddAuthor.TabIndex = 4;
            this.labelAddAuthor.Text = "Enter the name of Author";
            // 
            // labelIsError
            // 
            this.labelIsError.AutoSize = true;
            this.labelIsError.Location = new System.Drawing.Point(12, 40);
            this.labelIsError.Name = "labelIsError";
            this.labelIsError.Size = new System.Drawing.Size(0, 13);
            this.labelIsError.TabIndex = 5;
            // 
            // AddAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 59);
            this.Controls.Add(this.labelIsError);
            this.Controls.Add(this.labelAddAuthor);
            this.Controls.Add(this.buttonAddAuthor);
            this.Controls.Add(this.textBoxAddAuthor);
            this.Name = "AddAuthorForm";
            this.Text = "AddAuthorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxAddAuthor;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.Label labelAddAuthor;
        private System.Windows.Forms.Label labelIsError;
    }
}