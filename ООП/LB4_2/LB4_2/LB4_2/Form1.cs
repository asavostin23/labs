using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Rectangle> list;
        int listSize = 0;
        
        private void ShowList()
        {
            CollectionListBox.Items.Clear();
            foreach (var i in list)
                CollectionListBox.Items.Add("Квадрат, сторона = " + i.side.ToString());
        }
        private void ShowRequest(IEnumerable<Rectangle> enumerable)
        {
            RequestListBox.Items.Clear();
            foreach (var i in enumerable)
                RequestListBox.Items.Add("Квадрат, сторона = " + i.side.ToString());
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void GenerationButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            list = new List<Rectangle>();
            for (int i = 0; i < listSize; i++)
                list.Add(new Rectangle(rnd.Next(0, 100)));
            ShowList();
        }
       
        private void SortAscButton_Click(object sender, EventArgs e)
        {
            list.Sort(new RectangleComparer());
            ShowList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.Sort(new RectangleComparerDesc());
            ShowList();
        }

        private void RequestListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RequestOneButton_Click(object sender, EventArgs e)
        {
            ShowRequest(list.Where<Rectangle>(t => (t.side >= 10) && (t.side <= 30))); // От 10 до 30
        }

        private void RequestTwoButton_Click(object sender, EventArgs e)
        {
            RequestListBox.Items.Clear();
            RequestListBox.Items.Add("Количество элементов = " + list.Count());
        }

        private void RequestThreeButton_Click(object sender, EventArgs e)
        {
            ShowRequest(list.OrderByDescending(r => r.side).Take<Rectangle>(5));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                listSize = int.Parse(textBox1.Text);
                if (listSize < 0 || listSize > 35)
                    listSize = 0;
            }
            catch (FormatException ex) { listSize = 0; }
        }
    }
}
