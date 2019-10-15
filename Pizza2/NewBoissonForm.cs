using System;
using System.Drawing;
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
            listBoxListeBoissonsNew.Items.AddRange(DAL.ListeBoissons.ToArray());
            txtNomBoisson.Select();
        }

        private void btnCreerBoisson_Click(object sender, EventArgs e)
        {
            try
            {
                txtPrixBoisson.Text = txtPrixBoisson.Text.Replace('.', ',');
                Boisson newBoisson = new Boisson(txtNomBoisson.Text, float.Parse(txtPrixBoisson.Text));
                DAL.ListeBoissons.Add(newBoisson);
                listBoxListeBoissonsNew.Items.Add(newBoisson);
                txtNomBoisson.Clear();
                txtPrixBoisson.Clear();
                txtNomBoisson.Select();
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
                DAL.ListeBoissons.RemoveAt(index);
                listBoxListeBoissonsNew.Items.Remove(listBoxListeBoissonsNew.SelectedItem);
                
            }
            catch
            {
                MessageBox.Show("Selectionner un élément à supprimer", "Erreur");
            }
        }

        private void btnRetourBoisson_Click(object sender, EventArgs e)
        {
            DAL.ExportBoissonsXML();
            this.Close();
        }

        private void listBoxListeBoissonsNew_DrawItem(object sender, DrawItemEventArgs e)
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
