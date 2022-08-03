using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Huchon_Salemi_3I.metier
{
    abstract class Categorie
    {
        private int num;
        private Responsable responsable;

        protected Categorie(int num)
        {
            this.Num = num;
        }

        public int Num { get => num; set => num = value; }
        internal Responsable Responsable { get => responsable; set => responsable = value; }

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
