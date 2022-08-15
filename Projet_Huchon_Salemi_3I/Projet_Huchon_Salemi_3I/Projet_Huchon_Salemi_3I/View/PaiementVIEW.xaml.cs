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
    /// Logique d'interaction pour Paiement.xaml
    /// </summary>
    public partial class PaiementVIEW : Page
    {
        public Personne user = new Personne();
        public PaiementVIEW(Personne personne)
        {
            InitializeComponent();
            user = personne;
            initialPaiement();
        }

        public void initialPaiement()
        {
            Membre membre = new Membre();
            MembreDAO dao = new MembreDAO();

            membre = dao.Find(user.ID_personne);
            decimal soldeByDB = membre.verifierSolde();
            decimal compte = dao.RecupCptBancaire(user.ID_personne);

            solde.Text = soldeByDB + "€";
            cpt.Text = compte + "€";
        }

        private void Button_payer_Click(object sender, RoutedEventArgs e)
        {
            Membre membre = new Membre();
            MembreDAO dao = new MembreDAO();
            membre = dao.Find(user.ID_personne);

            char c ;
            string soldeOk = null;
            for (int i = 0; i < solde.Text.Length; i++)
            {
                c = solde.Text[i];
                if(c != '€')
                {
                    soldeOk = soldeOk + c;
                }
            }
            string cptOk = null;
            for (int i = 0; i < cpt.Text.Length; i++)
            {
                c = cpt.Text[i];
                if (c != '€')
                {
                    cptOk = cptOk + c;
                }
            }

            decimal soldeOkDecimal = Decimal.Parse(soldeOk);
            decimal cptOkDecimal = Decimal.Parse(cptOk);

            if (cptOkDecimal < soldeOkDecimal)
            {
                MessageBox.Show("Vous n'avez pas assez de fonds !", "Erreur", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                cptOkDecimal = cptOkDecimal - soldeOkDecimal;
                membre.paiementUpdate(cptOkDecimal);
                membre.Message = false;
                dao.UpdateMessage(membre);


                solde.Text = 0 + "€";
                cpt.Text = cptOkDecimal + "€";
            }

            
        }

        private void Button_Ajouter_Click(object sender, RoutedEventArgs e)
        {
            Membre membre = new Membre();
            MembreDAO dao = new MembreDAO();
            decimal Newcpt = Decimal.Parse(textajouter.Text);
            membre = dao.Find(user.ID_personne);
            membre.CptBanquaire = membre.CptBanquaire + Newcpt;
            dao.Update(membre);

            char c;
            string cptOk = null;
            for (int i = 0; i < cpt.Text.Length; i++)
            {
                c = cpt.Text[i];
                if (c != '€')
                {
                    cptOk = cptOk + c;
                }
            }
            decimal cptOkDecimal = Decimal.Parse(cptOk);
            decimal total = cptOkDecimal + Newcpt;
            cpt.Text = total + "€";
            textajouter.Clear();
        }
    }
}
