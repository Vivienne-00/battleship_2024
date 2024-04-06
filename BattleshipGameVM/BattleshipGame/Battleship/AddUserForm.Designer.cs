namespace Battleship
{
    partial class AddUserForm
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
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            textBoxBirthYear = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonAddUser = new Button();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 12F);
            textBoxUsername.Location = new Point(23, 83);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(221, 34);
            textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 12F);
            textBoxPassword.Location = new Point(23, 205);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(221, 34);
            textBoxPassword.TabIndex = 1;
            // 
            // textBoxBirthYear
            // 
            textBoxBirthYear.Font = new Font("Segoe UI", 12F);
            textBoxBirthYear.Location = new Point(311, 83);
            textBoxBirthYear.Name = "textBoxBirthYear";
            textBoxBirthYear.Size = new Size(221, 34);
            textBoxBirthYear.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(23, 48);
            label1.Name = "label1";
            label1.Size = new Size(136, 28);
            label1.TabIndex = 3;
            label1.Text = "Benutzername";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(23, 174);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 4;
            label2.Text = "Passwort";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(311, 48);
            label3.Name = "label3";
            label3.Size = new Size(114, 28);
            label3.TabIndex = 5;
            label3.Text = "Geburtsjahr";
            // 
            // buttonAddUser
            // 
            buttonAddUser.Font = new Font("Segoe UI", 12F);
            buttonAddUser.Location = new Point(631, 371);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(130, 44);
            buttonAddUser.TabIndex = 6;
            buttonAddUser.Text = "hinzufügen";
            buttonAddUser.UseVisualStyleBackColor = true;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAddUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxBirthYear);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Name = "AddUserForm";
            Text = "AddUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private TextBox textBoxBirthYear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonAddUser;
    }
}