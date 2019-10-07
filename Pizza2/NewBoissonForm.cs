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
    public partial class NewBoissonForm : Form
    {
        public NewBoissonForm()
        {
            InitializeComponent();
        }

        private void NewBoissonForm_Load(object sender, EventArgs e)
        {
            listBoxListeBoissonsNew.Items.AddRange(DAL.BoissonsAImporter.ToArray());
            txtNomBoisson.Select();
        }

        private void btnCreerBoisson_Click(object sender, EventArgs e)
        {
            try
            {
                txtPrixBoisson.Text = txtPrixBoisson.Text.Replace('.', ',');
                Boisson newBoisson = new Boisson(txtNomBoisson.Text, float.Parse(txtPrixBoisson.Text));
                DAL.BoissonsAImporter.Add(newBoisson);
                listBoxListeBoissonsNew.Items.Add(newBoisson);
                txtNomBoisson.Clear();
                txtPrixBoisson.Clear();
            }
            catch
            {
                MessageBox.Show("Il manque des informations", "Erreur");
            }
        }

        private void btnSupprimerBoisson_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBoxListeBoissonsNew.SelectedIndex;
                DAL.BoissonsAImporter.RemoveAt(index);
                listBoxListeBoissonsNew.Items.Remove(listBoxListeBoissonsNew.SelectedItem);
            }
            catch
            {
                MessageBox.Show("Selectionner un élément à supprimer", "Erreur");
            }
        }

        private void btnRetourBoisson_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
