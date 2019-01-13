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
            database.Recipes = database.GetRecipes();

            // Debug
            Console.WriteLine(database.Recipes[0].Name);
            Console.WriteLine(database.Recipes[0].Description);
            Console.WriteLine(database.Recipes[0].Time);

            // Debug
            database.Recipes[0].Ingredients = database.fillIngredients(1);
            foreach (Ingredient ingredient in database.Recipes[0].Ingredients)
            {
                Console.WriteLine(ingredient.Name);
            }
        }

    }
}
