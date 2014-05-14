﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;

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

        public Tracer tracer;

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
                        //cmd.CommandText = String.Format(@"INSERT INTO Entry (Timestamp, Description) VALUES ('{0}', '{1}')", timestamp.ToString("yyyy-MM-dd HH:mm:ss"), description);
                        cmd.CommandText = @"INSERT INTO Entry (Timestamp, Description) VALUES (@Timestamp, @Description)";

                        SQLiteParameter pTimestamp = new SQLiteParameter { ParameterName = "@Timestamp", Value = timestamp.ToString("yyyy-MM-dd HH:mm:ss") };
                        cmd.Parameters.Add(pTimestamp);

                        SQLiteParameter pDescription = new SQLiteParameter { ParameterName = "@Description", Value = description };
                        cmd.Parameters.Add(pDescription);

                        cmd.CommandType = CommandType.Text;

                        tracer.PutSQLQuery(cmd, 11);

                        cmd.ExecuteNonQuery();

                        //cmd.CommandText = String.Format(@"SELECT EntryID FROM Entry WHERE Timestamp = '{0}'", timestamp.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.CommandText = @"SELECT EntryID FROM Entry WHERE Timestamp = @Timestamp";

                        pTimestamp = new SQLiteParameter { ParameterName = "@Timestamp", Value = timestamp.ToString("yyyy-MM-dd HH:mm:ss") };
                        cmd.Parameters.Add(pTimestamp);
                        
                        cmd.CommandType = CommandType.Text;

                        tracer.PutSQLQuery(cmd, 12);

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
                        // cmd.CommandText = String.Format(@"DELETE FROM Entry WHERE EntryID = {0}", entryID);
                        cmd.CommandText = @"DELETE FROM Entry WHERE EntryID = @EntryID";

                        SQLiteParameter pEntryID = new SQLiteParameter { ParameterName = "@EntryID", Value = entryID };
                        cmd.Parameters.Add(pEntryID);

                        cmd.CommandType = CommandType.Text;

                        tracer.PutSQLQuery(cmd, 13);

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
                        cmd.CommandText = @"SELECT Name FROM Tag";
                        cmd.CommandType = CommandType.Text;

                        tracer.PutSQLQuery(cmd, 15);

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
                        //cmd.CommandText = String.Format(@"INSERT INTO Tag (Name) VALUES ('{0}')", tag);
                        cmd.CommandText = @"INSERT INTO Tag (Name) VALUES (@Tag)";
                        
                        
                        SQLiteParameter pTag = new SQLiteParameter { ParameterName = "@Tag", Value = tag };
                        cmd.Parameters.Add(pTag);

                        cmd.CommandType = CommandType.Text;

                        tracer.PutSQLQuery(cmd, 16);

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
                            //cmd.CommandText = String.Format(@"INSERT INTO Entry_Tag (EntryID, TagID) VALUES ('{0}', (SELECT TagID FROM Tag WHERE Name = '{1}'))", newEntryID, item);
                            cmd.CommandText = @"INSERT INTO Entry_Tag (EntryID, TagID) VALUES (@NewEntryID, (SELECT TagID FROM Tag WHERE Name = @Item))";
                            
                            SQLiteParameter pNewEntryID = new SQLiteParameter { ParameterName = "@NewEntryID", Value = newEntryID };
                            cmd.Parameters.Add(pNewEntryID);

                            SQLiteParameter pItem = new SQLiteParameter { ParameterName = "@Item", Value = item };
                            cmd.Parameters.Add(pItem);

                            cmd.CommandType = CommandType.Text;

                            tracer.PutSQLQuery(cmd, 17);

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

        public List<string> getTagsByEntry(string entryID)
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
                        //cmd.CommandText = String.Format(@"SELECT Name FROM Tag WHERE TagID IN (SELECT TagID FROM Entry_Tag WHERE Entry_Tag.EntryID = '{0}')", EntryID);
                        cmd.CommandText = @"SELECT Name FROM Tag WHERE TagID IN (SELECT TagID FROM Entry_Tag WHERE Entry_Tag.EntryID = @EntryID)";
                        
                        SQLiteParameter pEntryID = new SQLiteParameter { ParameterName = "@EntryID", Value = entryID };
                        cmd.Parameters.Add(pEntryID);
                        
                        cmd.CommandType = CommandType.Text;

                        tracer.PutSQLQuery(cmd, 18);

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
                        //cmd.CommandText = String.Format(@"DELETE FROM Entry_Tag WHERE EntryID = {0}", entryID);
                        cmd.CommandText = @"DELETE FROM Entry_Tag WHERE EntryID = @EntryID";

                        SQLiteParameter pEntryID = new SQLiteParameter { ParameterName = "@EntryID", Value = entryID };
                        cmd.Parameters.Add(pEntryID);

                        cmd.CommandType = CommandType.Text;

                        tracer.PutSQLQuery(cmd, 19);

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
                        //cmd.CommandText = String.Format(@"UPDATE Entry SET Description = '{0}' WHERE EntryID = {1} AND Description = '{2}'", newEntryDescription, entryID, oldEntryDescription);
                        cmd.CommandText = @"UPDATE Entry SET Description = @NewEntryDescription WHERE EntryID = @EntryID AND Description = @OldEntryDescription";

                        SQLiteParameter pNewEntryDescription = new SQLiteParameter { ParameterName = "@NewEntryDescription", Value = newEntryDescription };
                        cmd.Parameters.Add(pNewEntryDescription);

                        SQLiteParameter pEntryID = new SQLiteParameter { ParameterName = "@EntryID", Value = entryID };
                        cmd.Parameters.Add(pEntryID);
                        
                        SQLiteParameter pOldEntryDescription = new SQLiteParameter { ParameterName = "@OldEntryDescription", Value = oldEntryDescription };
                        cmd.Parameters.Add(pOldEntryDescription);

                        tracer.PutSQLQuery(cmd, 1234);

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

        public void UpdateTags(string entryID, string oldTags, string newTagsAsString)
        {
            this.deleteTagsByEntryID(long.Parse(entryID));

            newTagsAsString = newTagsAsString.Replace(" ", string.Empty);
            HashSet<string> tags = new HashSet<string>(newTagsAsString.Split(new Char[] { ',' }));
            HashSet<string> tagsInDB = this.getTagsAsArray();

            foreach (var item in tags)
            {
                if (!tagsInDB.Contains(item))
                {
                    this.addNewTag(item);
                }
            }

            this.addTagsToEntry(long.Parse(entryID), tags);
        }
    }
}
