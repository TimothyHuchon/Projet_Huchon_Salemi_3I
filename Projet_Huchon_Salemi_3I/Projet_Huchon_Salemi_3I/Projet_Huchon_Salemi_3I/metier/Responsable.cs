using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Huchon_Salemi_3I.metier
{
    public class Responsable : Personne
    {
        public decimal id_personne;
        public decimal num_categorie;

        public Responsable() { }
        public Responsable(string nom, string prenom, string tel, string id, string motDePasse, decimal num_categorie)
            : base(nom, prenom, tel, id, motDePasse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.id = id;
            this.motDePasse = motDePasse;
            this.num_categorie = num_categorie;
        }

        public Responsable(decimal id_personne, decimal num_categorie) 
        {
            this.Id_personne = id_personne;
            this.Num_categorie = num_categorie;
        }
        
        public decimal Id_personne { get => id_personne; set => id_personne = value; }
        public decimal Num_categorie { get => num_categorie; set => num_categorie = value; }
       
        public override string ToString()
        {
            return "Responsable { " +
                " nom: " + Nom +
                " prenom: " + Prenom +
                " tel: " + Tel +
                " id: " + Id +
                " motDePasse: " + MotDePasse +
                " categorie: " + num_categorie +
                " }";
        }
    }
}
