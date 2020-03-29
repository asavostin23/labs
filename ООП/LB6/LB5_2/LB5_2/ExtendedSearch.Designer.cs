namespace LB5_2
{
    partial class ExtendedSearch
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
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AdditionalSearchBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CourseBox = new System.Windows.Forms.TextBox();
            this.TermBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(27, 38);
            this.SearchBox.MaxLength = 100;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(481, 20);
            this.SearchBox.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(27, 191);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 20);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Курс";
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Семестр";
            // 
            // AdditionalSearchBox
            // 
            this.AdditionalSearchBox.Location = new System.Drawing.Point(27, 165);
            this.AdditionalSearchBox.MaxLength = 100;
            this.AdditionalSearchBox.Name = "AdditionalSearchBox";
            this.AdditionalSearchBox.Size = new System.Drawing.Size(481, 20);
            this.AdditionalSearchBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ФИО имеет символы...";
            // 
            // CourseBox
            // 
            this.CourseBox.Location = new System.Drawing.Point(27, 77);
            this.CourseBox.Name = "CourseBox";
            this.CourseBox.Size = new System.Drawing.Size(481, 20);
            this.CourseBox.TabIndex = 9;
            // 
            // TermBox
            // 
            this.TermBox.Location = new System.Drawing.Point(27, 116);
            this.TermBox.Name = "TermBox";
            this.TermBox.Size = new System.Drawing.Size(481, 20);
            this.TermBox.TabIndex = 10;
            // 
            // ExtendedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 251);
            this.Controls.Add(this.TermBox);
            this.Controls.Add(this.CourseBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AdditionalSearchBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Name = "ExtendedSearch";
            this.Text = "Расиширенный поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AdditionalSearchBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CourseBox;
        private System.Windows.Forms.TextBox TermBox;
    }
}