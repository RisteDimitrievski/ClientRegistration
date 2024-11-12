namespace WinFormsApp2
{
    partial class Usernotes
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
            saveButton = new Button();
            note = new TextBox();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Location = new Point(271, 407);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(232, 31);
            saveButton.TabIndex = 2;
            saveButton.Text = "Save notes";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // note
            // 
            note.Location = new Point(22, 12);
            note.Multiline = true;
            note.Name = "note";
            note.Size = new Size(766, 376);
            note.TabIndex = 3;
            // 
            // Usernotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(note);
            Controls.Add(saveButton);
            Name = "Usernotes";
            Text = "Usernotes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button saveButton;
        private TextBox note;
    }
}