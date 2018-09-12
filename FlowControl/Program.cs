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

            

            Console.WriteLine("Podaj swój wiek: ");
            age = int.Parse(Console.ReadLine());

            string test = age > 18 ? "Pełnoletni" : "Dziecko"; // trojargumentowe sprawdzenie
            Console.WriteLine(test);

            //Console.WriteLine("Podaj swoje imie: ");
            //name = Console.ReadLine();

            //if (age <= 10)
            //{
            //    if (name == "Marcin")
            //    {

            //    }
            //    Method1();
            //}
            //else if (age <20)
            //{
            //    Method2();
            //}
            //else if (age < 30)
            //{
            //    Method3();
            //}
            //else
            //{
            //    MEthod4();
            //}

            Console.ReadKey();
        }


        private static void MEthod4()
        {
            Console.WriteLine("Masz 30 lub więcej lat ");
        }

        private static void Method3()
        {
            Console.WriteLine("Twój wiek jest większy lub równy 20 a mniejszy od 30 i wynosi " + age);
        }

        private static void Method2()
        {
            Console.WriteLine("Twój wiek jest większy od 10 a mniejszy od 20 i wynosi " + age);
        }

        private static void Method1()
        {
            Console.WriteLine("Masz 10 lub mniej lat a dokładnie masz " + age);
        }
    }
}
