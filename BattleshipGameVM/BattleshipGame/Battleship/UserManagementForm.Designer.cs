namespace Battleship
{
    partial class UserManagementForm
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
            buttonAdd = new Button();
            buttonEditUser = new Button();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 402);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(175, 36);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Benutzer Hinzufügen";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEditUser
            // 
            buttonEditUser.Location = new Point(230, 402);
            buttonEditUser.Name = "buttonEditUser";
            buttonEditUser.Size = new Size(175, 36);
            buttonEditUser.TabIndex = 1;
            buttonEditUser.Text = "Benutzer bearbeiten";
            buttonEditUser.UseVisualStyleBackColor = true;
            buttonEditUser.Click += buttonEditUser_Click;
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEditUser);
            Controls.Add(buttonAdd);
            Name = "UserManagementForm";
            Text = "UserManagementForm";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdd;
        private Button buttonEditUser;
    }
}