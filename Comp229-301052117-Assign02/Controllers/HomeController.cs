using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Comp229_301052117_Assign02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Comp229_301052117_Assign02.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult DisplayPage(string dishName)
        {
            foreach (var r in RecipeRepository.recipe)
            {
                if (dishName == r.DishName)
                {
                    return View(r);
                }
            }

            return View(null);
        }

        public ViewResult UserPage()
        {
            return View("UserPage");
        }
        public ViewResult DataPage()
        {
            return View("DataPage", RecipeRepository.recipes);
        }
        [HttpGet]
        public ViewResult InsertPage()
        {
            return View("InsertPage");
        }

        [HttpPost]
        public ViewResult InsertPage(Recipes recipes)
        {
            RecipeRepository.AddRecipe(recipes);
            return View("DataPage", RecipeRepository.recipes);
        }
    }
    
}