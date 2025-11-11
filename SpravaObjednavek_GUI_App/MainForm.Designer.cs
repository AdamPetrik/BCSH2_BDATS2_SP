namespace SpravaObjednavek_GUI_App
{
    partial class MainForm
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
            panel1 = new Panel();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 60, 103);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 825);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(0, 765);
            label1.Name = "label1";
            label1.Size = new Size(130, 60);
            label1.TabIndex = 4;
            label1.Text = "FEI UPCE\r\nBCSH2 / BDAS2\r\nAutor: Adam Petřík\r\nSpráva objednávek v1.0";
            // 
            // button4
            // 
            button4.BackColor = Color.RoyalBlue;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 65, 194);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button4.ForeColor = Color.Snow;
            button4.Location = new Point(0, 198);
            button4.Name = "button4";
            button4.Size = new Size(200, 66);
            button4.TabIndex = 3;
            button4.Text = "Administrace";
            button4.TextImageRelation = TextImageRelation.TextAboveImage;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.RoyalBlue;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 65, 194);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button3.ForeColor = Color.Snow;
            button3.Location = new Point(0, 132);
            button3.Name = "button3";
            button3.Size = new Size(200, 66);
            button3.TabIndex = 2;
            button3.Text = "Reporty";
            button3.TextImageRelation = TextImageRelation.TextAboveImage;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 65, 194);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button2.ForeColor = Color.Snow;
            button2.Location = new Point(0, 66);
            button2.Name = "button2";
            button2.Size = new Size(200, 66);
            button2.TabIndex = 1;
            button2.Text = "Objednávky";
            button2.TextImageRelation = TextImageRelation.TextAboveImage;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 65, 194);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(200, 66);
            button1.TabIndex = 0;
            button1.Text = "Kasa";
            button1.TextImageRelation = TextImageRelation.TextAboveImage;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1320, 825);
            panel2.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1520, 825);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Správa objednávek";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label1;
    }
}