using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class mainForm : Form

    {
        // fick idén till operationerna från https://www.youtube.com/watch?v=Is1EHXFhEe4
        Double value = 0;
        String calc = "";
        bool operation_pressed;
        bool divByZero;
        public mainForm()
        {


            InitializeComponent();
            plus.FlatAppearance.BorderSize = 0;
            minus.FlatAppearance.BorderSize = 0;
            multiply.FlatAppearance.BorderSize = 0;
            divide.FlatAppearance.BorderSize = 0;
            equals.FlatAppearance.BorderSize = 0;
            one.FlatAppearance.BorderSize = 0;
            two.FlatAppearance.BorderSize = 0;
            three.FlatAppearance.BorderSize = 0;
            four.FlatAppearance.BorderSize = 0;
            five.FlatAppearance.BorderSize = 0;
            six.FlatAppearance.BorderSize = 0;
            seven.FlatAppearance.BorderSize = 0;
            eight.FlatAppearance.BorderSize = 0;
            nine.FlatAppearance.BorderSize = 0;
            zero.FlatAppearance.BorderSize = 0;
            decimalButton.FlatAppearance.BorderSize = 0;
            clearInput.FlatAppearance.BorderSize = 0;
            backSpaceButton.FlatAppearance.BorderSize = 0;



        }


        private void mainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kunde inte hitta strängen för backspace - gjorde med nyckeln istället
            if(e.KeyChar == 8)
            {
                backSpaceButton.PerformClick();
            }

           /* if (e.KeyChar == 13)
            {
                equals.PerformClick();
            } */
            switch (e.KeyChar.ToString())
            {
                case ",":
                    decimalButton.PerformClick();
                    break;


                case "c":
                    clearInput.PerformClick();
                    break;

                case "0":
                    zero.PerformClick();
                    break;

                case "1":
                    one.PerformClick();
                    break;

                case "2":
                    two.PerformClick();
                    break;

                case "3":
                    three.PerformClick();
                    break;

                case "4":
                    four.PerformClick();
                    break;

                case "5":
                    five.PerformClick();
                    break;

                case "6":
                    six.PerformClick();
                    break;

                case "7":
                    seven.PerformClick();
                    break;

                case "8":
                    eight.PerformClick();
                    break;

                case "9":
                    nine.PerformClick();
                    break;

                case "+":
                    plus.PerformClick();
                    break;

                case "-":
                    minus.PerformClick();
                    break;

                case "*":
                    multiply.PerformClick();
                    break;

                case "/":
                    divide.PerformClick();
                    break;

                case "=":
                    equals.PerformClick();
                    break;

                case "Enter":
                    equals.PerformClick();
                    break;

                default:
                    break;
            }
        }

        private void backSpaceButton_Click(object sender, EventArgs e)
        {
            if (resultBox.Text != "" && calcDisplay.Text != "")
            {
                resultBox.Text = resultBox.Text.Substring(0, resultBox.Text.Length - 1);
                calcDisplay.Text = calcDisplay.Text.Substring(0, calcDisplay.Text.Length - 1);
            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" || operation_pressed)
            {
                resultBox.Text = "";
            }
            operation_pressed = false;
            Button pressed = (Button)sender;

            if (pressed.Text == ",")
            {
                if (!resultBox.Text.Contains(","))
                {
                    resultBox.Text += pressed.Text;
                    calcDisplay.Text += pressed.Text;
                }
            }
            else
            {

                resultBox.Text += pressed.Text;
                calcDisplay.Text += pressed.Text;
            }
        }





        private void clearInput_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            calcDisplay.Text = "";
            value = 0;
        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button pressed = (Button)sender;
            if (divByZero == true)
            {
                calcDisplay.Text = resultBox.Text;
                divByZero = false;
            }

            
            if (value != 0)
            {

                equals.PerformClick();
                operation_pressed = true;
                calc = pressed.Text;
                calcDisplay.Text = $"{resultBox.Text} {calc} ";
            } 
            else
            {

                calc = pressed.Text;
                value = Double.Parse(resultBox.Text);
                operation_pressed = true;
                calcDisplay.Text = $"{resultBox.Text} {calc} ";
            }

        }

        private void equals_Click(object sender, EventArgs e)
        {
            switch (calc)
            {
                case "+":
                    resultBox.Text = (Double.Parse(resultBox.Text) + value).ToString();
                    break;

                case "−":
                    resultBox.Text = (value - Double.Parse(resultBox.Text)).ToString();
                    break;

                case "x":
                    resultBox.Text = (value * Double.Parse(resultBox.Text)).ToString();
                    break;

                case "÷":

                    resultBox.Text = (value / Double.Parse(resultBox.Text)).ToString();

                    break;

                default:
                    break;
            }
            if (calc == "÷")
            {
                if (resultBox.Text == "∞")
                {
                    divByZero = true;
                    calcDisplay.Text = "Divison by zero not allowed";
                    value = 0;
                    resultBox.Text = "0";
                }
            }
            else
            {
                value = Double.Parse(resultBox.Text);
                calcDisplay.Text = resultBox.Text;
            
                operation_pressed = false;

            }
        }
    }
}

