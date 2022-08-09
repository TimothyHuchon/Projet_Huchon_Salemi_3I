using Projet_Huchon_Salemi_3I.metier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;





namespace Projet_Huchon_Salemi_3I.DAO
{
    class BaladeDAO : DAO<Balade>
    {
        public override bool Create(Balade obj)
        {
            bool value = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Balade([lieu_depart],[dateDepart],[forfait]) VALUES(@lieu_depart,@dateDepart,@forfait)", connection);
                    cmd.Parameters.AddWithValue("lieu_depart", obj.LieuDepart);
                    cmd.Parameters.AddWithValue("dateDepart", obj.DateDepart);
                    cmd.Parameters.AddWithValue("forfait", obj.Forfait);
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

        public override bool Update(Balade obj)
        {
            bool value = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Balade SET [lieu_depart]=@lieu_depart, [dateDepart]=@dateDepart, [forfait]=@forfait WHERE num=@num", connection);
                    cmd.Parameters.AddWithValue("lieu_depart", obj.LieuDepart);
                    cmd.Parameters.AddWithValue("dateDepart", obj.DateDepart);
                    cmd.Parameters.AddWithValue("forfait", obj.Forfait);
                    cmd.Parameters.AddWithValue("num", obj.Num);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                value = true;
            }
            catch (SqlException)
            {

                throw new Exception("Une erreur sql s'est produite!"); ;
            }
            return value;
        }

        public override bool Delete(Balade obj)
        {
            bool value = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Balade WHERE num=@num", connection);
                    cmd.Parameters.AddWithValue("num", obj.Num);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                value = true;
            }
            catch (Exception)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }
            return value;
        }

        public override Balade Find(decimal num)
        {
            Balade balade = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Balade WHERE num = @num", connection);
                    cmd.Parameters.AddWithValue("num", num);
                    connection.Open();

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            balade = new Balade
                            {
                                Num = reader.GetInt32("num"),
                                LieuDepart = reader.GetString("lieu_depart"),
                                DateDepart = reader.GetDateTime("dateDepart"),
                                Forfait = reader.GetDecimal("forfait"),
                                ListeVehicule = new List<Vehicule>(),
                                ListeInscription = new List<Inscription>(),
                                CalendrierBalade = reader.GetDecimal("id_calendrier") 
                            };
                        }
                    }
                }
                if(balade != null)
                {
                    VehiculeDAO vehiculeDAO = new VehiculeDAO();
                    List<Vehicule> VehiculesBalade = vehiculeDAO.FindAllByBalade(balade);
                    foreach(Vehicule vehi in VehiculesBalade)
                    {
                        balade.listeVehicule.Add(vehi);
                    }


                    InscriptionDAO inscriptionDAO = new InscriptionDAO();
                    List<Inscription> inscriptionsBalade = inscriptionDAO.FindAllByBalade(balade);
                    foreach(Inscription inscri in inscriptionsBalade)
                    {
                        balade.listeInscription.Add(inscri);
                    }

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
            return balade;
        }

        public decimal recupForfait(decimal id)
        {
            decimal forfait = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT forfait FROM balade where num = @id", connection);
                    cmd.Parameters.AddWithValue("id", id);
                    connection.Open();
                    forfait = (decimal)cmd.ExecuteScalar();

                }
            }
            catch (SqlException)
            {
                throw new Exception("Une erreur sql s'est produite!");
            }
            return forfait;
        }

        public bool CreateTransport(Decimal vehi, Decimal bal)
        {
            bool value = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Transport([id_vehicule],[num_balade]) VALUES(@id_vehicule,@num_balade)", connection);
                    cmd.Parameters.AddWithValue("id_vehicule", vehi);
                    cmd.Parameters.AddWithValue("num_balade", bal);
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
    }
}
