using System;

namespace Calculator_ASM1
{
    class Program
    {
        static double Sum()
        {
            Console.WriteLine("moi nhap so a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("moi nhap so b:");
            double b = double.Parse(Console.ReadLine());
            double sum = a + b;
            return sum;
        }
        static double Subtract()
        {
            Console.WriteLine("moi nhap so a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("moi nhap so b:");
            double b = double.Parse(Console.ReadLine());
            double subtract = a - b;
            return subtract;
        }
        static double Multiple()
        {
            Console.WriteLine("moi nhap so a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("moi nhap so b:");
            double b = double.Parse(Console.ReadLine());
            double multiple = a * b;
            return multiple;
        }
        static double Divide()
        {
            Console.WriteLine("moi nhap so a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("moi nhap so b:");
            double b = double.Parse(Console.ReadLine());
            double divide = (double)a / (double)b;
            return divide;
        }
        public static void Main(string[] args)
        {
            int userChoise = 1;
            double result;

            while (userChoise != 0)
            {
                Console.WriteLine("_____________________________");
                Console.WriteLine("||Nhap 1 : Tinh tong 2 so  ||");
                Console.WriteLine("||Nhap 2 : Tinh hieu 2 so  ||");
                Console.WriteLine("||Nhap 3 : Tinh tich 2 so  || ");
                Console.WriteLine("||Nhap 4 : Tinh thuong 2 so||");
                Console.WriteLine("||Nhap 0 : Out Meta        ||");
                Console.WriteLine("-----------------------------");
                userChoise = int.Parse(Console.ReadLine());

                switch (userChoise)
                {
                    case 1:
                        result = Sum();
                        Console.WriteLine("Tổng 2 số là: {0}", result);
                        break;
                    case 2:
                        result = Subtract();
                        Console.WriteLine("Hiệu 2 số là: {0}", result);
                        break;
                    case 3:
                        result = Multiple();
                        Console.WriteLine("Tích 2 số là: {0}", result);
                        break;
                    case 4:
                        result = Divide();
                        Console.WriteLine("Thương 2 số là: {0}", result);
                        break;
                    case 0:
                        Console.WriteLine("See u again");
                        break;
                    default:
                        Console.WriteLine("Chon sai cmnr");
                        break;
                }
            }
        }
    }
}
