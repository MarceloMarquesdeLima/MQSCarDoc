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
CREATE TABLE Usuario (
    ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Empresa_ID INT,
    UserName VARCHAR(100),
	SenhaUser VARCHAR(10), 
    FOREIGN KEY (Empresa_ID) REFERENCES Empresa(ID) ON DELETE CASCADE
);

CREATE TABLE Permissao (
    ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Empresa_ID INT,
    NomePermissao VARCHAR(100),
);

CREATE TABLE PermissaoUsuario (
    Usuario_ID INT,
    Permissao_ID INT,
	FOREIGN KEY (Usuario_ID) REFERENCES Usuario(ID) ON DELETE CASCADE,
	FOREIGN KEY (Permissao_ID) REFERENCES Permissao(ID) ON DELETE CASCADE
);

CREATE TABLE Marca (
    ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Usuario_ID INT,
    Nome VARCHAR(100),
    FOREIGN KEY (Usuario_ID) REFERENCES Usuario(ID) ON DELETE CASCADE
);

CREATE TABLE Modelo (
    ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Usuario_ID INT,
	Marca_ID INT,
    Nome VARCHAR(100),
	FOREIGN KEY (Marca_ID) REFERENCES Marca(ID) ON DELETE CASCADE
);

CREATE TABLE TipoProcesso (
    ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Nome VARCHAR(100)
);

use master