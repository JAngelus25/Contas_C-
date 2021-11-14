using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace SitemaBancario
{
    class Poupanca
    {
            public class ContaP //Conta Poupança
            {
                public virtual void Saque(decimal valor)
                {
                    if ((valor > 0) && (valor <=this._saldo) && (valor <= 250))


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
    
}
