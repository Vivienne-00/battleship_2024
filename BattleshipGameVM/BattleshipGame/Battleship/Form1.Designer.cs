namespace Battleship {
    partial class Form1 {
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
        private void InitializeComponent() {
            gameBoardControlView1 = new View.GameBoardControlView();
            gameBoardControlView2 = new View.GameBoardControlView();
            SuspendLayout();
            // 
            // gameBoardControlView1
            // 
            gameBoardControlView1.BorderStyle = BorderStyle.FixedSingle;
            gameBoardControlView1.Location = new Point(27, 31);
            gameBoardControlView1.Name = "gameBoardControlView1";
            gameBoardControlView1.Size = new Size(300, 300);
            gameBoardControlView1.TabIndex = 0;
            // 
            // gameBoardControlView2
            // 
            gameBoardControlView2.BorderStyle = BorderStyle.FixedSingle;
            gameBoardControlView2.Location = new Point(570, 31);
            gameBoardControlView2.Name = "gameBoardControlView2";
            gameBoardControlView2.Size = new Size(300, 300);
            gameBoardControlView2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 635);
            Controls.Add(gameBoardControlView2);
            Controls.Add(gameBoardControlView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private View.GameBoardControlView gameBoardControlView1;
        private View.GameBoardControlView gameBoardControlView2;
    }
}
