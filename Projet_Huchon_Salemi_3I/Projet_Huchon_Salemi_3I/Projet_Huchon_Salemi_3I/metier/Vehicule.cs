using Projet_Huchon_Salemi_3I.DAO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Huchon_Salemi_3I.metier
{
    public class Vehicule
    {
        private Decimal id_vehicule;
        private Decimal id_personne_conducteur;
        private Decimal nbrePlacesMembre;
        private Decimal nbrePlacesVelo;
        private Membre conducteur;
        private List<Membre> passagers = new List<Membre>();
        private List<Velo> listeVelo = new List<Velo>();

        public Vehicule(){}

        public Vehicule(Decimal nbrePlacesMembre, Decimal nbrePlacesVelo)
        {
            this.NbrePlacesMembre = nbrePlacesMembre;
            this.NbrePlacesVelo = nbrePlacesVelo;
        }

        public Vehicule(Decimal id_personne_conducteur, Decimal nbrePlacesMembre, Decimal nbrePlacesVelo)
        {
            this.ID_personne_conducteur = id_personne_conducteur;
            this.NbrePlacesMembre = nbrePlacesMembre;
            this.NbrePlacesVelo = nbrePlacesVelo;
        }

        public Decimal ID_vehicule { get => id_vehicule; set => id_vehicule = value; }
        public Decimal ID_personne_conducteur { get => id_personne_conducteur; set => id_personne_conducteur = value; }
        public Decimal NbrePlacesMembre { get => nbrePlacesMembre; set => nbrePlacesMembre = value; }
        public Decimal NbrePlacesVelo { get => nbrePlacesVelo; set => nbrePlacesVelo = value; }
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

        public Vehicule MembreByVehicule(String nom, String prenom)
        {
            Personne personne = new Personne();
            decimal id = personne.GetidUser(nom, prenom);

            VehiculeDAO dao = new VehiculeDAO();

            return dao.VehiculeByMembre(id);
        }

        public void AjouterPassager(String nom, String prenom)
        {
            Personne personne = new Personne();
            decimal id = personne.GetidUser(nom, prenom);

            VehiculeDAO dao = new VehiculeDAO();

            dao.AjoutPassager(id, this);

        }

        public void ajouterVelo(decimal idvelo, String nom, String prenom)
        {
            Personne personne = new Personne();
            decimal id = personne.GetidUser(nom, prenom);
            

            VehiculeDAO dao = new VehiculeDAO();
            dao.AjoutVelo(id,idvelo, this);
        }
    }
}

