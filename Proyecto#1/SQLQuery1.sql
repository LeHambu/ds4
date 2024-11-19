create database Proyecto1;

use Proyecto1;

CREATE TABLE Calculos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Num1 FLOAT,
    Operador NVARCHAR(5),
    Num2 FLOAT,
    Resultado FLOAT
);

SELECT * FROM Calculos;


drop table Calculos;


