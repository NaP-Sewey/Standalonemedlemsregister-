namespace Standalonemedlemsregister_
{
    partial class Form2
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
            Signup1 = new Button();
            Username1 = new Label();
            textboxusername = new TextBox();
            Password1 = new Label();
            textboxpassword = new TextBox();
            Confirmpassword = new Label();
            ConfirmPasswordTextbox = new TextBox();
            label1 = new Label();
            MailTextbox = new TextBox();
            PhoneNumber = new Label();
            PhoneNumberTextbox = new TextBox();
            SuspendLayout();
            // 
            // Signup1
            // 
            Signup1.BackColor = Color.FromArgb(255, 128, 128);
            Signup1.BackgroundImageLayout = ImageLayout.None;
            Signup1.FlatStyle = FlatStyle.Flat;
            Signup1.Font = new Font("Rockwell", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Signup1.ForeColor = Color.Black;
            Signup1.Location = new Point(329, 394);
            Signup1.Margin = new Padding(3, 4, 3, 4);
            Signup1.Name = "Signup1";
            Signup1.Size = new Size(114, 43);
            Signup1.TabIndex = 13;
            Signup1.Text = "Sign up";
            Signup1.UseVisualStyleBackColor = false;
            Signup1.Click += Signup1_Click;
            // 
            // Username1
            // 
            Username1.AutoSize = true;
            Username1.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username1.Location = new Point(329, 26);
            Username1.Name = "Username1";
            Username1.Size = new Size(109, 24);
            Username1.TabIndex = 15;
            Username1.Text = "Username";
            // 
            // textboxusername
            // 
            textboxusername.Location = new Point(247, 53);
            textboxusername.Name = "textboxusername";
            textboxusername.Size = new Size(267, 27);
            textboxusername.TabIndex = 14;
            textboxusername.TextChanged += textboxusername_TextChanged;
            // 
            // Password1
            // 
            Password1.AutoSize = true;
            Password1.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password1.Location = new Point(329, 258);
            Password1.Name = "Password1";
            Password1.Size = new Size(104, 24);
            Password1.TabIndex = 17;
            Password1.Text = "Password";
            // 
            // textboxpassword
            // 
            textboxpassword.Location = new Point(247, 285);
            textboxpassword.Name = "textboxpassword";
            textboxpassword.Size = new Size(267, 27);
            textboxpassword.TabIndex = 16;
            textboxpassword.TextChanged += textboxpassword_TextChanged;
            // 
            // Confirmpassword
            // 
            Confirmpassword.AutoSize = true;
            Confirmpassword.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Confirmpassword.Location = new Point(297, 321);
            Confirmpassword.Name = "Confirmpassword";
            Confirmpassword.Size = new Size(186, 24);
            Confirmpassword.TabIndex = 19;
            Confirmpassword.Text = "ConfirmPassword";
            // 
            // ConfirmPasswordTextbox
            // 
            ConfirmPasswordTextbox.Location = new Point(247, 348);
            ConfirmPasswordTextbox.Name = "ConfirmPasswordTextbox";
            ConfirmPasswordTextbox.Size = new Size(267, 27);
            ConfirmPasswordTextbox.TabIndex = 18;
            ConfirmPasswordTextbox.TextChanged += ConfirmPasswordTextbox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(356, 83);
            label1.Name = "label1";
            label1.Size = new Size(57, 24);
            label1.TabIndex = 21;
            label1.Text = "Mail";
            // 
            // MailTextbox
            // 
            MailTextbox.Location = new Point(247, 110);
            MailTextbox.Name = "MailTextbox";
            MailTextbox.Size = new Size(267, 27);
            MailTextbox.TabIndex = 20;
            MailTextbox.TextChanged += MailTextbox_TextChanged;
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSize = true;
            PhoneNumber.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhoneNumber.Location = new Point(315, 153);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(149, 24);
            PhoneNumber.TabIndex = 23;
            PhoneNumber.Text = "Phonenumber";
            // 
            // PhoneNumberTextbox
            // 
            PhoneNumberTextbox.Location = new Point(247, 180);
            PhoneNumberTextbox.Name = "PhoneNumberTextbox";
            PhoneNumberTextbox.Size = new Size(267, 27);
            PhoneNumberTextbox.TabIndex = 22;
            PhoneNumberTextbox.TextChanged += PhoneNumberTextbox_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PhoneNumber);
            Controls.Add(PhoneNumberTextbox);
            Controls.Add(label1);
            Controls.Add(MailTextbox);
            Controls.Add(Confirmpassword);
            Controls.Add(ConfirmPasswordTextbox);
            Controls.Add(Password1);
            Controls.Add(textboxpassword);
            Controls.Add(Username1);
            Controls.Add(textboxusername);
            Controls.Add(Signup1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Signup1;
        private Label Username1;
        private TextBox textboxusername;
        private Label Password1;
        private TextBox textboxpassword;
        private Label Confirmpassword;
        private TextBox ConfirmPasswordTextbox;
        private Label label1;
        private TextBox MailTextbox;
        private Label PhoneNumber;
        private TextBox PhoneNumberTextbox;
    }
}