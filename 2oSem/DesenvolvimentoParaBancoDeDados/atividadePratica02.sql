-- 1. Crie um BD com o nome Clinica
-- CREATE DATABASE dbClinica;

-- 2. Crie as seguintes tabelas neste BD, considerando que os atributos sublinhados são chaves primárias e os em itálico são chaves estrangeiras:

-- Ambultorios: nroa(int)(PK), andar(numeric(3))(não nulo), capacidade(smallint)
CREATE TABLE Ambulatorios(
    nroa int,
    andar numeric(3) NOT NULL,
    capacidade smallint,
    PRIMARY KEY (nroa)
);

-- Medicos: codm (int)(PK), nome (varchar(40)) (não nulo), idade (smallint) (não nulo), especialidade (char(20)), CPF (numeric(11)) (único), cidade (varchar(30)), nroa (int)(FK)
CREATE TABLE Medicos(
    codm int,
    nome varchar(40) NOT NULL,
    idade smallint NOT NULL,
    especialidade char(20),
    cpf numeric(11),
    cidade varchar(30),
    nroa int,
    PRIMARY KEY (codm),
    FOREIGN KEY (nroa) REFERENCES Ambulatorios (nroa),
    UNIQUE(cpf)
);

-- Pacientes: codp (int)(PK), nome (varchar(40)) (não nulo), idade (smallint) (não nulo), cidade (char(30)), CPF (numeric(11)) (único), doenca (varchar(40)) (não nulo)
CREATE TABLE Pacientes(
    codp int,
    nome varchar(40) NOT NULL,
    idade smallint NOT NULL,
    cidade char(30),
    cpf numeric(11),
    doenca varchar(40) NOT null,
    PRIMARY KEY (codp)
);

-- Funcionarios: codf (int)(PK), nome (varchar(40)) (não nulo), idade (smallint), CPF (numeric(11)) (único), cidade (varchar(30)), salario (numeric(10)), cargo (varchar(20))
CREATE TABLE Funcionarios(
    codf int,
    nome varchar(40) NOT NULL,
    idade smallint NOT NULL,
    cpf numeric(11),
    cidade varchar(30),
    salario numeric(10),
    cargo varchar(20),
    PRIMARY KEY (codf)
);

-- Consultas: codm (int)(PK, FK), codp (int)(FK), data (date)(PK), hora (time)(PK)
CREATE TABLE Consultas(
    codm int,
    codp int,
    dia date,
    hora time,
    PRIMARY KEY (codm, dia, hora),
    FOREIGN KEY (codm) REFERENCES Medicos(codm),
    FOREIGN KEY (codp) REFERENCES Pacientes(codp)
);

-- 3. Cria a coluna nroa (int) na tabela Funcionarios
ALTER TABLE Funcionarios ADD nroa int;

-- 4. Crie os seguintes índices:
-- Medicos: CPF(único)
CREATE UNIQUE INDEX idx_medcpf
ON Medicos (cpf);

-- Pacientes: doenca
CREATE INDEX idx_pacdoencas
ON Pacientes (doenca);

-- 5. Remover o índice doenca em Pacientes
ALTER TABLE Pacientes
DROP INDEX idx_pacdoencas;

-- 6. Remover as colunas cargo e nroa da tabela de Funcionarios
ALTER TABLE Funcionarios DROP COLUMN cargo;
alter table	Funcionarios drop column nroa;
