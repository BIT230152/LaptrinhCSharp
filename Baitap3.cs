using System;

namespace Baitap3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Yêu cầu người dùng nhập một ký tự
            Console.Write("Nhap mot ki tu: ");
            char inputChar = Console.ReadLine()[0];

            // Chuyển đổi ký tự sang int để lấy mã ASCII
            int asciiCode = (int)inputChar;

            // Hiển thị kết quả
            Console.WriteLine($"Ky tu ban da nhap la '{inputChar}', ma ASCII cua no la {asciiCode}.");
        }
    }
}