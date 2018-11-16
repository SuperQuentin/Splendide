using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splendor
{
    /// <summary>
    /// CRUD form for the players
    /// </summary>
	public partial class PlayersForm : Form
	{
		private ConnectionDB database;

        /// <summary>
        /// Player forms
        /// </summary>
		public PlayersForm()
		{
			InitializeComponent();
			database = new ConnectionDB();
		}

        /// <summary>
        /// Add new player function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void cmdAddPlayer_Click(object sender, EventArgs e)
		{
			try
			{
				if (lstPlayers.Items.Count < 4)
				{
					lstPlayers.Items.Add(new Player(txtBox.Text, new int[5]));
					txtBox.Clear();
					cmdAddPlayer.Enabled = false;
					Program.ConsoleColor("Player added at the list", ConsoleColor.Green);
				}
				else
				{
					throw new Exception("The list is full");
				}
			}
			catch (Exception er)
			{
				MessageBox.Show(er.Message);
			}
		}

        /// <summary>
        /// Enable the add player button if the text isn't empty   
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void txtBox_TextChanged(object sender, EventArgs e)
		{
			if (txtBox.Text != null)
			{
				cmdAddPlayer.Enabled = true;
			}
			else
			{
				cmdAddPlayer.Enabled = false;
			}
		}

        /// <summary>
        /// Enable the remove button if a player is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void lstPlayers_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstPlayers.SelectedIndex != -1)
			{
				cmdRemovePlayer.Enabled = true;
			}
			else
			{
				cmdRemovePlayer.Enabled = false;
			}
		}

        /// <summary>
        /// Update the database with the new players
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void cmdEndPlayer_Click(object sender, EventArgs e)
		{
			List<Player> players = new List<Player>();

			foreach(Player player in lstPlayers.Items)
			{
				players.Add(player);
			}

			database.UpdatePlayers(players);
			this.Close();
		}

        /// <summary>
        /// Shows a message when the player form is opened
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void PlayersForm_Shown(object sender, EventArgs e)
		{
			Program.ConsoleColor("PlayersForm is open", ConsoleColor.Green);
		}

        /// <summary>
        /// Shows a message when the player form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void PlayersForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Program.ConsoleColor("PlayersForm is close", ConsoleColor.Green);
		}

        /// <summary>
        /// Loads the players from the database and add them to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void PlayersForm_Load(object sender, EventArgs e)
		{
			List<Player> players = database.GetPlayers();

			foreach(Player player in players)
			{
				lstPlayers.Items.Add(player);
			}
		}

        /// <summary>
        /// Removes the players from the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void cmdRemovePlayer_Click(object sender, EventArgs e)
		{
			lstPlayers.Items.RemoveAt(lstPlayers.SelectedIndex);
		}
	}
}
