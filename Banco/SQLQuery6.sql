CREATE PROCEDURE sp_consultacliente
    @Nome VARCHAR(100)
AS
BEGIN
    -- Declarações de início da procedure
    SET NOCOUNT ON;

    -- Exemplo de operação
    SELECT *
    FROM Cliente
    WHERE ID = @Nome
    
    -- Outras operações podem ser adicionadas aqui
END;

--------------

CREATE PROCEDURE sp_consultafuncionario
    @Nome VARCHAR(100)
AS
BEGIN
    -- Declarações de início da procedure
    SET NOCOUNT ON;

    -- Exemplo de operação
    SELECT *
    FROM Funcionario
    WHERE ID = @Nome
    
    -- Outras operações podem ser adicionadas aqui
END;

--------------

CREATE PROCEDURE sp_consultafornecedor
    @Nome VARCHAR(100)
AS
BEGIN
    -- Declarações de início da procedure
    SET NOCOUNT ON;

    -- Exemplo de operação
    SELECT *
    FROM Fornecedor
    WHERE ID = @Nome
    
    -- Outras operações podem ser adicionadas aqui
END;