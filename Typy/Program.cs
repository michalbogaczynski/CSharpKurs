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
            Diary d1 = new Diary();
            Diary d2 = d1;

            GiveName(ref d2);

            Console.WriteLine(d2.Name);

            int x1 = 4;
            IncrementNumber(x1);
                
            Console.WriteLine(x1);
            

            string name1 = "Marcin";
            string name2 = "marcin";


            bool areEqual = name1.Equals(name2, StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(areEqual);
            Console.ReadKey();
        }
    }
}

