using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Huchon_Salemi_3I.metier
{
    class Vehicule
    {
        private int nbrePlacesMembre;
        private int nbrePlacesVelo;

        public Vehicule(int nbrePlacesMembre, int nbrePlacesVelo)
        {
            this.NbrePlacesMembre = nbrePlacesMembre;
            this.NbrePlacesVelo = nbrePlacesVelo;
        }

        public int NbrePlacesMembre { get => nbrePlacesMembre; set => nbrePlacesMembre = value; }

        public int NbrePlacesVelo { get => nbrePlacesVelo; set => nbrePlacesVelo = value; }

        public override string ToString()
        {
            return "Vehicule: {"+
                " nbrePlacesMembre: "+NbrePlacesMembre+
                " nbrePlacesVelo: "+NbrePlacesVelo+
                " }";
        }
    }
}
