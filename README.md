# Estudo MVC .NET Core

Este é um projeto de exemplo desenvolvido com ASP.NET Core MVC e Entity Framework, que visa demonstrar a implementação de um sistema de gerenciamento de produtos. O aplicativo permite realizar operações CRUD (Criar, Ler, Atualizar e Deletar) em uma lista de produtos, utilizando uma interface web interativa com AJAX para melhorar a experiência do usuário.

## Funcionalidades
- **Gerenciamento de Produtos**: Adicionar, editar, excluir e visualizar produtos através de uma interface amigável.
- **Interação Assíncrona**: Utilize AJAX para operações sem recarregar a página, proporcionando uma experiência mais fluida.
- **Estrutura MVC**: O projeto segue a arquitetura MVC, separando claramente a lógica de negócios (Services), a interação com a base de dados (Data) e a apresentação (Views).
- **Banco de Dados**: Utiliza o Entity Framework Core para manipulação de dados, com suporte ao SQL Server.

## Tecnologias Utilizadas
- **ASP.NET Core 6.0**: Framework para desenvolvimento de aplicações web.
- **Entity Framework Core**: ORM para facilitar a manipulação de dados no banco de dados.
- **HTML, CSS e JavaScript**: Para construção da interface do usuário.
- **AJAX**: Para requisições assíncronas e melhor interatividade.

## Estrutura do Projeto

Estudo_MVC
│
├── Controllers
│   └── ProdutoController.cs
│
├── Data
│   └── AppDbContext.cs
│
├── Interface
│   └── IProdutoService.cs
│
├── Models
│   └── Produto.cs
│
├── Services
│   └── ProdutoService.cs
│
└── Views
    └── Produto
        └── Index.cshtml
