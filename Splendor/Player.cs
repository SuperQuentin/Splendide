using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splendor
{

    /// <summary>
    /// Class Player : attributes and methods to deal with a player
    /// </summary>
    class Player
    {
        public string name { get; set; }
        public int id { get; set; }
        public int[] ressources { get; set; }
        public int[] coins { get; set; }


		/// <summary>
		/// Construtor : initialize player with his different stats
		/// </summary>
		/// <param name="id"></param>
		/// <param name="name"></param>
		/// <param name="ressources"></param>
		public Player(string name, int[] ressources = null, int id = -1, int[] coins = null)
		{
			this.id = id;
			this.name = name;


			if (ressources == null)
			{
				ressources = new int[] { 0, 0, 0, 0, 0 };
			}
			if (coins == null)
			{
				coins = new int[] { 0,0,0,0,0};
			}

			this.ressources = ressources;
			this.coins = coins;
		}

		public override string ToString()
		{
			return this.id + " - " + this.name;
		}
	}
}
