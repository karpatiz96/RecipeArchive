using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RecipeArchive.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<User> User { get; set; }

        public DbSet<Meal> Meal { get; set; }

        public DbSet<UserMeal> UserMeal { get; set; }

        public DbSet<MealType> MealType { get; set; }

        public DbSet<Ingredient> Ingredient { get; set; }

    }
}
