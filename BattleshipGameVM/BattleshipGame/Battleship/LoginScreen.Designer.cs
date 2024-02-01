namespace Battleship
{
    partial class LoginScreen
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
            buttonEnter = new Button();
            textBoxUserName = new TextBox();
            labelUserName = new Label();
            buttonEnglish = new Button();
            buttonGerman = new Button();
            buttonSpanish = new Button();
            buttonJapanese = new Button();
            SuspendLayout();
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.FromArgb(180, 210, 255);
            buttonEnter.FlatAppearance.BorderColor = Color.FromArgb(180, 210, 255);
            buttonEnter.Font = new Font("Segoe UI", 20F);
            buttonEnter.Location = new Point(715, 454);
            buttonEnter.Margin = new Padding(3, 4, 3, 4);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(195, 74);
            buttonEnter.TabIndex = 0;
            buttonEnter.Text = "Enter";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonNext_Click;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Font = new Font("Segoe UI", 20F);
            textBoxUserName.Location = new Point(263, 287);
            textBoxUserName.Name = "textBoxBenutzername";
            textBoxUserName.Size = new Size(466, 52);
            textBoxUserName.TabIndex = 1;
            textBoxUserName.TextChanged += textBoxUserName_TextChanged;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI", 20F);
            labelUserName.Location = new Point(263, 232);
            labelUserName.Name = "labelBenutzername";
            labelUserName.Size = new Size(235, 46);
            labelUserName.TabIndex = 2;
            labelUserName.Text = "Benutzername";
            labelUserName.Click += labelUserName_Click;
            // 
            // buttonEnglish
            // 
            buttonEnglish.Font = new Font("Segoe UI", 18F);
            buttonEnglish.Location = new Point(32, 29);
            buttonEnglish.Name = "buttonEnglish";
            buttonEnglish.Size = new Size(160, 62);
            buttonEnglish.TabIndex = 3;
            buttonEnglish.Text = "Englisch";
            buttonEnglish.UseVisualStyleBackColor = true;
            buttonSpanish.Click += buttonEnglish_Click;
            // 
            // buttonGerman
            // 
            buttonGerman.Font = new Font("Segoe UI", 18F);
            buttonGerman.Location = new Point(263, 29);
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
            buttonSpanish.Location = new Point(510, 29);
            buttonSpanish.Name = "buttonSpanish";
            buttonSpanish.Size = new Size(160, 62);
            buttonSpanish.TabIndex = 5;
            buttonSpanish.Text = "Spanisch";
            buttonSpanish.UseVisualStyleBackColor = true;
            buttonSpanish.Click += buttonSpanish_Click;
            // 
            // buttonJapanese
            // 
            buttonJapanese.Font = new Font("Segoe UI", 18F);
            buttonJapanese.Location = new Point(750, 29);
            buttonJapanese.Name = "buttonJapanese";
            buttonJapanese.Size = new Size(160, 62);
            buttonJapanese.TabIndex = 6;
            buttonJapanese.Text = "Japanisch";
            buttonJapanese.UseVisualStyleBackColor = true;
            buttonSpanish.Click += buttonJapanese_Click;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 595);
            Controls.Add(buttonJapanese);
            Controls.Add(buttonSpanish);
            Controls.Add(buttonGerman);
            Controls.Add(buttonEnglish);
            Controls.Add(labelUserName);
            Controls.Add(textBoxUserName);
            Controls.Add(buttonEnter);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginScreen";
            Text = "LoginScreen";
            Load += LoginScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEnter;
        private TextBox textBoxUserName;
        private Label labelUserName;
        private Button buttonEnglish;
        private Button buttonGerman;
        private Button buttonSpanish;
        private Button buttonJapanese;
    }
}