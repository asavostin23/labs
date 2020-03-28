using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB5_2
{
    public partial class Form4 : Form
    {
        public List<Subject> subjects;
        public List<Subject> subjectsCopy;
        public Form4()
        {
            InitializeComponent();
            subjects = new List<Subject>();
            subjectsCopy = new List<Subject>();
        }
        public Form4(List<Subject> subjects)
        {
            InitializeComponent();
            this.subjects = subjects;
            subjectsCopy = new List<Subject>();
            foreach (var i in subjects)
                //subjectsCopy.Add((Subject)i.Clone());
                subjectsCopy.Add(i);
        }
        public Form4(List<Subject> subjects, List<Subject> subjectsCopy)
        {
            InitializeComponent();
            this.subjects = subjects;
            this.subjectsCopy = subjectsCopy;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            foreach (var i in subjects)
                SubjectsListBox.Items.Add(i);
            StripSubjectCount.Text = subjects.Count.ToString();
            StripDatetime.Text = DateTime.Now.ToString();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler((send, evArgs) => StripDatetime.Text = DateTime.Now.ToString());
            timer.Start();
            LoadFromJson();
        }
        public void RestoreSubjectsFromCopy()
        {
            subjects.Clear();
            subjects.AddRange(subjectsCopy);
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void поЛекторуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StripLastOperation.Text = "Поиск по лектору";
            new SearchLecturer(this).ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new Form1(this).ShowDialog();
            StripLastOperation.Text = "Добавить";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (SubjectsListBox.SelectedIndex >= 0)
            {
                subjectsCopy.Remove(subjects[SubjectsListBox.SelectedIndex]);///
                subjects.RemoveAt(SubjectsListBox.SelectedIndex);
            }
            StripLastOperation.Text = "Удалить";
            UpdateList();
        }

        private void SubjectsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void UpdateList()
        {
            SubjectsListBox.Items.Clear();
            foreach (var i in subjects)
                SubjectsListBox.Items.Add(i.Name);
            StripSubjectCount.Text = subjects.Count.ToString();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            subjectsCopy.Clear();
            RestoreSubjectsFromCopy();
            StripLastOperation.Text = "Очистить";
            UpdateList();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (SubjectsListBox.SelectedIndex >= 0)
            {
                int selectedIndex = SubjectsListBox.SelectedIndex;
                Subject temp = subjects[selectedIndex];
                subjectsCopy.Remove(temp);//////////////////////////////////////серилизация создает копии обьектов, а не ссылки!
                subjects.RemoveAt(selectedIndex);
                UpdateList();
                new Form1(this, temp).ShowDialog();
                StripLastOperation.Text = "Изменить";
            }
        }

        private void поСеместруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StripLastOperation.Text = "Поиск по семестру";
            new SearchTerm(this).ShowDialog();
        }

        private void поКурсуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StripLastOperation.Text = "Поиск по курсу";
        }

        private void количествуЛекцийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StripLastOperation.Text = "Сортировка по количеству лекций";
            RestoreSubjectsFromCopy();
            var selected = from t in subjects orderby t.LectureCount select t;
            List<Subject> temp = new List<Subject>(selected);
            subjects.Clear();
            subjects.AddRange(temp);
            UpdateList();
        }

        private void видуКонтроляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StripLastOperation.Text = "Сортировка по виду контроля";
            RestoreSubjectsFromCopy();
            var selected = subjects.OrderBy(q =>
            {
                if (q.TypeControl == TypeControlEnum.Exam)
                    return 1;
                else return 2;
            });
            List<Subject> temp = new List<Subject>(selected);
            subjects.Clear();
            subjects.AddRange(temp);
            UpdateList();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StripLastOperation.Text = "Сохранить";

            string subjectsString = JsonSerializer.Serialize<List<Subject>>(subjects);
            string subjectsCopyString = JsonSerializer.Serialize<List<Subject>>(subjectsCopy);
            using (StreamWriter sw = new StreamWriter(@"D:\data.json", false, System.Text.Encoding.Unicode))
            {
                sw.WriteLine(subjectsString);
                sw.WriteLine(subjectsCopyString);
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StripLastOperation.Text = "О программе";
            new AboutForm().ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void ShowSubjectsCopyButton_Click(object sender, EventArgs e)
        {
            SubjectsListBox.Items.Clear();
            foreach (var i in subjectsCopy)
                SubjectsListBox.Items.Add(i.Name);
            StripSubjectCount.Text = subjects.Count.ToString();
        }

        private void панельИнструментовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            LoadFromJson();
        }
        private void LoadFromJson()
        {
            string subjectsString, subjectsCopyString;
            using (StreamReader sr = new StreamReader(@"D:\data.json"))
            {
                subjectsString = sr.ReadLine();
                subjectsCopyString = sr.ReadLine();
            }

            subjectsCopy = JsonSerializer.Deserialize<List<Subject>>(subjectsCopyString);
            List<Subject> temp = JsonSerializer.Deserialize<List<Subject>>(subjectsString);
            subjects.Clear();
            foreach (Subject s1 in temp)
                foreach (Subject s2 in subjectsCopy)
                    if (s1.Equals(s2))
                    {
                        subjects.Add(s1);
                        break;
                    }
            UpdateList();
        }
    }
}
