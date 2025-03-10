using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Question_2
{
    public class Bai4
    {
        public double GiaiThua2(double num)
        {
            if (num == 0 || num == 1)
                return 1;
            return num * GiaiThua2(num - 1);
        }
    }
}
