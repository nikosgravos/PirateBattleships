using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Media;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ErgasiaBattleship
{
    public partial class BattleShips : Form
    {
        public PictureBox[,] playerBoard = new PictureBox[10, 10];
        int plCounter = 0;
        int plFrigateCounter = 0;
        int plCutlassCounter = 0;
        int plBateauCounter = 0;
        int plRowBoatCounter = 0;

        public Button[,] enemyBoard = new Button[10, 10];
        int enCounter = 0;
        int enFrigateCounter = 0;
        int enCutlassCounter = 0;
        int enBateauCounter = 0;
        int enRowBoatCounter = 0;

        Random random = new Random();

        bool[,] playerShips = new bool[10, 10];
        bool[,] enemyShips = new bool[10, 10];

        int cannonballCounter = 100;
        int secondsPassed = 0;
        int wins = 0;
        int losses = 0;


        public BattleShips()
        {
            InitializeComponent();

            PlaceEnemyTiles();
            PlaceEnemyShips();

            PlacePlayerTiles();
            PlacePlayerShips();
        }

        //creates player tiles
        private void PlacePlayerTiles()
        {
            int top = 265;
            int left = 74;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    playerBoard[i, j] = new PictureBox();
                    playerBoard[i, j].Height = 28;
                    playerBoard[i, j].Width = 29;
                    playerBoard[i, j].BackColor = Color.Transparent;
                    playerBoard[i, j].BorderStyle = BorderStyle.FixedSingle;

                    playerBoard[i, j].Left = left;
                    playerBoard[i, j].Top = top;
                    this.Controls.Add(playerBoard[i, j]);
                    left += 34;
                }

                top += 33;
                left = 74;
            }
        }

        //creates enemy tiles
        private void PlaceEnemyTiles()
        {
            int top = 265;
            int left = 780;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    enemyBoard[i, j] = new Button();
                    enemyBoard[i, j].Height = 28;
                    enemyBoard[i, j].Width = 29;
                    enemyBoard[i, j].BackColor = Color.Transparent;
                    enemyBoard[i, j].FlatStyle = FlatStyle.Popup;
                    enemyBoard[i, j].TabStop = false;
                    enemyBoard[i, j].Click += new EventHandler(HitShips); 

                    enemyBoard[i, j].Left = left;
                    enemyBoard[i, j].Top = top;
                    this.Controls.Add(enemyBoard[i, j]);
                    left += 34;
                }

                top += 33;
                left = 780;
            }
        }

        //places 4 ships on the player board
        private void PlacePlayerShips()
        {
            for (int shipLength = 5; shipLength >= 2; shipLength--)
            {
                int vert = random.Next(0, 2);
                int y = random.Next(0, 10);
                int x = random.Next(0, 10);
                bool canPlace = true;

                if (vert == 1)
                {
                    if (x <= shipLength)
                    {
                        for (int i = 0; i < shipLength; i++)
                        {
                            if (playerShips[x + i, y] == true)
                            {
                                canPlace = false;
                                break;
                            }
                        }
                        if (canPlace == true)
                        {
                            for (int i = 0; i < shipLength; i++)
                            {
                                if (shipLength == 5) playerBoard[x, y].Tag = "plFrigate";
                                else if (shipLength == 4) playerBoard[x, y].Tag = "plCutlass";
                                else if (shipLength == 3) playerBoard[x, y].Tag = "plBateau";
                                else if (shipLength == 2) playerBoard[x, y].Tag = "plRowBoat";

                                playerBoard[x, y].BackColor = Color.FromArgb(52, 26, 9);
                                playerShips[x, y] = true;
                                x++;
                            }
                        }
                        else
                        {
                            shipLength++;
                            continue;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < shipLength; i++)
                        {
                            if (playerShips[x - i, y] == true)
                            {
                                canPlace = false;
                                break;
                            }
                        }
                        if (canPlace == true)
                        {
                            for (int i = 0; i < shipLength; i++)
                            {
                                if (shipLength == 5) playerBoard[x, y].Tag = "plFrigate";
                                else if (shipLength == 4) playerBoard[x, y].Tag = "plCutlass";
                                else if (shipLength == 3) playerBoard[x, y].Tag = "plBateau";
                                else if (shipLength == 2) playerBoard[x, y].Tag = "plRowBoat";

                                playerBoard[x, y].BackColor = Color.FromArgb(52, 26, 9); ;
                                playerShips[x, y] = true;
                                x--;
                            }
                        }
                        else
                        {
                            shipLength++;
                            continue;
                        }
                    }
                }
                else
                {
                    if (y <= shipLength)
                    {
                        for (int i = 0; i < shipLength; i++)
                        {
                            if (playerShips[x, y + i] == true)
                            {
                                canPlace = false;
                                break;
                            }
                        }
                        if (canPlace == true)
                        {
                            for (int i = 0; i < shipLength; i++)
                            {
                                if (shipLength == 5) playerBoard[x, y].Tag = "plFrigate";
                                else if (shipLength == 4) playerBoard[x, y].Tag = "plCutlass";
                                else if (shipLength == 3) playerBoard[x, y].Tag = "plBateau";
                                else if (shipLength == 2) playerBoard[x, y].Tag = "plRowBoat";

                                playerBoard[x, y].BackColor = Color.FromArgb(52, 26, 9); ;
                                playerShips[x, y] = true;
                                y++;
                            }
                        }
                        else
                        {
                            shipLength++;
                            continue;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < shipLength; i++)
                        {
                            if (playerShips[x, y - i] == true)
                            {
                                canPlace = false;
                                break;
                            }
                        }
                        if (canPlace == true)
                        {
                            for (int i = 0; i < shipLength; i++)
                            {
                                if (shipLength == 5) playerBoard[x, y].Tag = "plFrigate";
                                else if (shipLength == 4) playerBoard[x, y].Tag = "plCutlass";
                                else if (shipLength == 3) playerBoard[x, y].Tag = "plBateau";
                                else if (shipLength == 2) playerBoard[x, y].Tag = "plRowBoat";

                                playerBoard[x, y].BackColor = Color.FromArgb(52, 26, 9); ;
                                playerShips[x, y] = true;
                                y--;
                            }
                        }
                        else
                        {
                            shipLength++;
                            continue;
                        }
                    }
                }
            }
        }

        //places 4 ships on the enemy board
        private void PlaceEnemyShips()
        {
            for (int shipLength = 5; shipLength >= 2; shipLength--)
            {
                int vert = random.Next(0, 2);
                int y = random.Next(0, 10);
                int x = random.Next(0, 10);
                bool canPlace = true;

                if (vert == 1)
                {
                    if (x <= shipLength)
                    {
                        for (int i = 0; i < shipLength; i++)
                        {
                            if (enemyShips[x + i, y] == true)
                            {
                                canPlace = false;
                                break;
                            }
                        }
                        if (canPlace == true)
                        {
                            for (int i = 0; i < shipLength; i++)
                            {
                                if (shipLength == 5) enemyBoard[x, y].Tag = "enFrigate";
                                else if (shipLength == 4) enemyBoard[x, y].Tag = "enCutlass";
                                else if (shipLength == 3) enemyBoard[x, y].Tag = "enBateau";
                                else if (shipLength == 2) enemyBoard[x, y].Tag = "enRowBoat";

                                //enemyBoard[x, y].BackColor = Color.FromArgb(52, 26, 9);
                                enemyShips[x, y] = true;
                                x++;
                            }
                        }
                        else
                        {
                            shipLength++;
                            continue;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < shipLength; i++)
                        {
                            if (enemyShips[x - i, y] == true)
                            {
                                canPlace = false;
                                break;
                            }
                        }
                        if (canPlace == true)
                        {
                            for (int i = 0; i < shipLength; i++)
                            {
                                if (shipLength == 5) enemyBoard[x, y].Tag = "enFrigate";
                                else if (shipLength == 4) enemyBoard[x, y].Tag = "enCutlass";
                                else if (shipLength == 3) enemyBoard[x, y].Tag = "enBateau";
                                else if (shipLength == 2) enemyBoard[x, y].Tag = "enRowBoat";

                                //enemyBoard[x, y].BackColor = Color.FromArgb(52, 26, 9);
                                enemyShips[x, y] = true;
                                x--;
                            }
                        }
                        else
                        {
                            shipLength++;
                            continue;
                        }
                    }
                }
                else
                {
                    if (y <= shipLength)
                    {
                        for (int i = 0; i < shipLength; i++)
                        {
                            if (enemyShips[x, y + i] == true)
                            {
                                canPlace = false;
                                break;
                            }
                        }
                        if (canPlace == true)
                        {
                            for (int i = 0; i < shipLength; i++)
                            {
                                if (shipLength == 5) enemyBoard[x, y].Tag = "enFrigate";
                                else if (shipLength == 4) enemyBoard[x, y].Tag = "enCutlass";
                                else if (shipLength == 3) enemyBoard[x, y].Tag = "enBateau";
                                else if (shipLength == 2) enemyBoard[x, y].Tag = "enRowBoat";

                                //enemyBoard[x, y].BackColor = Color.FromArgb(52, 26, 9);
                                enemyShips[x, y] = true;
                                y++;
                            }
                        }
                        else
                        {
                            shipLength++;
                            continue;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < shipLength; i++)
                        {
                            if (enemyShips[x, y - i] == true)
                            {
                                canPlace = false;
                                break;
                            }
                        }
                        if (canPlace == true)
                        {
                            for (int i = 0; i < shipLength; i++)
                            {
                                if (shipLength == 5) enemyBoard[x, y].Tag = "enFrigate";
                                else if (shipLength == 4) enemyBoard[x, y].Tag = "enCutlass";
                                else if (shipLength == 3) enemyBoard[x, y].Tag = "enBateau";
                                else if (shipLength == 2) enemyBoard[x, y].Tag = "enRowBoat";

                                //enemyBoard[x, y].BackColor = Color.FromArgb(52, 26, 9);
                                enemyShips[x, y] = true;
                                y--;
                            }
                        }
                        else
                        {
                            shipLength++;
                            continue;
                        }
                    }
                }
            }
        }

        //hits ships
        private void HitShips(object sender, EventArgs e)
        {
            //hits enemy ships
            if (plCounter != 14 && enCounter != 14)
            {
                Button hitPosition = (Button)sender;
                int x = (hitPosition.Top - 265) / 33;
                int y = (hitPosition.Left - 780) / 34;

                if (enemyShips[x, y] == true)
                {
                    enemyBoard[x, y].BackColor = Color.FromArgb(185, 0, 0);

                    if ((string)enemyBoard[x, y].Tag == "enFrigate") enFrigateCounter++;
                    else if ((string)enemyBoard[x, y].Tag == "enCutlass") enCutlassCounter++;
                    else if ((string)enemyBoard[x, y].Tag == "enBateau") enBateauCounter++;
                    else if ((string)enemyBoard[x, y].Tag == "enRowBoat") enRowBoatCounter++;

                    enCounter = enFrigateCounter + enCutlassCounter + enBateauCounter + enRowBoatCounter; 

                    if (enFrigateCounter == 5) enFrigateLbl.Visible = true;
                    if (enCutlassCounter == 4) enCutlassLbl.Visible = true;
                    if (enBateauCounter == 3) enBateauLbl.Visible = true;
                    if (enRowBoatCounter == 2) enRowBoatLbl.Visible = true;

                    if (enCounter == 14)
                    {
                        wins++;
                        winsLbl2.Text = "" + wins;

                        replayButton.Visible = true;
                        outcome.Visible = true;
                        winsLbl.Visible = winsLbl2.Visible = lossesLbl.Visible = lossesLbl2.Visible = true;

                        outcome.Text = "YOU WON!";
                        seconds.Stop();
                    }

                    cannonballCounter--;

                    enemyBoard[x, y].Enabled = false;
                }
                else
                {
                    enemyBoard[x, y].BackColor = Color.FromArgb(5, 165, 149);
                    cannonballCounter--;

                    enemyBoard[x, y].Enabled = false;
                }
            }

            canonballNumber.Text = "x" + cannonballCounter;

            //hits player ships
            if (enCounter != 14 && plCounter != 14)
            {
                var random = new Random();

                for (int i = 0; i < 100; i++)
                {
                    int z = random.Next(0, 10);
                    int w = random.Next(0, 10);

                    if (playerBoard[z, w].BackColor != Color.FromArgb(5, 165, 149) && playerBoard[z, w].BackColor != Color.FromArgb(185, 0, 0))
                    {
                        if (playerShips[z, w] == true)
                        {
                            playerBoard[z, w].BackColor = Color.FromArgb(185, 0, 0);

                            if ((string)playerBoard[z, w].Tag == "plFrigate") plFrigateCounter++;
                            else if ((string)playerBoard[z, w].Tag == "plCutlass") plCutlassCounter++;
                            else if ((string)playerBoard[z, w].Tag == "plBateau") plBateauCounter++;
                            else if ((string)playerBoard[z, w].Tag == "plRowBoat") plRowBoatCounter++;

                            plCounter = plFrigateCounter + plCutlassCounter + plBateauCounter + plRowBoatCounter;

                            if (plFrigateCounter == 5) plFrigateLbl.Visible = true;
                            if (plCutlassCounter == 4) plCutlassLbl.Visible = true;
                            if (plBateauCounter == 3) plBateauLbl.Visible = true;
                            if (plRowBoatCounter == 2) plRowBoatLbl.Visible = true;

                            if (plCounter == 14)
                            {
                                losses++;
                                lossesLbl2.Text = "" + losses;

                                replayButton.Visible = true;
                                outcome.Visible = true;
                                winsLbl.Visible = winsLbl2.Visible = lossesLbl.Visible = lossesLbl2.Visible = true;

                                outcome.Text = "YOU LOST";
                                seconds.Stop();
                            }

                            break;
                        }
                        else
                        {
                            playerBoard[z, w].BackColor = Color.FromArgb(5, 165, 149);
                            break;
                        }
                    }
                    else
                    {
                        i--;
                        continue;
                    }
                }
            }

        }

        //restarts game
        private void Replay(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    playerBoard[i, j].BackColor = enemyBoard[i, j].BackColor = Color.Transparent;
                    playerBoard[i, j].Tag = enemyBoard[i, j].Tag = "";
                    enemyBoard[i, j].Enabled = true;
                }
            }

            plFrigateLbl.Visible = plCutlassLbl.Visible = plBateauLbl.Visible = plRowBoatLbl.Visible = false;
            enFrigateLbl.Visible = enCutlassLbl.Visible = enBateauLbl.Visible = enRowBoatLbl.Visible = false;

            plCounter = plFrigateCounter = plCutlassCounter = plBateauCounter = plRowBoatCounter = 0;
            enCounter = enFrigateCounter = enCutlassCounter = enBateauCounter = enRowBoatCounter = 0;

            secondsPassed = 0;
            label11.Text = "Timer: " + secondsPassed + "\"";

            cannonballCounter = 100;
            canonballNumber.Text = "x" + cannonballCounter;

            playerShips = new bool[10, 10];
            enemyShips = new bool[10, 10];

            PlaceEnemyShips();
            PlacePlayerShips();

            seconds.Start();

            replayButton.Visible = false;
            outcome.Visible = false;
            winsLbl.Visible = winsLbl2.Visible = lossesLbl.Visible = lossesLbl2.Visible = false;
        }
        private void ReplayEnter(object sender, EventArgs e)
        {
            replayButton.ImageLocation = "replay2.png";
        }
        private void ReplayLeave(object sender, EventArgs e)
        {
            replayButton.ImageLocation = "replay.png";
        }

        //closes game
        private void CloseGame(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CloseButtonEnter(object sender, EventArgs e)
        {
            closeButton.ImageLocation = "close2.png";
        }
        private void CloseButtonLeave(object sender, EventArgs e)
        {
            closeButton.ImageLocation = "close.png";
        }

        //timer
        private void TimerTick(object sender, EventArgs e)
        {
            secondsPassed++;
            label11.Text = "Timer: " + secondsPassed + "\"";
        }
    }
}