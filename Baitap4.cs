using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Nhap so luong phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Nhap cac gia tri cua mang:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int max = arr[0]; 
        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        Console.WriteLine("Gia tri lon nhat cua mang la: " + max);
    }
}