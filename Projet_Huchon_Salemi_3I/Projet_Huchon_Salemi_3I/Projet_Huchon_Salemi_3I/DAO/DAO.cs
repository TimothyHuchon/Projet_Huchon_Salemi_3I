using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;


namespace Projet_Huchon_Salemi_3I.DAO
{
    public abstract class DAO<T>
    {

        protected string connectionString = null;
        public DAO()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["LOCALDB"].ConnectionString;
        }

        public abstract bool Create(T obj);
        public abstract bool Delete(T obj);
        public abstract bool Update(T obj);
        public abstract T Find(decimal id);

    }
}
