using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Heranca__Atividade.Exercicio
{
    internal class ContaEstudante:Conta
    {
        public double LimiteChequeEspecial { get; set; }
        public string Cpf { get; set; }

        public string NomeInstituicao { get; set; }

        public ContaEstudante() 
        { 
        
        }
        public ContaEstudante(double limiteChequeEspecial, string cpf, string nomeInstituicao, int numeroConta,
            string agencia, string titularConta, double saldoConta):base(numeroConta, agencia, titularConta, saldoConta)
        {
            LimiteChequeEspecial = limiteChequeEspecial;
            Cpf = cpf;
            NomeInstituicao = nomeInstituicao;
        }

        public override void Sacar()
        {

            Console.WriteLine("Digite o valor do saque: ");
            double saque = Convert.ToDouble(Console.ReadLine());
            double soma = SaldoConta + LimiteChequeEspecial;

            if (soma <= saque)
            { 
               
            
            }

            
        }
    }
}
