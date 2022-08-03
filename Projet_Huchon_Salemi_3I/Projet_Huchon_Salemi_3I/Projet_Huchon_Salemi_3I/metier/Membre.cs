using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Huchon_Salemi_3I.metier
{
    class Membre : Personne
    {
        private double solde;
        private Vehicule vehiculeproprietaire;
        private List<Vehicule> whereIAmPassager = new List<Vehicule>();
        private List<Categorie> mesCategories = new List<Categorie>();
        private List<Inscription> listeInscription = new List<Inscription>();
        private List<Velo> listeVelo = new List<Velo>();


        public Membre(string nom, string prenom, string tel, string id, string motDePasse, double solde)
            : base(nom, prenom, tel, id, motDePasse)
        {
            this.Solde = solde;
        }

        public double Solde { get => solde; set => solde = value; }
        internal Vehicule Vehiculeproprietaire { get => vehiculeproprietaire; set => vehiculeproprietaire = value; }
        internal List<Vehicule> WhereIAmPassager { get => whereIAmPassager; set => whereIAmPassager = value; }
        internal List<Categorie> MesCategories { get => mesCategories; set => mesCategories = value; }
        internal List<Inscription> ListeInscription { get => listeInscription; set => listeInscription = value; }
        internal List<Velo> ListeVelo { get => listeVelo; set => listeVelo = value; }

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
