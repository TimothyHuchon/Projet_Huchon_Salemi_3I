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
    /// Logique d'interaction pour RecapBalade.xaml
    /// </summary>
    public partial class RecapBaladeVIEW : Page
    {
        public RecapBaladeVIEW()
        {
            InitializeComponent();
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
                String recupString = listCat[i] + " A " + listBalade[i].LieuDepart + " => " + listBalade[i].DateDepart;
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

        private void txtBalade_DropDownClosed(object sender, EventArgs e)
        {
            Decimal numBalade = 0;
            Decimal.TryParse((txtBalade.SelectedItem as ComboboxItem).Value.ToString(), out numBalade);
            BaladeDAO daoBalade = new BaladeDAO();
            Balade Balade = new Balade();
            Balade = daoBalade.Find(numBalade);
            int MembreTotal = Balade.obtenirPlacesMembreTotal((int)numBalade);
            int MembreRest = Balade.obtenirPlacesMembreRestantes((int)numBalade);
            int VeloTotal = Balade.obtenirPlacesVeloTotal((int)numBalade);
            int VeloRest = Balade.obtenirPlacesVeloRestantes((int)numBalade);
            int MembreBesoin = Balade.obtenirPlacesMembreBesoin((int)numBalade);
            int VeloBesoin = Balade.obtenirPlaceVeloBesoin((int)numBalade);

            membreTotal.Text = "Total des places = " + MembreTotal;
            membreRest.Text = "Places restantes = " + MembreRest;
            veloTotal.Text = "Total des vélo = " + VeloTotal;
            veloRest.Text = "Velo restantes = " + MembreRest;
            membreBesoin.Text = "Besoin Membre = " + MembreBesoin;
            veloBesoin.Text = "Besoin Velo = " + VeloBesoin;
        }
    }
}
