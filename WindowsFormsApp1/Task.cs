using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Task: InterfaceIndex
    {
        private int[] array;
        private int size = 0;
        public event myDelegate event1;
        public event myDelegate2 event2;
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
        public string Name { get => "Task " + size; }
        public Task(int N)
        {
            Random rand = new Random();

            size = N;

            array = new int[size];

            for (int i = 0; i < size; ++i)
            {
                array[i] = rand.Next(1, 10);
            }
        }

        public string ChetSum(int N)
        {
            string str = "";
            int sum = 0;
            for (int i = 0; i < N; ++i)
            {
                if ((array[i] > 0) && (array[i] % 2 == 0))
                {
                    sum++;
                }
            }
            str += sum;
            return str;
        }

        public string ChetSum()
        {
            string str = "";
            int sum = 0;
            for (int i = 0; i < size; ++i)
            {
                if (((array[i] > 0) && (array[i] % 2 != 0)) || array[i] == 1)
                {
                    sum++;
                }
            }
            str += sum;
            return str;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
