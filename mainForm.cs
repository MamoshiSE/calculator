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
        
        Double value = 0;
        Double value2 = 0;
        String calc = "";
        bool operation_pressed;
        bool divByZero;
        String operatorSign;
        public mainForm()
        {


            InitializeComponent();
            // För bli av med knapparnas kanter
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
            // Beroende på vilken knapp som klickas så utförs den knappens händelse
      
            switch (e.KeyChar.ToString())
            {
                case ",":
                    decimalButton.PerformClick();
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
            // ifall "första värdet" är inslaget eller värdet är 0 så vill vi rensa inputs textboxen
            if (resultBox.Text == "0" || operation_pressed)
            {
                resultBox.Text = "";
                
            }
            // för att bli av med "Divide by zero" texten
            if (divByZero == true)
            {
                calcDisplay.Text = resultBox.Text;
            }
            operation_pressed = false;
            Button pressed = (Button)sender;

            // kollar så att man inte kan slå in fler än 1 decimal
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
            resultBox.Text = "0";
            calcDisplay.Text = "";
            value = 0;
            value2 = 0;
        }

        private void operation_Click(object sender, EventArgs e)
        {
            // Kollar vilken av operationerna som ska utföras
            // fick idén till operationerna från https://www.youtube.com/watch?v=Is1EHXFhEe4
            Button pressed = (Button)sender;
            if (divByZero == true)
            {
                calcDisplay.Text = resultBox.Text;
                divByZero = false;
            }

            else
            {

                calc = pressed.Text;
                value = Double.Parse(resultBox.Text);
                value2 = 0;
                operatorSign = calc;
                operation_pressed = true;
                calcDisplay.Text = $"{resultBox.Text} {calc} ";
            }

        }

        private void equals_Click(object sender, EventArgs e)
        {
            // Vid upprepade tryck av "=" så repeteras senaste operationen
            if (operation_pressed == false && (calc == "" || calc == "=") && divByZero == false)
            {
                switch (operatorSign)
                {
                    case "+":
                        resultBox.Text = (value + value2).ToString();
                        break;

                    case "−":
                        resultBox.Text = (value - value2).ToString();
                        break;

                    case "x":
                        resultBox.Text = (value * value2).ToString();
                        break;

                    case "÷":
                        resultBox.Text = (value / value2).ToString();
                        break;

                    default:
                        break;
                }
                
            }
           // Utför en av operationerna beroende på vilken som är tryckt.
            switch (calc)
            {
                case "+":
                    
                    value2 = Double.Parse(resultBox.Text);
                    resultBox.Text = (value + Double.Parse(resultBox.Text)).ToString();
                    break;

                case "−":
                    value2 = Double.Parse(resultBox.Text);
                    resultBox.Text = (value - Double.Parse(resultBox.Text)).ToString();
                    break;

                case "x":
                    value2 = Double.Parse(resultBox.Text);
                    resultBox.Text = (value * Double.Parse(resultBox.Text)).ToString();
                    break;

                case "÷":
                    value2 = Double.Parse(resultBox.Text);
                    resultBox.Text = (value / Double.Parse(resultBox.Text)).ToString();

                    break;

                default:
                    break;
            }
            // Kollar ifall man försökt dividera med 0
            if (calc == "÷" && resultBox.Text  == "∞")
            {
                
                    divByZero = true;
                    calcDisplay.Text = "Divison by zero not allowed";
                    value = 0;
                    value2 = 0;
                    resultBox.Text = "0";
                    calc = "";
                
            }
            else
            {
                value = Double.Parse(resultBox.Text);
                calcDisplay.Text = resultBox.Text;
                calc = "";
                operation_pressed = false;

            }
        }
        // Input från tangentbord. enter är = , delete är C (clear knappen), backspace tar bort senaste inmatningen 
        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                equals.PerformClick();
            }

            if (e.KeyCode == Keys.Delete)
            {
                clearInput.PerformClick();
            }

            if (e.KeyCode == Keys.Back)
            {
                backSpaceButton.PerformClick();
            }
        }
    }
}

