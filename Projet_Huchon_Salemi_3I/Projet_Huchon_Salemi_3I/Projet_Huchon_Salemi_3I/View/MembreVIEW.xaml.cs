﻿using System;
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
            modifBtn.Visibility = Visibility.Visible;

            switch (value)
            {
                case "Responsable": responsable.Visibility = Visibility.Visible;
                                    break;
                case "Tresorier": tresorier.Visibility = Visibility.Visible;
                                 break;
                default: break;
                
            }
        }

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
            modifBtn.Visibility = Visibility.Visible;
            
            PersonneDAO personneDAO = new PersonneDAO();
            Personne userModif = new Personne();
            userModif = personneDAO.Find(user.ID_personne);
            Main.Content = new HomeVIEW(userModif);
        }
        private void MenuItem_Dispo_Click(object sender, RoutedEventArgs e)
        {
            modifBtn.Visibility = Visibility.Hidden;
            PersonneDAO personneDAO = new PersonneDAO();
            Personne userModif = new Personne();
            userModif = personneDAO.Find(user.ID_personne);
            Main.Content = new DisponibilitéVIEW(userModif);
        }

        private void MenuItem_Velo_Click(object sender, RoutedEventArgs e)
        {
            modifBtn.Visibility = Visibility.Hidden;
            PersonneDAO personneDAO = new PersonneDAO();
            Personne userModif = new Personne();
            userModif = personneDAO.Find(user.ID_personne);
            Main.Content = new VeloVIEW(userModif);
        }

        private void MenuItem_Reserv_Click(object sender, RoutedEventArgs e)
        {
            modifBtn.Visibility = Visibility.Hidden;
            PersonneDAO personneDAO = new PersonneDAO();
            Personne userModif = new Personne();
            userModif = personneDAO.Find(user.ID_personne);
            Main.Content = new ReservationVIEW(userModif);
        }

        private void MenuItem_Pay_Click(object sender, RoutedEventArgs e)
        {
            modifBtn.Visibility = Visibility.Hidden;
            PersonneDAO personneDAO = new PersonneDAO();
            Personne userModif = new Personne();
            userModif = personneDAO.Find(user.ID_personne);
            Main.Content = new PaiementVIEW(userModif);
        }
        private void MenuItem_Cat_Click(object sender, RoutedEventArgs e)
        {
            modifBtn.Visibility = Visibility.Hidden;
            PersonneDAO personneDAO = new PersonneDAO();
            Personne userModif = new Personne();
            userModif = personneDAO.Find(user.ID_personne);
            Main.Content = new CategorieVIEW(userModif);
        }

        private void signOut_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            LogIn signOut = new LogIn();
            signOut.ShowDialog();
        }

        private void modifBtn_Click(object sender, RoutedEventArgs e)
        {
            modifBtn.Visibility = Visibility.Hidden;
            PersonneDAO personneDAO = new PersonneDAO();
            Personne userModif = new Personne();
            userModif = personneDAO.Find(user.ID_personne);
            Main.Content = new UpdateMembreView(userModif);
        }

        private void responsable_Click(object sender, RoutedEventArgs e)
        {
            modifBtn.Visibility = Visibility.Hidden;
            PersonneDAO personneDAO = new PersonneDAO();
            Personne userModif = new Personne();
            userModif = personneDAO.Find(user.ID_personne);
            Main.Content = new ResponsableVIEW(userModif);
        }

        private void info_Click(object sender, RoutedEventArgs e)
        {
            modifBtn.Visibility = Visibility.Hidden;
            Main.Content = new RecapBaladeVIEW();
        }

        private void tresorier_Click(object sender, RoutedEventArgs e)
        {
            modifBtn.Visibility = Visibility.Hidden;
            PersonneDAO personneDAO = new PersonneDAO();
            Personne userModif = new Personne();
            userModif = personneDAO.Find(user.ID_personne);
            Main.Content = new TresorieVIEW(userModif);
        }
    }
}
