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
            // SetShipsScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 553);
            Controls.Add(buttonQuitGame);
            Controls.Add(buttonStartGame);
            Name = "SetShipsScreen";
            Text = "SetShipsScreen";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStartGame;
        private Button buttonQuitGame;
    }
}