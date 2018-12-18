using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Recipe
{
    class Recipe
    {
        private string name;
        private string description;
        private int time;
        List<Ingredient> ingredients;
        List<Catagory> catagories;

        public Recipe(string name, string description, int time, List<Ingredient> ingredients, List<Catagory> catagories)
        {
            this.name = name;
            this.description = description;
            this.time = time;
            ingredients = new List<Ingredient>();
            catagories = new List<Catagory>();
        }
}
