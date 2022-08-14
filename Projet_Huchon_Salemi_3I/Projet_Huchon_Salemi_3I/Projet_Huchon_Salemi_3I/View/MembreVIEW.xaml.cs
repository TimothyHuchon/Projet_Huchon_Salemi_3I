using Projet_Huchon_Salemi_3I.DAO;
using Projet_Huchon_Salemi_3I.metier;
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

namespace Projet_Huchon_Salemi_3I.View
{
    /// <summary>
    /// Logique d'interaction pour Membre.xaml
    /// </summary>
    public partial class MembreVIEW : Window
    {
        public Personne personne = new Personne();
        public PersonneDAO dao = new PersonneDAO();

        public MembreVIEW()
        {
            InitializeComponent();
            personne = dao.Find(1);
            Main.Content = new HomeVIEW();
        }

        private void MaxBtn_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }
            else
            {
                if (WindowState == WindowState.Maximized)
                {
                    WindowState = WindowState.Normal;
                }
            }
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void Main_ContentRendered(object sender, EventArgs e)
        {
            Main.NavigationUIVisibility = NavigationUIVisibility.Hidden;
        }

        private void MenuItem_home_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new HomeVIEW();
        }
        private void MenuItem_Dispo_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new DisponibilitéVIEW(personne);
        }

        public void MenuItem_Velo_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new VeloVIEW(personne);
        }

        private void MenuItem_Reserv_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new ReservationVIEW(personne);
        }

        private void MenuItem_Pay_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new PaiementVIEW(personne);
        }
        private void MenuItem_Cat_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new CategorieVIEW(personne);
        }
        private void MenuItem_Deco_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            LogIn x = new LogIn();
            x.ShowDialog();
        }

    }
}
