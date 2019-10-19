using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comp229_301052117_Assign02.Models
{
    public static class RecipeRepository
    {
        public static List<Recipes> recipes = new List<Recipes>();

        public static IEnumerable<Recipes> recipe
        {
            get { return recipes; }
        }

        public static void AddRecipe(Recipes r)
        {
            recipes.Add(r);
        }
    }
}
