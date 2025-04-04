namespace Task1
{
    partial class Registration
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
            LoginLabel = new Label();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            RegisterUserButton = new Button();
            SuspendLayout();
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(12, 9);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(52, 20);
            LoginLabel.TabIndex = 0;
            LoginLabel.Text = "Логин";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(12, 32);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(185, 27);
            LoginTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(12, 106);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(185, 27);
            PasswordTextBox.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(12, 83);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(62, 20);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Пароль";
            // 
            // RegisterUserButton
            // 
            RegisterUserButton.Location = new Point(12, 179);
            RegisterUserButton.Name = "RegisterUserButton";
            RegisterUserButton.Size = new Size(185, 29);
            RegisterUserButton.TabIndex = 4;
            RegisterUserButton.Text = "Зарегистрироваться";
            RegisterUserButton.UseVisualStyleBackColor = true;
            RegisterUserButton.Click += RegisterUserButton_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(326, 248);
            Controls.Add(RegisterUserButton);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(LoginLabel);
            Name = "Registration";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginLabel;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Label PasswordLabel;
        private Button RegisterUserButton;
    }
}
