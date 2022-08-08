using Projet_Huchon_Salemi_3I.DAO;
using System;

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

        public void payerConducteur(decimal numBalade, String nom, String prenom)
        {
            Personne personne = new Personne();

            Vehicule vehicule = new Vehicule();
            VehiculeDAO Vdao = new VehiculeDAO();
            
            BaladeDAO dao = new BaladeDAO();
           
            MembreDAO Mdao = new MembreDAO();
            Membre membre = new Membre();

            decimal id_personne = personne.GetidUser(nom, prenom);
            decimal forfait = dao.recupForfait(numBalade);

            vehicule = Vdao.VehiculeByMembre(id_personne);
            decimal totalPlace = Vdao.NbrMembreByVehicule(vehicule.ID_vehicule);

            decimal totalAPayerConduct = totalPlace * forfait;
            membre = Mdao.Find(id_personne);
            membre.CptBanquaire = totalAPayerConduct;
            Mdao.Update(membre);
        }

        public void ReclamerForfait(decimal numBalade)
        {
            BaladeDAO dao = new BaladeDAO();
            InscriptionDAO Idao = new InscriptionDAO();
            MembreDAO Mdao = new MembreDAO();
            Membre membre = new Membre();

            decimal forfait = dao.recupForfait(numBalade);


            foreach (Decimal d in Idao.FindPersonneInscrit(numBalade))
            {
                membre = Mdao.Find(d);
                System.Diagnostics.Debug.WriteLine(membre);
                membre.Solde = membre.Solde + forfait;
                Mdao.Update(membre);
            }
        }

    }
}
