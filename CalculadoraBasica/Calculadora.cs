using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBasica
{
    public partial class Calculadora : Form
    {
        decimal valor1 = 0; 
        decimal valor2 = 0;
        string operacao = "";
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "9";
        }

        private void buttonPonto_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += ".";
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "") {
            valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
            textBoxResultado.Text = "";
            operacao = "SOMA";
            labelOperacao.Text = "+";
        } 
        else
        {
                MessageBox.Show("Informe um valor para efetuar a soma");
        }
    }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
                valor2 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
            if(operacao == "SOMA")
            {
               textBoxResultado.Text = Convert.ToString(valor1 + valor2);
            } else if(operacao == "SUBTRACAO")
            {
                textBoxResultado.Text = Convert.ToString(valor1 - valor2);
            } else if(operacao == "MULTIPLICACAO")
            {
                textBoxResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else
            {
                textBoxResultado.Text = Convert.ToString(valor1 / valor2);
            }
            }
            else
            {
                MessageBox.Show("Informe os valores antes");
            }
        }

        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
            textBoxResultado.Text = "";
            operacao = "SUBTRACAO";
            labelOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a subtração");
            }
        }

        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
            valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
            textBoxResultado.Text = "";
            operacao = "MULTIPLICACAO";
            labelOperacao.Text = "*";
            } 
            else
            {
                MessageBox.Show("Informe um valor para efetuar a multiplicação");
            }
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
            valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
            textBoxResultado.Text = "";
            operacao = "DIVISAO";
            labelOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a divisão");
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = "";
            labelOperacao.Text = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            labelOperacao.Text = "";
        }
    }
}
