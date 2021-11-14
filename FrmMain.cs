using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace SitemaBancario
{

    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAbrirConta_Click(object sender, EventArgs e)
        {
            var conta = new ContaC()
            {

                Numconta = txtNumeroC.Text


            };
            var cli = new Cliente()
            { Nome = txtNome.Text,
                CPF = txtCPF.Text,
                Conta = conta

            };
            StreamReader ab = File.OpenText(@"D:\\Users\JAmedeiros\Desktop\Num_Contas.txt");
            string input = ab.ReadToEnd();
            if (input.IndexOf(txtNumeroC.Text) < 0)
            
                Cliente.Contas.Conta.Add(cli); 
            else

                MessageBox.Show("Número de conta ja existente, tente outro");
            
            ab.Close();
            StreamWriter en = File.AppendText(@"D:\\Users\JAmedeiros\Desktop\Contas.txt");
            en.WriteLine("Foi criada uma conta do tipo {0} no nome de {1}, portador do CPF {2}, com a conta   número {3}",txtTipoConta.Text,txtNome.Text,txtCPF.Text,txtNumeroC.Text);
            en.WriteLine("-----------------------------------------//----------------------------------------//------------------------------------------------------------------------");
            en.Close();
            StreamWriter ac = File.AppendText(@"D:\\Users\JAmedeiros\Desktop\Num_Contas.txt");
            ac.WriteLine("Foi criada uma com o número {0}", txtNumeroC.Text);
            ac.WriteLine("-----------------------------------------//-----------------------");
            ac.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            var cli = Cliente.Contas.getClienteByNumConta(txtNumeroOP.Text);
            decimal valor = Convert.ToDecimal (txtValor.Text);
            cli.Conta.Saque(valor);
            StreamWriter en = File.AppendText(@"D:\\Users\JAmedeiros\Desktop\Contas.txt");
            en.WriteLine("Foi feito um saque no valor {0} reais , na conta de número {1}", valor, txtNumeroOP.Text);
            en.WriteLine("-------------------------------------------------------------------");
            en.Close();

        }

        private void txtNumeroOP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            var cli = Cliente.Contas.getClienteByNumConta(txtNumeroOP.Text);
            decimal valor = Convert.ToDecimal(txtValor.Text);
            cli.Conta.Depositar(valor);
            StreamWriter en = File.AppendText(@"D:\\Users\JAmedeiros\Desktop\Contas.txt");
            en.WriteLine("Foi feito um deposino no valor {0} reais , na conta de número {1}",valor, txtNumeroOP.Text);
            en.WriteLine("-------------------------------------------------------------------");
            en.Close();
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            var cli = Cliente.Contas.getClienteByNumConta(txtNumeroOP.Text);
            iblSaldo.Text =  cli.Conta.getSaldo().ToString() + " Reais";

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeroC_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }


}    

