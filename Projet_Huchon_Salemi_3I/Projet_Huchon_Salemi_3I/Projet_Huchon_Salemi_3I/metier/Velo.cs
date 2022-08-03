using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Huchon_Salemi_3I.metier
{
    class Velo
    {
        private double poids;
        private string type;
        private double longueur;
        private Vehicule vehicule;
        private List<Inscription> listeInscription = new List<Inscription>();
        private Membre proprietaire;

        public Velo(double poids, string type, double longueur)
        {
            this.Poids = poids;
            this.Type = type;
            this.Longueur = longueur;
        }

        public double Poids { get => poids; set => poids = value; }
        public string Type { get => type; set => type = value; }
        public double Longueur { get => longueur; set => longueur = value; }
        internal Vehicule Vehicule { get => vehicule; set => vehicule = value; }
        internal List<Inscription> ListeInscription { get => listeInscription; set => listeInscription = value; }
        internal Membre Proprietaire { get => proprietaire; set => proprietaire = value; }

        public override string ToString()
        {
            return "Velo { " +
                " Poids: " + poids +
                " Type: " + type +
                " Longueur: " + longueur +
                " }";
        }
    }
}
