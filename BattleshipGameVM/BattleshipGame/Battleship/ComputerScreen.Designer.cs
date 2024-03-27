namespace Battleship
{
    partial class ComputerScreen
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
            buttonEasy = new Button();
            buttonNormal = new Button();
            buttonDifficult = new Button();
            labelDifficulty = new Label();
            SuspendLayout();
            // 
            // buttonEasy
            // 
            buttonEasy.BackColor = Color.FromArgb(180, 210, 255);
            buttonEasy.FlatAppearance.BorderColor = Color.FromArgb(180, 210, 255);
            buttonEasy.Font = new Font("Segoe UI", 18F);
            buttonEasy.Location = new Point(353, 210);
            buttonEasy.Name = "buttonEasy";
            buttonEasy.Size = new Size(255, 64);
            buttonEasy.TabIndex = 6;
            buttonEasy.Text = "Einfach";
            buttonEasy.UseVisualStyleBackColor = false;
            buttonEasy.Click += buttonEasy_Click;
            // 
            // buttonNormal
            // 
            buttonNormal.BackColor = Color.FromArgb(180, 210, 255);
            buttonNormal.FlatAppearance.BorderColor = Color.FromArgb(180, 210, 255);
            buttonNormal.Font = new Font("Segoe UI", 18F);
            buttonNormal.Location = new Point(353, 302);
            buttonNormal.Name = "buttonNormal";
            buttonNormal.Size = new Size(255, 64);
            buttonNormal.TabIndex = 7;
            buttonNormal.Text = "Mittel";
            buttonNormal.UseVisualStyleBackColor = false;
            buttonNormal.Click += buttonNormal_Click;
            // 
            // buttonDifficult
            // 
            buttonDifficult.BackColor = Color.FromArgb(180, 210, 255);
            buttonDifficult.FlatAppearance.BorderColor = Color.FromArgb(180, 210, 255);
            buttonDifficult.Font = new Font("Segoe UI", 18F);
            buttonDifficult.Location = new Point(353, 393);
            buttonDifficult.Name = "buttonDifficult";
            buttonDifficult.Size = new Size(255, 64);
            buttonDifficult.TabIndex = 8;
            buttonDifficult.Text = "Schwierig";
            buttonDifficult.UseVisualStyleBackColor = false;
            buttonDifficult.Click += buttonDifficult_Click;
            // 
            // labelDifficulty
            // 
            labelDifficulty.AutoSize = true;
            labelDifficulty.BackColor = Color.Transparent;
            labelDifficulty.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDifficulty.Location = new Point(315, 121);
            labelDifficulty.Name = "labelDifficulty";
            labelDifficulty.Size = new Size(330, 46);
            labelDifficulty.TabIndex = 9;
            labelDifficulty.Text = "Schwierigkeitsstufe";
            labelDifficulty.Click += labelGameBoardSize_Click;
            // 
            // ComputerScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BGdefault;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(951, 548);
            Controls.Add(labelDifficulty);
            Controls.Add(buttonDifficult);
            Controls.Add(buttonNormal);
            Controls.Add(buttonEasy);
            Name = "ComputerScreen";
            Text = "ComputerScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEasy;
        private Button buttonNormal;
        private Button buttonDifficult;
        private Label labelDifficulty;
    }
}