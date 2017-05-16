using System.Linq;

namespace RecipeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (RecipesEntities context = new RecipesEntities())
            {
                //Recipe recipe = new Recipe
                //{
                //    Name = "Chicken Salad"
                //};

                //context.Recipes.Add(recipe);

                //Recipe recipe = context.Recipes.FirstOrDefault(r => r.Name == "Burger");
                //context.Recipes.Remove(recipe);
                //recipe.Name = "Burger";

                //context.SaveChanges();

                //Console.WriteLine(recipe.Id);
                //Console.Read();

                //context.SaveChanges();



                //context.Categories.Add(new Category() {Name = "Breakfast"});
                //context.Categories.Add(new Category() {Name = "Lunch"});


                //1. Using Id properties
                //Category category = context.Categories.FirstOrDefault(c => c.Name == "Breakfast");
                //context.Recipes.Add(new Recipe {Name = "Cereal", CategoryId = category.Id});

                //2. Recipe.Category navigation property
                Category category = context.Categories.FirstOrDefault(c => c.Name == "Lunch");
                context.Recipes.Add(new Recipe {Name = "Pizza", Category = category});

                context.SaveChanges();
            }
        }
    }
}
