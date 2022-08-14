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
    /// Logique d'interaction pour Disponibilité.xaml
    /// </summary>
    public partial class DisponibilitéVIEW : Page
    {
        public Personne user = new Personne();
        public DisponibilitéVIEW(Personne personne)
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

        private void Button_save_Click(object sender, RoutedEventArgs e)
        {
            Balade balade = new Balade();
            BaladeDAO daoBalade = new BaladeDAO();
            Decimal nbrVoiture = 0;
            Decimal nbrVelo = 0;
            if (string.IsNullOrWhiteSpace(txtBalade.Text) || string.IsNullOrWhiteSpace(textVoiture.Text) || string.IsNullOrWhiteSpace(textVelo.Text))
            {
                MessageBox.Show("Veuillez compléter tous les champs");
            }
            else
            {
                Decimal numBalade = 0; 
                Decimal.TryParse((txtBalade.SelectedItem as ComboboxItem).Value.ToString(), out numBalade);

                Decimal.TryParse(textVoiture.Text, out nbrVoiture);
                Decimal.TryParse(textVelo.Text, out nbrVelo);
                if (nbrVoiture != 0 && nbrVelo != 0)
                {
                    Vehicule v = new Vehicule(user.ID_personne, nbrVoiture, nbrVelo);
                    VehiculeDAO dao = new VehiculeDAO();
                    dao.Create(v);
                    decimal idVehicule = dao.lastVehiculeSave();

                    daoBalade.CreateTransport(idVehicule, numBalade);

                    txtBalade.Items.Clear();
                    textVoiture.Clear();
                    textVelo.Clear();
                    MessageBox.Show("Véhicule ajouté avec succés !");
                }
                else
                {
                    MessageBox.Show("Veuillez entrez des valeurs correctes");
                }
            }

        }

        private void Button_clear_Click(object sender, RoutedEventArgs e)
        {
            textVelo.Clear();
            textVoiture.Clear();
        }

        private List<Balade> baladeByCat()
        {
            MembreDAO daoMembre = new MembreDAO();
            CalendrierDAO daoCalendrier = new CalendrierDAO();
            BaladeDAO daoBalade = new BaladeDAO();
            Balade balade = new Balade();
            List<Balade> listBalade = new List<Balade>();
            List<decimal> listNumCat = daoMembre.catByMembre(user.ID_personne);

            foreach (decimal i in listNumCat)
            {
                List<decimal> listIdCalendrier = daoCalendrier.idByCategorie(i);
                foreach (decimal j in listIdCalendrier)
                {
                    balade = daoBalade.FindBaladeByCalendrier(j);
                    if (balade != null)
                    {
                        listBalade.Add(balade);
                    }
                }
            }
            return listBalade;
        }

        private void listeOfItem()
        {
            MembreDAO daoMembre = new MembreDAO();
            List<string> listCat = new List<string> { "Trialiste", "Descente", "Randonneur", "Cyclo" };
            List<Balade> nameBalade = baladeByCat();
            List<string> listRecupString = new List<string>();
            List<decimal> listNum = new List<decimal>();

            for (int i = 0; i < nameBalade.Count; i++)
            {
                String recupString = listCat[i] + " A "+ nameBalade[i].LieuDepart + " => " + nameBalade[i].DateDepart;
                listRecupString.Add(recupString);
                listNum.Add(nameBalade[i].Num);
            }
            ComboboxItem item = null;
            List<ComboboxItem> listItem = new List<ComboboxItem>();

            for(int i = 0; i < listRecupString.Count; i++)
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
    }
}
