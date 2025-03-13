namespace Task3
{
    partial class InputForm
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
            ToForm2Button = new Button();
            SuspendLayout();
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(12, 12);
            InputTextBox.Multiline = true;
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(223, 23);
            InputTextBox.TabIndex = 0;
            // 
            // ToForm2Button
            // 
            ToForm2Button.Location = new Point(241, 12);
            ToForm2Button.Name = "ToForm2Button";
            ToForm2Button.Size = new Size(75, 23);
            ToForm2Button.TabIndex = 1;
            ToForm2Button.Text = "Замена";
            ToForm2Button.UseVisualStyleBackColor = true;
            ToForm2Button.Click += ToForm2Button_Click;
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 66);
            Controls.Add(ToForm2Button);
            Controls.Add(InputTextBox);
            Name = "InputForm";
            Text = "Форма ввода текста";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputTextBox;
        private Button ToForm2Button;
    }
}
