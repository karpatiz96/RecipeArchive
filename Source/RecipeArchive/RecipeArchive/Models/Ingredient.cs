﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeArchive.Models
{
    public class Ingredient
    {
        public int IngredientID { get; set; }

        public int MealID { get; set; }

        public string Name { get; set; }

        public string Quantity { get; set; }

        public Meal Meal { get; set; }
    }
}
