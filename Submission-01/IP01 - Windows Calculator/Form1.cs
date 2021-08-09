using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP01___Windows_Calculator
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
        private void ButtonClick(object sender, EventArgs e)
        {

 //clear textbox upon button click if the current text is either "0" OR
//when an operation has been performed
            if ((TextBoxResults.Text == "0") || (isOperationPerformed)) 
                TextBoxResults.Clear();

//set isOperationPerformed to false
            isOperationPerformed = false;

//text on button equals input
            Button button=(Button)sender;

//do not allow more than one decimal per entry
            if (button.Text == ".")
            {
                if (!TextBoxResults.Text.Contains("."))
                    TextBoxResults.Text = TextBoxResults.Text + button.Text;
            }
            else
                TextBoxResults.Text = TextBoxResults.Text + button.Text;
        }
        private void OperatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            operationPerformed = button.Text;
            resultValue = Double.Parse(TextBoxResults.Text);

            CurrentOperationLabel.Text = resultValue + " " + operationPerformed;

            isOperationPerformed = true;
        }
        private void ClearClick(object sender, EventArgs e)
        {
            TextBoxResults.Text = "0";
            resultValue = 0;
        }
        private void ClearEntryClick(object sender, EventArgs e)
        {
            TextBoxResults.Text = "0";
        }
        private void BackSpaceClick(object sender, EventArgs e)
        {
            if ((String.Compare(TextBoxResults.Text, " ") < 0))
            {
                TextBoxResults.Text = TextBoxResults.Text.Substring(0, TextBoxResults.Text.Length - 1 + 1);
            }
            else
            {
                TextBoxResults.Text = TextBoxResults.Text.Substring(0, TextBoxResults.Text.Length - 1);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void TextBoxResults_TextChanged(object sender, EventArgs e)
        {

        }
        private void ResultsClick(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+": 
                    TextBoxResults.Text = (resultValue + Double.Parse(TextBoxResults.Text)).ToString();
                    break;
                case "-":
                    TextBoxResults.Text = (resultValue - Double.Parse(TextBoxResults.Text)).ToString();
                    break;
                case "*":
                    TextBoxResults.Text = (resultValue * Double.Parse(TextBoxResults.Text)).ToString();
                    break;
                case "/":
                    TextBoxResults.Text = (resultValue / Double.Parse(TextBoxResults.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void CalculatorWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
