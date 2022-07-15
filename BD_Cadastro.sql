/*Criando banco de dados*/
CREATE DATABASE BD_CADASTRO

/*Seleciona o banco de dados*/
USE BD_CADASTRO

/*Cria��o da tabela*/
CREATE TABLE CLIENTE(
	ID INT NOT NULL IDENTITY,
	NOME VARCHAR(100) NOT NULL,
	ENDERECO VARCHAR(100),
	CEP VARCHAR(9),
	BAIRRO VARCHAR(50),
	CIDADE VARCHAR(50),
	UF VARCHAR(2),
	TELEFONE VARCHAR(15),

	--Chave Prim�ria da tabela cliente
	CONSTRAINT PK_CLIENTE PRIMARY KEY(ID)
)

SELECT * FROM CLIENTE

UPDATE CLIENTE SET NOME='luana' where ID=4