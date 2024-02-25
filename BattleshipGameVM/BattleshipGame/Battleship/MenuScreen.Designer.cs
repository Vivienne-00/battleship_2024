namespace Battleship
{
    partial class MenuScreen
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
            buttonGameModeHuman = new Button();
            buttonGameModeComputer = new Button();
            labelGameMode = new Label();
            buttonSettings = new Button();
            LblUserName = new Label();
            label2 = new Label();
            LblHighscore = new Label();
            SuspendLayout();
            // 
            // buttonGameModeHuman
            // 
            buttonGameModeHuman.BackColor = Color.FromArgb(180, 210, 255);
            buttonGameModeHuman.FlatAppearance.BorderColor = Color.FromArgb(180, 210, 255);
            buttonGameModeHuman.Font = new Font("Segoe UI", 20F);
            buttonGameModeHuman.Location = new Point(336, 276);
            buttonGameModeHuman.Name = "buttonGameModeHuman";
            buttonGameModeHuman.Size = new Size(275, 85);
            buttonGameModeHuman.TabIndex = 5;
            buttonGameModeHuman.Text = "Mensch";
            buttonGameModeHuman.UseVisualStyleBackColor = false;
            buttonGameModeHuman.Click += buttonGameModeHuman_Click;
            // 
            // buttonGameModeComputer
            // 
            buttonGameModeComputer.BackColor = Color.FromArgb(180, 210, 255);
            buttonGameModeComputer.FlatAppearance.BorderColor = Color.FromArgb(180, 210, 255);
            buttonGameModeComputer.Font = new Font("Segoe UI", 20F);
            buttonGameModeComputer.Location = new Point(336, 395);
            buttonGameModeComputer.Name = "buttonGameModeComputer";
            buttonGameModeComputer.Size = new Size(275, 85);
            buttonGameModeComputer.TabIndex = 6;
            buttonGameModeComputer.Text = "Computer";
            buttonGameModeComputer.UseVisualStyleBackColor = false;
            buttonGameModeComputer.Click += buttonGameModeComputer_Click;
            // 
            // labelGameMode
            // 
            labelGameMode.AutoSize = true;
            labelGameMode.Font = new Font("Segoe UI", 20F);
            labelGameMode.Location = new Point(378, 209);
            labelGameMode.Name = "labelGameMode";
            labelGameMode.Size = new Size(194, 46);
            labelGameMode.TabIndex = 7;
            labelGameMode.Text = "Spielmodus";
            // 
            // buttonSettings
            // 
            buttonSettings.BackgroundImage = Properties.Resources.zahnrad;
            buttonSettings.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSettings.Location = new Point(831, 12);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(95, 95);
            buttonSettings.TabIndex = 8;
            buttonSettings.UseVisualStyleBackColor = true;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // LblUserName
            // 
            LblUserName.AutoSize = true;
            LblUserName.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblUserName.Location = new Point(32, 18);
            LblUserName.Name = "LblUserName";
            LblUserName.Size = new Size(142, 60);
            LblUserName.TabIndex = 9;
            LblUserName.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 87);
            label2.Name = "label2";
            label2.Size = new Size(231, 60);
            label2.TabIndex = 10;
            label2.Text = "Highscore:";
            // 
            // LblHighscore
            // 
            LblHighscore.AutoSize = true;
            LblHighscore.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblHighscore.Location = new Point(269, 87);
            LblHighscore.Name = "LblHighscore";
            LblHighscore.Size = new Size(49, 60);
            LblHighscore.TabIndex = 11;
            LblHighscore.Text = "  ";
            // 
            // MenuScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 548);
            Controls.Add(LblHighscore);
            Controls.Add(label2);
            Controls.Add(LblUserName);
            Controls.Add(buttonSettings);
            Controls.Add(labelGameMode);
            Controls.Add(buttonGameModeComputer);
            Controls.Add(buttonGameModeHuman);
            Name = "MenuScreen";
            Text = "MenuScreen";
            Load += MenuScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGameModeHuman;
        private Button buttonGameModeComputer;
        private Label labelGameMode;
        private Button buttonSettings;
        private Label LblUserName;
        private Label label2;
        private Label LblHighscore;
    }
}