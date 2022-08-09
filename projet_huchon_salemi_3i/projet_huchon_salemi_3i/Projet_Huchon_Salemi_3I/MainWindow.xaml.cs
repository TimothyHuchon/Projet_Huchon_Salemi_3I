using Projet_Huchon_Salemi_3I.DAO;
using Projet_Huchon_Salemi_3I.metier;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace Projet_Huchon_Salemi_3I
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /*  Personne personne = new Personne();
                decimal id = personne.CheckidUser("Salemi", "Alessandro");
                System.Diagnostics.Debug.WriteLine("l'id est donc = " + id);

                Balade balade = new Balade();
                int placetotal = balade.obtenirPlacesMembreTotal(1);
                System.Diagnostics.Debug.WriteLine(" LE NOMBRE DE PLACES MEMBRE TOTAL EST : " + placetotal);

                Balade balade1 = new Balade();
                int placetotal1 = balade1.obtenirPlacesVeloTotal(1);
                System.Diagnostics.Debug.WriteLine(" LE NOMBRE DE PLACES VELO TOTAL EST : " + placetotal1);

                Balade balade2 = new Balade();
                int placesRestantes = balade2.obtenirPlacesMembreRestantes(1);
                System.Diagnostics.Debug.WriteLine(" LE NOMBRE DE PLACES MEMBRE RESTANTES EST : " + placesRestantes);

                Balade balade3 = new Balade();
                int placesRestantes1 = balade3.obtenirPlacesVeloRestantes(1);
                System.Diagnostics.Debug.WriteLine(" LE NOMBRE DE PLACES  velo RESTANTES EST : " + placesRestantes1);

                Balade balade4 = new Balade();
                int placesBesoin = balade4.obtenirPlacesMembreBesoin(1);
                System.Diagnostics.Debug.WriteLine(" besoin de place membre : " + placesBesoin);

                Balade balade5 = new Balade();
                int placesBesoinvelo = balade5.obtenirPlaceVeloBesoin(1);
                System.Diagnostics.Debug.WriteLine(" besoin de place velo : " + placesBesoinvelo);

                Balade balade6 = new Balade("Dour",new DateTime(2022,10,26),12);
                BaladeDAO baladeDAO = new BaladeDAO();
                baladeDAO.Create(balade6);

                Balade balade7 = new Balade(3,"Elouges", new DateTime(2022, 11, 27), 14);
                BaladeDAO baladeDAO = new BaladeDAO();
                baladeDAO.Update(balade7);

                Balade balade8 = new Balade(3);
                BaladeDAO baladeDAO = new BaladeDAO();
                baladeDAO.Delete(balade8);

                Inscription inscription = new Inscription(false, false);
                InscriptionDAO inscriptionDAO = new InscriptionDAO();
                inscriptionDAO.Create(inscription);

                Inscription inscription = new Inscription(10,true, true);
                InscriptionDAO inscriptionDAO = new InscriptionDAO();
                inscriptionDAO.Update(inscription);

                Inscription inscription = new Inscription(11);
                InscriptionDAO inscriptionDAO = new InscriptionDAO();
                inscriptionDAO.Delete(inscription);
            
                Balade balade = new Balade();
                balade.ajouterVehicule(3,2);

                Vehicule vehicule = new Vehicule();
                VehiculeDAO vehiculeDAO = new VehiculeDAO();
                vehicule = vehiculeDAO.Find(1);*/

            /* ------------- Balade ------------- */


            /* ------------- Calendrier ------------- */
           /* Calendrier calendrier = new Calendrier(1);
            CalendrierDAO calendrierDao = new CalendrierDAO();
            calendrierDao.Create(calendrier);

            Calendrier calendrier1 = new Calendrier();
            CalendrierDAO calendrierDao1 = new CalendrierDAO();
            calendrierDao1.Delete(calendrier1);

            Calendrier calendrier2 = new Calendrier();
            CalendrierDAO calendrierDAO2 = new CalendrierDAO();
            calendrierDAO2.Update(calendrier2);

            Calendrier calendrier3 = new Calendrier();
            CalendrierDAO calendrierDAO3 = new CalendrierDAO();
            calendrierDAO3.Find(1);*/


            /* ------------- Inscription ------------- */
            /*Inscription inscription = new Inscription(1);
            InscriptionDAO inscriptionDao = new InscriptionDAO();
            calendrierDao.Create(inscription);

            Inscription inscription1 = new Inscription();
            InscriptionDAO inscriptionDao1 = new InscriptionDAO();
            inscriptionDao1.Delete(inscription1);

            Inscription inscription2 = new Inscription();
            InscriptionDAO inscriptionDAO2 = newInscriptionDAO();
            calendrierDAO2.Update(inscription2);

            Inscription inscription3 = new Inscription();
            InscriptionDAO inscriptionDAO3 = new InscriptionDAO();
            calendrierDAO3.Find(1);*/

            /* ------------- Membre ------------- */

           /* Membre membre = new Membre(1);
            MembreDAO membreDao = new MembreDAO();
            calendrierDao.Create(membre);

            Membre membre1 = new Membre();
            Membre membreDao1 = new MembreDAO();
            membreDao1.Delete(membre1);

            Membre membre2 = new Membre();
            MembreDAO membreDAO2 = newMembreDAO();
            calendrierDAO2.Update(membre2);

            Membre membre3 = new Membre();
            MembreDAO membreDAO3 = new MembreDAO();
            membreDAO3.Find(1);*/
            /* ------------- Personne ------------- */

           /* Personne personne = new Personne(1);
            PersonneDAO personneDao = new PersonneDAO();
            personneDao.Create(personne);

            Personne personne1 = new Personne();
            PersonneDAO personneDao1 = new PersonneDAO();
            personneDao1.Delete(personne1);

            Personne personne2 = new Personne();
            PersonneDAO personneDAO2 = new PersonneDAO();
            personneDAO2.Update(personne2);

            Personne personne3 = new Personne();
            PersonneDAO personneDAO3 = new PersonneDAO();
            personneDAO3.Find(1);

            Personne personne4 = new Personne();
            decimal id = personne4.CheckidUser("Salemi", "Alessandro");
            System.Diagnostics.Debug.WriteLine("l'id est donc = " + id);*/

            /* ------------- Responsable ------------- */

          /*  Responsable responsable = new Responsable(1);
            ResponsableDAO responsableDao = new ResponsableDAO();
            responsableDao.Create(responsable);

            Responsable responsable1 = new Responsable();
            ResponsableDAO responsableDao1 = new ResponsableDAO();
            responsableDao1.Delete(responsable1);

            Responsable responsable2 = new Responsable();
            ResponsableDAO responsableDAO2 = new ResponsableDAO();
            responsableDAO2.Update(responsable2);

            Responsable responsable3 = new Responsable();
            ResponsableDAO responsableDAO3 = new ResponsableDAO();
            responsableDAO3.Find(1);*/
            /* ------------- Tresorier ------------- */

          /*Tresorier tresorier = new Tresorier(1);
            TresorierDAO tresorierDao = new TresorierDAO();
            tresorierDao.Create(tresorier);

            Tresorier tresorier1 = new Tresorier();
            TresorierDAO tresorierDao1 = new TresorierDAO();
            tresorierDao1.Delete(tresorier1);

            Tresorier tresorier2 = new Tresorier();
            TresorierDAO tresorierDAO2 = new TresorierDAO();
            calendrierDAO2.Update(tresorier2);

            Tresorier tresorier3 = new Tresorier();
            TresorierDAO tresorierDAO3 = new TresorierDAO();
            tresorierDao.Find(1);*/
            /* ------------- Vehicule ------------- */

          /*  Vehicule vehicule = new Vehicule(1);
            VehiculeDAO vehiculeDao = new VehiculeDAO();
            vehiculeDao.Create(vehicule);

            Vehicule vehicule1 = new Vehicule();
            VehiculeDAO vehiculeDao1 = new VehiculeDAO();
            vehiculeDao1.Delete(vehicule1);

            Vehicule vehicule2 = new Vehicule();
            VehiculeDAO vehiculeDAO2 = new VehiculeDAO();
            vehiculeDAO2.Update(vehicule2);

            Vehicule vehicule3 = new Vehicule();
            VehiculeDAO vehiculeDAO3 = new VehiculeDAO();
            vehiculeDAO3.Find(1);*/
            /* ------------- Velo ------------- */

          /*  Velo velo = new Velo(1);
            VeloDAO veloDao = new VeloDAO();
            veloDao.Create(velo);

            Velo velo1 = new Velo();
            VeloDAO veloDao1 = new VeloDAO();
            veloDao1.Delete(velo1);

            Velo velo2 = new Velo();
            VeloDAO veloDAO2 = new VeloDAO();
            veloDAO2.Update(velo2);

            Velo velo3 = new Velo();
            VeloDAO veloDAO3 = new VeloDAO();
            veloDAO3.Find(1);
          */



        }
    }
}
