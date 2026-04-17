# 💳 Sistema de Processamento de Pagamentos

Aplicação console em C# que simula um sistema de pagamentos, permitindo processar pagamentos via **Cartão** ou **Boleto** com exibição de confirmação ao final.

## Integrantes
- Fernando Gonzales Alexandre — RM: 555045
- Gabriel Guerreiro - RM: 554973
- Lucas Dias - RM: 555450
- Luiz Felipe Coelho - RM: 555074
- Vitor Musolino - RM: 555012

## 🗂️ Estrutura do Projeto
```
SistemaPagamentos/
├── Program.cs
├── Models/
│   ├── Pagamento.cs         
│   ├── PagamentoCartao.cs   
│   └── PagamentoBoleto.cs   
└── UI/
    └── Menu.cs              
```

## ✅ Pontos-chave
- **Herança e Polimorfismo:** `PagamentoCartao` e `PagamentoBoleto` herdam da classe abstrata `Pagamento`
- **Encapsulamento:** propriedades tipadas corretamente (`decimal` para valores monetários, `string` para identificadores)
- **Boas práticas:** classes organizadas em pastas por responsabilidade (`Models/`, `UI/`)
- **Robustez:** aceita vírgula e ponto como separador decimal na entrada de valores

## Prints
-<img width="1471" height="678" alt="image" src="https://github.com/user-attachments/assets/dd67b456-8e49-4ab8-b21a-6203d5b55985" />
