using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB5_2
{
    public partial class SearchLecturer : Form
    {
        private SearchLecturer()
        {
            InitializeComponent();
        }
        public SearchLecturer(Form4 form4) : this()
        {
            callingForm = form4;
        }
        Form4 callingForm;
        private void SearchLecturerButton_Click(object sender, EventArgs e)
        {
            HashSet<Subject> result = new HashSet<Subject>();

            Data data = new Data(SearchLecturerBox.Text);
            var results = new List<ValidationResult>();
            var context = new ValidationContext(data);
            if (!Validator.TryValidateObject(data, context, results, true))
            {
                SearchLecturerBox.BackColor = Color.Red;
            }
            else
            {
                Regex fioSearch = new Regex($@"^{SearchLecturerBox.Text}");
                foreach (Subject subject in callingForm.subjectsCopy)
                {
                    foreach (Lecturer lecturer in subject.Lecturers)
                    {
                        if ((fioSearch.Matches(lecturer.Name).Count +
                            fioSearch.Matches(lecturer.Surname).Count +
                            fioSearch.Matches(lecturer.Patronymic).Count) > 0)
                        {
                            result.Add(subject);
                            break;
                        }

                    }
                }
                callingForm.subjects.Clear();
                callingForm.subjects.AddRange(result);
                callingForm.UpdateList();
                Close();
            }
        }
        class Data
        {
            [Required]
            [RegularExpression(@"[а-я|А-Я]+")]
            public string text { get; set; }

            public Data(string text) => this.text = text;
        }

        
    }
    
}
