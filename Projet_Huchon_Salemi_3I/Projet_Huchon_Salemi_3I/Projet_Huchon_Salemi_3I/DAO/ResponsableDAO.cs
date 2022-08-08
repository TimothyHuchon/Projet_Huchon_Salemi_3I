using Projet_Huchon_Salemi_3I.metier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Projet_Huchon_Salemi_3I.DAO
{
    public class ResponsableDAO : DAO<Responsable>
    {
        public ResponsableDAO() { }

        public override bool Create(Responsable obj)
        {
            bool value = false;
            try
            {
                if (VerifierIdPresent(obj.ID_personne) == false)
                {
                    using (SqlConnection connection = new SqlConnection(this.connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Responsable([id_personne],[num_categorie]) VALUES(@id,@num); ", connection);
                        cmd.Parameters.AddWithValue("id", obj.ID_personne);
                        cmd.Parameters.AddWithValue("num", obj.Num_categorie);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                    value = true;
                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }
            return value;
        }

        public override bool Delete(Responsable obj)
        {
            bool value = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Responsable WHERE id_personne = @id", connection);
                    cmd.Parameters.AddWithValue("id", obj.ID_personne);
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

        public override Responsable Find(decimal id)
        {
            Responsable responsable = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Responsable where id_personne = @id", connection);
                    cmd.Parameters.AddWithValue("id", id);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            responsable = new Responsable
                            {
                                ID_personne = reader.GetDecimal("id_personne"),
                                Num_categorie = reader.GetDecimal("num_categorie")
                            };
                        }

                    }
                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }

            return responsable;
        }

        public override bool Update(Responsable obj)
        {
            bool value = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Responsable SET [id_personne] = @id,[num_categorie] = @num WHERE id_personne = @id", connection);
                    cmd.Parameters.AddWithValue("id", obj.ID_personne);
                    cmd.Parameters.AddWithValue("num", obj.Num_categorie);
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

        public bool VerifierIdPresent(decimal id)
        {
            bool value = false;
            int personne = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Tresorier where id_personne = @id", connection);
                    cmd.Parameters.AddWithValue("id", id);
                    connection.Open();
                    personne = (int)cmd.ExecuteScalar();

                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }

            if (personne >= 1)
            {
                value = true;
            }
            return value;
        }
    }
}
