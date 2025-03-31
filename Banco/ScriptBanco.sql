CREATE DATABASE mqscardoc;

-- Seleciona o banco de dados criado
USE mqscardoc;

-- Tabela Endereco (chave primária: IdEndereco)
CREATE TABLE Endereco (
    IdEndereco INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Rua VARCHAR(50) NOT NULL,
    Complemento VARCHAR(50),
    Numero VARCHAR(10),
    Cidade VARCHAR(50),
    Estado VARCHAR(50)
);

-- Tabela Funcionario com chave estrangeira referenciando Endereco(IdEndereco)
CREATE TABLE Empresa (
    ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Endereco_ID INT,
    Nome VARCHAR(100),
    FOREIGN KEY (Endereco_ID) REFERENCES Endereco(IdEndereco) ON DELETE CASCADE
);

-- Tabela Cliente com chave estrangeira referenciando Endereco(IdEndereco)
CREATE TABLE Cliente (
    ID INT IDENTITY(1,1) PRIMARY KEY  NOT NULL,
    Endereco_ID INT,
    Nome VARCHAR(100)
    FOREIGN KEY (Endereco_ID) REFERENCES Endereco(IdEndereco) ON DELETE CASCADE
);

-- Tabela Fornecedor com chave estrangeira referenciando Endereco(IdEndereco)
CREATE TABLE Fornecedor (
    ID INT IDENTITY(1,1) PRIMARY KEY  NOT NULL,
    Endereco_ID INT,
    Nome VARCHAR(100),
    FOREIGN KEY (Endereco_ID) REFERENCES Endereco(IdEndereco) ON DELETE CASCADE
);
