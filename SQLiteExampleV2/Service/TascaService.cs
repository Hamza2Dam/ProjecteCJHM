using SQLiteExampleV2.Entity;
using SQLiteExampleV2.Persistence;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;

namespace SQLiteExampleV2.Service
{
    public class TascaService
    {

        // GetTODO
        public static List<Tasca> GetTODO()
        {
            var result = new List<Tasca>();

            using (var ctx = DbContext.GetInstance())
            {
                var query = "SELECT * FROM Tasca Where Estat ='TODO'";

                using (var command = new SQLiteCommand(query, ctx))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new Tasca
                            {
                                Codi = Convert.ToInt32(reader["Codi"].ToString()),
                                Nom = reader["Nom"].ToString(),
                                Descripcio = reader["Descripcio"].ToString(),
                                Responsable = reader["Responsable"].ToString(),
                                Colors = reader["Colors"].ToString(),
                                Data_Inici = Convert.ToDateTime(reader["Data_Inici"]),
                                Data_Final = Convert.ToDateTime(reader["Data_Final"]),
                                Estat = reader["Estat"].ToString(),

                            });
                        }
                    }
                }
            }
            return result;
        }

        // GetDOING
        public static List<Tasca> GetDOING()
        {
            var result = new List<Tasca>();

            using (var ctx = DbContext.GetInstance())
            {
                var query = "SELECT * FROM Tasca Where Estat ='DOING'";

                using (var command = new SQLiteCommand(query, ctx))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new Tasca
                            {
                                Codi = Convert.ToInt32(reader["Codi"].ToString()),
                                Nom = reader["Nom"].ToString(),
                                Descripcio = reader["Descripcio"].ToString(),
                                Responsable = reader["Responsable"].ToString(),
                                Colors = reader["Colors"].ToString(),
                                Data_Inici = Convert.ToDateTime(reader["Data_Inici"]),
                                Data_Final = Convert.ToDateTime(reader["Data_Final"]),
                                Estat = reader["Estat"].ToString(),

                            });
                        }
                    }
                }
            }
            return result;
        }

        // GetDONE
        public static List<Tasca> GetDONE()
        {
            var result = new List<Tasca>();

            using (var ctx = DbContext.GetInstance())
            {
                var query = "SELECT * FROM Tasca Where Estat ='DONE'";

                using (var command = new SQLiteCommand(query, ctx))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new Tasca
                            {
                                Codi = Convert.ToInt32(reader["Codi"].ToString()),
                                Nom = reader["Nom"].ToString(),
                                Descripcio = reader["Descripcio"].ToString(),
                                Responsable = reader["Responsable"].ToString(),
                                Colors = reader["Colors"].ToString(),
                                Data_Inici = Convert.ToDateTime(reader["Data_Inici"]),
                                Data_Final = Convert.ToDateTime(reader["Data_Final"]),
                                Estat = reader["Estat"].ToString(),

                            });
                        }
                    }
                }
            }
            return result;
        }

        // GETALL
        public static List<Tasca> GetALL()
        {
            var result = new List<Tasca>();

            using (var ctx = DbContext.GetInstance())
            {
                var query = "SELECT * FROM Tasca";

                using (var command = new SQLiteCommand(query, ctx))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new Tasca
                            {
                                Codi = Convert.ToInt32(reader["Codi"].ToString()),
                                Nom = reader["Nom"].ToString(),
                                Descripcio = reader["Descripcio"].ToString(),
                                Responsable = reader["Responsable"].ToString(),
                                Colors = reader["Colors"].ToString(),
                                Data_Inici = Convert.ToDateTime(reader["Data_Inici"]),
                                Data_Final = Convert.ToDateTime(reader["Data_Final"]),
                                Estat = reader["Estat"].ToString(),

                            });
                        }
                    }
                }
            }
            return result;
        }



        // Add TASCA
        public int Add(Tasca tasca)
        {
            int rows_afected = 0;
            using (var ctx = DbContext.GetInstance())
            {
                string query = "INSERT INTO Tasca (Nom, Descripcio, Responsable, Colors, Data_Inici, Data_Final, Estat) VALUES (?, ?, ?, ?, ?, ?, ?)";
                using (var command = new SQLiteCommand(query, ctx))
                {
                    command.Parameters.Add(new SQLiteParameter("Nom", tasca.Nom));
                    command.Parameters.Add(new SQLiteParameter("Descripcio", tasca.Descripcio));
                    command.Parameters.Add(new SQLiteParameter("Responsable", tasca.Responsable));
                    command.Parameters.Add(new SQLiteParameter("Colors", tasca.Colors));
                    command.Parameters.Add(new SQLiteParameter("Data_Inici", tasca.Data_Inici));
                    command.Parameters.Add(new SQLiteParameter("Data_Final", tasca.Data_Final));
                    command.Parameters.Add(new SQLiteParameter("Estat", tasca.Estat));

                    rows_afected = command.ExecuteNonQuery();
                }
            }

            return rows_afected;
        }

        // Update TASCA
        public int Update(Tasca tasca)
        {
            int rows_afected = 0;
            using (var ctx = DbContext.GetInstance())
            {
                string query = "UPDATE Tasca SET Nom = ?, Descripcio = ?, Responsable = ?, Colors = ?,  Data_Inici = ?, Data_Final = ?, Estat = ? WHERE Codi = ?";
                using (var command = new SQLiteCommand(query, ctx))
                {
                    command.Parameters.Add(new SQLiteParameter("Nom", tasca.Nom));
                    command.Parameters.Add(new SQLiteParameter("Descripcio", tasca.Descripcio));
                    command.Parameters.Add(new SQLiteParameter("Responsable", tasca.Responsable));
                    command.Parameters.Add(new SQLiteParameter("Colors", tasca.Colors));
                    command.Parameters.Add(new SQLiteParameter("Data_Inici", tasca.Data_Inici));
                    command.Parameters.Add(new SQLiteParameter("Data_Final", tasca.Data_Final));
                    command.Parameters.Add(new SQLiteParameter("Estat", tasca.Estat));
                    command.Parameters.Add(new SQLiteParameter("Codi", tasca.Codi));

                    rows_afected = command.ExecuteNonQuery();
                }
            }

            return rows_afected;
        }

        // Delete TASCA
        public int Delete(int Codi)
        {
            int rows_afected = 0;
            using (var ctx = DbContext.GetInstance())
            {
                string query = "DELETE FROM Tasca WHERE Codi = ?";
                using (var command = new SQLiteCommand(query, ctx))
                {
                    command.Parameters.Add(new SQLiteParameter("Codi", Codi));
                    rows_afected = command.ExecuteNonQuery();
                }
            }

            return rows_afected;
        }


        // Pasar la tasca de TODO a DOING
        public int Update_Todo_Doing(int Codi)
        {
            int rows_afected = 0;
            using (var ctx = DbContext.GetInstance())
            {
                string query = "UPDATE Tasca SET Estat = 'DOING' WHERE Codi = ?";
                using (var command = new SQLiteCommand(query, ctx))
                {
                    command.Parameters.Add(new SQLiteParameter("Codi", Codi));
                    rows_afected = command.ExecuteNonQuery();
                }
            }

            return rows_afected;
        }


        // Pasar la tasca de DOING a TODO
        public int Update_Doing_Todo(int Codi)
        {
            int rows_afected = 0;
            using (var ctx = DbContext.GetInstance())
            {
                string query = "UPDATE Tasca SET Estat = 'TODO' WHERE Codi = ?";
                using (var command = new SQLiteCommand(query, ctx))
                {
                    command.Parameters.Add(new SQLiteParameter("Codi", Codi));
                    rows_afected = command.ExecuteNonQuery();
                }
            }

            return rows_afected;
        }

        // Pasar la tasca de DOING a DONE
        public int Update_Doing_Done(int Codi)
        {
            int rows_afected = 0;
            using (var ctx = DbContext.GetInstance())
            {
                string query = "UPDATE Tasca SET Estat = 'DONE' WHERE Codi = ?";
                using (var command = new SQLiteCommand(query, ctx))
                {
                    command.Parameters.Add(new SQLiteParameter("Codi", Codi));
                    rows_afected = command.ExecuteNonQuery();
                }
            }

            return rows_afected;
        }

        // Pasar la tasca de DONE a DOING
        public int Update_Done_Doing(int Codi)
        {
            int rows_afected = 0;
            using (var ctx = DbContext.GetInstance())
            {
                string query = "UPDATE Tasca SET Estat = 'DOING' WHERE Codi = ?";
                using (var command = new SQLiteCommand(query, ctx))
                {
                    command.Parameters.Add(new SQLiteParameter("Codi", Codi));
                    rows_afected = command.ExecuteNonQuery();
                }
            }

            return rows_afected;
        }


    }
}
