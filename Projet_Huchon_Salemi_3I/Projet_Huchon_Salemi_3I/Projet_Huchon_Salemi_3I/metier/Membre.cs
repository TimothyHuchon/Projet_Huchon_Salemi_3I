using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Huchon_Salemi_3I.metier
{
    class Membre : Personne
    {
        private double solde;

        public Membre(string nom, string prenom, string tel, string id, string motDePasse,double solde)
            : base(nom, prenom, tel, id, motDePasse)
        {
            this.Solde = solde;
        }

        public double Solde { get => solde; set => solde = value; }

        public override string ToString()
        {
            return "Membre { " +
                " nom: " + Nom +
                " prenom: " + Prenom +
                " tel: " + Tel +
                " id: " + Id +
                " motDePasse: " + MotDePasse +
                " solde: " + solde +
                " }";
        }

        public void calculSolde()
        {

        }

        public void verifierSolde()
        {

        }
    }
}
