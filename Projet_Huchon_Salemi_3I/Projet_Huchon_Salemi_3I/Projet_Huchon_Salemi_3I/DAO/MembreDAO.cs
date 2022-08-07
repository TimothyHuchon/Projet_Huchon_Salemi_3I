
using Projet_Huchon_Salemi_3I.metier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Projet_Huchon_Salemi_3I.DAO
{
    public class MembreDAO : DAO<Membre>
    {
        public MembreDAO() {}

        public override bool Create(Membre obj)
        {
            bool value = false;
            try
            {
                if (VerifierIdPresent(obj.ID_personne) == false)
                {
                    using (SqlConnection connection = new SqlConnection(this.connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Membre([id_personne],[solde],[compte_banquaire]) VALUES(@id, @solde, @cpt); ", connection);
                        cmd.Parameters.AddWithValue("id", obj.ID_personne);
                        cmd.Parameters.AddWithValue("solde", obj.Solde);
                        cmd.Parameters.AddWithValue("cpt", obj.CptBanquaire);
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

        public override bool Delete(Membre obj)
        {
            bool value = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Membre WHERE id_personne = @id", connection);
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

        public override Membre Find(decimal id)
        {
            Membre membre = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Membre where id_personne = @id", connection);
                    cmd.Parameters.AddWithValue("id", id);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            membre = new Membre
                            {
                                ID_personne = reader.GetDecimal("id_personne"),
                                Solde = reader.GetDecimal("solde"),
                                CptBanquaire = reader.GetDecimal("compte_banquaire"),
                            };
                        }

                    }
                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }

            return membre;
        }

        public override bool Update(Membre obj)
        {
            bool value = false; 
            try
            {
                    using (SqlConnection connection = new SqlConnection(this.connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Membre SET [id_personne] = @id,[solde] = @solde,[compte_banquaire] = @compte WHERE id_personne = @id", connection);
                        cmd.Parameters.AddWithValue("id", obj.ID_personne);
                        cmd.Parameters.AddWithValue("solde", obj.Solde);
                        cmd.Parameters.AddWithValue("compte", obj.CptBanquaire);
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
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Membre where id_personne = @id", connection);
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

        public decimal TotalofAbonnementCat(decimal id)
        {
            int TotalofAbonnement = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM MembreByCat where id_personne = @id", connection);
                    cmd.Parameters.AddWithValue("id", id);
                    connection.Open();
                    TotalofAbonnement = (int)cmd.ExecuteScalar();

                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }
            return TotalofAbonnement;
        }

        public decimal RecupCptBanquaire(decimal id)
        {
            decimal cptbanquaire = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT compte_banquaire FROM Membre where id_personne = @id", connection);
                    cmd.Parameters.AddWithValue("id", id);
                    connection.Open();
                    cptbanquaire = (decimal)cmd.ExecuteScalar();
                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }
            return cptbanquaire;
        }

        public decimal RecupSolde(decimal id)
        {
            decimal cptbanquaire = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT solde FROM Membre where id_personne = @id", connection);
                    cmd.Parameters.AddWithValue("id", id);
                    connection.Open();
                    cptbanquaire = (decimal)cmd.ExecuteScalar();
                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }
            return cptbanquaire;
        }
    }
}
