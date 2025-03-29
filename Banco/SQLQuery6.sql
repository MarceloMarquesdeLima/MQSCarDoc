CREATE PROCEDURE sp_consultacliente
    @Nome VARCHAR(100)
AS
BEGIN
    -- Declara��es de in�cio da procedure
    SET NOCOUNT ON;

    -- Exemplo de opera��o
    SELECT *
    FROM Cliente
    WHERE ID = @Nome
    
    -- Outras opera��es podem ser adicionadas aqui
END;

--------------

CREATE PROCEDURE sp_consultafuncionario
    @Nome VARCHAR(100)
AS
BEGIN
    -- Declara��es de in�cio da procedure
    SET NOCOUNT ON;

    -- Exemplo de opera��o
    SELECT *
    FROM Funcionario
    WHERE ID = @Nome
    
    -- Outras opera��es podem ser adicionadas aqui
END;

--------------

CREATE PROCEDURE sp_consultafornecedor
    @Nome VARCHAR(100)
AS
BEGIN
    -- Declara��es de in�cio da procedure
    SET NOCOUNT ON;

    -- Exemplo de opera��o
    SELECT *
    FROM Fornecedor
    WHERE ID = @Nome
    
    -- Outras opera��es podem ser adicionadas aqui
END;