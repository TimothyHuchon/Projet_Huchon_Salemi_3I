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
using System.Windows.Shapes;
using MaterialDesignThemes.Wpf;
using Projet_Huchon_Salemi_3I.metier;
using Projet_Huchon_Salemi_3I.DAO;

namespace Projet_Huchon_Salemi_3I.View
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public string lastName = "";
        public string firstName = "";
        public string phone = "";
        public string id = "";
        public string password = "";
        public Register()
        {
            InitializeComponent();
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

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            LogIn login = new LogIn();
            login.ShowDialog();
        }

        private void signupBtn_Click(object sender, RoutedEventArgs e)
        {
            lastName = txtNom.Text;
            firstName = txtPrenom.Text;
            phone = txtTel.Text;
            id = txtID.Text;
            password = txtPassWord.Password;

            if (lastName != "" || firstName != "" || phone != "" || id != "" || password != "")
            {


                bool ok = false;
                Personne personne = new Personne(lastName, firstName, phone, id, password);
                PersonneDAO personneDAO = new PersonneDAO();
                ok = personneDAO.Create(personne);


                if (ok == true)
                {

                    MessageBox.Show("Vous êtes enregistré!", "Bienvenue", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Hide();
                    LogIn login = new LogIn();
                    login.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Une erreur est survenue!", "Erreur", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs!", "Erreur", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }
    }
}