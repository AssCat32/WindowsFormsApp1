using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int size;
        int sizeList;
        List<InterfaceIndex> listBox;
        public event myDelegate event1;
        public event myDelegate2 event2;

        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            listBox = new List<InterfaceIndex>();
            int first = rand.Next(5, 10);
            int second = rand.Next(5, 10);
            for (int i = 0; i < first; ++i)
            {
                listBox.Add(new Task(rand.Next(10, 20)));
            }
            for (int i = 0; i < second; ++i)
            {
                listBox.Add(new SecondTask(rand.Next(10, 20)));
            }

            foreach (var item in listBox)
            {
                listBoxClasses.Items.Add(item);
            }
        }

        Task task1;
        SecondTask task2;
        private void Createbutton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ReadtextBox.Text) < 10)
            {
                size = rand.Next(10, 20);
                ReadtextBox.Text = Convert.ToString(size);
            }
            else
            {
                size = Convert.ToInt32(ReadtextBox.Text);
            }
            task1 = new Task(Convert.ToInt32(size));
            ArraytextBox.Text = PrintArray(task1);
        }

        private void ChetSumButton_Click(object sender, EventArgs e)
        {
            OutputtextBox.Text = task1.ChetSum(ArraytextBox.Text.Length);
            ArraytextBox.Text = PrintArray(task1);
        }

        private void NeChetbutton_Click(object sender, EventArgs e)
        {
            OutputtextBox.Text = task1.ChetSum();
            ArraytextBox.Text = PrintArray(task1);
        }

        private string PrintArray(InterfaceIndex e)
        {
            string str = "";
            for (int i = 0; i < size; ++i)
            {
                str += e[i];
            }
            return str;
        }

        private void CreatebuttonList_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ReadtextBox.Text) < 10)
            {
                sizeList = rand.Next(10, 20);
                ReadtextBox.Text = Convert.ToString(size);
            }
            else
            {
                sizeList = Convert.ToInt32(ReadtextBox.Text);
            }
            task2 = new SecondTask(sizeList);
            ArraytextBox.Text = PrintArray(task2);
        }

        private void ChetbuttonList_Click(object sender, EventArgs e)
        {
            OutputtextBox.Text = task2.ChetSum(ArraytextBox.Text.Length);
            ArraytextBox.Text = PrintArray(task2);
        }

        private void NeChetbuttonList_Click(object sender, EventArgs e)
        {
            OutputtextBox.Text = task2.ChetSum();
            ArraytextBox.Text = PrintArray(task2);
        }

        private void InsertFirstM_Click(object sender, EventArgs e)
        {
            event1 += listBox.ElementAt(listBoxClasses.SelectedIndex).ChetSum;
        }

        private void DeleteFirstM_Click(object sender, EventArgs e)
        {
            event1 -= listBox.ElementAt(listBoxClasses.SelectedIndex).ChetSum;
        }

        private void InsertSecondM_Click(object sender, EventArgs e)
        {
            event2 += listBox.ElementAt(listBoxClasses.SelectedIndex).ChetSum;
        }

        private void DeleteSecondM_Click(object sender, EventArgs e)
        {
            event2 -= listBox.ElementAt(listBoxClasses.SelectedIndex).ChetSum;
        }

        private void EventFirst_Click(object sender, EventArgs e)
        {
            richTextBox.Text += event1?.Invoke(Convert.ToInt32(ReadtextBox.Text)) + "\n";
        }

        private void EventSecond_Click(object sender, EventArgs e)
        {
            richTextBox.Text += event2?.Invoke() + "\n";
        }
    }
}
