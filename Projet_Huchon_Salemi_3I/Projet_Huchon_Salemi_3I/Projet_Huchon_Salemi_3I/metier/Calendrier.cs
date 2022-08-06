using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Huchon_Salemi_3I.metier
{
    class Calendrier
    {
        private List<Balade> listeBalade = new List<Balade>();
        private Categorie categorie; 



        internal List<Balade> ListeBalade { get => listeBalade; set => listeBalade = value; }
        internal Categorie Categorie { get => categorie; set => categorie = value; }

        public void ajouterBalade()
        {

        }
    }
}