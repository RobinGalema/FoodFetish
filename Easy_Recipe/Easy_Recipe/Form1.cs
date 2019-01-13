using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_Recipe
{
    public partial class Form1 : Form
    {
        // Create the database object to receive data
        Database database = new Database();
        public Form1()
        {
            InitializeComponent();
            // Create a list of all recipes that are in the database
            List<Recipe> recipes = database.GetRecipes();

            // Debug
            Console.WriteLine(recipes[0].Name);
            Console.WriteLine(recipes[0].Description);
            Console.WriteLine(recipes[0].Time);

            // Debug
            recipes[0].Ingredients = database.fillIngredients(1);
            foreach (Ingredient ingredient in recipes[0].Ingredients)
            {
                Console.WriteLine(ingredient.Name);
            }
        }
    }
}
