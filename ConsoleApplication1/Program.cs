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


            int c;

               
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
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
                        suma();
                        break;

                    case 2:
                        resta();
                        break;

                    case 3:
                        Multi();
                        break;

                    case 4:
                        div();
                        break;

                    default:
                        Console.WriteLine("pendejo");
                        break;
                }
            } while (c != 5);


        }
        public static void suma()
        {
            int a, b, d;
            Console.WriteLine("numero 1");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("numero 2");

            b = int.Parse(Console.ReadLine());
            Console.Clear();

            d = a + b;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(a + " + " + b + " = " + d);
            Console.ReadKey();
            Console.Clear();
        }
        public static void resta()
        {
            int a, b, d;
            Console.WriteLine("numero 1");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("numero 2");

            b = int.Parse(Console.ReadLine());
            Console.Clear();
            d = a - b;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(a + " - " + b + " = " + d);
            Console.ReadKey();
            Console.Clear();
        }

        public static void Multi()
        {
            int a, b, d;
            Console.WriteLine("numero 1");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("numero 2");

            b = int.Parse(Console.ReadLine());
            Console.Clear();

            d = a * b;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(a + " x " + b + " = " + d);
            Console.ReadKey();
        }

        public static void div()
        {
            int a, b, d;
            Console.WriteLine("numero 1");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("numero 2");

            b = int.Parse(Console.ReadLine());
            Console.Clear();
            d = a / b;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(a + " / " + b + " = " + d);
            Console.ReadKey();
        }

        public static void Dfault()
        {

        }
    }
}
