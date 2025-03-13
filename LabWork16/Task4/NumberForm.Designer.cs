namespace Task4
{
    partial class NumberForm
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
            button0 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            ClearButton = new Button();
            numberTextBox = new TextBox();
            SuspendLayout();
            // 
            // button0
            // 
            button0.Location = new Point(48, 10);
            button0.Name = "button0";
            button0.Size = new Size(75, 23);
            button0.TabIndex = 0;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += DigitButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(48, 39);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += DigitButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(48, 68);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += DigitButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(48, 97);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += DigitButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(48, 126);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += DigitButton_Click;
            // 
            // button5
            // 
            button5.Location = new Point(48, 155);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += DigitButton_Click;
            // 
            // button6
            // 
            button6.Location = new Point(48, 184);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += DigitButton_Click;
            // 
            // button7
            // 
            button7.Location = new Point(48, 213);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += DigitButton_Click;
            // 
            // button8
            // 
            button8.Location = new Point(48, 242);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += DigitButton_Click;
            // 
            // button9
            // 
            button9.Location = new Point(48, 271);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += DigitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(48, 338);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(75, 23);
            ClearButton.TabIndex = 11;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // numberTextBox
            // 
            numberTextBox.Location = new Point(37, 300);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(100, 23);
            numberTextBox.TabIndex = 12;
            // 
            // NumberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(177, 462);
            Controls.Add(numberTextBox);
            Controls.Add(ClearButton);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button0);
            Name = "NumberForm";
            Text = "Номер";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button0;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button ClearButton;
        private TextBox numberTextBox;
    }
}
