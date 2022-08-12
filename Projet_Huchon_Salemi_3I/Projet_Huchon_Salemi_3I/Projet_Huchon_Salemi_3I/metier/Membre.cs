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

        public Membre(string nom, string prenom, string tel, string id, string motDePasse, decimal solde)
        : base(nom, prenom, tel, id, motDePasse)
        {
            this.solde = solde;
        }

        public Membre(decimal id_personne, decimal solde, decimal cptBanquaire)
        {
            this.id_personne = id_personne;
            this.solde = solde;
            this.cptBanquaire = cptBanquaire;
        }

        public Membre() { }

        public decimal ID_personne { get => id_personne; set => id_personne = value; }
        public decimal Solde { get => solde; set => solde = value; }
        public decimal CptBanquaire { get => cptBanquaire; set => cptBanquaire = value; }


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
            DAO.MembreDAO dao = new DAO.MembreDAO();
            Personne personne = new Personne();
            decimal id = personne.GetidUser(nom, prenom);
            decimal total = dao.TotalofAbonnementCat(id);
            decimal cpt = dao.RecupCptBancaire(id);

            if (total >= 2)
            {
                for (int i = 0; i < (total - 1); i = i + 1)
                {
                    solde = solde + 5;
                }
                solde = solde + 20;


                Membre membre = new Membre(id, solde, cpt);
                System.Diagnostics.Debug.WriteLine(membre);
                dao.Update(membre);
            }
            else
            {
                solde = 20;
                Membre membre = new Membre(id, solde, cpt);
                dao.Update(membre);
            }

        }

        public decimal verifierSolde(String nom, String prenom)
        {
            DAO.MembreDAO dao = new DAO.MembreDAO();
            Personne personne = new Personne();

            decimal id = personne.GetidUser(nom, prenom);

            return dao.RecupSolde(id);
        }

        public void soldeToZero(String nom, String prenom)
        {
            DAO.MembreDAO dao = new DAO.MembreDAO();
            Personne personne = new Personne();
            decimal id = personne.GetidUser(nom, prenom);
            decimal cpt = dao.RecupCptBancaire(id);
            Membre membre = new Membre(id, 0, cpt);
            dao.Update(membre);
        }
    }
}
