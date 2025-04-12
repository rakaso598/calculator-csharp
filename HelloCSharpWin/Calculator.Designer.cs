namespace HelloCSharpWin
{
    partial class Calculator
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
            HelloLabel = new Label();
            SumNumbers = new Button();
            Sum1 = new TextBox();
            Sum2 = new TextBox();
            SumResult = new TextBox();
            SuspendLayout();
            // 
            // HelloLabel
            // 
            HelloLabel.AutoSize = true;
            HelloLabel.Cursor = Cursors.Hand;
            HelloLabel.Location = new Point(23, 27);
            HelloLabel.Name = "HelloLabel";
            HelloLabel.Size = new Size(107, 15);
            HelloLabel.TabIndex = 0;
            HelloLabel.Text = "여기를 클릭하세요";
            HelloLabel.Click += HelloLabel_Click;
            // 
            // SumNumbers
            // 
            SumNumbers.Location = new Point(167, 78);
            SumNumbers.Name = "SumNumbers";
            SumNumbers.Size = new Size(75, 23);
            SumNumbers.TabIndex = 1;
            SumNumbers.Text = "=";
            SumNumbers.UseVisualStyleBackColor = true;
            SumNumbers.Click += SumNumbers_Click;
            // 
            // Sum1
            // 
            Sum1.Location = new Point(23, 78);
            Sum1.Name = "Sum1";
            Sum1.Size = new Size(66, 23);
            Sum1.TabIndex = 3;
            // 
            // Sum2
            // 
            Sum2.Location = new Point(95, 78);
            Sum2.Name = "Sum2";
            Sum2.Size = new Size(66, 23);
            Sum2.TabIndex = 4;
            // 
            // SumResult
            // 
            SumResult.Location = new Point(248, 79);
            SumResult.Name = "SumResult";
            SumResult.Size = new Size(66, 23);
            SumResult.TabIndex = 5;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 135);
            Controls.Add(SumResult);
            Controls.Add(Sum2);
            Controls.Add(Sum1);
            Controls.Add(SumNumbers);
            Controls.Add(HelloLabel);
            Name = "Calculator";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HelloLabel;
        private Button SumNumbers;
        private TextBox Sum1;
        private TextBox Sum2;
        private TextBox SumResult;
    }
}
