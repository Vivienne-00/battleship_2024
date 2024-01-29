namespace Battleship
{
    partial class GameBoardSizeScreen
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
            labelGameBoardSize = new Label();
            buttonSize11x11 = new Button();
            buttonSize9x9 = new Button();
            buttonSize10x10 = new Button();
            buttonSize13x13 = new Button();
            buttonSize15x15 = new Button();
            buttonSize12x12 = new Button();
            buttonSize14x14 = new Button();
            SuspendLayout();
            // 
            // labelGameBoardSize
            // 
            labelGameBoardSize.AutoSize = true;
            labelGameBoardSize.Font = new Font("Segoe UI", 20F);
            labelGameBoardSize.Location = new Point(231, 62);
            labelGameBoardSize.Name = "labelGameBoardSize";
            labelGameBoardSize.Size = new Size(490, 46);
            labelGameBoardSize.TabIndex = 1;
            labelGameBoardSize.Text = "Bitte Spielfeldgrösse auswählen";
            // 
            // buttonSize9x9
            // 
            buttonSize9x9.BackColor = Color.FromArgb(180, 210, 255);
            buttonSize9x9.FlatAppearance.BorderColor = Color.FromArgb(180, 210, 255);
            buttonSize9x9.Font = new Font("Segoe UI", 20F);
            buttonSize9x9.Location = new Point(115, 165);
            buttonSize9x9.Name = "buttonSize9x9";
            buttonSize9x9.Size = new Size(195, 74);
            buttonSize9x9.TabIndex = 3;
            buttonSize9x9.Text = "9 x 9";
            buttonSize9x9.UseVisualStyleBackColor = false;
            buttonSize9x9.Click += buttonSize9x9_Click;
            // 
            // buttonSize10x10
            // 
            buttonSize10x10.BackColor = Color.FromArgb(180, 210, 255);
            buttonSize10x10.FlatAppearance.BorderColor = Color.FromArgb(180, 210, 255);
            buttonSize10x10.Font = new Font("Segoe UI", 20F);
            buttonSize10x10.Location = new Point(374, 165);
            buttonSize10x10.Name = "buttonSize10x10";
            buttonSize10x10.Size = new Size(195, 74);
            buttonSize10x10.TabIndex = 4;
            buttonSize10x10.Text = "10 x 10";
            buttonSize10x10.UseVisualStyleBackColor = false;
            buttonSize10x10.Click += buttonSize10x10_Click;
            // 
            // buttonSize11x11
            // 
            buttonSize11x11.BackColor = Color.FromArgb(180, 210, 255);
            buttonSize11x11.FlatAppearance.BorderColor = Color.FromArgb(180, 210, 255);
            buttonSize11x11.Font = new Font("Segoe UI", 20F);
            buttonSize11x11.Location = new Point(616, 165);
            buttonSize11x11.Name = "buttonSize11x11";
            buttonSize11x11.Size = new Size(195, 74);
            buttonSize11x11.TabIndex = 2;
            buttonSize11x11.Text = "11 x 11";
            buttonSize11x11.UseVisualStyleBackColor = false;
            buttonSize11x11.Click += buttonSize11x11_Click;
            // 
            // buttonSize12x12
            // 
            buttonSize12x12.BackColor = Color.FromArgb(180, 210, 255);
            buttonSize12x12.FlatAppearance.BorderColor = Color.FromArgb(180, 210, 255);
            buttonSize12x12.Font = new Font("Segoe UI", 20F);
            buttonSize12x12.Location = new Point(374, 269);
            buttonSize12x12.Name = "buttonSize12x12";
            buttonSize12x12.Size = new Size(195, 74);
            buttonSize12x12.TabIndex = 7;
            buttonSize12x12.Text = "12 x 12";
            buttonSize12x12.UseVisualStyleBackColor = false;
            buttonSize12x12.Click += buttonSize12x12_Click;
            // 
            // buttonSize13x13
            // 
            buttonSize13x13.BackColor = Color.FromArgb(180, 210, 255);
            buttonSize13x13.FlatAppearance.BorderColor = Color.FromArgb(180, 210, 255);
            buttonSize13x13.Font = new Font("Segoe UI", 20F);
            buttonSize13x13.Location = new Point(115, 375);
            buttonSize13x13.Name = "buttonSize13x13";
            buttonSize13x13.Size = new Size(195, 74);
            buttonSize13x13.TabIndex = 5;
            buttonSize13x13.Text = "13 x 13";
            buttonSize13x13.UseVisualStyleBackColor = false;
            buttonSize13x13.Click += buttonSize13x13_Click;
            // 
            // buttonSize14x14
            // 
            buttonSize14x14.BackColor = Color.FromArgb(180, 210, 255);
            buttonSize14x14.FlatAppearance.BorderColor = Color.FromArgb(180, 210, 255);
            buttonSize14x14.Font = new Font("Segoe UI", 20F);
            buttonSize14x14.Location = new Point(374, 375);
            buttonSize14x14.Name = "buttonSize14x14";
            buttonSize14x14.Size = new Size(195, 74);
            buttonSize14x14.TabIndex = 8;
            buttonSize14x14.Text = "14 x 14";
            buttonSize14x14.UseVisualStyleBackColor = false;
            buttonSize14x14.Click += buttonSize14x14_Click;
            // 
            // buttonSize15x15
            // 
            buttonSize15x15.BackColor = Color.FromArgb(180, 210, 255);
            buttonSize15x15.FlatAppearance.BorderColor = Color.FromArgb(180, 210, 255);
            buttonSize15x15.Font = new Font("Segoe UI", 20F);
            buttonSize15x15.Location = new Point(616, 375);
            buttonSize15x15.Name = "buttonSize15x15";
            buttonSize15x15.Size = new Size(195, 74);
            buttonSize15x15.TabIndex = 6;
            buttonSize15x15.Text = "15 x 15";
            buttonSize15x15.UseVisualStyleBackColor = false;
            buttonSize15x15.Click += buttonSize15x15_Click;
            // 
            // GameBoardSizeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 548);
            Controls.Add(buttonSize14x14);
            Controls.Add(buttonSize12x12);
            Controls.Add(buttonSize15x15);
            Controls.Add(buttonSize13x13);
            Controls.Add(buttonSize10x10);
            Controls.Add(buttonSize9x9);
            Controls.Add(buttonSize11x11);
            Controls.Add(labelGameBoardSize);
            Name = "GameBoardSizeScreen";
            Text = "GameBoardSizeScreen";
            Load += GameBoardSizeScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGameBoardSize;
        private Button buttonSize11x11;
        private Button buttonSize9x9;
        private Button buttonSize10x10;
        private Button buttonSize13x13;
        private Button buttonSize15x15;
        private Button buttonSize12x12;
        private Button buttonSize14x14;
    }
}