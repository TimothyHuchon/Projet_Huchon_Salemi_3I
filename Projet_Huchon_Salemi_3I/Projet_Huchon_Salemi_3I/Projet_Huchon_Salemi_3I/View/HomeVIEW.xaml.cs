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
using Projet_Huchon_Salemi_3I.metier;
using Projet_Huchon_Salemi_3I.DAO;

namespace Projet_Huchon_Salemi_3I.View
{
    /// <summary>
    /// Logique d'interaction pour Home.xaml
    /// </summary>
    public partial class HomeVIEW : Page
    {
        Personne user = new Personne();
        Decimal num_velo = 0;
        public HomeVIEW(Personne personne)
        {
            InitializeComponent();
            profilNom.Text = personne.Nom;
            profilPrenom.Text = personne.Prenom;
            profilTel.Text = personne.Tel;
            identifiantID.Text = personne.Id;
            identifiantPassword.Text = personne.MotDePasse;
            user = personne;

            Vehicule vehicule = new Vehicule();
            VehiculeDAO vehiculeDAO = new VehiculeDAO();
            vehicule = vehiculeDAO.VehiculeByMembre(personne.ID_personne);
            if (vehicule != null)
            {
                cardVehi.Visibility = Visibility.Visible;
                vehiculeNbrePassagers.Text = "" + vehicule.NbrePlacesMembre;
                vehiculeNbreVelos.Text = "" + vehicule.NbrePlacesVelo;
            }
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

        private void listeOfVelo()
        {
            VeloDAO daoVelo = new VeloDAO();

            List<Velo> listVelo = daoVelo.FindVeloByMembre(user.ID_personne);

            List<string> listRecupString = new List<string>();
            List<decimal> listNum = new List<decimal>();

            for (int i = 0; i < listVelo.Count; i++)
            {
                String recupString = ""+listVelo[i].Type;
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

        private void txtvelo_DropDownOpened(object sender, EventArgs e)
        {
            txtvelo.Items.Clear();
            listeOfVelo();
        }


        private void txtvelo_DropDownClosed(object sender, EventArgs e)
        {
            if (txtvelo.Text != "")
            {
                Decimal.TryParse((txtvelo.SelectedItem as ComboboxItem).Value.ToString(), out num_velo);
                Velo velo = new Velo();
                VeloDAO veloDAO = new VeloDAO();
                velo = veloDAO.Find(num_velo);
                veloPoid.Text = "" + velo.Poids;
                veloType.Text = velo.Type;
                veloLongueur.Text = "" + velo.Longueur;
            }
        }
    }
}
