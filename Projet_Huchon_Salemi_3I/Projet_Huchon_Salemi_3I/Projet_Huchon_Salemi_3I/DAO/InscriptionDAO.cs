﻿using Projet_Huchon_Salemi_3I.metier;
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
            return false;
        }

        public override bool Update(Inscription obj)
        {
            return false;
        }

        public override bool Delete(Inscription obj)
        {
            return false;
        }

        public override Inscription Find(int id)
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

    }
}