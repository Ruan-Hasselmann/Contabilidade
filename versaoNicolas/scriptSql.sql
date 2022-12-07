CREATE DATABASE db_contabilidade;
USE db_contabilidade;


CREATE TABLE PRODUTOS
(
    idProduto integer not null primary key auto_increment,
    descricao varchar(50),
    margem double,
    qtdEstoque integer
);

CREATE TABLE cliente
(
	idCliente integer not null primary key auto_increment,
    nomeCliente varchar(200) not null
);


CREATE TABLE MOVIMENTACOES
(
	idMov integer not null primary key auto_increment,
	operacao char(1),
	valor decimal(10,2),
	qtd integer,
	tipoPagamento INT NOT NULL,
	fk_idProduto integer,
	foreign key (fk_idProduto) references PRODUTOS(idProduto)
);


INSERT INTO PRODUTOS(descricao, qtdEstoque, margem) VALUES ('Lápis', 100, 10);
INSERT INTO PRODUTOS(descricao, qtdEstoque, margem) VALUES ('Borracha', 60, 10);


