namespace SistemaPagamentos.UI
{
    public static class Menu
    {
        public static void ExibirMenu()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("***** Sistema de Processamento de Pagamentos *****");
            System.Console.WriteLine("********** Escolha a forma de pagamento **********");
            System.Console.WriteLine("1 - Cartão");
            System.Console.WriteLine("2 - Boleto");
            System.Console.WriteLine("3 - Sair");
            System.Console.Write("Escolha uma opção: ");
        }
    }
}
