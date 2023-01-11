using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        // mohit va masahat moraba, mosalas,zoozanaghe
        static void Main(string[] args)
        {
            Class1 shape1 = new Class1();
            Console.WriteLine("what shape? \n 1.square \t 2.triangle \t 3.trapezius");
            var answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    Console.WriteLine("size of the side? ");
                    shape1.a1 = Convert.ToInt32(Console.ReadLine());
                    shape1.a2 = shape1.a3 = 0;
                    shape1.b1 = shape1.b2 = 0;
                    break;
                case "2":
                    Console.WriteLine("size of the base? ");
                    shape1.a1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("size of the side? ");
                    shape1.b1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("size of the other side? ");
                    shape1.b2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("size of the height? ");
                    shape1.a2 = Convert.ToInt32(Console.ReadLine());
                    shape1.a3 = 0;
                    break;
                case "3":
                    Console.WriteLine("size of the smallest side? ");
                    shape1.a1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("size of the biggest side? ");
                    shape1.a2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("size of the other side? ");
                    shape1.b1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("size of the last side? ");
                    shape1.b2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("size of the height? ");
                    shape1.a3 = Convert.ToInt32(Console.ReadLine());
                    break;
                default :
                    Console.WriteLine("you only can pick 1,2 or 3!!");
                    Console.ReadKey();
                    return;
                    break;
            }
            Console.WriteLine("Area: ");
            Console.WriteLine(shape1.Masahat());
            Console.WriteLine("perimeter: ");
            Console.WriteLine(shape1.Mohit());

            Console.ReadKey();
   

        }
    }
}
