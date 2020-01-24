namespace Calculator
{
    partial class mainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.minus = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.numbersPanel = new System.Windows.Forms.Panel();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.numbersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.resultBox);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 261);
            this.panel1.TabIndex = 0;
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(225, 97);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(78, 52);
            this.minus.TabIndex = 1;
            this.minus.Text = "−";
            this.minus.UseVisualStyleBackColor = false;
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.equals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(150, 146);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(78, 52);
            this.equals.TabIndex = 2;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.multiply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(225, 49);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(78, 52);
            this.multiply.TabIndex = 3;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = false;
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.divide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(225, 0);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(78, 52);
            this.divide.TabIndex = 4;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = false;
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(225, 146);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(78, 52);
            this.plus.TabIndex = 5;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            // 
            // numbersPanel
            // 
            this.numbersPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.numbersPanel.Controls.Add(this.plus);
            this.numbersPanel.Controls.Add(this.divide);
            this.numbersPanel.Controls.Add(this.minus);
            this.numbersPanel.Controls.Add(this.equals);
            this.numbersPanel.Controls.Add(this.multiply);
            this.numbersPanel.Controls.Add(this.zero);
            this.numbersPanel.Controls.Add(this.decimalButton);
            this.numbersPanel.Controls.Add(this.three);
            this.numbersPanel.Controls.Add(this.two);
            this.numbersPanel.Controls.Add(this.one);
            this.numbersPanel.Controls.Add(this.six);
            this.numbersPanel.Controls.Add(this.five);
            this.numbersPanel.Controls.Add(this.four);
            this.numbersPanel.Controls.Add(this.nine);
            this.numbersPanel.Controls.Add(this.eight);
            this.numbersPanel.Controls.Add(this.seven);
            this.numbersPanel.Location = new System.Drawing.Point(1, 64);
            this.numbersPanel.Name = "numbersPanel";
            this.numbersPanel.Size = new System.Drawing.Size(300, 198);
            this.numbersPanel.TabIndex = 1;
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.seven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(0, 0);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(78, 52);
            this.seven.TabIndex = 6;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.eight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(75, 0);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(78, 52);
            this.eight.TabIndex = 7;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(150, 0);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(78, 52);
            this.nine.TabIndex = 8;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.four.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(0, 49);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(78, 52);
            this.four.TabIndex = 9;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.five.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(75, 49);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(78, 52);
            this.five.TabIndex = 10;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.six.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(150, 49);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(78, 52);
            this.six.TabIndex = 11;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.one.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(0, 97);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(78, 52);
            this.one.TabIndex = 12;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.two.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(75, 97);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(78, 52);
            this.two.TabIndex = 13;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.three.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(150, 97);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(78, 52);
            this.three.TabIndex = 14;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            // 
            // decimalButton
            // 
            this.decimalButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.decimalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.decimalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalButton.Location = new System.Drawing.Point(0, 146);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(78, 52);
            this.decimalButton.TabIndex = 15;
            this.decimalButton.Text = ",";
            this.decimalButton.UseVisualStyleBackColor = false;
            this.decimalButton.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.zero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(75, 146);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(78, 52);
            this.zero.TabIndex = 16;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.resultBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.resultBox.Enabled = false;
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.HideSelection = false;
            this.resultBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.resultBox.Location = new System.Drawing.Point(0, 0);
            this.resultBox.MinimumSize = new System.Drawing.Size(0, 63);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(303, 63);
            this.resultBox.TabIndex = 2;
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(303, 261);
            this.Controls.Add(this.numbersPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.numbersPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Panel numbersPanel;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.TextBox resultBox;
    }
}

