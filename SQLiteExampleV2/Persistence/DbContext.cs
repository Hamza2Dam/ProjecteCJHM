using System;
using System.Data.SQLite;
using System.IO;

namespace SQLiteExampleV2.Persistence
{
    public class DbContext
    {
        private const string DBName = "database7.sqlite";
        private const string SQLScript = @"..\..\..\Util\database.sql";
        private static bool IsDbRecentlyCreated = false;

        public static void Up()
        {
            // Crea la base de datos solo una vez
            if (!File.Exists(Path.GetFullPath(DBName)))
            {
                SQLiteConnection.CreateFile(DBName);
                IsDbRecentlyCreated = true;
            }

            using (var ctx = GetInstance())
            {
                // Crea la base de datos solo la primera vez
                if (IsDbRecentlyCreated)
                {
                    using (var reader = new StreamReader(Path.GetFullPath(SQLScript)))
                    {
                        var query = "";
                        var line = "";
                        while ((line = reader.ReadLine()) != null)
                        {
                            query += line;
                        }

                        using (var command = new SQLiteCommand(query, ctx))
                        {
                            command.ExecuteNonQuery();
                        }
                    }

                    // Insert a Users
                    for (var i = 1; i <= 15; i++)
                    {
                        var query = "INSERT INTO Users (name, lastname, birthday) VALUES (?, ?, ?)";

                        using (var command = new SQLiteCommand(query, ctx))
                        {
                  
                            command.Parameters.Add(new SQLiteParameter("name", ""));
                            command.Parameters.Add(new SQLiteParameter("lastname", "" ));

                            var rnd = new Random();
                            command.Parameters.Add(new SQLiteParameter("birthday", DateTime.Today.AddYears(-rnd.Next(1, 50))));

                            command.ExecuteNonQuery();
                        }
                    }

                    // Insert a Tasca
                    for (var i = 1; i <= 10; i++)
                    {
                        var query = "INSERT INTO Tasca (Nom, Descripcio, Responsable, Colors, Data_Inici, Data_Final, Estat) VALUES (?, ?, ?, ?, ?, ?, ?)";

                        using (var command = new SQLiteCommand(query, ctx))
                        {

                            command.Parameters.Add(new SQLiteParameter("Nom", "" ));
                            command.Parameters.Add(new SQLiteParameter("Descripcio", ""));
                            command.Parameters.Add(new SQLiteParameter("Responsable", ""));
                            command.Parameters.Add(new SQLiteParameter("Colors", " " ));

                            var rnd = new Random();
                            command.Parameters.Add(new SQLiteParameter("Data_Inici", DateTime.Today.AddYears(-rnd.Next(1, 50))));
                            command.Parameters.Add(new SQLiteParameter("Data_Final", DateTime.Today.AddYears(-rnd.Next(1, 50))));
                            command.Parameters.Add(new SQLiteParameter("Estat", "TODO"));

                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
        }


        // SQLiteConnection
        public static SQLiteConnection GetInstance()
        {
            var db = new SQLiteConnection(
                string.Format("Data Source={0};Version=3;", DBName)
            );

            db.Open();

            return db;
        }







    }
}
