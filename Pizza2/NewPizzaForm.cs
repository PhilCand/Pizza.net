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
            foreach (Pizza pizza in DAL.PizzasAImporter)
            {
                listBoxListePizza.Items.Add(pizza);
            }
        }

        private void btnSuppPizza_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBoxListePizza.SelectedIndex;
                DAL.PizzasAImporter.RemoveAt(index);
                listBoxListePizza.Items.Remove(listBoxListePizza.SelectedItem);
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Selectionner un élément à supprimer", "Erreur");
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
