using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Objeto_For
{
    public class Conta
    {
        public int Numero { get; set; }
        public string NomedTitular{ get; set; }
        private double Saldo { get; set; }
        private int numero;
        public void Saca(double valor)
        {
            this.Saldo -= valor;
        }
        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
        public override string ToString()
        {
            return string.Format("O número da sua conta é {0}- nome do titular {1}- saldo em {2} reais",Numero,NomedTitular,Saldo);
        }
    }
    class ManipulacaoPrivado 
    { 
        static void Main(string[] args) 
        {
            var op = new Conta();
            double s = op.Saldo;
        }
        public double PegaSaldo()
        {
            return this.Saldo;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string nome;
            double sal;
            Console.WriteLine("Qual é o número da sua conta (tem seis digitos)?");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual é seu nome ?");
            nome = Console.ReadLine();
            Console.WriteLine("Qula é o valor inicial que você quer depositar?");
            sal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("De um apelido para a sua conta, o apelido e criado a parir do primeiro nomeseguido cos 3 primeiros digitos do cpf");
            StreamWriter en = File.AppendText(@"D:\\Users\JAmedeiros\Desktop\conta.txt");
            en.WriteLine("O número da conta é {0} - o nome do titular é {1} e o valor atual do seu saldo é {2} reais ", num,nome,sal);
            Conta primeiraconta_nome = new Conta
            {
                Numero = num,
                NomedTitular= nome,
                Saldo=sal,
            };

            en.Close();
            Console.WriteLine(primeiraconta_nome);
        }   

    }
}
    

