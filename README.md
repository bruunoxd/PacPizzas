# 🍕 PacPizzas

Sistema de gerenciamento para pizzaria desenvolvido em **C# WinForms (.NET 4.8)** com banco de dados **MySQL**.

---

## 📋 Sobre o Projeto

O PacPizzas é um sistema desktop completo para gestão de pizzarias, cobrindo desde o cadastro de produtos e clientes até o controle de pedidos, entregas e geração de relatórios.

---

## ✨ Funcionalidades

| Módulo | Descrição |
|---|---|
| 🔐 Login | Autenticação de usuários com controle de acesso |
| 👥 Clientes | Cadastro e gerenciamento de clientes |
| 🧑‍💼 Funcionários | Cadastro e controle de funcionários |
| 👤 Usuários | Gerenciamento de usuários do sistema |
| 🍕 Produtos | Cadastro de pizzas e produtos com preços |
| 🛒 Pedidos | Registro e acompanhamento de pedidos (PDV) |
| 🚚 Entregas | Controle de entregas |
| 📊 Relatórios | Relatórios de pedidos e relatórios por período |

---

## 🏗️ Arquitetura

O projeto segue o padrão de **3 camadas**:

```
PacPizzas/
├── 01_Camada_Dados/         # Acesso a dados (conexão MySQL, DataSets)
├── 02_Camada_Negocio/       # Regras de negócio (classes de entidade)
└── 03_Camada_Interface/     # Formulários WinForms (UI)
```

---

## 🛠️ Tecnologias

- **Linguagem:** C# (.NET Framework 4.8)
- **Interface:** Windows Forms (WinForms)
- **Banco de Dados:** MySQL 8+ / 9+
- **Conector MySQL:** MySql.Data 8.4.0
- **Relatórios:** Microsoft ReportViewer 15.0 (RDLC)

---

## ⚙️ Pré-requisitos

- Windows 10/11
- [.NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48)
- [MySQL Server 8+](https://dev.mysql.com/downloads/mysql/)
- Visual Studio 2019 ou superior (para compilar)

---

## 🚀 Instalação e Configuração

### 1. Clone o repositório

```bash
git clone https://github.com/bruunoxd/PacPizzas.git
```

### 2. Configure o banco de dados

Acesse o MySQL e execute os comandos abaixo:

```sql
CREATE DATABASE PacPizzas;
USE PacPizzas;

CREATE TABLE funcionarios (
    idfuncionarios INT NOT NULL AUTO_INCREMENT,
    nomefuncionario VARCHAR(100),
    cpffuncionario VARCHAR(14),
    telefonefuncionario VARCHAR(15),
    PRIMARY KEY (idfuncionarios)
);

CREATE TABLE usuarios (
    idusuarios INT NOT NULL AUTO_INCREMENT,
    nomeusuario VARCHAR(100),
    logousuario VARCHAR(50),
    senhausuario VARCHAR(50),
    cpfusuario VARCHAR(14),
    PRIMARY KEY (idusuarios)
);

CREATE TABLE clientes (
    idclientes INT NOT NULL AUTO_INCREMENT,
    nomecliente VARCHAR(100),
    telefonecliente VARCHAR(15),
    enderecocliente VARCHAR(150),
    PRIMARY KEY (idclientes)
);

CREATE TABLE produtos (
    idprodutos INT NOT NULL AUTO_INCREMENT,
    nomeproduto VARCHAR(100),
    tipoproduto VARCHAR(50),
    valorproduto DECIMAL(10,2),
    PRIMARY KEY (idprodutos)
);

CREATE TABLE pedidos (
    idpedidos INT NOT NULL AUTO_INCREMENT,
    idcliente INT,
    idfuncionario INT,
    datapedido DATETIME,
    valorpedido DECIMAL(10,2),
    statuspedido VARCHAR(30),
    PRIMARY KEY (idpedidos)
);

CREATE TABLE itens (
    iditens INT NOT NULL AUTO_INCREMENT,
    idpedido INT,
    idproduto INT,
    quantidade INT,
    valoritem DECIMAL(10,2),
    PRIMARY KEY (iditens)
);

-- Usuário administrador padrão
INSERT INTO usuarios (nomeusuario, logousuario, senhausuario, cpfusuario)
VALUES ('Administrador', 'admin', 'admin', '000.000.000-00');
```

### 3. Ajuste a string de conexão

Edite o arquivo `01_Camada_Dados/clsConexaoBanco.cs` com as credenciais do seu MySQL:

```csharp
public static string conexaoMySQL = "Server=localhost; user id=root; password=SUA_SENHA; database=PacPizzas;";
```

### 4. Compile e execute

Abra `PacPizzas.sln` no Visual Studio e pressione **F5** para compilar e executar.

---


> ⚠️ Troque a senha após o primeiro acesso.

---

## 📁 Estrutura de Arquivos

```
PacPizzas/
├── 01_Camada_Dados/
│   ├── clsConexaoBanco.cs       # String de conexão MySQL
│   ├── clsPedidos.xsd           # Dataset de pedidos
│   └── dsPedidos.xsd            # Dataset relatórios
├── 02_Camada_Negocio/
│   ├── clsClientes.cs
│   ├── clsFuncionarios.cs
│   ├── clsUsuarios.cs
│   ├── clsProdutos.cs
│   ├── clsPedido.cs
│   ├── clsEntregas.cs
│   ├── clsRelatorio.cs
│   ├── clsRelatorioPeriodo.cs
│   ├── clsVisualizar.cs
│   ├── clsLogin.cs
│   └── RotinasGerais.cs
├── 03_Camada_Interface/
│   ├── frmLogin.cs
│   ├── frmMenu.cs
│   ├── frmClientes.cs
│   ├── frmFuncionarios.cs
│   ├── frmUsuarios.cs
│   ├── frmProdutos.cs
│   ├── frmPedido.cs
│   ├── frmEntregas.cs
│   ├── frmRelatorio.cs
│   ├── frmRelatorioPeriodo.cs
│   ├── frmVisualizar.cs
│   └── rptPedidos.rdlc          # Template de relatório
├── Properties/
├── App.config
├── Program.cs
└── PacPizzas.csproj
```

---

## 📄 Licença

Este projeto é de uso educacional.
