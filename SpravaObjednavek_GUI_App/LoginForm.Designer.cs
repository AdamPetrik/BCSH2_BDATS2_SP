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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            loginButton = new Button();
            hostButton = new Button();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            usernameLabel.Location = new Point(12, 9);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(164, 25);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Uživatelské jméno";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            passwordLabel.Location = new Point(13, 63);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(59, 25);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Heslo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(17, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 23);
            textBox2.TabIndex = 3;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            loginButton.Location = new Point(49, 133);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(97, 34);
            loginButton.TabIndex = 4;
            loginButton.Text = "Přihlásit se";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // hostButton
            // 
            hostButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            hostButton.Location = new Point(49, 173);
            hostButton.Name = "hostButton";
            hostButton.Size = new Size(97, 34);
            hostButton.TabIndex = 5;
            hostButton.Text = "Režim hosta";
            hostButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(199, 226);
            Controls.Add(hostButton);
            Controls.Add(loginButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Name = "LoginForm";
            Text = "Přihlášení";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button loginButton;
        private Button hostButton;
    }
}
