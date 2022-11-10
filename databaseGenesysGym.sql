create database GenesysGym;
use GenesysGym;

create table usuarios(
id_user int primary key auto_increment,
nome_user varchar (30),
username varchar (8) unique,
senha_user varchar (20),
status_user varchar (1),
nivel_user int
);
select * from usuarios; 


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
cep varchar (9),
telefone char (11),
email varchar (50)
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
cargo char (20) not null,
telefone char (11),
email varchar (50)
);
select * from funcionario;

create table treino(
cod_treino int auto_increment primary key,
grupoMuscular varchar (40),
descrição_exerc varchar (200),
qtde_series int,
qtde_reps int,
cod_cliente int not null,
codfuncionario int not null
);
select * from treino;

alter table treino
add constraint cod_cliente
foreign key (cod_cliente)
references cliente (cod_cliente);

alter table treino
add constraint codfuncionario
foreign key (codfuncionario)
references funcionario (codfuncionario);







