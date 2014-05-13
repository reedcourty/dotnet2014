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

        public long addNewEntry(DateTime timestamp, string description)
        {
            long newEntryID = -1;
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

                        cmd.CommandText = String.Format(@"SELECT EntryID FROM Entry WHERE Timestamp = '{0}'", timestamp.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.CommandType = CommandType.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                newEntryID = reader.GetInt64(0);
                            }

                        }
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
            return newEntryID;
        }

        public void deleteEntryByID(long entryID)
        {
            try
            {
                var connectionString = String.Format("Data Source={0};Version=3;", DB);
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        // Documentation: SQLite - DELETE http://www.sqlite.org/lang_delete.html
                        cmd.CommandText = String.Format(@"DELETE FROM Entry WHERE EntryID = {0}", entryID);
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

        public HashSet<string> getTagsAsArray()
        {
            HashSet<string> result = new HashSet<string>();
            try
            {
                var connectionString = String.Format("Data Source={0};Version=3;", DB);
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        // Documentation: SQLite - SELECT http://www.sqlite.org/lang_select.html
                        cmd.CommandText = String.Format(@"SELECT Name FROM Tag");
                        cmd.CommandType = CommandType.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                result.Add(reader["Name"] as string);
                            }

                        }
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

            return result;
        }

        public void addNewTag(string tag)
        {
            try
            {
                var connectionString = String.Format("Data Source={0};Version=3;", DB);
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = String.Format(@"INSERT INTO Tag (Name) VALUES ('{0}')", tag);
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

        public void addTagsToEntry(long newEntryID, HashSet<string> tags)
        {

            Console.WriteLine("{0}, {1}", newEntryID, tags.ToString());

            try
            {
                var connectionString = String.Format("Data Source={0};Version=3;", DB);
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        foreach (var item in tags)
                        {
                            cmd.CommandText = String.Format(@"INSERT INTO Entry_Tag (EntryID, TagID) VALUES ('{0}', (SELECT TagID FROM Tag WHERE Name = '{1}'))", newEntryID, item);
                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();    
                        }
                        
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

        public List<string> getTagsByEntry(string EntryID)
        {
            List<string> result = new List<string>();

            try
            {
                var connectionString = String.Format("Data Source={0};Version=3;", DB);
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        // Documentation: SQLite - SELECT http://www.sqlite.org/lang_select.html
                        cmd.CommandText = String.Format(@" SELECT Name FROM Tag WHERE TagID IN (SELECT TagID FROM Entry_Tag WHERE Entry_Tag.EntryID = '{0}')", EntryID);
                        cmd.CommandType = CommandType.Text;
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                result.Add(reader["Name"] as string);
                            }

                        }
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

            return result;
        }

        public void deleteTagsByEntryID(long entryID)
        {
            try
            {
                var connectionString = String.Format("Data Source={0};Version=3;", DB);
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        // Documentation: SQLite - DELETE http://www.sqlite.org/lang_delete.html
                        cmd.CommandText = String.Format(@"DELETE FROM Entry_Tag WHERE EntryID = {0}", entryID);
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

        public void OptimisticUpdate(string entryID, string oldEntryDescription, string oldTags, string newEntryDescription, string newTagsAsString)
        {
            try
            {
                var connectionString = String.Format("Data Source={0};Version=3;", DB);
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        // Documentation: SQLite - UPDATE: http://www.sqlite.org/lang_update.html
                        cmd.CommandText = String.Format(@"UPDATE Entry SET Description = '{0}' WHERE EntryID = {1} AND Description = '{2}'", newEntryDescription, entryID, oldEntryDescription);
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
