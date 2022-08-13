using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Projet_Huchon_Salemi_3I.metier;
using Projet_Huchon_Salemi_3I.DAO;

namespace Projet_Huchon_Salemi_3I.View
{
    /// <summary>
    /// Logique d'interaction pour Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home(Personne personne)
        {
            InitializeComponent();
            profilNom.Text = personne.Nom;
            profilPrenom.Text = personne.Prenom;
            profilTel.Text = personne.Tel;
            identifiantID.Text = personne.Id;
            identifiantPassword.Text = personne.MotDePasse;

            //Projet_Huchon_Salemi_3I.metier.Membre membre = new Projet_Huchon_Salemi_3I.metier.Membre();
            // MembreDAO membreDAO = new MembreDAO();
            // membre = membreDAO.Find(personne.ID_personne);


            /*Projet_Huchon_Salemi_3I.metier.Velo velo = new Projet_Huchon_Salemi_3I.metier.Velo();
            VeloDAO veloDAO = new VeloDAO();
            velo = veloDAO.FindByMembre(personne.ID_personne);
            veloPoid.Text = ""+velo.Poids;
            veloType.Text = velo.Type;
            veloLongueur.Text = ""+velo.Longueur;*/

            Vehicule vehicule = new Vehicule();
            VehiculeDAO vehiculeDAO = new VehiculeDAO();
            vehicule = vehiculeDAO.VehiculeByMembre(personne.ID_personne);
            vehiculeNbrePassagers.Text = ""+vehicule.NbrePlacesMembre;
            vehiculeNbreVelos.Text = ""+vehicule.NbrePlacesVelo;
        }
    }
}
