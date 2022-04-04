
namespace Calculator
{
    public partial class Form1 : Form
    {
        double num1;
        double num2;
        char sign;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            textBox1.TextAlign = HorizontalAlignment.Right;

        }

        private void one_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "0";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();
            textBox1.ResetText();
            this.num1 = 0;
            this.num2 = 0;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            if (richTextBox1.Text.Length > 0)
            {
                this.num1 = Convert.ToDouble(richTextBox1.Text);
                textBox1.SelectedText = richTextBox1.Text + " + ";
                richTextBox1.ResetText();

            }
            this.sign = '+';
        }



        private void minus_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            if (richTextBox1.Text.Length > 0)
            {
                this.num1 = Convert.ToDouble(richTextBox1.Text);
                textBox1.SelectedText = richTextBox1.Text + " - ";
                richTextBox1.ResetText();

            }
            this.sign = '-';

        }



        private void divide_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            if (richTextBox1.Text.Length > 0)
            {
                this.num1 = Convert.ToDouble(richTextBox1.Text);
                textBox1.SelectedText = richTextBox1.Text + " / ";
                richTextBox1.ResetText();

            }
            this.sign = '/';
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                this.num1 = Convert.ToDouble(richTextBox1.Text);
                textBox1.SelectedText = richTextBox1.Text + " * ";
                richTextBox1.ResetText();

            }
            this.sign = '*';
        }
        private void button8_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text.Length > 0)
            {
                double num = Convert.ToDouble(richTextBox1.Text);
                richTextBox1.ResetText();
                richTextBox1.SelectedText = (num / 100).ToString("#.##");
            }

        }


        private void fraction_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                if (this.num1 > 0 && this.num2 == 0)
                {
                    MessageBox.Show("Can not divide number with zero");
                }
                double num = Convert.ToDouble(richTextBox1.Text);
                richTextBox1.ResetText();
                richTextBox1.SelectedText = (1 / num).ToString("#.##");
            }

        }

        private void square_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                double num = Convert.ToDouble(richTextBox1.Text);
                richTextBox1.ResetText();
                richTextBox1.SelectedText = Convert.ToString(num * num);
            }

        }

        private void root_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                double num = Convert.ToDouble(richTextBox1.Text);
                richTextBox1.ResetText();
                richTextBox1.SelectedText = Math.Sqrt(num).ToString("#.##");
            }

        }

        private void cut_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            if (text.Length > 0)
            {
                text = text.Substring(0, text.Length - 1);
                richTextBox1.ResetText();
                richTextBox1.SelectedText = text;
            }
            else
            {
                richTextBox1.ResetText();
            }



        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0 || Convert.ToDouble(richTextBox1.Text) % 1 == 0)
            {
                richTextBox1.SelectedText = ".";

            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                double num = Convert.ToDouble(richTextBox1.Text);
                richTextBox1.ResetText();
                richTextBox1.SelectedText = Convert.ToString(num * num * num);

            }

        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void equall_Click(object sender, EventArgs e)
        {

            string eval = "";
            switch (this.sign)
            {
                case '+':
                    textBox1.ResetText();
                    if (richTextBox1.Text.Length > 0)
                    {
                        this.num2 = Convert.ToDouble(richTextBox1.Text);

                    }
                    eval = Convert.ToString(this.num1 + this.num2);
                    richTextBox1.ResetText();
                    richTextBox1.SelectedText = eval;
                    textBox1.ResetText();
                    textBox1.SelectedText = Convert.ToString(this.num1) + " + " + Convert.ToString(this.num2) + " = " + eval;

                    break;
                case '-':
                    textBox1.ResetText();
                    if (richTextBox1.Text.Length > 0)
                    {
                        this.num2 = Convert.ToDouble(richTextBox1.Text);

                    }
                    eval = Convert.ToString(this.num1 - this.num2);
                    richTextBox1.ResetText();
                    richTextBox1.SelectedText = eval;
                    textBox1.ResetText();
                    textBox1.SelectedText = Convert.ToString(this.num1) + " - " + Convert.ToString(this.num2) + " = " + eval;
                    break;
                case '*':
                    textBox1.ResetText();
                    if (richTextBox1.Text.Length > 0)
                    {
                        this.num2 = Convert.ToDouble(richTextBox1.Text);

                    }
                    eval = Convert.ToString(this.num1 * this.num2);
                    richTextBox1.ResetText();
                    richTextBox1.SelectedText = eval;
                    textBox1.ResetText();
                    textBox1.SelectedText = Convert.ToString(this.num1) + " * " + Convert.ToString(this.num2) + " = " + eval;
                    break;
                case '/':

                    textBox1.ResetText();
                    if (richTextBox1.Text.Length > 0)
                    {
                        this.num2 = Convert.ToDouble(richTextBox1.Text);

                    }
                    eval = Convert.ToString((this.num1 / this.num2));
                    richTextBox1.ResetText();
                    richTextBox1.SelectedText = eval;
                    textBox1.ResetText();
                    textBox1.SelectedText = Convert.ToString(this.num1) + " / " + Convert.ToString(this.num2) + " = " + eval;
                    break;
            }

        }
    }
}