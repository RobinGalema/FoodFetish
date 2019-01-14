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
        public Form1()
        {
            InitializeComponent();
            //Deze regel verstopt de tabcontrol.
            tabControl1.Appearance = TabAppearance.FlatButtons; tabControl1.ItemSize = new Size(0, 1); tabControl1.SizeMode = TabSizeMode.Fixed;

            //Hide border of the listbox
            listBoxRequiredIngredients.BorderStyle = BorderStyle.None;

            //Format Listboxes
            listBoxFavourites.DrawMode = DrawMode.OwnerDrawVariable;

            // Create some items.
            //Replace with for each loop to put data in the listbox, \n starts a new line.

            //Doest the same as the code above for the ingredients Listbox
            listBoxIngredients.DrawMode = DrawMode.OwnerDrawVariable;

            //Retrieve recipes and bind them to the listbox
            database.GetRecipes();

            listBoxSearchResults.DataSource = database.Recipes;
            listBoxSearchResults.DisplayMember = "name".ToString();
            listBoxSearchResults.ValueMember = "recipeId";

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

        //Code to enable the writing of multiple lines for 1 item in a listbox.

        // Calculate the size of an item.
        private int ItemMargin = 5;
        private void listBoxFavourites_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            // Get the ListBox and the item.
            ListBox lst = sender as ListBox;
            string txt = (string)lst.Items[e.Index];

            // Measure the string.
            SizeF txt_size = e.Graphics.MeasureString(txt, this.Font);

            // Set the required size.
            e.ItemHeight = (int)txt_size.Height + 2 * ItemMargin;
            e.ItemWidth = (int)txt_size.Width;
        }

        private void listBoxFavourites_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Get the ListBox and the item.
            ListBox lst = sender as ListBox;
            string txt = (string)lst.Items[e.Index];

            // Draw the background.
            e.DrawBackground();

            // See if the item is selected.
            if ((e.State & DrawItemState.Selected) ==
                DrawItemState.Selected)
            {
                // Selected. Draw with the system highlight color.
                e.Graphics.DrawString(txt, this.Font,
                    SystemBrushes.HighlightText, e.Bounds.Left,
                        e.Bounds.Top + ItemMargin);
            }
            else
            {
                // Not selected. Draw with ListBox's foreground color.
                using (SolidBrush br = new SolidBrush(e.ForeColor))
                {
                    e.Graphics.DrawString(txt, this.Font, br,
                        e.Bounds.Left, e.Bounds.Top + ItemMargin);
                }
            }

            // Draw the focus rectangle if appropriate.
            e.DrawFocusRectangle();
        }


        private void listBoxIngredient_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Get the ListBox and the item.
            ListBox lst = sender as ListBox;
            string txt = (string)lst.Items[e.Index];

            // Draw the background.
            e.DrawBackground();

            // See if the item is selected.
            if ((e.State & DrawItemState.Selected) ==
                DrawItemState.Selected)
            {
                // Selected. Draw with the system highlight color.
                e.Graphics.DrawString(txt, this.Font,
                    SystemBrushes.HighlightText, e.Bounds.Left,
                        e.Bounds.Top + ItemMargin);
            }
            else
            {
                // Not selected. Draw with ListBox's foreground color.
                using (SolidBrush br = new SolidBrush(e.ForeColor))
                {
                    e.Graphics.DrawString(txt, this.Font, br,
                        e.Bounds.Left, e.Bounds.Top + ItemMargin);
                }
            }

            // Draw the focus rectangle if appropriate.
            e.DrawFocusRectangle();
        }

        private void listBoxIngredient_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            // Get the ListBox and the item.
            ListBox lst = sender as ListBox;
            string txt = (string)lst.Items[e.Index];

            // Measure the string.
            SizeF txt_size = e.Graphics.MeasureString(txt, this.Font);

            // Set the required size.
            e.ItemHeight = (int)txt_size.Height + 2 * ItemMargin;
            e.ItemWidth = (int)txt_size.Width;
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
            selectedrecipe = database.Recipes[(Int32)listBoxSearchResults.SelectedValue - 1];
            selectedrecipe.Ingredients = database.fillIngredients((Int32)listBoxSearchResults.SelectedValue);

            Console.WriteLine((Int32)listBoxSearchResults.SelectedValue);
            Console.WriteLine(database.Recipes[(Int32)listBoxSearchResults.SelectedValue - 1].Ingredients);

            labelRecipeTitle.Text = selectedrecipe.Name;
            labelRecipePreperation.Text = selectedrecipe.Description;

            listBoxRequiredIngredients.DataSource = selectedrecipe.Ingredients;
            listBoxRequiredIngredients.DisplayMember = "displayValue";

            listBoxRequiredIngredients.Update();

            tabControl1.SelectedIndex = 1;
        }

        private void buttonCookRecipe_Click(object sender, EventArgs e)
        {
            // Add the recipe to a file which tracks which recipes you have previously cooked
            File.AppendAllText(@"C:\Users\Robin\Documents\GitHub\FoodFetish\Easy_Recipe\Easy_Recipe\cookedRecipes.txt", selectedrecipe.Name + Environment.NewLine);

            MessageBox.Show("Recept toegevoegd aan gekookte recepten");
        }
    }
}
