using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Easy_Recipe
{
    class Database
    {
        // Connection Fields
        const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Robin\Documents\GitHub\FoodFetish\Easy_Recipe\Easy_Recipe\DB_App.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionString);

        // Fields
        private List<Recipe> recipes = new List<Recipe>();
        private List<User> users = new List<User>();
        private List<Catagory> catagories = new List<Catagory>();

        // Properties
        public List<Recipe> Recipes { get => recipes; set => recipes = value; }
        public List<User> Users { get => users; set => users = value; }
        public List<Catagory> Catagories { get => catagories; set => catagories = value; }

        // Methods

        /// <summary>
        /// Gets all the recipes currently availible in the database
        /// </summary>
        /// <returns></returns>
        public List<Recipe> GetRecipes()
        {
            recipes = new List<Recipe>();
            string query = "Select * From Recepten";

            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                { 
                    Recipe recipe = new Recipe(reader.GetString(1), reader.GetString(2), (Int32)reader.GetInt32(3));
                    recipes.Add(recipe);
                }
            }

            conn.Close();
            Console.WriteLine(recipes);
            return recipes;  
        }

        /// <summary>
        /// Fills the list of ingredients of the selected recipe with ingredients from the database
        /// </summary>
        /// <param name="recipeID"></param>
        /// <returns></returns>
        public List<Ingredient> fillIngredients(int recipeID)
        {

                List<Ingredient> ingredients = new List<Ingredient>();

                string query = "Select Ing_Rec.Id, Ingredient.Naam, Recepten.Naam, Ing_Rec.aantal From ((Ing_Rec" +
                               " Inner join Ingredient on Ing_Rec.Ing_Id = Ingredient.Id)" +
                               " Inner join Recepten on Ing_Rec.Rec_Id = Recepten.Id)" +
                               " Where Ing_Rec.Id = @RecipeID";

            conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@RecipeId", recipeID);

            using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    
                    while (reader.Read())
                    {
                        Ingredient ingredient = new Ingredient(reader.GetString(1), reader.GetInt32(3));
                        ingredients.Add(ingredient);

                    }
                }

           
            conn.Close();
            return ingredients;
            
        }

        /// <summary>
        /// Returns a list of all users currently in the database
        /// </summary>
        /// <returns></returns>
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
