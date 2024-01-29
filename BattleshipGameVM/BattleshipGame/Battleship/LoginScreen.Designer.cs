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
            textBoxBenutzername = new TextBox();
            labelBenutzername = new Label();
            SuspendLayout();
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.FromArgb(180, 210, 255);
            buttonEnter.FlatAppearance.BorderColor = Color.FromArgb(180, 210, 255);
            buttonEnter.Font = new Font("Segoe UI", 20F);
            buttonEnter.Location = new Point(674, 453);
            buttonEnter.Margin = new Padding(3, 4, 3, 4);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(195, 74);
            buttonEnter.TabIndex = 0;
            buttonEnter.Text = "Enter";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonNext_Click;
            // 
            // textBoxBenutzername
            // 
            textBoxBenutzername.Font = new Font("Segoe UI", 20F);
            textBoxBenutzername.Location = new Point(263, 253);
            textBoxBenutzername.Name = "textBoxBenutzername";
            textBoxBenutzername.Size = new Size(466, 52);
            textBoxBenutzername.TabIndex = 1;
            textBoxBenutzername.TextChanged += textBoxBenutzername_TextChanged;
            // 
            // labelBenutzername
            // 
            labelBenutzername.AutoSize = true;
            labelBenutzername.Font = new Font("Segoe UI", 20F);
            labelBenutzername.Location = new Point(263, 200);
            labelBenutzername.Name = "labelBenutzername";
            labelBenutzername.Size = new Size(235, 46);
            labelBenutzername.TabIndex = 2;
            labelBenutzername.Text = "Benutzername";
            labelBenutzername.Click += labelBenutzername_Click;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 595);
            Controls.Add(labelBenutzername);
            Controls.Add(textBoxBenutzername);
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
        private TextBox textBoxBenutzername;
        private Label labelBenutzername;
    }
}