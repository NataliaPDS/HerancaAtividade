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
        
        public Conta()
        {

        }
        public Conta(int numeroConta, string agencia, string titularConta, double saldoConta)
        {
            NumeroConta = numeroConta;
            Agencia = agencia;
            TitularConta = titularConta;
            SaldoConta = saldoConta;
        }   

        public virtual void Sacar(double valor1) //saque
        {
         

            if(valor1 <= SaldoConta) 
            {
                double sub = SaldoConta - valor1;   
                Console.WriteLine($"Saque de {sub} aprovado!");
            
            }
            else
            {
                Console.WriteLine($"Saldo não suficiente para saque!");
            }
        }
        public void Depositar(double valor2)//depositar
        {
            double soma = valor2 + SaldoConta;
            Console.WriteLine($"Saldo atual: {soma}");
        }

    }
}
