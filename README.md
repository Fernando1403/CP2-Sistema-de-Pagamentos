# 💳 Sistema de Processamento de Pagamentos

Aplicação console em C# que simula um sistema de pagamentos, permitindo processar pagamentos via **Cartão** ou **Boleto** com exibição de confirmação ao final.

## 🚀 Como executar
```bash
dotnet run
```

## 🗂️ Estrutura do Projeto
```
SistemaPagamentos/
├── Program.cs
├── Models/
│   ├── Pagamento.cs         # Classe abstrata base
│   ├── PagamentoCartao.cs   # Pagamento via cartão
│   └── PagamentoBoleto.cs   # Pagamento via boleto
└── UI/
    └── Menu.cs              # Menu estático do console
```

## ✅ Pontos-chave
- **Herança e Polimorfismo:** `PagamentoCartao` e `PagamentoBoleto` herdam da classe abstrata `Pagamento`
- **Encapsulamento:** propriedades tipadas corretamente (`decimal` para valores monetários, `string` para identificadores)
- **Boas práticas:** classes organizadas em pastas por responsabilidade (`Models/`, `UI/`)
- **Robustez:** aceita vírgula e ponto como separador decimal na entrada de valores
