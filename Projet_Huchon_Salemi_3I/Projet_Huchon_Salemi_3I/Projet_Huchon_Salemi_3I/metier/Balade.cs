using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Huchon_Salemi_3I.metier
{
    class Balade
    {
        private int num;
        private string lieuDepart;
        private DateTime dateDepart;
        private double forfait;
        public List<Vehicule> listeVehicule = new List<Vehicule>();
        public List<Inscription> listeInscription = new List<Inscription>();
        public Calendrier calendrier;


        public Balade(int num, string lieuDepart, DateTime dateDepart, double forfait)
        {
            this.Num = num;
            this.LieuDepart = lieuDepart;
            this.DateDepart = dateDepart;
            this.Forfait = forfait;
        }

        public int Num { get => num; set => num = value; }
        public string LieuDepart { get => lieuDepart; set => lieuDepart = value; }
        public DateTime DateDepart { get => dateDepart; set => dateDepart = value; }
        public double Forfait { get => forfait; set => forfait = value; }
        internal List<Vehicule> ListeVehicule { get => listeVehicule; set => listeVehicule = value; }
        internal List<Inscription> ListeInscription { get => listeInscription; set => listeInscription = value; }
        internal Calendrier CalendrierBalade { get => calendrier; set => calendrier = value; }

        public override bool Equals(object obj)
        {
            return obj is Balade balade &&
                   Num == balade.Num;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Num);
        }

        public override string ToString()
        {
            return "Balade { " +
                " num: " + num +
                " lieu: " + lieuDepart +
                " date: " + dateDepart +
                " forfait: " + forfait +
                " }";
        }

        public void obtenirPlacesMembreTotal()
        {

        }

        public void obtenirPlacesMembreRestantes()
        {

        }

        public void obtenirVeloTotal()
        {

        }

        public void obtenirVeloRestantes()
        {

        }

        public void obtenirPlacesMembreBesoin()
        {

        }

        public void obtenirPlaceVeloBesoin()
        {

        }

        public void ajouterVehicule()
        {

        }


    }
}