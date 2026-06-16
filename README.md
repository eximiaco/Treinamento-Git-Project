# Treinamento-Git-Project

API .NET mínima usada como apoio prático no treinamento **Git: do zero ao fluxo diário — Trilha 1**, ministrado por [EximiaCo](https://eximia.co) para o time de engenharia da Tramontina.

> O foco deste repositório é o **fluxo Git**, não o código C# — daí a simplicidade proposital.

## O que tem aqui

Uma Web API ASP.NET Core (.NET 9) com **um único endpoint**:

```
GET /hello
```

Que retorna:

```json
{
  "message": "Hello, World!",
  "project": "Treinamento-Git-Project",
  "track":   "Trilha 1 — Git: do zero ao fluxo diário"
}
```

## Como rodar

Pré-requisitos: [.NET SDK 9](https://dotnet.microsoft.com/download) instalado.

```bash
cd API.HelloWorld.Web
dotnet run
```

A API sobe em `http://localhost:5050/hello`.

## Como este repositório foi construído

Os commits foram feitos seguindo o **Lab A da Trilha 1**, em sequência didática. Use `git log --oneline` para vê-los — cada um é um marco do treinamento.

```
git log --oneline
```

## Estrutura

```
.
├── API.HelloWorld.Web/
│   ├── API.HelloWorld.Web.csproj
│   ├── Program.cs              # endpoint GET /hello
│   ├── appsettings.json
│   ├── appsettings.Development.json   # ignorado (segredos locais)
│   └── Properties/
│       └── launchSettings.json
├── .gitignore                  # template para projetos .NET
└── README.md                   # você está aqui
```

## Para os participantes do treinamento

Este repositório é a sua referência para refazer o Lab A em casa. Clone, apague o `.git/`, e refaça os passos do PDF de apoio para fixar o aprendizado.

```bash
git clone git@github.com:eximiaco/Treinamento-Git-Project.git
cd Treinamento-Git-Project
rm -rf .git
git init
# ... siga o roteiro do Lab A
```

## Contato

**Douglas Picolotto** · EximiaCo · douglas.picolotto@eximia.co
