namespace LB4_2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GenerationButton = new System.Windows.Forms.Button();
            this.CollectionListBox = new System.Windows.Forms.ListBox();
            this.RequestListBox = new System.Windows.Forms.ListBox();
            this.SortAscButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RequestOneButton = new System.Windows.Forms.Button();
            this.RequestTwoButton = new System.Windows.Forms.Button();
            this.RequestThreeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Размер коллекции";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GenerationButton
            // 
            this.GenerationButton.Location = new System.Drawing.Point(162, 29);
            this.GenerationButton.Name = "GenerationButton";
            this.GenerationButton.Size = new System.Drawing.Size(107, 53);
            this.GenerationButton.TabIndex = 2;
            this.GenerationButton.Text = "Сгенерировать коллекцию";
            this.GenerationButton.UseVisualStyleBackColor = true;
            this.GenerationButton.Click += new System.EventHandler(this.GenerationButton_Click);
            // 
            // CollectionListBox
            // 
            this.CollectionListBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CollectionListBox.FormattingEnabled = true;
            this.CollectionListBox.ItemHeight = 15;
            this.CollectionListBox.Location = new System.Drawing.Point(30, 121);
            this.CollectionListBox.Name = "CollectionListBox";
            this.CollectionListBox.Size = new System.Drawing.Size(333, 529);
            this.CollectionListBox.TabIndex = 3;
            this.CollectionListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // RequestListBox
            // 
            this.RequestListBox.FormattingEnabled = true;
            this.RequestListBox.ItemHeight = 15;
            this.RequestListBox.Location = new System.Drawing.Point(426, 121);
            this.RequestListBox.Name = "RequestListBox";
            this.RequestListBox.Size = new System.Drawing.Size(333, 529);
            this.RequestListBox.TabIndex = 4;
            this.RequestListBox.SelectedIndexChanged += new System.EventHandler(this.RequestListBox_SelectedIndexChanged);
            // 
            // SortAscButton
            // 
            this.SortAscButton.Location = new System.Drawing.Point(288, 29);
            this.SortAscButton.Name = "SortAscButton";
            this.SortAscButton.Size = new System.Drawing.Size(107, 53);
            this.SortAscButton.TabIndex = 5;
            this.SortAscButton.Text = "Сортировать по возрастанию";
            this.SortAscButton.UseVisualStyleBackColor = true;
            this.SortAscButton.Click += new System.EventHandler(this.SortAscButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сортировать по убыванию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RequestOneButton
            // 
            this.RequestOneButton.Location = new System.Drawing.Point(803, 121);
            this.RequestOneButton.Name = "RequestOneButton";
            this.RequestOneButton.Size = new System.Drawing.Size(93, 53);
            this.RequestOneButton.TabIndex = 7;
            this.RequestOneButton.Text = "Запрос 1";
            this.RequestOneButton.UseVisualStyleBackColor = true;
            this.RequestOneButton.Click += new System.EventHandler(this.RequestOneButton_Click);
            // 
            // RequestTwoButton
            // 
            this.RequestTwoButton.Location = new System.Drawing.Point(803, 193);
            this.RequestTwoButton.Name = "RequestTwoButton";
            this.RequestTwoButton.Size = new System.Drawing.Size(93, 53);
            this.RequestTwoButton.TabIndex = 8;
            this.RequestTwoButton.Text = "Запрос 2";
            this.RequestTwoButton.UseVisualStyleBackColor = true;
            this.RequestTwoButton.Click += new System.EventHandler(this.RequestTwoButton_Click);
            // 
            // RequestThreeButton
            // 
            this.RequestThreeButton.Location = new System.Drawing.Point(803, 266);
            this.RequestThreeButton.Name = "RequestThreeButton";
            this.RequestThreeButton.Size = new System.Drawing.Size(93, 53);
            this.RequestThreeButton.TabIndex = 9;
            this.RequestThreeButton.Text = "Запрос 3";
            this.RequestThreeButton.UseVisualStyleBackColor = true;
            this.RequestThreeButton.Click += new System.EventHandler(this.RequestThreeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 681);
            this.Controls.Add(this.RequestThreeButton);
            this.Controls.Add(this.RequestTwoButton);
            this.Controls.Add(this.RequestOneButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SortAscButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RequestListBox);
            this.Controls.Add(this.CollectionListBox);
            this.Controls.Add(this.GenerationButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "LB4_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GenerationButton;
        private System.Windows.Forms.ListBox CollectionListBox;
        private System.Windows.Forms.ListBox RequestListBox;
        private System.Windows.Forms.Button SortAscButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RequestOneButton;
        private System.Windows.Forms.Button RequestTwoButton;
        private System.Windows.Forms.Button RequestThreeButton;
    }
}

