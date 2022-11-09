CREATE DATABASE db_contabilidade;
USE db_contabilidade;
GO

CREATE TABLE PRODUTOS
(
	idProduto integer not null primary key identity,
	descricao varchar(50),
	qtdEstoque integer
)
GO

CREATE TABLE MOVIMENTACOES
(
	idMov integer not null primary key identity,
	operacao char(1),
	valor decimal(10,2),
	qtd integer,
	tipoPagamento char(1),
	fk_idProduto integer
	foreign key (fk_idProduto) references PRODUTOS(idProduto)
)
GO

INSERT INTO PRODUTOS(descricao, qtdEstoque) VALUES ('Lápis', 100);
INSERT INTO PRODUTOS(descricao, qtdEstoque) VALUES ('Borracha', 60);