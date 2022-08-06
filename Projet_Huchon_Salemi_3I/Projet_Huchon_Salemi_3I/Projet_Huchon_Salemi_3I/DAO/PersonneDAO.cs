
using Projet_Huchon_Salemi_3I.metier;
using System;
using System.Collections.Generic;
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
            return false;
        }

        public override bool Delete(Personne obj)
        {
            return false;
        }

        public override bool Update(Personne obj)
        {
            return false;
        }

        public override Personne Find(int id)
        {
            return null;
        }

        public Personne FindId(String nom, String prenom)
        {
            Personne personne = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("select * from Personne where nom = @nom and prenom = @prenom", connection);
                    cmd.Parameters.AddWithValue("nom", personne.Nom);
                    cmd.Parameters.AddWithValue("prenom", personne.Prenom);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            personne = new Personne
                            {
                                ID_personne = reader.GetInt32("id_personne")
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
    }
}
