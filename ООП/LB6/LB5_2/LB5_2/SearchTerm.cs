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
            List<int> tempTerm = new List<int>();
            if (TermSearchCheckBox1.Checked)
                tempTerm.Add(1);
            if (TermSearchCheckBox2.Checked)
                tempTerm.Add(2);
            foreach (Subject subject in callingForm.subjectsCopy)
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

            callingForm.subjects.Clear();
            callingForm.subjects.AddRange(result);
            callingForm.UpdateList();
            Close();
        }
    }
}
