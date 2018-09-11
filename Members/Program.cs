using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            //diary.AddRating(3.5f);
            //diary.AddRating(5.4f);
            //diary.AddRating(8.4f);

            //DiaryStatistics stats = diary.ComputeStatistics();
            //WriteResult("Average", stats.AverageGrade, 3, 5, 6, 7, 8 );
            //WriteResult("Max", (int)stats.MaxGrade);
            //WriteResult("Min", (long)stats.MinGrade);
            //WriteResult("Min", stats.MinGrade, 1);

            diary.NameChanged += new NameChangedDelegate(OnNameChanged);        
            diary.NameChanged += new NameChangedDelegate(OnNameChanged2);
            diary.NameChanged += new NameChangedDelegate(OnNameChanged3);
            diary.NameChanged += new NameChangedDelegate(OnNameChanged4);
            diary.NameChanged += new NameChangedDelegate(OnNameChanged4);
            diary.Name = "Dzienniczek Michała";
            diary.Name = "Jacek Hej";

            


            //diary.Name = null;
            Console.WriteLine(diary.Name);

            Console.ReadKey(); 
        }

        private static void OnNameChanged(string existingName, string newName)
        {
            Console.WriteLine($"Zmiana nazwy z {existingName} na {newName}");
        }

        private static void OnNameChanged2(string existingName, string newName)
        {
            Console.WriteLine("**************");
        }

        private static void OnNameChanged3(string existingName, string newName)
        {
            Console.WriteLine("Hello");
        }
        private static void OnNameChanged4(string existingName, string newName)
        {
            Console.WriteLine("+++++++++++++");
        }
        static void WriteResult(string description, params float[] result)
        {
            Console.WriteLine(description + ": " + result[0] + "  " + result[4]);
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, long result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, float result, long test)
        {
            Console.WriteLine($"{description}: {result:c}; {2}: {3}: {4}: {5}: ");
        }


    }
}
