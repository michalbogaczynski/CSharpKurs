using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typy
{
    class Program
    {

        static void GiveName(ref Diary diary)
        {
            diary = new Diary();
            diary.Name = "Dzienniczek Marcina";
        }

        static void IncrementNumber(int number)
        {
            number += 1;
        }

        static void Main(string[] args)
        {
            //PassByValueAndRef();

            Immutable();

            Console.ReadKey();
        }

        private static void Immutable()
        {
            string name = " Marcin ";
            name = name.Trim(); //usuwanie białych znaków, nalezy przypisać do zmiennej aby utworzyć nowy ciąg

            DateTime date = new DateTime(2015, 3, 10);
            date = date.AddHours(48);
                        
            Console.WriteLine(name);
            Console.WriteLine(date);
        }

        private static void PassByValueAndRef()
        {
            Diary d1 = new Diary();
            Diary d2 = d1;

            GiveName(ref d2);

            Console.WriteLine(d2.Name);

            int x1 = 4;
            IncrementNumber(x1);

            Console.WriteLine(x1);
        }
    }
}

