using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members
{
    public class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
            //Count++;
        }
        //Stan
        private List<float> ratings;

        //public static float MinGrade = 0;
        //public static float MaxGrade = 10;
        //public static long Count = 0;

        private string _name;

        public string Name
        {
            get
            {
                return _name.ToUpper();
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }


        //Zachowania
        public void AddRating(float rating)
        {
            if (rating >= 0 && rating <= 10)
            {
                ratings.Add(rating);
            }
            
        }

        public DiaryStatistics ComputeStatistics()
        {
            DiaryStatistics stats = new DiaryStatistics();

            float sum = 0f;
            foreach (var rating in ratings)
            {
                //sum = sum + rating; to samo co na dole
                sum += rating;
            }

            stats.AverageGrade = sum / ratings.Count();
            stats.MaxGrade = ratings.Max();
            stats.MinGrade = ratings.Min();

            return stats;
        }


    }
}
