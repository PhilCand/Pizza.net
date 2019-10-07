using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            listBoxListePizza.Items.AddRange(DAL.PizzasAImporter.ToArray());
                
            txtNomPizza.Select();
        }

        private void btnSuppPizza_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBoxListePizza.SelectedIndex;
                DAL.PizzasAImporter.RemoveAt(index);
                listBoxListePizza.Items.Remove(listBoxListePizza.SelectedItem);                
            }
            catch
            {
                MessageBox.Show("Selectionner un élément à supprimer", "Erreur");
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void btnAjouterIngredient_Click(object sender, EventArgs e)
        {
            Ingredient ingredient = new Ingredient(txtIngredient.Text);

            listBoxIngredients.Items.Add(ingredient);

            txtIngredient.Clear();
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
                DAL.PizzasAImporter.Add(newPizza);
                listBoxIngredients.Items.Clear();
                txtNomPizza.Clear();
                txtPrixPizza.Clear();
            }
            catch
            {
                MessageBox.Show("Il manque des informations", "Erreur");
            }
        }
    }
}
