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
    /// Logique d'interaction pour Tresorie.xaml
    /// </summary>
    public partial class TresorieVIEW : Page
    {
        public Personne user = new Personne();
        public TresorieVIEW(Personne personne)
        {
            InitializeComponent();
            user = personne;
            listeOfItem();
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void listeOfItem()
        {
            MembreDAO daoMembre = new MembreDAO();
            BaladeDAO daoBalade = new BaladeDAO();
            List<string> listCat = new List<string> { "Trialiste", "Descente", "Randonneur", "Cyclo" };
            List<Balade> listBalade = daoBalade.allBalade();
            List<string> listRecupString = new List<string>();
            List<decimal> listNum = new List<decimal>();

            for (int i = 0; i < listBalade.Count; i++)
            {
                decimal numCat = ((listBalade[i].CalendrierBalade) - 2);
                String recupString = listCat[(int)numCat] + " A " + listBalade[i].LieuDepart + " => " + listBalade[i].DateDepart;
                listRecupString.Add(recupString);
                listNum.Add(listBalade[i].Num);
            }
            ComboboxItem item = null;
            List<ComboboxItem> listItem = new List<ComboboxItem>();

            for (int i = 0; i < listRecupString.Count; i++)
            {
                item = new ComboboxItem();
                item.Text = listRecupString[i];
                item.Value = listNum[i];
                listItem.Add(item);
            }

            foreach (ComboboxItem i in listItem)
            {
                txtBalade.Items.Add(i);
            }
        }

        private void Button_Payer_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBalade.Text))
            {
                 MessageBox.Show("Veuillez séléctionner une balade ", "Erreur", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else 
            {
                Decimal numBalade = 0;
                Decimal.TryParse((txtBalade.SelectedItem as ComboboxItem).Value.ToString(), out numBalade);
                TresorierDAO daoTresorier = new TresorierDAO();
                Tresorier tresorier = daoTresorier.Find(user.ID_personne);
                tresorier.payerConducteur(numBalade);

            }       
        }

        private void Button_reclam_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBalade.Text))
            {
                MessageBox.Show("Veuillez séléctionner une balade ", "Erreur", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                Decimal numBalade = 0;
                Decimal.TryParse((txtBalade.SelectedItem as ComboboxItem).Value.ToString(), out numBalade);
                TresorierDAO daoTresorier = new TresorierDAO();
                Tresorier tresorier = daoTresorier.Find(user.ID_personne);
                tresorier.ReclamerForfait(numBalade);
            }
        }

        private void Button_Envoyer_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBalade.Text))
            {
                MessageBox.Show("Veuillez séléctionner une balade ", "Erreur", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                Decimal numBalade = 0;
                Decimal.TryParse((txtBalade.SelectedItem as ComboboxItem).Value.ToString(), out numBalade);
                TresorierDAO daoTresorier = new TresorierDAO();
                Tresorier tresorier = daoTresorier.Find(user.ID_personne);
                tresorier.envoiLettreRappel(numBalade);
            }
        }
    }
}
