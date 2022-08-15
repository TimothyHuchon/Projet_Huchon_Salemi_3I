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
    /// Logique d'interaction pour Velo.xaml
    /// </summary>
    public partial class VeloVIEW : Page
    {
        public Personne user = new Personne();
        public VeloVIEW(Personne personne)
        {
            InitializeComponent();
            user = personne;
        }

        private void Button_save_Click(object sender, RoutedEventArgs e)
        {
            Decimal poid = 0;
            Decimal Long = 0;
            if(string.IsNullOrWhiteSpace(textPoid.Text) || string.IsNullOrWhiteSpace(textType.Text) || string.IsNullOrWhiteSpace(textLong.Text))
            {
                MessageBox.Show("Veuillez compléter tous les champs", "Erreur", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                if(Decimal.TryParse(textPoid.Text, out poid).Equals(null) && Decimal.TryParse(textLong.Text, out Long).Equals(null))
                {
                    System.Diagnostics.Debug.WriteLine("pas bon format");
                }
                else
                {
                    Decimal.TryParse(textPoid.Text, out poid);
                    Decimal.TryParse(textLong.Text, out Long);
                    if(poid != 0 && Long != 0)
                    {
                        Velo v = new Velo(poid, textType.Text, Long);
                        v.Proprietaire = user.ID_personne;
                        VeloDAO dao = new VeloDAO();
                        dao.Create(v);

                        textType.Clear();
                        textPoid.Clear();
                        textLong.Clear();
                        MessageBox.Show("Vélo ajouté avec succés !", "Erreur", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Veuillez entrez des valeurs correctes", "Erreur", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
            }
        }
        private void Button_clear_Click(object sender, RoutedEventArgs e)
        {
            textType.Clear();
            textPoid.Clear();
            textLong.Clear();
        }
    }
}
