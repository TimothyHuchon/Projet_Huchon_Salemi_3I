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
    public partial class Membre : Window
    {
        public Membre()
        {
            InitializeComponent();
            Main.Content = new Home();
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
            Main.Content = new Home();
        }
        private void MenuItem_Dispo_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Disponibilité();
        }

        private void MenuItem_Velo_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Velo();
        }

        private void MenuItem_Reserv_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Reservation();
        }

        private void MenuItem_Pay_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Paiement();
        }
        private void MenuItem_Cat_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Categorie();
        }

    }
}
