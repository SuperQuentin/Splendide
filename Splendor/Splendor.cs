/**
 * \file      frmAddVideoGames.cs
 * \author    F. Andolfatto
 * \version   1.0
 * \date      August 22. 2018
 * \brief     Form to play.
 *
 * \details   This form enables to choose coins or cards to get ressources (precious stones) and prestige points 
 * to add and to play with other players
 */


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
    /// manages the form that enables to play with the Splendor
    /// </summary>
    public partial class frmSplendor : Form
    {

        private Random rand = new Random();

        //Used to store textbox objects
        private List<List<TextBox>> gridCard;

		private string cardSelect;

        private List<List<Card>> gridCardStock;

        //Used to store ressources labels for the player
        private List<Label> allRessourcesLblChoice;

        //Used to store ressources labels for the game;
        private List<Label> allRessourcesLbl;

        //Used to store ressources labels for the player coins
        private List<Label> allRessourcesLblPlayer;

        //Used to store players objects
        private List<Player> players;


        private List<int> nbCoinsSelected;

        //Id of the player that is playing
        private int currentPlayerId = 0;

        //used to store the total number of coins
        private int totalCoins;

        //used to store the number of coins available in the game
        private List<int> availableCoins;

		PlayersForm playersForm;

        //connection to the database
        private ConnectionDB conn;

        /// <summary>
        /// constructor
        /// </summary>
        public frmSplendor()
        {
            InitializeComponent();

			//Initialize a connection with the sqlite database
			conn = new ConnectionDB(true);

			gridCard = new List<List<TextBox>>();
			players = new List<Player>();
			availableCoins = new List<int>() { 7, 7, 7, 7, 7 };
			nbCoinsSelected = new List<int>() { 0, 0, 0, 0, 0 };
		}

        /// <summary>
        /// loads the form and initialize data in it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSplendor_Load(object sender, EventArgs e)
        {
			//Stock Ressources label objects
            allRessourcesLbl = new List<Label>() { lblRubisCoin, lblEmeraudeCoin, lblOnyxCoin, lblSaphirCoin, lblDiamandCoin };
			allRessourcesLblPlayer = new List<Label>() { lblPlayerRubisCoin, lblPlayerEmeraudeCoin, lblPlayerOnyxCoin, lblPlayerSaphirCoin, lblPlayerDiamandCoin };

			foreach (Label lblCoin in allRessourcesLbl)
			{
				lblCoin.Enabled = false;
			}

			//Puts coins values in labels
			for (int x = 0; x < allRessourcesLbl.Count; x++)
            {
                allRessourcesLbl[x].Text = availableCoins[x].ToString();
            }

            gridCard.Add(new List<TextBox>() { txtLevel11, txtLevel12, txtLevel13, txtLevel14 });
            gridCard.Add(new List<TextBox>() { txtLevel21, txtLevel22, txtLevel23, txtLevel24 });
            gridCard.Add(new List<TextBox>() { txtLevel31, txtLevel32, txtLevel33, txtLevel34 });
            gridCard.Add(new List<TextBox>() { txtNoble1, txtNoble2, txtNoble3, txtNoble4 });


            foreach (List<TextBox> txtBoxes in gridCard)
            {
                foreach (TextBox txtBox in txtBoxes)
                {
                    txtBox.ReadOnly = true;
					txtBox.Click += ClickOnCard; //we wire the click on all cards to the same event
				}
            }

            

            //load cards from the database
            List<Card> listCardOne = conn.GetListCardAccordingToLevel(1);
            List<Card> listCardTwo = conn.GetListCardAccordingToLevel(2);
            List<Card> listCardThree = conn.GetListCardAccordingToLevel(3);
            List<Card> listNoble = conn.GetListCardAccordingToLevel(4);

            gridCardStock = new List<List<Card>>() { listCardOne, listCardTwo, listCardThree, listNoble };

            for (int x = 0; x < gridCard.Count; x++)
            {
                for (int y = 0; y < gridCard[x].Count; y++)
                {
                    var randomValue = rand.Next((gridCardStock[x].Count()));
                    gridCard[x][y].Text = gridCardStock[x].ElementAt(randomValue).ToString();
                    gridCardStock[x].RemoveAt(randomValue);
                }
            }

            this.Width = 680;
            this.Height = 540;


            //Initialize a list with ressources labels
            allRessourcesLblChoice = new List<Label>() { lblChoiceRubis, lblChoiceEmeraude, lblChoiceOnyx, lblChoiceSaphir, lblChoiceDiamand };

            //Make label be not visible
            foreach (Label lbl in allRessourcesLbl)
            {
                lbl.Visible = true;
            }

            cmdValidateChoice.Visible = false;
            cmdNextPlayer.Visible = false;

        }

        private void ClickOnCard(object sender, EventArgs e)
        {
			if (nbCoinsSelected.Sum() == 0)
			{
				TextBox txtBox = sender as TextBox;

				var cardInfo = txtBox.Text.Split('\t');

				List<int> cost = new List<int>() { 2,0,0,0,0 };

				for (int x = 0; x < cost.Count;x++)
				{
					var res = players[currentPlayerId].ressources[x];
					var coin = players[currentPlayerId].coins[x];

					if (res >= cost[x] || res == cost[x] || coin >= cost[x] || coin == cost[x] || coin + res >= cost[x] || coin + res == cost[x])
					{
						cardSelect = txtBox.Text;
						lblChoiceCard.Text = "Carte choisi";
					}
					
					/**
					if (res >= cost[x] || res == cost[x])
					{

					}
					else if (coin >= cost[x] || coin == cost[x])
					{

					}
					else if (coin + res >= cost[x] || coin + res == cost[x])
					{

					}
					**/
				}

				cmdValidateChoice.Visible = true;


			}
			else
			{ 
				MessageBox.Show("Vous ne pouvez pas");
			}

            
        }

        /// <summary>
        /// click on the play button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdPlay_Click(object sender, EventArgs e)
        {
            this.Width = 680;
            this.Height = 780;

			cmdInsertPlayer.Enabled = false;
			cmdPlay.Enabled = false;

			LoadPlayer();

			foreach(Label lblCoin in allRessourcesLbl)
			{
				lblCoin.Text = "7";
				lblCoin.Enabled = true;
			}

			foreach (Label lblCoinChoice in allRessourcesLblChoice)
			{
				lblCoinChoice.Text = "0";
			}

			foreach(Label lblCoinPlayer in allRessourcesLblPlayer)
			{
				lblCoinPlayer.Text = "0";
			}


			PlayerTurn(players[currentPlayerId]);

			Program.ConsoleColor("The game starting", ConsoleColor.Green);

		}

		private void PlayerTurn(Player player)
		{
			lblPlayer.Text = "Jeu du joueur : " + player.name;

			for (int x = 0; x<allRessourcesLblPlayer.Count;x++)
			{
				allRessourcesLblPlayer[x].Text = player.coins[x].ToString();
			}
		}

		private void LoadPlayer()
		{
			cmdNextPlayer.Enabled = false;
			foreach (Player player in conn.GetPlayers())
			{
				this.players.Add(player);
			}			
		}


		/// <summary>
		/// Check if the coins can take
		/// </summary>
		/// <param name="selectCoins"></param>
		/// <param name="availableRessources"></param>
		/// <param name="witchRessource"></param>
		private void coinsCheck(List<int> selectCoins, List<int> availableRessources, Ressources witchRessource)
        {
			int res = (int)witchRessource;

			cmdValidateChoice.Visible = true;
			allRessourcesLblChoice[res].Visible = true;

			totalCoins = selectCoins.Sum() - selectCoins[res];

			if (availableRessources[res] == 2)
			{
				MessageBox.Show("Ce type de jeton ne peut plus être retiré!");
			}
			else if (selectCoins.Any(x => x == 2))
			{
				MessageBox.Show("Vous possédez déjà 2 jetons!");
			}
			else if (selectCoins[res] == 1 && totalCoins >= 1)
			{
				MessageBox.Show("Vous ne pouvez avoir qu'un jeton de chaque couleur!");
			}
			else if (selectCoins[res] + totalCoins != 3)
			{
				selectCoins[res]++;
				availableRessources[res]--;
				allRessourcesLbl[res].Text = availableRessources[res].ToString();
				allRessourcesLblChoice[res].Text = selectCoins[res] + "\r\n";
				Program.ConsoleColor("Take " + witchRessource.ToString(), ConsoleColor.Green);
			}
			else
			{
				MessageBox.Show("Vous avez atteint le nombre de jetons maximum!");
			}
		}

        /// <summary>
        /// click on the red coin (rubis) to tell the player has selected this coin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblRubisCoin_Click(object sender, EventArgs e)
        {
			coinsCheck(this.nbCoinsSelected, this.availableCoins, Ressources.Rubis);
        }

        /// <summary>
        /// click on the blue coin (saphir) to tell the player has selected this coin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblSaphirCoin_Click(object sender, EventArgs e)
        {
			coinsCheck(this.nbCoinsSelected, this.availableCoins, Ressources.Saphir);
			
				
        }

        /// <summary>
        /// click on the black coin (onyx) to tell the player has selected this coin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblOnyxCoin_Click(object sender, EventArgs e)
        {
			coinsCheck(this.nbCoinsSelected, this.availableCoins, Ressources.Onyx);	
        }

        /// <summary>
        /// click on the green coin (emeraude) to tell the player has selected this coin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblEmeraudeCoin_Click(object sender, EventArgs e)
        {
			coinsCheck(this.nbCoinsSelected, this.availableCoins, Ressources.Emeraude);				
        }

        /// <summary>
        /// click on the white coin (diamand) to tell the player has selected this coin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblDiamandCoin_Click(object sender, EventArgs e)
        {
			coinsCheck(this.nbCoinsSelected, this.availableCoins, Ressources.Diamand);				
        }

        /// <summary>
        /// click on the validate button to approve the selection of coins or card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdValidateChoice_Click(object sender, EventArgs e)
        {
            totalCoins = nbCoinsSelected.Sum();

            if (totalCoins > 1)
            {
				for (int x = 0; x < players[currentPlayerId].coins.Count();x++)
				{
					players[currentPlayerId].coins[x] = nbCoinsSelected[x];
				}

				//coins reset
				foreach (Label lblCoins in allRessourcesLblChoice)
				{
					lblCoins.Text = "0";
				}

                for (int x = 0; x < nbCoinsSelected.Count; x++)
                {
                    nbCoinsSelected[x] = 0;
                }

                cmdNextPlayer.Visible = true;
                cmdNextPlayer.Enabled = true;
            }
			else
			{
				lblChoiceCard.Text = "Carte en stock";

				//TODO
				

			}
        }

        /// <summary>
        /// click on the insert button to insert player in the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdInsertPlayer_Click(object sender, EventArgs e)
        {
			playersForm = new PlayersForm();
			playersForm.Show();
		}

        /// <summary>
        /// click on the next player to tell him it is his turn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdNextPlayer_Click(object sender, EventArgs e)
        {
			//TO DO in release 1.0 : 3 is hard coded (number of players for the game), it shouldn't. 
			//TO DO Get the id of the player : in release 0.1 there are only 3 players
			//Reload the data of the player
			//We are not allowed to click on the next button

			if (currentPlayerId < players.Count() - 1)
			{
				currentPlayerId++;
			}
			else
			{
				currentPlayerId = 0;
			}

			PlayerTurn(players[currentPlayerId]);

        }

        private void coinsTaker(List<int> selectCoins, List<int> availableRessources, Ressources witchRessource)
        {
            selectCoins[(int)witchRessource]--;
            availableRessources[(int)witchRessource]++;
            allRessourcesLbl[(int)witchRessource].Text = availableRessources[(int)witchRessource].ToString();
            allRessourcesLblChoice[(int)witchRessource].Text = selectCoins[(int)witchRessource] + "\r\n";
			Program.ConsoleColor("put back the " + witchRessource.ToString(),ConsoleColor.Green);
        }

        /// <summary>
        /// click on the player rubis coin to remove a coin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblChoiceRubis_Click(object sender, EventArgs e)
        {
			if (int.Parse(lblChoiceRubis.Text) > 0)
			{
				coinsTaker(this.nbCoinsSelected, this.availableCoins, Ressources.Rubis);
			}
        }

        /// <summary>
        /// click on the player saphir coin to remove a coin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblChoiceSaphir_Click(object sender, EventArgs e)
        {
			if (int.Parse(lblChoiceSaphir.Text) > 0)
			{
				coinsTaker(this.nbCoinsSelected, this.availableCoins, Ressources.Saphir);
			}
			
        }

        /// <summary>
        /// click on the player onyx coin to remove a coin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblChoiceOnyx_Click(object sender, EventArgs e)
        {
			if (int.Parse(lblChoiceOnyx.Text) > 0)
			{
				coinsTaker(this.nbCoinsSelected, this.availableCoins, Ressources.Onyx);
			}
        }

        /// <summary>
        /// click on the player emeraude coin to remove a coin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblChoiceEmeraude_Click(object sender, EventArgs e)
        {
			if (int.Parse(lblChoiceEmeraude.Text) > 0)
			{
				coinsTaker(this.nbCoinsSelected, this.availableCoins, Ressources.Emeraude);
			}
        }

        /// <summary>
        /// click on the player diamand coin to remove a coin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblChoiceDiamand_Click(object sender, EventArgs e)
        {
			if (int.Parse(lblChoiceDiamand.Text) > 0)
			{
				coinsTaker(this.nbCoinsSelected, this.availableCoins, Ressources.Diamand);
			}
			
        }
    }
}
