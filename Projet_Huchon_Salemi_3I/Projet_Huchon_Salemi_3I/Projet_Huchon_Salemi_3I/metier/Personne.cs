using Projet_Huchon_Salemi_3I.DAO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Huchon_Salemi_3I.metier
{
    public class Personne
    {
        private int id_personne;
        private string nom;
        private string prenom;
        private string tel;
        private string id;
        private string motDePasse;

        public Personne(){}

        public Personne(int id_personne) {
            this.id_personne = id_personne;
        }

        protected Personne(string nom, string prenom, string tel, string id, string motDePasse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.id = id;
            this.motDePasse = motDePasse;
        }

        public int ID_personne { get => id_personne; set => id_personne = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Id { get => id; set => id = value; }
        public string MotDePasse { get => motDePasse; set => motDePasse = value; }

        public override bool Equals(object obj)
        {
            return obj is Personne personne &&
                   Id == personne.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public int CheckidUser(String nom, String Prenom)
        {
            PersonneDAO personneDAO = new PersonneDAO();
            Personne user = new Personne();

            user = personneDAO.FindId(nom, prenom);
            return user.ID_personne;
        }

    }

}