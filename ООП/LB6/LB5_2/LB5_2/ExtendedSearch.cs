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
    public partial class ExtendedSearch : Form
    {
        private ExtendedSearch()
        {
            InitializeComponent();
        }
        Form4 callingForm;
        public ExtendedSearch(Form4 form4) : this()
        {
            callingForm = form4;
        }



        private void SearchButton_Click(object sender, EventArgs e)
        {
            ExtendedSearchData data = new ExtendedSearchData(
                SearchBox.Text,
                TermBox.Text,
                CourseBox.Text,
                AdditionalSearchBox.Text
                );
            HashSet<Subject> result, result2;
            if (data.searchQuery != "")
            {
                result = new HashSet<Subject>();

                Regex fioSearch = new Regex($@"^{data.searchQuery}");
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
            }
            else
                result = new HashSet<Subject>(callingForm.subjectsCopy);

            Regex digitRegex = new Regex(@"(\d{1})");
            if (data.courseString != "")
            {
                result2 = new HashSet<Subject>();
                List<int> tempCourse = new List<int>();

                
                var courseMathes = digitRegex.Matches(data.courseString);
                foreach (var i in courseMathes)
                    tempCourse.Add(int.Parse(i.ToString()));

                foreach (Subject subject in result)
                    foreach (var i in tempCourse)
                        if (subject.Course.Contains(i))
                        {
                            result2.Add(subject);
                            break;
                        }
            }
            else
                result2 = new HashSet<Subject>(result);

            if (data.termString != "")
            {
                result = new HashSet<Subject>();
                List<int> tempTerm = new List<int>();
                var termMathes = digitRegex.Matches(data.termString);
                foreach (var i in termMathes)
                    tempTerm.Add(int.Parse(i.ToString()));

                foreach (Subject subject in result2)
                    foreach (var i in tempTerm)
                        if (subject.Term.Contains(i))
                        {
                            result.Add(subject);
                            break;
                        }

            }
            else
                result = new HashSet<Subject>(result2);


            callingForm.subjects.Clear();
            callingForm.subjects.AddRange(result);
            callingForm.UpdateList();
            Close();
        }
        class ExtendedSearchData
        {
            
            [StringLength(100, MinimumLength = 3)]
            [RegularExpression(@"[A-Z|a-z|а-я|А-Я]*")]
            public string searchQuery;

            
            [StringLength(100)]
            [RegularExpression(@"\s*\d{1}\s*,\s*\d{1}\s*")]
            public string termString;

            
            [StringLength(100)]
            [RegularExpression(@"\s*\d{1}\s*,\s*\d{1}\s*,\s*\d{1}\s*,\s*\d{1}\s*")]
            public string courseString;

            [StringLength(100)]
            [RegularExpression(@"[A-Z|a-z|а-я|А-Я]*")]
            public string additionalQuery;

            public ExtendedSearchData(string searchQuery, string termString, string courseString, string additionalQuery)
            {
                this.searchQuery = searchQuery;
                this.termString = termString;
                this.courseString = courseString; 
                this.additionalQuery = additionalQuery;
            }
        }


    }
}
