namespace Task5
{
    partial class MainForm
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
            InputTextBox = new TextBox();
            OpenChangeFormButton = new Button();
            SuspendLayout();
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(12, 12);
            InputTextBox.Multiline = true;
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(284, 144);
            InputTextBox.TabIndex = 0;
            // 
            // OpenChangeFormButton
            // 
            OpenChangeFormButton.Location = new Point(12, 162);
            OpenChangeFormButton.Name = "OpenChangeFormButton";
            OpenChangeFormButton.Size = new Size(75, 23);
            OpenChangeFormButton.TabIndex = 1;
            OpenChangeFormButton.Text = "Замена";
            OpenChangeFormButton.UseVisualStyleBackColor = true;
            OpenChangeFormButton.Click += OpenChangeFormButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 200);
            Controls.Add(OpenChangeFormButton);
            Controls.Add(InputTextBox);
            Name = "MainForm";
            Text = "Главная форма";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputTextBox;
        private Button OpenChangeFormButton;
    }
}
