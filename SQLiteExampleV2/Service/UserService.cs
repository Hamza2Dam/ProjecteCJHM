using SQLiteExampleV2.Entity;
using SQLiteExampleV2.Persistence;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;

namespace SQLiteExampleV2.Service
{
    public class UserService
    {
       
        /// <summary>
        /// Obté tots els usuaris
        /// </summary>
        /// <returns></returns>
        public static List<User> GetAll()
        {
            var result = new List<User>();

            using (var ctx = DbContext.GetInstance())
            {
                var query = "SELECT * FROM Users";

                using (var command = new SQLiteCommand(query, ctx))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new User
                            {
                                Id = Convert.ToInt32(reader["id"].ToString()),
                                Name = reader["Name"].ToString(),
                                LastName = reader["Lastname"].ToString(),
                                Birthday = Convert.ToDateTime(reader["Birthday"]),
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
        /// <param name="user">Entitat usuari</param>
        /// <returns>El número d'usuaris afegits</returns>
        public int Add(User user)
        {
            int rows_afected = 0;
            using (var ctx = DbContext.GetInstance())
            {
                string query = "INSERT INTO Users (name, lastname, birthday) VALUES (?, ?, ?)";
                using (var command = new SQLiteCommand(query, ctx))
                {
                    command.Parameters.Add(new SQLiteParameter("name", user.Name));
                    command.Parameters.Add(new SQLiteParameter("lastname", user.LastName));
                    command.Parameters.Add(new SQLiteParameter("birthday", user.Birthday));

                    rows_afected  = command.ExecuteNonQuery();
                }
            }

            return rows_afected;
        }

        /// <summary>
        /// Actualitza un usuari
        /// </summary>
        /// <param name="user">Entitat usuari que es vol modificar</param>
        /// <returns>El número de usuaris modificats</returns>
        public int Update(User user)
        {
            int rows_afected = 0;
            using (var ctx = DbContext.GetInstance())
            {
                string query = "UPDATE Users SET name = ?, lastname = ?, birthday = ? WHERE Id = ?";
                using (var command = new SQLiteCommand(query, ctx))
                {
                    command.Parameters.Add(new SQLiteParameter("name", user.Name));
                    command.Parameters.Add(new SQLiteParameter("Lastname", user.LastName));
                    command.Parameters.Add(new SQLiteParameter("Birthday", user.Birthday));
                    command.Parameters.Add(new SQLiteParameter("Id", user.Id));

                    rows_afected = command.ExecuteNonQuery();
                }
            }

            return rows_afected;
        }

        /// <summary>
        /// Elimina un usuari
        /// </summary>
        /// <param name="Id">Codi d'usuari que es vol eliminar</param>
        /// <returns>El número d'usuaris eliminats></returns>
        public int Delete(int Id)
        {
            int rows_afected = 0;
            using (var ctx = DbContext.GetInstance())
            {
                string query = "DELETE FROM Users WHERE Id = ?";
                using (var command = new SQLiteCommand(query, ctx))
                {
                   command.Parameters.Add(new SQLiteParameter("Id", Id));
                   rows_afected = command.ExecuteNonQuery();
                }
            }

            return rows_afected;
        }

    }
}
