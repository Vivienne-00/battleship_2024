namespace Battleship
{
    partial class SignUpScreen
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
            labelBirthYear = new Label();
            textBoxBirthYear = new TextBox();
            buttonEnter = new Button();
            SuspendLayout();
            // 
            // labelBirthYear
            // 
            labelBirthYear.AutoSize = true;
            labelBirthYear.BackColor = Color.Transparent;
            labelBirthYear.Font = new Font("Segoe UI", 20F);
            labelBirthYear.Location = new Point(263, 208);
            labelBirthYear.Name = "labelBirthYear";
            labelBirthYear.Size = new Size(421, 46);
            labelBirthYear.TabIndex = 3;
            labelBirthYear.Text = "Bitte Geburtsjahr eingeben";
            labelBirthYear.Click += labelUserName_Click;
            // 
            // textBoxBirthYear
            // 
            textBoxBirthYear.Font = new Font("Segoe UI", 20F);
            textBoxBirthYear.Location = new Point(263, 259);
            textBoxBirthYear.Name = "textBoxBirthYear";
            textBoxBirthYear.Size = new Size(466, 52);
            textBoxBirthYear.TabIndex = 4;
            textBoxBirthYear.TextChanged += textBoxBirthYear_TextChanged;
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
            buttonEnter.TabIndex = 5;
            buttonEnter.Text = "Eingabe";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // SignUpScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BGdefault;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(972, 598);
            Controls.Add(buttonEnter);
            Controls.Add(textBoxBirthYear);
            Controls.Add(labelBirthYear);
            Name = "SignUpScreen";
            Text = "SignUpScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBirthYear;
        private TextBox textBoxBirthYear;
        private Button buttonEnter;
    }
}