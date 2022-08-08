using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Projet_Huchon_Salemi_3I.metier;

namespace Projet_Huchon_Salemi_3I.DAO
{
    class VehiculeDAO : DAO<Vehicule>
    {
        public override bool Create(Vehicule obj)
        {
            return false;
        }

        public override bool Update(Vehicule obj)
        {
            return false;
        }

        public override bool Delete(Vehicule obj)
        {
            return false;
        }

        public override Vehicule Find(decimal id)
        {
            Vehicule vehicule = null;
            try
            {
                using(SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Vehicule WHERE id_vehicule = @id", connection);
                    cmd.Parameters.AddWithValue("id_vehicule", id);
                    connection.Open();

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            vehicule = new Vehicule
                            {
                                NbrePlacesMembre = reader.GetInt32("nbrePlacesMembre"),
                                NbrePlacesVelo = reader.GetInt32("nbrePlacesVelo"),
                                Conducteur = new Membre(),
                                Passagers = new List<Membre>(),
                                ListeVelo = new List<Velo>()  

                            };
                        }
                    }
                }
                if (vehicule != null)
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
            return vehicule;
        }

        public List<Vehicule> FindAllByBalade(Balade balade)
        {
            List<Vehicule> vehicules = new List<Vehicule>();
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Vehicule WHERE id_vehicule IN (SELECT id_vehicule FROM Transport WHERE num_balade = @num)", connection);
                    cmd.Parameters.AddWithValue("num", balade.Num);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Vehicule vehi = new Vehicule
                            {
                                NbrePlacesMembre = reader.GetInt32("nbrePlacesMembre"),
                                NbrePlacesVelo = reader.GetInt32("nbrePlacesVelo")

                            };
                            vehicules.Add(vehi);
                        }
                    }
                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }
            return vehicules;
        }


    }
}
