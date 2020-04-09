namespace LB5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLabel = new System.Windows.Forms.Label();
            this.TermLabel = new System.Windows.Forms.Label();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.LectureCountLabel = new System.Windows.Forms.Label();
            this.LaboratoryCountLabel = new System.Windows.Forms.Label();
            this.TypeControlLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.TermListBox = new System.Windows.Forms.CheckedListBox();
            this.CourseListBox = new System.Windows.Forms.CheckedListBox();
            this.LectureCountBox = new System.Windows.Forms.TextBox();
            this.LaboratoryCountBox = new System.Windows.Forms.TextBox();
            this.ExamRadioButton = new System.Windows.Forms.RadioButton();
            this.CreditRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(29, 23);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(175, 21);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Название дисциплины:";
            // 
            // TermLabel
            // 
            this.TermLabel.AutoSize = true;
            this.TermLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TermLabel.Location = new System.Drawing.Point(29, 73);
            this.TermLabel.Name = "TermLabel";
            this.TermLabel.Size = new System.Drawing.Size(73, 21);
            this.TermLabel.TabIndex = 1;
            this.TermLabel.Text = "Семестр:";
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CourseLabel.Location = new System.Drawing.Point(120, 73);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(46, 21);
            this.CourseLabel.TabIndex = 2;
            this.CourseLabel.Text = "Курс:";
            // 
            // LectureCountLabel
            // 
            this.LectureCountLabel.AutoSize = true;
            this.LectureCountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LectureCountLabel.Location = new System.Drawing.Point(29, 186);
            this.LectureCountLabel.Name = "LectureCountLabel";
            this.LectureCountLabel.Size = new System.Drawing.Size(152, 21);
            this.LectureCountLabel.TabIndex = 3;
            this.LectureCountLabel.Text = "Количество лекций:";
            // 
            // LaboratoryCountLabel
            // 
            this.LaboratoryCountLabel.AutoSize = true;
            this.LaboratoryCountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LaboratoryCountLabel.Location = new System.Drawing.Point(29, 236);
            this.LaboratoryCountLabel.Name = "LaboratoryCountLabel";
            this.LaboratoryCountLabel.Size = new System.Drawing.Size(203, 21);
            this.LaboratoryCountLabel.TabIndex = 4;
            this.LaboratoryCountLabel.Text = "Количество лабораторных:";
            // 
            // TypeControlLabel
            // 
            this.TypeControlLabel.AutoSize = true;
            this.TypeControlLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeControlLabel.Location = new System.Drawing.Point(29, 287);
            this.TypeControlLabel.Name = "TypeControlLabel";
            this.TypeControlLabel.Size = new System.Drawing.Size(110, 21);
            this.TypeControlLabel.TabIndex = 5;
            this.TypeControlLabel.Text = "Тип контроля:";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(29, 47);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(231, 23);
            this.NameBox.TabIndex = 6;
            // 
            // TermListBox
            // 
            this.TermListBox.FormattingEnabled = true;
            this.TermListBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.TermListBox.Location = new System.Drawing.Point(29, 97);
            this.TermListBox.Name = "TermListBox";
            this.TermListBox.Size = new System.Drawing.Size(46, 40);
            this.TermListBox.TabIndex = 7;
            // 
            // CourseListBox
            // 
            this.CourseListBox.FormattingEnabled = true;
            this.CourseListBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CourseListBox.Location = new System.Drawing.Point(120, 97);
            this.CourseListBox.Name = "CourseListBox";
            this.CourseListBox.Size = new System.Drawing.Size(46, 76);
            this.CourseListBox.TabIndex = 8;
            this.CourseListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // LectureCountBox
            // 
            this.LectureCountBox.Location = new System.Drawing.Point(29, 210);
            this.LectureCountBox.Name = "LectureCountBox";
            this.LectureCountBox.Size = new System.Drawing.Size(203, 23);
            this.LectureCountBox.TabIndex = 9;
            // 
            // LaboratoryCountBox
            // 
            this.LaboratoryCountBox.Location = new System.Drawing.Point(29, 261);
            this.LaboratoryCountBox.Name = "LaboratoryCountBox";
            this.LaboratoryCountBox.Size = new System.Drawing.Size(100, 23);
            this.LaboratoryCountBox.TabIndex = 10;
            // 
            // ExamRadioButton
            // 
            this.ExamRadioButton.AutoSize = true;
            this.ExamRadioButton.Location = new System.Drawing.Point(29, 321);
            this.ExamRadioButton.Name = "ExamRadioButton";
            this.ExamRadioButton.Size = new System.Drawing.Size(71, 19);
            this.ExamRadioButton.TabIndex = 11;
            this.ExamRadioButton.TabStop = true;
            this.ExamRadioButton.Text = "Экзамен";
            this.ExamRadioButton.UseVisualStyleBackColor = true;
            // 
            // CreditRadioButton
            // 
            this.CreditRadioButton.AutoSize = true;
            this.CreditRadioButton.Location = new System.Drawing.Point(29, 347);
            this.CreditRadioButton.Name = "CreditRadioButton";
            this.CreditRadioButton.Size = new System.Drawing.Size(56, 19);
            this.CreditRadioButton.TabIndex = 12;
            this.CreditRadioButton.TabStop = true;
            this.CreditRadioButton.Text = "Зачет";
            this.CreditRadioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 704);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CreditRadioButton);
            this.Controls.Add(this.ExamRadioButton);
            this.Controls.Add(this.TypeControlLabel);
            this.Controls.Add(this.LaboratoryCountBox);
            this.Controls.Add(this.LaboratoryCountLabel);
            this.Controls.Add(this.LectureCountBox);
            this.Controls.Add(this.LectureCountLabel);
            this.Controls.Add(this.CourseListBox);
            this.Controls.Add(this.CourseLabel);
            this.Controls.Add(this.TermListBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.TermLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Учебный отдел";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TermLabel;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.Label LectureCountLabel;
        private System.Windows.Forms.Label LaboratoryCountLabel;
        private System.Windows.Forms.Label TypeControlLabel;
        private System.Windows.Forms.Label NameLabel;
        //private System.Windows.Forms.Label Labar;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.CheckedListBox TermListBox;
        private System.Windows.Forms.CheckedListBox CourseListBox;
        private System.Windows.Forms.TextBox LectureCountBox;
        private System.Windows.Forms.TextBox LaboratoryCountBox;
        private System.Windows.Forms.RadioButton ExamRadioButton;
        private System.Windows.Forms.RadioButton CreditRadioButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

