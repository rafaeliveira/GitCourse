using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNumConta = 0;
            int iOpcao = 0;
            string sNome = "";
            char cOpcao;
            double dValor = 0.0;

            Conta conta;

            Console.WriteLine("Cadastro de Contas:");
            Console.WriteLine();

            Console.Write("Entre com o nome do cliente: ");
            sNome = Console.ReadLine();
            Console.Write("Entre com o numero da conta: ");
            iNumConta = int.Parse(Console.ReadLine());
            Console.Write("Haverá depósito inicial (s/n)? ");
            cOpcao = char.Parse(Console.ReadLine());
            
            if(cOpcao == 's' || cOpcao == 'S')
            {
                Console.Write("Entre com o valor inicial de depósito: ");
                dValor = double.Parse(Console.ReadLine());

                conta = new Conta(sNome, iNumConta, dValor);
            }
            else
            {
                conta = new Conta(sNome, iNumConta);
            }
            
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.WriteLine("|-----------------------------|");
            Console.WriteLine("| Escolha a opção desejada:   |");
            Console.WriteLine("| 1 - Depósito                |");
            Console.WriteLine("| 2 - Saque                   |");
            Console.WriteLine("| 3 - Saldo Atualizado        |");
            Console.WriteLine("| 4 - Alterar Nome do titular |");
            Console.WriteLine("| 5 - Sair                    |");
            Console.WriteLine("|-----------------------------|");
            iOpcao = int.Parse(Console.ReadLine());

            if(iOpcao > 0 && iOpcao <= 5)
            {
                if (iOpcao == 1)
                {
                    Console.Write("Entre com o valor a ser depositado: ");
                    dValor = double.Parse(Console.ReadLine());
                    conta.Deposito(dValor);
                    Console.WriteLine(conta);
                }
                else if (iOpcao == 2)
                {
                    Console.Write("Entre com o valor a ser sacado: ");
                    dValor = double.Parse(Console.ReadLine());
                    conta.Saque(dValor);
                    Console.WriteLine(conta);
                }
                else if (iOpcao == 3)
                {
                    Console.WriteLine(conta);
                }
                else if (iOpcao == 4)
                {
                    Console.Write("Entre com o novo nome do cliente: ");
                    sNome = Console.ReadLine();
                    conta.NomeTitular = sNome;
                    Console.WriteLine(conta);
                }
                else if (iOpcao == 5)
                {
                    Console.WriteLine("Obrigado por usar nossos serviços!");
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Por favor escolha uma das opções acima!");
            }
        }
    }
}
