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
            // textBox1
            // 
            textBox1.Location = new Point(67, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(67, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 23);
            textBox2.TabIndex = 3;
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
            // hostButton
            // 
            hostButton.BackColor = Color.RoyalBlue;
            hostButton.FlatStyle = FlatStyle.Flat;
            hostButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            hostButton.ForeColor = Color.Snow;
            hostButton.Location = new Point(67, 172);
            hostButton.Name = "hostButton";
            hostButton.Size = new Size(164, 34);
            hostButton.TabIndex = 5;
            hostButton.Text = "Režim hosta";
            hostButton.UseVisualStyleBackColor = false;
            hostButton.Click += hostButton_Click;
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
            Controls.Add(hostButton);
            Controls.Add(loginButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label statusLabel;
    }
}
