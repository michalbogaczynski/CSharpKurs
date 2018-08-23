using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();
            for (; ;)
            {
                Greeting();
                Age();
                Settings();
            }

            //foreach (var item in args)
            //{
            //    Console.WriteLine("Witaj " + item);
            //}
        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MinValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);
        }

        /// <summary>
        /// Ustawienia
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        /// <summary>
        /// Komunikat dotyczacy wieku
        /// </summary>
        private static void Age()
        {
            Console.Write("Ile masz lat?: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Brawo jesteś pelnołnoletni możesz wypić piwko");
            }
            else if (result == false)
            {
                Console.WriteLine("Błędny wiek");
            }
            else
            {
                Console.WriteLine("Możesz wypić herbate");
            }
        }
        /// <summary>
        /// Wyspisujemy powitanie użytkownika
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Wpisz swoje imie: ");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj, " + name);
        }
    }
}
