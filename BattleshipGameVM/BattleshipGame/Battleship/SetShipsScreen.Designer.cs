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
            buttonCruiser = new Button();
            buttonDestroyer = new Button();
            buttonSubmarine = new Button();
            button4 = new Button();
            button5 = new Button();
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
            // ButtonBattleship
            // 
            buttonBattleship.BackColor = Color.Gray;
            buttonBattleship.Location = new Point(682, 151);
            buttonBattleship.Name = "ButtonBattleship";
            buttonBattleship.Size = new Size(35, 175);
            buttonBattleship.TabIndex = 8;
            buttonBattleship.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            buttonCruiser.BackColor = Color.Gray;
            buttonCruiser.Location = new Point(810, 151);
            buttonCruiser.Name = "button1";
            buttonCruiser.Size = new Size(35, 105);
            buttonCruiser.TabIndex = 9;
            buttonCruiser.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            buttonDestroyer.BackColor = Color.Gray;
            buttonDestroyer.Location = new Point(683, 358);
            buttonDestroyer.Name = "button2";
            buttonDestroyer.Size = new Size(35, 70);
            buttonDestroyer.TabIndex = 10;
            buttonDestroyer.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            buttonSubmarine.BackColor = Color.Gray;
            buttonSubmarine.Location = new Point(810, 325);
            buttonSubmarine.Name = "button3";
            buttonSubmarine.Size = new Size(0, 0);
            buttonSubmarine.TabIndex = 11;
            buttonSubmarine.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.Location = new Point(683, 342);
            button4.Name = "button4";
            button4.Size = new Size(0, 0);
            button4.TabIndex = 12;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Gray;
            button5.Location = new Point(746, 151);
            button5.Name = "button5";
            button5.Size = new Size(35, 140);
            button5.TabIndex = 13;
            button5.UseVisualStyleBackColor = false;
            // 
            // SetShipsScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 553);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(buttonDestroyer);
            Controls.Add(buttonCruiser);
            Controls.Add(buttonBattleship);
            Controls.Add(buttonQuitGame);
            Controls.Add(buttonStartGame);
            Name = "SetShipsScreen";
            Text = "SetShipsScreen";
            Load += SetShipsScreen_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStartGame;
        private Button buttonQuitGame;
        private Button buttonBattleship;
        private Button buttonCruiser;
        private Button buttonDestroyer;
        private Button buttonSubmarine;
        private Button button4;
        private Button button5;
    }
}