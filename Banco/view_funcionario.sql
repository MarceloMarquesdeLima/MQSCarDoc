CREATE VIEW vwClientesAtivos AS
SELECT 
    ClienteID, 
    Nome, 
    Endereco, 
    Telefone
FROM 
    Clientes
WHERE 
    Status = 'Ativo'; -- Apenas clientes ativos.
