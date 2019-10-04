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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static int essai = 3;
        private void btnLoginOK_Click(object sender, EventArgs e)
        {
                       
            if (txtUtilisateur.Text == "chef" && txtMDP.Text == "pizza")
            {
                DialogResult = DialogResult.OK;
                Program.userName = txtUtilisateur.Text;                
                //Utilisateur = ADMIN
            }

            if (txtUtilisateur.Text != "chef" && txtMDP.Text == "pizza")
            {
                DialogResult = DialogResult.OK;
                Program.userName = txtUtilisateur.Text;
                // Utilisateur = USER
            }

            if (txtMDP.Text != "pizza")
            {
                essai--;
                MessageBox.Show($"Identification incorrecte, il vous reste {essai} essai(s)");
                DialogResult = DialogResult.No;
            }
                       
        }

    private void labelNbEssais_Click(object sender, EventArgs e)
    {

    }
        private void btnLoginAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
