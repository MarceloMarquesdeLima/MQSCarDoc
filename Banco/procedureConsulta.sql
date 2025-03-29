CREATE VIEW ConCliente AS
SELECT 
    ID, 
    Nome, 
    Celular, 
    Telefone
FROM 
    Cliente
WHERE 
    Ativo = 1; 
