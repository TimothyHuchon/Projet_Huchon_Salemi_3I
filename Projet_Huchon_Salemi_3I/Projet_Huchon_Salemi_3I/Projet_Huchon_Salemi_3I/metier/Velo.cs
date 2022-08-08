using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Huchon_Salemi_3I.metier
{
    public class Velo
    {
        private decimal id_velo;
        private decimal poids;
        private string type;
        private decimal longueur;
        private decimal id_vehicule;
        private List<Inscription> listeInscription = new List<Inscription>();
        private decimal id_personne;

        public Velo(decimal poids, string type, decimal longueur)
        {
            this.Poids = poids;
            this.Type = type;
            this.Longueur = longueur;
        }

        public Velo(decimal id_personne, decimal id_vehicule, decimal poids, string type, decimal longueur)
        {
            this.Proprietaire = id_personne;
            this.Vehicule = id_vehicule;
            this.Poids = poids;
            this.Type = type;
            this.Longueur = longueur;
        }

        public Velo() { }

        public decimal ID { get => id_velo; set => id_velo = value; }
        public decimal Poids { get => poids; set => poids = value; }
        public string Type { get => type; set => type = value; }
        public decimal Longueur { get => longueur; set => longueur = value; }
        internal decimal Vehicule { get => id_vehicule; set => id_vehicule = value; }
        internal List<Inscription> ListeInscription { get => listeInscription; set => listeInscription = value; }
        internal decimal Proprietaire { get => id_vehicule; set => id_vehicule = value; }

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
