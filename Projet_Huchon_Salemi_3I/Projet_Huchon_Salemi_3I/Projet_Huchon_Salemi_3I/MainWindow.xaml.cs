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

            //Vehicule v = new Vehicule();
            //Velo velo = new Velo(5,"VTT",127);
            // Vehicule v2 = new Vehicule();
            // v.ajouterVelo(velo,"Salemi","Alessandro");
            Vehicule v = new Vehicule(1,5,7);
            v.ID_vehicule = 2;
            VehiculeDAO dao = new VehiculeDAO();
            dao.Delete(v);
          
            System.Diagnostics.Debug.WriteLine(" LE NOMBRE DE PLACES MEMBRE RESTANTES EST : " );


        }
    }
}
