using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca__Atividade.Exercicio
{
    internal class ContaEmpresarial: Conta
    {
        public double Anuidade { get; set; }
        public double LimiteEmprestimo { get; set; }
        public double TotalEmprestimo { get; set; }

        public ContaEmpresarial(double anuidade, double limiteEmprestimo, double totalEmprestimo, int numeroConta,
       string agencia, string titularConta, double saldoConta) : base(numeroConta, agencia, titularConta, saldoConta)
        {
            Anuidade = anuidade;
            LimiteEmprestimo = limiteEmprestimo;
            TotalEmprestimo = totalEmprestimo;
        }

        public void Emprestimo ()
        {
            Console.WriteLine("Digite o valor do saque: ");
            double saque = Convert.ToDouble(Console.ReadLine());
           

            if (saque <= SaldoConta)
            {
                double taxa = saque - Anuidade;
                Console.WriteLine($"Saque de {taxa} aprovado!");

            }
            else
            {
                Console.WriteLine($"Saldo não suficiente para saque!");
            }
        }
        public override void Sacar()
        {

        }

    }
}
