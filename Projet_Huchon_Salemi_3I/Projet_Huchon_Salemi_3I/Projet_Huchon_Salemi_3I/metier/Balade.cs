﻿using Projet_Huchon_Salemi_3I.DAO;
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
        private decimal forfait;
        public List<Vehicule> listeVehicule = new List<Vehicule>();
        public List<Inscription> listeInscription = new List<Inscription>();
        public decimal id_calendrier;

        public Balade()
        {
        }

        public Balade(int num, string lieuDepart, DateTime dateDepart, decimal forfait)
        {
            this.num = num;
            this.lieuDepart = lieuDepart;
            this.dateDepart = dateDepart;
            this.forfait = forfait;
        }

        public Balade(int num, string lieuDepart, DateTime dateDepart, decimal forfait, List<Vehicule> listeVehicule, List<Inscription> listeInscription, decimal id_calendrier)
        {
            this.num = num;
            this.lieuDepart = lieuDepart;
            this.dateDepart = dateDepart;
            this.forfait = forfait;
            this.listeVehicule = listeVehicule;
            this.listeInscription = listeInscription;
            this.CalendrierBalade = id_calendrier;
        }


        public int Num { get => num; set => num = value; }
        public string LieuDepart { get => lieuDepart; set => lieuDepart = value; }
        public DateTime DateDepart { get => dateDepart; set => dateDepart = value; }
        public decimal Forfait { get => forfait; set => forfait = value; }
        internal List<Vehicule> ListeVehicule { get => listeVehicule; set => listeVehicule = value; }
        internal List<Inscription> ListeInscription { get => listeInscription; set => listeInscription = value; }
        internal decimal CalendrierBalade { get => id_calendrier; set => id_calendrier = value; }

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

        public int obtenirPlacesMembreTotal(int num)
        {
            int totalNbrePlaces = 0;

            BaladeDAO baladeDAO = new BaladeDAO();
            Balade balade = new Balade();

            balade = baladeDAO.Find(num);

            foreach (Vehicule i in balade.listeVehicule)
            {
                totalNbrePlaces = totalNbrePlaces + (int) i.NbrePlacesMembre;
            }
            return totalNbrePlaces;
        }

        public int obtenirPlacesMembreRestantes(int num)
        {
            int placesRestantes = 0;
            int membresReservations = 0;

            BaladeDAO baladeDAO = new BaladeDAO();
            Balade balade = new Balade();

            balade = baladeDAO.Find(num);
            foreach (Inscription i in balade.listeInscription)
            {
                if (i.Passager)
                {
                    membresReservations++;
                }
            }
            int totalNbrePlaces = obtenirPlacesMembreTotal(num);
            placesRestantes = totalNbrePlaces - membresReservations;

            return placesRestantes; 
        }

        public int obtenirPlacesVeloTotal(int num)
        {
            int totalNbrePlaces = 0;

            BaladeDAO baladeDAO = new BaladeDAO();
            Balade balade = new Balade();

            balade = baladeDAO.Find(num);

            foreach(Vehicule i in balade.listeVehicule)
            {
                totalNbrePlaces = totalNbrePlaces + (int) i.NbrePlacesVelo;
            }
            return totalNbrePlaces;
        }

        public int obtenirPlacesVeloRestantes(int num)
        {
            int placesRestantes = 0;
            int veloReservations = 0;

            BaladeDAO baladeDAO = new BaladeDAO();
            Balade balade = new Balade();

            balade = baladeDAO.Find(num);
            foreach(Inscription i in balade.listeInscription)
            {
                if (i.Passager)
                {
                    veloReservations++;
                }
            }
            int totalNbrePlacesVelo = obtenirPlacesVeloTotal(num);
            placesRestantes = totalNbrePlacesVelo - veloReservations;

            return placesRestantes;

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