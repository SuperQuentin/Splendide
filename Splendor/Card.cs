using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splendor
{
    /// <summary>
    /// class Card : attributes and methods to deal with a card
    /// </summary>
    class Card
    {
        private Ressources ress;
        private int prestigePt;
        private int level;
        //tableau : l'index correspond à l'énumération, la valeur à la ressource requise
        private int[] cout = new int[4];
        private SQLiteConnection m_dbConnection;



        public Card(){
            m_dbConnection = new SQLiteConnection("Data Source=Splendor.sqlite;Version=3;");
            m_dbConnection.Open();
        }

        public void AddCard(int level, int ressource, int prestige, int[] cost, int player = 0)
        {
            var sql = "INSERT INTO card(fkRessource,level,nbPtPrestige) values(" + ressource + ", " + level + "," + prestige + ")";
            var command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "select last_insert_rowid()";
            command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader read = command.ExecuteReader();
            var id = read.Read();
           

            for (int i = 0; i < cost.Length; i++)
            {
                sql = "INSERT INTO cost(fkCard,fkRessource,nbRessource) values(" + id + "," + i + "," + cost[i] + ")";
                command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
            }

        }

        /// <summary>
        /// the precious stone that the card gives
        /// </summary>
        public Ressources Ress
        {
            get
            {
                return ress;
            }
            set
            {
                ress = value;
            }

        }

        /// <summary>
        /// number of prestige point of the card
        /// </summary>
        public int PrestigePt
        {
            get
            {
                return prestigePt;
            }
            set
            {
                prestigePt = value;
            }

        }

        /// <summary>
        /// level of the card : 1, 2 or 3
        /// </summary>
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
            }
        }

        /// <summary>
        /// all the precious stones that are needed to buy the card
        /// </summary>
        public int[] Cout
        {
            get
            {
                return cout;
            }
            set
            {
                cout = value;
            }
        }

        /// <summary>
        /// displays information about the card
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string res = "";
            
            res = Enum.GetName(typeof(Ressources), Ress);
            //Be careful, those \t enables to split the string when clicking on a card
            res += "\t";

            if (prestigePt != 0)
            {
                res += prestigePt;
            }
            res += "\t";
            res += "\r\n\r\n";
            int boucle = 0;
            
            foreach (int i in cout)
            {
                
                string ressource = "";

                if (i != 0)
                {
                    ressource = "    ";
                    ressource += Enum.GetName(typeof(Ressources), boucle) + " ";
                    ressource += i + "\r\n";
                }
                
                res += ressource;
                boucle++;

            }
            return res;
        }

        public void import()
        {
            var db = new ConnectionDB();

            var cards = new List<Stack<Card>>();

            for(int x = 0; x<4; x++)
            {
                cards[x] = db.GetListCardAccordingToLevel(x+1);
            }



        }




    }
}
