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
    /// Interaction logic for UpdateMembreView.xaml
    /// </summary>
    public partial class UpdateMembreView : Page
    {
        Decimal num_velo = 0;
        private string nomModifRO = "";
        private string prenomModifRO = "";
        private string telModif = "";
        private string idModif = "";
        private string passwordModif = "";
        Personne user = new Personne();
        

        public UpdateMembreView(Personne personne)
        {
            InitializeComponent();
            txtNomModif.Text = personne.Nom;
            txtPrenomModif.Text = personne.Prenom;
            txtTelModif.Text = personne.Tel;
            txtIdModif.Text = personne.Id;
            txtPassWordModif.Password = personne.MotDePasse;
            user = personne;
 
        }

        private void InfoModifBtn_Click(object sender, RoutedEventArgs e)
        {
            nomModifRO = txtNomModif.Text;
            prenomModifRO = txtPrenomModif.Text;
            telModif = txtTelModif.Text;
            idModif = txtIdModif.Text;
            passwordModif = txtPassWordModif.Password;
            bool good = false;

            Personne user = new Personne();
            Personne personne = new Personne(nomModifRO,prenomModifRO,telModif,idModif,passwordModif);
            PersonneDAO personneDAO = new PersonneDAO();
            good = personneDAO.Update(personne);
            if (good == true) MessageBox.Show("Modification enregistrée!", "Bravo", MessageBoxButton.OK, MessageBoxImage.Information);
            else MessageBox.Show("Erreur!", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);

            /* TEST */

            /* MembreVIEW membre = new MembreVIEW(personne);
             membre.ShowDialog();*/

            /* TEST */
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

            List<Velo> listVelo = daoVelo.FindVeloByMembre2(user.ID_personne);

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
                txtveloModif.Items.Add(i);
            }
        }
        private void txtveloModif_DropDownOpened(object sender, EventArgs e)
        {
            txtveloModif.Items.Clear();
            listeOfVelo();
        }

        private void txtveloModif_DropDownClosed(object sender, EventArgs e)
        {
            bool good = false;
            if (txtveloModif.Text != "")
            {
                Decimal.TryParse((txtveloModif.SelectedItem as ComboboxItem).Value.ToString(), out num_velo);
                Velo velo = new Velo(num_velo);
                VeloDAO veloDAO = new VeloDAO();
                good = veloDAO.Delete(velo);
                if(good == true) MessageBox.Show("Vélo supprimé!", "Bravo", MessageBoxButton.OK, MessageBoxImage.Information);
                else MessageBox.Show("Erreur lors de la suppression du vélo!", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else MessageBox.Show("Erreur! Séléctionner un vélo", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
