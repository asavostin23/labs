using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LB5
{
    public partial class Form2 : Form
    {
        private Lecturer lecturer;
        private Form1 callingForm;
        public Lecturer GetLecturer() => lecturer;

        public Form2(Form1 form, Lecturer lecturerObj) : this(form)
        {
            //InitializeComponent();
            //callingForm = form;

            lecturer = lecturerObj;


            NameBox.Text = lecturer.Name;
            SurnameBox.Text = lecturer.Surname;
            PatronymicBox.Text = lecturer.Patronymic;
            PulpitComboBox.Text = lecturer.Pulpit;
            SalaryTrackBar.Value = lecturer.Salary;
            PhoneMaskedBox.Text = lecturer.Phone;
            AuditoriumBox.Text = lecturer.Auditorium;
            DateOfBirthCalendar.SelectionStart = DateTime.Parse(lecturer.DateOfBirth);
            DateOfBirthCalendar.SelectionEnd = DateOfBirthCalendar.SelectionStart;
            ExperienceBox.Text = lecturer.Experience.ToString();
            SalaryLabel.Text = "Зарплата: " + SalaryTrackBar.Value;

            NameBox.Tag = true;
            SurnameBox.Tag = true;
            PatronymicBox.Tag = true;
            DateOfBirthCalendar.Tag = true;
            PulpitComboBox.Tag = true;
            AuditoriumBox.Tag = true;
            SalaryTrackBar.Tag = true;
            ExperienceBox.Tag = true;
            PhoneMaskedBox.Tag = true;
        }
        public Form2(Form1 form) : this()
        {
            callingForm = form;
        }
        public Form2()
        {

            InitializeComponent();
            if (lecturer == null)
                lecturer = new Lecturer();


            SalaryTrackBar.Scroll += SalaryTrackBar_Scroll;

            //LecturerSaveButton.Enabled = false;

            NameBox.Tag = false;
            SurnameBox.Tag = false;
            PatronymicBox.Tag = false;
            DateOfBirthCalendar.Tag = false;
            PulpitComboBox.Tag = false;
            AuditoriumBox.Tag = false;
            SalaryTrackBar.Tag = false;
            ExperienceBox.Tag = false;
            PhoneMaskedBox.Tag = false;

            NameBox.Validating += new System.ComponentModel.CancelEventHandler(TextBoxEmpty_Validating);
            SurnameBox.Validating += new System.ComponentModel.CancelEventHandler(TextBoxEmpty_Validating);
            PatronymicBox.Validating += new System.ComponentModel.CancelEventHandler(TextBoxEmpty_Validating);
            AuditoriumBox.Validating += new System.ComponentModel.CancelEventHandler(TextBoxEmpty_Validating);
            ExperienceBox.Validating += new System.ComponentModel.CancelEventHandler(TextBoxEmpty_Validating);
            PhoneMaskedBox.Validating += new System.ComponentModel.CancelEventHandler(MaskedTextBoxEmpty_Validating);
            PulpitComboBox.Validating += new System.ComponentModel.CancelEventHandler(ComboBoxEmpty_Validating);
            SalaryTrackBar.Validating += new CancelEventHandler(
                (sender, e) =>
                {
                    TrackBar tb = (TrackBar)sender;
                    if (tb.Value >= 0)
                        tb.Tag = true;
                    ValidateSave();
                }
                );
            DateOfBirthCalendar.Validating += new CancelEventHandler(CalendarEmpty_Validating);

            NameBox.KeyPress += NoNums_KeyPress;
            SurnameBox.KeyPress += NoNums_KeyPress;
            PatronymicBox.KeyPress += NoNums_KeyPress;
            ExperienceBox.KeyPress += (sender, e) =>
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                    e.Handled = true;
            };
            PhoneMaskedBox.KeyUp += (sender, e) =>
            {
                MaskedTextBox tb = (MaskedTextBox)sender;
                tb.Tag = tb.MaskCompleted;
                if (tb.MaskCompleted)
                    tb.BackColor = System.Drawing.SystemColors.Window;
                ValidateSave();
            };

            DateOfBirthCalendar.DateChanged += (sender, e) =>
            {
                if (DateOfBirthCalendar.SelectionStart >= DateOfBirthCalendar.TodayDate)
                    new Form3().ShowDialog();
            };
        }
        private void NoNums_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar < 48 || e.KeyChar > 57)
&& e.KeyChar != 8))
                e.Handled = true;
        }
        private void ValidateSave()
        {
            // Активизирует кнопку ОК, если значения всех свойств Tags — true.
            LecturerSaveButton.Enabled = ((bool)(NameBox.Tag) &&
            (bool)(SurnameBox.Tag) &&
            (bool)(PatronymicBox.Tag) &&
            (bool)(DateOfBirthCalendar.Tag) &&
            (bool)(PulpitComboBox.Tag) &&
            (bool)(AuditoriumBox.Tag) &&
            (bool)(SalaryTrackBar.Tag) &&
            (bool)(ExperienceBox.Tag) &&
            (bool)(PhoneMaskedBox.Tag)
            );
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
        private void MaskedTextBoxEmpty_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MaskedTextBox tb = (MaskedTextBox)sender;

            if (!tb.MaskCompleted)
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
        private void ComboBoxEmpty_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ComboBox tb = (ComboBox)sender;
            if (tb.SelectedItem == null)
            {
                //tb.BackColor = Color.Red;
                tb.Tag = false;
            }
            else
            {
                //tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }
            ValidateSave();
        }
        private void CalendarEmpty_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MonthCalendar tb = (MonthCalendar)sender;
            if (tb.SelectionStart == null || tb.SelectionStart >= tb.TodayDate)
            {
                //tb.BackColor = Color.Red;
                tb.Tag = false;
            }
            else
            {

                //tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }
            ValidateSave();
        }

        private void PulpitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PatronymicBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void SalaryTrackBar_Scroll(object sender, EventArgs e)
        {
            SalaryLabel.Text = "Зарплата: " + SalaryTrackBar.Value;
        }

        private void ExperienceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneMaskedBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void LecturerSaveButton_Click(object sender, EventArgs e)
        {
            lecturer.Name = NameBox.Text;
            lecturer.Surname = SurnameBox.Text;
            lecturer.Patronymic = PatronymicBox.Text;
            lecturer.Pulpit = PulpitComboBox.Text;
            lecturer.Salary = SalaryTrackBar.Value;
            lecturer.Phone = PhoneMaskedBox.Text;
            lecturer.Auditorium = AuditoriumBox.Text;
            lecturer.DateOfBirth = DateOfBirthCalendar.SelectionStart.ToLongDateString();
            lecturer.Experience = int.Parse(ExperienceBox.Text);

            callingForm.subject.Lecturers.Add(lecturer);
            Close();
            //new Form2(callingForm, lecturer).ShowDialog();
        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
