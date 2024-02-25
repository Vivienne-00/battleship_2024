using System.Data.SQLite;

namespace Battleship.Persistency
{
    public sealed class Database
    {
        private Database() { }
        private static Database database;
        private static SQLiteConnection sqlite_conn;
        public static Database GetInstance()
        {
            if (database == null)
            {
                // Create a new database connection:
                database = new Database();
                sqlite_conn = new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; ");
                Console.WriteLine("Creating Database connection.");
                // Open the connection:
                try
                {
                    sqlite_conn.Open();
                    CreateDataBase();
                    InsertData(sqlite_conn);
                    ReadData(sqlite_conn);
                    Console.WriteLine("Opened connection");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Couldnt open");
                }
            }
            return database;
        }

        private static void CreateDataBase()
        {
            SQLiteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE IF NOT EXISTS SampleTable (Col1 VARCHAR(20), Col2 INT)";
            string Createsql1 = "CREATE TABLE IF NOT EXISTS SampleTable1 (Col1 VARCHAR(20), Col2 INT)";
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = Createsql1;
            sqlite_cmd.ExecuteNonQuery();
        }

        public static void InsertData(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO SampleTable(Col1, Col2) VALUES('Test Text ', 1); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO SampleTable(Col1, Col2) VALUES('Test1 Text1 ', 2); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO SampleTable(Col1, Col2) VALUES('Test2 Text2 ', 3); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO SampleTable1(Col1, Col2) VALUES('Test3 Text3 ', 3); ";
            sqlite_cmd.ExecuteNonQuery();
        }
        public static void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM SampleTable";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                Console.WriteLine(myreader);
            }
            conn.Close();
        }

        public SQLiteConnection GetConnection()
        {
            sqlite_conn.Open();
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT name FROM  sqlite_schema WHERE      type ='table' AND     name NOT LIKE 'sqlite_%';";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Console.Write(sqlite_datareader.GetString(0));
            }
            return sqlite_conn;
        }

        public void DeleteTable()
        {
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "DROP TABLE IF EXISTS SampleTable;";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }
    }
}
