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
        public Form1()
        {
            InitializeComponent();
        }

        Task task1;
        SecondTask task2;
        private void Createbutton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
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
            Random rand = new Random();
            if (Convert.ToInt32(ReadtextBox.Text) < 10)
            {
                size = rand.Next(10, 20);
                ReadtextBox.Text = Convert.ToString(size);
            }
            else
            {
                size = Convert.ToInt32(ReadtextBox.Text);
            }
            task2 = new SecondTask(size);
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
    }
}
