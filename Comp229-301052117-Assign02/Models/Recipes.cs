using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Comp229_301052117_Assign02.Models
{
    public class Recipes
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Please choose the amount of servings")]
        public string Servings { get; set; }
        [Required(ErrorMessage = "Please enter your dish name")]
        public string DishName { get; set; }
        [Required(ErrorMessage = "Please enter the ingredients")]
        public string Ingredients { get; set; }
        [Required(ErrorMessage = "Please enter the description of your dish")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please choose a category")]
        public string Category { get; set; }
        //public int ID { get; set; }

    }
}
