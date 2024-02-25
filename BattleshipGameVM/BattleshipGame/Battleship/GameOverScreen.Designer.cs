namespace Battleship
{
    partial class GameOverScreen
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
            labelVictory = new Label();
            labelDefeat = new Label();
            buttonNewGame = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // labelVictory
            // 
            labelVictory.AutoSize = true;
            labelVictory.Font = new Font("Segoe UI", 40F);
            labelVictory.Location = new Point(374, 166);
            labelVictory.Name = "labelVictory";
            labelVictory.Size = new Size(164, 89);
            labelVictory.TabIndex = 2;
            labelVictory.Text = "Sieg";
            // 
            // labelDefeat
            // 
            labelDefeat.AutoSize = true;
            labelDefeat.Font = new Font("Segoe UI", 40F);
            labelDefeat.Location = new Point(277, 181);
            labelDefeat.Name = "labelDefeat";
            labelDefeat.Size = new Size(360, 89);
            labelDefeat.TabIndex = 3;
            labelDefeat.Text = "Niederlage";
            // 
            // buttonNewGame
            // 
            buttonNewGame.BackColor = Color.FromArgb(180, 210, 255);
            buttonNewGame.FlatAppearance.BorderColor = Color.FromArgb(180, 210, 255);
            buttonNewGame.Font = new Font("Segoe UI", 18F);
            buttonNewGame.Location = new Point(355, 311);
            buttonNewGame.Name = "buttonNewGame";
            buttonNewGame.Size = new Size(195, 64);
            buttonNewGame.TabIndex = 5;
            buttonNewGame.Text = "Neues Spiel";
            buttonNewGame.UseVisualStyleBackColor = false;
            buttonNewGame.Click += buttonNewGame_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(180, 210, 255);
            buttonExit.FlatAppearance.BorderColor = Color.FromArgb(180, 210, 255);
            buttonExit.Font = new Font("Segoe UI", 18F);
            buttonExit.Location = new Point(355, 391);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(195, 64);
            buttonExit.TabIndex = 6;
            buttonExit.Text = "Beenden";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // GameOverScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 548);
            Controls.Add(buttonExit);
            Controls.Add(buttonNewGame);
            Controls.Add(labelDefeat);
            Controls.Add(labelVictory);
            Name = "GameOverScreen";
            Text = "GameOverScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelVictory;
        private Label labelDefeat;
        private Button buttonNewGame;
        private Button buttonExit;
    }
}