using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Recipe
{
    class Ingredient
    {
        // Fields
        // The name of the ingredient 
        private string name;

        // Properties
        public string Name { get => name; set => name = value; }

        // Constructor
        public Ingredient(string name)
        {
            // giving the name of ingredient
            this.name = name;
        }

    }
}
