
//Form1.cs: For disigning 

namespace WinFormsApp1
{
    partial class Form1
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
            Labe1 = new Label();
            label2 = new Label();
            label3 = new Label();
            amountTextBox = new TextBox();
            rateTextBox = new TextBox();
            termNumericUpDown = new NumericUpDown();
            button1 = new Button();
            outputLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)termNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // Labe1
            // 
            Labe1.AutoSize = true;
            Labe1.Location = new Point(37, 54);
            Labe1.Name = "Labe1";
            Labe1.Size = new Size(99, 15);
            Labe1.TabIndex = 0;
            Labe1.Text = "Loan amount (P):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 101);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 1;
            label2.Text = " Annual rate (R) %:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 149);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Term (n): ";
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(181, 46);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(165, 23);
            amountTextBox.TabIndex = 3;
            // 
            // rateTextBox
            // 
            rateTextBox.Location = new Point(180, 93);
            rateTextBox.Name = "rateTextBox";
            rateTextBox.Size = new Size(166, 23);
            rateTextBox.TabIndex = 4;
            // 
            // termNumericUpDown
            // 
            termNumericUpDown.Location = new Point(178, 141);
            termNumericUpDown.Name = "termNumericUpDown";
            termNumericUpDown.Size = new Size(168, 23);
            termNumericUpDown.TabIndex = 5;
            termNumericUpDown.ValueChanged += termNumericUpDown_ValueChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(404, 32);
            button1.Name = "button1";
            button1.Size = new Size(162, 144);
            button1.TabIndex = 6;
            button1.Text = "Calculate EMI ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // outputLabel
            // 
            outputLabel.BorderStyle = BorderStyle.Fixed3D;
            outputLabel.Location = new Point(650, 32);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(150, 144);
            outputLabel.TabIndex = 7;
            outputLabel.Click += outputLabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 233);
            Controls.Add(outputLabel);
            Controls.Add(button1);
            Controls.Add(termNumericUpDown);
            Controls.Add(rateTextBox);
            Controls.Add(amountTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Labe1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Equated monthly installment";
            ((System.ComponentModel.ISupportInitialize)termNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Labe1;
        private Label label2;
        private Label label3;
        private TextBox amountTextBox;
        private TextBox rateTextBox;
        private NumericUpDown termNumericUpDown;
        private Button button1;
        private Label outputLabel;
    }
}