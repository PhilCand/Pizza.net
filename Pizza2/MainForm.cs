﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Pizza2
{
    public partial class MainForm : Form
    {
        public ListBox ListBoxPizza { get => listBoxPizza; set => listBoxPizza = value; }

        public MainForm()
        {
            InitializeComponent();
        }

        static List<Produit> listeProduits = new List<Produit>();
        static float prixTotal = 0;

        private void btnNouvelleRecette_Click(object sender, EventArgs e)
        {
            NewPizzaForm newPizzaForm = new NewPizzaForm();
            newPizzaForm.ShowDialog();
            listBoxPizza.Items.Clear();
            listBoxPizza.Items.AddRange(DAL.ListePizzas.ToArray());
            listBoxPizza.SelectedIndex = 0;
        }

        private void btnDetailPizza_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Pizza)listBoxPizza.SelectedItem).AfficherIngredients(), ((Pizza)listBoxPizza.SelectedItem).Nom);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (Pizza pizza in DAL.ListePizzas)
            {
                listBoxPizza.Items.Add(pizza);
            }

            foreach (Boisson boisson in DAL.ListeBoissons)
            {
                listBoxBoisson.Items.Add(boisson);
            }

            if (listBoxPizza.Items.Count > 0) listBoxPizza.SelectedIndex = 0;

            if (listBoxBoisson.Items.Count > 0) listBoxBoisson.SelectedIndex = 0;

            foreach (Commande commande in DAL.ListeCommandes)
            {
                listBoxHistoCdes.Items.Add(commande);
                prixTotal += commande.PrixCommande;
            }
        }

        private void btnNouvelleBoisson_Click(object sender, EventArgs e)
        {
            NewBoissonForm newBoissonForm = new NewBoissonForm();
            newBoissonForm.ShowDialog();
            listBoxBoisson.Items.Clear();
            listBoxBoisson.Items.AddRange(DAL.ListeBoissons.ToArray());
            listBoxBoisson.SelectedIndex = 0;
        }

        private void changerUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm.essai = 3;
            DialogResult result = DialogResult.No;
            using (var loginForm = new LoginForm())

                while (LoginForm.essai > 0 && result == DialogResult.No)
                {
                    result = loginForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        loginForm.Close();
                    }
                }
        }

        private void btnAjouterPizza_Click(object sender, EventArgs e)
        {
            PizzaCommandee pizzaAjoute = new PizzaCommandee(((Pizza)listBoxPizza.SelectedItem).Nom, ((Pizza)listBoxPizza.SelectedItem).Prix);
            listBoxPizza.ClearSelected();

            if (radioButtonSmall.Checked == true)
            {
                pizzaAjoute.Taille = "small";
                radioButtonSmall.Checked = false;
            }

            if (radioButtonMedium.Checked == true)
            {
                pizzaAjoute.Taille = "medium";
                pizzaAjoute.Prix += 2;
            }

            if (radioButtonLarge.Checked == true)
            {
                pizzaAjoute.Taille = "large";
                pizzaAjoute.Prix += 5;
                radioButtonLarge.Checked = false;
            }

            if (checkBoxSupCapres.Checked == true)
            {
                pizzaAjoute.Capres = true;
                pizzaAjoute.Supplement += " + capres";
                pizzaAjoute.Prix += 1;
                checkBoxSupCapres.Checked = false;
            }

            if (checkBoxSupOlives.Checked == true)
            {
                pizzaAjoute.Olives = true;
                pizzaAjoute.Supplement += " + olives";
                pizzaAjoute.Prix += 1;
                checkBoxSupOlives.Checked = false;
            }

            if (checkBoxSupAnchois.Checked == true)
            {
                pizzaAjoute.Anchois = true;
                pizzaAjoute.Supplement += " + anchois";
                pizzaAjoute.Prix += 1;
                checkBoxSupAnchois.Checked = false;
            }

            if (checkBoxSupOeuf.Checked == true)
            {
                pizzaAjoute.Oeuf = true;
                pizzaAjoute.Supplement += " + oeuf";
                pizzaAjoute.Prix += 1;
                checkBoxSupOeuf.Checked = false;
            }

            listBoxRecapCommande.Items.Add(pizzaAjoute);
            listeProduits.Add(pizzaAjoute);

            float total = float.Parse(txtTotalCdeEnCours.Text) + pizzaAjoute.Prix;
            txtTotalCdeEnCours.Text = total.ToString();

            radioButtonMedium.Checked = true;

            if (listBoxPizza.Items.Count > 0) listBoxPizza.SelectedIndex = 0;
        }

        private void btnAjouterBoisson_Click(object sender, EventArgs e)
        {
            Boisson boissonAjoute = new Boisson(((Boisson)listBoxBoisson.SelectedItem).Nom, ((Boisson)listBoxBoisson.SelectedItem).Prix);

            listeProduits.Add(boissonAjoute);
            listBoxBoisson.ClearSelected();
            listBoxRecapCommande.Items.Add(boissonAjoute);
            float total = float.Parse(txtTotalCdeEnCours.Text) + boissonAjoute.Prix;
            txtTotalCdeEnCours.Text = total.ToString();

            if (listBoxBoisson.Items.Count > 0) listBoxBoisson.SelectedIndex = 0;
        }

        private void buttonSupprEnCours_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBoxRecapCommande.SelectedIndex;
                float total = float.Parse(txtTotalCdeEnCours.Text) - listeProduits[index].Prix;
                listeProduits.RemoveAt(index);
                listBoxRecapCommande.Items.Remove(listBoxRecapCommande.SelectedItem);
                txtTotalCdeEnCours.Text = total.ToString();
            }
            catch
            {
                MessageBox.Show("Selectionner un élément à supprimer", "Erreur",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnValiderCommande_Click(object sender, EventArgs e)
        {
            Client nouveauClient = new Client();

            nouveauClient.NomClient = txtNomClient.Text;
            nouveauClient.PrenomClient = txtPrenomClient.Text;
            nouveauClient.Adresse1Client = txtAdresse1.Text;
            nouveauClient.Adresse2Client = txtAdresse2.Text;
            nouveauClient.CPClient = txtCP.Text;
            nouveauClient.VilleClient = txtVille.Text;
            nouveauClient.TelClient = txtTel.Text;


            foreach (var box in groupBox4.Controls.OfType<TextBox>())
            {
                box.Text = "";
            }

            txtTotalCdeEnCours.Text = "0";

            Commande nouvelleCommande = new Commande(nouveauClient, listeProduits);

            if (DAL.ListeCommandes.Count == 0) nouvelleCommande.Numero = 1;
            else nouvelleCommande.Numero = 1 + DAL.ListeCommandes[DAL.ListeCommandes.Count - 1].Numero;
            

            foreach (Produit produit in listeProduits)
            {
                nouvelleCommande.PrixCommande += produit.Prix;
            }

            listBoxHistoCdes.Items.Add(nouvelleCommande);
            DAL.ListeCommandes.Add(nouvelleCommande);
            DAL.ExportCommande(DAL.ListeCommandes);

            listBoxRecapCommande.Items.Clear();
            
            listeProduits.Clear();

            prixTotal += nouvelleCommande.PrixCommande;

            this.Text = $"Pizza.net - Utilisateur : {Program.userName} - Nombre de commandes : {DAL.ListeCommandes.Count} - Prix total : {prixTotal}";
        }

        private void listBoxHistoCdes_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxHistoContenuCde.Items.Clear();
            txtHistoNom.Text = "";
            txtHistoPrenom.Text = "";
            txtHistoAdresse1.Text = "";
            txtHistoAdresse2.Text = "";
            txtHistoCP.Text = "";
            txtHistoVille.Text = "";
            txtHistoTel.Text = "";
            txtHistoPrix.Text = "";

            if (listBoxHistoCdes.SelectedIndex >= 0)
            {
                txtHistoNom.Text = ((Commande)listBoxHistoCdes.SelectedItem).Client.NomClient;
                txtHistoPrenom.Text = ((Commande)listBoxHistoCdes.SelectedItem).Client.PrenomClient;
                txtHistoAdresse1.Text = ((Commande)listBoxHistoCdes.SelectedItem).Client.Adresse1Client;
                txtHistoAdresse2.Text = ((Commande)listBoxHistoCdes.SelectedItem).Client.Adresse2Client;
                txtHistoCP.Text = ((Commande)listBoxHistoCdes.SelectedItem).Client.CPClient;
                txtHistoVille.Text = ((Commande)listBoxHistoCdes.SelectedItem).Client.VilleClient;
                txtHistoTel.Text = ((Commande)listBoxHistoCdes.SelectedItem).Client.TelClient;

                foreach (Produit produit in ((Commande)listBoxHistoCdes.SelectedItem).Contenu)
                {
                    listBoxHistoContenuCde.Items.Add(produit);
                }

                txtHistoPrix.Text = ((Commande)listBoxHistoCdes.SelectedItem).PrixCommande.ToString();
            }
        }
        private void buttonSuppCde_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBoxHistoCdes.SelectedIndex;
                prixTotal -= DAL.ListeCommandes[index].PrixCommande;
                listBoxHistoCdes.ClearSelected();
                listBoxHistoCdes.Items.RemoveAt(index);
                DAL.ListeCommandes.RemoveAt(index);
                listBoxHistoContenuCde.Items.Clear();
                DAL.ExportCommande(DAL.ListeCommandes);

                this.Text = $"Pizza.net - Utilisateur : {Program.userName} - Nombre de commandes : {DAL.ListeCommandes.Count} - Prix total : {prixTotal}";
            }
            catch
            {
                MessageBox.Show("Selectionner un element à supprimer", "Erreur");
            }
        }
        private void MainForm_Activated(object sender, EventArgs e)
        {
            this.Text = $"Pizza.net - Utilisateur : {Program.userName} - Nombre de commandes : {DAL.ListeCommandes.Count} - Prix total : {prixTotal}";
            if (Program.userName == "chef")
            {
                btnNouvelleRecette.Visible = true;
                btnNouvelleBoisson.Visible = true;
                buttonSuppCde.Visible = true;
            }

            if (Program.userName != "chef")
            {
                btnNouvelleRecette.Visible = false;
                btnNouvelleBoisson.Visible = false;
                buttonSuppCde.Visible = false;
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Voulez vous vraiment quitter ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) e.Cancel = true;
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
