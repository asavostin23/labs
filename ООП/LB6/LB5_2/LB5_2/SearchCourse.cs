using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            List<int> tempCourse = new List<int>();
            if (CourseSearchCheckBox1.Checked)
                tempCourse.Add(1);
            if (CourseSearchCheckBox2.Checked)
                tempCourse.Add(2);
            if (CourseSearchCheckBox3.Checked)
                tempCourse.Add(3);
            if (CourseSearchCheckBox4.Checked)
                tempCourse.Add(4);
            foreach (Subject subject in callingForm.subjectsCopy)
                foreach (var i in tempCourse)
                    if(subject.Course.Contains(i))
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
}
