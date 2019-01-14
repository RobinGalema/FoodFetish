using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Easy_Recipe
{
    public partial class Form1 : Form
    {
        // Create the database object to receive data
        Database database = new Database();
        Recipe selectedrecipe;
        List<User> users;

        public Form1()
        {
            InitializeComponent();
            //Deze regel verstopt de tabcontrol.
            tabControl1.Appearance = TabAppearance.FlatButtons; tabControl1.ItemSize = new Size(0, 1); tabControl1.SizeMode = TabSizeMode.Fixed;

            //Hide border of the listbox
            listBoxRequiredIngredients.BorderStyle = BorderStyle.None;

            // Create some items.
            //Replace with for each loop to put data in the listbox, \n starts a new line.

            //Doest the same as the code above for the ingredients Listbox
            listBoxIngredients.DrawMode = DrawMode.OwnerDrawVariable;

            //Retrieve recipes and bind them to the listbox
            database.GetRecipes();

            listBoxSearchResults.DataSource = database.Recipes;
            listBoxSearchResults.DisplayMember = "name".ToString();
            listBoxSearchResults.ValueMember = "recipeId";

            users = database.GetUsers();
            try
            {
                User currentUser = users[0];
            }
            catch
            {
                MessageBox.Show("Er zijn geen gebruikers gevonden. U gebruikt de app momenteel als gast.");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
        //Click event for Add ingredient button
        private void buttonAddIngredient_Click(object sender, EventArgs e)
        {

        }


        //Click Events voor de 3 hoofdbuttons
        private void buttonSearchRecipe_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void buttonFavorites_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void buttonIngredients_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }




        //Click Events voor de pictureboxes.
        private void pictureBoxRecent1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void pictureBoxRecent2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void pictureBoxSuggestHealthy_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void pictureBoxSuggestBudget_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void pictureBoxSuggestDesert_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void pictureBoxSuggestSalade_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
        
        //Click Events for the back buttons.
        private void buttonBackRecipe_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void buttonBackSearch_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void buttonBackFavourites_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void buttonBackIngredients_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void labelRecipePreperation_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Search for recipe with the input of the textbox included and show them in the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string input = textBoxSearch.Text;

            List<Recipe> searchedRecipes = database.searchRecipe(input);
            listBoxSearchResults.DataSource = searchedRecipes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Check which recipe in the listbox is selected and import that recipe into selectedrecipe
                selectedrecipe = database.Recipes[(Int32)listBoxSearchResults.SelectedValue - 1];
                // Fill the recipe with the right ingredients
                selectedrecipe.Ingredients = database.fillIngredients((Int32)listBoxSearchResults.SelectedValue);

                // Debug
                Console.WriteLine((Int32)listBoxSearchResults.SelectedValue);
                Console.WriteLine(database.Recipes[(Int32)listBoxSearchResults.SelectedValue - 1].Ingredients);

                // Display the recipename and the description of the recipe in the right labels
                labelRecipeTitle.Text = selectedrecipe.Name;
                labelRecipePreperation.Text = selectedrecipe.Description;

                // Link the listbox for the ingredients to the list of ingredients of the selected ingredients
                listBoxRequiredIngredients.DataSource = selectedrecipe.Ingredients;
                listBoxRequiredIngredients.DisplayMember = "displayValue";

                // Update the listbox
                listBoxRequiredIngredients.Update();

                // Switch to the tab for the recipe
                tabControl1.SelectedIndex = 1;
            }
            catch
            {
                MessageBox.Show("Er is iets fout gegaan bij het ophalen van het recept. Is er een recept geselecteerd?");
            }
        }

        private void buttonCookRecipe_Click(object sender, EventArgs e)
        {
            try
            {
                // Add the recipe to a file which tracks which recipes you have previously cooked
                File.AppendAllText(@"C:\Users\Robin\Documents\GitHub\FoodFetish\Easy_Recipe\Easy_Recipe\cookedRecipes.txt", selectedrecipe.Name + Environment.NewLine);

                MessageBox.Show("Recept toegevoegd aan gekookte recepten");
            }
            catch
            {
                MessageBox.Show("Er is iets fout gegaan bij het toevoegen aan de lijst met gekookte recepten.");
            }
        }
    }
}
