using Projet_Huchon_Salemi_3I.metier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Projet_Huchon_Salemi_3I.DAO
{
    public class VeloDAO : DAO<Velo>
    {
        public VeloDAO() { }
        public override bool Create(Velo obj)
        {
            bool value = false;
            try
            {
                    using (SqlConnection connection = new SqlConnection(this.connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Velo([id_personne],[poids],[type],[longueur]) VALUES(@idP, @poids, @type, @long)", connection);
                        cmd.Parameters.AddWithValue("idP", obj.Proprietaire);
                        cmd.Parameters.AddWithValue("poids", obj.Poids);
                        cmd.Parameters.AddWithValue("type", obj.Type);
                        cmd.Parameters.AddWithValue("long", obj.Longueur);
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

        public override bool Delete(Velo obj)
        {
            bool value = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Velo WHERE id_velo = @id", connection);
                    cmd.Parameters.AddWithValue("id", obj.ID);
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

        public override Velo Find(decimal id)
        {
            Velo velo = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Velo where id_velo = @id", connection);
                    cmd.Parameters.AddWithValue("id", id);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            velo = new Velo
                            {
                                Proprietaire = reader.GetDecimal("id_personne"),
                                Vehicule = reader.GetDecimal("id_vehicule"),
                                Poids = reader.GetDecimal("poids"),
                                Type = reader.GetString("type"),
                                Longueur = reader.GetDecimal("longueur"),
                            };
                        }

                    }
                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }

            return velo;
        }

        public override bool Update(Velo obj)
        {
            bool value = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Velo SET [id_personne] = @idPers ,[id_vehicule] = @idV,[poids] = @poid,[type] = @type,[longueur] = @longeur WHERE id_velo = @idVelo", connection);
                    cmd.Parameters.AddWithValue("idPers", obj.Proprietaire);
                    cmd.Parameters.AddWithValue("idV", obj.Vehicule);
                    cmd.Parameters.AddWithValue("poid", obj.Poids);
                    cmd.Parameters.AddWithValue("type", obj.Type);
                    cmd.Parameters.AddWithValue("longeur", obj.Longueur);
                    cmd.Parameters.AddWithValue("idVelo", obj.ID);
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

        public List<Velo> FindVeloByMemebre(decimal id)
        {
           List<Velo> listvelo = new List<Velo>();
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Velo where id_personne = @id", connection);
                    cmd.Parameters.AddWithValue("id", id);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Velo velo = new Velo
                            {
                                ID = reader.GetDecimal("id_velo"),
                                Proprietaire = reader.GetDecimal("id_personne"),
                                Poids = reader.GetDecimal("poids"),
                                Type = reader.GetString("type"),
                                Longueur = reader.GetDecimal("longueur"),
                            };
                            listvelo.Add(velo);
                        }

                    }
                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }

            return listvelo;
        }
    }
}
