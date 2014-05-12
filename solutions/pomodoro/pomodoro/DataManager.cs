using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pomodoro
{
    public class DataManager
    {
        private string db;

        public string DB
        {
            get { return db; }
            set { db = value; }
        }

        public void createDBOrSkip()
        {
            Console.WriteLine(Path.GetFullPath(DB));
            if (!File.Exists(DB))
            {
                try
                {
                    SQLiteConnection.CreateFile(DB);

                    var connectionString = String.Format("Data Source={0};Version=3;", DB);
                    using (var conn = new SQLiteConnection(connectionString))
                    {
                        conn.Open();
                        using (var cmd = conn.CreateCommand())
                        {
                            // Documentation: SQLite - CREATE TABLE: http://www.sqlite.org/lang_createtable.html
                            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Tag (
                                                TagID INTEGER PRIMARY KEY AUTOINCREMENT,
                                                Name TEXT
                                            )";
                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();


                            // Documentation: SQLite - Date and Time Datatype: http://www.sqlite.org/datatype3.html#datetime
                            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Entry (
                                                EntryID INTEGER PRIMARY KEY AUTOINCREMENT,
                                                Timestamp TEXT,
                                                Description TEXT
                                            )";
                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();

                            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Entry_Tag (
                                                EntryID INTEGER REFERENCES Entry(EntryID),
                                                TagID INTEGER REFERENCES Tag(TagID),
                                                PRIMARY KEY (EntryID, TagID)
                                            )";
                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (System.IO.IOException exception)
                {
                    Console.WriteLine(String.Format("{0}: {1}", exception.Source, exception.Message));
                }
            }
        }

        public void addNewEntry(DateTime timestamp, string description)
        {
            try
            {
                var connectionString = String.Format("Data Source={0};Version=3;", DB);
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = String.Format(@"INSERT INTO Entry (Timestamp, Description) VALUES ('{0}', '{1}')", timestamp.ToString("yyyy-MM-dd HH:mm:ss"), description);
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (System.IO.IOException exception)
            {
                Console.WriteLine(String.Format("{0}: {1}", exception.Source, exception.Message));
            }
            catch (System.Data.SQLite.SQLiteException exception)
            {
                Console.WriteLine(String.Format("{0}: {1}", exception.Source, exception.Message));
            }
        }
    }
}
