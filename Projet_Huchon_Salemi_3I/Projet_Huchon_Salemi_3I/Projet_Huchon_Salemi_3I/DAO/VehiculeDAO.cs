﻿using System;
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
            bool value = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Vehicule([id_personne_conducteurs],[nbrePlacesMembre],[nbrePlacesVelo]) VALUES(@idPers,@place, @velo) ", connection);
                    cmd.Parameters.AddWithValue("idPers", obj.ID_personne_conducteur);
                    cmd.Parameters.AddWithValue("place", obj.NbrePlacesMembre);
                    cmd.Parameters.AddWithValue("velo", obj.NbrePlacesVelo);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                value = true;
  
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }
            return value;
        }

        public override bool Update(Vehicule obj)
        {
            bool value = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Vehicule SET [id_personne_conducteurs] = @idP,[nbrePlacesMembre] = @place,[nbrePlacesVelo] = @velo WHERE id_vehicule = @id", connection);
                    cmd.Parameters.AddWithValue("idP", obj.ID_personne_conducteur);
                    cmd.Parameters.AddWithValue("place", obj.NbrePlacesMembre);
                    cmd.Parameters.AddWithValue("velo", obj.NbrePlacesVelo);
                    cmd.Parameters.AddWithValue("id", obj.ID_vehicule);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                value = true;
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }
            return value;
        }

        public override bool Delete(Vehicule obj)
        {
            bool value = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Vehicule WHERE id_vehicule = @id", connection);
                    cmd.Parameters.AddWithValue("id", obj.ID_vehicule);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                value = true;
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }
            return value;
        }

        public override Vehicule Find(decimal id)
        {
            Vehicule vehicule = null;
            try
            {
                using(SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Vehicule WHERE id_vehicule = @id", connection);
                    cmd.Parameters.AddWithValue("id", id);
                    connection.Open();

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            vehicule = new Vehicule
                            {
                                ID_vehicule = reader.GetDecimal("id_vehicule"),
                                ID_personne_conducteur = reader.GetDecimal("id_personne_conducteurs"),
                                NbrePlacesMembre = reader.GetDecimal("nbrePlacesMembre"),
                                NbrePlacesVelo = reader.GetDecimal("nbrePlacesVelo"),
                               
                            };
                        }
                    }
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
                                NbrePlacesMembre = reader.GetDecimal("nbrePlacesMembre"),
                                NbrePlacesVelo = reader.GetDecimal("nbrePlacesVelo")

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

        public void AjoutPassager(decimal id, Vehicule vehicule)
        {
            int verif = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Passager where id_vehicule = @v and id_personne = @id", connection);
                    cmd.Parameters.AddWithValue("v", vehicule.ID_vehicule);
                    cmd.Parameters.AddWithValue("id", id);
                    connection.Open();
                    verif = (int)cmd.ExecuteScalar();

                }
                if (verif == 0)
                {
                    using (SqlConnection connection = new SqlConnection(this.connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Passager([id_vehicule],[id_personne]) VALUES(@idVehicule, @idPersonne); ", connection);
                        cmd.Parameters.AddWithValue("idVehicule", vehicule.ID_vehicule);
                        cmd.Parameters.AddWithValue("idPersonne", id);          
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }
        }

        public Vehicule VehiculeByMembre(decimal id)
        {
            Vehicule vehicule = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Vehicule where id_personne_conducteurs = @id", connection);
                    cmd.Parameters.AddWithValue("id", id);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            vehicule = new Vehicule
                            {
                                ID_vehicule = reader.GetDecimal("id_vehicule"),
                                ID_personne_conducteur = reader.GetDecimal("id_personne_conducteurs"),
                                NbrePlacesMembre = reader.GetDecimal("nbrePlacesMembre"),
                                NbrePlacesVelo = reader.GetDecimal("nbrePlacesVelo"),
                            };
                        }

                    }
                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }

            return vehicule;
        }

       

        public void AjoutVelo(decimal id_membre, decimal idvelo, Vehicule vehicule)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Velo SET [id_vehicule] = @idV WHERE id_velo = @idVelo", connection);
                  
                    cmd.Parameters.AddWithValue("idV", vehicule.ID_vehicule);
                    cmd.Parameters.AddWithValue("idVelo", idvelo);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
          

            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }
        }

        public decimal NbrMembreByVehicule (decimal id)
        {
            decimal totalMembre = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(id_personne) from passager where id_vehicule = @id", connection);
                    cmd.Parameters.AddWithValue("id", id);
                    connection.Open();
                    totalMembre = (int)cmd.ExecuteScalar();
                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }

            return totalMembre;
        }

        public decimal lastVehiculeSave()
        {
            decimal id = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT MAX(id_vehicule) from vehicule", connection);
                    connection.Open();
                    id = (decimal)cmd.ExecuteScalar();
                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }

            return id;
        }

        public List<decimal> vehiculeByNumBalade(decimal num)
        {
            List<decimal> listNum = new List<decimal>();
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT id_vehicule from transport where num_balade = @num", connection);
                    cmd.Parameters.AddWithValue("num", num);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal v = reader.GetDecimal("id_vehicule");
                            listNum.Add(v);
                        }
                    }
                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }

            return listNum;
        }

        public decimal countPassagerByVehicule(decimal idV)
        {
            decimal id = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) from passager where id_vehicule =@id", connection);
                    cmd.Parameters.AddWithValue("id", idV);
                    connection.Open();
                    id = (int)cmd.ExecuteScalar();
                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }

            return id;
        }

    }
}
