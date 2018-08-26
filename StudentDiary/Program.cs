using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary(); //twirzenie obiektu klasy Diary(instancji)
            //diary.AddRating(5);
            //diary.AddRating(8.5f);
            //diary.AddRating(4.7f);

            //float avg = diary.CalcualteAverage();
            //float max = diary.GiveMaxRatig();
            //float min = diary.GiveMinRating();

            for (; ;)
            {
                Console.WriteLine("Podaj oceny z zakresu od 1-10");
                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating);
                
                if (rating == 11)
                {
                    break;
                }
                if (result) //(result == true) to to samo
                {
                    if (rating > 0 && rating <= 10)
                    {
                        diary.AddRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna liczba, podaj liczbę z zakresu 1-10");     
                    }
                    
                }
                

            }

            Console.WriteLine("Średnia twoich ocen to: " + diary.CalcualteAverage());
            Console.WriteLine("Najwyższa ocena to: " + diary.GiveMaxRatig());
            Console.WriteLine("Najniższa ocena to: " + diary.GiveMinRating());
            Console.ReadKey();

            Diary diary2 = new Diary();

        }
    }
}
