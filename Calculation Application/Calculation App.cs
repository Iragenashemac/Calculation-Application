using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculation_Application
{
    public partial class Calculate : Form
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string  operators = "+";

        public Calculate()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "0";
            }
            else
            {
                TextBox.Text += "0";
            }

        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (!TextBox.Text.Contains("."))
            {
                TextBox.Text += ".";
            }

        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "1";
            }
            else
            {
                TextBox.Text += "1";
            }
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "2";
            }
            else
            {
                TextBox.Text += "2";
            }

        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "3";
            }
            else
            {
                TextBox.Text += "3";
            }

        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "4";
            }
            else
            {
                TextBox.Text += "4";
            }

        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "5";
            }
            else
            {
                TextBox.Text += "5";
            }

        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "6";
            }
            else
            {
                TextBox.Text += "6";
            }

        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "7";
            }
            else
            {
                TextBox.Text += "7";
            }

        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "8";
            }
            else
            {
                TextBox.Text += "8";
            }

        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "9";
            }
            else
            {
                TextBox.Text += "9";
            }
        }

        private void PlusMinusBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Contains("-"))
            {
                TextBox.Text = TextBox.Text.Trim('-');
            }
            else
            {
                TextBox.Text = "-" + TextBox.Text;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "-";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "+";
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "/";
        }

        private void MultiplicationBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "*";
        }

        private void ModulusBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "%";
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            switch (operators)
            {

                case "+":
                    valueSecond = decimal.Parse(TextBox.Text);
                    Result = valueFirst + valueSecond;
                    TextBox.Text = Result.ToString();
                    break;

                case "-":
                    valueSecond = decimal.Parse(TextBox.Text);
                    Result = valueFirst - valueSecond;
                    TextBox.Text = Result.ToString();
                    break;

                case "/":
                    valueSecond = decimal.Parse(TextBox.Text);
                    Result = valueFirst / valueSecond;
                    TextBox.Text = Result.ToString();
                    break;

                case "*":
                    valueSecond = decimal.Parse(TextBox.Text);
                    Result = valueFirst * valueSecond;
                    TextBox.Text = Result.ToString();
                    break;

                case "%":
                    valueSecond = decimal.Parse(TextBox.Text);
                    Result = valueFirst % valueSecond;
                    TextBox.Text = Result.ToString();
                    break;


            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            TextBox.Text = "0";
            valueFirst = 0.0m;
            valueSecond = 0.0m;
            Result = 0.0m;
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                TextBox.Text = TextBox.Text.Substring(0, TextBox.Text.Length - 1);
            }

            // Optional: Reset to "0" if TextBox is empty after deletion
            if (TextBox.Text == "")
            {
                TextBox.Text = "0";
            }
        }
    }
}
