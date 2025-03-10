namespace NET_Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao 1 so: ");
            double num = double.Parse(Console.ReadLine());
            Bai4 bai4 = new Bai4();

            double gt = bai4.GiaiThua2(num);
            Console.WriteLine($"Giai thua cua {num} la: {gt}");
            Bai6 bai6 = new Bai6();
            bai6.KiemTraChanLe(num);
            Bai5 bai5 = new Bai5();
            bool nguyento = bai5.CheckNguyenTo(num);
            if (nguyento)
            {
                Console.WriteLine($"{num} la so ngto");
            }
            else
                Console.WriteLine($"{num} khong la so ngto");
            bai5.LietKeSoNguyenTo(num);
            Bai7 bai7 = new Bai7();
            Console.WriteLine("Nhap vao 1 so: ");
            string input = Console.ReadLine();

            if (long.TryParse(input, out _)) // Kiểm tra xem có phải số hợp lệ không
            {
                Console.WriteLine("Bang chu: " + bai7.chuyenSo(input));
            }
            else
            {
                Console.WriteLine("Vui long nhap so hop le.");
            }

        }

    }
}
