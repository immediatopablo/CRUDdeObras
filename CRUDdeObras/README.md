# CRUD de Obras – ASP.NET WebForms + VB.NET + SQL Server LocalDB

Este é um projeto de exemplo para demonstrar o uso de ASP.NET WebForms com VB.NET, ADO.NET e banco de dados SQL Server LocalDB para gerenciar obras (CRUD).

## 📌 Tecnologias usadas

- ASP.NET WebForms (.NET Framework)
- VB.NET
- SQL Server LocalDB
- ADO.NET
- Visual Studio 2022

## ⚙️ Funcionalidades

- Listagem de obras em um GridView
- Integração com SQL Server via ADO.NET
- Leitura de dados de uma tabela `Obras`
- Projeto simples com foco em aprendizado e entrevistas técnicas

## 🧱 Estrutura da Tabela SQL

```sql
CREATE TABLE Obras (
    Id INT NOT NULL PRIMARY KEY IDENTITY,
    DescricaoObra VARCHAR(70) NOT NULL,
    Endereco VARCHAR(70) NOT NULL,
    DataInicio DATE NOT NULL
);
