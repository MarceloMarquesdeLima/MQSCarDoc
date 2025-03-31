ALTER TABLE Cliente
ADD Ativo BIT;

ALTER TABLE Fornecedor
ADD Ativo BIT;

ALTER TABLE Funcionario
ADD Ativo BIT;

ALTER TABLE Empresa
ADD Ativo BIT;
ALTER TABLE Empresa
ADD Celular Varchar(20);
ALTER TABLE Empresa
ADD Telefone Varchar(20);
ALTER TABLE Empresa
ADD Email Varchar(100);

ALTER TABLE Cliente
ADD Celular Varchar(20);
ALTER TABLE Cliente
ADD Telefone Varchar(20);

ALTER TABLE Fornecedor
ADD Telefone Varchar(20);
ALTER TABLE Fornecedor
ADD Celular Varchar(20);

ALTER TABLE Funcionario
ADD Celular Varchar(20);
ALTER TABLE Funcionario
ADD Telefone Varchar(20);

ALTER TABLE Cliente
ADD Email Varchar(100);

ALTER TABLE Fornecedor
ADD Email Varchar(100);

ALTER TABLE Funcionario
ADD Email Varchar(100);