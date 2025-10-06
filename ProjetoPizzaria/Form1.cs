using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPizzaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTamahoPizza.Items.Add("Pequena- R$ 20,00");
            cmbTamahoPizza.Items.Add("Média- R$ 30,00");
            cmbTamahoPizza.Items.Add("Grande- R$ 50,00");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {


            //DECLARANDO AS VARIAVEIS
            double valorPizza = 0, valorOpcao = 0, valorTotal = 0;

            if (cmbTamahoPizza.SelectedIndex == 0)
            {
                valorPizza = 20;
            }
            else if (cmbTamahoPizza.SelectedIndex == 1)
            {
                valorPizza = 30;
            }
            else if (cmbTamahoPizza.SelectedIndex == 2)
            {
                valorPizza = 50;
            }
            if (chkBorda.Checked == true)
            {
                valorOpcao = valorOpcao + 5;
            }
            if (chkTempero.Checked == true)
            {
                valorOpcao = valorOpcao + 6;
            }
            if (chkCebola.Checked == true)
            {
                valorOpcao = valorOpcao + 3;
            }
            if (chkCatupiry.Checked == true)
            {
                valorOpcao = valorOpcao + 4;
            }
            else
            {

            }
            valorTotal = valorPizza + valorOpcao;
            txtValorPizza.Text = Convert.ToString(valorPizza);
            txtValorOpcionais.Text = Convert.ToString(valorOpcao);
            txtValorPagar.Text = Convert.ToString(valorTotal);
        }

    }
}

