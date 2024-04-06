namespace Battleship
{
    partial class SettingsScreen
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
            buttonEnglish = new Button();
            buttonGerman = new Button();
            buttonSpanish = new Button();
            buttonMenuScreen = new Button();
            buttonResetHighscore = new Button();
            SuspendLayout();
            // 
            // buttonEnglish
            // 
            buttonEnglish.Font = new Font("Segoe UI", 18F);
            buttonEnglish.Location = new Point(151, 63);
            buttonEnglish.Name = "buttonEnglish";
            buttonEnglish.Size = new Size(160, 62);
            buttonEnglish.TabIndex = 3;
            buttonEnglish.Text = "Englisch";
            buttonEnglish.UseVisualStyleBackColor = true;
            buttonEnglish.Click += buttonEnglish_Click;
            // 
            // buttonGerman
            // 
            buttonGerman.Font = new Font("Segoe UI", 18F);
            buttonGerman.Location = new Point(388, 63);
            buttonGerman.Name = "buttonGerman";
            buttonGerman.Size = new Size(160, 62);
            buttonGerman.TabIndex = 4;
            buttonGerman.Text = "Deutsch";
            buttonGerman.UseVisualStyleBackColor = true;
            buttonGerman.Click += buttonGerman_Click;
            // 
            // buttonSpanish
            // 
            buttonSpanish.Font = new Font("Segoe UI", 18F);
            buttonSpanish.Location = new Point(627, 63);
            buttonSpanish.Name = "buttonSpanish";
            buttonSpanish.Size = new Size(160, 62);
            buttonSpanish.TabIndex = 5;
            buttonSpanish.Text = "Spanisch";
            buttonSpanish.UseVisualStyleBackColor = true;
            buttonSpanish.Click += buttonSpanish_Click;
            // 
            // buttonMenuScreen
            // 
            buttonMenuScreen.Font = new Font("Segoe UI", 18F);
            buttonMenuScreen.Location = new Point(365, 417);
            buttonMenuScreen.Name = "buttonMenuScreen";
            buttonMenuScreen.Size = new Size(197, 62);
            buttonMenuScreen.TabIndex = 7;
            buttonMenuScreen.Text = "Hauptmenü";
            buttonMenuScreen.UseVisualStyleBackColor = true;
            buttonMenuScreen.Click += buttonMenuScreen_Click;
            // 
            // buttonResetHighscore
            // 
            buttonResetHighscore.Font = new Font("Segoe UI", 18F);
            buttonResetHighscore.Location = new Point(239, 165);
            buttonResetHighscore.Name = "buttonResetHighscore";
            buttonResetHighscore.Size = new Size(464, 62);
            buttonResetHighscore.TabIndex = 8;
            buttonResetHighscore.Text = "High-Score-Liste löschen";
            buttonResetHighscore.UseVisualStyleBackColor = true;
            buttonResetHighscore.Click += buttonResetHighscore_Click;
            // 
            // SettingsScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BGdefault;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(933, 501);
            Controls.Add(buttonResetHighscore);
            Controls.Add(buttonMenuScreen);
            Controls.Add(buttonEnglish);
            Controls.Add(buttonGerman);
            Controls.Add(buttonSpanish);
            Name = "SettingsScreen";
            Text = "SettingsScreen";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonEnglish;
        private Button buttonGerman;
        private Button buttonSpanish;
        private Button buttonMenuScreen;
        private Button buttonResetHighscore;
    }
}