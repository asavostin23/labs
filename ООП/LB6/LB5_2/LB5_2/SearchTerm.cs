using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB5_2
{
    public partial class SearchTerm : Form
    {
        Form4 callingForm;
        public SearchTerm()
        {
            InitializeComponent();
        }
        public SearchTerm(Form4 form) : this() => callingForm = form;

        private void TermSearchButton_Click(object sender, EventArgs e)
        {
            HashSet<Subject> result = new HashSet<Subject>();
            Data data = new Data();
            if (TermSearchCheckBox1.Checked)
                data.tempTerm.Add(1);
            if (TermSearchCheckBox2.Checked)
                data.tempTerm.Add(2);

            var results = new List<ValidationResult>();
            var context = new ValidationContext(data);
            if (!Validator.TryValidateObject(data, context, results, true))
            {
                TermSearchCheckBox1.BackColor = Color.Red;
                TermSearchCheckBox2.BackColor = Color.Red;
            }
            else
            {

                foreach (Subject subject in callingForm.subjectsCopy)
                {
                    bool check = true;
                    if (subject.Term.Count == data.tempTerm.Count)
                    {
                        for (int i = 0; i < subject.Term.Count; i++)
                            if (subject.Term[i] != data.tempTerm[i])
                            {
                                check = false;
                                break;
                            }
                    }
                    else check = false;
                    if (check)
                        result.Add(subject);
                }

                callingForm.subjects.Clear();
                callingForm.subjects.AddRange(result);
                callingForm.UpdateList();
                Close();
            }
        }
        class Data
        {
            [ListValidation]
            public List<int> tempTerm { get;set; }
            public Data() => tempTerm = new List<int>();
        }
    }
    public class ListValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value is List<int> list && list.Count > 0;
        }
    }
}
