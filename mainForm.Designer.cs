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
            this.numbersPanel = new System.Windows.Forms.Panel();
            this.clearInput = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.backSpaceButton = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.calcDisplay = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.numbersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.calcDisplay);
            this.panel1.Controls.Add(this.numbersPanel);
            this.panel1.Controls.Add(this.resultBox);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.MaximumSize = new System.Drawing.Size(295, 289);
            this.panel1.MinimumSize = new System.Drawing.Size(295, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 289);
            this.panel1.TabIndex = 0;
            // 
            // numbersPanel
            // 
            this.numbersPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.numbersPanel.Controls.Add(this.clearInput);
            this.numbersPanel.Controls.Add(this.six);
            this.numbersPanel.Controls.Add(this.plus);
            this.numbersPanel.Controls.Add(this.backSpaceButton);
            this.numbersPanel.Controls.Add(this.minus);
            this.numbersPanel.Controls.Add(this.equals);
            this.numbersPanel.Controls.Add(this.multiply);
            this.numbersPanel.Controls.Add(this.divide);
            this.numbersPanel.Controls.Add(this.decimalButton);
            this.numbersPanel.Controls.Add(this.zero);
            this.numbersPanel.Controls.Add(this.three);
            this.numbersPanel.Controls.Add(this.two);
            this.numbersPanel.Controls.Add(this.one);
            this.numbersPanel.Controls.Add(this.five);
            this.numbersPanel.Controls.Add(this.four);
            this.numbersPanel.Controls.Add(this.nine);
            this.numbersPanel.Controls.Add(this.eight);
            this.numbersPanel.Controls.Add(this.seven);
            this.numbersPanel.Location = new System.Drawing.Point(11, 72);
            this.numbersPanel.Name = "numbersPanel";
            this.numbersPanel.Size = new System.Drawing.Size(270, 198);
            this.numbersPanel.TabIndex = 1;
            // 
            // clearInput
            // 
            this.clearInput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.clearInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clearInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearInput.Location = new System.Drawing.Point(217, 58);
            this.clearInput.Name = "clearInput";
            this.clearInput.Size = new System.Drawing.Size(53, 74);
            this.clearInput.TabIndex = 19;
            this.clearInput.Text = "C";
            this.clearInput.UseVisualStyleBackColor = false;
            this.clearInput.Click += new System.EventHandler(this.clearInput_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.six.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(110, 49);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(58, 52);
            this.six.TabIndex = 11;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.button_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(161, 146);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(58, 52);
            this.plus.TabIndex = 5;
            this.plus.TabStop = false;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.operation_Click);
            // 
            // backSpaceButton
            // 
            this.backSpaceButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.backSpaceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backSpaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backSpaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backSpaceButton.Location = new System.Drawing.Point(216, -4);
            this.backSpaceButton.Name = "backSpaceButton";
            this.backSpaceButton.Size = new System.Drawing.Size(53, 64);
            this.backSpaceButton.TabIndex = 18;
            this.backSpaceButton.Text = "DEL";
            this.backSpaceButton.UseVisualStyleBackColor = false;
            this.backSpaceButton.Click += new System.EventHandler(this.backSpaceButton_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(161, 97);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(58, 52);
            this.minus.TabIndex = 1;
            this.minus.TabStop = false;
            this.minus.Text = "−";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.operation_Click);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.equals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(216, 129);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(53, 69);
            this.equals.TabIndex = 2;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.multiply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(161, 49);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(58, 52);
            this.multiply.TabIndex = 3;
            this.multiply.TabStop = false;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.operation_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.divide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(161, 0);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(58, 52);
            this.divide.TabIndex = 4;
            this.divide.TabStop = false;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.operation_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.decimalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.decimalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalButton.Location = new System.Drawing.Point(110, 146);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(58, 52);
            this.decimalButton.TabIndex = 15;
            this.decimalButton.Text = ",";
            this.decimalButton.UseVisualStyleBackColor = false;
            this.decimalButton.Click += new System.EventHandler(this.button_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.zero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(0, 146);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(113, 52);
            this.zero.TabIndex = 16;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.button_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.three.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(110, 97);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(58, 52);
            this.three.TabIndex = 14;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.button_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.two.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(55, 97);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(58, 52);
            this.two.TabIndex = 13;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.button_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.one.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(0, 97);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(58, 52);
            this.one.TabIndex = 12;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.button_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.five.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(55, 49);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(58, 52);
            this.five.TabIndex = 10;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.button_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.four.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(0, 49);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(58, 52);
            this.four.TabIndex = 9;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.button_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(110, 0);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(58, 52);
            this.nine.TabIndex = 8;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.button_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.eight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(55, 0);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(58, 52);
            this.eight.TabIndex = 7;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.button_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.seven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(0, 0);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(58, 52);
            this.seven.TabIndex = 6;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.button_Click);
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.resultBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.resultBox.Enabled = false;
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.HideSelection = false;
            this.resultBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.resultBox.Location = new System.Drawing.Point(11, 33);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(269, 31);
            this.resultBox.TabIndex = 2;
            this.resultBox.Text = "0";
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // calcDisplay
            // 
            this.calcDisplay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.calcDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calcDisplay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.calcDisplay.Enabled = false;
            this.calcDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcDisplay.Location = new System.Drawing.Point(11, 12);
            this.calcDisplay.Name = "calcDisplay";
            this.calcDisplay.ReadOnly = true;
            this.calcDisplay.Size = new System.Drawing.Size(261, 15);
            this.calcDisplay.TabIndex = 1;
            this.calcDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(295, 288);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "mainForm";
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainForm_KeyPress);
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
        private System.Windows.Forms.Button backSpaceButton;
        private System.Windows.Forms.Button clearInput;
        private System.Windows.Forms.TextBox calcDisplay;
    }
}

