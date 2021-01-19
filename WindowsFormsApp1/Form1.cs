using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

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

        private readonly Logger logger;

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

            logger = LogManager.GetCurrentClassLogger();
        }

        Task task1;
        SecondTask task2;
        private void Createbutton_Click(object sender, EventArgs e)
        {
            try
            {
                size = Convert.ToInt32(ReadtextBox.Text);

                if (size < 10)
                {
                    throw new MyExeption("size < 10");
                }

                task1 = new Task(Convert.ToInt32(size));
                ArraytextBox.Text = PrintArray(task1);
            }
            catch (MyExeption ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ChetSumButton_Click(object sender, EventArgs e)
        {
            OutputtextBox.Text = task1.ChetSum(ArraytextBox.Text.Length);
            ArraytextBox.Text = PrintArray(task1);
            logger.Info($"Вызван метод ChetSumButton_Click с результатом {OutputtextBox.Text}");
        }

        private void NeChetbutton_Click(object sender, EventArgs e)
        {
            OutputtextBox.Text = task1.ChetSum();
            ArraytextBox.Text = PrintArray(task1);
            logger.Info($"Вызван метод NeChetbutton_Click с результатом {OutputtextBox.Text}");
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
            try
            {
                sizeList = Convert.ToInt32(ReadtextBox.Text);

                if (sizeList < 10)
                {
                    throw new MyExeption("size < 10");
                }

                task2 = new SecondTask(sizeList);
                ArraytextBox.Text = PrintArray(task2);
            }
            catch (MyExeption ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ChetbuttonList_Click(object sender, EventArgs e)
        {
            OutputtextBox.Text = task2.ChetSum(ArraytextBox.Text.Length);
            ArraytextBox.Text = PrintArray(task2);
            logger.Info($"Вызван метод ChetbuttonList_Click с результатом {OutputtextBox.Text}");
        }

        private void NeChetbuttonList_Click(object sender, EventArgs e)
        {
            OutputtextBox.Text = task2.ChetSum();
            ArraytextBox.Text = PrintArray(task2);
            logger.Info($"Вызван метод NeChetbuttonList_Click с результатом {OutputtextBox.Text}");
        }

        private void InsertFirstM_Click(object sender, EventArgs e)
        {
            event1 += listBox.ElementAt(listBoxClasses.SelectedIndex).ChetSum;
            logger.Info($"Привязали событие event1 {listBox.ElementAt(listBoxClasses.SelectedIndex)}");
        }

        private void DeleteFirstM_Click(object sender, EventArgs e)
        {
            event1 -= listBox.ElementAt(listBoxClasses.SelectedIndex).ChetSum;
            logger.Info($"Отвязали событие event1 {listBox.ElementAt(listBoxClasses.SelectedIndex)}");
        }

        private void InsertSecondM_Click(object sender, EventArgs e)
        {
            event2 += listBox.ElementAt(listBoxClasses.SelectedIndex).ChetSum;
            logger.Info($"Привязали событие event2 {listBox.ElementAt(listBoxClasses.SelectedIndex)}");
        }

        private void DeleteSecondM_Click(object sender, EventArgs e)
        {
            event2 -= listBox.ElementAt(listBoxClasses.SelectedIndex).ChetSum;
            logger.Info($"Отвязали событие event2 {listBox.ElementAt(listBoxClasses.SelectedIndex)}");
        }

        private void EventFirst_Click(object sender, EventArgs e)
        {
            size = listBox.ElementAt(listBoxClasses.SelectedIndex).Size;
            richTextBox.Text += event1?.Invoke(size) + "\n";
            logger.Info($"Вызвали событие event1 с результатом {event1?.Invoke(size)}");
        }

        private void EventSecond_Click(object sender, EventArgs e)
        {
            richTextBox.Text += event2?.Invoke() + "\n";
            logger.Info($"Вызвали событие event2 с результатом {event2?.Invoke()}");
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (SaveData(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info($"Сохранение прошло успешно!");
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn($"Не сохранилось!");
                }
            }
        }

        private bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                foreach (var item in listBox)
                {
                    size = item.Size;

                    if (item.GetType().Name == "Task")
                    {
                        sw.WriteLine("Task: " + PrintArray(item) + "." + item.ChetSum(size) + "." + item.ChetSum());
                    }
                    if (item.GetType().Name == "SecondTask")
                    {
                        sw.WriteLine("SecondTask: "+ PrintArray(item) + "." + item.ChetSum(size) + "." + item.ChetSum());
                    }

                }
            }
            return true;
        }


        private void buttonSort_Click(object sender, EventArgs e)
        {
            listBox.Sort(new MyComparer());
            listBoxClasses.Items.Clear();

            foreach (var item in listBox)
            {
                listBoxClasses.Items.Add(item);
            }
                
            logger.Info("Сортировка списка");
        }
    }
}
