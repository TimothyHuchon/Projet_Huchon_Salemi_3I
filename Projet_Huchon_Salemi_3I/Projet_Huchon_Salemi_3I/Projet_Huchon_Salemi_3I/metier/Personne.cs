using Projet_Huchon_Salemi_3I.DAO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Huchon_Salemi_3I.metier
{
    public class Personne
    {
        protected Decimal id_personne;
        protected string nom;
        protected string prenom;
        protected string tel;
        protected string id;
        protected string motDePasse;

        public Personne(){}

        public Personne(string nom, string prenom, string tel, string id, string motDePasse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.id = id;
            this.motDePasse = motDePasse;
        }

        public Decimal ID_personne { get => id_personne; set => id_personne = value; }
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

        public decimal GetidUser(string nom, string prenom)
        {
            PersonneDAO dao = new PersonneDAO();
            decimal id = 0;

            id = dao.FindId(nom, prenom);

            return id;
        }

        public bool SignIn(string id, string motDePasse)
        {
            bool isMembre = false;
            int countPersonne = 0;
            PersonneDAO personneDAO = new PersonneDAO();
            countPersonne = personneDAO.IsInscrit(id, motDePasse);
            if (countPersonne == 1) isMembre = true;
            return isMembre;
        }

        public string checkProfile(decimal id)
        {
            string value = null;

            ResponsableDAO Rdao = new ResponsableDAO();
            Responsable responsable = Rdao.Find(id);
            if (responsable == null)
            {
                TresorierDAO Tdao = new TresorierDAO();
                Tresorier tresorier = Tdao.Find(id);
                if (tresorier == null)
                {
                    value = "Membre";
                }
                else
                {
                    value = "Tresorier";
                }
            }
            else
            {
                value = "Responsable";
            }
            

            return value;
        }

    }

}