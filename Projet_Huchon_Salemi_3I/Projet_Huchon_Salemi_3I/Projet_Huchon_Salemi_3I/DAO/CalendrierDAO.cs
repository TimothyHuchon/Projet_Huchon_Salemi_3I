using Projet_Huchon_Salemi_3I.metier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Projet_Huchon_Salemi_3I.DAO
{
    public class CalendrierDAO : DAO<Calendrier>
    {
        public CalendrierDAO() { }
        public override bool Create(Calendrier obj)
        {
            bool value = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Calendrier([num_categorie]) VALUES(@num); ", connection);
                    cmd.Parameters.AddWithValue("num", obj.NUM_categorie);
       
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

        public override bool Delete(Calendrier obj)
        {
            bool value = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Calendrier WHERE id_calendrier = @id", connection);
                    cmd.Parameters.AddWithValue("id", obj.ID_calendrier);
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

        public override Calendrier Find(decimal id)
        {
            Calendrier calendrier = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Calendrier where id_calendrier = @id", connection);
                    cmd.Parameters.AddWithValue("id", id);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            calendrier = new Calendrier
                            {
                                ID_calendrier = reader.GetDecimal("id_calendrier"),
                                NUM_categorie = reader.GetDecimal("num_categorie")
                            };
                        }

                    }
                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }

            return calendrier;
        }

        public override bool Update(Calendrier obj)
        {
            bool value = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Calendrier SET [id_calendrier] = @id,[num_categorie] = @num WHERE id_calendrier = @id", connection);
                    cmd.Parameters.AddWithValue("id", obj.ID_calendrier);
                    cmd.Parameters.AddWithValue("num", obj.NUM_categorie);
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

        public List<decimal> idByCategorie(decimal num)
        {
            List<decimal> listId = new List<decimal>();
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT id_calendrier FROM Calendrier where num_categorie = @num", connection);
                    cmd.Parameters.AddWithValue("num", num);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal calendrier = reader.GetDecimal("id_calendrier");
                            listId.Add(calendrier);
                        }
                    }
                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite");
            }
            return listId;
        }
    }
}
