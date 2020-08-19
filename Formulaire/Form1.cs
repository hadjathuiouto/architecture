using Client_Metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulaire
{
    public partial class Form1 : Form
    {
        ClientMetier UnClient = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void InsertClient(String numero, string nom, string prenom, string adresse)
        {
            ClientMetier UnClient = new ClientMetier();
            int verif = UnClient.VerifNumero(numero);
            if(verif == 0)
            {
                UnClient.Nom = nom;
                UnClient.Prenom = prenom;
                UnClient.Tel = numero;
                UnClient.Adresse = adresse;
                UnClient.Insertion();
                Cleanfields();
            }
            else
            {
                MessageBox.Show("Ce numéro existe déjà", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Inserer_Click(object sender, EventArgs e)
        {
            InsertClient(t)
        }
    }
}
