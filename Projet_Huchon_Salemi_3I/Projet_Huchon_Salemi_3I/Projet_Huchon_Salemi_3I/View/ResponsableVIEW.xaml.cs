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
    /// Logique d'interaction pour Responsable.xaml
    /// </summary>
    public partial class ResponsableVIEW : Page
    {
        public Personne user = new Personne();
        public ResponsableVIEW(Personne personne)
        {
            InitializeComponent();
            user = personne;
        }

        private void Button_save_Click(object sender, RoutedEventArgs e)
        {
            if(date.SelectedDate == null || heure.SelectedTime == null || txtlieu.Text == null || txtForfait.Text == null)
            {
                MessageBox.Show("Veuillez completer tous les champs", "Erreur", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                int y = date.SelectedDate.Value.Year;
                int m = date.SelectedDate.Value.Month;
                int d = date.SelectedDate.Value.Day;
                int h = heure.SelectedTime.Value.Hour;
                int min = heure.SelectedTime.Value.Minute;
                DateTime dateOk = new DateTime(y, m, d, h , min, 0);
                Decimal forfait = 0;
                Decimal.TryParse(txtForfait.Text, out forfait);
  

               
                if(forfait != 0)
                {

                    BaladeDAO baladedao = new BaladeDAO();
                    Balade balade = new Balade(txtlieu.Text, dateOk, forfait);
                    baladedao.Create(balade);

                    decimal lastAjoutBalade = baladedao.lastBaladeSave();

                    CalendrierDAO calendrierDAO = new CalendrierDAO();
                    Calendrier calendrier = new Calendrier();
                    ResponsableDAO responsableDAO = new ResponsableDAO();
                    Responsable responsable = responsableDAO.Find(user.ID_personne);
                    List<decimal> ListId_calendrier = calendrierDAO.idByCategorie(responsable.Num_categorie);
                    calendrier = calendrierDAO.Find(ListId_calendrier[0]);
                    calendrier.ajouterBalade(lastAjoutBalade);

                    txtForfait.Clear();
                    txtlieu.Clear();
                    MessageBox.Show("Balade ajouté avec succés !", "Félicitations", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Erreur Ajout Balade", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }

        private void Button_clear_Click(object sender, RoutedEventArgs e)
        {
            txtForfait.Clear();
            txtlieu.Clear();
        }
    }
}
