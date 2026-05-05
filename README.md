# Paulino Lanches

## 📋 Descrição

Projeto de lanchonete desenvolvido em **ASP.NET MVC** com **Entity Framework Core** para gerenciar conexões com banco de dados e operações comerciais.

## 🛠️ Tecnologias Utilizadas

- **C#** (57.8%) - Linguagem principal do projeto
- **ASP.NET MVC** - Framework web
- **Entity Framework Core** - ORM para acesso a dados
- **HTML** (39.9%) - Marcação de páginas
- **CSS** (2.2%) - Estilização
- **JavaScript** (0.1%) - Interatividade

## 🎯 Funcionalidades

- Gerenciamento de produtos/lanches
- Controle de pedidos
- Integração com banco de dados via Entity Framework Core
- Interface web responsiva

## �� Como Usar

1. Clone o repositório:
```bash
git clone https://github.com/MateusPaulino13/Paulino-Lanches.git
```

2. Abra o projeto em sua IDE (Visual Studio ou Visual Studio Code)

3. Restaure as dependências do NuGet:
```bash
dotnet restore
```

4. Configure a string de conexão do banco de dados em `appsettings.json`

5. Execute as migrations do Entity Framework:
```bash
dotnet ef database update
```

6. Execute a aplicação:
```bash
dotnet run
```

## 📁 Estrutura do Projeto

```
Paulino-Lanches/
├── Controllers/      # Controladores MVC
├── Models/          # Modelos de dados
├── Views/           # Páginas HTML
├── Data/            # Contexto do Entity Framework
└── wwwroot/         # Arquivos estáticos (CSS, JS)
```

## 📝 Licença

Este projeto é de uso pessoal/educacional.

## 👨‍💻 Autor

[MateusPaulino13](https://github.com/MateusPaulino13)
