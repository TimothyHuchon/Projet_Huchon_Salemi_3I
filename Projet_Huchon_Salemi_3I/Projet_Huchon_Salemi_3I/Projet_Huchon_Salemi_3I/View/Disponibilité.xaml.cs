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
    /// Logique d'interaction pour Disponibilité.xaml
    /// </summary>
    public partial class Disponibilité : Page
    {
        public Disponibilité()
        {
            InitializeComponent();
        }

        private void Button_save_Click(object sender, RoutedEventArgs e)
        {
            //TO DO
        }

        private void Button_clear_Click(object sender, RoutedEventArgs e)
        {
            textVelo.Clear();
            textVoiture.Clear();
        }
    }
}
