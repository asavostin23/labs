namespace LB5
{
    partial class Form2
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.PatronymicLabel = new System.Windows.Forms.Label();
            this.PatronymicBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.DateOfBirthCalendar = new System.Windows.Forms.MonthCalendar();
            this.PulpitLabel = new System.Windows.Forms.Label();
            this.PulpitComboBox = new System.Windows.Forms.ComboBox();
            this.AuditoriumLabel = new System.Windows.Forms.Label();
            this.AuditoriumBox = new System.Windows.Forms.TextBox();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.SalaryTrackBar = new System.Windows.Forms.TrackBar();
            this.ExperienceLabel = new System.Windows.Forms.Label();
            this.ExperienceBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.PhoneMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.LecturerSaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(36, 19);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 21);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Имя:";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(36, 43);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(329, 23);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SurnameLabel.Location = new System.Drawing.Point(36, 69);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(78, 21);
            this.SurnameLabel.TabIndex = 2;
            this.SurnameLabel.Text = "Фамилия:";
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(36, 93);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(329, 23);
            this.SurnameBox.TabIndex = 3;
            // 
            // PatronymicLabel
            // 
            this.PatronymicLabel.AutoSize = true;
            this.PatronymicLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatronymicLabel.Location = new System.Drawing.Point(36, 119);
            this.PatronymicLabel.Name = "PatronymicLabel";
            this.PatronymicLabel.Size = new System.Drawing.Size(80, 21);
            this.PatronymicLabel.TabIndex = 4;
            this.PatronymicLabel.Text = "Отчество:";
            // 
            // PatronymicBox
            // 
            this.PatronymicBox.Location = new System.Drawing.Point(36, 143);
            this.PatronymicBox.Name = "PatronymicBox";
            this.PatronymicBox.Size = new System.Drawing.Size(329, 23);
            this.PatronymicBox.TabIndex = 5;
            this.PatronymicBox.TextChanged += new System.EventHandler(this.PatronymicBox_TextChanged);
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateOfBirthLabel.Location = new System.Drawing.Point(36, 169);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(124, 21);
            this.DateOfBirthLabel.TabIndex = 6;
            this.DateOfBirthLabel.Text = "Дата рождения:";
            // 
            // DateOfBirthCalendar
            // 
            this.DateOfBirthCalendar.Location = new System.Drawing.Point(36, 199);
            this.DateOfBirthCalendar.Name = "DateOfBirthCalendar";
            this.DateOfBirthCalendar.ShowTodayCircle = false;
            this.DateOfBirthCalendar.TabIndex = 7;
            // 
            // PulpitLabel
            // 
            this.PulpitLabel.AutoSize = true;
            this.PulpitLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PulpitLabel.Location = new System.Drawing.Point(36, 370);
            this.PulpitLabel.Name = "PulpitLabel";
            this.PulpitLabel.Size = new System.Drawing.Size(75, 21);
            this.PulpitLabel.TabIndex = 8;
            this.PulpitLabel.Text = "Кафедра:";
            // 
            // PulpitComboBox
            // 
            this.PulpitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PulpitComboBox.FormattingEnabled = true;
            this.PulpitComboBox.Items.AddRange(new object[] {
            "Кафедра информационных систем и технологий",
            "Кафедра программной инженерии",
            "Кафедра информатики и веб-дизайна"});
            this.PulpitComboBox.Location = new System.Drawing.Point(36, 394);
            this.PulpitComboBox.Name = "PulpitComboBox";
            this.PulpitComboBox.Size = new System.Drawing.Size(329, 23);
            this.PulpitComboBox.TabIndex = 9;
            this.PulpitComboBox.SelectedIndexChanged += new System.EventHandler(this.PulpitComboBox_SelectedIndexChanged);
            // 
            // AuditoriumLabel
            // 
            this.AuditoriumLabel.AutoSize = true;
            this.AuditoriumLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AuditoriumLabel.Location = new System.Drawing.Point(36, 420);
            this.AuditoriumLabel.Name = "AuditoriumLabel";
            this.AuditoriumLabel.Size = new System.Drawing.Size(91, 21);
            this.AuditoriumLabel.TabIndex = 10;
            this.AuditoriumLabel.Text = "Аудитория:";
            // 
            // AuditoriumBox
            // 
            this.AuditoriumBox.Location = new System.Drawing.Point(36, 444);
            this.AuditoriumBox.Name = "AuditoriumBox";
            this.AuditoriumBox.Size = new System.Drawing.Size(329, 23);
            this.AuditoriumBox.TabIndex = 11;
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalaryLabel.Location = new System.Drawing.Point(36, 470);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(83, 21);
            this.SalaryLabel.TabIndex = 12;
            this.SalaryLabel.Text = "Зарплата: ";
            // 
            // SalaryTrackBar
            // 
            this.SalaryTrackBar.Location = new System.Drawing.Point(38, 495);
            this.SalaryTrackBar.Maximum = 5000;
            this.SalaryTrackBar.Name = "SalaryTrackBar";
            this.SalaryTrackBar.Size = new System.Drawing.Size(329, 45);
            this.SalaryTrackBar.TabIndex = 13;
            this.SalaryTrackBar.TickFrequency = 1000;
            // 
            // ExperienceLabel
            // 
            this.ExperienceLabel.AutoSize = true;
            this.ExperienceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExperienceLabel.Location = new System.Drawing.Point(38, 543);
            this.ExperienceLabel.Name = "ExperienceLabel";
            this.ExperienceLabel.Size = new System.Drawing.Size(50, 21);
            this.ExperienceLabel.TabIndex = 14;
            this.ExperienceLabel.Text = "Стаж:";
            // 
            // ExperienceBox
            // 
            this.ExperienceBox.Location = new System.Drawing.Point(36, 567);
            this.ExperienceBox.Name = "ExperienceBox";
            this.ExperienceBox.Size = new System.Drawing.Size(329, 23);
            this.ExperienceBox.TabIndex = 15;
            this.ExperienceBox.TextChanged += new System.EventHandler(this.ExperienceBox_TextChanged);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneLabel.Location = new System.Drawing.Point(36, 593);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(74, 21);
            this.PhoneLabel.TabIndex = 16;
            this.PhoneLabel.Text = "Телефон:";
            // 
            // PhoneMaskedBox
            // 
            this.PhoneMaskedBox.Location = new System.Drawing.Point(36, 617);
            this.PhoneMaskedBox.Mask = "000-00-00";
            this.PhoneMaskedBox.Name = "PhoneMaskedBox";
            this.PhoneMaskedBox.Size = new System.Drawing.Size(331, 23);
            this.PhoneMaskedBox.TabIndex = 17;
            this.PhoneMaskedBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.PhoneMaskedBox_MaskInputRejected);
            // 
            // LecturerSaveButton
            // 
            this.LecturerSaveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LecturerSaveButton.Location = new System.Drawing.Point(141, 646);
            this.LecturerSaveButton.Name = "LecturerSaveButton";
            this.LecturerSaveButton.Size = new System.Drawing.Size(117, 42);
            this.LecturerSaveButton.TabIndex = 18;
            this.LecturerSaveButton.Text = "Сохранить";
            this.LecturerSaveButton.UseVisualStyleBackColor = true;
            this.LecturerSaveButton.Click += new System.EventHandler(this.LecturerSaveButton_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(407, 725);
            this.Controls.Add(this.LecturerSaveButton);
            this.Controls.Add(this.PhoneMaskedBox);
            this.Controls.Add(this.ExperienceBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.ExperienceLabel);
            this.Controls.Add(this.SalaryLabel);
            this.Controls.Add(this.AuditoriumBox);
            this.Controls.Add(this.PulpitLabel);
            this.Controls.Add(this.AuditoriumLabel);
            this.Controls.Add(this.PulpitComboBox);
            this.Controls.Add(this.DateOfBirthCalendar);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.PatronymicBox);
            this.Controls.Add(this.PatronymicLabel);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SalaryTrackBar);
            this.Name = "Form2";
            this.Text = "Лектор";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalaryTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.Label PatronymicLabel;
        private System.Windows.Forms.TextBox PatronymicBox;
        //private System.Windows.Forms.Label DateBirth;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.MonthCalendar DateOfBirthCalendar;
        private System.Windows.Forms.Label PulpitLabel;
        private System.Windows.Forms.ComboBox PulpitComboBox;
        private System.Windows.Forms.Label AuditoriumLabel;
        private System.Windows.Forms.TextBox AuditoriumBox;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.TrackBar SalaryTrackBar;//
        private System.Windows.Forms.Label ExperienceLabel;
        private System.Windows.Forms.TextBox ExperienceBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedBox;
        private System.Windows.Forms.Button LecturerSaveButton;
        //private System.Windows.Forms.Timer timer1;
    }
}