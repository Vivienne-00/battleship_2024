namespace Battleship {
    partial class GameScreen {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelEnemy = new Label();
            SuspendLayout();
            // 
            // labelEnemy
            // 
            labelEnemy.AutoSize = true;
            labelEnemy.BackColor = Color.Transparent;
            labelEnemy.Font = new Font("Segoe UI", 16F);
            labelEnemy.Location = new Point(577, 9);
            labelEnemy.Name = "labelEnemy";
            labelEnemy.Size = new Size(104, 37);
            labelEnemy.TabIndex = 16;
            labelEnemy.Text = "Gegner";
            // 
            // GameScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BGdefault;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1253, 847);
            Controls.Add(labelEnemy);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GameScreen";
            Text = "BattleShipVM GameScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEnemy;
    }
}
