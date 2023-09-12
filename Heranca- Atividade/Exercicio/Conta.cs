using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca__Atividade.Exercicio
{
    internal class Conta
    {
      public int NumeroConta { get; set; }
        public string Agencia { get; set; }
        public string TitularConta { get; set;}

        public double SaldoConta { get; set;}

        public virtual void Sacar()
        {
            Console.WriteLine("Digite o valor do saque: ");
            double saque = Convert.ToDouble(Console.ReadLine());

            if(saque <= SaldoConta) 
            {
                Console.WriteLine($"Saque de {saque} aprovado!");
            
            }
            else
            {
                Console.WriteLine($"Saldo não suficiente para saque!");
            }
        }
        public override void Depositar()
        {

            Console.WriteLine("Digite o valor para depositar: ");
            double depositar = Convert.ToDouble(Console.ReadLine());

            double soma = depositar + SaldoConta;
            Console.WriteLine($"Saldo atual: {soma}");
        }

    }
}
