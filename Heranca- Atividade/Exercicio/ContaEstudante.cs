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

        public override void Sacar(double valor5)
        {

            //double soma = SaldoConta + LimiteChequeEspecial;
            //if (valor5 <= soma)

            if (valor5 <= SaldoConta + LimiteChequeEspecial) //soma menor que o valor do sacar
            { 
                 SaldoConta -= valor5;
                //Console.WriteLine($"\nO saque de {sub} foi concluido com sucesso!\n");
            
            }
            else
            {
                Console.WriteLine($"\nNão foi possivel concluir este saque!");
            }

            
        }
    }
}
