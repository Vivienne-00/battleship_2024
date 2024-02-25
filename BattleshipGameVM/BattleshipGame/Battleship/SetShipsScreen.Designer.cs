namespace Battleship
{
    partial class SetShipsScreen
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
            buttonStartGame = new Button();
            buttonQuitGame = new Button();
            buttonBattleship = new Button();
            buttonDestroyer = new Button();
            buttonCruiser = new Button();
            buttonSubmarine = new Button();
            button4 = new Button();
            button1 = new Button();
            labelSetShips = new Label();
            SuspendLayout();
            // 
            // buttonStartGame
            // 
            buttonStartGame.BackColor = Color.FromArgb(180, 210, 255);
            buttonStartGame.FlatAppearance.BorderColor = Color.FromArgb(180, 210, 255);
            buttonStartGame.Font = new Font("Segoe UI", 17F);
            buttonStartGame.Location = new Point(681, 21);
            buttonStartGame.Name = "buttonStartGame";
            buttonStartGame.Size = new Size(172, 55);
            buttonStartGame.TabIndex = 6;
            buttonStartGame.Text = "Start";
            buttonStartGame.UseVisualStyleBackColor = false;
            buttonStartGame.Click += buttonStartGame_Click;
            // 
            // buttonQuitGame
            // 
            buttonQuitGame.BackColor = Color.FromArgb(180, 210, 255);
            buttonQuitGame.FlatAppearance.BorderColor = Color.FromArgb(180, 210, 255);
            buttonQuitGame.Font = new Font("Segoe UI", 17F);
            buttonQuitGame.Location = new Point(681, 475);
            buttonQuitGame.Name = "buttonQuitGame";
            buttonQuitGame.Size = new Size(172, 55);
            buttonQuitGame.TabIndex = 7;
            buttonQuitGame.Text = "Beenden";
            buttonQuitGame.UseVisualStyleBackColor = false;
            buttonQuitGame.Click += buttonQuitGame_Click;
            // 
            // buttonBattleship
            // 
            buttonBattleship.BackColor = Color.Gray;
            buttonBattleship.Location = new Point(682, 169);
            buttonBattleship.Name = "buttonBattleship";
            buttonBattleship.Size = new Size(35, 175);
            buttonBattleship.TabIndex = 8;
            buttonBattleship.UseVisualStyleBackColor = false;
            buttonBattleship.Click += buttonBattleship_Click;
            // 
            // buttonDestroyer
            // 
            buttonDestroyer.BackColor = Color.Gray;
            buttonDestroyer.Location = new Point(810, 169);
            buttonDestroyer.Name = "buttonDestroyer";
            buttonDestroyer.Size = new Size(35, 105);
            buttonDestroyer.TabIndex = 9;
            buttonDestroyer.UseVisualStyleBackColor = false;
            buttonDestroyer.Click += buttonDestroyer_Click;
            // 
            // buttonCruiser
            // 
            buttonCruiser.BackColor = Color.Gray;
            buttonCruiser.Location = new Point(746, 169);
            buttonCruiser.Name = "buttonCruiser";
            buttonCruiser.Size = new Size(35, 140);
            buttonCruiser.TabIndex = 13;
            buttonCruiser.UseVisualStyleBackColor = false;
            buttonCruiser.Click += buttonCruiser_Click_1;
            // 
            // buttonSubmarine
            // 
            buttonSubmarine.BackColor = Color.Gray;
            buttonSubmarine.Location = new Point(683, 376);
            buttonSubmarine.Name = "buttonSubmarine";
            buttonSubmarine.Size = new Size(35, 70);
            buttonSubmarine.TabIndex = 10;
            buttonSubmarine.UseVisualStyleBackColor = false;
            buttonSubmarine.Click += buttonSubmarine_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.rotate;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI", 30F);
            button1.Location = new Point(803, 396);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 14;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelSetShips
            // 
            labelSetShips.AutoSize = true;
            labelSetShips.BackColor = Color.Transparent;
            labelSetShips.Font = new Font("Segoe UI", 16F);
            labelSetShips.Location = new Point(424, 92);
            labelSetShips.Name = "labelSetShips";
            labelSetShips.Size = new Size(421, 37);
            labelSetShips.TabIndex = 15;
            labelSetShips.Text = "Bitte setze alle Schiffe auf das Feld";
            labelSetShips.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SetShipsScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(labelSetShips);
            Controls.Add(button1);
            Controls.Add(buttonCruiser);
            Controls.Add(buttonSubmarine);
            Controls.Add(buttonDestroyer);
            Controls.Add(buttonBattleship);
            Controls.Add(buttonQuitGame);
            Controls.Add(buttonStartGame);
            Name = "SetShipsScreen";
            Text = "SetShipsScreen";
            Load += SetShipsScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStartGame;
        private Button buttonQuitGame;
        private Button buttonBattleship;
        private Button buttonDestroyer;
        private Button buttonSubmarine;
        private Button button4;
        private Button buttonCruiser;
        private Button button1;
        private Label labelSetShips;
    }
}