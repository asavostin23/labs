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

            var results = new List<ValidationResult>();
            var context = new ValidationContext(data);
            if (!Validator.TryValidateObject(data, context, results, true))
            {

                foreach (var error in results)
                {
                    //Console.WriteLine(error.ErrorMessage);
                }
            }
            else
            {

                HashSet<Subject> result, result2;
                if (data.searchQuery != "")
                {
                    result = new HashSet<Subject>();

                    Regex fioSearch = new Regex($@"{data.searchQuery}",RegexOptions.IgnoreCase);//^
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


                    tempTerm.Sort();
                    foreach (Subject subject in result2)
                    {
                        bool check = true;
                        if (subject.Term.Count == tempTerm.Count)
                        {
                            for (int i = 0; i < subject.Term.Count; i++)
                                if (subject.Term[i] != tempTerm[i])
                                {
                                    check = false;
                                    break;
                                }
                        }
                        else check = false;
                        if (check)
                            result.Add(subject);
                    }
                }
                else
                    result = new HashSet<Subject>(result2);

                if (data.additionalQuery != "")
                {
                    result2 = new HashSet<Subject>();

                    Regex fioSearch = new Regex(@"[" + data.additionalQuery + "]+", RegexOptions.IgnoreCase);
                    foreach (Subject subject in result)
                    {
                        foreach (Lecturer lecturer in subject.Lecturers)
                        {
                            if ((fioSearch.Matches(lecturer.Name).Count +
                                fioSearch.Matches(lecturer.Surname).Count +
                                fioSearch.Matches(lecturer.Patronymic).Count) > 0)
                            {
                                result2.Add(subject);
                                break;
                            }
                        }
                    }
                }
                else
                    result2 = new HashSet<Subject>(result);


                callingForm.subjects.Clear();
                callingForm.subjects.AddRange(result2);
                callingForm.UpdateList();
                Close();
            }
        }
        


    }
    public class ExtendedSearchData
    {

        [StringLength(100)]
        [RegularExpression(@"[а-я|А-Я]*")]
        public string searchQuery { get; set; }

        [StringLength(100)]
        [RegularExpression(@"\s*[1-2]{1}\s*(,\s*[1-2]{1}\s*)?")]
        public string termString { get; set; }


        [StringLength(100)]
        [RegularExpression(@"\s*\d{1}\s*(,\s*\d{1}\s*){0,3}")]
        public string courseString { get; set; }


        [RegularExpression(@"[A-Z|a-z|а-я|А-Я]*")]
        [StringLength(100)]
        public string additionalQuery { get; set; }

        public ExtendedSearchData(string searchQuery, string termString, string courseString, string additionalQuery)
        {
            this.searchQuery = searchQuery;
            this.termString = termString;
            this.courseString = courseString;
            this.additionalQuery = additionalQuery;
        }
    }
}
