namespace Task3
{
    partial class Multiplication
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
            GenerateMultiplicationTableButton = new Button();
            SuspendLayout();
            // 
            // GenerateMultiplicationTableButton
            // 
            GenerateMultiplicationTableButton.Location = new Point(120, 209);
            GenerateMultiplicationTableButton.Name = "GenerateMultiplicationTableButton";
            GenerateMultiplicationTableButton.Size = new Size(216, 29);
            GenerateMultiplicationTableButton.TabIndex = 0;
            GenerateMultiplicationTableButton.Text = "Таблица умножения";
            GenerateMultiplicationTableButton.UseVisualStyleBackColor = true;
            GenerateMultiplicationTableButton.Click += GenerateMultiplicationTableButton_Click;
            // 
            // Multiplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(GenerateMultiplicationTableButton);
            MaximumSize = new Size(500, 500);
            MinimumSize = new Size(500, 500);
            Name = "Multiplication";
            Text = "Генерация таблицы умножения";
            ResumeLayout(false);
        }

        #endregion

        private Button GenerateMultiplicationTableButton;
    }
}
