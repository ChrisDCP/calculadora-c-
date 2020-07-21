using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {


            int a, b, c, d;

                Console.WriteLine("numero 1");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("numero 2");

                b = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("\t sumar 1 \n");
                Console.WriteLine("\t restar 2 \n");
                Console.WriteLine("\t multiplicar 3 \n");
                Console.WriteLine("\t dividir 4 \n");

                Console.WriteLine("¿Que quiere hacer?");
                c = int.Parse(Console.ReadLine());
                Console.Clear();

               

                switch (c)
                {
                    case 1:
                        d = a + b;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(a+" + " + b + " = " + d);
                        Console.ReadKey();
                    break;

                    case 2:
                        d = a - b;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(a + " - " + b + " = " + d);
                        Console.ReadKey();
                    break;

                    case 3:
                        d = a * b;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(a + " x " + b + " = " + d);
                        Console.ReadKey();
                    break;

                    case 4:
                        d = a / b;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(a + " / " + b + " = " + d);
                        Console.ReadKey();
                    break;

                    default:
                        Console.WriteLine("pendejo");
                    break;
                }





        }
    }
}
