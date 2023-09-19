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
           
            if (valor3 <= LimiteEmprestimo - TotalEmprestimo)  
            {

                SaldoConta += valor3;
                valor3 += TotalEmprestimo;
                Console.WriteLine($"\nO valor de {SaldoConta} foi realizado com sucessso!\n");

            }
            else
            {
                Console.WriteLine("\nNão é possivel realizar o emprestimo requerido!\n");
            }
        }
        public override void Sacar(double valor4) //feio //voltar aqui
        {
         
            if (valor4 <= SaldoConta) //se o valor inserido for menor que o saldo da conta
            {
                if (valor4 >= 5000) //5000.00
                {
                    double taxa = 5;
                    SaldoConta -= valor4;
                    SaldoConta -= taxa;
                    Console.WriteLine($"\nO saque de {valor4} foi concluido com sucesso!\n Saldo Total: {SaldoConta}\n");

                }
                else
                {
                    double sub = SaldoConta - valor4;
                    Console.WriteLine($"\nO saque de {sub} foi concluido com sucesso!\n");
                }

            }
            else
            {
                Console.WriteLine("\nNão é possivel realizar o emprestimo requerido!\n");
            }
             
        }

    }
}
