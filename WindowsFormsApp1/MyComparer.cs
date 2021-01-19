using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class MyComparer : IComparer<InterfaceIndex>
    {
        public int Compare(InterfaceIndex x, InterfaceIndex y)
        {
            var result = x.Name.CompareTo(y.Name);

            if (result != 0)
            {
                return result;
            }

            result = x.Size.CompareTo(y.Size);

            return result;
        }
    }
}
