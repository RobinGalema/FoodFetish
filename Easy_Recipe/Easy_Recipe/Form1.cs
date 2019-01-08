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
        Database database = new Database();

        public Form1()
        {
            InitializeComponent();
            List<Recipe> recipes = database.GetRecipes();

            Console.WriteLine(recipes[0].Name);
            Console.WriteLine(recipes[0].Description);
            Console.WriteLine(recipes[0].Time);
            Console.WriteLine(recipes[0].Ingredients);
            Console.WriteLine(recipes[0].Catagories);

        }
    }
}
