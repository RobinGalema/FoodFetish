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
        private int amountNeeded;
        private string displayValue;

        // Properties
        public string Name { get => name; set => name = value; }
        public int AmountNeeded { get => amountNeeded; set => amountNeeded = value; }
        public string DisplayValue { get => displayValue; set => displayValue = value; }

        // Constructor
        public Ingredient(string name, int amountNeeded)
        {
            // giving the name of ingredient
            this.name = name;
            this.amountNeeded = amountNeeded;
            displayValue = name + ": " + amountNeeded.ToString();
        }

    }
}
