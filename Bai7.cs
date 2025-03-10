using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Question_2
{
    public class Bai7
    {
        public string chuyenSo(string number)
        {
            string[] words = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string result = "";

            foreach (char digit in number)
            {
                result += words[digit - '0'] + " "; // Chuyển chữ số thành chữ
            }

            return result.Trim(); // Xóa khoảng trắng cuối cùng
        }
    }
}
