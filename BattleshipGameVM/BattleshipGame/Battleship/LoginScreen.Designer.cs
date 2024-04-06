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
			textBoxPassword = new TextBox();
			labelPassword = new Label();
			LblError = new Label();
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
			buttonEnter.TabIndex = 3;
			buttonEnter.Text = "Eingabe";
			buttonEnter.UseVisualStyleBackColor = false;
			buttonEnter.Click += buttonNext_Click;
			// 
			// textBoxUserName
			// 
			textBoxUserName.Font = new Font("Segoe UI", 20F);
			textBoxUserName.Location = new Point(263, 231);
			textBoxUserName.Name = "textBoxUserName";
			textBoxUserName.Size = new Size(466, 52);
			textBoxUserName.TabIndex = 1;
			textBoxUserName.TextChanged += textBoxUserName_TextChanged;
			// 
			// labelUserName
			// 
			labelUserName.AutoSize = true;
			labelUserName.BackColor = Color.Transparent;
			labelUserName.Font = new Font("Segoe UI", 20F);
			labelUserName.Location = new Point(263, 182);
			labelUserName.Name = "labelUserName";
			labelUserName.Size = new Size(235, 46);
			labelUserName.TabIndex = 77;
			labelUserName.Text = "Benutzername";
			labelUserName.Click += labelUserName_Click;
			// 
			// buttonEnglish
			// 
			buttonEnglish.Font = new Font("Segoe UI", 18F);
			buttonEnglish.Location = new Point(119, 29);
			buttonEnglish.Name = "buttonEnglish";
			buttonEnglish.Size = new Size(160, 62);
			buttonEnglish.TabIndex = 55;
			buttonEnglish.TabStop = false;
			buttonEnglish.Text = "Englisch";
			buttonEnglish.UseVisualStyleBackColor = true;
			buttonEnglish.Click += buttonEnglish_Click_1;
			// 
			// buttonGerman
			// 
			buttonGerman.Font = new Font("Segoe UI", 18F);
			buttonGerman.Location = new Point(418, 29);
			buttonGerman.Name = "buttonGerman";
			buttonGerman.Size = new Size(160, 62);
			buttonGerman.TabIndex = 56;
			buttonGerman.TabStop = false;
			buttonGerman.Text = "Deutsch";
			buttonGerman.UseVisualStyleBackColor = true;
			buttonGerman.Click += buttonGerman_Click;
			// 
			// buttonSpanish
			// 
			buttonSpanish.Font = new Font("Segoe UI", 18F);
			buttonSpanish.Location = new Point(715, 29);
			buttonSpanish.Name = "buttonSpanish";
			buttonSpanish.Size = new Size(160, 62);
			buttonSpanish.TabIndex = 57;
			buttonSpanish.TabStop = false;
			buttonSpanish.Text = "Spanisch";
			buttonSpanish.UseVisualStyleBackColor = true;
			buttonSpanish.Click += buttonSpanish_Click_1;
			// 
			// textBoxPassword
			// 
			textBoxPassword.Font = new Font("Segoe UI", 20F);
			textBoxPassword.Location = new Point(263, 350);
			textBoxPassword.Name = "textBoxPassword";
			textBoxPassword.PasswordChar = '*';
			textBoxPassword.Size = new Size(466, 52);
			textBoxPassword.TabIndex = 2;
			textBoxPassword.TextChanged += textBoxPassword_TextChanged;
			// 
			// labelPassword
			// 
			labelPassword.AutoSize = true;
			labelPassword.BackColor = Color.Transparent;
			labelPassword.Font = new Font("Segoe UI", 20F);
			labelPassword.Location = new Point(263, 302);
			labelPassword.Name = "labelPassword";
			labelPassword.Size = new Size(152, 46);
			labelPassword.TabIndex = 78;
			labelPassword.Text = "Passwort";
			// 
			// LblError
			// 
			LblError.AutoSize = true;
			LblError.BackColor = Color.Transparent;
			LblError.Font = new Font("Segoe UI", 20F);
			LblError.Location = new Point(263, 454);
			LblError.Name = "LblError";
			LblError.Size = new Size(0, 46);
			LblError.TabIndex = 9;
			// 
			// LoginScreen
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.BGdefault;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(972, 598);
			Controls.Add(LblError);
			Controls.Add(labelPassword);
			Controls.Add(textBoxPassword);
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
        private TextBox textBoxPassword;
        private Label labelPassword;
		private Label LblError;
	}
}