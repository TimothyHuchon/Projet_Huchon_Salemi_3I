using Projet_Huchon_Salemi_3I.metier;
using System;
using System.Collections.Generic;
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

             DAO.MembreDAO dao = new DAO.MembreDAO();
            Membre membre = new Membre();

              membre.calculSolde("Salemi", "Alessandro");
            
            // DAO.MembreDAO dao = new DAO.MembreDAO();
            // Membre membre = new Membre();
            // System.Diagnostics.Debug.WriteLine("l'id est donc = " + membre.verifierSolde("Salemi", "Alessandro"));
        }
    }
}
