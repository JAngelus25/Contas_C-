using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace SitemaBancario
{
    public class ContaC
    {
        public virtual void Saque(decimal valor)
        {
            if ((valor>0)&&(valor <=this._saldo))

            {
                this._saldo = _saldo - valor;

            }
            else
                MessageBox.Show("Saldo insuficiente");

        }
        public string Numconta;
        public virtual void Depositar(decimal valor)
        {
            if (valor > 0) 

            {
                this._saldo = _saldo + valor;

            }


        }
        private decimal _saldo =0;
        public decimal getSaldo()
        {
            return this._saldo;

        }
    }
    public class Cliente
    {
        public string Nome;
        public string CPF;
        public ContaC Conta;

        public static class Contas
        {
            public static List<Cliente> Conta = new List<Cliente>();
            public static Cliente getClienteByNumConta(string numConta)
            {
                Cliente ret = null;
                foreach (var a in Conta)
                    if (a.Conta.Numconta == numConta)
                    {
                        ret = a;
                    }
                return ret;
            }



        }
    }

    public class ContaP //Conta Poupança
    {
        public virtual void Saque(decimal valor)
        {
            if ((valor > 0) && (valor < +this._saldo) && (valor <= 250))


                this._saldo = _saldo - valor;


            else

                MessageBox.Show("O valor do saque é superior ao valor atual do saldo ou ultrapassa 250 R$ ");
        }    
        public string Numconta;
        public virtual void Depositar(decimal valor)
        {
            if (valor > 0)

            {
                this._saldo = _saldo + valor;

            }


        }
        private decimal _saldo = 0;
        public decimal getSaldo()
        {
            return this._saldo;

        }
    }
}