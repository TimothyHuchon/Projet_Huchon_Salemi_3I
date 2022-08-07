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
            System.Diagnostics.Debug.WriteLine(" LE NOMBRE DE PLACES TOTAL EST : " + placetotal);

            Balade balade1 = new Balade();
            int placetotal1 = balade1.obtenirPlacesVeloTotal(2);
            System.Diagnostics.Debug.WriteLine(" LE NOMBRE DE PLACES VELO TOTAL EST : " + placetotal1);*/

            Balade balade2 = new Balade();
            int placesRestantes = balade2.obtenirPlacesMembreRestantes(1);
            System.Diagnostics.Debug.WriteLine(" LE NOMBRE DE PLACES MEMBRE RESTANTES EST : " + placesRestantes);


        }
    }
}
