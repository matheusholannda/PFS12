CREATE DATABASE SegPFS12;

USE SegPFS12;

CREATE TABLE Users(
Id INT PRIMARY KEY IDENTITY,
Email VARCHAR(100) UNIQUE NOT NULL,
[Password] VARCHAR(50) NOT NULL 
);

INSERT INTO Users VALUES('email@email.com','senha123');

SELECT * FROM Users;

SELECT Email, HASHBYTES('MD5', [Password]) AS 'Senha com Hash' FROM Users;

INSERT INTO Users VALUES('email2@email.com','senha1234');

SELECT Email, HASHBYTES('MD5', [Password]) AS 'Senha com Hash' FROM Users WHERE id=1;

SELECT Email, HASHBYTES('MD2', [Password]) AS 'Senha com Hash' FROM Users WHERE id=1;
SELECT Email, HASHBYTES('MD4', [Password]) AS 'Senha com Hash' FROM Users WHERE id=1;
SELECT Email, HASHBYTES('SHA', [Password]) AS 'Senha com Hash' FROM Users WHERE id=1;
SELECT Email, HASHBYTES('SHA1', [Password]) AS 'Senha com Hash' FROM Users WHERE id=1;
SELECT Email, HASHBYTES('SHA2_256', [Password]) AS 'Senha com Hash' FROM Users WHERE id=1;
SELECT Email, HASHBYTES('SHA2_512', [Password]) AS 'Senha com Hash' FROM Users WHERE id=1;

UPDATE Users SET [Password] = 'senha123' WHERE id=2;

SELECT Email, HASHBYTES('MD5', [Password]) AS 'Senha com Hash' FROM Users;
SELECT Email, PWDENCRYPT([Password]) AS 'Senha com Hash' FROM Users;