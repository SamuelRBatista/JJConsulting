# JJ Consulting - Prova Técnica ASP.NET Core MVC

Este projeto foi desenvolvido como parte da prova técnica para **Desenvolvedor Full Stack** na **JJ Consulting**.  
O objetivo é criar uma aplicação **ASP.NET Core MVC** que consome dados de uma API externa e exibe em uma interface web.

---

## 🛠️ Tecnologias Utilizadas
- [.NET 8](https://dotnet.microsoft.com/)  
- ASP.NET Core MVC  
- C#  
- HttpClient para consumo de API externa  
- Bootstrap 5 para estilização simples (opcional)

---

## 📌 Funcionalidades
- **Listagem de Usuários**: página inicial que exibe todos os usuários retornados da API externa.  
- **Detalhes de Usuário**: ao clicar em "Detalhes", o sistema exibe as informações individuais de cada usuário.  

---

## 📂 Estrutura do Projeto
JJConsulting
├── Controllers
│ └── UsersController.cs
├── Models
│ ├── Address.cs
│ ├── Company.cs
│ ├── Geo.cs
│ └── User.cs
├── Services
│ └── UserService.cs
├── Views
│ └── Users
│ ├── Index.cshtml
│ └── Details.cshtml
├── Program.cs
└── JJConsulting.csproj

---

## ⚙️ Como Executar

### 1. Clonar o repositório
```bash
git clone https://github.com/seu-usuario/jjconsulting-prova-tecnica.git
cd jjconsulting-prova-tecnica

dotnet restore

dotnet run
http://localhost:5000
