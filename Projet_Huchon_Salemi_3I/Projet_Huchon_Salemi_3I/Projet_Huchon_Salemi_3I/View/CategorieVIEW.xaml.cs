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
    public partial class CategorieVIEW : Page
    {
        public Personne user = new Personne();
        public CategorieVIEW(Personne personne)
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
            List<string> nameCat = new List<string>{"Trialiste", "Descente", "Randonneur", "Cyclo" };
            ComboboxItem item = null;
            List<ComboboxItem> listItem = new List<ComboboxItem>();

            for (int i = 0; i < 4; i++)
            {
                item = new ComboboxItem();
                item.Text = nameCat[i];
                item.Value = i + 1;
                listItem.Add(item); 
            }

            for (int i = 0; i < 4; i++)
            {
                txtCat.Items.Add(listItem[i]);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            decimal num = 0;
            MembreDAO dao = new MembreDAO();

            Decimal.TryParse((txtCat.SelectedItem as ComboboxItem).Value.ToString(), out num);
            if(dao.VerifierCatPresent(user.ID_personne, num))
            {
                MessageBox.Show("Vous etes déjà inscrit à cette catégorie !","Erreur", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                dao.membreInCat(user.ID_personne, num);
                Membre membre = dao.Find(user.ID_personne);
                membre.calculSolde(user.Nom, user.Prenom);
                txtCat.Items.Clear();
                MessageBox.Show("Catégorie ajouté avec succés !", "Félicitation", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            
        }
    }
}
