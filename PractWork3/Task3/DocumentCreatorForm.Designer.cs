namespace Task3
{
    partial class DocumentCreatorForm
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
            DescriptionTextBox = new TextBox();
            CreateDocumentButton = new Button();
            SuspendLayout();
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(12, 12);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(520, 276);
            DescriptionTextBox.TabIndex = 0;
            // 
            // CreateDocumentButton
            // 
            CreateDocumentButton.Location = new Point(12, 309);
            CreateDocumentButton.Name = "CreateDocumentButton";
            CreateDocumentButton.Size = new Size(167, 23);
            CreateDocumentButton.TabIndex = 1;
            CreateDocumentButton.Text = "Создать новый документ";
            CreateDocumentButton.UseVisualStyleBackColor = true;
            CreateDocumentButton.Click += CreateDocumentButton_Click;
            // 
            // DocumentCreatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 351);
            Controls.Add(CreateDocumentButton);
            Controls.Add(DescriptionTextBox);
            Name = "DocumentCreatorForm";
            Text = "Создание документа";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DescriptionTextBox;
        private Button CreateDocumentButton;
    }
}
