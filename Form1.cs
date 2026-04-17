
namespace WinFormsApp1
{
    /// <summary>
    /// A comprehensive calculator application with basic arithmetic, trigonometric, and advanced mathematical operations.
    /// </summary>
    public partial class MyCalculator : Form
    {
        /// <summary>
        /// Flag indicating whether a new number entry is starting.
        /// </summary>
        private bool _isNewEntry = true;

        /// <summary>
        /// First operand for binary operations.
        /// </summary>
        private double _firstOperand;

        /// <summary>
        /// Second operand for binary operations.
        /// </summary>
        private double _secondOperand;

        /// <summary>
        /// The current operation to be performed.
        /// </summary>
        private string _currentOperation;

        /// <summary>
        /// Calculates the factorial of a number recursively.
        /// </summary>
        /// <param name="n">The number to calculate factorial for.</param>
        /// <returns>The factorial of n.</returns>
        private int CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * CalculateFactorial(n - 1);
        }

        /// <summary>
        /// Initializes a new instance of the MyCalculator form.
        /// </summary>
        public MyCalculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the form load event.
        /// </summary>
        private void MyCalculator_Load(object sender, EventArgs e)
        {
            // Form initialization if needed
        }

        /// <summary>
        /// Appends a digit to the display screen.
        /// </summary>
        /// <param name="digit">The digit to append.</param>
        private void AppendDigit(string digit)
        {
            if (_isNewEntry)
            {
                Screen.Text = string.Empty;
                _isNewEntry = false;
            }
            Screen.Text += digit;
        }
        /// <summary>
        /// Handles the click event for the digit '1'.
        /// </summary>
        private void One_Click(object sender, EventArgs e)
        {
            AppendDigit("1");
        }

        /// <summary>
        /// Handles the click event for the digit '2'.
        /// </summary>
        private void Two_Click(object sender, EventArgs e)
        {
            AppendDigit("2");
        }

        /// <summary>
        /// Handles the click event for the digit '4'.
        /// </summary>
        private void Four_Click(object sender, EventArgs e)
        {
            AppendDigit("4");
        }

        /// <summary>
        /// Handles the click event for the digit '5'.
        /// </summary>
        private void Five_Click(object sender, EventArgs e)
        {
            AppendDigit("5");
        }

        /// <summary>
        /// Handles the click event for the digit '6'.
        /// </summary>
        private void Six_Click(object sender, EventArgs e)
        {
            AppendDigit("6");
        }

        /// <summary>
        /// Handles the click event for the digit '7'.
        /// </summary>
        private void Seven_Click(object sender, EventArgs e)
        {
            AppendDigit("7");
        }

        /// <summary>
        /// Handles the click event for the digit '8'.
        /// </summary>
        private void Eight_Click(object sender, EventArgs e)
        {
            AppendDigit("8");
        }

        /// <summary>
        /// Handles the click event for the digit '9'.
        /// </summary>
        private void Nine_Click(object sender, EventArgs e)
        {
            AppendDigit("9");
        }
        /// <summary>
        /// Handles the addition operation.
        /// </summary>
        private void Plus_Click(object sender, EventArgs e)
        {
            _firstOperand = double.Parse(Screen.Text);
            _currentOperation = "+";
            _isNewEntry = true;
        }

        /// <summary>
        /// Handles the calculation and displays the result.
        /// </summary>
        private void Equal_Click(object sender, EventArgs e)
        {
            _secondOperand = double.Parse(Screen.Text);
            double result = 0;
            bool hasError = false;

            try
            {
                switch (_currentOperation)
                {
                    case "Factorial":
                        result = CalculateFactorial(Convert.ToInt32(_secondOperand));
                        break;
                    case "+":
                        result = _firstOperand + _secondOperand;
                        break;
                    case "*":
                        result = _firstOperand * _secondOperand;
                        break;
                    case "-":
                        result = _firstOperand - _secondOperand;
                        break;
                    case "/":
                        if (_secondOperand == 0)
                        {
                            MessageBox.Show("Cannot divide by zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            hasError = true;
                        }
                        else
                        {
                            result = _firstOperand / _secondOperand;
                        }
                        break;
                    case "%":
                        if (_secondOperand == 0)
                        {
                            MessageBox.Show("Cannot calculate modulo with zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            hasError = true;
                        }
                        else
                        {
                            result = _firstOperand % _secondOperand;
                        }
                        break;
                    case "sin":
                        _secondOperand = _secondOperand * Math.PI / 180;
                        result = Math.Sin(_secondOperand);
                        break;
                    case "cos":
                        _secondOperand = _secondOperand * Math.PI / 180;
                        result = Math.Cos(_secondOperand);
                        break;
                    case "tan":
                        _secondOperand = _secondOperand * Math.PI / 180;
                        result = Math.Tan(_secondOperand);
                        break;
                    case "sinh":
                        _secondOperand = _secondOperand * Math.PI / 180;
                        result = Math.Sinh(_secondOperand);
                        break;
                    case "cosh":
                        _secondOperand = _secondOperand * Math.PI / 180;
                        result = Math.Cosh(_secondOperand);
                        break;
                    case "tanh":
                        _secondOperand = _secondOperand * Math.PI / 180;
                        result = Math.Tanh(_secondOperand);
                        break;
                    case "Power":
                        result = Math.Pow(_firstOperand, _secondOperand);
                        break;
                    case "log":
                        if (_secondOperand <= 0)
                        {
                            MessageBox.Show("Logarithm requires a positive number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            hasError = true;
                        }
                        else
                        {
                            result = Math.Log10(_secondOperand);
                        }
                        break;
                }

                if (!hasError)
                {
                    Screen.Text = result.ToString();
                    _isNewEntry = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _isNewEntry = true;
            }
        }

        /// <summary>
        /// Handles the multiplication operation.
        /// </summary>
        private void Mul_Click(object sender, EventArgs e)
        {
            _firstOperand = double.Parse(Screen.Text);
            _currentOperation = "*";
            _isNewEntry = true;
        }

        /// <summary>
        /// Handles the subtraction operation.
        /// </summary>
        private void Minus_Click(object sender, EventArgs e)
        {
            _firstOperand = double.Parse(Screen.Text);
            _currentOperation = "-";
            _isNewEntry = true;
        }

        /// <summary>
        /// Handles the division operation.
        /// </summary>
        private void Div_Click(object sender, EventArgs e)
        {
            _firstOperand = double.Parse(Screen.Text);
            _currentOperation = "/";
            _isNewEntry = true;
        }

        /// <summary>
        /// Handles the modulo operation.
        /// </summary>
        private void Mod_Click(object sender, EventArgs e)
        {
            _firstOperand = double.Parse(Screen.Text);
            _currentOperation = "%";
            _isNewEntry = true;
        }
        /// <summary>
        /// Handles the backspace operation to remove the last digit.
        /// </summary>
        private void Backspace_Click(object sender, EventArgs e)
        {
            if (Screen.TextLength > 0)
            {
                Screen.Text = Screen.Text.Remove((Screen.Text.Length - 1));
            }
        }

        /// <summary>
        /// Handles the sine operation.
        /// </summary>
        private void sine_Click(object sender, EventArgs e)
        {
            _currentOperation = "sin";
            _isNewEntry = true;
        }

        /// <summary>
        /// Handles the click event for the digit '0'.
        /// </summary>
        private void Zero_Click(object sender, EventArgs e)
        {
            AppendDigit("0");
        }

        /// <summary>
        /// Handles the cosine operation.
        /// </summary>
        private void Cosine_Click(object sender, EventArgs e)
        {
            _currentOperation = "cos";
            _isNewEntry = true;
        }

        /// <summary>
        /// Handles the tangent operation.
        /// </summary>
        private void Tangent_Click(object sender, EventArgs e)
        {
            _currentOperation = "tan";
            _isNewEntry = true;
        }

        /// <summary>
        /// Handles the hyperbolic sine operation.
        /// </summary>
        private void Hyperbolic_Sine_Click(object sender, EventArgs e)
        {
            _currentOperation = "sinh";
            _isNewEntry = true;
        }

        /// <summary>
        /// Handles the hyperbolic cosine operation.
        /// </summary>
        private void Cosine_Hyperbolic_Click(object sender, EventArgs e)
        {
            _currentOperation = "cosh";
            _isNewEntry = true;
        }

        /// <summary>
        /// Handles the hyperbolic tangent operation.
        /// </summary>
        private void Tangent_Hyperbolic_Click(object sender, EventArgs e)
        {
            _currentOperation = "tanh";
            _isNewEntry = true;
        }

        /// <summary>
        /// Handles the factorial operation.
        /// </summary>
        private void Factorial_Click(object sender, EventArgs e)
        {
            _currentOperation = "Factorial";
            _isNewEntry = true;
        }

        /// <summary>
        /// Handles the power operation.
        /// </summary>
        private void Power_Click(object sender, EventArgs e)
        {
            _firstOperand = double.Parse(Screen.Text);
            _currentOperation = "Power";
            _isNewEntry = true;
        }

        /// <summary>
        /// Handles the logarithm (base 10) operation.
        /// </summary>
        private void Log_Click(object sender, EventArgs e)
        {
            _firstOperand = double.Parse(Screen.Text);
            _currentOperation = "log";
            _isNewEntry = true;
        }

        /// <summary>
        /// Handles the click event for the digit '3'.
        /// </summary>
        private void Three_Click(object sender, EventArgs e)
        {
            AppendDigit("3");
        }
    }
}