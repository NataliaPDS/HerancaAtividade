using Heranca__Atividade.Exercicio;

public class Program 
{
    static void Main(string[] args)
    {
        while (true) 
        
        {
           

            try 
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Conta");
                Console.WriteLine("2 - Conta Empresarial");
                Console.WriteLine("3 - Conta Estudante");
                Console.WriteLine("Digite o número da opção: ");
                int opcao = Convert.ToInt32(Console.ReadLine());
                
                if (opcao == 1)
                {
                    Conta c = new Conta();
                    c.NumeroConta = 1;
                    c.Agencia = "1111";
                    c.TitularConta = "Natalia";
                    c.SaldoConta = 1000;
                    Console.WriteLine("\nDigite o valor do saque: \n");
                    double valor1 = Convert.ToDouble(Console.ReadLine());
                    c.Sacar(valor1);
                    Console.WriteLine("\nDigite o valor que deseja depositar: \n");
                    double valor2 = Convert.ToDouble(Console.ReadLine());
                    c.Depositar(valor2);
                }
                else if (opcao == 2)
                {
                    ContaEmpresarial cEmp = new ContaEmpresarial();
                    cEmp.NumeroConta = 2;
                    cEmp.Agencia = "2222";
                    cEmp.TitularConta = "Vinicius";
                    cEmp.SaldoConta = 10000.00;
                    cEmp.Anuidade = 5.00;
                    cEmp.LimiteEmprestimo = 5000.00;
                    cEmp.TotalEmprestimo = 200.00;

                    

                    Console.WriteLine("\nDigite o valor do emprestimo: \n");
                    double valor3 = Convert.ToDouble(Console.ReadLine());
                    cEmp.Emprestimo(valor3);
                    Console.WriteLine("\nDigite o valor do saque: \n");
                    double valor4 = Convert.ToDouble(Console.ReadLine());
                    cEmp.Sacar(valor4);

                }
                else if (opcao == 3)
                {
                    ContaEstudante cEst = new ContaEstudante();
                    cEst.NumeroConta = 3;
                    cEst.Agencia = "3333";
                    cEst.TitularConta = "Sthefany";
                    cEst.SaldoConta = 200;
                    cEst.LimiteChequeEspecial = 100;
                    cEst.Cpf = "000.000.000-00";
                    cEst.NomeInstituicao = "IFRO";

                    Console.WriteLine("\nDigite o valor do saque: \n");
                    double valor5 = Convert.ToDouble(Console.ReadLine());
                    cEst.Sacar(valor5);

                }
            }
            catch (Exception)
            { 
                Console.WriteLine("erro");
            }
            finally 
            {
                Console.WriteLine("Tchau");
                    
                    
            }


        }

    }



}

