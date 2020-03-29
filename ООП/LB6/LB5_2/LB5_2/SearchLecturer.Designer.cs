namespace LB5_2
{
    partial class SearchLecturer
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
            this.SearchLecturerBox = new System.Windows.Forms.TextBox();
            this.SearchLecturerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchLecturerBox
            // 
            this.SearchLecturerBox.Location = new System.Drawing.Point(30, 32);
            this.SearchLecturerBox.MaxLength = 70;
            this.SearchLecturerBox.Name = "SearchLecturerBox";
            this.SearchLecturerBox.Size = new System.Drawing.Size(490, 20);
            this.SearchLecturerBox.TabIndex = 0;
            // 
            // SearchLecturerButton
            // 
            this.SearchLecturerButton.Location = new System.Drawing.Point(539, 32);
            this.SearchLecturerButton.Name = "SearchLecturerButton";
            this.SearchLecturerButton.Size = new System.Drawing.Size(75, 20);
            this.SearchLecturerButton.TabIndex = 1;
            this.SearchLecturerButton.Text = "Поиск";
            this.SearchLecturerButton.UseVisualStyleBackColor = true;
            this.SearchLecturerButton.Click += new System.EventHandler(this.SearchLecturerButton_Click);
            // 
            // SearchLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 73);
            this.Controls.Add(this.SearchLecturerButton);
            this.Controls.Add(this.SearchLecturerBox);
            this.Name = "SearchLecturer";
            this.Text = "Поиск по лектору";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchLecturerBox;
        private System.Windows.Forms.Button SearchLecturerButton;
    }
}