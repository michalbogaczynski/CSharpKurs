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

            //instructionFor();
            //instructionWhile();
            //instructionDoWhile();
            //instrutionForeach();
            //instructionForInfinity();

            //instructionContinueBreak();
            //instructionGoTo();

            int[] ages = { 1, 2, 3, 4, 5, 6, 7, 8 };
            CheckAges(ages);

            Console.ReadKey();
        }
        #region metody prywatne
        private static void CheckAges(int[] ages)
        {
            foreach (var age in ages)
            {
                if (age == 3)
                {
                    Console.WriteLine("wiek wynosi: {0}", age);
                    return;//wychodzi z pętli oraz metody i przechodzi do następnej instrukcji 
                }
            }
        }

        private static void instructionGoTo()
        {
            int[] ages = { 1, 2, 3, 4, 5, 6, 7, 8 };
            foreach (var age in ages)
            {
                if (age == 2)
                {
                    Console.WriteLine("wiek wynosi: {0}", age);
                    goto skip;//przeskakuje do skip, instruckaj goto zaciemnia kod raczej nie używać
                    Console.WriteLine("hello"); //ta instrukcja się nie wykona ponieważ jest po continue
                }


            }

        skip:
            Console.WriteLine("witaj");
        }

        private static void instructionContinueBreak()
        {
            int[] ages = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var age in ages)
            {
                if (age == 2)
                {
                    Console.WriteLine("wiek wynosi: {0}", age);
                    continue; //po tej instrukcji nie wykonywane są dalsze instruckję tylko program przechodzi do kolejnej iteraccji czyli do 3
                    Console.WriteLine("hello"); //ta instrukcja się nie wykona ponieważ jest po continue
                }

                if (age == 4)
                {
                    Console.WriteLine("wiek wynosi: {0}", age);
                    break; //przerywa działanie pętli
                    Console.WriteLine("hello"); //nie wykona się
                }
            }
        }

        private static void instructionForInfinity()
        {
            for (;;)
            {
                Console.WriteLine("podaj imie");
                string text = Console.ReadLine();
                Console.WriteLine("masz na imie {0}", text);
            }
        }

        private static void instrutionForeach()
        {
            int[] tab = { 1, 2, 3, 4, 5, 7, 4, 2 };

            foreach (var item in tab)
            {
                Console.WriteLine(item);
            }
        }

        private static void instructionDoWhile()
        {
            int i = 2;
            do
            {
                Console.WriteLine("wartość i {0}", i);
                i++;
            } while (i > 3);
        }

        private static void instructionWhile()
        {
            int i = 1;

            while (i > 3)
            {
                Console.WriteLine("wartość i {0}", i);
                i++;
            }
        }

        private static void instructionFor()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int a = 0; a < 2; a++)
                {
                    Console.WriteLine("wartość i : {0} oraz wartość a : {1}", i, a);
                }

            }
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
        #endregion
    }
}
