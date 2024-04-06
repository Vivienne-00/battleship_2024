namespace Battleship
{
    partial class SplashScreen
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
			SuspendLayout();
			// 
			// SplashScreen
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.BGSplashScreen;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(914, 600);
			Margin = new Padding(3, 4, 3, 4);
			Name = "SplashScreen";
			Text = "BattleShip by Vivienne G., Miguel F.";
			Load += SplashScreen_Load;
			Shown += SplashScreen_Shown;
			ResumeLayout(false);
		}

		#endregion

		private Button button1;
    }
}