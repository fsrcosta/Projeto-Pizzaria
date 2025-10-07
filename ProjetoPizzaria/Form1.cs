using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPizzaria
{
    public partial class Form1 : Form
    {

        // estanciando a classe conexao
        Conexao con = new Conexao();
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //vefifica os campos
            if (txtValorPizza.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValorPizza.Focus();
            }
            else if (txtValorOpcionais.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValorOpcionais.Focus();
            }
            else if (txtValorPagar.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValorPagar.Focus();
            }
            else
            {
                //tratamento de erros
                try
                {
                    //inserindo dados no banco de dados
                    string sql = "insert into tbPedido(tipoPizza,valorPizza,valorOpcao,valorTotal) values(@pizza,@vpizza,@vopcao,@total)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@pizza", MySqlDbType.Text).Value = cmbTamahoPizza.Text;
                    cmd.Parameters.Add("@vpizza", MySqlDbType.Text).Value = txtValorPizza.Text;
                    cmd.Parameters.Add("@vopcao", MySqlDbType.Text).Value = txtValorOpcionais.Text;
                    cmd.Parameters.Add("@total", MySqlDbType.Text).Value = txtValorPagar.Text;
                    cmd.ExecuteNonQuery();
                    // este comando executa ação
                    MessageBox.Show("Dados cadastrados com Sucesso !!!");
                    cmbTamahoPizza.Text = "";
                    txtValorPizza.Text = "";
                    txtValorOpcionais.Text = "";
                    txtValorPagar.Text = "";
                    cmbTamahoPizza.Focus();
                    con.DesConnectarBD();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }
    }
}

