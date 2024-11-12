namespace WinFormsApp2
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
            label1 = new Label();
            email = new TextBox();
            label2 = new Label();
            password = new TextBox();
            button1 = new Button();
            label3 = new Label();
            fname = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            address = new TextBox();
            postalcode = new TextBox();
            city = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 176);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Email address:";
            // 
            // email
            // 
            email.Location = new Point(341, 173);
            email.Name = "email";
            email.Size = new Size(331, 23);
            email.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 241);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // password
            // 
            password.Location = new Point(341, 233);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(331, 23);
            password.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(341, 518);
            button1.Name = "button1";
            button1.Size = new Size(331, 34);
            button1.TabIndex = 4;
            button1.Text = "Save information to database";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 123);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 5;
            label3.Text = "Full name:";
            // 
            // fname
            // 
            fname.Location = new Point(341, 115);
            fname.Name = "fname";
            fname.Size = new Size(331, 23);
            fname.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(176, 293);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 7;
            label4.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(157, 344);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 8;
            label5.Text = "Postal code:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(190, 396);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 9;
            label6.Text = "City:";
            // 
            // address
            // 
            address.Location = new Point(341, 285);
            address.Name = "address";
            address.Size = new Size(331, 23);
            address.TabIndex = 10;
            // 
            // postalcode
            // 
            postalcode.Location = new Point(341, 336);
            postalcode.Name = "postalcode";
            postalcode.Size = new Size(331, 23);
            postalcode.TabIndex = 11;
            // 
            // city
            // 
            city.Location = new Point(341, 388);
            city.Name = "city";
            city.Size = new Size(331, 23);
            city.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 610);
            Controls.Add(city);
            Controls.Add(postalcode);
            Controls.Add(address);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(fname);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(label2);
            Controls.Add(email);
            Controls.Add(label1);
            Name = "Form1";
            Text = "New client registration";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox email;
        private Label label2;
        private TextBox password;
        private Button button1;
        private Label label3;
        private TextBox fname;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox address;
        private TextBox postalcode;
        private TextBox city;
    }
}
