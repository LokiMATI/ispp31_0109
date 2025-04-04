namespace Task1
{
    partial class TemplateFillForm
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
            DiscriptionTextBox = new TextBox();
            TaskCountTextBox = new TextBox();
            TaskCountLabel = new Label();
            CreateDocumentButton = new Button();
            SuspendLayout();
            // 
            // DiscriptionTextBox
            // 
            DiscriptionTextBox.Location = new Point(12, 12);
            DiscriptionTextBox.Multiline = true;
            DiscriptionTextBox.Name = "DiscriptionTextBox";
            DiscriptionTextBox.Size = new Size(386, 232);
            DiscriptionTextBox.TabIndex = 0;
            // 
            // TaskCountTextBox
            // 
            TaskCountTextBox.Location = new Point(12, 273);
            TaskCountTextBox.Name = "TaskCountTextBox";
            TaskCountTextBox.Size = new Size(119, 23);
            TaskCountTextBox.TabIndex = 1;
            // 
            // TaskCountLabel
            // 
            TaskCountLabel.AutoSize = true;
            TaskCountLabel.Location = new Point(12, 255);
            TaskCountLabel.Name = "TaskCountLabel";
            TaskCountLabel.Size = new Size(119, 15);
            TaskCountLabel.TabIndex = 2;
            TaskCountLabel.Text = "Количество заданий";
            // 
            // CreateDocumentButton
            // 
            CreateDocumentButton.Location = new Point(12, 302);
            CreateDocumentButton.Name = "CreateDocumentButton";
            CreateDocumentButton.Size = new Size(200, 23);
            CreateDocumentButton.TabIndex = 3;
            CreateDocumentButton.Text = "Создать документ по шаблону";
            CreateDocumentButton.UseVisualStyleBackColor = true;
            CreateDocumentButton.Click += CreateDocumentButton_Click;
            // 
            // TemplateFillForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CreateDocumentButton);
            Controls.Add(TaskCountLabel);
            Controls.Add(TaskCountTextBox);
            Controls.Add(DiscriptionTextBox);
            Name = "TemplateFillForm";
            Text = "Заполнение шаблона";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DiscriptionTextBox;
        private TextBox TaskCountTextBox;
        private Label TaskCountLabel;
        private Button CreateDocumentButton;
    }
}
