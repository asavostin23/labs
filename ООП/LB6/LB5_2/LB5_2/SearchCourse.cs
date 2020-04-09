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
    public partial class SearchCourse : Form
    {
        Form4 callingForm;
        public SearchCourse()
        {
            InitializeComponent();
        }
        public SearchCourse(Form4 form) : this() => callingForm = form;

        private void CourseSearchButton_Click(object sender, EventArgs e)
        {
            HashSet<Subject> result = new HashSet<Subject>();
            //List<int> tempCourse = new List<int>();
            Data data = new Data(); 
            if (CourseSearchCheckBox1.Checked)
                data.tempCourse.Add(1);
            if (CourseSearchCheckBox2.Checked)
                data.tempCourse.Add(2);
            if (CourseSearchCheckBox3.Checked)
                data.tempCourse.Add(3);
            if (CourseSearchCheckBox4.Checked)
                data.tempCourse.Add(4);

            var results = new List<ValidationResult>();
            var context = new ValidationContext(data);
            if (!Validator.TryValidateObject(data, context, results, true))
            {
                CourseSearchCheckBox1.BackColor = Color.Red;
                CourseSearchCheckBox2.BackColor = Color.Red;
                CourseSearchCheckBox3.BackColor = Color.Red;
                CourseSearchCheckBox4.BackColor = Color.Red;
            }
            else
            {
                foreach (Subject subject in callingForm.subjectsCopy)
                    foreach (var i in data.tempCourse)
                        if (subject.Course.Contains(i))
                        {
                            result.Add(subject);
                            break;
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
            public List<int> tempCourse { get; set; }
            public Data() => tempCourse = new List<int>();
        }
    }
}
