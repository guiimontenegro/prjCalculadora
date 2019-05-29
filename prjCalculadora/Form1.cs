using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCalculadora
{
    public partial class CalculadoraBasica : Form
    {
        public CalculadoraBasica()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            resultado = num1 - num2;
            txtResultado.Text = resultado.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            resultado = num1 * num2;
            txtResultado.Text = resultado.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            //declaração de variaveis do tipo double, num1, num2, resultado
            double num1, num2, resultado;
            /*num1 e num 2  recebe conteúdo do textbox(txtNum1.text e txtNum2.text) 
             * convert.tDouble é necessario para que seja convertido  o conteudo do
             * textbox para número. */
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            //Variavel resultado= recebe conteudo de num1 + num2 e realiza o calculo
            resultado = num1 + num2;
            //txtResultado.text = Recebe conteudo da variavel resultado e converte para num
            txtResultado.Text = resultado.ToString();
        }

        private void CalculadoraBasica_Load(object sender, EventArgs e)
        {

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            resultado = num1 / num2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResultado.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
