using Projet_Huchon_Salemi_3I.metier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Projet_Huchon_Salemi_3I.DAO
{
    public class TresorierDAO : DAO<Tresorier>
    {
        public TresorierDAO() { }

        public override bool Create(Tresorier obj)
        {
            bool value = false;
            try
            {
                if (VerifierIdPresent(obj.ID_personne) == false)
                {
                    using (SqlConnection connection = new SqlConnection(this.connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Tresorier([id_personne]) VALUES(@id); ", connection);
                        cmd.Parameters.AddWithValue("id", obj.ID_personne);
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

        public override bool Delete(Tresorier obj)
        {
            bool value = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Tresorier WHERE id_personne = @id", connection);
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

        public override Tresorier Find(decimal id)
        {
            Tresorier tresorier = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Tresorier where id_personne = @id", connection);
                    cmd.Parameters.AddWithValue("id", id);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tresorier = new Tresorier
                            {
                                ID_personne = reader.GetDecimal("id_personne")
                            };
                        }

                    }
                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }

            return tresorier;
        }

        public override bool Update(Tresorier obj)
        {
            return false;
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
