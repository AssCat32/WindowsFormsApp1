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
            task = new Task();

        }

        private void ChetSumButton_Click(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(ReadtextBox.Text);
            OutputtextBox.Text = task.ChetSum(size);
            ArraytextBox.Text = task.PrintArray(size);

        }

        private void NeChetbutton_Click(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(ReadtextBox.Text);
            OutputtextBox.Text = task.NeChetSum(size);
            ArraytextBox.Text = task.PrintArray(size);

        }
    }
}
