-- OP READ - LER 
/*
SELECT * FROM Contas;
GO
*/

SELECT Id,Titular,Numero_da_conta,Saldo FROM Contas
WHERE Saldo > 1000;
GO

SELECT * FROM Contas 
WHERE TITULAR LIKE '%MARIA%';
GO