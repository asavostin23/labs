namespace LB5_2
{
    partial class SearchCourse
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
            this.CourseSearchCheckBox1 = new System.Windows.Forms.CheckBox();
            this.CourseSearchCheckBox2 = new System.Windows.Forms.CheckBox();
            this.CourseSearchCheckBox3 = new System.Windows.Forms.CheckBox();
            this.CourseSearchCheckBox4 = new System.Windows.Forms.CheckBox();
            this.CourseSearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CourseSearchCheckBox1
            // 
            this.CourseSearchCheckBox1.AutoSize = true;
            this.CourseSearchCheckBox1.Location = new System.Drawing.Point(35, 41);
            this.CourseSearchCheckBox1.Name = "CourseSearchCheckBox1";
            this.CourseSearchCheckBox1.Size = new System.Drawing.Size(32, 17);
            this.CourseSearchCheckBox1.TabIndex = 0;
            this.CourseSearchCheckBox1.Text = "1";
            this.CourseSearchCheckBox1.UseVisualStyleBackColor = true;
            // 
            // CourseSearchCheckBox2
            // 
            this.CourseSearchCheckBox2.AutoSize = true;
            this.CourseSearchCheckBox2.Location = new System.Drawing.Point(35, 65);
            this.CourseSearchCheckBox2.Name = "CourseSearchCheckBox2";
            this.CourseSearchCheckBox2.Size = new System.Drawing.Size(32, 17);
            this.CourseSearchCheckBox2.TabIndex = 1;
            this.CourseSearchCheckBox2.Text = "2";
            this.CourseSearchCheckBox2.UseVisualStyleBackColor = true;
            // 
            // CourseSearchCheckBox3
            // 
            this.CourseSearchCheckBox3.AutoSize = true;
            this.CourseSearchCheckBox3.Location = new System.Drawing.Point(35, 89);
            this.CourseSearchCheckBox3.Name = "CourseSearchCheckBox3";
            this.CourseSearchCheckBox3.Size = new System.Drawing.Size(32, 17);
            this.CourseSearchCheckBox3.TabIndex = 2;
            this.CourseSearchCheckBox3.Text = "3";
            this.CourseSearchCheckBox3.UseVisualStyleBackColor = true;
            // 
            // CourseSearchCheckBox4
            // 
            this.CourseSearchCheckBox4.AutoSize = true;
            this.CourseSearchCheckBox4.Location = new System.Drawing.Point(35, 113);
            this.CourseSearchCheckBox4.Name = "CourseSearchCheckBox4";
            this.CourseSearchCheckBox4.Size = new System.Drawing.Size(32, 17);
            this.CourseSearchCheckBox4.TabIndex = 3;
            this.CourseSearchCheckBox4.Text = "4";
            this.CourseSearchCheckBox4.UseVisualStyleBackColor = true;
            // 
            // CourseSearchButton
            // 
            this.CourseSearchButton.Location = new System.Drawing.Point(35, 136);
            this.CourseSearchButton.Name = "CourseSearchButton";
            this.CourseSearchButton.Size = new System.Drawing.Size(75, 23);
            this.CourseSearchButton.TabIndex = 4;
            this.CourseSearchButton.Text = "Поиск";
            this.CourseSearchButton.UseVisualStyleBackColor = true;
            this.CourseSearchButton.Click += new System.EventHandler(this.CourseSearchButton_Click);
            // 
            // SearchCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 209);
            this.Controls.Add(this.CourseSearchButton);
            this.Controls.Add(this.CourseSearchCheckBox4);
            this.Controls.Add(this.CourseSearchCheckBox3);
            this.Controls.Add(this.CourseSearchCheckBox2);
            this.Controls.Add(this.CourseSearchCheckBox1);
            this.Name = "SearchCourse";
            this.Text = "Поиск по курсу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CourseSearchCheckBox1;
        private System.Windows.Forms.CheckBox CourseSearchCheckBox2;
        private System.Windows.Forms.CheckBox CourseSearchCheckBox3;
        private System.Windows.Forms.CheckBox CourseSearchCheckBox4;
        private System.Windows.Forms.Button CourseSearchButton;
    }
}