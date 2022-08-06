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
        public Calendrier Calendrier;

        public Balade()
        {
        }

        public Balade(int num, string lieuDepart, DateTime dateDepart, double forfait)
        {
            this.num = num;
            this.lieuDepart = lieuDepart;
            this.dateDepart = dateDepart;
            this.forfait = forfait;
        }

        public Balade(int num, string lieuDepart, DateTime dateDepart, double forfait, List<Vehicule> listeVehicule, List<Inscription> listeInscription, Calendrier calendrier)
        {
            this.num = num;
            this.lieuDepart = lieuDepart;
            this.dateDepart = dateDepart;
            this.forfait = forfait;
            this.listeVehicule = listeVehicule;
            this.listeInscription = listeInscription;
            this.Calendrier = calendrier;
        }


        public int Num { get => num; set => num = value; }
        public string LieuDepart { get => lieuDepart; set => lieuDepart = value; }
        public DateTime DateDepart { get => dateDepart; set => dateDepart = value; }
        public double Forfait { get => forfait; set => forfait = value; }
        internal List<Vehicule> ListeVehicule { get => listeVehicule; set => listeVehicule = value; }
        internal List<Inscription> ListeInscription { get => listeInscription; set => listeInscription = value; }
        internal Calendrier CalendrierBalade { get => Calendrier; set => Calendrier = value; }

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

        public int obtenirPlacesMembreTotal(List<Vehicule> listeVehicule)
        {
            int totalNbrePlaces = 0;
            foreach (Vehicule i in listeVehicule)
            {
                totalNbrePlaces = totalNbrePlaces + i.NbrePlacesMembre;
            }
            return totalNbrePlaces;
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