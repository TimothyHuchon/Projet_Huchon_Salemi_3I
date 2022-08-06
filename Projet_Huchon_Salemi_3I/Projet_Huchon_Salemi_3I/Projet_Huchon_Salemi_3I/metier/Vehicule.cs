using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Huchon_Salemi_3I.metier
{
    class Vehicule
    {
        private int nbrePlacesMembre;
        private int nbrePlacesVelo;
        private Membre conducteur;
        private List<Membre> passagers = new List<Membre>();
        private List<Velo> listeVelo = new List<Velo>();

        public Vehicule(int nbrePlacesMembre, int nbrePlacesVelo)
        {
            this.NbrePlacesMembre = nbrePlacesMembre;
            this.NbrePlacesVelo = nbrePlacesVelo;
        }

        public int NbrePlacesMembre { get => nbrePlacesMembre; set => nbrePlacesMembre = value; }
        public int NbrePlacesVelo { get => nbrePlacesVelo; set => nbrePlacesVelo = value; }
        internal Membre Conducteur { get => conducteur; set => conducteur = value; }
        internal List<Membre> Passagers { get => passagers; set => passagers = value; }
        internal List<Velo> ListeVelo { get => listeVelo; set => listeVelo = value; }

        public override string ToString()
        {
            return "Vehicule: {" +
                " nbrePlacesMembre: " + NbrePlacesMembre +
                " nbrePlacesVelo: " + NbrePlacesVelo +
                " }";
        }
    }
}

