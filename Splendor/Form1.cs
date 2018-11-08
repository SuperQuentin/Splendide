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
        private List<List<TextBox>> gridCard = new List<List<TextBox>>();

        private List<List<Card>> gridCardStock;

        //Used to store ressources labels for the player
        private List<Label> allRessourcesLblChoice;

        //Used to store ressources labels for the game;
        private List<Label> allRessourcesLbl;

        //Used to store ressources labels for the player coins
        private List<Label> allRessourcesLblPlayer;

        //Used to store players objects
        private List<Player> players = new List<Player>();

        private List<int> nbCoinsSelected;

        //Id of the player that is playing
        private int currentPlayerId = 0;

        //Used to store the total number of coins
        private int totalCoins;

        //Used to store the number of coins available in the game
        private List<int> availableCoins = new List<int>() { 7, 7, 7, 7, 7 };

        //Used to store the number of the players
        public string nbJoueurs = "";

        //Used to store the names of the players
        public List<string> nomJoueurs;

        //Used to store an error if the name is empty
        private string verifNom = "";

        //Boolean to enable us to know if the user can click on a coin or a card
        private bool enableClicLabel;
        //Connection to the database
        private ConnectionDB conn;

        /// <summary>
        /// constructor
        /// </summary>
        public frmSplendor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// loads the form and initialize data in it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSplendor_Load(object sender, EventArgs e)
        {
            //Appel de la fonction de seléction du nombre de joueurs
            NbJoueurs("Nombre de joueurs", "Veuillez insérer le nombre de joueurs");

            //Vérifie si le nombre de joueurs est correct
            while(nbJoueurs == "" || int.Parse(nbJoueurs) > 4)
            {
                NbJoueurs("Nombre de joueurs", "Veuillez insérer un nombre valide");
            }

            NomJoueurs("Nom des joueurs");

            for (int i = 0; i < int.Parse(nbJoueurs); i++)
            {
                if(nomJoueurs[i] == "")
                {
                    verifNom = "vide";
                }
            }

            do
            {
                verifNom = "";
                NomJoueurs("Nom des joueurs");

                for (int i = 0; i < int.Parse(nbJoueurs); i++)
                {
                    if (nomJoueurs[i] == "")
                    {
                        verifNom = "vide";
                    }
                }
            } while (verifNom == "vide");



                allRessourcesLbl = new List<Label>() { lblRubisCoin, lblEmeraudeCoin, lblOnyxCoin, lblSaphirCoin, lblDiamandCoin };

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
                }
            }

            //Initialize a connection with the sqlite database
            conn = new ConnectionDB();

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
                    var randomValue = rand.Next((gridCardStock[x].Count()) - 1);
                    gridCard[x][y].Text = gridCardStock[x].ElementAt(randomValue).ToString();
                    gridCardStock[x].RemoveAt(randomValue);
                }
            }

            this.Width = 680;
            this.Height = 540;

            enableClicLabel = false;


            //Initialize a list with ressources labels
            allRessourcesLblChoice = new List<Label>() { lblChoiceRubis, lblChoiceEmeraude, lblChoiceOnyx, lblChoiceSaphir, lblChoiceDiamand };

            //Make label be not visible
            foreach (Label lbl in allRessourcesLbl)
            {
                lbl.Visible = true;
            }

            cmdValidateChoice.Visible = false;
            cmdNextPlayer.Visible = false;

            //we wire the click on all cards to the same event
            foreach (List<TextBox> txtBoxes in gridCard)
            {
                foreach (TextBox txtBox in txtBoxes)
                {
                    txtBox.Click += ClickOnCard;
                }
            }
        }

        public DialogResult NbJoueurs(string title, string promptText)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();

            form.Text = title;
            label.Text = promptText;

            buttonOk.Text = "OK";
            buttonOk.DialogResult = DialogResult.OK;

            label.SetBounds(35, 20, 180, 13);
            textBox.SetBounds(226, 17, 30, 20);
            buttonOk.SetBounds(116, 65, 75, 23);

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;

            DialogResult dialogResult = form.ShowDialog();
            nbJoueurs = textBox.Text;
            return dialogResult;
        }

        public DialogResult NomJoueurs(string title)
        {
            Form form = new Form();

            Label label1 = new Label();
            Label label2 = new Label();
            Label label3 = new Label();
            Label label4 = new Label();

            TextBox textBox1 = new TextBox();
            TextBox textBox2 = new TextBox();
            TextBox textBox3 = new TextBox();
            TextBox textBox4 = new TextBox();

            Button buttonOk = new Button();

            form.Text = title;

            label1.Text = "Joueur 1 ";
            label2.Text = "Joueur 2 ";
            label3.Text = "Joueur 3 ";
            label4.Text = "Joueur 4 ";

            buttonOk.Text = "OK";
            buttonOk.DialogResult = DialogResult.OK;

            label1.SetBounds(35, 10, 50, 13);
            label2.SetBounds(35, 30, 50, 13);
            label3.SetBounds(35, 50, 50, 13);
            label4.SetBounds(35, 70, 50, 13);

            textBox1.SetBounds(100, 7, 100, 20);
            textBox2.SetBounds(100, 27, 100, 20);
            textBox3.SetBounds(100, 47, 100, 20);
            textBox4.SetBounds(100, 67, 100, 20);

            buttonOk.SetBounds(250, 65, 75, 23);

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label1, label2, label3, label4, textBox1, textBox2, textBox3, textBox4, buttonOk });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;

            DialogResult dialogResult = form.ShowDialog();
            nomJoueurs.Add(textBox1.Text);
            nomJoueurs.Add(textBox2.Text);
            nomJoueurs.Add(textBox3.Text);
            nomJoueurs.Add(textBox4.Text);

            return dialogResult;
        }

        private void ClickOnCard(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;

            var cardInfo = txtBox.Text.Split();


            //We get the value on the card and we split it to get all the values we need (number of prestige points and ressource)
            //Enable the button "Validate"
            //TO DO
            cmdValidateChoice.Visible = true;
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

            int id = 0;

            LoadPlayer(id);
        }


        /// <summary>
        /// load data about the current player
        /// </summary>
        /// <param name="id">identifier of the player</param>
        private void LoadPlayer(int id)
        {

            this.currentPlayerId = id;

            enableClicLabel = true;

            //no coins or card selected yet, labels are empty

            foreach (Label lblChoice in allRessourcesLblChoice)
            {
                lblChoice.Text = "";
            }

            lblChoiceCard.Text = "";

            //no coins selected
            nbCoinsSelected = new List<int>() { 0, 0, 0, 0, 0 };

            //Add different player in a list
            players.Add(new Player(0, conn.GetPlayerName(0)));
            players.Add(new Player(1, conn.GetPlayerName(1)));
            players.Add(new Player(2, conn.GetPlayerName(2)));

            allRessourcesLblPlayer = new List<Label>() { lblPlayerRubisCoin, lblPlayerEmeraudeCoin, lblPlayerOnyxCoin, lblPlayerSaphirCoin, lblPlayerDiamandCoin };

            for (int x = 0; x < allRessourcesLblPlayer.Count; x++)
            {
                allRessourcesLblPlayer[x].Text = players[currentPlayerId].ressources[x].ToString();
            }

            lblPlayer.Text = "Jeu de " + players[currentPlayerId].name;

            cmdPlay.Enabled = false;
        }

        /// <summary>
        /// Check if the coins can take
        /// </summary>
        /// <param name="selectCoins"></param>
        /// <param name="availableRessources"></param>
        /// <param name="witchRessource"></param>
        private void coinsCheck(List<int> selectCoins, List<int> availableRessources, Ressources witchRessource)
        {
            if (enableClicLabel)
            {
                cmdValidateChoice.Visible = true;
                allRessourcesLblChoice[(int)witchRessource].Visible = true;

                totalCoins = selectCoins.Sum() - selectCoins[(int)witchRessource];

                if (availableRessources[(int)witchRessource] == 2)
                {
                    MessageBox.Show("Ce type de jeton ne peut plus être retiré!");
                }
                else if (selectCoins.Any(x => x == 2))
                {
                    MessageBox.Show("Vous possédez déjà 2 jetons!");
                }
                else if (selectCoins[(int)witchRessource] == 1 && totalCoins >= 1)
                {
                    MessageBox.Show("Vous ne pouvez avoir qu'un jeton de chaque couleur!");
                }
                else if (selectCoins[(int)witchRessource] + totalCoins != 3)
                {
                    selectCoins[(int)witchRessource]++;
                    availableRessources[(int)witchRessource]--;
                    allRessourcesLbl[(int)witchRessource].Text = availableRessources[(int)witchRessource].ToString();
                    allRessourcesLblChoice[(int)witchRessource].Text = selectCoins[(int)witchRessource] + "\r\n";
                }
                else
                {
                    MessageBox.Show("Vous avez atteint le nombre de jetons maximum!");
                }
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

                //coins reset
                for (int x = 0; x < nbCoinsSelected.Count; x++)
                {
                    nbCoinsSelected[x] = 0;
                }

                cmdNextPlayer.Visible = true;
                cmdNextPlayer.Enabled = true;
            }
        }

        /// <summary>
        /// click on the insert button to insert player in the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdInsertPlayer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A implémenter");
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

        }

        private void coinsTaker(List<int> selectCoins, List<int> availableRessources, Ressources witchRessource)
        {
            selectCoins[(int)witchRessource]--;
            availableRessources[(int)witchRessource]++;
            allRessourcesLbl[(int)witchRessource].Text = availableRessources[(int)witchRessource].ToString();
            allRessourcesLblChoice[(int)witchRessource].Text = selectCoins[(int)witchRessource] + "\r\n";

            if (selectCoins[(int)witchRessource] == 0)
            {
                allRessourcesLblChoice[(int)witchRessource].Visible = false;
            }
        }

        /// <summary>
        /// click on the player rubis coin to remove a coin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblChoiceRubis_Click(object sender, EventArgs e)
        {
            coinsTaker(this.nbCoinsSelected, this.availableCoins, Ressources.Rubis);
        }

        /// <summary>
        /// click on the player saphir coin to remove a coin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblChoiceSaphir_Click(object sender, EventArgs e)
        {
            coinsTaker(this.nbCoinsSelected, this.availableCoins, Ressources.Saphir);
        }

        /// <summary>
        /// click on the player onyx coin to remove a coin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblChoiceOnyx_Click(object sender, EventArgs e)
        {
            coinsTaker(this.nbCoinsSelected, this.availableCoins, Ressources.Onyx);
        }

        /// <summary>
        /// click on the player emeraude coin to remove a coin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblChoiceEmeraude_Click(object sender, EventArgs e)
        {
            coinsTaker(this.nbCoinsSelected, this.availableCoins, Ressources.Emeraude);
        }

        /// <summary>
        /// click on the player diamand coin to remove a coin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblChoiceDiamand_Click(object sender, EventArgs e)
        {
            coinsTaker(this.nbCoinsSelected, this.availableCoins, Ressources.Diamand);
        }
    }
}
