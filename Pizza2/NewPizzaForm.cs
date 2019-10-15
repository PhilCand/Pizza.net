using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Pizza2
{
    public partial class NewPizzaForm : Form
    {
        public NewPizzaForm()
        {
            InitializeComponent();
        }

        private void NewPizzaForm_Load(object sender, EventArgs e)
        {
            List<Pizza> ListePizzasTmp = new List<Pizza>(DAL.ListePizzas);
            
            listBoxListePizza.Items.AddRange(ListePizzasTmp.ToArray());
                
            txtNomPizza.Select();
        }

        private void btnSuppPizza_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBoxListePizza.SelectedIndex;
                DAL.ListePizzas.RemoveAt(index);
                listBoxListePizza.Items.Remove(listBoxListePizza.SelectedItem);
                
            }
            catch
            {
                MessageBox.Show("Selectionner un élément à supprimer", "Erreur");
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            DAL.ExportPizzasXML();
            this.Close();
        }

        private void btnAjouterIngredient_Click(object sender, EventArgs e)
        {
            Ingredient ingredient = new Ingredient(txtIngredient.Text);

            listBoxIngredients.Items.Add(ingredient);

            txtIngredient.Clear();
            txtIngredient.Select();
        }
        
        private void btnCreerPizza_Click(object sender, EventArgs e)
        {
            try
            {
                txtPrixPizza.Text = txtPrixPizza.Text.Replace('.', ',');

                Pizza newPizza = new Pizza(txtNomPizza.Text, float.Parse(txtPrixPizza.Text));
                Ingredient[] ingredientsnewPizza = new Ingredient[listBoxIngredients.Items.Count];
                listBoxIngredients.Items.CopyTo(ingredientsnewPizza, 0);
                newPizza.Ingredients = ingredientsnewPizza.ToList<Ingredient>();
                listBoxListePizza.Items.Add(newPizza);
                DAL.ListePizzas.Add(newPizza);
                listBoxIngredients.Items.Clear();
                txtNomPizza.Clear();
                txtPrixPizza.Clear();
            }
            catch
            {
                MessageBox.Show("Il manque des informations", "Erreur");
            }

        }

        private void tabControlSaisiCde_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            //if the item state is selected them change the back color 
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.PaleTurquoise);//Choose the color

            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Draw the current item text
            e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), e.Font, Brushes.SaddleBrown, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }
    }
}
