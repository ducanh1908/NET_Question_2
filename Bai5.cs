using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Question_2
{
    public class Bai5
    {
        public bool CheckNguyenTo(double num)
        {
            if (num < 2)
                return false;
            if (num == 2)
                return true;
            for (int i = 2; i < Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;

        }
        public void LietKeSoNguyenTo(double n)
        {
            Console.WriteLine($"Cac so nguyen to la:");
            for (int i = 1; i <= n; i++)
            {
                if (CheckNguyenTo(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
