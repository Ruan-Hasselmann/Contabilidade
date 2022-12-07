CREATE DATABASE db_contabilidade;
USE db_contabilidade;


CREATE TABLE cliente
(
	idCliente integer not null primary key auto_increment,
    nomeCliente varchar(200) not null
);

CREATE TABLE FORNECEDOR
(
	idFornecedor integer not null primary key auto_increment,
	nomeFornecedor varchar(50)
);




INSERT INTO cliente(nomeCliente) VALUES ();



