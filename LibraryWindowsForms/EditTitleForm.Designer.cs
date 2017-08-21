namespace LibraryWindowsForms
{
    partial class EditTitleForm
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
            this.textBoxTitleOfBookValue = new System.Windows.Forms.TextBox();
            this.buttonEditTitle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTitleOfBookValue
            // 
            this.textBoxTitleOfBookValue.Location = new System.Drawing.Point(13, 19);
            this.textBoxTitleOfBookValue.Name = "textBoxTitleOfBookValue";
            this.textBoxTitleOfBookValue.Size = new System.Drawing.Size(247, 20);
            this.textBoxTitleOfBookValue.TabIndex = 0;
            // 
            // buttonEditTitle
            // 
            this.buttonEditTitle.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditTitle.Location = new System.Drawing.Point(279, 12);
            this.buttonEditTitle.Name = "buttonEditTitle";
            this.buttonEditTitle.Size = new System.Drawing.Size(85, 31);
            this.buttonEditTitle.TabIndex = 1;
            this.buttonEditTitle.Text = "Edit";
            this.buttonEditTitle.UseVisualStyleBackColor = true;
            this.buttonEditTitle.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditTitleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 56);
            this.Controls.Add(this.buttonEditTitle);
            this.Controls.Add(this.textBoxTitleOfBookValue);
            this.Name = "EditTitleForm";
            this.Text = "EditTitleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitleOfBookValue;
        private System.Windows.Forms.Button buttonEditTitle;
    }
}