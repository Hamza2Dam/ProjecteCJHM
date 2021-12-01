using System;
using System.Data.SQLite;
using System.IO;

namespace SQLiteExampleV2.Persistence
{
    public class DbContext
    {
        private const string DBName = "database.sqlite";
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
