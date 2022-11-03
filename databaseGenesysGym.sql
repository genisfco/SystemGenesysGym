create database GenesysGym;
use GenesysGym;
create table cliente(
codCliente int not null,
nmCliente varchar (300),
cpf varchar (15) not null,
rg varchar (12)not null,
sexo char (1),
dtMatricula datetime,
dtNascimento date,
logradouro varchar (150),
numLogradouro int,
bairro varchar (150),
cidade varchar (50),
estado char (2),
cep varchar (9)
);
select * from cliente;


create table funcionario(
codfuncionario int not null,
nome varchar (300) not null,
cpf varchar (15) not null,
rg varchar (12) not null,
sexo char (1),
dtMatricula datetime,
dtNascimento date,
logradouro varchar (150),
numLogradouro int,
bairro varchar (150),
cidade varchar (50),
estado char (2),
cep varchar (9),
cargo char (1) not null
);
select * from funcionario;

