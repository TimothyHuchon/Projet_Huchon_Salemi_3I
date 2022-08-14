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
using MaterialDesignThemes.Wpf;

namespace Projet_Huchon_Salemi_3I.View
{
    /// <summary>
    /// Logique d'interaction pour Membre.xaml
    /// </summary>
    public partial class MembreVIEW : Window
    {
        public Personne user = new Personne();
        private string value;

        public MembreVIEW(Personne personne)
        {
            InitializeComponent();
            user = personne;
            Main.Content = new HomeVIEW(personne);
            value = personne.checkProfile(personne.ID_personne);

            switch (value)
            {
                case "Responsable": responsable.Visibility = Visibility.Visible;
                                    break;
                case "Tresorier": tresorier.Visibility = Visibility.Visible;
                                 break;
                default:
                   
                    break;
                
            }
        }

        /* TEST */


        public bool IsDarkTheme { get; set; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();

        private void themeToggle_Click(object sender, RoutedEventArgs e)
        {
            ITheme theme = paletteHelper.GetTheme();
            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);
            }
            else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);
            }
            paletteHelper.SetTheme(theme);
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        /* TEST */




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

            Main.Content = new HomeVIEW(user);
        }
        private void MenuItem_Dispo_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new DisponibilitéVIEW(user);
        }

        private void MenuItem_Velo_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new VeloVIEW(user);
        }

        private void MenuItem_Reserv_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new ReservationVIEW(user);
        }

        private void MenuItem_Pay_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new PaiementVIEW(user);
        }
        private void MenuItem_Cat_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new CategorieVIEW(user);
        }

        private void signOut_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            LogIn signOut = new LogIn();
            signOut.ShowDialog();
        }
    }
}
