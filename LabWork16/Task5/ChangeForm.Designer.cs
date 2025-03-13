namespace Task5
{
    partial class ChangeForm
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
            SearchTextBox = new TextBox();
            ChangeTextBox = new TextBox();
            SearchLabel = new Label();
            ChangeLabel = new Label();
            ChangeButton = new Button();
            SuspendLayout();
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(12, 25);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(197, 23);
            SearchTextBox.TabIndex = 0;
            // 
            // ChangeTextBox
            // 
            ChangeTextBox.Location = new Point(12, 81);
            ChangeTextBox.Name = "ChangeTextBox";
            ChangeTextBox.Size = new Size(197, 23);
            ChangeTextBox.TabIndex = 1;
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.Location = new Point(12, 7);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(42, 15);
            SearchLabel.TabIndex = 2;
            SearchLabel.Text = "Поиск";
            // 
            // ChangeLabel
            // 
            ChangeLabel.AutoSize = true;
            ChangeLabel.Location = new Point(12, 63);
            ChangeLabel.Name = "ChangeLabel";
            ChangeLabel.Size = new Size(48, 15);
            ChangeLabel.TabIndex = 3;
            ChangeLabel.Text = "Замена";
            // 
            // ChangeButton
            // 
            ChangeButton.Location = new Point(12, 110);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(75, 23);
            ChangeButton.TabIndex = 4;
            ChangeButton.Text = "Заменить";
            ChangeButton.UseVisualStyleBackColor = true;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // ChangeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 156);
            Controls.Add(ChangeButton);
            Controls.Add(ChangeLabel);
            Controls.Add(SearchLabel);
            Controls.Add(ChangeTextBox);
            Controls.Add(SearchTextBox);
            Name = "ChangeForm";
            Text = "ChangeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchTextBox;
        private TextBox ChangeTextBox;
        private Label SearchLabel;
        private Label ChangeLabel;
        private Button ChangeButton;
    }
}