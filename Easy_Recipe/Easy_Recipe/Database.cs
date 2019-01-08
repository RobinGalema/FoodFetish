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
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Robin\OneDrive\Documents\GitHub\FoodFetish\Easy_Recipe\Easy_Recipe\DB_App.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionString);

        // Fields
        private List<Recipe> recipes = new List<Recipe>();
        private List<User> users = new List<User>();
        private List<Ingredient> ingredients = new List<Ingredient>();
        private List<Catagory> catagories = new List<Catagory>();

        // Properties
        internal List<Recipe> Recipes { get => recipes; set => recipes = value; }
        internal List<User> Users { get => users; set => users = value; }
        internal List<Ingredient> Ingredients { get => ingredients; set => ingredients = value; }
        internal List<Catagory> Catagories { get => catagories; set => catagories = value; }

        // Methods
        public List<Ingredient> getIngredients()
        {
            ingredients = new List<Ingredient>();

            string query = "SELECT Ingredient.naam FROM Ingredient";

            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Ingredient ingredient = new Ingredient(reader.GetString(0));

                    ingredients.Add(ingredient);
                }
            }

            conn.Close();
            return ingredients;
        }

        public List<Catagory> getCategories()
        {
            catagories = new List<Catagory>();

            string query = "SELECT Categorie.naam FROM Categorie";

            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Catagory catagory = new Catagory(reader.GetString(0));

                    catagories.Add(catagory);
                }
            }

            conn.Close();
            return catagories;
        }

        public List<User> GetUsers()
        {
            users = new List<User>();

            string query = "SELECT Gebruiker.Naam, Gebruiker.Wachtwoord, Gebruiker.E-mail FROM Gebruiker";

            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    User user = new User(reader.GetString(0), reader.GetString(1), reader.GetString(2));

                    users.Add(user);
                }
            }

            conn.Close();
            return users;
        }
    }
}
