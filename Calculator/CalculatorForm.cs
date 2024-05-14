namespace Calculator
{
    public partial class FormCalculator : Form
    {
        private decimal firstNumber = 0.0m;
        private decimal secondNumber = 0.0m;
        private decimal result = 0.0m;
        private string operators;
        public FormCalculator()
        {
            InitializeComponent();
        }
              

        private void textBox1(object sender, EventArgs e)
        {

        }
             

        private void buttonResult_Click(object sender, EventArgs e)
        {
            switch(operators)
            {
                case "-":
                    secondNumber = decimal.Parse(TxtBox.Text);
                    result = firstNumber - secondNumber;
                    TxtBox.Text = result.ToString();
                    break;
                case "+":
                    secondNumber = decimal.Parse(TxtBox.Text);
                    result = firstNumber + secondNumber;
                    TxtBox.Text = result.ToString();
                    break;
                case "*":
                    secondNumber = decimal.Parse(TxtBox.Text);
                    result = firstNumber * secondNumber;
                    TxtBox.Text = result.ToString();
                    break;
                case "/":
                    secondNumber = decimal.Parse(TxtBox.Text);
                    result = firstNumber / secondNumber;
                    TxtBox.Text = result.ToString();
                    break;
                case "%":
                    secondNumber = decimal.Parse(TxtBox.Text);
                    result = firstNumber % secondNumber;
                    TxtBox.Text = result.ToString();
                    break;

            }
        }
              

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            firstNumber = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "+";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            firstNumber = 0.0m;
            secondNumber = 0.0m;
            TxtBox.Text = "0";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            firstNumber = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "-";
        }

        private void buttonDevide_Click(object sender, EventArgs e)
        {
            firstNumber = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "/";
        }

        private void buttonMultiple_Click(object sender, EventArgs e)
        {
            firstNumber = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "*";
        }

        private void buttonPlusOrMinus_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text.Contains("-"))
            {
                TxtBox.Text = TxtBox.Text.Trim('-');
            }
            else
            {
                TxtBox.Text = '-' + TxtBox.Text;
            }
        }

        private void buttonPercent(object sender, EventArgs e)
        {
            firstNumber = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "%";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "0";
            }
            else
            {
                TxtBox.Text += "0";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "1";
            }
            else
            {
                TxtBox.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "2";
            }
            else
            {
                TxtBox.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "3";
            }
            else
            {
                TxtBox.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "4";
            }
            else
            {
                TxtBox.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "5";
            }
            else
            {
                TxtBox.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "6";
            }
            else
            {
                TxtBox.Text += "6";
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "7";
            }
            else
            {
                TxtBox.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "8";
            }
            else
            {
                TxtBox.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "9";
            }
            else
            {
                TxtBox.Text += "9";
            }
        }
        private void buttonPoint(object sender, EventArgs e)
        {
            if (!TxtBox.Text.Contains("."))
            {
                TxtBox.Text += ".";
            }

        }
    }
}
