using Projet_Huchon_Salemi_3I.DAO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Huchon_Salemi_3I.metier
{
    public class Membre : Personne
    {
        private decimal id_personne;
        private decimal solde;
        private decimal cptBanquaire;
        private bool message;


        public Membre(decimal id_personne, decimal solde, decimal cptBanquaire)
        {
            this.id_personne = id_personne;
            this.solde = solde;
            this.cptBanquaire = cptBanquaire;
        }

        public Membre(decimal id_personne, decimal solde, decimal cptBanquaire, bool message)
        {
            this.id_personne = id_personne;
            this.solde = solde;
            this.cptBanquaire = cptBanquaire;
            this.message = message;
        }

        public Membre() { }

        public decimal Id_personne { get => id_personne; set => id_personne = value; }
        public decimal Solde { get => solde; set => solde = value; }
        public decimal CptBanquaire { get => cptBanquaire; set => cptBanquaire = value; }
        public bool Message { get => message; set => message = value; }

        public override string ToString()
        {
            return "Membre { " +
                " id: " + ID_personne +
                " nom: " + Nom +
                " prenom: " + Prenom +
                " tel: " + Tel +
                " id: " + Id +
                " motDePasse: " + MotDePasse +
                " solde: " + solde +
                " cpt : " + cptBanquaire +

                " }";
        }

        public void calculSolde(String nom, String prenom)
        {
            decimal solde = 0;
            MembreDAO dao = new MembreDAO();
            Personne personne = new Personne();
            decimal id = personne.GetidUser(nom, prenom);
            decimal total = dao.TotalofAbonnementCat(id);

            if (total > 1)
            {
                solde = solde + 5;

                Membre membre = dao.Find(id);
                membre.Solde = membre.Solde + solde;
                dao.Update(membre);
            }
            else
            {
                solde = 20;
                Membre membre = dao.Find(id);
                membre.Solde = membre.Solde + solde;
                dao.Update(membre);
            }

        }

        public decimal verifierSolde()
        {
            MembreDAO dao = new MembreDAO();
            return dao.RecupSolde(this.ID_personne);
        }

        public void paiementUpdate(decimal cpt)
        {
            DAO.MembreDAO dao = new DAO.MembreDAO();
            Membre membre = new Membre(this.ID_personne, 0, cpt);
            dao.Update(membre);
        }
    }
}
