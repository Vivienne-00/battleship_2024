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
            SuspendLayout();
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.FromArgb(180, 210, 255);
            buttonEnter.FlatAppearance.BorderColor = Color.FromArgb(180, 210, 255);
            buttonEnter.Font = new Font("Segoe UI", 20F);
            buttonEnter.Location = new Point(669, 452);
            buttonEnter.Margin = new Padding(3, 4, 3, 4);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(200, 75);
            buttonEnter.TabIndex = 0;
            buttonEnter.Text = "Enter";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonNext_Click;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 595);
            Controls.Add(buttonEnter);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginScreen";
            Text = "LoginScreen";
            Load += LoginScreen_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonEnter;
    }
}