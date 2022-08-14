using Projet_Huchon_Salemi_3I.metier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Projet_Huchon_Salemi_3I.DAO
{
    class InscriptionDAO : DAO<Inscription>
    {
        public override bool Create(Inscription obj)
        {
            bool value = false;
            try
            {
                using(SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Inscription([id_personne],[num_balade],[id_velo],[passager],[velo]) VALUES (@idP, @num, @idV, @passager,@velo)",connection);
                    cmd.Parameters.AddWithValue("idP", obj.Id_personne);
                    cmd.Parameters.AddWithValue("num", obj.Num_balade);
                    cmd.Parameters.AddWithValue("idV", obj.Id_velo);
                    cmd.Parameters.AddWithValue("passager", obj.Passager);
                    cmd.Parameters.AddWithValue("velo", obj.Velo);
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

        public override bool Update(Inscription obj)
        {
            bool value = false;
            try
            {
                using(SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Inscription SET [passager]=@passager, [velo]=@velo WHERE id_inscription=@id", connection);
                    cmd.Parameters.AddWithValue("passager", obj.Passager);
                    cmd.Parameters.AddWithValue("velo", obj.Velo);
                    cmd.Parameters.AddWithValue("id", obj.Id_inscription);
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

        public override bool Delete(Inscription obj)
        {
            bool value = false;
            try
            {
                using(SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Inscription WHERE id_inscription = @id", connection);
                    cmd.Parameters.AddWithValue("id", obj.Id_inscription);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {

                throw new Exception("Une erreur sql s'est produite!");
            }
            return value;
        }

        public override Inscription Find(decimal id)
        {
            Inscription inscription = null;
            try
            {
                using(SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Inscription WHERE id_inscription = @id", connection);
                    connection.Open();

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            inscription = new Inscription
                            {
                                Passager = reader.GetBoolean("passager"),
                                Velo = reader.GetBoolean("velo")
                            };
                        }
                    }
                }
                if(inscription != null)
                {
                    /* **************************************************************************
                     * **************************************************************************
                     * **************************A completer*************************************
                     * **************************************************************************
                     * **************************************************************************
                     */
                }
            }
            catch (SqlException)
            {

                throw new Exception("Une erreur sql s'est produite!");
            }
            return inscription;
        }


        public List<Inscription> FindAllByBalade(Balade balade)
        {
            List<Inscription> inscriptions = new List<Inscription>();
            try
            {
                using(SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Inscription WHERE num_balade = @num", connection);
                    cmd.Parameters.AddWithValue("num", balade.Num);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Inscription inscr = new Inscription
                            {
                                Passager = reader.GetBoolean("passager"),
                                Velo = reader.GetBoolean("velo")
                            };
                            inscriptions.Add(inscr);
                        }
                    }
                }
            }
            catch (SqlException)
            {

                throw new Exception("Une erreur sql s'est produite");
            }
            return inscriptions;
        }

        public List<decimal> FindPersonneInscrit(decimal num)
        {
            List<decimal> personne = new List<decimal>();
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT id_personne FROM Inscription WHERE num_balade = @num", connection);
                    cmd.Parameters.AddWithValue("num", num);
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal pers = reader.GetDecimal("id_personne");
                            personne.Add(pers);
                        }
                    }
                }
            }
            catch (SqlException)
            {

                throw new Exception("Une erreur sql s'est produite");
            }
            return personne;
        }

    }
}
