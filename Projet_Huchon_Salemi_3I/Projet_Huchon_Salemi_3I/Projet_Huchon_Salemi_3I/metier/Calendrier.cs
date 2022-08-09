using Projet_Huchon_Salemi_3I.DAO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Huchon_Salemi_3I.metier
{
    public class Calendrier
    {
        private decimal id_calendrier;
        private List<Balade> listeBalade = new List<Balade>();
        private decimal num_categorie;

        public Calendrier() { }

        public Calendrier(decimal num_categorie)
        {
            this.num_categorie = num_categorie;
        }

        public Calendrier(decimal id_calendrier, decimal num_categorie) 
        {
            this.ID_calendrier = id_calendrier;
            this.NUM_categorie = num_categorie;
        }



        public decimal ID_calendrier { get => id_calendrier; set => id_calendrier = value; }
        internal List<Balade> ListeBalade { get => listeBalade; set => listeBalade = value; }
        internal decimal NUM_categorie { get => num_categorie; set => num_categorie = value; }

        public void ajouterBalade(decimal num)
        {
            BaladeDAO dao = new BaladeDAO();
            Balade balade = new Balade();
            balade = dao.Find(num);
            balade.id_calendrier = this.ID_calendrier;
            dao.Update(balade);
        }
    }
}