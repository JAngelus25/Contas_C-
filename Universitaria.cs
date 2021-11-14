using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SitemaBancario
{
    class Universitaria
    {
        public class ContaU
        {
            public virtual void Saque(decimal valor)
            {
                if ((valor > 0) && (valor <=this._saldo)&&(valor<500))

                {
                    this._saldo = _saldo - valor;

                }
            }
            public string Numconta;
            public virtual void Depositar(decimal valor)
            {
                if (valor > 0)

                {
                    this._saldo = _saldo + valor;

                }
                else
                    MessageBox.Show("Saldo insuficiente !!");
            }
            private decimal _saldo = 0;
            public decimal getSaldo()
            {
                return this._saldo;

            }
        }
        public class Cliente
        {
            public string Nome;
            public string CPF;
            public ContaU Conta;

            public static class Contas
            {
                public static List<Cliente> Conta = new List<Cliente>();
                public static Cliente getClienteByNumConta(string numConta)
                {
                    Cliente ret = null;
                    foreach (var c in Conta)
                        if (c.Conta.Numconta == numConta)
                        {
                            ret = c;
                        }
                    return ret;
                }



            }
        }

    }
}
