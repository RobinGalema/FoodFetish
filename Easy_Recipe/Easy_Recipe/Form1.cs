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
        public Form1()
        {
            InitializeComponent();
            //Deze regel verstopt de tabcontrol.
            tabControl1.Appearance = TabAppearance.FlatButtons; tabControl1.ItemSize = new Size(0, 1); tabControl1.SizeMode = TabSizeMode.Fixed;

            //var pos = this.PointToScreen(labelRecentHeader.Location);
            //pos = pictureBoxRecent1.PointToClient(pos);
            //labelRecentHeader.Parent = pictureBoxRecent1;
            //labelRecentHeader.Location = pos;
            //labelRecentHeader.BackColor = Color.Transparent;
            listBoxIngredients.BorderStyle = BorderStyle.None;
            //listBoxSearchResults.BorderStyle = BorderStyle.None;
           // listBoxFavourites.BorderStyle = BorderStyle.None;

            //Format Listboxes
            listBoxFavourites.DrawMode = DrawMode.OwnerDrawVariable;

            // Create some items.
            listBoxFavourites.Items.Add("Name: Gerecht\nBereidingstijd: 10 min");
            listBoxFavourites.Items.Add("Name: Gerecht\nBereidingstijd: 10 min");
            listBoxFavourites.Items.Add("Name: Gerecht\nBereidingstijd: 10 min");
            listBoxFavourites.Items.Add("Name: Gerecht\nBereidingstijd: 10 min");

            listBoxSearchResults.DrawMode = DrawMode.OwnerDrawVariable;

            // Create some items.
            listBoxSearchResults.Items.Add("Name: Gerecht\nBereidingstijd: 10 min");
            listBoxSearchResults.Items.Add("Name: Gerecht\nBereidingstijd: 10 min");
            listBoxSearchResults.Items.Add("Name: Gerecht\nBereidingstijd: 10 min");
            listBoxSearchResults.Items.Add("Name: Gerecht\nBereidingstijd: 10 min");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }





        private void buttonSearchRecipe_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void buttonFavorites_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

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

        private void listBoxSearchResults_MeasureItem(object sender, MeasureItemEventArgs e)
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

        private void listBoxSearchResults_DrawItem(object sender, DrawItemEventArgs e)
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

        private void listBoxIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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
    }
}
