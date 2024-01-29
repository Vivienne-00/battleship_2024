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
            buttonJapanese = new Button();
            SuspendLayout();
            // 
            // buttonEnglish
            // 
            buttonEnglish.Font = new Font("Segoe UI", 18F);
            buttonEnglish.Location = new Point(29, 74);
            buttonEnglish.Name = "buttonEnglish";
            buttonEnglish.Size = new Size(160, 62);
            buttonEnglish.TabIndex = 3;
            buttonEnglish.Text = "Englisch";
            buttonEnglish.UseVisualStyleBackColor = true;
            // 
            // buttonGerman
            // 
            buttonGerman.Font = new Font("Segoe UI", 18F);
            buttonGerman.Location = new Point(263, 74);
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
            buttonSpanish.Location = new Point(505, 74);
            buttonSpanish.Name = "buttonSpanish";
            buttonSpanish.Size = new Size(160, 62);
            buttonSpanish.TabIndex = 5;
            buttonSpanish.Text = "Spanisch";
            buttonSpanish.UseVisualStyleBackColor = true;
            buttonSpanish.Click += buttonJapanese_Click;
            // 
            // buttonJapanese
            // 
            buttonJapanese.Font = new Font("Segoe UI", 18F);
            buttonJapanese.Location = new Point(739, 74);
            buttonJapanese.Name = "buttonJapanese";
            buttonJapanese.Size = new Size(160, 62);
            buttonJapanese.TabIndex = 6;
            buttonJapanese.Text = "Japanisch";
            buttonJapanese.UseVisualStyleBackColor = true;
            // 
            // SettingsScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 501);
            Controls.Add(buttonEnglish);
            Controls.Add(buttonGerman);
            Controls.Add(buttonSpanish);
            Controls.Add(buttonJapanese);
            Name = "SettingsScreen";
            Text = "SettingsScreen";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonEnglish;
        private Button buttonGerman;
        private Button buttonSpanish;
        private Button buttonJapanese;
    }
}