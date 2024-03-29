﻿using Projet_Huchon_Salemi_3I.DAO;
using System;
using System.Collections.Generic;
using System.Text;


namespace Projet_Huchon_Salemi_3I.metier
{
    class Balade
    {
        public decimal id_vehicule;
        private decimal num;
        private string lieuDepart;
        private DateTime dateDepart;
        private decimal forfait;
        public List<Vehicule> listeVehicule = new List<Vehicule>();
        public List<Inscription> listeInscription = new List<Inscription>();
        public decimal id_calendrier;

        public Balade()
        {
        }

        public Balade(string lieuDepart, DateTime dateDepart, decimal forfait)
        {
            this.lieuDepart = lieuDepart;
            this.dateDepart = dateDepart;
            this.forfait = forfait;
        }

        public decimal Num { get => num; set => num = value; }
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

            if (placesRestantes > 0) return placesRestantes;
            else return 0;
        }

        public int obtenirPlacesVeloTotal(int num)
        {
            int totalNbrePlaces = 0;

            BaladeDAO baladeDAO = new BaladeDAO();
            Balade balade = new Balade();

            balade = baladeDAO.Find(num);
            foreach (Vehicule i in balade.listeVehicule)
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
            foreach (Inscription i in balade.listeInscription)
            {
                if (i.Passager)
                {
                    veloReservations++;
                }
            }
            int totalNbrePlacesVelo = obtenirPlacesVeloTotal(num);
            placesRestantes = totalNbrePlacesVelo - veloReservations;

            if (placesRestantes > 0) return placesRestantes;
            else return 0;

        }

        public int obtenirPlacesMembreBesoin(int num)
        {
            int placesRestantes = 0;
            int membreReservation = 0;

            BaladeDAO baladeDAO = new BaladeDAO();
            Balade balade = new Balade();

            balade = baladeDAO.Find(num);            
            foreach (Inscription i in balade.listeInscription)
            {
                if (i.Passager) membreReservation++;
            }
            int totalNbrePlaces = obtenirPlacesMembreTotal(num);
            placesRestantes = totalNbrePlaces - membreReservation;

            if (placesRestantes < 0)
            {
                placesRestantes = Math.Abs(placesRestantes);
                return placesRestantes;
            }
            else return 0;

        }

        public int obtenirPlaceVeloBesoin(int num)
        {
            int placesRestantesVelo = 0;
            int veloReservations = 0;

            BaladeDAO baladeDAO = new BaladeDAO();
            Balade balade = new Balade();

            balade = baladeDAO.Find(num);
            foreach (Inscription i in balade.listeInscription)
            {
                if (i.Velo) veloReservations++;
            }
            int totalNbrePlacesVelo = obtenirPlacesVeloTotal(num);
            placesRestantesVelo = totalNbrePlacesVelo - veloReservations;

            if (placesRestantesVelo < 0)
            {
                placesRestantesVelo = Math.Abs(placesRestantesVelo);
                return placesRestantesVelo;
            }
            else return 0;
        }

        public void ajouterVehicule(Decimal numVehi, Decimal numBal)
        {

            BaladeDAO baladeDAO = new BaladeDAO();


            baladeDAO.CreateTransport(numVehi, numBal);
        }
    }
}