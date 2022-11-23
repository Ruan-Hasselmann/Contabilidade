CREATE DATABASE db_contabilidade;
USE db_contabilidade;


CREATE TABLE PRODUTOS
(
	idProduto integer not null primary key auto_increment,
	descricao varchar(50),
	margem double,
	qtdEstoque integer
);


CREATE TABLE MOVIMENTACOES
(
	idMov integer not null primary key auto_increment,
	operacao char(1),
	valor decimal(10,2),
	qtd integer,
	tipoPagamento char(1),
	fk_idProduto integer,
	foreign key (fk_idProduto) references PRODUTOS(idProduto)
);


INSERT INTO PRODUTOS(descricao, qtdEstoque) VALUES ('Lápis', 100);
INSERT INTO PRODUTOS(descricao, qtdEstoque) VALUES ('Borracha', 60);