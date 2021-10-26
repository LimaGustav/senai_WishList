CREATE DATABASE WishList;
GO
 
USE WishList;
GO

CREATE TABLE Usuario (
idUsuario TINYINT PRIMARY KEY IDENTITY (1,1),
email VARCHAR (256) NOT NULL unique,
senha VARCHAR (50) NOT NULL
);
GO

CREATE TABLE Desejos (
idDesejo TINYINT PRIMARY KEY IDENTITY (1,1),
idUsuario TINYINT FOREIGN KEY REFERENCES USUARIO (idUsuario),
descricao VARCHAR (256) NOT NULL,
);
GO