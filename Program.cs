using System;

namespace ChuyenDoiNhietDo
{
    class Program
    {
       
        public static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (9.0 / 5) * celsius + 32;
            return fahrenheit;
        }

        // Phương thức chuyển đổi từ Fahrenheit sang Celsius
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (5.0 / 9) * (fahrenheit - 32);
            return celsius;
        }

        // Phương thức Main thực thi ứng dụng
        public static void Main(string[] args)
        {
            double fahrenheit;
            double celsius;
            int choice;

            do
            {
                // Hiển thị menu lựa chọn
                Console.WriteLine("Menu:");
                Console.WriteLine("1. F sang C");
                Console.WriteLine("2. C sang F");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Nhap Nhiet Do: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Chuyển đổi Fahrenheit sang Celsius
                        Console.WriteLine("Nhap do F: ");
                        fahrenheit = Double.Parse(Console.ReadLine());
                        Console.WriteLine("F sang C: " + FahrenheitToCelsius(fahrenheit));
                        break;

                    case 2:
                        // Chuyển đổi Celsius sang Fahrenheit
                        Console.WriteLine("Nhap do C: ");
                        celsius = Double.Parse(Console.ReadLine());
                        Console.WriteLine("C sang F: " + CelsiusToFahrenheit(celsius));
                        break;

                    case 0:
                        // Thoát chương trình
                        Environment.Exit(0);
                        break;

                    default:
                        // Trường hợp nhập lựa chọn không hợp lệ
                        Console.WriteLine("Lua chon khong hop le, hay chon lai.");
                        break;
                }
            } while (choice != 0); // Vòng lặp tiếp tục cho đến khi người dùng chọn thoát
    }
}
}
