namespace Standalonemedlemsregister_
{
    partial class Form1
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
            textboxusername = new TextBox();
            textboxpassword = new TextBox();
            Username1 = new Label();
            Password1 = new Label();
            Login1 = new Button();
            Signup1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textboxusername
            // 
            textboxusername.BackColor = Color.White;
            textboxusername.BorderStyle = BorderStyle.FixedSingle;
            textboxusername.Location = new Point(162, 127);
            textboxusername.Margin = new Padding(3, 2, 3, 2);
            textboxusername.Name = "textboxusername";
            textboxusername.Size = new Size(234, 23);
            textboxusername.TabIndex = 1;
            // 
            // textboxpassword
            // 
            textboxpassword.BackColor = Color.Snow;
            textboxpassword.BorderStyle = BorderStyle.FixedSingle;
            textboxpassword.Location = new Point(162, 244);
            textboxpassword.Margin = new Padding(3, 2, 3, 2);
            textboxpassword.Name = "textboxpassword";
            textboxpassword.Size = new Size(234, 23);
            textboxpassword.TabIndex = 3;
            textboxpassword.TextChanged += textboxpassword_TextChanged;
            // 
            // Username1
            // 
            Username1.AutoSize = true;
            Username1.BackColor = Color.White;
            Username1.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username1.ForeColor = Color.SkyBlue;
            Username1.Location = new Point(234, 106);
            Username1.Name = "Username1";
            Username1.Size = new Size(88, 19);
            Username1.TabIndex = 4;
            Username1.Text = "Username";
            // 
            // Password1
            // 
            Password1.AutoSize = true;
            Password1.BackColor = Color.White;
            Password1.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password1.ForeColor = Color.SkyBlue;
            Password1.Location = new Point(234, 224);
            Password1.Name = "Password1";
            Password1.Size = new Size(84, 19);
            Password1.TabIndex = 5;
            Password1.Text = "Password";
            // 
            // Login1
            // 
            Login1.BackColor = Color.FromArgb(128, 255, 128);
            Login1.BackgroundImageLayout = ImageLayout.None;
            Login1.FlatStyle = FlatStyle.Flat;
            Login1.Font = new Font("Rockwell", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login1.ForeColor = Color.Black;
            Login1.Location = new Point(71, 273);
            Login1.Name = "Login1";
            Login1.Size = new Size(100, 32);
            Login1.TabIndex = 11;
            Login1.Text = "Login";
            Login1.UseVisualStyleBackColor = false;
            Login1.Click += Login1_Click;
            // 
            // Signup1
            // 
            Signup1.BackColor = Color.FromArgb(255, 128, 128);
            Signup1.BackgroundImageLayout = ImageLayout.None;
            Signup1.FlatStyle = FlatStyle.Flat;
            Signup1.Font = new Font("Rockwell", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Signup1.ForeColor = Color.Black;
            Signup1.Location = new Point(177, 273);
            Signup1.Name = "Signup1";
            Signup1.Size = new Size(100, 32);
            Signup1.TabIndex = 12;
            Signup1.Text = "Sign up";
            Signup1.UseVisualStyleBackColor = false;
            Signup1.Click += Signup1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Enabled = false;
            label1.Font = new Font("Rockwell Extra Bold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SkyBlue;
            label1.Location = new Point(108, 19);
            label1.Name = "label1";
            label1.Size = new Size(138, 34);
            label1.TabIndex = 2;
            label1.Text = "Log ind";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Signup1);
            panel1.Controls.Add(Login1);
            panel1.Location = new Point(99, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(351, 337);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(541, 370);
            Controls.Add(Username1);
            Controls.Add(textboxusername);
            Controls.Add(Password1);
            Controls.Add(textboxpassword);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textboxusername;
        private TextBox textboxpassword;
        private Label Username1;
        private Label Password1;
        private Button Login1;
        private Button Signup1;
        private Label label1;
        private Panel panel1;
    }
}
