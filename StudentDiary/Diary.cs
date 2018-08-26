using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
        }
        //Stan
        List<float> ratings;
                
        //Zachowania
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        public float CalcualteAverage()
        {
            float sum = 0, avg = 0;
            foreach (var rating in ratings)
            {
                //sum = sum + rating; to samo co na dole
                sum += rating;
            }

            avg = sum / ratings.Count();
            return avg;
        }

        public float GiveMaxRatig()
        {
            return ratings.Max();
        }

        public float GiveMinRating()
        { 
            return ratings.Min();
        }

    }
}
