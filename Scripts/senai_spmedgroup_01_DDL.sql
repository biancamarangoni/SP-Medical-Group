CREATE DATABASE SP_MEDICAL_GROUP;
GO

USE SP_MEDICAL_GROUP

CREATE TABLE tipoUsuario(
	idTipoUsuario int primary key identity,
	tituloTipoUsuario varchar(30) UNIQUE NOT NULL
);
GO

CREATE TABLE Usuario(
	idUsuario int primary key identity,
	idTipoUsuario int foreign key references TipoUsuario(idTipoUsuario),
	nomeUsuario varchar(50) NOT NULL,
	email varchar(100) UNIQUE NOT NULL,
	senha varchar(15) NOT NULL,
);
GO

CREATE TABLE Endereco(
	idEndereco int primary key identity,
	CEP varchar(8) NOT NULL,
	estado varchar(30) NOT NULL,
	cidade varchar(50) NOT NULL,
	bairro varchar(50) NOT NULL,
	rua varchar(100) NOT NULL,
	numero varchar(200) NOT NULL,
);
GO

CREATE TABLE Paciente(
	idPaciente int primary key identity,
	idUsuario int foreign key references Usuario(idUsuario),
	idEndereco int foreign key references Endereco(idEndereco),
	nomePaciente varchar(100) NOT NULL,
	dataNascimento varchar(8) NOT NULL,
	telefone varchar(9) NOT NULL,
	RG varchar(10) UNIQUE NOT NULL,
	CPF varchar(11) UNIQUE NOT NULL,
);
GO

CREATE TABLE Clinica(
	idClinica int primary key identity,
	idEndereco int foreign key references Endereco(idEndereco),
	nomeFantasia varchar(100) NOT NULL,
	CNPJ varchar(14) NOT NULL,
	razaoSocial varchar(200) NOT NULL,
	horaAbertura varchar(4) NOT NULL,
	horaFechamento varchar(4) NOT NULL,
);
GO

CREATE TABLE Situacao(
	idSituacao int primary key identity,
	tipoStatus varchar(25) NOT NULL,
);
GO

CREATE TABLE Especialidade(
	idEspecialidade int primary key identity,
	nomeEspecialidade varchar(100) NOT NULL,
);
GO

CREATE TABLE Medico(
	idMedico int primary key identity,
	idUsuario int foreign key references Usuario(idUsuario),
	idClinica int foreign key references Clinica(idClinica),
	idEspecialidade int foreign key references Especialidade(idEspecialidade),
	nomeMedico varchar(100) NOT NULL,
);
GO

CREATE TABLE Consulta(
	idConsulta int primary key identity,
	idPaciente int foreign key references Paciente(idPaciente),
	idMedico int foreign key references Medico(idMedico),
	idSituacao int foreign key references Situacao(idSituacao),
	dataConsulta varchar(8) NOT NULL,
	descricaoConsulta varchar(200),
);
GO