using System;

namespace Baitap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so thuc: ");
            double number = double.Parse(Console.ReadLine());

            int int_number = (int)number;
            long long_number = (long)number;

            Console.WriteLine($"So ban da nhap la {number}, so nguyen la {int_number} va so dai la {long_number}");
        }
    }
}