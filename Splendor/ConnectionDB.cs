using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Splendor
{
    /// <summary>
    /// Contains methods and attributes to connect and deal with the database
    /// TO DO : le modèle de données n'est pas super, à revoir!!!!
    /// </summary>
    class ConnectionDB
    {
        //Connection to the database
        private SQLiteConnection m_dbConnection;
        private List<Card> allCards = new List<Card>();

        /// <summary>
        /// Constructor : creates the connection to the database SQLite
        /// </summary>
        public ConnectionDB(bool showDBReNew = false)
        {
			create:
			try
			{
				if (!File.Exists("Splendor.sqlite"))
				{
					SQLiteConnection.CreateFile("Splendor.sqlite");
					this.Initiate();
				}
				else if(showDBReNew)
				{
					DialogResult dialogResult = MessageBox.Show("Voulez-vous régénérer la base de donnée ?", "Reload", MessageBoxButtons.YesNo);

					if (dialogResult == DialogResult.Yes) {
						File.Delete("Splendor.sqlite");
						SQLiteConnection.CreateFile("Splendor.sqlite");
						this.Initiate();
					}
					else
					{
						m_dbConnection = new SQLiteConnection("Data Source=Splendor.sqlite;Version=3;");
						m_dbConnection.Open();
						Program.ConsoleColor("New Connection established", ConsoleColor.Green);
					}
				}
				else
				{
					m_dbConnection = new SQLiteConnection("Data Source=Splendor.sqlite;Version=3;");
					m_dbConnection.Open();
					Program.ConsoleColor("New Connection established", ConsoleColor.Green);
				}
			}
			catch(Exception e)
			{
				Program.ConsoleColor(e.Message);
				MessageBox.Show("Veuillez fermer le fichier");
				goto create;
			}

			
		}

		/// <summary>
		/// Connect to database and create principal table
		/// </summary>
		private void Initiate()
		{
			m_dbConnection = new SQLiteConnection("Data Source=Splendor.sqlite;Version=3;");
			m_dbConnection.Open();
			Program.ConsoleColor("New Connection established", ConsoleColor.Green);

			//Create and insert players
			CreatePlayerTable();

			//Create and insert cards
			CreateInsertCardsTable();

			//Create and insert ressources
			CreateInsertRessourcesTable();

			//Import card from a csv to send it to the database
			ImportCardCsv();

			Program.ConsoleColor("Database initialize", ConsoleColor.Green);
		}

		/// <summary>
		/// Execute the sql command
		/// </summary>
		/// <param name="sqlRequest"></param>
		/// <param name="dbConnection"></param>
		/// <returns></returns>
		private SQLiteDataReader ExecNonQuery(string sqlRequest, SQLiteConnection dbConnection)
		{
			SQLiteCommand command = new SQLiteCommand(sqlRequest, dbConnection);
			return command.ExecuteReader();
		}

		/// <summary>
		/// Delete and Update with the new value the table players
		/// </summary>
		/// <param name="players"></param>
		public void UpdatePlayers(List<Player> players)
		{
			ExecNonQuery("DELETE FROM 'player'", m_dbConnection);
			ExecNonQuery("UPDATE SQLITE_SEQUENCE SET SEQ=0 WHERE NAME='player'",m_dbConnection);
			foreach (Player player in players)
			{
				this.ExecNonQuery("INSERT INTO player (pseudo) values('" + player.name + "')", m_dbConnection);
			}
			
		}

        /// <summary>
        /// Get the list of cards according to the level
        /// </summary>
        /// <returns>cards stack</returns>
        public List<Card> GetListCardAccordingToLevel(int level)
        {
			SQLiteDataReader reader = ExecNonQuery("SELECT id,fkRessource,nbPtPrestige,level FROM card where level = " + level, m_dbConnection);

			List<Card> listCard = new List<Card>();

            while (reader.Read())
            {
				SQLiteDataReader costReader = ExecNonQuery("select cost.nbRessource FROM cost where cost.fkCard = " + reader["id"].ToString(), m_dbConnection);

                var cost = new List<int>();

                while (costReader.Read())
                {
                    cost.Add(int.Parse(costReader[0].ToString()));
                }

                listCard.Add(new Card(int.Parse(reader["level"].ToString()), int.Parse(reader["nbPtPrestige"].ToString()), cost.ToArray(), int.Parse(reader["fkRessource"].ToString())));
            }

            return listCard;
        }




        /// <summary>
        /// Create the "player" table and insert data
        /// </summary>
        private void CreatePlayerTable()
        {
			Program.ConsoleColor("Baking player table", ConsoleColor.Yellow);

			string sql = "CREATE TABLE player (id INTEGER PRIMARY KEY AUTOINCREMENT, pseudo VARCHAR(20))";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

			Program.ConsoleColor("Player table is coocked", ConsoleColor.Green);

        }


        /// <summary>
        /// Get the name of the player according to his id
        /// </summary>
        /// <param name="id">id of the player</param>
        /// <returns></returns>
        public List<Player> GetPlayers()
        {
			SQLiteDataReader reader = ExecNonQuery("select id,pseudo from player", this.m_dbConnection);

			List<Player> players = new List<Player>();

			while (reader.Read())
			{
				players.Add(new Player(reader["pseudo"].ToString(),new int[5], int.Parse(reader["id"].ToString())));
			}

			return players;
        }

        /// <summary>
        /// Create the table "ressources" and insert data
        /// </summary>
        private void CreateInsertRessourcesTable()
        {
			Program.ConsoleColor("Baking ressource table", ConsoleColor.Yellow);

			string sql = "CREATE TABLE ressource (id INTEGER PRIMARY KEY, name VARCHAR(20))";
            var command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

			Program.ConsoleColor("Player table is coocked", ConsoleColor.Green);

			Program.ConsoleColor("Inserting ressource values", ConsoleColor.Yellow);

			sql = "INSERT INTO ressource (id,name) values(" + (int)Ressources.Rubis + ",\"rubis\")";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "INSERT INTO ressource (id,name) values(" + (int)Ressources.Emeraude + ",\"emeraude\")";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "INSERT INTO ressource (id,name) values(" + (int)Ressources.Onyx + ",\"onyx\")";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "INSERT INTO ressource (id,name) values(" + (int)Ressources.Saphir + ",\"saphir\")";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "INSERT INTO ressource (id,name) values(" + (int)Ressources.Diamand + ",\"diamand\")";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

			Program.ConsoleColor("Values has been insert", ConsoleColor.Green);

		}


        /// <summary>
        /// Create tables "cards", "cost" and insert data
        /// </summary>
        private void CreateInsertCardsTable()
        {
			Program.ConsoleColor("Baking card table", ConsoleColor.Yellow);

			string sql = "CREATE TABLE card (id INTEGER PRIMARY KEY, fkRessource INT, level INT, nbPtPrestige INT, fkPlayer INT)";
            var command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

			Program.ConsoleColor("Player card is coocked", ConsoleColor.Green);

			Program.ConsoleColor("Baking cost table", ConsoleColor.Yellow);

			sql = "CREATE TABLE cost (id INTEGER PRIMARY KEY, fkCard INT, fkRessource INT, nbRessource INT)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

			Program.ConsoleColor("Player cost is coocked", ConsoleColor.Green);

		}



        /// <summary>
        /// Add card in the database
        /// </summary>
        /// <param name="level"></param>
        /// <param name="ressource"></param>
        /// <param name="prestige"></param>
        /// <param name="cost"></param>
        /// <param name="player"></param>
        public void AddCard(int level, int ressource, int prestige, int[] cost, int player = 0)
        {
			//Insert the card in the table card on the database
            var sql = "INSERT INTO card(fkRessource,level,nbPtPrestige) values(" + ressource + ", " + level + "," + prestige + ")";
            var command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

			//Select the card we have inserted
			SQLiteDataReader reader = ExecNonQuery("select last_insert_rowid() as last",m_dbConnection);


			while (reader.Read())
            {
                for (int i = 0; i < cost.Length; i++)
                {
					//Insert in the table on many ressources the card cost
                    sql = "INSERT INTO cost(fkCard,fkRessource,nbRessource) values(" + reader["last"] + "," + (i) + "," + cost[i] + ")";
                    command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();
                }
            }

        }

        /// <summary>
        /// Import card from csv to put in the database
        /// </summary>
        public void ImportCardCsv(string csvPath = "./cards.csv")
        {
			string[] reader = null;

			try
			{
				Program.ConsoleColor("Reading csv fill", ConsoleColor.Yellow);
				reader = File.ReadAllLines(csvPath); //Try to open the file
			}
			catch(Exception e)
			{
				Program.ConsoleColor(e.Message); //Show a logs message with the error

				OpenFileDialog openFileDialog = new OpenFileDialog(); //Ask a file to read

				while (!File.Exists(csvPath)) //Check if the selected file exists 
				{
					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						csvPath = openFileDialog.FileName; //Recover the file path
						Program.ConsoleColor("Fichier csv chargé",ConsoleColor.Green);
					}					
				}
				reader = File.ReadAllLines(csvPath); //Finaly read all line in the file
			}
			finally
			{
				foreach (var line in reader.Skip(1)) //Going to read all line and skip the first one
				{
					string[] values = line.Split(';');
					var newValues = new int[8];

					for (int x = 0; x < values.Length; x++)
					{
						newValues[x] = int.Parse(values[x].ToString() == "" ? "0" : values[x].ToString());
					}

					//Add the card to the sqlite database
					this.AddCard(newValues[0], newValues[1], newValues[2], new int[] { newValues[3], newValues[4], newValues[5], newValues[6], newValues[7] });
					Program.ConsoleColor("New card was add to the database", ConsoleColor.Green);
				}
			}
        }
    }
}
