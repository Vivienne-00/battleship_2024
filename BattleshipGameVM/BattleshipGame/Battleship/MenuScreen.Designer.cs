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
            labelGameMode.Click += labelGameMode_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.Location = new Point(831, 12);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(95, 95);
            buttonSettings.TabIndex = 8;
            buttonSettings.UseVisualStyleBackColor = true;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // MenuScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 548);
            Controls.Add(buttonSettings);
            Controls.Add(labelGameMode);
            Controls.Add(buttonGameModeComputer);
            Controls.Add(buttonGameModeHuman);
            Name = "MenuScreen";
            Text = "MenuScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGameModeHuman;
        private Button buttonGameModeComputer;
        private Label labelGameMode;
        private Button buttonSettings;
    }
}