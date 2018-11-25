using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        public Conta[] contas;
        private int numeroDeContas;

        public Form1()
        {
            InitializeComponent();
        }

        public void AdicionaConta(Conta conta)
        {
            this.contas[this.numeroDeContas] = conta;
            this.numeroDeContas++;
            comboContas.Items.Add("Titular: " + conta.Titular.Nome);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.contas = new Conta[10];

            Conta c1 = new ContaCorrente();
            c1.Titular = new Cliente("Vitor");
            c1.Numero = 1;
            this.AdicionaConta(c1);

            Conta c2 = new ContaPoupanca();
            c2.Titular = new Cliente("Matheus");
            c2.Numero = 2;
            AdicionaConta(c2);

            Conta c3 = new ContaCorrente();
            c3.Titular = new Cliente("Osnir");
            c3.Numero = 3;
            this.AdicionaConta(c3);

            
        }

        private void botaoDeposita_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];

            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);

            selecionada.Deposita(valorOperacao);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            MessageBox.Show("Deposito realizado com sucesso!!");
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta seleciona = contas[indice];

            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);

            seleciona.Saca(valorOperacao);
            textoSaldo.Text = Convert.ToString(seleciona.Saldo);
            MessageBox.Show("Saque efetuado com sucesso");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textoNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoBusca_click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(comboContas.Text);
            Conta selecionada = this.contas[indice];

            textoTitular.Text = selecionada.Titular.Nome;
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];

            textoTitular.Text = selecionada.Titular.Nome;
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();
        }

        private void botaoImpostos_Click(object sender, EventArgs e)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Deposita(200);

            MessageBox.Show("imposto da conta corrente = " + conta.CalculaTributos());
            ITributavel t = conta;

            MessageBox.Show("imposto da conta pela interface = " + t.CalculaTributos());

            SeguroDeVida sv = new SeguroDeVida();
            MessageBox.Show("Imposto pelo seguro = " + sv.CalculaTributos());

            t = sv;
            MessageBox.Show("imposto da conta pela interface = " + t.CalculaTributos());
        }

        private void textoSaldo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
