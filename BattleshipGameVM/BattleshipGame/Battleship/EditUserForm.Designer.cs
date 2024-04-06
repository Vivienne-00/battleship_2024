namespace Battleship
{
    partial class EditUserForm
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
            buttonEditUser = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxBirthYear = new TextBox();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            checkBoxUserActive = new CheckBox();
            SuspendLayout();
            // 
            // buttonEditUser
            // 
            buttonEditUser.Font = new Font("Segoe UI", 12F);
            buttonEditUser.Location = new Point(639, 365);
            buttonEditUser.Name = "buttonEditUser";
            buttonEditUser.Size = new Size(130, 44);
            buttonEditUser.TabIndex = 13;
            buttonEditUser.Text = "speichern";
            buttonEditUser.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(319, 42);
            label3.Name = "label3";
            label3.Size = new Size(114, 28);
            label3.TabIndex = 12;
            label3.Text = "Geburtsjahr";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(31, 168);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 11;
            label2.Text = "Passwort";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(31, 42);
            label1.Name = "label1";
            label1.Size = new Size(136, 28);
            label1.TabIndex = 10;
            label1.Text = "Benutzername";
            // 
            // textBoxBirthYear
            // 
            textBoxBirthYear.Font = new Font("Segoe UI", 12F);
            textBoxBirthYear.Location = new Point(319, 77);
            textBoxBirthYear.Name = "textBoxBirthYear";
            textBoxBirthYear.Size = new Size(221, 34);
            textBoxBirthYear.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 12F);
            textBoxPassword.Location = new Point(31, 199);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(221, 34);
            textBoxPassword.TabIndex = 8;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 12F);
            textBoxUsername.Location = new Point(31, 77);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(221, 34);
            textBoxUsername.TabIndex = 7;
            // 
            // checkBoxUserActive
            // 
            checkBoxUserActive.AutoSize = true;
            checkBoxUserActive.Font = new Font("Segoe UI", 12F);
            checkBoxUserActive.Location = new Point(319, 199);
            checkBoxUserActive.Name = "checkBoxUserActive";
            checkBoxUserActive.Size = new Size(79, 32);
            checkBoxUserActive.TabIndex = 14;
            checkBoxUserActive.Text = "Aktiv";
            checkBoxUserActive.UseVisualStyleBackColor = true;
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBoxUserActive);
            Controls.Add(buttonEditUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxBirthYear);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Name = "EditUserForm";
            Text = "EditUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEditUser;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxBirthYear;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private CheckBox checkBoxUserActive;
    }
}