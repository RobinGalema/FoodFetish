using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Easy_Recipe
{
    class DatabaseConnection
    {
        // Connection Fields
        const string connectionString = @"";
        SqlConnection conn = new SqlConnection(connectionString);

        // Fields
        private List<Recipe> recipes = new List<Recipe>();
        private List<User> users = new List<User>();

        // Properties
        internal List<Recipe> Recipes { get => recipes; set => recipes = value; }
        internal List<User> Users { get => users; set => users = value; }
    }
}
