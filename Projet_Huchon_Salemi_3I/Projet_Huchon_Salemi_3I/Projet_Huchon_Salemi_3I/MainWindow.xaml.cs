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
                baladeDAO.Delete(balade8);*/

            /* Inscription inscription = new Inscription(false, false);
             InscriptionDAO inscriptionDAO = new InscriptionDAO();
             inscriptionDAO.Create(inscription);*/

            /* Inscription inscription = new Inscription(10,true, true);
             InscriptionDAO inscriptionDAO = new InscriptionDAO();
             inscriptionDAO.Update(inscription);*/

            /* Inscription inscription = new Inscription(11);
             InscriptionDAO inscriptionDAO = new InscriptionDAO();
             inscriptionDAO.Delete(inscription);*/
            
            Balade balade = new Balade();
            balade.ajouterVehicule(3,2);

            /*Vehicule vehicule = new Vehicule();
            VehiculeDAO vehiculeDAO = new VehiculeDAO();
            vehicule = vehiculeDAO.Find(1);*/

        }
    }
}
