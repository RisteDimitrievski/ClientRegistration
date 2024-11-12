namespace WinFormsApp2
{
    partial class Login
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
            label1 = new Label();
            email = new TextBox();
            label2 = new Label();
            password = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 187);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            label1.Click += label1_Click;
            // 
            // email
            // 
            email.AccessibleName = "email";
            email.Location = new Point(265, 179);
            email.Name = "email";
            email.PlaceholderText = "Email";
            email.Size = new Size(365, 23);
            email.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 235);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // password
            // 
            password.AccessibleName = "password";
            password.Location = new Point(265, 227);
            password.Name = "password";
            password.PasswordChar = '•';
            password.PlaceholderText = "Account password";
            password.Size = new Size(365, 23);
            password.TabIndex = 2;
            // 
            // button1
            // 
            button1.AccessibleName = "register";
            button1.Location = new Point(216, 403);
            button1.Name = "button1";
            button1.Size = new Size(360, 35);
            button1.TabIndex = 4;
            button1.Text = "Create new account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(216, 340);
            button2.Name = "button2";
            button2.Size = new Size(360, 33);
            button2.TabIndex = 3;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(label2);
            Controls.Add(email);
            Controls.Add(label1);
            Name = "Login";
            Text = "User Notes Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox email;
        private Label label2;
        private TextBox password;
        private Button button1;
        private Button button2;
    }
}