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
	public partial class PlayersForm : Form
	{
		private ConnectionDB database;

		public PlayersForm()
		{
			InitializeComponent();
			database = new ConnectionDB();
		}

		private void cmdAddPlayer_Click(object sender, EventArgs e)
		{
			try
			{
				if (lstPlayers.Items.Count < 4)
				{
					lstPlayers.Items.Add(new Player(lstPlayers.Items.Count, txtBox.Text, new int[5]));
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

		private void PlayersForm_Shown(object sender, EventArgs e)
		{
			Program.ConsoleColor("PlayersForm is open", ConsoleColor.Green);
		}

		private void PlayersForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Program.ConsoleColor("PlayersForm is close", ConsoleColor.Green);
		}

		private void PlayersForm_Load(object sender, EventArgs e)
		{
			List<Player> players = database.GetPlayers();

			foreach(Player player in players)
			{
				lstPlayers.Items.Add(player);
			}
		}

		private void cmdRemovePlayer_Click(object sender, EventArgs e)
		{
			lstPlayers.Items.RemoveAt(lstPlayers.SelectedIndex);
		}
	}
}
