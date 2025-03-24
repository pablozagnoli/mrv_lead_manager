# Projeto Full Stack: API .NET + Angular

Este repositório contém dois projetos principais:
1. **API .NET 6**: Backend da aplicação.
2. **Angular Frontend**: Interface de usuário.

## Índice
1. [Pré-requisitos](#pré-requisitos)
2. [Como rodar a API .NET](#como-rodar-a-api-net)
3. [Como rodar o projeto Angular](#como-rodar-o-projeto-angular)

---

## Pré-requisitos

Antes de executar os projetos, certifique-se de ter instalado:

- **.NET 8 SDK**: [Download .NET SDK](https://dotnet.microsoft.com/download)
- **Node.js** (recomendado: v18 ou superior): [Download Node.js](https://nodejs.org/)
- **Angular CLI** (instale globalmente com o comando abaixo):
  ```bash
  npm install -g @angular/cli
Banco de Dados (opcional, dependendo da configuração da API).
Como rodar a API .NET
Clone o repositório:

bash
Copiar
Editar
git clone https://github.com/seu-usuario/seu-repositorio.git
cd seu-repositorio/api-dotnet
Restaurar os pacotes:

bash
Copiar
Editar
dotnet restore
Configurar o banco de dados (se necessário):

Verifique o arquivo appsettings.json para configurar a conexão com o banco de dados.
Executar as migrações (se houver):

bash
Copiar
Editar
dotnet ef database update
Rodar a API:

bash
Copiar
Editar
dotnet run
A API estará disponível em: http://localhost:5000

Como rodar o projeto Angular
Navegue até o diretório do frontend:

bash
Copiar
Editar
cd ../angular-frontend
Instalar as dependências:

bash
Copiar
Editar
npm install
Configurar o arquivo environment.ts:

Certifique-se de que o arquivo src/environments/environment.ts aponte para a URL correta da API (por padrão: http://localhost:5000).
Rodar o projeto Angular:

bash
Copiar
Editar
ng serve
O frontend estará disponível em: http://localhost:4200
