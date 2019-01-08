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
        private string password;
        private string email;
        List<Recipe> Recipes;

        // Constructor
        public User(string name, string password, string email)
        {
            this.name = name;
            this.password = password;
            this.email = email;
        }

        // Properties
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        internal List<Recipe> Recipes1 { get => Recipes; set => Recipes = value; }
    }
}
