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
            label1 = new Label();
            textboxpassword = new TextBox();
            Username1 = new Label();
            Password1 = new Label();
            Login1 = new Button();
            Signup1 = new Button();
            SuspendLayout();
            // 
            // textboxusername
            // 
            textboxusername.Location = new Point(185, 169);
            textboxusername.Name = "textboxusername";
            textboxusername.Size = new Size(267, 27);
            textboxusername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Rockwell", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(165, 9);
            label1.Name = "label1";
            label1.Size = new Size(304, 44);
            label1.TabIndex = 2;
            label1.Text = "Medlemsregister";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // textboxpassword
            // 
            textboxpassword.Location = new Point(185, 325);
            textboxpassword.Name = "textboxpassword";
            textboxpassword.Size = new Size(267, 27);
            textboxpassword.TabIndex = 3;
            // 
            // Username1
            // 
            Username1.AutoSize = true;
            Username1.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username1.Location = new Point(267, 142);
            Username1.Name = "Username1";
            Username1.Size = new Size(109, 24);
            Username1.TabIndex = 4;
            Username1.Text = "Username";
            // 
            // Password1
            // 
            Password1.AutoSize = true;
            Password1.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password1.Location = new Point(267, 298);
            Password1.Name = "Password1";
            Password1.Size = new Size(104, 24);
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
            Login1.Location = new Point(197, 419);
            Login1.Margin = new Padding(3, 4, 3, 4);
            Login1.Name = "Login1";
            Login1.Size = new Size(114, 43);
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
            Signup1.Location = new Point(317, 419);
            Signup1.Margin = new Padding(3, 4, 3, 4);
            Signup1.Name = "Signup1";
            Signup1.Size = new Size(114, 43);
            Signup1.TabIndex = 12;
            Signup1.Text = "Sign up";
            Signup1.UseVisualStyleBackColor = false;
            Signup1.Click += Signup1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(618, 493);
            Controls.Add(Signup1);
            Controls.Add(Login1);
            Controls.Add(Password1);
            Controls.Add(Username1);
            Controls.Add(textboxpassword);
            Controls.Add(label1);
            Controls.Add(textboxusername);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textboxusername;
        private Label label1;
        private TextBox textboxpassword;
        private Label Username1;
        private Label Password1;
        private Button Login1;
        private Button Signup1;
    }
}
