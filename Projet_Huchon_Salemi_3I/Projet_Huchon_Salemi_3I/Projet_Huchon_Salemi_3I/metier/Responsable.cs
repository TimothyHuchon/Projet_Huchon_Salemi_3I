using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Huchon_Salemi_3I.metier
{
    class Responsable : Personne
    {
        public Categorie categorie;
        public Responsable(string nom, string prenom, string tel, string id, string motDePasse, Categorie categorie)
            : base(nom, prenom, tel, id, motDePasse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.id = id;
            this.motDePasse = motDePasse;
            this.categorie = categorie;
        }

        public override string ToString()
        {
            return "Responsable { " +
                " nom: " + Nom +
                " prenom: " + Prenom +
                " tel: " + Tel +
                " id: " + Id +
                " motDePasse: " + MotDePasse +
                " categorie: " + categorie +
                " }";
        }
    }
}
