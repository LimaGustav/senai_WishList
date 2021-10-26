USE WishList
GO

INSERT INTO Usuario (email, senha)
VALUES ('figueirapedro@gmail.com', 'pedro123'),('juliasilva@gmail.com', 'julia123'), ('gustavolima@gmail.com','gustavo123'),('pedrocabral@gmail.com', 'cabral123');
GO

INSERT INTO Desejos(descricao, idUsuario)
VALUES ('andar de costa',1), ('conhecer paises',2), ('entender calculo',3), ('ficar em casa',4);
go

