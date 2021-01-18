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
        public Form1()
        {
            InitializeComponent();
        }

        Task task;
        private void Createbutton_Click(object sender, EventArgs e)
        {
            task = new Task(Convert.ToInt32(ReadtextBox.Text));
            ArraytextBox.Text = task.PrintArray();
        }

        private void ChetSumButton_Click(object sender, EventArgs e)
        { 
            OutputtextBox.Text = task.ChetSum(ArraytextBox.Text.Length);
            ArraytextBox.Text = task.PrintArray();
        }

        private void NeChetbutton_Click(object sender, EventArgs e)
        {
            OutputtextBox.Text = task.ChetSum();
            ArraytextBox.Text = task.PrintArray();
        }
    }
}
