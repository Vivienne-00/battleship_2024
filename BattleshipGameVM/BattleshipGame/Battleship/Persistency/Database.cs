using System.Data.SQLite;

namespace Battleship.Persistency
{
    public sealed class Database
    {
        private Database() { }
        private static Database database;
        private static SQLiteConnection sqlite_conn;

        public static String actualUser = "";
        public static Languages actualLanguage = Languages.German;
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
                    if (CheckForTranslationTable() == 0) { InsertData(sqlite_conn); }
                    ReadData(sqlite_conn);
                    GetTableNames();

                    Console.WriteLine("Opened connection");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Couldnt open");
                }
            }
            return database;
        }


        private static int CheckForTranslationTable()
        {
            int result = 0;
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT COUNT(German) as Count FROM Translations;";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                //int myreader = sqlite_datareader.GetInt32(0);
                String s = "" + sqlite_datareader["Count"];
                result = Convert.ToInt32(s);
                //Console.WriteLine(s);
            }
            return result;
        }
        private static void CreateDataBase()
        {
            SQLiteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE IF NOT EXISTS UserData (ID INTEGER PRIMARY KEY,    Username TEXT NOT NULL,   Highscore INTEGER NOT NULL);";
            string Createsql1 = "CREATE TABLE IF NOT EXISTS Translations (TranslationID INTEGER PRIMARY KEY,  German TEXT NOT NULL, English TEXT NOT NULL, Spanish TEXT NOT NULL);"; //, Japanese TEXT NOT NULL);";
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
            sqlite_cmd.CommandText = "INSERT INTO Translations(German, English, Spanish) VALUES('Willkommen', 'Welcome', 'Bienvenido'); ";
            sqlite_cmd.ExecuteNonQuery();
            SQLiteCommand cmd1;
            cmd1 = conn.CreateCommand();
            cmd1.CommandText = "INSERT INTO Translations(German, English, Spanish) VALUES('Englisch', 'English', 'Ingles'); ";
            cmd1.ExecuteNonQuery();
            SQLiteCommand cmd2;
            cmd2 = conn.CreateCommand();
            cmd2.CommandText = "INSERT INTO Translations(German, English, Spanish) VALUES('Deutsch', 'German', 'Aleman'); ";
            cmd2.ExecuteNonQuery();
            SQLiteCommand cmd3;
            cmd3 = conn.CreateCommand();
            cmd3.CommandText = "INSERT INTO Translations(German, English, Spanish) VALUES('Spanisch', 'Spanish', 'Español'); ";
            cmd3.ExecuteNonQuery();
            SQLiteCommand cmd4;
            cmd4 = conn.CreateCommand();
            cmd4.CommandText = "INSERT INTO Translations(German, English, Spanish) VALUES('Benutzername', 'Username', 'Usuario'); ";
            cmd4.ExecuteNonQuery();
            SQLiteCommand cmd5;
            cmd5 = conn.CreateCommand();
            cmd5.CommandText = "INSERT INTO Translations(German, English, Spanish) VALUES('Eingabe', 'Enter', 'Ingresar'); ";
            cmd5.ExecuteNonQuery();
            SQLiteCommand cmd6;
            cmd6 = conn.CreateCommand();
            cmd6.CommandText = "INSERT INTO Translations(German, English, Spanish) VALUES('Spielmodus', 'Game Mode', 'Modo de juego'); ";
            cmd6.ExecuteNonQuery();
            SQLiteCommand cmd7;
            cmd7 = conn.CreateCommand();
            cmd7.CommandText = "INSERT INTO Translations(German, English, Spanish) VALUES('Mensch', 'Human', 'Humano'); ";
            cmd7.ExecuteNonQuery();
            SQLiteCommand cmd8;
            cmd8 = conn.CreateCommand();
            cmd8.CommandText = "INSERT INTO Translations(German, English, Spanish) VALUES('Computer', 'Computer', 'Computadora'); ";
            cmd8.ExecuteNonQuery();

            //sqlite_cmd.CommandText = "INSERT INTO Translations(Col1, Col2) VALUES('Test1 Text1 ', 2); ";
            //sqlite_cmd.ExecuteNonQuery();
            //sqlite_cmd.CommandText = "INSERT INTO Translations(Col1, Col2) VALUES('Test2 Text2 ', 3); ";
            //sqlite_cmd.ExecuteNonQuery();
            //sqlite_cmd.CommandText = "INSERT INTO Translations(Col1, Col2) VALUES('Test3 Text3 ', 3); ";
            //sqlite_cmd.ExecuteNonQuery();
        }
        public static void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Translations;";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                int myreader = sqlite_datareader.GetInt32(0);
                String s = "" + sqlite_datareader["German"] + " " + sqlite_datareader["English"] + " " + sqlite_datareader["Spanish"];
                Console.WriteLine(myreader + s);
            }
            //conn.Close();
        }

        public static SQLiteConnection GetTableNames()
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT name FROM  sqlite_schema WHERE type ='table' AND name NOT LIKE 'sqlite_%';";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Console.Write(sqlite_datareader.GetString(0));
            }
            return sqlite_conn;
        }

        public void DeleteTable()
        {
            //sqlite_conn.Open();
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "DROP TABLE IF EXISTS SampleTable;";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }


        public void InsertUser(String user)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = $"SELECT COUNT(*) as Count FROM UserData WHERE '{user}' = Username;";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            bool userExists = false;
            while (sqlite_datareader.Read())
            {
                int count = sqlite_datareader.GetInt32(0);
                //String s = "" + sqlite_datareader["Count"];
                if (count != 0) userExists = true;
                //Console.WriteLine(myreader + s);
            }

            if (!userExists)
            {
                SQLiteCommand sqlite_cmd2;
                sqlite_cmd2 = sqlite_conn.CreateCommand();
                sqlite_cmd2.CommandText = $"INSERT INTO UserData(Username, Highscore) VALUES('{user}', 0); "; //, 'いらっしゃいませ'
                sqlite_cmd2.ExecuteNonQuery();
            }
            actualUser = user;
        }

        public int GetHighScore()
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = $"SELECT Highscore FROM UserData WHERE '{actualUser}' = Username;";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            int highScore = -1;
            while (sqlite_datareader.Read())
            {
                highScore = sqlite_datareader.GetInt32(0);
            }
            return highScore;
        }

        public String GetTranslation(String word)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            String language = GetLanguageFromEnum();
            sqlite_cmd.CommandText = $"SELECT {language} FROM Translation WHERE '{word}' = German;";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            String translation = "";
            while (sqlite_datareader.Read())
            {
                translation = sqlite_datareader.GetString(0);
            }
            return translation;
        }

        private String GetLanguageFromEnum()
        {
            String language = "German";
            switch (actualLanguage)
            {
                case Languages.English:
                    language = "English";
                    break;
                case Languages.Spanish:
                    language = "Spanish";
                    break;
                case Languages.German:
                    language = "German";
                    break;
            }
            return language;
        }

        public void SetHighScore(int newHighscore)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = $"UPDATE UserData SET Highscore = {newHighscore} WHERE '{actualUser}' = Username;";

            sqlite_datareader = sqlite_cmd.ExecuteReader();

        }
    }
}
