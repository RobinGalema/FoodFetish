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
        List<ingredient> ingredients;
        List<catagory> catagories;

        public Recipe(string name, string description, int time, List<ingredient> ingredients, List<catagory> catagories)
        {
            this.name = name;
            this.description = description;
            this.time = time;
            ingredients = new List<ingredient>();
            catagories = new List<catagory>();
        }
    }
}
