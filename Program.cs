using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Lua chon chuc nang:");
            Console.WriteLine("1. Tim so lon nhat trong 3 so thuc");
            Console.WriteLine("2. Kiem tra so nguyen to");
            Console.WriteLine("3. Nhap va xuat mang so nguyen");
            Console.WriteLine("0. Ket thuc chuong trinh");
            Console.Write("Nhap lua chon cua ban: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    TimSoLonNhat();
                    break;
                case 2:
                    KiemTraSoNguyenTo();
                    break;
                case 3:
                    NhapVaXuatMang();
                    break;
                case 0:
                    Console.WriteLine("Chuong trinh ket thuc.");
                    return;
                default:
                    Console.WriteLine("Lua chon khong hop le. Vui long thu lai.");
                    break;
            }
        }
    }

    static void TimSoLonNhat()
    {
        Console.WriteLine("Nhap ba so thuc:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double max = Math.Max(a, Math.Max(b, c));
        Console.WriteLine("So lon nhat la: " + max);
    }

    static void KiemTraSoNguyenTo()
    {
        Console.WriteLine("Nhap mot so nguyen:");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (number < 2)
            isPrime = false;
        else
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        if (isPrime)
            Console.WriteLine(number + " la so nguyen to.");
        else
            Console.WriteLine(number + " khong phai la so nguyen to.");
    }

    static void NhapVaXuatMang()
    {
        Console.WriteLine("Nhap kich thuoc mang:");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        Console.WriteLine("Nhap cac phan tu cua mang:");
        for (int i = 0; i < size; i++)
        {
            Console.Write("arr[" + i + "] = ");
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Mang sau khi nhap:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
