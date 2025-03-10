using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Question_2
{
    public  class Bai6
    {
        public void KiemTraChanLe(double num)
        {
            if (num % 2 == 0)
                Console.WriteLine($"{num} la so chan");
            else
                Console.WriteLine($"{num} la so le");
        }
    }
}
