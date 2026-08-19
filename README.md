# ApiProdutos

API REST desenvolvida em **ASP.NET Core** para cadastro e gerenciamento de produtos, com documentação interativa via **Swagger UI**. Projeto criado como atividade da disciplina de Tecnologia Avançada de Programação (Fatec Jales).

## 📋 Sobre o projeto

A ApiProdutos é uma API que permite listar, buscar, cadastrar, atualizar e excluir produtos, aplicando os conceitos de:

- Arquitetura em camadas (Controllers, DTOs, Models, Repositories)
- Validação de dados com Data Annotations
- Documentação automática dos endpoints via OpenAPI/Swagger
- Persistência dos dados em memória (sem banco de dados nesta etapa)

## 🚀 Tecnologias utilizadas

- **C#**
- **.NET 10 / ASP.NET Core Web API**
- **Swashbuckle.AspNetCore** (Swagger UI)
- **Data Annotations** para validação dos DTOs

## 🗂️ Estrutura do projeto

```
ApiProdutos/
├── Controllers/
│   └── ProdutosController.cs
├── DTOs/
│   ├── CriarProdutoDto.cs
│   └── AtualizarProdutoDto.cs
├── Models/
│   └── Produto.cs
├── Repositories/
│   └── ProdutoRepository.cs
├── Properties/
│   └── launchSettings.json
├── Program.cs
└── ApiProdutos.csproj
```

## ⚙️ Funcionalidades

- ✅ Listar todos os produtos
- ✅ Buscar produto por ID
- ✅ Cadastrar novo produto
- ✅ Atualizar produto existente
- ✅ Excluir produto
- ✅ Validação automática dos dados de entrada
- ✅ Documentação interativa via Swagger UI

> **Observação:** os dados são armazenados em memória (`List<Produto>`) e são perdidos ao encerrar a aplicação. Essa é uma etapa inicial do projeto, que futuramente pode evoluir para persistência com Entity Framework Core.

## 🔧 Como executar o projeto

1. Clone o repositório:
```bash
git clone https://github.com/guilhermezanardi07/ApiProdutos.git
```

2. Acesse a pasta do projeto:
```bash
cd ApiProdutos
```

3. Restaure as dependências:
```bash
dotnet restore
```

4. Compile o projeto:
```bash
dotnet build
```

5. Execute a aplicação:
```bash
dotnet run
```

6. Acesse a documentação interativa no navegador:
```
https://localhost:{porta}/swagger
```

## 📄 Endpoints

| Método | Rota | Descrição |
|--------|------|-----------|
| GET | `/api/produtos` | Lista todos os produtos |
| GET | `/api/produtos/{id}` | Busca um produto por ID |
| POST | `/api/produtos` | Cadastra um novo produto |
| PUT | `/api/produtos/{id}` | Atualiza um produto existente |
| DELETE | `/api/produtos/{id}` | Remove um produto |

## 📦 Exemplo de requisição (POST)

```json
{
  "nome": "Monitor",
  "descricao": "Monitor de 24 polegadas",
  "preco": 899.90,
  "quantidadeEstoque": 8
}
```

## 🧾 Códigos de resposta HTTP

| Código | Significado |
|--------|-------------|
| 200 OK | Consulta realizada com sucesso |
| 201 Created | Recurso criado com sucesso |
| 204 No Content | Operação concluída sem corpo de resposta |
| 400 Bad Request | Dados inválidos |
| 404 Not Found | Recurso não encontrado |

## 👤 Autor

Desenvolvido por **Guilherme Zanardi** — estudante de Análise e Desenvolvimento de Sistemas na Fatec Jales.

## 📝 Licença

Este projeto tem fins exclusivamente educacionais.
