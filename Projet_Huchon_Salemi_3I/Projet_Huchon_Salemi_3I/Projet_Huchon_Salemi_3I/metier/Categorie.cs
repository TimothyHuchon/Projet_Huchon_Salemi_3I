using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Huchon_Salemi_3I.metier
{
    abstract class Categorie
    {
        private int num;
        private Responsable responsable;
        private List<Membre> listeMembre = new List<Membre>();
        private Calendrier calendrier;

        protected Categorie(int num)
        {
            this.num = num;
        }

        public int Num { get => num; set => num = value; }
        internal Responsable Responsable { get => Responsable1; set => Responsable1 = value; }
        internal Responsable Responsable1 { get => responsable; set => responsable = value; }
        internal List<Membre> ListeMembre { get => listeMembre; set => listeMembre = value; }
        internal Calendrier Calendrier { get => calendrier; set => calendrier = value; }

        public override bool Equals(object obj)
        {
            return obj is Categorie categorie &&
                   Num == categorie.Num;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Num);
        }
    }

}
