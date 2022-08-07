using Projet_Huchon_Salemi_3I.metier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;





namespace Projet_Huchon_Salemi_3I.DAO
{
    class BaladeDAO : DAO<Balade>
    {
        public override bool Create(Balade obj)
        {
            return false;
        }

        public override bool Update(Balade obj)
        {
            return false;
        }

        public override bool Delete(Balade obj)
        {
            return false;
        }

        public override Balade Find(decimal num)
        {
            Balade balade = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Balade WHERE num = @num", connection);
                    cmd.Parameters.AddWithValue("num", num);
                    connection.Open();

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            balade = new Balade
                            {
                                Num = reader.GetInt32("num"),
                                LieuDepart = reader.GetString("lieuDepart"),
                                DateDepart = reader.GetDateTime("dateDepart"),
                                Forfait = reader.GetDouble("forfait"),

                            };
                        }
                    }
                }
                if(balade != null)
                {
                    /*  *********************************************************  
                        *********************************************************  
                        ********************************************************* 
                            à compléter après la création basique des dao
                        ********************************************************* 
                        ********************************************************* 
                        ********************************************************* */
                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }
            return balade;
        }


        public List<Balade> FindPlacesMembreTotal(Vehicule vehicule)
        {

            List<Balade> listeBalades = new List<Balade>();
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("Select v.nbrePlacesMembre from dbo.Balade b JOIN Transport t ON b.num = t.num_baladeJOIN Vehicule v ON t.id_vehicule = v.id_vehiculeWHERE b.num = @num", connection);
                    cmd.Parameters.AddWithValue("num", vehicule.NbrePlacesMembre);
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Balade balade = new Balade
                            {
                               ListeVehicule = new List<Vehicule>(),
                            };
                            listeBalades.Add(balade);
                        }
                    }
                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }
            return listeBalades;
        }
    }
}
