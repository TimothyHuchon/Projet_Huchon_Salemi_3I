using Projet_Huchon_Salemi_3I.DAO;
using Projet_Huchon_Salemi_3I.metier;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Logique d'interaction pour Reservation.xaml
    /// </summary>
    public partial class ReservationVIEW : Page
    {
        public Personne user = new Personne();
        public ReservationVIEW(Personne personne)
        {
            InitializeComponent();
            user = personne;
            listeOfCat();
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
            if (string.IsNullOrEmpty(txtvelo.Text) || string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(txtCat.Text) || string.IsNullOrEmpty(txtBalade.Text))
            {
                MessageBox.Show("Veuillez selectionnez tous les champs !", "Erreur", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                VehiculeDAO vehiculeDAO = new VehiculeDAO();
                InscriptionDAO inscriptionDAO = new InscriptionDAO();
                BaladeDAO baladeDAO = new BaladeDAO();

                Decimal num_balade = 0;
                Decimal.TryParse((txtBalade.SelectedItem as ComboboxItem).Value.ToString(), out num_balade);
                System.Diagnostics.Debug.WriteLine(num_balade);
                Decimal num_velo = 0;
                Decimal.TryParse((txtvelo.SelectedItem as ComboboxItem).Value.ToString(), out num_velo);
                Balade balade = baladeDAO.Find(num_balade);

                if (txtPass.Text == "Passager")
                {
                    Inscription inscri = new Inscription(user.ID_personne, num_balade, true, num_velo, true);
                    inscriptionDAO.Create(inscri);
                    List<decimal> Listvehicule = vehiculeDAO.vehiculeByNumBalade(num_balade);
                   
                    if (!Listvehicule.Count.Equals(0))
                    {
                        decimal id_v_ok = 0;
                        foreach(decimal i in Listvehicule)
                        {
                            Vehicule vehicule = vehiculeDAO.Find(i);
                            decimal totalPassager = vehiculeDAO.countPassagerByVehicule(i);
                            if(totalPassager < vehicule.NbrePlacesMembre)
                            {
                                id_v_ok = i;
                            }
                        }
                        Vehicule vehicule_ok = vehiculeDAO.Find(id_v_ok);
                        vehicule_ok.AjouterPassager(user.Nom, user.Prenom);

                        MessageBox.Show("Réservation ajouté avec succés !", "Félicitations", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Pas assez de places pour cette balade", "Erreur", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }

                    txtBalade.Items.Clear();
                    txtCat.Items.Clear();
                    txtPass.Items.Clear();
                    txtvelo.Items.Clear();
                }
                else
                {
                    Inscription inscri = new Inscription(user.ID_personne, num_balade, false, num_velo, true);
                    inscriptionDAO.Create(inscri);

                    Vehicule vehicule_ok = vehiculeDAO.VehiculeByMembre(user.ID_personne);
                    vehicule_ok.ajouterVelo(num_velo, user.Nom, user.Prenom);

                    MessageBox.Show("Réservation ajouté avec succés !", "Félicitations", MessageBoxButton.OK, MessageBoxImage.Information);
                    txtBalade.Items.Clear();
                    txtCat.Items.Clear();
                    txtPass.Items.Clear();
                    txtvelo.Items.Clear();
                }
            }
        }

        private void Button_clear_Click(object sender, RoutedEventArgs e)
        {
            txtBalade.Items.Clear();
            txtCat.Items.Clear();
            txtPass.Items.Clear();
            txtvelo.Items.Clear();
            forfait.Text = null;

        }

        private void listeOfCat()
        {
            List<string> nameTotal = new List<string> { "Trialiste", "Descente", "Randonneur", "Cyclo" };
            BaladeDAO daoBalade = new BaladeDAO();
            List<decimal> listNum = daoBalade.idCatByPers(user.ID_personne);
            List<string> nameCatOk = new List<string>();

            foreach (decimal d in listNum)
            {
                nameCatOk.Add(nameTotal[(int)d -1]);
            }
            
            ComboboxItem item = null;
            List<ComboboxItem> listItem = new List<ComboboxItem>();

            for (int i = 0; i < nameCatOk.Count; i++)
            {
                item = new ComboboxItem();
                item.Text = nameCatOk[i];
                item.Value = i + 1;
                listItem.Add(item);
            }

            for (int i = 0; i < nameCatOk.Count; i++)
            {
                txtCat.Items.Add(listItem[i]);
            }
        }

        private List<Balade> baladeByCat(int numCat)
        {
            MembreDAO daoMembre = new MembreDAO();
            CalendrierDAO daoCalendrier = new CalendrierDAO();
            BaladeDAO daoBalade = new BaladeDAO();
            Balade balade = new Balade();
            List<Balade> listBalade = new List<Balade>();
            List<decimal> listNumCat = daoMembre.catByMembre(user.ID_personne);

            List<decimal> listIdCalendrier = daoCalendrier.idByCategorie(numCat);
            foreach (decimal j in listIdCalendrier)
            {
                List<Balade> listBaladeOk = daoBalade.FindBaladeByCalendrier(j);
                foreach (Balade b in listBaladeOk)
                {
                    if (b != null)
                    {
                        listBalade.Add(b);
                    }
                }
            }
          
            return listBalade;
        }

        private void listeOfBalade(int numCat)
        {
            MembreDAO daoMembre = new MembreDAO();
            List<string> listCat = new List<string> { "Trialiste", "Descente", "Randonneur", "Cyclo" };
            List<Balade> nameBalade = baladeByCat(numCat);
            List<string> listRecupString = new List<string>();
            List<decimal> listNum = new List<decimal>();

            for (int i = 0; i < nameBalade.Count; i++)
            {

                String recupString = listCat[numCat-1] + " A " + nameBalade[i].LieuDepart + " => " + nameBalade[i].DateDepart;
                listRecupString.Add(recupString);
                listNum.Add(nameBalade[i].Num);
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

        private void listeOfVelo()
        {
            VeloDAO daoVelo = new VeloDAO();

            List<Velo> listVelo = daoVelo.FindVeloByMembre(user.ID_personne);

            List<string> listRecupString = new List<string>();
            List<decimal> listNum = new List<decimal>();

            for (int i = 0; i < listVelo.Count; i++)
            {
                String recupString = listVelo[i].Type + " - " + listVelo[i].Longueur + " cm";
                listRecupString.Add(recupString);
                listNum.Add(listVelo[i].ID);
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
                txtvelo.Items.Add(i);
            }
        }

        private void txtBalade_DropDownOpened(object sender, EventArgs e)
        {
            txtBalade.Items.Clear();
            int num = 0;
            
            if (string.IsNullOrEmpty(txtCat.Text))
            {
                MessageBox.Show("Veuillez selectionnez une catégorie !", "Erreur", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                int.TryParse((txtCat.SelectedItem as ComboboxItem).Value.ToString(), out num);
                listeOfBalade(num);
            }
        }

        private void txtvelo_DropDownOpened(object sender, EventArgs e)
        {
            txtvelo.Items.Clear();
            listeOfVelo();

        }

        private void txtBalade_DropDownClosed(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtBalade.Text))
            {
                Decimal num_balade = 0;
                Decimal.TryParse((txtBalade.SelectedItem as ComboboxItem).Value.ToString(), out num_balade);

                BaladeDAO baladeDAO = new BaladeDAO();
                Balade balade = new Balade();
                balade = baladeDAO.Find(num_balade);
                

                forfait.Text = "Forfait = " + balade.Forfait + "€";
            }
            
        }

    }
}
