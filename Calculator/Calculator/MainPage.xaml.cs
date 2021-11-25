using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        private StringBuilder userInput = new StringBuilder();
        private StringBuilder solution = new StringBuilder();
        private char op = ' ';

        public MainPage()
        {
            InitializeComponent();
        }
        private void UpdateLabels()
        {
            lblInput.Text = userInput.ToString();
            lblSolution.Text = solution.ToString();
        }
        private void BtnAdd_Clicked(object sender, EventArgs e)
        {
            userInput.Append("+");
            op = '+';
            UpdateLabels();
        }
        private void BtnSubtract_Clicked(object sender, EventArgs e)
        {
            userInput.Append("-");
            op = '-';
            UpdateLabels();
        }
        private void BtnMultiply_Clicked(object sender, EventArgs e)
        {
            userInput.Append("*");
            op = '*';
            UpdateLabels();
        }
        private void BtnDivide_Clicked(object sender, EventArgs e)
        {
            userInput.Append("÷");
            op = '÷';
            UpdateLabels();
        }
        private void BtnClear_Clicked(object sender, EventArgs e)
        {
            userInput.Clear();
            solution.Clear();
            UpdateLabels();
        }
        private void BtnZero_Clicked(object sender, EventArgs e)
        {
            userInput.Append("0");
            UpdateLabels();
        }
        private void BtnOne_Clicked(object sender, EventArgs e)
        {
            userInput.Append("1");
            UpdateLabels();
        }
        private void BtnTwo_Clicked(object sender, EventArgs e)
        {
            userInput.Append("2");
            UpdateLabels();
        }
        private void BtnThree_Clicked(object sender, EventArgs e)
        {
            userInput.Append("3");
            UpdateLabels();
        }
        private void BtnFour_Clicked(object sender, EventArgs e)
        {
            userInput.Append("4");
            UpdateLabels();
        }
        private void BtnFive_Clicked(object sender, EventArgs e)
        {
            userInput.Append("5");
            UpdateLabels();
        }
        private void BtnSix_Clicked(object sender, EventArgs e)
        {
            userInput.Append("6");
            UpdateLabels();
        }
        private void BtnSeven_Clicked(object sender, EventArgs e)
        {
            userInput.Append("7");
            UpdateLabels();
        }
        private void BtnEight_Clicked(object sender, EventArgs e)
        {
            userInput.Append("8");
            UpdateLabels();
        }
        private void BtnNine_Clicked(object sender, EventArgs e)
        {
            userInput.Append("9");
            UpdateLabels();
        }
        private void BtnDelete_Clicked(object sender, EventArgs e)
        {
            userInput.Length--;
            UpdateLabels();
        }
        private void BtnEquals_Clicked(object sender, EventArgs e)
        {
            double num1;
            double num2;
            double result = 0;

            char[] symbol = { '+', '-', '*', '/' };

            string[] operands = userInput.ToString().Split(symbol);
            num1 = int.Parse(operands[0]);
            num2 = int.Parse(operands[1]);

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '÷':
                    result = num1 / num2;
                    break;
            }
            solution = new StringBuilder(result.ToString());

            UpdateLabels();
        }
    }
}
