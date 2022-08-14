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
using Projet_Huchon_Salemi_3I.DAO;
using Projet_Huchon_Salemi_3I.metier;



namespace Projet_Huchon_Salemi_3I.View
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        private string userName="";
        private string motDePasse="";

        public LogIn()
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

        private void signupBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            userName = txtUsername.Text;
            motDePasse = txtPassWord.Password;
            bool verification = false;


            if (userName != "" || motDePasse != "")
            {
                Personne personne = new Personne();
                verification = personne.SignIn(userName, motDePasse);

                if (verification == true)
                {
                    PersonneDAO personneDAO = new PersonneDAO();
                    personne = personneDAO.whoIsInscrit(userName, motDePasse);
                    this.Hide();
                    MembreVIEW membre = new MembreVIEW(personne);
                    membre.ShowDialog();
                }
                else
                {
                    txtUsername.Clear();
                    txtPassWord.Clear();
                    MessageBox.Show("Vérifier vos identifiants ou créer un compte!", "Erreur", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                txtUsername.Clear();
                txtPassWord.Clear();
                MessageBox.Show("Veuillez remplir tous les champs!", "Erreur", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
