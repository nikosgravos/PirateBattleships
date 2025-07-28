namespace ErgasiaBattleship
{
    partial class BattleShips
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleShips));
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cannonball = new System.Windows.Forms.PictureBox();
            this.canonballNumber = new System.Windows.Forms.Label();
            this.seconds = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.plCutlassLbl = new System.Windows.Forms.Label();
            this.plRowBoatLbl = new System.Windows.Forms.Label();
            this.plFrigateLbl = new System.Windows.Forms.Label();
            this.plBateauLbl = new System.Windows.Forms.Label();
            this.enCutlassLbl = new System.Windows.Forms.Label();
            this.enFrigateLbl = new System.Windows.Forms.Label();
            this.enRowBoatLbl = new System.Windows.Forms.Label();
            this.enBateauLbl = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.replayButton = new System.Windows.Forms.PictureBox();
            this.outcome = new System.Windows.Forms.Label();
            this.winsLbl = new System.Windows.Forms.Label();
            this.lossesLbl = new System.Windows.Forms.Label();
            this.winsLbl2 = new System.Windows.Forms.Label();
            this.lossesLbl2 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cannonball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(468, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Cannonballs Left:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(248, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // cannonball
            // 
            this.cannonball.BackColor = System.Drawing.Color.Transparent;
            this.cannonball.Image = ((System.Drawing.Image)(resources.GetObject("cannonball.Image")));
            this.cannonball.Location = new System.Drawing.Point(625, 101);
            this.cannonball.Name = "cannonball";
            this.cannonball.Size = new System.Drawing.Size(40, 40);
            this.cannonball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cannonball.TabIndex = 4;
            this.cannonball.TabStop = false;
            // 
            // canonballNumber
            // 
            this.canonballNumber.AutoSize = true;
            this.canonballNumber.BackColor = System.Drawing.Color.Transparent;
            this.canonballNumber.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canonballNumber.ForeColor = System.Drawing.Color.Black;
            this.canonballNumber.Location = new System.Drawing.Point(663, 111);
            this.canonballNumber.Name = "canonballNumber";
            this.canonballNumber.Size = new System.Drawing.Size(57, 18);
            this.canonballNumber.TabIndex = 2;
            this.canonballNumber.Text = "x 100";
            // 
            // seconds
            // 
            this.seconds.Enabled = true;
            this.seconds.Interval = 1000;
            this.seconds.Tick += new System.EventHandler(this.TimerTick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Timer: 0\"";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(224, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "Your Sinked Ships";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(913, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(249, 25);
            this.label13.TabIndex = 6;
            this.label13.Text = "Enemy Sinked Ships";
            // 
            // plCutlassLbl
            // 
            this.plCutlassLbl.AutoSize = true;
            this.plCutlassLbl.BackColor = System.Drawing.Color.Transparent;
            this.plCutlassLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plCutlassLbl.Location = new System.Drawing.Point(29, 89);
            this.plCutlassLbl.Name = "plCutlassLbl";
            this.plCutlassLbl.Size = new System.Drawing.Size(85, 18);
            this.plCutlassLbl.TabIndex = 6;
            this.plCutlassLbl.Text = "CUTLASS";
            this.plCutlassLbl.Visible = false;
            // 
            // plRowBoatLbl
            // 
            this.plRowBoatLbl.AutoSize = true;
            this.plRowBoatLbl.BackColor = System.Drawing.Color.Transparent;
            this.plRowBoatLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plRowBoatLbl.Location = new System.Drawing.Point(29, 139);
            this.plRowBoatLbl.Name = "plRowBoatLbl";
            this.plRowBoatLbl.Size = new System.Drawing.Size(100, 18);
            this.plRowBoatLbl.TabIndex = 6;
            this.plRowBoatLbl.Text = "ROW BOAT";
            this.plRowBoatLbl.Visible = false;
            // 
            // plFrigateLbl
            // 
            this.plFrigateLbl.AutoSize = true;
            this.plFrigateLbl.BackColor = System.Drawing.Color.Transparent;
            this.plFrigateLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plFrigateLbl.Location = new System.Drawing.Point(31, 64);
            this.plFrigateLbl.Name = "plFrigateLbl";
            this.plFrigateLbl.Size = new System.Drawing.Size(82, 18);
            this.plFrigateLbl.TabIndex = 6;
            this.plFrigateLbl.Text = "FRIGATE";
            this.plFrigateLbl.Visible = false;
            // 
            // plBateauLbl
            // 
            this.plBateauLbl.AutoSize = true;
            this.plBateauLbl.BackColor = System.Drawing.Color.Transparent;
            this.plBateauLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plBateauLbl.Location = new System.Drawing.Point(29, 114);
            this.plBateauLbl.Name = "plBateauLbl";
            this.plBateauLbl.Size = new System.Drawing.Size(75, 18);
            this.plBateauLbl.TabIndex = 6;
            this.plBateauLbl.Text = "BATEAU";
            this.plBateauLbl.Visible = false;
            // 
            // enCutlassLbl
            // 
            this.enCutlassLbl.AutoSize = true;
            this.enCutlassLbl.BackColor = System.Drawing.Color.Transparent;
            this.enCutlassLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enCutlassLbl.Location = new System.Drawing.Point(1055, 89);
            this.enCutlassLbl.Name = "enCutlassLbl";
            this.enCutlassLbl.Size = new System.Drawing.Size(85, 18);
            this.enCutlassLbl.TabIndex = 6;
            this.enCutlassLbl.Text = "CUTLASS";
            this.enCutlassLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.enCutlassLbl.Visible = false;
            // 
            // enFrigateLbl
            // 
            this.enFrigateLbl.AutoSize = true;
            this.enFrigateLbl.BackColor = System.Drawing.Color.Transparent;
            this.enFrigateLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enFrigateLbl.Location = new System.Drawing.Point(1058, 64);
            this.enFrigateLbl.Name = "enFrigateLbl";
            this.enFrigateLbl.Size = new System.Drawing.Size(82, 18);
            this.enFrigateLbl.TabIndex = 6;
            this.enFrigateLbl.Text = "FRIGATE";
            this.enFrigateLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.enFrigateLbl.Visible = false;
            // 
            // enRowBoatLbl
            // 
            this.enRowBoatLbl.AutoSize = true;
            this.enRowBoatLbl.BackColor = System.Drawing.Color.Transparent;
            this.enRowBoatLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enRowBoatLbl.Location = new System.Drawing.Point(1042, 139);
            this.enRowBoatLbl.Name = "enRowBoatLbl";
            this.enRowBoatLbl.Size = new System.Drawing.Size(100, 18);
            this.enRowBoatLbl.TabIndex = 6;
            this.enRowBoatLbl.Text = "ROW BOAT";
            this.enRowBoatLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.enRowBoatLbl.Visible = false;
            // 
            // enBateauLbl
            // 
            this.enBateauLbl.AutoSize = true;
            this.enBateauLbl.BackColor = System.Drawing.Color.Transparent;
            this.enBateauLbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enBateauLbl.Location = new System.Drawing.Point(1065, 114);
            this.enBateauLbl.Name = "enBateauLbl";
            this.enBateauLbl.Size = new System.Drawing.Size(75, 18);
            this.enBateauLbl.TabIndex = 6;
            this.enBateauLbl.Text = "BATEAU";
            this.enBateauLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.enBateauLbl.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 18);
            this.label14.TabIndex = 6;
            this.label14.Text = "•";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 18);
            this.label15.TabIndex = 6;
            this.label15.Text = "•";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(17, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 18);
            this.label16.TabIndex = 6;
            this.label16.Text = "•";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(17, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 18);
            this.label17.TabIndex = 6;
            this.label17.Text = "•";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1136, 89);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 18);
            this.label18.TabIndex = 6;
            this.label18.Text = "•";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1136, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 18);
            this.label19.TabIndex = 6;
            this.label19.Text = "•";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(1136, 139);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 18);
            this.label20.TabIndex = 6;
            this.label20.Text = "•";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(1136, 114);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(19, 18);
            this.label21.TabIndex = 6;
            this.label21.Text = "•";
            // 
            // replayButton
            // 
            this.replayButton.BackColor = System.Drawing.Color.Transparent;
            this.replayButton.Image = ((System.Drawing.Image)(resources.GetObject("replayButton.Image")));
            this.replayButton.Location = new System.Drawing.Point(488, 477);
            this.replayButton.Name = "replayButton";
            this.replayButton.Size = new System.Drawing.Size(200, 78);
            this.replayButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.replayButton.TabIndex = 7;
            this.replayButton.TabStop = false;
            this.replayButton.Visible = false;
            this.replayButton.Click += new System.EventHandler(this.Replay);
            this.replayButton.MouseEnter += new System.EventHandler(this.ReplayEnter);
            this.replayButton.MouseLeave += new System.EventHandler(this.ReplayLeave);
            // 
            // outcome
            // 
            this.outcome.BackColor = System.Drawing.Color.Transparent;
            this.outcome.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outcome.Location = new System.Drawing.Point(488, 558);
            this.outcome.Name = "outcome";
            this.outcome.Size = new System.Drawing.Size(200, 31);
            this.outcome.TabIndex = 8;
            this.outcome.Text = "YOU LOST!";
            this.outcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outcome.Visible = false;
            // 
            // winsLbl
            // 
            this.winsLbl.BackColor = System.Drawing.Color.Transparent;
            this.winsLbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winsLbl.Location = new System.Drawing.Point(491, 441);
            this.winsLbl.Name = "winsLbl";
            this.winsLbl.Size = new System.Drawing.Size(67, 18);
            this.winsLbl.TabIndex = 8;
            this.winsLbl.Text = "WINS";
            this.winsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winsLbl.Visible = false;
            // 
            // lossesLbl
            // 
            this.lossesLbl.BackColor = System.Drawing.Color.Transparent;
            this.lossesLbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossesLbl.Location = new System.Drawing.Point(599, 441);
            this.lossesLbl.Name = "lossesLbl";
            this.lossesLbl.Size = new System.Drawing.Size(89, 18);
            this.lossesLbl.TabIndex = 8;
            this.lossesLbl.Text = "LOSSES";
            this.lossesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lossesLbl.Visible = false;
            // 
            // winsLbl2
            // 
            this.winsLbl2.BackColor = System.Drawing.Color.Transparent;
            this.winsLbl2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winsLbl2.Location = new System.Drawing.Point(491, 459);
            this.winsLbl2.Name = "winsLbl2";
            this.winsLbl2.Size = new System.Drawing.Size(67, 18);
            this.winsLbl2.TabIndex = 8;
            this.winsLbl2.Text = "0";
            this.winsLbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winsLbl2.Visible = false;
            // 
            // lossesLbl2
            // 
            this.lossesLbl2.BackColor = System.Drawing.Color.Transparent;
            this.lossesLbl2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossesLbl2.Location = new System.Drawing.Point(599, 459);
            this.lossesLbl2.Name = "lossesLbl2";
            this.lossesLbl2.Size = new System.Drawing.Size(89, 18);
            this.lossesLbl2.TabIndex = 8;
            this.lossesLbl2.Text = "0";
            this.lossesLbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lossesLbl2.Visible = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(1148, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 24);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 9;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.CloseGame);
            this.closeButton.MouseEnter += new System.EventHandler(this.CloseButtonEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.CloseButtonLeave);
            // 
            // BattleShips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1174, 641);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.replayButton);
            this.Controls.Add(this.plBateauLbl);
            this.Controls.Add(this.plRowBoatLbl);
            this.Controls.Add(this.plFrigateLbl);
            this.Controls.Add(this.plCutlassLbl);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.enBateauLbl);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.enRowBoatLbl);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.enFrigateLbl);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.enCutlassLbl);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cannonball);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.canonballNumber);
            this.Controls.Add(this.lossesLbl2);
            this.Controls.Add(this.lossesLbl);
            this.Controls.Add(this.winsLbl2);
            this.Controls.Add(this.winsLbl);
            this.Controls.Add(this.outcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BattleShips";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BattleShips";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cannonball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox cannonball;
        private System.Windows.Forms.Label canonballNumber;
        private System.Windows.Forms.Timer seconds;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label plCutlassLbl;
        private System.Windows.Forms.Label plRowBoatLbl;
        private System.Windows.Forms.Label plFrigateLbl;
        private System.Windows.Forms.Label plBateauLbl;
        private System.Windows.Forms.Label enCutlassLbl;
        private System.Windows.Forms.Label enFrigateLbl;
        private System.Windows.Forms.Label enRowBoatLbl;
        private System.Windows.Forms.Label enBateauLbl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox replayButton;
        private System.Windows.Forms.Label outcome;
        private System.Windows.Forms.Label winsLbl;
        private System.Windows.Forms.Label lossesLbl;
        private System.Windows.Forms.Label winsLbl2;
        private System.Windows.Forms.Label lossesLbl2;
        private System.Windows.Forms.PictureBox closeButton;
    }
}

