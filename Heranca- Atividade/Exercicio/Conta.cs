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
                SaldoConta = SaldoConta - valor1;   
                Console.WriteLine($"\nSaque de {valor1} foi aprovado! \nSaldo total atual: {SaldoConta}\n");
            
            }
            else
            {
                Console.WriteLine($"\nNão é possivel fazer saque com este valor de saldo!\n");
            }
        }
        public void Depositar(double valor2)//depositar
        {

            if(valor2 >= 0)
            {
                SaldoConta += valor2;
                Console.WriteLine($"\nSaldo atual: {SaldoConta}\n");
            }
            else
            {
                Console.WriteLine("\nOperação inválida!\n");
            }
            
        }

    }
}
