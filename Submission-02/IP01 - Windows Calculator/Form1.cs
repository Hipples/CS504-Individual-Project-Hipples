using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySimpleCalculator
{
    public partial class CalculatorWindow : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public CalculatorWindow()
        {
            InitializeComponent();
        }

//Value Input [ 0 ] - [ 9 ] or [ . ]
        private void ValueInput(object sender, EventArgs e)
        {

     //clear textbox upon button click if the current text is either "0" OR
    //when an operation has been performed
            if ((TextBox.Text == "0") || (isOperationPerformed)) 
               TextBox.Clear();

    //set isOperationPerformed to false
            isOperationPerformed = false;

    //text on button equals user input
            Button button=(Button)sender;

    //do not allow more than one decimal per entry
            if (button.Text == ".")
            {
                if (!TextBox.Text.Contains("."))
                    TextBox.Text = TextBox.Text + button.Text;
            }
            else
                TextBox.Text = TextBox.Text + button.Text;
        }

//Operators  [ + ]  [ - ]  [ / ]  [ * ]
        private void Operators(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            operationPerformed = button.Text;
            resultValue = Double.Parse(TextBox.Text);

        //Push user input to label above textbox
            CurrentOperationLabel.Text = resultValue + " " + operationPerformed;

            isOperationPerformed = true;
        }

//Clear All  [ C ]
        private void ClearAll(object sender, EventArgs e)
        {
            TextBox.Text = "0";
            resultValue = 0;
        }

//Clear Entry  [ CE ]
        private void ClearEntry(object sender, EventArgs e)
        {
            TextBox.Text = "0";
        }

//Backspace  [ < ] 
        private void BackSpace(object sender, EventArgs e)
        {
            if ((String.Compare(TextBox.Text, " ") < 0))
            {
                TextBox.Text = TextBox.Text.Substring(0, TextBox.Text.Length - 1 + 1);
            }
            else
            {
                TextBox.Text = TextBox.Text.Substring(0, TextBox.Text.Length - 1);
            }
        }

//Calculate  [ = ]
        private void Calculate(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+": 
                    TextBox.Text = (resultValue + Double.Parse(TextBox.Text)).ToString();
                    break;
                case "-":
                    TextBox.Text = (resultValue - Double.Parse(TextBox.Text)).ToString();
                    break;
                case "*":
                    TextBox.Text = (resultValue * Double.Parse(TextBox.Text)).ToString();
                    break;
                case "/":
                    TextBox.Text = (resultValue / Double.Parse(TextBox.Text)).ToString();
                    break;
                default:
                    break;
            }

    //Push results to be stored on CurrentOperationLabel. 
            resultValue = Double.Parse(TextBox.Text);
            CurrentOperationLabel.Text = "";
        }
    }
}
//Cannot do more than a + b, that is, cannot perform multistep operations without applying the equal sign between every other value. 