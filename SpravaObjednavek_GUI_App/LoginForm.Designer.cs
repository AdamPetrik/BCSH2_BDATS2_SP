namespace SpravaObjednavek_GUI_App
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameLabel = new Label();
            passwordLabel = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            guestButton = new Button();
            statusLabel = new Label();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            usernameLabel.Location = new Point(67, 8);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(164, 25);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Uživatelské jméno";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            passwordLabel.Location = new Point(120, 62);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(59, 25);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Heslo";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(67, 36);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(164, 23);
            usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(67, 90);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(164, 23);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.RoyalBlue;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            loginButton.ForeColor = Color.Snow;
            loginButton.Location = new Point(67, 132);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(164, 34);
            loginButton.TabIndex = 4;
            loginButton.Text = "Přihlásit se";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // guestButton
            // 
            guestButton.BackColor = Color.RoyalBlue;
            guestButton.FlatStyle = FlatStyle.Flat;
            guestButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            guestButton.ForeColor = Color.Snow;
            guestButton.Location = new Point(67, 172);
            guestButton.Name = "guestButton";
            guestButton.Size = new Size(164, 34);
            guestButton.TabIndex = 5;
            guestButton.Text = "Režim hosta";
            guestButton.UseVisualStyleBackColor = false;
            guestButton.Click += guestButton_Click;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(149, 240);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(0, 15);
            statusLabel.TabIndex = 6;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 263);
            Controls.Add(statusLabel);
            Controls.Add(guestButton);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Přihlášení";
            Shown += LoginForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Button guestButton;
        private Label statusLabel;
    }
}
