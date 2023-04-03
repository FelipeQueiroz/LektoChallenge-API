# API REST para gerenciamento de usuários e envio de mensagens de suporte

Essa API REST foi desenvolvida em C# .NET utilizando o framework .NET Core. A API permite o gerenciamento de usuários através de um CRUD (Create, Read, Update, Delete) e também permite o envio de mensagens de suporte. Com o objetivo de completar o desafio proposto pela empresa Lekto.

## Tecnologias utilizadas

- C# .NET
- MongoDB
- Swagger

## Como rodar o projeto

1. Clone o repositório em sua máquina local
```csharp
git clone https://github.com/FelipeQueiroz/LektoChallenge-API

```

2. Instale as dependências do projeto

```csharp
dotnet restore
```


3. Configure o banco de dados MongoDB

Crie um arquivo appsettings.json na raiz do projeto e adicione as informações do seu banco de dados. Exemplo:
```json
{
  "UserStoreDatabaseSettings": {
    "CollectionName": "users",
    "ConnectionString": "MONGODB_URL",
    "DatabaseName": "Users"
  },
  "MessageStoreDatabaseSettings": {
    "CollectionMessageName": "messages",
    "ConnectionString": "MONGODB_URL",
    "DatabaseName": "Messages"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}

```
Execute o projeto
```
dotnet run
````

A API estará disponível em http://localhost:5000/swagger/index.html.

## Endpoints

A documentação dos endpoints está disponível através do Swagger. Para acessar, abra a URL http://localhost:5000/swagger/index.html no seu navegador.

Os endpoints disponíveis são:

- GET /api/users
- GET /api/users/{id}
- POST /api/users
- PUT /api/users/{id}
- DELETE /api/users/{id}
- POST /api/Message

## Contribuições
Contribuições são sempre bem-vindas! Se você encontrou algum bug ou tem alguma sugestão de melhoria, por favor abra uma issue ou faça um pull request.

## Licença
Esse projeto está sob a licença MIT. Consulte o arquivo LICENSE para mais informações.
