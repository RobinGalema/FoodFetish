using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Recipe
{
    class Recipe
    {
        // Fields
        private string name;
        private string description;
        private int time;
        List<Ingredient> ingredients;
        List<Catagory> catagories;

        // Properties
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Time { get => time; set => time = value; }
        public List<Ingredient> Ingredients { get => ingredients; set => ingredients = value; }
        public List<Catagory> Catagories { get => catagories; set => catagories = value; }

        // Constructor
        public Recipe(string name, string description, int time)
        {
            this.name = name;
            this.description = description;
            this.time = time;
            ingredients = new List<Ingredient>();
            catagories = new List<Catagory>();
        }


    }
}
