using System;
using System.Globalization;
using SistemaPagamentos.Models;
using SistemaPagamentos.UI;

namespace SistemaPagamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            do
            {
                Menu.ExibirMenu();
                opcao = Console.ReadLine()?.Trim();

                switch (opcao)
                {
                    case "1":
                        ProcessarCartao();
                        break;

                    case "2":
                        ProcessarBoleto();
                        break;

                    case "3":
                        Console.WriteLine("\nSaindo do sistema. Até logo!");
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida. Tente novamente.");
                        break;
                }

            } while (opcao != "3");
        }

        static decimal LerValor()
        {
            decimal valor;
            string entrada;

            do
            {
                Console.Write("Informe o valor do pagamento: R$ ");
                entrada = Console.ReadLine()?.Trim().Replace(",", ".");

            } while (!decimal.TryParse(entrada, NumberStyles.Any, CultureInfo.InvariantCulture, out valor) || valor <= 0);

            return valor;
        }

        static void ProcessarCartao()
        {
            Console.WriteLine("\n--- Pagamento com Cartão ---");
            decimal valor = LerValor();

            Console.Write("Informe o número do cartão: ");
            string numeroCartao = Console.ReadLine()?.Trim();

            PagamentoCartao pagamento = new PagamentoCartao(valor, numeroCartao);
            Console.WriteLine("\n" + pagamento.ProcessarPagamento());
        }

        static void ProcessarBoleto()
        {
            Console.WriteLine("\n--- Pagamento com Boleto ---");
            decimal valor = LerValor();

            Console.Write("Informe o código de barras: ");
            string codigoBarras = Console.ReadLine()?.Trim();

            PagamentoBoleto pagamento = new PagamentoBoleto(valor, codigoBarras);
            Console.WriteLine("\n" + pagamento.ProcessarPagamento());
        }
    }
}
