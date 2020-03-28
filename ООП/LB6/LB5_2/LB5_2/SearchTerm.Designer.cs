namespace LB5_2
{
    partial class SearchTerm
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
            this.TermSearchCheckBox1 = new System.Windows.Forms.CheckBox();
            this.TermSearchCheckBox2 = new System.Windows.Forms.CheckBox();
            this.TermSearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TermSearchCheckBox1
            // 
            this.TermSearchCheckBox1.AutoSize = true;
            this.TermSearchCheckBox1.Location = new System.Drawing.Point(28, 28);
            this.TermSearchCheckBox1.Name = "TermSearchCheckBox1";
            this.TermSearchCheckBox1.Size = new System.Drawing.Size(32, 17);
            this.TermSearchCheckBox1.TabIndex = 0;
            this.TermSearchCheckBox1.Text = "1";
            this.TermSearchCheckBox1.UseVisualStyleBackColor = true;
            // 
            // TermSearchCheckBox2
            // 
            this.TermSearchCheckBox2.AutoSize = true;
            this.TermSearchCheckBox2.Location = new System.Drawing.Point(28, 52);
            this.TermSearchCheckBox2.Name = "TermSearchCheckBox2";
            this.TermSearchCheckBox2.Size = new System.Drawing.Size(32, 17);
            this.TermSearchCheckBox2.TabIndex = 1;
            this.TermSearchCheckBox2.Text = "2";
            this.TermSearchCheckBox2.UseVisualStyleBackColor = true;
            // 
            // TermSearchButton
            // 
            this.TermSearchButton.Location = new System.Drawing.Point(82, 28);
            this.TermSearchButton.Name = "TermSearchButton";
            this.TermSearchButton.Size = new System.Drawing.Size(94, 41);
            this.TermSearchButton.TabIndex = 2;
            this.TermSearchButton.Text = "Поиск";
            this.TermSearchButton.UseVisualStyleBackColor = true;
            this.TermSearchButton.Click += new System.EventHandler(this.TermSearchButton_Click);
            // 
            // SearchTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 114);
            this.Controls.Add(this.TermSearchButton);
            this.Controls.Add(this.TermSearchCheckBox2);
            this.Controls.Add(this.TermSearchCheckBox1);
            this.Name = "SearchTerm";
            this.Text = "Поиск по семестру";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox TermSearchCheckBox1;
        private System.Windows.Forms.CheckBox TermSearchCheckBox2;
        private System.Windows.Forms.Button TermSearchButton;
    }
}