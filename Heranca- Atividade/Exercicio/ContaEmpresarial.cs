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
        
        public ContaEmpresarial()
        {

        }
        public ContaEmpresarial(double anuidade, double limiteEmprestimo, double totalEmprestimo, int numeroConta,
       string agencia, string titularConta, double saldoConta) : base(numeroConta, agencia, titularConta, saldoConta)
        {
            Anuidade = anuidade;
            LimiteEmprestimo = limiteEmprestimo;
            TotalEmprestimo = totalEmprestimo;
           
        }

        public void Emprestimo () //feito
        {
            Console.WriteLine("Digite o valor do emprestimo: ");
            double emprestimo = Convert.ToDouble(Console.ReadLine());
          


            if (emprestimo <= LimiteEmprestimo) //menor ou igual a 5000 
            {

                if (SaldoConta >= emprestimo) 
                {
                    double a = emprestimo + TotalEmprestimo;
                    Console.WriteLine($"O valor de {a} foi realizado com sucessso!");

                }
                else
                {
                    Console.WriteLine("Saldo insuficiente para emprestimo!");
                }

            }
            else
            {
                Console.WriteLine("Não é possivel realizar o emprestimo requerido!");
            }
        }
        public override void Sacar() //feio //voltar aqui
        {
            Console.WriteLine("Digite o valor do saque: ");
            double saque = Convert.ToDouble(Console.ReadLine());

            if (saque <= SaldoConta)
            {
                if (saque >= LimiteEmprestimo) //5000.00
                {
                    double taxa = LimiteEmprestimo + Anuidade;
                    Console.WriteLine($"O saque de {taxa} foi concluido com sucesso!");

                }
                else
                {
                    Console.WriteLine($"O saque de {saque} foi concluido com sucesso!");
                }

            }
            else
            {
                Console.WriteLine("Não é possivel realizar o emprestimo requerido!");
            }
             
        }

    }
}
