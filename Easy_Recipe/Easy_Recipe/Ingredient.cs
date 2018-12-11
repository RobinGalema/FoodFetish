using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Recipe
{
    class Ingredient
    {
        // The name of the ingredient 
        private string name;
        // The amount that is needed of the ingredient
        private int amount;

        public Ingredient(string name, int amount)
        {
            // giving the name of ingredient
            this.name = name;
            // getting the amount that is required
            this.amount = amount;
        }
    }
}
