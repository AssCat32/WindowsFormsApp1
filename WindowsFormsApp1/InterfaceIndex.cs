using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    interface InterfaceIndex
    {
        int this[int index]
        {
            get;
            set;
        }
        string Name 
        { 
            get; 
        }
        int Size
        {
            get;
        }
        
        string ChetSum(int N);
        string ChetSum();
    }
}
