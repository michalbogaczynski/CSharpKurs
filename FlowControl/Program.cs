using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    class Program
    {
        private static int age;
        private static string name;

        static void Main(string[] args)
        {
            //instructionIf();
            //instructionSwitch();

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int a = 0; a < 2; a++)
            //    {
            //        Console.WriteLine("wartość i : {0} oraz wartość a : {1}", i, a);
            //    }

            //}

            int i = 1;

            //while (i > 3)
            //{
            //    Console.WriteLine("wartość i {0}", i );
            //    i++;
            //}

            //do
            //{
            //    Console.WriteLine("wartość i {0}", i );
            //    i++;
            //} while (i > 3);

            //int[] tab = { 1, 2, 3, 4, 5, 7, 4, 2 };

            //foreach (var item in tab)
            //{
            //    Console.WriteLine(item);
            //}

            for (; ;)
            {
                Console.WriteLine("podaj imie");
                string text = Console.ReadLine();
                Console.WriteLine("masz na imie {0}", text);
            }



            Console.ReadKey();
        }

        private static void instructionSwitch()
        {
            Console.WriteLine("Podaj imie: ");
            name = Console.ReadLine();

            switch (name)
            {
                case "Marcin":
                    Method1();
                    break;
                case "Tomek":
                    Method2();
                    Method3();
                    break;
                default:
                    MEthod4();
                    break;
            }
        }

        private static void instructionIf()
        {
            Console.WriteLine("Podaj swój wiek: ");
            age = int.Parse(Console.ReadLine());

            string test = age > 18 ? "Pełnoletni" : "Dziecko"; // trojargumentowe sprawdzenie
            Console.WriteLine(test);

            Console.WriteLine("Podaj swoje imie: ");
            name = Console.ReadLine();

            if (age <= 10)
            {
                if (name == "Marcin")
                {

                }
                Method1();
            }
            else if (age < 20)
            {
                Method2();
            }
            else if (age < 30)
            {
                Method3();
            }
            else
            {
                MEthod4();
            }
        }

        private static void MEthod4()
        {
            Console.WriteLine("Jesteś w metodzie 4");
        }

        private static void Method3()
        {
            Console.WriteLine("Jesteś w metodzie 3");
        }

        private static void Method2()
        {
            Console.WriteLine("Jesteś w drugiej metodzie");
        }

        private static void Method1()
        {
            Console.WriteLine("Jesteś w pierwszej metodzie");
        }
    }
}
