
namespace WinFormsApp1
{
    public partial class MyCalculator : Form
    {
        bool isFirst = true;
        double op1, op2;
        string opr;
        int facto(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * facto(n - 1);
        }

        public MyCalculator()
        {
            InitializeComponent();
        }

        private void MyCalculator_Load(object sender, EventArgs e)
        {

        }
        private void One_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = " ";
                isFirst = false;
            }
            Screen.Text += "1";
        }
        private void Two_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = " ";
                isFirst = false;
            }
            Screen.Text += "2";
        }
        private void Four_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = " ";
                isFirst = false;
            }
            Screen.Text += "4";
        }
        private void Five_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = " ";
                isFirst = false;
            }
            Screen.Text += "5";
        }
        private void Six_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = " ";
                isFirst = false;
            }
            Screen.Text += "6";
        }
        private void Seven_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = " ";
                isFirst = false;
            }
            Screen.Text += "7";
        }
        private void Eight_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = " ";
                isFirst = false;
            }
            Screen.Text += "8";
        }
        private void Nine_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = " ";
                isFirst = false;
            }
            Screen.Text += "9";
        }
        private void Plus_Click(object sender, EventArgs e)
        {
            op1 = int.Parse(Screen.Text);
            opr = "+";
            isFirst = true;
        }
        private void Equal_Click(object sender, EventArgs e)
        {
            op2 = int.Parse(Screen.Text);
            switch (opr)
            {
                case "Factorial":
                    Screen.Text = facto(Convert.ToInt32(op2)).ToString();
                    isFirst = true;
                    break;
                case "+":
                    Screen.Text = (op1 + op2).ToString();
                    isFirst = true;
                    break;
                case "*":
                    Screen.Text = (op1 * op2).ToString();
                    isFirst = true;
                    break;
                case "-":
                    Screen.Text = (op1 - op2).ToString();
                    isFirst = true;
                    break;
                case "/":
                    Screen.Text = (op1 / op2).ToString();
                    isFirst = true;
                    break;
                case "%":
                    Screen.Text = (op1 % op2).ToString();
                    isFirst = true;
                    break;
                case "sin":
                    op2 = op2 * Math.PI / 180;
                    Screen.Text = Math.Sin(op2).ToString();
                    isFirst = true;
                    break;
                case "cos":
                    op2 = op2 * Math.PI / 180;
                    Screen.Text = Math.Cos(op2).ToString();
                    isFirst = true;
                    break;
                case "tan":
                    op2 = op2 * Math.PI / 180;
                    Screen.Text = Math.Tan(op2).ToString();
                    isFirst = true;
                    break;
                case "sinh":
                    op2 = op2 * Math.PI / 180;
                    Screen.Text = Math.Sinh(op2).ToString();
                    isFirst = true;
                    break;
                case "cosh":
                    op2 = op2 * Math.PI / 180;
                    Screen.Text = Math.Cosh(op2).ToString();
                    isFirst = true;
                    break;
                case "tanh":
                    op2 = op2 * Math.PI / 180;
                    Screen.Text = Math.Tanh(op2).ToString();
                    isFirst = true;
                    break;
                case "Power":
                    Screen.Text = Math.Pow(op1, op2).ToString();
                    isFirst = true;
                    break;
                case "log":
                    Screen.Text = Math.Log10(op2).ToString();
                    isFirst = true;
                    break;
            }
        }
        private void Mul_Click(object sender, EventArgs e)
        {
            op1 = int.Parse(Screen.Text);
            opr = "*";
            isFirst = true;
        }
        private void Minus_Click(object sender, EventArgs e)
        {
            op1 = int.Parse(Screen.Text);
            opr = "-";
            isFirst = true;
        }
        private void Div_Click(object sender, EventArgs e)
        {
            op1 = int.Parse(Screen.Text);
            opr = "/";
            isFirst = true;
        }
        private void Mod_Click(object sender, EventArgs e)
        {
            op1 = int.Parse(Screen.Text);
            opr = "%";
            isFirst = true;
        }
        private void Backspace_Click(object sender, EventArgs e)
        {
            if (Screen.TextLength > 0)
            {
                Screen.Text = Screen.Text.Remove((Screen.Text.Length - 1));
            }
        }
        private void sine_Click(object sender, EventArgs e)
        {
            opr = "sin";
            isFirst = true;
        }
        private void Zero_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = " ";
                isFirst = false;
            }
            Screen.Text += "0";
        }
        private void Cosine_Click(object sender, EventArgs e)
        {
            opr = "cos";
            isFirst = true;
        }
        private void Tangent_Click(object sender, EventArgs e)
        {
            opr = "tan";
            isFirst = true;
        }
        private void Hyperbolic_Sine_Click(object sender, EventArgs e)
        {
            opr = "sinh";
            isFirst = true;
        }
        private void Cosine_Hyperbolic_Click(object sender, EventArgs e)
        {
            opr = "cosh";
            isFirst = true;
        }
        private void Tangent_Hyperbolic_Click(object sender, EventArgs e)
        {
            opr = "tanh";
            isFirst = true;
        }
        private void Factorial_Click(object sender, EventArgs e)
        {
            opr = "Factorial";
            isFirst = true;
        }
        private void Power_Click(object sender, EventArgs e)
        {
            op1 = int.Parse(Screen.Text);
            opr = "Power";
            isFirst = true;
        }
        private void Log_Click(object sender, EventArgs e)
        {
            op1 = int.Parse(Screen.Text);
            opr = "log";
            isFirst = true;
        }
        private void Three_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = " ";
                isFirst = false;
            }
            Screen.Text += "3";
        }
    }
}