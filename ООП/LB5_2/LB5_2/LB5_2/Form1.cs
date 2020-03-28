using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace LB5_2
{
    public enum ProfessionEnum
    {
        ISiT,
        POIT,
        DEVI,
        POIBMS
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            subject = new Subject();

            SubjectSaveButton.Enabled = false;
            NameBox.Tag = false;
            LectureCountBox.Tag = false;
            LaboratoryCountBox.Tag = false;
            TermListBox.Tag = false;
            CourseListBox.Tag = false;
            ExamRadioButton.Tag = false;
            CreditRadioButton.Tag = false;

            NameBox.KeyPress += NoNums_KeyPress;
            LectureCountBox.KeyPress += (sender, e) =>
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                    e.Handled = true;
            };
            LaboratoryCountBox.KeyPress += (sender, e) =>
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                    e.Handled = true;
            };

            NameBox.Validating += new CancelEventHandler(TextBoxEmpty_Validating);
            LectureCountBox.Validating += new CancelEventHandler(TextBoxEmpty_Validating);
            LaboratoryCountBox.Validating += new CancelEventHandler(TextBoxEmpty_Validating);
            TermListBox.Validating += new CancelEventHandler(ListBoxEmpty_Validating);
            CourseListBox.Validating += new CancelEventHandler(ListBoxEmpty_Validating);

            ExamRadioButton.MouseUp += (sender, e) =>
            {
                RadioButton tb = (RadioButton)sender;
                tb.Tag = tb.Checked;
                if (tb.Checked)
                    ValidateSave();
            };
            CreditRadioButton.MouseUp += (sender, e) =>
            {
                RadioButton tb = (RadioButton)sender;
                tb.Tag = tb.Checked;
                if (tb.Checked)
                    ValidateSave();
            };

            DataGridView.AllowUserToAddRows = false;
            var SurnameColumn = new DataGridViewColumn();
            SurnameColumn.HeaderText = "Фамилия"; //текст в шапке
            SurnameColumn.Width = 150; //ширина колонки
            SurnameColumn.ReadOnly = true; //значение в этой колонке нельзя править
            SurnameColumn.Name = "SurnameColumn"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            SurnameColumn.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            SurnameColumn.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
            var NameColumn = new DataGridViewColumn();
            NameColumn.HeaderText = "Имя";
            NameColumn.Name = "NameColumn";
            NameColumn.CellTemplate = new DataGridViewTextBoxCell();
            NameColumn.Width = 100;
            NameColumn.ReadOnly = true;
            var PatronymicColumn = new DataGridViewColumn();
            PatronymicColumn.HeaderText = "Отчество";
            PatronymicColumn.Name = "PatronymicColumn";
            PatronymicColumn.CellTemplate = new DataGridViewTextBoxCell();
            PatronymicColumn.Width = 100;
            PatronymicColumn.ReadOnly = true;
            var PulpitColumn = new DataGridViewColumn();
            PulpitColumn.HeaderText = "Кафедра";
            PulpitColumn.Name = "PulpitColumn";
            PulpitColumn.CellTemplate = new DataGridViewTextBoxCell();
            PulpitColumn.Width = 300;
            PulpitColumn.ReadOnly = true;
            var AuditoriumColumn = new DataGridViewColumn();
            AuditoriumColumn.HeaderText = "Аудитория";
            AuditoriumColumn.Name = "AuditoriumColumn";
            AuditoriumColumn.CellTemplate = new DataGridViewTextBoxCell();
            AuditoriumColumn.ReadOnly = true;
            var DateOfBirthColumn = new DataGridViewColumn();
            DateOfBirthColumn.HeaderText = "Дата рождения";
            DateOfBirthColumn.Name = "DateOfBirthColumn";
            DateOfBirthColumn.CellTemplate = new DataGridViewTextBoxCell();
            DateOfBirthColumn.Width = 200;
            DateOfBirthColumn.ReadOnly = true;
            var SalaryColumn = new DataGridViewColumn();
            SalaryColumn.HeaderText = "Зарплата";
            SalaryColumn.Name = "SalaryColumn";
            SalaryColumn.CellTemplate = new DataGridViewTextBoxCell();
            SalaryColumn.ReadOnly = true;
            var ExperienceColumn = new DataGridViewColumn();
            ExperienceColumn.HeaderText = "Стаж";
            ExperienceColumn.Name = "ExperienceColumn";
            ExperienceColumn.CellTemplate = new DataGridViewTextBoxCell();
            ExperienceColumn.ReadOnly = true;
            var PhoneColumn = new DataGridViewColumn();
            PhoneColumn.HeaderText = "Телефон";
            PhoneColumn.Name = "PhoneColumn";
            PhoneColumn.CellTemplate = new DataGridViewTextBoxCell();
            PhoneColumn.ReadOnly = true;
            DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView.Columns.Add(SurnameColumn);
            DataGridView.Columns.Add(NameColumn);
            DataGridView.Columns.Add(PatronymicColumn);
            DataGridView.Columns.Add(PulpitColumn);
            DataGridView.Columns.Add(AuditoriumColumn);
            DataGridView.Columns.Add(DateOfBirthColumn);
            DataGridView.Columns.Add(SalaryColumn);
            DataGridView.Columns.Add(ExperienceColumn);
            DataGridView.Columns.Add(PhoneColumn);

            UpdateTable();
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        subject.Lecturers.RemoveAt(e.RowIndex);
        //        UpdateTable();
        //    }
        //}
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                new Form2(this, subject.Lecturers[e.RowIndex]).ShowDialog();
                subject.Lecturers.RemoveAt(e.RowIndex);//
                UpdateTable();
            }
        }

        private void ListBoxEmpty_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckedListBox tb = (CheckedListBox)sender;
            if (tb.CheckedItems.Count == 0)
            {
                tb.BackColor = Color.Red;
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }
            ValidateSave();
        }
        private void RadioEmpty_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            RadioButton tb = (RadioButton)sender;
            tb.Tag = tb.Checked;
            ValidateSave();
        }
        private void NoNums_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar < 48 || e.KeyChar > 57) || e.KeyChar == 8))
                e.Handled = true;
        }
        private void TextBoxEmpty_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }
            ValidateSave();
        }
        private void ValidateSave()
        {
            // Активизирует кнопку ОК, если значения всех свойств Tags — true.
            SubjectSaveButton.Enabled = ((bool)(NameBox.Tag) &&
            (bool)(TermListBox.Tag) &&
            (bool)(CourseListBox.Tag) &&
            (bool)(LectureCountBox.Tag) &&
            (bool)(LaboratoryCountBox.Tag)
            &&
            (
            (bool)(ExamRadioButton.Checked) ||
            (bool)(CreditRadioButton.Checked))
            );
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            new Form2(this).ShowDialog();
        }



        public Subject subject { get; set; }
        public void UpdateTable()
        {
            DataGridView.Rows.Clear();
            foreach (var i in subject.Lecturers)
            {

                DataGridView.Rows.Add(
                    i.Surname,
                    i.Name,
                    i.Patronymic,
                    i.Pulpit,
                    i.Auditorium,
                    i.DateOfBirth.ToString(),
                    i.Salary,
                    i.Experience,
                    i.Phone
                    );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2(this, this.subject.Lecturers[0]).ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SubjectSaveButton_Click(object sender, EventArgs e)
        {
            List<Lecturer> lecturersTemp = subject.Lecturers;
            subject = new Subject();/////////
            subject.Lecturers = lecturersTemp;

            subject.Name = NameBox.Text;
            foreach (var i in TermListBox.CheckedItems)
                subject.Term.Add(int.Parse(i.ToString()));
            foreach (var i in CourseListBox.CheckedItems)
                subject.Course.Add(int.Parse(i.ToString()));
            subject.LectureCount = int.Parse(LectureCountBox.Text);
            subject.LaboratoryCount = int.Parse(LaboratoryCountBox.Text);
            subject.TypeControl = (ExamRadioButton.Checked) ? TypeControlEnum.Exam : TypeControlEnum.Credit;

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json = JsonSerializer.Serialize<Subject>(subject);
            using (StreamWriter sw = new StreamWriter(@"D:\data.json", false, System.Text.Encoding.Unicode))
            {
                sw.WriteLine(json);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string json;
            using (StreamReader sr = new StreamReader(@"D:\data.json"))
            {
                json = sr.ReadToEnd();
            }
            subject = JsonSerializer.Deserialize<Subject>(json);

            SubjectSaveButton.Enabled = true;
            NameBox.Tag = true;
            LectureCountBox.Tag = true;
            LaboratoryCountBox.Tag = true;
            TermListBox.Tag = true;
            CourseListBox.Tag = true;
            ExamRadioButton.Tag = true;
            CreditRadioButton.Tag = true;

            NameBox.Text = subject.Name;
            
            foreach(var i in subject.Term)
            {
                TermListBox.SetItemChecked(i - 1,true);
            }
            foreach (var i in subject.Course)
            {
                CourseListBox.SetItemChecked(i - 1, true);
            }
            //foreach (var i in subject.Course)
            //{
            //    CourseListBox.SelectedItems.Add(i);
            //    //TermListBox.Items = i.ToString();
            //    //CourseListBox.Items.Add(i);
            //    //subject.Term.Add(int.Parse(i.ToString()));
            //}
            LectureCountBox.Text = subject.LectureCount.ToString();
            LaboratoryCountBox.Text = subject.LaboratoryCount.ToString();
            if (subject.TypeControl == TypeControlEnum.Exam)
                ExamRadioButton.Checked = true;
            else
                CreditRadioButton.Checked = true;

            UpdateTable();
            NameBox.BackColor = System.Drawing.SystemColors.Window;
        }
    }
}
