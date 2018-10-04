namespace Splendor
{
    partial class frmSplendor
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblGoldCoin = new System.Windows.Forms.Label();
            this.lblRubisCoin = new System.Windows.Forms.Label();
            this.lblSaphirCoin = new System.Windows.Forms.Label();
            this.lblOnyxCoin = new System.Windows.Forms.Label();
            this.lblEmeraudeCoin = new System.Windows.Forms.Label();
            this.lblDiamandCoin = new System.Windows.Forms.Label();
            this.cmdInsertPlayer = new System.Windows.Forms.Button();
            this.cmdPlay = new System.Windows.Forms.Button();
            this.txtPlayerEmeraudeCard = new System.Windows.Forms.TextBox();
            this.txtPlayerOnyxCard = new System.Windows.Forms.TextBox();
            this.txtPlayerSaphirCard = new System.Windows.Forms.TextBox();
            this.txtPlayerRubisCard = new System.Windows.Forms.TextBox();
            this.lblPlayerDiamandCoin = new System.Windows.Forms.Label();
            this.lblPlayerEmeraudeCoin = new System.Windows.Forms.Label();
            this.lblPlayerOnyxCoin = new System.Windows.Forms.Label();
            this.lblPlayerSaphirCoin = new System.Windows.Forms.Label();
            this.lblPlayerRubisCoin = new System.Windows.Forms.Label();
            this.lblPlayerGoldCoin = new System.Windows.Forms.Label();
            this.txtPlayerBookedCard = new System.Windows.Forms.TextBox();
            this.txtPlayerDiamandCard = new System.Windows.Forms.TextBox();
            this.lblChoiceRubis = new System.Windows.Forms.Label();
            this.lblChoiceSaphir = new System.Windows.Forms.Label();
            this.lblChoiceOnyx = new System.Windows.Forms.Label();
            this.lblChoiceEmeraude = new System.Windows.Forms.Label();
            this.lblChoiceDiamand = new System.Windows.Forms.Label();
            this.cmdValidateChoice = new System.Windows.Forms.Button();
            this.cmdNextPlayer = new System.Windows.Forms.Button();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblChoiceCard = new System.Windows.Forms.Label();
            this.lblNbPtPrestige = new System.Windows.Forms.Label();
            this.flwCardLevel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.flwCardLevel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.flwCardLevel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.flwCardNoble = new System.Windows.Forms.FlowLayoutPanel();
            this.txtBox01 = new System.Windows.Forms.TextBox();
            this.textBox02 = new System.Windows.Forms.TextBox();
            this.textBox03 = new System.Windows.Forms.TextBox();
            this.textBox04 = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flwCardLevel1.SuspendLayout();
            this.flwCardLevel2.SuspendLayout();
            this.flwCardLevel3.SuspendLayout();
            this.flwCardNoble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGoldCoin
            // 
            this.lblGoldCoin.AutoSize = true;
            this.lblGoldCoin.ForeColor = System.Drawing.Color.Yellow;
            this.lblGoldCoin.Location = new System.Drawing.Point(542, 15);
            this.lblGoldCoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGoldCoin.Name = "lblGoldCoin";
            this.lblGoldCoin.Size = new System.Drawing.Size(50, 13);
            this.lblGoldCoin.TabIndex = 0;
            this.lblGoldCoin.Text = "GoldCoin";
            // 
            // lblRubisCoin
            // 
            this.lblRubisCoin.AutoSize = true;
            this.lblRubisCoin.BackColor = System.Drawing.Color.Red;
            this.lblRubisCoin.ForeColor = System.Drawing.Color.White;
            this.lblRubisCoin.Location = new System.Drawing.Point(19, 15);
            this.lblRubisCoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRubisCoin.Name = "lblRubisCoin";
            this.lblRubisCoin.Size = new System.Drawing.Size(55, 13);
            this.lblRubisCoin.TabIndex = 1;
            this.lblRubisCoin.Text = "RubisCoin";
            this.lblRubisCoin.UseMnemonic = false;
            this.lblRubisCoin.Click += new System.EventHandler(this.lblRubisCoin_Click);
            // 
            // lblSaphirCoin
            // 
            this.lblSaphirCoin.AutoSize = true;
            this.lblSaphirCoin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblSaphirCoin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSaphirCoin.Location = new System.Drawing.Point(100, 15);
            this.lblSaphirCoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaphirCoin.Name = "lblSaphirCoin";
            this.lblSaphirCoin.Size = new System.Drawing.Size(58, 13);
            this.lblSaphirCoin.TabIndex = 2;
            this.lblSaphirCoin.Text = "SaphirCoin";
            this.lblSaphirCoin.Click += new System.EventHandler(this.lblSaphirCoin_Click);
            // 
            // lblOnyxCoin
            // 
            this.lblOnyxCoin.AutoSize = true;
            this.lblOnyxCoin.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblOnyxCoin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblOnyxCoin.Location = new System.Drawing.Point(186, 15);
            this.lblOnyxCoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOnyxCoin.Name = "lblOnyxCoin";
            this.lblOnyxCoin.Size = new System.Drawing.Size(52, 13);
            this.lblOnyxCoin.TabIndex = 3;
            this.lblOnyxCoin.Text = "OnyxCoin";
            this.lblOnyxCoin.Click += new System.EventHandler(this.lblOnyxCoin_Click);
            // 
            // lblEmeraudeCoin
            // 
            this.lblEmeraudeCoin.AutoSize = true;
            this.lblEmeraudeCoin.BackColor = System.Drawing.Color.Green;
            this.lblEmeraudeCoin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEmeraudeCoin.Location = new System.Drawing.Point(265, 15);
            this.lblEmeraudeCoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmeraudeCoin.Name = "lblEmeraudeCoin";
            this.lblEmeraudeCoin.Size = new System.Drawing.Size(76, 13);
            this.lblEmeraudeCoin.TabIndex = 4;
            this.lblEmeraudeCoin.Text = "EmeraudeCoin";
            this.lblEmeraudeCoin.Click += new System.EventHandler(this.lblEmeraudeCoin_Click);
            // 
            // lblDiamandCoin
            // 
            this.lblDiamandCoin.AutoSize = true;
            this.lblDiamandCoin.BackColor = System.Drawing.SystemColors.Window;
            this.lblDiamandCoin.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblDiamandCoin.Location = new System.Drawing.Point(368, 15);
            this.lblDiamandCoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiamandCoin.Name = "lblDiamandCoin";
            this.lblDiamandCoin.Size = new System.Drawing.Size(70, 13);
            this.lblDiamandCoin.TabIndex = 5;
            this.lblDiamandCoin.Text = "DiamandCoin";
            this.lblDiamandCoin.Click += new System.EventHandler(this.lblDiamandCoin_Click);
            // 
            // cmdInsertPlayer
            // 
            this.cmdInsertPlayer.Location = new System.Drawing.Point(501, 153);
            this.cmdInsertPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.cmdInsertPlayer.Name = "cmdInsertPlayer";
            this.cmdInsertPlayer.Size = new System.Drawing.Size(82, 39);
            this.cmdInsertPlayer.TabIndex = 18;
            this.cmdInsertPlayer.Text = "Entrer joueur";
            this.cmdInsertPlayer.UseVisualStyleBackColor = true;
            this.cmdInsertPlayer.Click += new System.EventHandler(this.cmdInsertPlayer_Click);
            // 
            // cmdPlay
            // 
            this.cmdPlay.Location = new System.Drawing.Point(501, 211);
            this.cmdPlay.Margin = new System.Windows.Forms.Padding(2);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(82, 39);
            this.cmdPlay.TabIndex = 19;
            this.cmdPlay.Text = "Jouer";
            this.cmdPlay.UseVisualStyleBackColor = true;
            this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
            // 
            // txtPlayerEmeraudeCard
            // 
            this.txtPlayerEmeraudeCard.ForeColor = System.Drawing.Color.Green;
            this.txtPlayerEmeraudeCard.Location = new System.Drawing.Point(380, 624);
            this.txtPlayerEmeraudeCard.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlayerEmeraudeCard.Multiline = true;
            this.txtPlayerEmeraudeCard.Name = "txtPlayerEmeraudeCard";
            this.txtPlayerEmeraudeCard.Size = new System.Drawing.Size(81, 98);
            this.txtPlayerEmeraudeCard.TabIndex = 30;
            // 
            // txtPlayerOnyxCard
            // 
            this.txtPlayerOnyxCard.Location = new System.Drawing.Point(260, 624);
            this.txtPlayerOnyxCard.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlayerOnyxCard.Multiline = true;
            this.txtPlayerOnyxCard.Name = "txtPlayerOnyxCard";
            this.txtPlayerOnyxCard.Size = new System.Drawing.Size(81, 98);
            this.txtPlayerOnyxCard.TabIndex = 29;
            // 
            // txtPlayerSaphirCard
            // 
            this.txtPlayerSaphirCard.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtPlayerSaphirCard.Location = new System.Drawing.Point(140, 624);
            this.txtPlayerSaphirCard.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlayerSaphirCard.Multiline = true;
            this.txtPlayerSaphirCard.Name = "txtPlayerSaphirCard";
            this.txtPlayerSaphirCard.Size = new System.Drawing.Size(81, 98);
            this.txtPlayerSaphirCard.TabIndex = 28;
            // 
            // txtPlayerRubisCard
            // 
            this.txtPlayerRubisCard.ForeColor = System.Drawing.Color.Red;
            this.txtPlayerRubisCard.Location = new System.Drawing.Point(20, 624);
            this.txtPlayerRubisCard.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlayerRubisCard.Multiline = true;
            this.txtPlayerRubisCard.Name = "txtPlayerRubisCard";
            this.txtPlayerRubisCard.Size = new System.Drawing.Size(81, 98);
            this.txtPlayerRubisCard.TabIndex = 27;
            // 
            // lblPlayerDiamandCoin
            // 
            this.lblPlayerDiamandCoin.AutoSize = true;
            this.lblPlayerDiamandCoin.BackColor = System.Drawing.SystemColors.Window;
            this.lblPlayerDiamandCoin.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblPlayerDiamandCoin.Location = new System.Drawing.Point(379, 593);
            this.lblPlayerDiamandCoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerDiamandCoin.Name = "lblPlayerDiamandCoin";
            this.lblPlayerDiamandCoin.Size = new System.Drawing.Size(70, 13);
            this.lblPlayerDiamandCoin.TabIndex = 26;
            this.lblPlayerDiamandCoin.Text = "DiamandCoin";
            // 
            // lblPlayerEmeraudeCoin
            // 
            this.lblPlayerEmeraudeCoin.AutoSize = true;
            this.lblPlayerEmeraudeCoin.BackColor = System.Drawing.Color.Green;
            this.lblPlayerEmeraudeCoin.ForeColor = System.Drawing.Color.White;
            this.lblPlayerEmeraudeCoin.Location = new System.Drawing.Point(284, 593);
            this.lblPlayerEmeraudeCoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerEmeraudeCoin.Name = "lblPlayerEmeraudeCoin";
            this.lblPlayerEmeraudeCoin.Size = new System.Drawing.Size(76, 13);
            this.lblPlayerEmeraudeCoin.TabIndex = 25;
            this.lblPlayerEmeraudeCoin.Text = "EmeraudeCoin";
            // 
            // lblPlayerOnyxCoin
            // 
            this.lblPlayerOnyxCoin.AutoSize = true;
            this.lblPlayerOnyxCoin.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblPlayerOnyxCoin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPlayerOnyxCoin.Location = new System.Drawing.Point(200, 593);
            this.lblPlayerOnyxCoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerOnyxCoin.Name = "lblPlayerOnyxCoin";
            this.lblPlayerOnyxCoin.Size = new System.Drawing.Size(52, 13);
            this.lblPlayerOnyxCoin.TabIndex = 24;
            this.lblPlayerOnyxCoin.Text = "OnyxCoin";
            // 
            // lblPlayerSaphirCoin
            // 
            this.lblPlayerSaphirCoin.AutoSize = true;
            this.lblPlayerSaphirCoin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblPlayerSaphirCoin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPlayerSaphirCoin.Location = new System.Drawing.Point(108, 593);
            this.lblPlayerSaphirCoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerSaphirCoin.Name = "lblPlayerSaphirCoin";
            this.lblPlayerSaphirCoin.Size = new System.Drawing.Size(58, 13);
            this.lblPlayerSaphirCoin.TabIndex = 23;
            this.lblPlayerSaphirCoin.Text = "SaphirCoin";
            // 
            // lblPlayerRubisCoin
            // 
            this.lblPlayerRubisCoin.AutoSize = true;
            this.lblPlayerRubisCoin.BackColor = System.Drawing.Color.Red;
            this.lblPlayerRubisCoin.ForeColor = System.Drawing.Color.White;
            this.lblPlayerRubisCoin.Location = new System.Drawing.Point(18, 593);
            this.lblPlayerRubisCoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerRubisCoin.Name = "lblPlayerRubisCoin";
            this.lblPlayerRubisCoin.Size = new System.Drawing.Size(55, 13);
            this.lblPlayerRubisCoin.TabIndex = 22;
            this.lblPlayerRubisCoin.Text = "RubisCoin";
            this.lblPlayerRubisCoin.UseMnemonic = false;
            // 
            // lblPlayerGoldCoin
            // 
            this.lblPlayerGoldCoin.AutoSize = true;
            this.lblPlayerGoldCoin.ForeColor = System.Drawing.Color.Yellow;
            this.lblPlayerGoldCoin.Location = new System.Drawing.Point(501, 348);
            this.lblPlayerGoldCoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerGoldCoin.Name = "lblPlayerGoldCoin";
            this.lblPlayerGoldCoin.Size = new System.Drawing.Size(50, 13);
            this.lblPlayerGoldCoin.TabIndex = 21;
            this.lblPlayerGoldCoin.Text = "GoldCoin";
            // 
            // txtPlayerBookedCard
            // 
            this.txtPlayerBookedCard.Location = new System.Drawing.Point(503, 374);
            this.txtPlayerBookedCard.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlayerBookedCard.Multiline = true;
            this.txtPlayerBookedCard.Name = "txtPlayerBookedCard";
            this.txtPlayerBookedCard.Size = new System.Drawing.Size(81, 98);
            this.txtPlayerBookedCard.TabIndex = 31;
            // 
            // txtPlayerDiamandCard
            // 
            this.txtPlayerDiamandCard.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPlayerDiamandCard.Location = new System.Drawing.Point(502, 624);
            this.txtPlayerDiamandCard.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlayerDiamandCard.Multiline = true;
            this.txtPlayerDiamandCard.Name = "txtPlayerDiamandCard";
            this.txtPlayerDiamandCard.Size = new System.Drawing.Size(81, 98);
            this.txtPlayerDiamandCard.TabIndex = 32;
            // 
            // lblChoiceRubis
            // 
            this.lblChoiceRubis.AutoSize = true;
            this.lblChoiceRubis.BackColor = System.Drawing.Color.Red;
            this.lblChoiceRubis.ForeColor = System.Drawing.SystemColors.Window;
            this.lblChoiceRubis.Location = new System.Drawing.Point(18, 524);
            this.lblChoiceRubis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoiceRubis.Name = "lblChoiceRubis";
            this.lblChoiceRubis.Size = new System.Drawing.Size(57, 13);
            this.lblChoiceRubis.TabIndex = 33;
            this.lblChoiceRubis.Text = "choix rubis";
            // 
            // lblChoiceSaphir
            // 
            this.lblChoiceSaphir.AutoSize = true;
            this.lblChoiceSaphir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblChoiceSaphir.ForeColor = System.Drawing.SystemColors.Window;
            this.lblChoiceSaphir.Location = new System.Drawing.Point(108, 524);
            this.lblChoiceSaphir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoiceSaphir.Name = "lblChoiceSaphir";
            this.lblChoiceSaphir.Size = new System.Drawing.Size(63, 13);
            this.lblChoiceSaphir.TabIndex = 34;
            this.lblChoiceSaphir.Text = "choix saphir";
            // 
            // lblChoiceOnyx
            // 
            this.lblChoiceOnyx.AutoSize = true;
            this.lblChoiceOnyx.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblChoiceOnyx.ForeColor = System.Drawing.SystemColors.Window;
            this.lblChoiceOnyx.Location = new System.Drawing.Point(200, 524);
            this.lblChoiceOnyx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoiceOnyx.Name = "lblChoiceOnyx";
            this.lblChoiceOnyx.Size = new System.Drawing.Size(57, 13);
            this.lblChoiceOnyx.TabIndex = 35;
            this.lblChoiceOnyx.Text = "choix onyx";
            // 
            // lblChoiceEmeraude
            // 
            this.lblChoiceEmeraude.AutoSize = true;
            this.lblChoiceEmeraude.BackColor = System.Drawing.Color.Green;
            this.lblChoiceEmeraude.ForeColor = System.Drawing.SystemColors.Window;
            this.lblChoiceEmeraude.Location = new System.Drawing.Point(284, 524);
            this.lblChoiceEmeraude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoiceEmeraude.Name = "lblChoiceEmeraude";
            this.lblChoiceEmeraude.Size = new System.Drawing.Size(82, 13);
            this.lblChoiceEmeraude.TabIndex = 36;
            this.lblChoiceEmeraude.Text = "choix émeraude";
            // 
            // lblChoiceDiamand
            // 
            this.lblChoiceDiamand.AutoSize = true;
            this.lblChoiceDiamand.BackColor = System.Drawing.SystemColors.Window;
            this.lblChoiceDiamand.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblChoiceDiamand.Location = new System.Drawing.Point(379, 524);
            this.lblChoiceDiamand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoiceDiamand.Name = "lblChoiceDiamand";
            this.lblChoiceDiamand.Size = new System.Drawing.Size(75, 13);
            this.lblChoiceDiamand.TabIndex = 37;
            this.lblChoiceDiamand.Text = "choix diamand";
            // 
            // cmdValidateChoice
            // 
            this.cmdValidateChoice.Location = new System.Drawing.Point(20, 554);
            this.cmdValidateChoice.Margin = new System.Windows.Forms.Padding(2);
            this.cmdValidateChoice.Name = "cmdValidateChoice";
            this.cmdValidateChoice.Size = new System.Drawing.Size(83, 21);
            this.cmdValidateChoice.TabIndex = 38;
            this.cmdValidateChoice.Text = "Valider choix";
            this.cmdValidateChoice.UseVisualStyleBackColor = true;
            this.cmdValidateChoice.Click += new System.EventHandler(this.cmdValidateChoice_Click);
            // 
            // cmdNextPlayer
            // 
            this.cmdNextPlayer.Location = new System.Drawing.Point(135, 554);
            this.cmdNextPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.cmdNextPlayer.Name = "cmdNextPlayer";
            this.cmdNextPlayer.Size = new System.Drawing.Size(106, 20);
            this.cmdNextPlayer.TabIndex = 39;
            this.cmdNextPlayer.Text = "Joueur suivant";
            this.cmdNextPlayer.UseVisualStyleBackColor = true;
            this.cmdNextPlayer.Click += new System.EventHandler(this.cmdNextPlayer_Click);
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(22, 499);
            this.lblPlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(58, 13);
            this.lblPlayer.TabIndex = 40;
            this.lblPlayer.Text = "Plateau de";
            // 
            // lblChoiceCard
            // 
            this.lblChoiceCard.AutoSize = true;
            this.lblChoiceCard.Location = new System.Drawing.Point(472, 524);
            this.lblChoiceCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoiceCard.Name = "lblChoiceCard";
            this.lblChoiceCard.Size = new System.Drawing.Size(67, 13);
            this.lblChoiceCard.TabIndex = 41;
            this.lblChoiceCard.Text = "carte choisie";
            // 
            // lblNbPtPrestige
            // 
            this.lblNbPtPrestige.AutoSize = true;
            this.lblNbPtPrestige.Location = new System.Drawing.Point(467, 592);
            this.lblNbPtPrestige.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbPtPrestige.Name = "lblNbPtPrestige";
            this.lblNbPtPrestige.Size = new System.Drawing.Size(73, 13);
            this.lblNbPtPrestige.TabIndex = 46;
            this.lblNbPtPrestige.Text = "Nb pt prestige";
            // 
            // flwCardLevel1
            // 
            this.flwCardLevel1.Controls.Add(this.textBox31);
            this.flwCardLevel1.Controls.Add(this.textBox32);
            this.flwCardLevel1.Controls.Add(this.textBox33);
            this.flwCardLevel1.Controls.Add(this.textBox34);
            this.flwCardLevel1.Location = new System.Drawing.Point(14, 374);
            this.flwCardLevel1.Margin = new System.Windows.Forms.Padding(2);
            this.flwCardLevel1.Name = "flwCardLevel1";
            this.flwCardLevel1.Size = new System.Drawing.Size(452, 107);
            this.flwCardLevel1.TabIndex = 47;
            // 
            // textBox31
            // 
            this.textBox31.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox31.Location = new System.Drawing.Point(3, 3);
            this.textBox31.Multiline = true;
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(102, 98);
            this.textBox31.TabIndex = 66;
            // 
            // textBox32
            // 
            this.textBox32.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox32.Location = new System.Drawing.Point(111, 3);
            this.textBox32.Multiline = true;
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(102, 98);
            this.textBox32.TabIndex = 64;
            // 
            // textBox33
            // 
            this.textBox33.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox33.Location = new System.Drawing.Point(219, 3);
            this.textBox33.Multiline = true;
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(102, 98);
            this.textBox33.TabIndex = 65;
            // 
            // textBox34
            // 
            this.textBox34.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox34.Location = new System.Drawing.Point(327, 3);
            this.textBox34.Multiline = true;
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(102, 98);
            this.textBox34.TabIndex = 63;
            // 
            // flwCardLevel2
            // 
            this.flwCardLevel2.Controls.Add(this.textBox21);
            this.flwCardLevel2.Controls.Add(this.textBox22);
            this.flwCardLevel2.Controls.Add(this.textBox23);
            this.flwCardLevel2.Controls.Add(this.textBox24);
            this.flwCardLevel2.Location = new System.Drawing.Point(14, 257);
            this.flwCardLevel2.Margin = new System.Windows.Forms.Padding(2);
            this.flwCardLevel2.Name = "flwCardLevel2";
            this.flwCardLevel2.Size = new System.Drawing.Size(452, 117);
            this.flwCardLevel2.TabIndex = 48;
            // 
            // textBox21
            // 
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox21.Location = new System.Drawing.Point(3, 3);
            this.textBox21.Multiline = true;
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(102, 98);
            this.textBox21.TabIndex = 59;
            // 
            // textBox22
            // 
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox22.Location = new System.Drawing.Point(111, 3);
            this.textBox22.Multiline = true;
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(102, 98);
            this.textBox22.TabIndex = 62;
            // 
            // textBox23
            // 
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox23.Location = new System.Drawing.Point(219, 3);
            this.textBox23.Multiline = true;
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(102, 98);
            this.textBox23.TabIndex = 61;
            // 
            // textBox24
            // 
            this.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox24.Location = new System.Drawing.Point(327, 3);
            this.textBox24.Multiline = true;
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(102, 98);
            this.textBox24.TabIndex = 60;
            // 
            // flwCardLevel3
            // 
            this.flwCardLevel3.Controls.Add(this.textBox11);
            this.flwCardLevel3.Controls.Add(this.textBox12);
            this.flwCardLevel3.Controls.Add(this.textBox13);
            this.flwCardLevel3.Controls.Add(this.textBox14);
            this.flwCardLevel3.Location = new System.Drawing.Point(14, 145);
            this.flwCardLevel3.Margin = new System.Windows.Forms.Padding(2);
            this.flwCardLevel3.Name = "flwCardLevel3";
            this.flwCardLevel3.Size = new System.Drawing.Size(452, 111);
            this.flwCardLevel3.TabIndex = 49;
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Location = new System.Drawing.Point(3, 3);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(102, 98);
            this.textBox11.TabIndex = 55;
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Location = new System.Drawing.Point(111, 3);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(102, 98);
            this.textBox12.TabIndex = 56;
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Location = new System.Drawing.Point(219, 3);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(102, 98);
            this.textBox13.TabIndex = 57;
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Location = new System.Drawing.Point(327, 3);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(102, 98);
            this.textBox14.TabIndex = 58;
            // 
            // flwCardNoble
            // 
            this.flwCardNoble.Controls.Add(this.txtBox01);
            this.flwCardNoble.Controls.Add(this.textBox02);
            this.flwCardNoble.Controls.Add(this.textBox03);
            this.flwCardNoble.Controls.Add(this.textBox04);
            this.flwCardNoble.Location = new System.Drawing.Point(14, 37);
            this.flwCardNoble.Margin = new System.Windows.Forms.Padding(2);
            this.flwCardNoble.Name = "flwCardNoble";
            this.flwCardNoble.Size = new System.Drawing.Size(452, 109);
            this.flwCardNoble.TabIndex = 50;
            // 
            // txtBox01
            // 
            this.txtBox01.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox01.Location = new System.Drawing.Point(3, 3);
            this.txtBox01.Multiline = true;
            this.txtBox01.Name = "txtBox01";
            this.txtBox01.Size = new System.Drawing.Size(102, 98);
            this.txtBox01.TabIndex = 51;
            // 
            // textBox02
            // 
            this.textBox02.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox02.Location = new System.Drawing.Point(111, 3);
            this.textBox02.Multiline = true;
            this.textBox02.Name = "textBox02";
            this.textBox02.Size = new System.Drawing.Size(102, 98);
            this.textBox02.TabIndex = 52;
            // 
            // textBox03
            // 
            this.textBox03.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox03.Location = new System.Drawing.Point(219, 3);
            this.textBox03.Multiline = true;
            this.textBox03.Name = "textBox03";
            this.textBox03.Size = new System.Drawing.Size(102, 98);
            this.textBox03.TabIndex = 53;
            // 
            // textBox04
            // 
            this.textBox04.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox04.Location = new System.Drawing.Point(327, 3);
            this.textBox04.Multiline = true;
            this.textBox04.Name = "textBox04";
            this.textBox04.Size = new System.Drawing.Size(102, 98);
            this.textBox04.TabIndex = 54;
            // 
            // frmSplendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 763);
            this.Controls.Add(this.flwCardNoble);
            this.Controls.Add(this.flwCardLevel3);
            this.Controls.Add(this.flwCardLevel2);
            this.Controls.Add(this.flwCardLevel1);
            this.Controls.Add(this.lblNbPtPrestige);
            this.Controls.Add(this.lblChoiceCard);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.cmdNextPlayer);
            this.Controls.Add(this.cmdValidateChoice);
            this.Controls.Add(this.lblChoiceDiamand);
            this.Controls.Add(this.lblChoiceEmeraude);
            this.Controls.Add(this.lblChoiceOnyx);
            this.Controls.Add(this.lblChoiceSaphir);
            this.Controls.Add(this.lblChoiceRubis);
            this.Controls.Add(this.txtPlayerDiamandCard);
            this.Controls.Add(this.txtPlayerBookedCard);
            this.Controls.Add(this.txtPlayerEmeraudeCard);
            this.Controls.Add(this.txtPlayerOnyxCard);
            this.Controls.Add(this.txtPlayerSaphirCard);
            this.Controls.Add(this.txtPlayerRubisCard);
            this.Controls.Add(this.lblPlayerDiamandCoin);
            this.Controls.Add(this.lblPlayerEmeraudeCoin);
            this.Controls.Add(this.lblPlayerOnyxCoin);
            this.Controls.Add(this.lblPlayerSaphirCoin);
            this.Controls.Add(this.lblPlayerRubisCoin);
            this.Controls.Add(this.lblPlayerGoldCoin);
            this.Controls.Add(this.cmdPlay);
            this.Controls.Add(this.cmdInsertPlayer);
            this.Controls.Add(this.lblDiamandCoin);
            this.Controls.Add(this.lblEmeraudeCoin);
            this.Controls.Add(this.lblOnyxCoin);
            this.Controls.Add(this.lblSaphirCoin);
            this.Controls.Add(this.lblRubisCoin);
            this.Controls.Add(this.lblGoldCoin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSplendor";
            this.Text = "Splendor";
            this.Load += new System.EventHandler(this.frmSplendor_Load);
            this.flwCardLevel1.ResumeLayout(false);
            this.flwCardLevel1.PerformLayout();
            this.flwCardLevel2.ResumeLayout(false);
            this.flwCardLevel2.PerformLayout();
            this.flwCardLevel3.ResumeLayout(false);
            this.flwCardLevel3.PerformLayout();
            this.flwCardNoble.ResumeLayout(false);
            this.flwCardNoble.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGoldCoin;
        private System.Windows.Forms.Label lblRubisCoin;
        private System.Windows.Forms.Label lblSaphirCoin;
        private System.Windows.Forms.Label lblOnyxCoin;
        private System.Windows.Forms.Label lblEmeraudeCoin;
        private System.Windows.Forms.Label lblDiamandCoin;
        private System.Windows.Forms.Button cmdInsertPlayer;
        private System.Windows.Forms.Button cmdPlay;
        private System.Windows.Forms.TextBox txtPlayerEmeraudeCard;
        private System.Windows.Forms.TextBox txtPlayerOnyxCard;
        private System.Windows.Forms.TextBox txtPlayerSaphirCard;
        private System.Windows.Forms.TextBox txtPlayerRubisCard;
        private System.Windows.Forms.Label lblPlayerDiamandCoin;
        private System.Windows.Forms.Label lblPlayerEmeraudeCoin;
        private System.Windows.Forms.Label lblPlayerOnyxCoin;
        private System.Windows.Forms.Label lblPlayerSaphirCoin;
        private System.Windows.Forms.Label lblPlayerRubisCoin;
        private System.Windows.Forms.Label lblPlayerGoldCoin;
        private System.Windows.Forms.TextBox txtPlayerBookedCard;
        private System.Windows.Forms.TextBox txtPlayerDiamandCard;
        private System.Windows.Forms.Label lblChoiceRubis;
        private System.Windows.Forms.Label lblChoiceSaphir;
        private System.Windows.Forms.Label lblChoiceOnyx;
        private System.Windows.Forms.Label lblChoiceEmeraude;
        private System.Windows.Forms.Label lblChoiceDiamand;
        private System.Windows.Forms.Button cmdValidateChoice;
        private System.Windows.Forms.Button cmdNextPlayer;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblChoiceCard;
        private System.Windows.Forms.Label lblNbPtPrestige;
        private System.Windows.Forms.FlowLayoutPanel flwCardLevel1;
        private System.Windows.Forms.FlowLayoutPanel flwCardLevel2;
        private System.Windows.Forms.FlowLayoutPanel flwCardLevel3;
        private System.Windows.Forms.FlowLayoutPanel flwCardNoble;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox txtBox01;
        private System.Windows.Forms.TextBox textBox02;
        private System.Windows.Forms.TextBox textBox03;
        private System.Windows.Forms.TextBox textBox04;
    }
}

