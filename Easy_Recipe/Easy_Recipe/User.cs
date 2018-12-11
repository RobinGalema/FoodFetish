using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Recipe
{
    class User
    {
        //fields
        private string name;
        private string wachtwoord;
        List<Recipe> Recipes;

        //properties
        public string Name { get => name; set => name = value; }
        public string Wachtwoord { get => wachtwoord; set => wachtwoord = value; }
        public List<Recipe> Recipes1 { get => Recipes; set => Recipes = value; }

        //constructor
        public User(string name, string wachtwoord, List<Recipe> recipes)
        {
            this.name = name;
            this.wachtwoord = wachtwoord;
            Recipes = recipes;
        }

        //methods
        public void AddFavorite()
        {

        }

        public void RemoveFavorite()
        {

        }

        public void ChangePassword(string nieuwwWachtwoord)
        {

        }
    }
}
