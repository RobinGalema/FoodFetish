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
            listBoxSearchResults.BorderStyle = BorderStyle.None;
            listBoxFavourites.BorderStyle = BorderStyle.None;
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
    }
}
