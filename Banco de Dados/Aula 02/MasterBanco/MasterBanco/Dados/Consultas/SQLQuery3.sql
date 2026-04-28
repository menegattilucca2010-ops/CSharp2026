-- OP READ - LER 

SELECT * FROM Contas;
GO

SELECT Id,Titular,Numero_da_conta,Saldo FROM Contas
WHERE Saldo > 1000;
GO

SELECT * FROM Contas 
WHERE TITULAR LIKE '%MARIA%';
GO

SELECT * FROM Contas
WHERE Numero_da_conta = 1002
GO

-- Ordenar por saldo do MAIOR p/ MENOR
SELECT * FROM Contas
ORDER BY Saldo DESC
GO


-- Contar quantas contas existem na tabela
SELECT COUNT(*) AS TotalContas FROM Contas
GO

-- Ordenar por saldo do MENOR p/ MAIOR
SELECT * FROM Contas
ORDER BY Saldo ASC
GO

-- Soma todos Saldos das contas na tabela
SELECT SUM(Saldo) AS SaldoTotal FROM Contas 

-- Média de saldo nas contas
SELECT AVG(Saldo) AS MedidasSaldos FROM Contas
GO

