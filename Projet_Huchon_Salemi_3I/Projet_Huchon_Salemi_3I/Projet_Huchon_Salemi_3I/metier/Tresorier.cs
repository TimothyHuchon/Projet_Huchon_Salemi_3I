using Projet_Huchon_Salemi_3I.DAO;
using System;
using System.Collections.Generic;
using System.Windows;

namespace Projet_Huchon_Salemi_3I.metier
{
    public class Tresorier : Personne
    {
        private decimal id_personne;
        public Tresorier(string nom, string prenom, string tel, string id, string motDePasse)
            : base(nom, prenom, tel, id, motDePasse){}

        public Tresorier() { }

        public Tresorier(decimal id_personne)
        { 
            this.ID_personne = id_personne;
        }

        public decimal ID_personne { get => id_personne; set => id_personne = value; }

        public override string ToString()
        {
            return "Tresorier { " +
                " nom: " + Nom +
                " prenom: " + Prenom +
                " tel: " + Tel +
                " id: " + Id +
                " motDePasse: " + MotDePasse +
                " }";

        }

        public string envoiLettreRappel(decimal numBalade)
        {
            string lettreRappel = null;
            BaladeDAO dao = new BaladeDAO();
            decimal forfait = dao.recupForfait(numBalade);

            return "Vous devez payer " + forfait + " € pour la balade.";
        }

        public void payerConducteur(decimal numBalade)
        {
            Personne personne = new Personne();

           
            VehiculeDAO Vdao = new VehiculeDAO();
            
            BaladeDAO dao = new BaladeDAO();
           
            MembreDAO Mdao = new MembreDAO();
            

           
            decimal forfait = dao.recupForfait(numBalade);
            List<decimal> listIdV = Vdao.vehiculeByNumBalade(numBalade);
            foreach(decimal d in listIdV)
            {
                Vehicule vehicule = Vdao.Find(d);              
               
                decimal totalPlace = Vdao.NbrMembreByVehicule(vehicule.ID_vehicule);
                decimal totalAPayerConduct = totalPlace * forfait;
                System.Diagnostics.Debug.WriteLine(vehicule.ID_personne_conducteur);
                Membre membre = Mdao.Find(vehicule.ID_personne_conducteur);
                System.Diagnostics.Debug.WriteLine(membre.ID_personne);
                membre.CptBanquaire = membre.CptBanquaire + totalAPayerConduct;
                Mdao.Update(membre);
            }
            MessageBox.Show("Paiement fait avec succés !", "Félicitations", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        public void ReclamerForfait(decimal numBalade)
        {
            BaladeDAO dao = new BaladeDAO();
            InscriptionDAO Idao = new InscriptionDAO();
            MembreDAO Mdao = new MembreDAO();

            decimal forfait = dao.recupForfait(numBalade);


            foreach (Decimal d in Idao.FindPersonneInscrit(numBalade))
            {
                Membre membre = Mdao.Find(d);
                membre.Solde = membre.Solde + forfait;
                Mdao.Update(membre);
            }
            MessageBox.Show("Réclamation faite avec succés !", "Félicitations", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

    }
}
