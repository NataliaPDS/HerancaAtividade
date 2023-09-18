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

        public void Emprestimo (double valor3) //feito //emprestimo
        {
           
            if (valor3 <= LimiteEmprestimo - TotalEmprestimo) //menor ou igual a 5000 
            {

                SaldoConta += valor3;
                valor3 += TotalEmprestimo;
                    Console.WriteLine($"O valor de {SaldoConta} foi realizado com sucessso!");

            }
            else
            {
                Console.WriteLine("Não é possivel realizar o emprestimo requerido!");
            }
        }
        public override void Sacar(double valor4) //feio //voltar aqui
        {
         

            if (valor4 <= SaldoConta) //se o valor inserido for menor que o saldo da conta
            {
                if (valor4 >= LimiteEmprestimo) //5000.00
                {
                    double taxa = valor4 + 5;
                    double a = taxa - SaldoConta;
                    Console.WriteLine($"O saque de {a} foi concluido com sucesso!");

                }
                else
                {
                    double sub = SaldoConta - valor4;
                    Console.WriteLine($"O saque de {sub} foi concluido com sucesso!");
                }

            }
            else
            {
                Console.WriteLine("Não é possivel realizar o emprestimo requerido!");
            }
             
        }

    }
}
