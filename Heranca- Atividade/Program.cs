using Heranca__Atividade.Exercicio;

public class Program 
{
    static void Main(string[] args)
    {


        Conta c= new Conta();
       c.NumeroConta = 1;
       c.Agencia = "1111";
       c.TitularConta = "Natalia";
        c.SaldoConta = 1000;
        c.Sacar();
        c.Depositar();

        ContaEmpresarial cEmp = new ContaEmpresarial();
        cEmp.NumeroConta = 2;
        cEmp.Agencia = "2222";
        cEmp.TitularConta = "Vinicius";
        cEmp.SaldoConta = 10000.00;
        cEmp.Anuidade = 5.00;
        cEmp.LimiteEmprestimo = 5000.00;
        cEmp.TotalEmprestimo = 200.00;
        cEmp.Emprestimo();
        cEmp.Sacar();

        ContaEstudante cEst = new ContaEstudante();
        cEst.NumeroConta = 3;
        cEst.Agencia = "3333";
        cEst.TitularConta = "Sthefany";
        cEst.SaldoConta = 200;
        cEst.LimiteChequeEspecial = 100;
        cEst.Cpf = "000.000.000-00";
        cEst.NomeInstituicao = "IFRO";
        cEst.Sacar();

        

    }



}

