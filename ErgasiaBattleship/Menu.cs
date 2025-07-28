using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Media;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ErgasiaBattleship
{
    public partial class Menu : Form
    {
        Events events = new Events();

        PictureBox startButton = new PictureBox();
        PictureBox rulesButton = new PictureBox();
        PictureBox closeButton = new PictureBox();

        SoundPlayer beach = new SoundPlayer("beach.wav");

        int seconds = 0;

        public Menu()
        {
            InitializeComponent();
            beach.Play();

            StartButton();
            CloseButton();
            RulesButton();

            startButton.Click += events.OpenGame;
            rulesButton.Click += events.OpenRules;
        }


        //starts game
        private void StartButton()
        {
            startButton.BackColor = Color.Transparent;
            startButton.Size = new Size(117, 65);
            startButton.Location = new Point(175, 335);
            startButton.ImageLocation = "play.png";
            startButton.SizeMode = PictureBoxSizeMode.StretchImage;

            startButton.MouseEnter += new EventHandler(StartButtonEnter);
            startButton.MouseLeave += new EventHandler(StartButtonLeave);

            this.Controls.Add(startButton);
        }
        private void StartButtonEnter(object sender, EventArgs e)
        {
            startButton.ImageLocation = "play2.png";
        }
        private void StartButtonLeave(object sender, EventArgs e)
        {
            startButton.ImageLocation = "play.png";
        }


        //shows rules
        private void RulesButton()
        {
            rulesButton.BackColor = Color.Transparent;
            rulesButton.Size = new Size(90, 31);
            rulesButton.Location = new Point(188, 305);
            rulesButton.ImageLocation = "rules.png";
            rulesButton.SizeMode = PictureBoxSizeMode.StretchImage;

            rulesButton.MouseEnter += new EventHandler(RulesButtonEnter);
            rulesButton.MouseLeave += new EventHandler(RulesButtonLeave);

            this.Controls.Add(rulesButton);
        }
        private void RulesButtonEnter(object sender, EventArgs e)
        {
            rulesButton.ImageLocation = "rules2.png";
        }
        private void RulesButtonLeave(object sender, EventArgs e)
        {
            rulesButton.ImageLocation = "rules.png";
        }


        //closes menu
        private void CloseButton()
        {
            closeButton.BackColor = Color.Transparent;
            closeButton.Size = new Size(24, 24);
            closeButton.Location = new Point(455, 0);
            closeButton.ImageLocation = "close.png";
            closeButton.SizeMode = PictureBoxSizeMode.StretchImage;

            closeButton.MouseEnter += new EventHandler(CloseButtonEnter);
            closeButton.MouseLeave += new EventHandler(CloseButtonLeave);
            closeButton.Click += new EventHandler(CloseButtonClick);

            this.Controls.Add(closeButton);
        }
        private void CloseButtonEnter(object sender, EventArgs e)
        {
            closeButton.ImageLocation = "close2.png";
        }
        private void CloseButtonLeave(object sender, EventArgs e)
        {
            closeButton.ImageLocation = "close.png";
        }
        public void CloseButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        //replays beach
        private void BeachTimerTick(object sender, EventArgs e)
        {
            seconds++;

            if(seconds % 115 == 0)
            {
                beach.Play();
            }
        }
    }

    class Events
    {
        public void OpenGame(object sender, EventArgs e)
        {
            BattleShips game = new BattleShips();
            game.Show();
        }

        public void OpenRules(object sender, EventArgs e)
        {
            Rules rules = new Rules();
            rules.StartPosition = FormStartPosition.Manual;
            rules.Location = new Point(700, 0);
            rules.Show();
        }
    }
}
