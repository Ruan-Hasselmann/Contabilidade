DROP DATABASE db_contabilidade;

CREATE DATABASE db_contabilidade;
USE db_contabilidade;

CREATE TABLE PRODUTOS
(
	idProduto integer not null primary key auto_increment,
	descricao varchar(50),
	margem double,
	qtdEstoque integer
);

CREATE TABLE CLIENTE
(
	idCliente integer not null primary key auto_increment,
	nomeCliente varchar(50)
);

CREATE TABLE FORNECEDOR
(
	idFornecedor integer not null primary key auto_increment,
	nomeFornecedor varchar(50)
);


CREATE TABLE MOVIMENTACOES
(
	idMov integer not null primary key auto_increment,
	operacao char(1),
	valor decimal(10,2),
	qtd integer,
	tipoPagamento INT NOT NULL,
	fk_idProduto integer,
    fk_idCliente integer,
    fk_idFornecedor integer,
    parcelas INT DEFAULT 0,
	entrada INT DEFAULT 0,
    foreign key (fk_idProduto) references PRODUTOS(idProduto),
    foreign key (fk_idCliente) references CLIENTE(idCliente),
    foreign key (fk_idFornecedor) references FORNECEDOR(idFornecedor)
);

DROP VIEW IF EXISTS Geral;

CREATE VIEW Geral as 
SELECT 	MOV.idMov,
	MOV.operacao,
	MOV.valor,
	MOV.qtd,
	MOV.tipoPagamento,
	MOV.fk_idProduto,
    MOV.fk_idCliente,
    MOV.fk_idFornecedor,
	PRO.idProduto as idProduto,
	PRO.descricao as descricao_produto,
	CLI.idCliente as idCliente,
    CLI.nomeCliente as nome_cliente,
    FON.idFornecedor as idFornecedor,
    FON.nomeFornecedor as nome_fornecedor,
    MOV.parcelas,
	MOV.entrada,
    PRO.margem as margem
    FROM MOVIMENTACOES AS MOV 
		INNER JOIN PRODUTOS AS PRO
			ON MOV.fk_idProduto = PRO.idProduto
		LEFT JOIN CLIENTE AS CLI
			ON MOV.fk_idCliente = CLI.idCliente
		LEFT JOIN FORNECEDOR AS FON
			ON MOV.fk_idFornecedor = FON.idFornecedor;

INSERT INTO PRODUTOS(descricao, qtdEstoque, margem) VALUES ('Lápis', 100, 10);
INSERT INTO PRODUTOS(descricao, qtdEstoque, margem) VALUES ('Borracha', 60, 10);
select * from Geral;