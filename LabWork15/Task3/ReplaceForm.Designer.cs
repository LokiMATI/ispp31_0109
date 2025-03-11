namespace Task3
{
    partial class ReplaceForm
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
            ReplaceTextBox = new TextBox();
            ReplaceButton = new Button();
            SearchLable = new Label();
            ReplaceLabel = new Label();
            SuspendLayout();
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(12, 28);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(221, 23);
            SearchTextBox.TabIndex = 0;
            // 
            // ReplaceTextBox
            // 
            ReplaceTextBox.Location = new Point(12, 82);
            ReplaceTextBox.Name = "ReplaceTextBox";
            ReplaceTextBox.Size = new Size(221, 23);
            ReplaceTextBox.TabIndex = 1;
            // 
            // ReplaceButton
            // 
            ReplaceButton.Location = new Point(12, 111);
            ReplaceButton.Name = "ReplaceButton";
            ReplaceButton.Size = new Size(75, 23);
            ReplaceButton.TabIndex = 2;
            ReplaceButton.Text = "Заменить";
            ReplaceButton.UseVisualStyleBackColor = true;
            ReplaceButton.Click += ReplaceButton_Click;
            // 
            // SearchLable
            // 
            SearchLable.AutoSize = true;
            SearchLable.Location = new Point(12, 10);
            SearchLable.Name = "SearchLable";
            SearchLable.Size = new Size(44, 15);
            SearchLable.TabIndex = 3;
            SearchLable.Text = "Найти:";
            // 
            // ReplaceLabel
            // 
            ReplaceLabel.AutoSize = true;
            ReplaceLabel.Location = new Point(12, 64);
            ReplaceLabel.Name = "ReplaceLabel";
            ReplaceLabel.Size = new Size(63, 15);
            ReplaceLabel.TabIndex = 4;
            ReplaceLabel.Text = "Заменить:";
            // 
            // ReplaceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 156);
            Controls.Add(ReplaceLabel);
            Controls.Add(SearchLable);
            Controls.Add(ReplaceButton);
            Controls.Add(ReplaceTextBox);
            Controls.Add(SearchTextBox);
            Name = "ReplaceForm";
            Text = "Форма замены текста";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchTextBox;
        private TextBox ReplaceTextBox;
        private Button ReplaceButton;
        private Label SearchLable;
        private Label ReplaceLabel;
    }
}