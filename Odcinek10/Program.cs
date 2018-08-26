using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odcinek10
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            diary.AddRating(3);
            diary.AddRating(5);

            // po skompilowaniu przypiadana będzie ocena 8 ponieważ do zmiennej diary został przypisany nowy obiekt
            //diary = new Diary();
            //diary.AddRating(8);

            //dwie zmienne czyli diary i diary2 przypisane są do osobnych obiektów
            //Diary diary2 = new Diary();
            //diary.AddRating(8);

            // w obiekcie beda przypisane 3 oceny, obie zmienne przypisane są do jednego obiektu
            Diary diary2 = diary;
            diary.AddRating(8);

        }
    }
}
