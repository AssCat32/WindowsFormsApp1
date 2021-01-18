using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SecondTask : InterfaceIndex
    {
        private List<int> list;
        private int size = 0;
        
        public int this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }
        public string Name { get => "SecondTask " + size; }
        public int Size { get => size; }
        public SecondTask(int N)
        {
            Random rand = new Random();

            size = N;

            list = new List<int> { };
            for (int i = 0; i < N; ++i)
            {
                list.Add(rand.Next(1, 10));
            }
        }
        public string ChetSum(int N)
        {
            string str = "";
            int sum = 0;
            for (int i = 0; i < N; ++i)
            {
                if ((list[i] > 0) && (list[i] % 2 == 0))
                {
                    sum++;
                }
            }
            str += sum;
            return str;
        }
        //NeChet
        public string ChetSum()
        {
            string str = "";
            int sum = 0;
            for (int i = 0; i < size; ++i)
            {
                if (((list[i] > 0) && (list[i] % 2 != 0)) || list[i] == 1)
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
