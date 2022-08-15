
using Projet_Huchon_Salemi_3I.metier;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Projet_Huchon_Salemi_3I.DAO
{
    public class PersonneDAO : DAO<Personne>
    {
        public PersonneDAO() {}

        public override bool Create(Personne obj)
        {
            bool value = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Personne([nom],[prenom],[tel],[id],[motDePasse]) VALUES(@nom, @prenom, @tel, @id, @mdp)", connection);
                    cmd.Parameters.AddWithValue("nom", obj.Nom);
                    cmd.Parameters.AddWithValue("prenom", obj.Prenom);
                    cmd.Parameters.AddWithValue("tel", obj.Tel);
                    cmd.Parameters.AddWithValue("id", obj.Id);
                    cmd.Parameters.AddWithValue("mdp", obj.MotDePasse);
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

        public override bool Delete(Personne obj)
        {
            bool value = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Personne WHERE id_personne = @id", connection);
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

        public override bool Update(Personne obj)
        {
            bool value = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Personne SET [tel] = @tel,[id] = @id,[motDePasse] = @mdp WHERE nom = @nom and prenom = @prenom", connection);
                    cmd.Parameters.AddWithValue("nom", obj.Nom);
                    cmd.Parameters.AddWithValue("prenom", obj.Prenom);
                    cmd.Parameters.AddWithValue("tel", obj.Tel);
                    cmd.Parameters.AddWithValue("id", obj.Id);
                    cmd.Parameters.AddWithValue("mdp", obj.MotDePasse);
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

        public override Personne Find(decimal id)
        {
            Personne personne = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Personne where id_personne = @id", connection);
                    cmd.Parameters.AddWithValue("id", id);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            personne = new Personne
                            {
                                ID_personne = reader.GetDecimal("id_personne"),
                                Nom = reader.GetString("nom"),
                                Prenom = reader.GetString("prenom"),
                                Tel = reader.GetString("tel"),
                                Id = reader.GetString("id"),
                                MotDePasse = reader.GetString("motDePasse"),
                            };
                        }

                    }
                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }

            return personne;
        }

        public decimal FindId(String nom, String prenom)
        {
           int personne = 0;
           try
           {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT id_personne FROM Personne where nom = @nom and prenom = @prenom", connection);
                    cmd.Parameters.AddWithValue("nom", nom);
                    cmd.Parameters.AddWithValue("prenom", prenom);
                    connection.Open();
                     
                    if (cmd.ExecuteScalar() != null)
                    {
                        personne = (int)(decimal) cmd.ExecuteScalar();
                    }
                    
   
                }
           }
            catch (SqlException)
           {
               throw new Exception("Une erreur sql s'est produite!");
           }
            return personne;
        }

        public int IsInscrit(string id, string motDePasse)
        {
            int countPersonne = 0;
            try
            {
                using(SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Personne where id = @id and motDePasse = @mdp", connection);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("mdp", motDePasse);
                    connection.Open();
                    if (cmd.ExecuteScalar() != null)
                    {
                        countPersonne = (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite");
            }
            return countPersonne;
        }


        public Personne whoIsInscrit(string id, string motDePasse)
        {
            Personne personne = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Personne where id = @id and motDePasse = @mdp", connection);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("mdp", motDePasse);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            personne = new Personne
                            {
                                ID_personne = reader.GetDecimal("id_personne"),
                                Nom = reader.GetString("nom"),
                                Prenom = reader.GetString("prenom"),
                                Tel = reader.GetString("tel"),
                                Id = reader.GetString("id"),
                                MotDePasse = reader.GetString("motDePasse"),
                            };
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
