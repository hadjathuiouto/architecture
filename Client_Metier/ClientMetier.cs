using Client_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Client_Metier
{
    
    public class ClientMetier
    {
        private int _id;
        private string _nom;
        private string _prenom;
        private string _tel;
        private string _adresse;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        public string Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }

        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        Client LeClient
        {
            get
            {
                Client c;
                c.id = this.Id;
                c.nom = this.Nom;
                c.prenom = this.Prenom;
                c.tel = this.Tel;
                c.adresse = this.Adresse;
                return c;
            }
        }

        //Méthode d'insertion 
        public int Insertion()
        {
            ClientData UnClientData = new ClientData();
            return UnClientData.InsertClient(LeClient);
        }

        //Méthode de modification 
        public int UpdateClient()
        {
            ClientData UnClientData = new ClientData();
           return UnClientData.UpdateClient(LeClient);
        }

        //Méthode de suppression
        public void DeleteClient(int IdClient)
        {
            ClientData UnClientData = new ClientData();
            UnClientData.DeleteClient(IdClient);
        }

        public DataTable SelectClient()
        {
            ClientData UnClientData = new ClientData();
            return UnClientData.SelectClient(); 
        }

        public DataTable VerifNumero(string numero)
        {
            ClientData UnClientData = new ClientData();
            return UnClientData.VerifClientBeforeInsert(numero);
        }
    }
}
