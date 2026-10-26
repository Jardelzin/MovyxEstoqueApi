# 📦 Movyx Estoque API

API REST desenvolvida em **C# com .NET 8** para gerenciamento de estoque e controle de ativos de almoxarifado da Movyx.

O projeto tem como objetivo substituir o controle manual realizado em planilhas por uma solução baseada em banco de dados relacional, facilitando o registro, a consulta e o acompanhamento da movimentação de equipamentos, como rastreadores, câmeras e acessórios.

## 🚀 Tecnologias utilizadas

- **Linguagem:** C# 12
- **Framework:** .NET 8
- **Arquitetura:** API REST
- **ORM:** Entity Framework Core
- **Banco de dados:** PostgreSQL
- **Documentação e testes:** Swagger / OpenAPI
- **Versionamento:** Git e GitHub

## 📋 Funcionalidades

- Cadastro e gerenciamento de produtos.
- Controle de entrada e saída de equipamentos.
- Consulta de produtos e saldos de estoque.
- Registro de períodos de fechamento de estoque.
- Persistência de dados utilizando PostgreSQL.
- Documentação e testes dos endpoints por meio do Swagger.
  
## 🛠️ Pré-requisitos

Antes de executar a aplicação, certifique-se de ter instalado:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [PostgreSQL](https://www.postgresql.org/download/)
- [Git](https://git-scm.com/)
- Uma IDE ou editor de código, como [Visual Studio](https://visualstudio.microsoft.com/), [JetBrains Rider](https://www.jetbrains.com/rider/) ou [Visual Studio Code](https://code.visualstudio.com/).

**Opcional:** [DBeaver](https://dbeaver.io/) ou [pgAdmin](https://www.pgadmin.org/) para administrar o banco de dados.

## ⚙️ Configuração e execução

### 1. Clonar o repositório

Abra o terminal e execute:

```bash
git clone https://github.com/Jardelzin/MovyxEstoqueApi.git
cd MovyxEstoqueApi
```

### 2. Configurar o banco de dados

Certifique-se de que o PostgreSQL esteja em execução e crie um banco de dados vazio chamado `MovyxEstoqueDb`.

Em seguida, configure a connection string no arquivo `appsettings.json`, respeitando a estrutura já existente no projeto:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=MovyxEstoqueDb;Username=SEU_USUARIO;Password=SUA_SENHA"
  }
}
```

Substitua `SEU_USUARIO` e `SUA_SENHA` pelas credenciais do seu PostgreSQL.

**Importante:** não envie senhas, tokens ou outras credenciais reais para o GitHub. Para ambientes compartilhados ou de produção, prefira utilizar variáveis de ambiente ou o sistema de configuração segura da aplicação.

### 3. Instalar a ferramenta do Entity Framework Core

Caso ainda não tenha a ferramenta `dotnet-ef` instalada, execute:

```bash
dotnet tool install --global dotnet-ef --version 8.*
```

Se ela já estiver instalada, mas precisar ser atualizada, utilize:

```bash
dotnet tool update --global dotnet-ef --version 8.*
```

> Execute os comandos seguintes no diretório que contém o arquivo `.csproj` da API. Se o projeto utilizar uma estrutura com projetos separados para infraestrutura e inicialização, os comandos poderão precisar de parâmetros adicionais.

### 4. Restaurar as dependências

Execute:

```bash
dotnet restore
```

### 5. Aplicar as migrations

Para criar ou atualizar as tabelas do banco de dados conforme as migrations existentes, execute:

```bash
dotnet ef database update
```

Esse comando pressupõe que as migrations já foram criadas e que o Entity Framework Core está configurado corretamente para acessar o PostgreSQL.

### 6. Executar a aplicação

Inicie a API com:

```bash
dotnet run
```

O terminal exibirá os endereços HTTP e/ou HTTPS em que a aplicação está sendo executada.

## 📚 Documentação da API — Swagger

Com a aplicação em execução, acesse o endereço do Swagger informado pelo terminal, normalmente:

```text
https://localhost:<porta>/swagger
```

Substitua `<porta>` pela porta efetivamente exibida ao iniciar a aplicação.

Pela interface do Swagger, é possível consultar os endpoints disponíveis e executar requisições para testar as funcionalidades implementadas.

## 🗂️ Banco de dados

O PostgreSQL é utilizado para armazenar os dados da aplicação, enquanto o Entity Framework Core atua como ORM, permitindo mapear as entidades do C# para as tabelas relacionais.

As migrations permitem versionar as alterações no esquema do banco de dados e aplicá-las aos ambientes configurados.

## 🔒 Segurança e configuração

- Não versione credenciais reais ou informações sensíveis.
- Utilize configurações específicas para cada ambiente.
- Mantenha as dependências atualizadas.
- Restrinja o acesso ao banco de dados conforme as necessidades do ambiente.

## 👨‍💻 Autor

**Jardel Dias Martins Reyes**

[GitHub — Jardelzin](https://github.com/Jardelzin)

---

Desenvolvido como projeto de aplicação prática de desenvolvimento Back-End com C#, .NET, APIs REST, Entity Framework Core e PostgreSQL.
