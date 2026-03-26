using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bai1();
            bai2();
            bai3();
            bai4();
            Fibonacci();
        }
        static void bai1() { 
            Console.WriteLine("moi ban nhap n:");
             int n = int.Parse(Console.ReadLine());

             int sum = 0;
             for (int i = 2; i <= n; i+=2)
             {
                 sum += i;
             }
             Console.WriteLine("tong cac so chan tu 2 den n la: " + sum);
         }


        static void bai2()
         {
             Console.WriteLine("moi ban nhap n:");
             int n = int.Parse(Console.ReadLine());
             double phan_tram = 0;
             for (int i = 1; i <= n; i++)
             {
                 phan_tram += 1.0/i;
             }
             Console.WriteLine("tong cac so tu 1 den n la: " + phan_tram);
         }

        static void bai3()
        {
            Console.WriteLine("moi ban nhap so can kiem tra:");
            int n = int.Parse(Console.ReadLine());

            bool laNguyenTo = true;

            if (n < 2)
            {
                laNguyenTo = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)  
                    {
                        laNguyenTo = false;
                        break;
                    }
                }
            }

            if (laNguyenTo)
                Console.WriteLine(n + " la so nguyen to");
            else
                Console.WriteLine(n + " khong phai la so nguyen to");
        }

        static void bai4()
        {
            Console.WriteLine("moi ban nhap do dai canh a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("moi ban nhap do dai canh b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("moi ban nhap do dai canh c:");
            int c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("3 canh a, b, c tao thanh 1 tam giac deu");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("3 canh a, b, c tao thanh 1 tam giac can");
                }
                else
                {
                    Console.WriteLine("3 canh a, b, c tao thanh 1 tam giac thuong");
                }
            }
            else
            {
                Console.WriteLine("3 canh a, b, c khong the tao thanh 1 tam giac");
            }
        }
        static void Fibonacci()
        {
            Console.WriteLine("moi ban nhap n:");
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                int c = a + b;  // số tiếp theo
                Console.Write(c + " ");
                a = b;          // dịch chuyển
                b = c;
            }
            Console.Write(a + " ");

        }
    }

}
