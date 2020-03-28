namespace LB5_2
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЛекторуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поСеместруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поКурсуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаПоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествуЛекцийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видуКонтроляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.SubjectsListBox = new System.Windows.Forms.ListBox();
            this.Strip = new System.Windows.Forms.StatusStrip();
            this.StripSubjectCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StripDatetime = new System.Windows.Forms.ToolStripStatusLabel();
            this.StripLastOperation = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.ShowSubjectsCopyButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.сортировкаПоToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1047, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поЛекторуToolStripMenuItem,
            this.поСеместруToolStripMenuItem,
            this.поКурсуToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // поЛекторуToolStripMenuItem
            // 
            this.поЛекторуToolStripMenuItem.Name = "поЛекторуToolStripMenuItem";
            this.поЛекторуToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.поЛекторуToolStripMenuItem.Text = "по лектору";
            this.поЛекторуToolStripMenuItem.Click += new System.EventHandler(this.поЛекторуToolStripMenuItem_Click);
            // 
            // поСеместруToolStripMenuItem
            // 
            this.поСеместруToolStripMenuItem.Name = "поСеместруToolStripMenuItem";
            this.поСеместруToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.поСеместруToolStripMenuItem.Text = "по семестру";
            this.поСеместруToolStripMenuItem.Click += new System.EventHandler(this.поСеместруToolStripMenuItem_Click);
            // 
            // поКурсуToolStripMenuItem
            // 
            this.поКурсуToolStripMenuItem.Name = "поКурсуToolStripMenuItem";
            this.поКурсуToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.поКурсуToolStripMenuItem.Text = "по курсу";
            this.поКурсуToolStripMenuItem.Click += new System.EventHandler(this.поКурсуToolStripMenuItem_Click);
            // 
            // сортировкаПоToolStripMenuItem
            // 
            this.сортировкаПоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.количествуЛекцийToolStripMenuItem,
            this.видуКонтроляToolStripMenuItem});
            this.сортировкаПоToolStripMenuItem.Name = "сортировкаПоToolStripMenuItem";
            this.сортировкаПоToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.сортировкаПоToolStripMenuItem.Text = "Сортировка по";
            
            // 
            // количествуЛекцийToolStripMenuItem
            // 
            this.количествуЛекцийToolStripMenuItem.Name = "количествуЛекцийToolStripMenuItem";
            this.количествуЛекцийToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.количествуЛекцийToolStripMenuItem.Text = "количеству лекций";
            this.количествуЛекцийToolStripMenuItem.Click += new System.EventHandler(this.количествуЛекцийToolStripMenuItem_Click);
            // 
            // видуКонтроляToolStripMenuItem
            // 
            this.видуКонтроляToolStripMenuItem.Name = "видуКонтроляToolStripMenuItem";
            this.видуКонтроляToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.видуКонтроляToolStripMenuItem.Text = "виду контроля";
            this.видуКонтроляToolStripMenuItem.Click += new System.EventHandler(this.видуКонтроляToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.ShowSubjectsCopyButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1047, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripButton1.Text = "Добавить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(63, 22);
            this.toolStripButton2.Text = "Очистить";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(55, 22);
            this.toolStripButton3.Text = "Удалить";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(65, 22);
            this.toolStripButton4.Text = "Изменить";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // SubjectsListBox
            // 
            this.SubjectsListBox.FormattingEnabled = true;
            this.SubjectsListBox.Location = new System.Drawing.Point(13, 70);
            this.SubjectsListBox.Name = "SubjectsListBox";
            this.SubjectsListBox.Size = new System.Drawing.Size(984, 485);
            this.SubjectsListBox.TabIndex = 3;
            this.SubjectsListBox.SelectedIndexChanged += new System.EventHandler(this.SubjectsListBox_SelectedIndexChanged);
            // 
            // Strip
            // 
            this.Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripSubjectCount,
            this.toolStripStatusLabel2,
            this.StripDatetime,
            this.StripLastOperation});
            this.Strip.Location = new System.Drawing.Point(0, 643);
            this.Strip.Name = "Strip";
            this.Strip.Size = new System.Drawing.Size(1047, 22);
            this.Strip.TabIndex = 4;
            this.Strip.Text = "statusStrip1";
            // 
            // StripSubjectCount
            // 
            this.StripSubjectCount.Name = "StripSubjectCount";
            this.StripSubjectCount.Size = new System.Drawing.Size(118, 17);
            this.StripSubjectCount.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // StripDatetime
            // 
            this.StripDatetime.Name = "StripDatetime";
            this.StripDatetime.Size = new System.Drawing.Size(118, 17);
            this.StripDatetime.Text = "toolStripStatusLabel3";
            // 
            // StripLastOperation
            // 
            this.StripLastOperation.Name = "StripLastOperation";
            this.StripLastOperation.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(65, 22);
            this.toolStripButton5.Text = "Обновить";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // ShowSubjectsCopyButton
            // 
            this.ShowSubjectsCopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ShowSubjectsCopyButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowSubjectsCopyButton.Image")));
            this.ShowSubjectsCopyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowSubjectsCopyButton.Name = "ShowSubjectsCopyButton";
            this.ShowSubjectsCopyButton.Size = new System.Drawing.Size(112, 22);
            this.ShowSubjectsCopyButton.Text = "ShowSubjectsCopy";
            this.ShowSubjectsCopyButton.Click += new System.EventHandler(this.ShowSubjectsCopyButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 665);
            this.Controls.Add(this.Strip);
            this.Controls.Add(this.SubjectsListBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Дисциплины";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Strip.ResumeLayout(false);
            this.Strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЛекторуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поСеместруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поКурсуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаПоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествуЛекцийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видуКонтроляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ListBox SubjectsListBox;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.StatusStrip Strip;
        private System.Windows.Forms.ToolStripStatusLabel StripSubjectCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel StripDatetime;
        private System.Windows.Forms.ToolStripStatusLabel StripLastOperation;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton ShowSubjectsCopyButton;
    }
}