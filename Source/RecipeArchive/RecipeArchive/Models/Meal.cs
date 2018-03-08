using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeArchive.Models
{
    public class Meal
    {

        public enum DifficultyStates
        {
            easy = 0,
            normal = 1,
            hard = 2
        }

        public int MealID { get; set; }

        public int MealTypeID { get; set; }

        public DifficultyStates Difficulty { get; set; }

        public string Name { get; set; }

        public int? MakeTime { get; set; }

        public string Description { get; set; }

        public byte[] Picture { get; set; }

        public MealType MealType { get; set; }

    }
}
