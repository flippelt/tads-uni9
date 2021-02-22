#create database DBTabajara; #Criar um banco de dados

#use database DBTabajara; #define o banco de dados que será utilizado

#drop table TbCliente; #Excluir tabela

create table TbCliente #criar uma tabela
(
  id int(4) primary key AUTO_INCREMENT, #primary key define a chave primária
  nome varchar(50),             #auto_incrment adiciona 1 no campo anterior
  email varchar(50),
  cidade varchar(20)
);

INSERT INTO TbCliente #inserir dados na tabela
(nome, email, cidade) VALUES 
('Felipe', 'felipe@uni9.edu.br', 'São Paulo');

INSERT INTO TbCliente 
(nome, email, cidade) VALUES 
('Pedro', 'felipe@uni9.edu.br', 'São Paulo');

INSERT INTO TbCliente 
(nome, email, cidade) VALUES 
('Debora', 'de@uni9.edu.br', 'Cuiabá');

UPDATE tbcliente set email="teste@teste.com", cidade="Santo André" WHERE id=2 ;

DELETE FROM tbCliente WHERE id=1 or id=3;

#RENAME TABLE TBCLIENTE TO MEUS_CLIENTES;

ALTER TABLE TBCLIENTE ADD ESTADO CHAR(2) NOT NULL AFTER EMAIL;


DESCRIBE TBCLIENTE; 