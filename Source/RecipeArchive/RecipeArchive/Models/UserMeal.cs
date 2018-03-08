using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeArchive.Models
{
    public class UserMeal
    {

        public int UserMealID { get; set; }

        public int UserID { get; set; }

        public int MealID { get; set; }

        public bool RecipeBook { get; set; }

        public bool AlreadyMade { get; set; }

        public bool Favourite { get; set; }

        public int Stars { get; set; }

        public User User { get; set; }

        public Meal Meal { get; set; }
    }
}
