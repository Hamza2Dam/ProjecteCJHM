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

        /// <summary>
        /// Obté tots els usuaris
        /// </summary>
        /// <returns></returns>
        public static List<Tasca> GetAll()
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

                            });
                        }
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Afegeix un nou usuari a la base de dades
        /// </summary>
        /// <param nom="tasca">Entitat usuari</param>
        /// <returns>El número d'usuaris afegits</returns>
        public int Add(Tasca tasca)
        {
            int rows_afected = 0;
            using (var ctx = DbContext.GetInstance())
            {
                string query = "INSERT INTO Tasca (Nom, Descripcio, Responsable, Colors, Data_Inici, Data_Final) VALUES (?, ?, ?, ?, ?, ?)";
                using (var command = new SQLiteCommand(query, ctx))
                {
                    command.Parameters.Add(new SQLiteParameter("Nom", tasca.Nom));
                    command.Parameters.Add(new SQLiteParameter("Descripcio", tasca.Descripcio));
                    command.Parameters.Add(new SQLiteParameter("Responsable", tasca.Responsable));
                    command.Parameters.Add(new SQLiteParameter("Colors", tasca.Colors));
                    command.Parameters.Add(new SQLiteParameter("Data_Inici", tasca.Data_Inici));
                    command.Parameters.Add(new SQLiteParameter("Data_Final", tasca.Data_Final));

                    rows_afected = command.ExecuteNonQuery();
                }
            }

            return rows_afected;
        }

        public int Update(Tasca tasca)
        {
            int rows_afected = 0;
            using (var ctx = DbContext.GetInstance())
            {
                string query = "UPDATE Tasca SET Nom = ?, Descripcio = ?, Responsable = ?, Colors = ?,  Data_Inici = ?, Data_Final = ? WHERE Id = ?";
                using (var command = new SQLiteCommand(query, ctx))
                {
                    command.Parameters.Add(new SQLiteParameter("Nom", tasca.Nom));
                    command.Parameters.Add(new SQLiteParameter("Descripcio", tasca.Descripcio));
                    command.Parameters.Add(new SQLiteParameter("Responsable", tasca.Responsable));
                    command.Parameters.Add(new SQLiteParameter("Colors", tasca.Colors));
                    command.Parameters.Add(new SQLiteParameter("Data_Inici", tasca.Data_Inici));
                    command.Parameters.Add(new SQLiteParameter("Data_Final", tasca.Data_Final));

                    rows_afected = command.ExecuteNonQuery();
                }
            }

            return rows_afected;
        }

    }
}
