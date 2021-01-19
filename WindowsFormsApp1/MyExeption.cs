using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class MyExeption: Exception
    {
        public MyExeption(string s) : base($"Вы ввели неверное значение N {s}")
        {

        }
    } 
}
