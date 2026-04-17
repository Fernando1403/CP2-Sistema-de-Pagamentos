using System;

namespace SistemaPagamentos.Models
{
    public abstract class Pagamento
    {
        public decimal Valor { get; set; }
        public DateTime DataPagamento { get; set; }

        protected Pagamento(decimal valor)
        {
            Valor = valor;
            DataPagamento = DateTime.Now;
        }

        public abstract string ProcessarPagamento();
    }
}
